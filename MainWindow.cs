using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
      -h <size> \"<node ids>\" <filename>
         Generates a single heightmap image using meshes from the
         specified nodes.
         <size> is two comma-separated numbers in the format \"X,Y\",
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
         comma-separated numbers in the format \"X,Y,Z\".
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
        bool m_loggingEnabled = false;
           
        public MainWindow()
        {
            InitializeComponent();
            comboBoxFontFormat.SelectedIndex = 0;
        }


        //event handlers
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(textBoxJobList.Text != string.Empty) //TODO apply this when using close button
            {
                if(MessageBox.Show("There are pending jobs which will be lost!", "WARNING", MessageBoxButtons.OKCancel) == DialogResult.OK)
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
            od.Filter = "mesh scenes|*.fbx|truetype font|*.ttf|heightmap file|*.png";
            if(od.ShowDialog() == DialogResult.OK)
            {
                textBoxFileIn.Text = od.FileName;
                //TODO switch to and lock tab for file extension
            }
        }
    }
}
