using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    General options:
    -v <verbosity> Verbosity level (0-4).

    FBX file options:
      -i <id> Filter by node ID.
      -t Write text/xml.
      -g:auto Automatically group animation channels into a new animation.
      -g:none Do not prompt to group animations.
      -g <node id> <animation id>
         Group all animation channels targeting the nodes into a
         new animation.
      -m Output material file for scene.
      -tb <node id>
         Generates tangents and binormals for the given node
      -oa 
         Optimizes animations by analyzing animation channel data and
         removing any channels that contain default/identity values
         and removing any duplicate contiguous keyframes, which are
         common when exporting baked animation data.
      -h <size> "<node ids>" <filename>
         Generates a single heightmap image using meshes from the
         specified nodes.
         <size> is two comma-separated numbers in the format "X,Y",
         indicating the dimensions of the produced heightmap image.
         <node ids> should be in quotes with a space between each id.
         Filename is the name of the image (PNG) to be saved.
         Multiple -h arguments can be supplied to generate more than one
         heightmap. For 24-bit packed height data use -hp instead of -h.

    Normal map options:
         -n Generate normal map (requires input file of type PNG or RAW)
         -s Size/resolution of the input heightmap image (required for RAW files)
         -w <size> Specifies the size of an input terrain heightmap file in world
         units, along the X, Y and Z axes. <size> should be three
         comma-separated numbers in the format "X,Y,Z".
         The Y value represents the maximum possible height value of a
         full intensity heightmap pixel.
        
         Normal map generation can be used to create object-space normal maps from
         heightmap images. Heightmaps must be in either PNG format (where the
         intensity of each pixel represents a height value), or in RAW format
         (8 or 16-bit), which is a common headerless format supported by most
         terrain generation tools.

    TTF file options:
      -s <sizes> Comma-separated list of font sizes (in pixels).
      -p Output font preview.
      -f Format of font. -f:b (BITMAP), -f:d (DISTANCE_FIELD).
 
 
 */




namespace GPBinUtilGUI
{
    public partial class MainWindow : Form
    {
        Process cmdProcess = new Process();
        
        public MainWindow()
        {
            InitializeComponent();
            comboBoxFontFormat.SelectedIndex = 0;
            cmdProcess.StartInfo.UseShellExecute = false;
            cmdProcess.StartInfo.RedirectStandardError = true;
            cmdProcess.StartInfo.RedirectStandardInput = true;
            cmdProcess.StartInfo.RedirectStandardOutput = true;
        }


        //event handlers
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listBoxJobs.Items.Count != 0) //TODO apply this when using close button
            {
                if(MessageBox.Show("There are jobs in the list which will be lost!", "WARNING", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            this.Close();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "mesh scenes|*.fbx|truetype font|*.ttf";//|heightmap file|*.png";
            if(od.ShowDialog() == DialogResult.OK)
            {
                textBoxFileIn.Text = od.FileName;
                switch(System.IO.Path.GetExtension(od.FileName))
                {
                    case ".fbx":
                        tabControl1.SelectedIndex = 0;
                        ((Control)tabPageFbx).Enabled = true;
                        ((Control)tabPageFont).Enabled = false;
                        ((Control)tabPageNormalMap).Enabled = false;
                        break;
                    case ".ttf":
                        tabControl1.SelectedIndex = 1;
                        ((Control)tabPageFbx).Enabled = false;
                        ((Control)tabPageFont).Enabled = true;
                        ((Control)tabPageNormalMap).Enabled = false;
                        break;
                    case ".png":
                        tabControl1.SelectedIndex = 2;
                        ((Control)tabPageFbx).Enabled = false;
                        ((Control)tabPageFont).Enabled = false;
                        ((Control)tabPageNormalMap).Enabled = true;
                        break;
                }
            }
        }

        private void buttonAddJob_Click(object sender, EventArgs e)
        {
            if(textBoxFileIn.Text != string.Empty)
            {
                string cmd = "";
                switch(tabControl1.SelectedIndex)
                {
                    case 0: //fbx
                        if (checkBoxNodeID.Checked) cmd += "-i " + numericUpDownNodeID.Value.ToString() + " ";
                        if (checkBoxSceneMaterial.Checked) cmd += "-m ";
                        if (checkBoxTanBitan.Checked) cmd += "-tb " + numericUpDownTanBitan.Value.ToString() + " ";
                        break;
                    case 1: //ttf
                        //validate textbox input
                        if (textBoxFontSizes.Text == string.Empty) return;
                        foreach(char c in textBoxFontSizes.Text)
                        {
                            if (!Char.IsNumber(c) && c != ',')
                                return;
                        }
                        cmd = "-s " + textBoxFontSizes.Text;
                        cmd += (comboBoxFontFormat.SelectedIndex == 0) ? " -f:b " : " -f:d ";
                        if (checkBoxFontPreview.Checked) cmd += "-p ";
                        break;
                    case 2: //png
                        cmd = "-n ";
                        break;
                }
                cmd += "\"" + textBoxFileIn.Text + "\"";
                listBoxJobs.Items.Add(cmd);
            }
        }

        private void enableLoggingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enableLoggingToolStripMenuItem.Checked = !enableLoggingToolStripMenuItem.Checked;
        }

        private void buttonRemoveJob_Click(object sender, EventArgs e)
        {
            if(listBoxJobs.SelectedIndex > -1)
                listBoxJobs.Items.RemoveAt(listBoxJobs.SelectedIndex);
        }

        private void buttonEncode_Click(object sender, EventArgs e)
        {
            if(listBoxJobs.Items.Count > 0)
            {
                //check exe is in in same directory
                string path = Application.StartupPath + "\\gameplay-encoder.exe";

                if (!System.IO.File.Exists(path))
                {
                    MessageBox.Show("gameplay-encoder.exe not found.\r\nPlease make sure it exists in the same directory as GPBinUtilGUI.exe", "Error");
                    return;
                }
                cmdProcess.StartInfo.FileName = path;
               
                //if logging enabled we can output this to a text file
                StringBuilder consoleOutput = new StringBuilder();
                consoleOutput.Append("\r\nJob started: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\r\n");
                consoleOutput.Append("-----------------------------\r\n\r\n");

                foreach(string cmd in listBoxJobs.Items)
                {
                    cmdProcess.StartInfo.Arguments = cmd;
                    cmdProcess.Start();
                    consoleOutput.Append(cmdProcess.StandardOutput.ReadToEnd() + "\n" + cmdProcess.StandardError.ReadToEnd());
                    cmdProcess.WaitForExit();
                    cmdProcess.Close();
                }

                if(enableLoggingToolStripMenuItem.Checked)
                {
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(Application.StartupPath + "\\logfile.txt", true);
                    sw.Write(consoleOutput.ToString());
                    sw.Close();
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (listBoxJobs.Items.Count > 0) listBoxJobs.Items.Clear();
        }
    }
}
