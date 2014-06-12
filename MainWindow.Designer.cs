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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableLoggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFileIn = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFbx = new System.Windows.Forms.TabPage();
            this.tabPageFont = new System.Windows.Forms.TabPage();
            this.tabPageNormalMap = new System.Windows.Forms.TabPage();
            this.textBoxJobList = new System.Windows.Forms.TextBox();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.buttonAddJob = new System.Windows.Forms.Button();
            this.buttonRemoveJob = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFontSizes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxFontPreview = new System.Windows.Forms.CheckBox();
            this.comboBoxFontFormat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            this.enableLoggingToolStripMenuItem.Name = "enableLoggingToolStripMenuItem";
            this.enableLoggingToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.enableLoggingToolStripMenuItem.Text = "Enable Logging";
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
            this.tabControl1.Size = new System.Drawing.Size(485, 225);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPageFbx
            // 
            this.tabPageFbx.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageFbx.Location = new System.Drawing.Point(4, 22);
            this.tabPageFbx.Name = "tabPageFbx";
            this.tabPageFbx.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFbx.Size = new System.Drawing.Size(477, 216);
            this.tabPageFbx.TabIndex = 0;
            this.tabPageFbx.Text = "FBX Options";
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
            this.tabPageFont.Size = new System.Drawing.Size(477, 199);
            this.tabPageFont.TabIndex = 1;
            this.tabPageFont.Text = "Font Options";
            // 
            // tabPageNormalMap
            // 
            this.tabPageNormalMap.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageNormalMap.Location = new System.Drawing.Point(4, 22);
            this.tabPageNormalMap.Name = "tabPageNormalMap";
            this.tabPageNormalMap.Size = new System.Drawing.Size(477, 216);
            this.tabPageNormalMap.TabIndex = 2;
            this.tabPageNormalMap.Text = "Normal Map Options";
            // 
            // textBoxJobList
            // 
            this.textBoxJobList.Location = new System.Drawing.Point(12, 327);
            this.textBoxJobList.Multiline = true;
            this.textBoxJobList.Name = "textBoxJobList";
            this.textBoxJobList.ReadOnly = true;
            this.textBoxJobList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxJobList.Size = new System.Drawing.Size(485, 153);
            this.textBoxJobList.TabIndex = 5;
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(422, 486);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(75, 23);
            this.buttonEncode.TabIndex = 8;
            this.buttonEncode.Text = "Encode";
            this.buttonEncode.UseVisualStyleBackColor = true;
            // 
            // buttonAddJob
            // 
            this.buttonAddJob.Location = new System.Drawing.Point(422, 289);
            this.buttonAddJob.Name = "buttonAddJob";
            this.buttonAddJob.Size = new System.Drawing.Size(75, 23);
            this.buttonAddJob.TabIndex = 7;
            this.buttonAddJob.Text = "Add Job";
            this.buttonAddJob.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveJob
            // 
            this.buttonRemoveJob.Location = new System.Drawing.Point(12, 487);
            this.buttonRemoveJob.Name = "buttonRemoveJob";
            this.buttonRemoveJob.Size = new System.Drawing.Size(112, 23);
            this.buttonRemoveJob.TabIndex = 6;
            this.buttonRemoveJob.Text = "Remove Selected";
            this.buttonRemoveJob.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Job Queue:";
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
            // textBoxFontSizes
            // 
            this.textBoxFontSizes.Location = new System.Drawing.Point(54, 15);
            this.textBoxFontSizes.Name = "textBoxFontSizes";
            this.textBoxFontSizes.Size = new System.Drawing.Size(192, 20);
            this.textBoxFontSizes.TabIndex = 1;
            this.textBoxFontSizes.Text = "10,12,14";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Format:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 519);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRemoveJob);
            this.Controls.Add(this.buttonAddJob);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.textBoxJobList);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxFileIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(525, 554);
            this.MinimumSize = new System.Drawing.Size(525, 554);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gameplay Binary Encoder UI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFileIn;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFbx;
        private System.Windows.Forms.TabPage tabPageFont;
        private System.Windows.Forms.TabPage tabPageNormalMap;
        private System.Windows.Forms.TextBox textBoxJobList;
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
    }
}

