namespace ResizeToTGA
{
    partial class FormResize
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResize));
            btnResize = new Button();
            btnSelect = new Button();
            btnSelectFolder = new Button();
            cmbSize = new ComboBox();
            lblOutputPath = new Label();
            lblProgress = new Label();
            grdImages = new DataGridView();
            colFilename = new DataGridViewTextBoxColumn();
            colPath = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)grdImages).BeginInit();
            SuspendLayout();
            // 
            // btnResize
            // 
            btnResize.Font = new Font("Gadugi", 12F);
            btnResize.Location = new Point(395, 73);
            btnResize.Margin = new Padding(4);
            btnResize.Name = "btnResize";
            btnResize.Size = new Size(164, 53);
            btnResize.TabIndex = 0;
            btnResize.Text = "Resize";
            btnResize.UseVisualStyleBackColor = true;
            btnResize.Click += btnResize_Click;
            // 
            // btnSelect
            // 
            btnSelect.Font = new Font("Gadugi", 12F);
            btnSelect.Location = new Point(395, 13);
            btnSelect.Margin = new Padding(4);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(164, 52);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "Select Images";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.Font = new Font("Gadugi", 12F);
            btnSelectFolder.Location = new Point(395, 505);
            btnSelectFolder.Margin = new Padding(4);
            btnSelectFolder.Name = "btnSelectFolder";
            btnSelectFolder.Size = new Size(164, 53);
            btnSelectFolder.TabIndex = 3;
            btnSelectFolder.Text = "Select Save Folder";
            btnSelectFolder.UseVisualStyleBackColor = true;
            btnSelectFolder.Click += btnSelectFolder_Click;
            // 
            // cmbSize
            // 
            cmbSize.FormattingEnabled = true;
            cmbSize.Items.AddRange(new object[] { "16x16", "32x32", "48x48", "64x64", "128x128", "256x256" });
            cmbSize.Location = new Point(395, 133);
            cmbSize.Name = "cmbSize";
            cmbSize.Size = new Size(164, 27);
            cmbSize.TabIndex = 4;
            cmbSize.SelectedIndexChanged += cmbSize_SelectedIndexChanged;
            // 
            // lblOutputPath
            // 
            lblOutputPath.Location = new Point(395, 454);
            lblOutputPath.Name = "lblOutputPath";
            lblOutputPath.Size = new Size(165, 47);
            lblOutputPath.TabIndex = 5;
            lblOutputPath.Text = "label1";
            lblOutputPath.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProgress
            // 
            lblProgress.Location = new Point(395, 163);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(165, 47);
            lblProgress.TabIndex = 6;
            lblProgress.Text = "label1";
            lblProgress.TextAlign = ContentAlignment.MiddleCenter;
            lblProgress.Visible = false;
            // 
            // grdImages
            // 
            grdImages.AllowUserToAddRows = false;
            grdImages.AllowUserToDeleteRows = false;
            grdImages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdImages.Columns.AddRange(new DataGridViewColumn[] { colFilename, colPath });
            grdImages.Location = new Point(13, 10);
            grdImages.Name = "grdImages";
            grdImages.ReadOnly = true;
            grdImages.RowHeadersVisible = false;
            grdImages.Size = new Size(376, 548);
            grdImages.TabIndex = 8;
            // 
            // colFilename
            // 
            colFilename.Frozen = true;
            colFilename.HeaderText = "Filename";
            colFilename.Name = "colFilename";
            colFilename.ReadOnly = true;
            // 
            // colPath
            // 
            colPath.Frozen = true;
            colPath.HeaderText = "Path";
            colPath.Name = "colPath";
            colPath.ReadOnly = true;
            colPath.Width = 275;
            // 
            // FormResize
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 570);
            Controls.Add(grdImages);
            Controls.Add(lblProgress);
            Controls.Add(lblOutputPath);
            Controls.Add(cmbSize);
            Controls.Add(btnSelectFolder);
            Controls.Add(btnSelect);
            Controls.Add(btnResize);
            Font = new Font("Gadugi", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(588, 609);
            MinimumSize = new Size(588, 609);
            Name = "FormResize";
            Text = "WoW Resize";
            FormClosing += FormResize_FormClosing;
            ((System.ComponentModel.ISupportInitialize)grdImages).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnResize;
        private Button btnSelect;
        private Button btnSelectFolder;
        private ComboBox cmbSize;
        private Label lblOutputPath;
        private Label lblProgress;
        private DataGridView grdImages;
        private DataGridViewTextBoxColumn colFilename;
        private DataGridViewTextBoxColumn colPath;
    }
}
