namespace GPBinUtilGUI
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableLoggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFileIn = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFbx = new System.Windows.Forms.TabPage();
            this.textBoxBitan = new System.Windows.Forms.TextBox();
            this.textBoxOnlyNode = new System.Windows.Forms.TextBox();
            this.checkBoxTanBitan = new System.Windows.Forms.CheckBox();
            this.checkBoxSceneMaterial = new System.Windows.Forms.CheckBox();
            this.checkBoxNodeID = new System.Windows.Forms.CheckBox();
            this.tabPageFont = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxFontFormat = new System.Windows.Forms.ComboBox();
            this.checkBoxFontPreview = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFontSizes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageNormalMap = new System.Windows.Forms.TabPage();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.buttonAddJob = new System.Windows.Forms.Button();
            this.buttonRemoveJob = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxJobs = new System.Windows.Forms.ListBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxConsoleOutput = new System.Windows.Forms.TextBox();
            this.textBoxConsoleInput = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxGroupAnim = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageFbx.SuspendLayout();
            this.tabPageFont.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(509, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableLoggingToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // enableLoggingToolStripMenuItem
            // 
            this.enableLoggingToolStripMenuItem.Checked = true;
            this.enableLoggingToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableLoggingToolStripMenuItem.Name = "enableLoggingToolStripMenuItem";
            this.enableLoggingToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.enableLoggingToolStripMenuItem.Text = "Enable Logging";
            this.enableLoggingToolStripMenuItem.Click += new System.EventHandler(this.enableLoggingToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input:";
            // 
            // textBoxFileIn
            // 
            this.textBoxFileIn.Location = new System.Drawing.Point(53, 27);
            this.textBoxFileIn.Name = "textBoxFileIn";
            this.textBoxFileIn.ReadOnly = true;
            this.textBoxFileIn.Size = new System.Drawing.Size(363, 20);
            this.textBoxFileIn.TabIndex = 2;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(422, 25);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 3;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageFbx);
            this.tabControl1.Controls.Add(this.tabPageFont);
            this.tabControl1.Controls.Add(this.tabPageNormalMap);
            this.tabControl1.Location = new System.Drawing.Point(12, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(485, 139);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPageFbx
            // 
            this.tabPageFbx.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageFbx.Controls.Add(this.checkBoxGroupAnim);
            this.tabPageFbx.Controls.Add(this.textBoxBitan);
            this.tabPageFbx.Controls.Add(this.textBoxOnlyNode);
            this.tabPageFbx.Controls.Add(this.checkBoxTanBitan);
            this.tabPageFbx.Controls.Add(this.checkBoxSceneMaterial);
            this.tabPageFbx.Controls.Add(this.checkBoxNodeID);
            this.tabPageFbx.Location = new System.Drawing.Point(4, 22);
            this.tabPageFbx.Name = "tabPageFbx";
            this.tabPageFbx.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFbx.Size = new System.Drawing.Size(477, 113);
            this.tabPageFbx.TabIndex = 0;
            this.tabPageFbx.Text = "FBX Options";
            // 
            // textBoxBitan
            // 
            this.textBoxBitan.Location = new System.Drawing.Point(238, 53);
            this.textBoxBitan.Name = "textBoxBitan";
            this.textBoxBitan.Size = new System.Drawing.Size(162, 20);
            this.textBoxBitan.TabIndex = 13;
            // 
            // textBoxOnlyNode
            // 
            this.textBoxOnlyNode.Location = new System.Drawing.Point(238, 7);
            this.textBoxOnlyNode.Name = "textBoxOnlyNode";
            this.textBoxOnlyNode.Size = new System.Drawing.Size(162, 20);
            this.textBoxOnlyNode.TabIndex = 12;
            // 
            // checkBoxTanBitan
            // 
            this.checkBoxTanBitan.AutoSize = true;
            this.checkBoxTanBitan.Location = new System.Drawing.Point(7, 55);
            this.checkBoxTanBitan.Name = "checkBoxTanBitan";
            this.checkBoxTanBitan.Size = new System.Drawing.Size(225, 17);
            this.checkBoxTanBitan.TabIndex = 3;
            this.checkBoxTanBitan.Text = "Generate Tan Space Normals for Node(s):";
            this.toolTip1.SetToolTip(this.checkBoxTanBitan, "Comma Separated list of node IDs\r\nlike,this,for,example");
            this.checkBoxTanBitan.UseVisualStyleBackColor = true;
            // 
            // checkBoxSceneMaterial
            // 
            this.checkBoxSceneMaterial.AutoSize = true;
            this.checkBoxSceneMaterial.Location = new System.Drawing.Point(7, 31);
            this.checkBoxSceneMaterial.Name = "checkBoxSceneMaterial";
            this.checkBoxSceneMaterial.Size = new System.Drawing.Size(129, 17);
            this.checkBoxSceneMaterial.TabIndex = 2;
            this.checkBoxSceneMaterial.Text = "Output scene material";
            this.checkBoxSceneMaterial.UseVisualStyleBackColor = true;
            // 
            // checkBoxNodeID
            // 
            this.checkBoxNodeID.AutoSize = true;
            this.checkBoxNodeID.Location = new System.Drawing.Point(7, 7);
            this.checkBoxNodeID.Name = "checkBoxNodeID";
            this.checkBoxNodeID.Size = new System.Drawing.Size(91, 17);
            this.checkBoxNodeID.TabIndex = 0;
            this.checkBoxNodeID.Text = "Only node ID:";
            this.checkBoxNodeID.UseVisualStyleBackColor = true;
            // 
            // tabPageFont
            // 
            this.tabPageFont.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageFont.Controls.Add(this.label5);
            this.tabPageFont.Controls.Add(this.comboBoxFontFormat);
            this.tabPageFont.Controls.Add(this.checkBoxFontPreview);
            this.tabPageFont.Controls.Add(this.label4);
            this.tabPageFont.Controls.Add(this.textBoxFontSizes);
            this.tabPageFont.Controls.Add(this.label3);
            this.tabPageFont.Location = new System.Drawing.Point(4, 22);
            this.tabPageFont.Name = "tabPageFont";
            this.tabPageFont.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFont.Size = new System.Drawing.Size(477, 113);
            this.tabPageFont.TabIndex = 1;
            this.tabPageFont.Text = "Font Options";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Format:";
            // 
            // comboBoxFontFormat
            // 
            this.comboBoxFontFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFontFormat.FormattingEnabled = true;
            this.comboBoxFontFormat.Items.AddRange(new object[] {
            "Bitmap",
            "Distance Field"});
            this.comboBoxFontFormat.Location = new System.Drawing.Point(54, 47);
            this.comboBoxFontFormat.Name = "comboBoxFontFormat";
            this.comboBoxFontFormat.Size = new System.Drawing.Size(192, 21);
            this.comboBoxFontFormat.TabIndex = 4;
            // 
            // checkBoxFontPreview
            // 
            this.checkBoxFontPreview.AutoSize = true;
            this.checkBoxFontPreview.Location = new System.Drawing.Point(271, 51);
            this.checkBoxFontPreview.Name = "checkBoxFontPreview";
            this.checkBoxFontPreview.Size = new System.Drawing.Size(99, 17);
            this.checkBoxFontPreview.TabIndex = 3;
            this.checkBoxFontPreview.Text = "Output Preview";
            this.checkBoxFontPreview.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Comma Separated List of Font Sizes";
            // 
            // textBoxFontSizes
            // 
            this.textBoxFontSizes.Location = new System.Drawing.Point(54, 15);
            this.textBoxFontSizes.Name = "textBoxFontSizes";
            this.textBoxFontSizes.Size = new System.Drawing.Size(192, 20);
            this.textBoxFontSizes.TabIndex = 1;
            this.textBoxFontSizes.Text = "10,12,14";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sizes:";
            // 
            // tabPageNormalMap
            // 
            this.tabPageNormalMap.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageNormalMap.Location = new System.Drawing.Point(4, 22);
            this.tabPageNormalMap.Name = "tabPageNormalMap";
            this.tabPageNormalMap.Size = new System.Drawing.Size(477, 113);
            this.tabPageNormalMap.TabIndex = 2;
            this.tabPageNormalMap.Text = "Normal Map Options";
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(422, 385);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(75, 23);
            this.buttonEncode.TabIndex = 10;
            this.buttonEncode.Text = "Encode";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // buttonAddJob
            // 
            this.buttonAddJob.Location = new System.Drawing.Point(422, 203);
            this.buttonAddJob.Name = "buttonAddJob";
            this.buttonAddJob.Size = new System.Drawing.Size(75, 23);
            this.buttonAddJob.TabIndex = 5;
            this.buttonAddJob.Text = "Add Job";
            this.buttonAddJob.UseVisualStyleBackColor = true;
            this.buttonAddJob.Click += new System.EventHandler(this.buttonAddJob_Click);
            // 
            // buttonRemoveJob
            // 
            this.buttonRemoveJob.Location = new System.Drawing.Point(12, 386);
            this.buttonRemoveJob.Name = "buttonRemoveJob";
            this.buttonRemoveJob.Size = new System.Drawing.Size(112, 23);
            this.buttonRemoveJob.TabIndex = 8;
            this.buttonRemoveJob.Text = "Remove Selected";
            this.buttonRemoveJob.UseVisualStyleBackColor = true;
            this.buttonRemoveJob.Click += new System.EventHandler(this.buttonRemoveJob_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Job Queue:";
            // 
            // listBoxJobs
            // 
            this.listBoxJobs.FormattingEnabled = true;
            this.listBoxJobs.Location = new System.Drawing.Point(12, 232);
            this.listBoxJobs.Name = "listBoxJobs";
            this.listBoxJobs.Size = new System.Drawing.Size(485, 147);
            this.listBoxJobs.TabIndex = 7;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(130, 386);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxConsoleOutput
            // 
            this.textBoxConsoleOutput.Location = new System.Drawing.Point(12, 415);
            this.textBoxConsoleOutput.Multiline = true;
            this.textBoxConsoleOutput.Name = "textBoxConsoleOutput";
            this.textBoxConsoleOutput.ReadOnly = true;
            this.textBoxConsoleOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxConsoleOutput.Size = new System.Drawing.Size(481, 102);
            this.textBoxConsoleOutput.TabIndex = 11;
            // 
            // textBoxConsoleInput
            // 
            this.textBoxConsoleInput.Location = new System.Drawing.Point(12, 524);
            this.textBoxConsoleInput.Name = "textBoxConsoleInput";
            this.textBoxConsoleInput.Size = new System.Drawing.Size(404, 20);
            this.textBoxConsoleInput.TabIndex = 12;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(422, 524);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 13;
            this.buttonSubmit.Text = "Submit";
            this.toolTip1.SetToolTip(this.buttonSubmit, "Submits commands to the GP binary utility, for example when grouping fbx animatio" +
        "ns");
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // checkBoxGroupAnim
            // 
            this.checkBoxGroupAnim.AutoSize = true;
            this.checkBoxGroupAnim.Location = new System.Drawing.Point(7, 79);
            this.checkBoxGroupAnim.Name = "checkBoxGroupAnim";
            this.checkBoxGroupAnim.Size = new System.Drawing.Size(109, 17);
            this.checkBoxGroupAnim.TabIndex = 14;
            this.checkBoxGroupAnim.Text = "Group Animations";
            this.checkBoxGroupAnim.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 559);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxConsoleInput);
            this.Controls.Add(this.textBoxConsoleOutput);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.listBoxJobs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRemoveJob);
            this.Controls.Add(this.buttonAddJob);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxFileIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(525, 594);
            this.MinimumSize = new System.Drawing.Size(525, 594);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gameplay Binary Encoder UI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageFbx.ResumeLayout(false);
            this.tabPageFbx.PerformLayout();
            this.tabPageFont.ResumeLayout(false);
            this.tabPageFont.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableLoggingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFileIn;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFbx;
        private System.Windows.Forms.TabPage tabPageFont;
        private System.Windows.Forms.TabPage tabPageNormalMap;
        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.Button buttonAddJob;
        private System.Windows.Forms.Button buttonRemoveJob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFontSizes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxFontFormat;
        private System.Windows.Forms.CheckBox checkBoxFontPreview;
        private System.Windows.Forms.CheckBox checkBoxTanBitan;
        private System.Windows.Forms.CheckBox checkBoxSceneMaterial;
        private System.Windows.Forms.CheckBox checkBoxNodeID;
        private System.Windows.Forms.ListBox listBoxJobs;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxBitan;
        private System.Windows.Forms.TextBox textBoxOnlyNode;
        private System.Windows.Forms.TextBox textBoxConsoleOutput;
        private System.Windows.Forms.TextBox textBoxConsoleInput;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkBoxGroupAnim;
    }
}

