
namespace MSU_JSON_Creator
{
    partial class MSU_JSON_Creator
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
            this.dgMSUTracks = new System.Windows.Forms.DataGridView();
            this.mnuMainTracks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hasSubTracksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSubTracksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtGame = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPackName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.numNormalization = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOutputPrefix = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnDeselectAll = new System.Windows.Forms.Button();
            this.btnSelectValids = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dgSubTracks = new System.Windows.Forms.DataGridView();
            this.mnuSubTracks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addSubTrackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSubTrackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFillFolder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgMSUTracks)).BeginInit();
            this.mnuMainTracks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNormalization)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSubTracks)).BeginInit();
            this.mnuSubTracks.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgMSUTracks
            // 
            this.dgMSUTracks.AllowUserToAddRows = false;
            this.dgMSUTracks.AllowUserToDeleteRows = false;
            this.dgMSUTracks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgMSUTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMSUTracks.ContextMenuStrip = this.mnuMainTracks;
            this.dgMSUTracks.Location = new System.Drawing.Point(12, 112);
            this.dgMSUTracks.Name = "dgMSUTracks";
            this.dgMSUTracks.Size = new System.Drawing.Size(1228, 448);
            this.dgMSUTracks.TabIndex = 0;
            // 
            // mnuMainTracks
            // 
            this.mnuMainTracks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hasSubTracksToolStripMenuItem,
            this.removeSubTracksToolStripMenuItem});
            this.mnuMainTracks.Name = "mnuMainTracks";
            this.mnuMainTracks.Size = new System.Drawing.Size(176, 48);
            // 
            // hasSubTracksToolStripMenuItem
            // 
            this.hasSubTracksToolStripMenuItem.Name = "hasSubTracksToolStripMenuItem";
            this.hasSubTracksToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.hasSubTracksToolStripMenuItem.Text = "Has Sub Tracks";
            this.hasSubTracksToolStripMenuItem.Click += new System.EventHandler(this.hasSubTracksToolStripMenuItem_Click);
            // 
            // removeSubTracksToolStripMenuItem
            // 
            this.removeSubTracksToolStripMenuItem.Name = "removeSubTracksToolStripMenuItem";
            this.removeSubTracksToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.removeSubTracksToolStripMenuItem.Text = "Remove Sub Tracks";
            this.removeSubTracksToolStripMenuItem.Click += new System.EventHandler(this.removeSubTracksToolStripMenuItem_Click);
            // 
            // txtGame
            // 
            this.txtGame.Location = new System.Drawing.Point(53, 39);
            this.txtGame.Name = "txtGame";
            this.txtGame.Size = new System.Drawing.Size(209, 20);
            this.txtGame.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pack Name";
            // 
            // txtPackName
            // 
            this.txtPackName.Location = new System.Drawing.Point(341, 39);
            this.txtPackName.Name = "txtPackName";
            this.txtPackName.Size = new System.Drawing.Size(209, 20);
            this.txtPackName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Artist";
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(597, 39);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(209, 20);
            this.txtArtist.TabIndex = 5;
            // 
            // numNormalization
            // 
            this.numNormalization.Location = new System.Drawing.Point(888, 40);
            this.numNormalization.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numNormalization.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.numNormalization.Name = "numNormalization";
            this.numNormalization.Size = new System.Drawing.Size(55, 20);
            this.numNormalization.TabIndex = 7;
            this.numNormalization.Value = new decimal(new int[] {
            21,
            0,
            0,
            -2147483648});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(812, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Normalization";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(957, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Output Prefix";
            // 
            // txtOutputPrefix
            // 
            this.txtOutputPrefix.Location = new System.Drawing.Point(1031, 39);
            this.txtOutputPrefix.Name = "txtOutputPrefix";
            this.txtOutputPrefix.Size = new System.Drawing.Size(209, 20);
            this.txtOutputPrefix.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1246, 37);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(1327, 37);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 12;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnDeselectAll
            // 
            this.btnDeselectAll.Location = new System.Drawing.Point(15, 77);
            this.btnDeselectAll.Name = "btnDeselectAll";
            this.btnDeselectAll.Size = new System.Drawing.Size(75, 23);
            this.btnDeselectAll.TabIndex = 13;
            this.btnDeselectAll.Text = "Deselect All";
            this.btnDeselectAll.UseVisualStyleBackColor = true;
            this.btnDeselectAll.Click += new System.EventHandler(this.btnDeselectAll_Click);
            // 
            // btnSelectValids
            // 
            this.btnSelectValids.Location = new System.Drawing.Point(96, 77);
            this.btnSelectValids.Name = "btnSelectValids";
            this.btnSelectValids.Size = new System.Drawing.Size(143, 23);
            this.btnSelectValids.TabIndex = 14;
            this.btnSelectValids.Text = "Select All with Trim Start";
            this.btnSelectValids.UseVisualStyleBackColor = true;
            this.btnSelectValids.Click += new System.EventHandler(this.btnSelectValids_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(1267, 77);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(143, 23);
            this.btnValidate.TabIndex = 15;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1422, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveXMLToolStripMenuItem,
            this.openXMLToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveXMLToolStripMenuItem
            // 
            this.saveXMLToolStripMenuItem.Name = "saveXMLToolStripMenuItem";
            this.saveXMLToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.saveXMLToolStripMenuItem.Text = "Save XML (New File Name)";
            this.saveXMLToolStripMenuItem.Click += new System.EventHandler(this.saveXMLToolStripMenuItem_Click);
            // 
            // openXMLToolStripMenuItem
            // 
            this.openXMLToolStripMenuItem.Name = "openXMLToolStripMenuItem";
            this.openXMLToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.openXMLToolStripMenuItem.Text = "Open XML";
            this.openXMLToolStripMenuItem.Click += new System.EventHandler(this.openXMLToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dgSubTracks
            // 
            this.dgSubTracks.AllowUserToAddRows = false;
            this.dgSubTracks.AllowUserToDeleteRows = false;
            this.dgSubTracks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgSubTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSubTracks.ContextMenuStrip = this.mnuSubTracks;
            this.dgSubTracks.Location = new System.Drawing.Point(1246, 112);
            this.dgSubTracks.Name = "dgSubTracks";
            this.dgSubTracks.Size = new System.Drawing.Size(164, 448);
            this.dgSubTracks.TabIndex = 18;
            // 
            // mnuSubTracks
            // 
            this.mnuSubTracks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSubTrackToolStripMenuItem,
            this.removeSubTrackToolStripMenuItem});
            this.mnuSubTracks.Name = "mnuSubTracks";
            this.mnuSubTracks.Size = new System.Drawing.Size(171, 48);
            // 
            // addSubTrackToolStripMenuItem
            // 
            this.addSubTrackToolStripMenuItem.Name = "addSubTrackToolStripMenuItem";
            this.addSubTrackToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.addSubTrackToolStripMenuItem.Text = "Add Sub Track";
            this.addSubTrackToolStripMenuItem.Click += new System.EventHandler(this.addSubTrackToolStripMenuItem_Click);
            // 
            // removeSubTrackToolStripMenuItem
            // 
            this.removeSubTrackToolStripMenuItem.Name = "removeSubTrackToolStripMenuItem";
            this.removeSubTrackToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.removeSubTrackToolStripMenuItem.Text = "Remove Sub Track";
            this.removeSubTrackToolStripMenuItem.Click += new System.EventHandler(this.removeSubTrackToolStripMenuItem_Click);
            // 
            // btnFillFolder
            // 
            this.btnFillFolder.Location = new System.Drawing.Point(245, 77);
            this.btnFillFolder.Name = "btnFillFolder";
            this.btnFillFolder.Size = new System.Drawing.Size(143, 23);
            this.btnFillFolder.TabIndex = 19;
            this.btnFillFolder.Text = "Fill Folder";
            this.btnFillFolder.UseVisualStyleBackColor = true;
            this.btnFillFolder.Click += new System.EventHandler(this.btnFillFolder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Folder";
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(435, 80);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(209, 20);
            this.txtFolder.TabIndex = 20;
            // 
            // MSU_JSON_Creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 572);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.btnFillFolder);
            this.Controls.Add(this.dgSubTracks);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.btnSelectValids);
            this.Controls.Add(this.btnDeselectAll);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOutputPrefix);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numNormalization);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPackName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGame);
            this.Controls.Add(this.dgMSUTracks);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MSU_JSON_Creator";
            this.Text = "MSU JSON Creator";
            ((System.ComponentModel.ISupportInitialize)(this.dgMSUTracks)).EndInit();
            this.mnuMainTracks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numNormalization)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSubTracks)).EndInit();
            this.mnuSubTracks.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMSUTracks;
        private System.Windows.Forms.TextBox txtGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPackName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.NumericUpDown numNormalization;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOutputPrefix;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnDeselectAll;
        private System.Windows.Forms.Button btnSelectValids;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openXMLToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip mnuMainTracks;
        private System.Windows.Forms.ToolStripMenuItem hasSubTracksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSubTracksToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgSubTracks;
        private System.Windows.Forms.ContextMenuStrip mnuSubTracks;
        private System.Windows.Forms.ToolStripMenuItem addSubTrackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSubTrackToolStripMenuItem;
        private System.Windows.Forms.Button btnFillFolder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFolder;
    }
}

