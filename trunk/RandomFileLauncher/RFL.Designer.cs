namespace RandomFileLauncher
{
    partial class FrmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.chbAudio = new System.Windows.Forms.CheckBox();
            this.chbVideo = new System.Windows.Forms.CheckBox();
            this.chbPicture = new System.Windows.Forms.CheckBox();
            this.chbText = new System.Windows.Forms.CheckBox();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.tboxPath1 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.chbAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.chbTransparent = new System.Windows.Forms.CheckBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddTextbox = new System.Windows.Forms.Button();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // chbAudio
            // 
            this.chbAudio.AutoSize = true;
            this.chbAudio.Location = new System.Drawing.Point(12, 30);
            this.chbAudio.Name = "chbAudio";
            this.chbAudio.Size = new System.Drawing.Size(33, 17);
            this.chbAudio.TabIndex = 1;
            this.chbAudio.Text = "A";
            this.chbAudio.UseVisualStyleBackColor = true;
            // 
            // chbVideo
            // 
            this.chbVideo.AutoSize = true;
            this.chbVideo.Location = new System.Drawing.Point(51, 30);
            this.chbVideo.Name = "chbVideo";
            this.chbVideo.Size = new System.Drawing.Size(33, 17);
            this.chbVideo.TabIndex = 2;
            this.chbVideo.Text = "V";
            this.chbVideo.UseVisualStyleBackColor = true;
            // 
            // chbPicture
            // 
            this.chbPicture.AutoSize = true;
            this.chbPicture.Location = new System.Drawing.Point(90, 30);
            this.chbPicture.Name = "chbPicture";
            this.chbPicture.Size = new System.Drawing.Size(33, 17);
            this.chbPicture.TabIndex = 3;
            this.chbPicture.Text = "P";
            this.chbPicture.UseVisualStyleBackColor = true;
            // 
            // chbText
            // 
            this.chbText.AutoSize = true;
            this.chbText.Location = new System.Drawing.Point(129, 30);
            this.chbText.Name = "chbText";
            this.chbText.Size = new System.Drawing.Size(33, 17);
            this.chbText.TabIndex = 4;
            this.chbText.Text = "T";
            this.chbText.UseVisualStyleBackColor = true;
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.BackColor = System.Drawing.Color.White;
            this.btnBrowseFolder.Location = new System.Drawing.Point(252, 53);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(28, 20);
            this.btnBrowseFolder.TabIndex = 5;
            this.btnBrowseFolder.Text = "...";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new System.EventHandler(this.BtnBrowseFolderClick);
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.White;
            this.btnLaunch.Location = new System.Drawing.Point(78, 3);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(187, 23);
            this.btnLaunch.TabIndex = 6;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.BtnLaunchClick);
            this.btnLaunch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BtnLaunchKeyPress);
            // 
            // tboxPath1
            // 
            this.tboxPath1.Location = new System.Drawing.Point(12, 53);
            this.tboxPath1.Name = "tboxPath1";
            this.tboxPath1.Size = new System.Drawing.Size(234, 20);
            this.tboxPath1.TabIndex = 1;
            this.tboxPath1.TabStop = false;
            this.tboxPath1.Text = "F:\\zdownloading";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Random File Launch";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(150, 37);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 8;
            // 
            // chbAlwaysOnTop
            // 
            this.chbAlwaysOnTop.AutoSize = true;
            this.chbAlwaysOnTop.Location = new System.Drawing.Point(240, 30);
            this.chbAlwaysOnTop.Name = "chbAlwaysOnTop";
            this.chbAlwaysOnTop.Size = new System.Drawing.Size(40, 17);
            this.chbAlwaysOnTop.TabIndex = 8;
            this.chbAlwaysOnTop.Text = "AT";
            this.chbAlwaysOnTop.UseVisualStyleBackColor = true;
            this.chbAlwaysOnTop.CheckedChanged += new System.EventHandler(this.ChbAlwaysOnTopCheckedChanged);
            // 
            // chbTransparent
            // 
            this.chbTransparent.AutoSize = true;
            this.chbTransparent.Location = new System.Drawing.Point(198, 30);
            this.chbTransparent.Name = "chbTransparent";
            this.chbTransparent.Size = new System.Drawing.Size(36, 17);
            this.chbTransparent.TabIndex = 7;
            this.chbTransparent.Text = "Tr";
            this.chbTransparent.UseVisualStyleBackColor = true;
            this.chbTransparent.CheckedChanged += new System.EventHandler(this.ChbTransparentCheckedChanged);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(180, 11);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(80, 13);
            this.lblVersion.TabIndex = 10;
            this.lblVersion.Text = "Version number";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(3, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearchClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(3, 32);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(48, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
            // 
            // btnAddTextbox
            // 
            this.btnAddTextbox.Location = new System.Drawing.Point(78, 32);
            this.btnAddTextbox.Name = "btnAddTextbox";
            this.btnAddTextbox.Size = new System.Drawing.Size(48, 23);
            this.btnAddTextbox.TabIndex = 14;
            this.btnAddTextbox.Text = "+";
            this.btnAddTextbox.UseVisualStyleBackColor = true;
            this.btnAddTextbox.Click += new System.EventHandler(this.BtnAddTextboxClick);
            // 
            // pnlControls
            // 
            this.pnlControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControls.Controls.Add(this.lblResult);
            this.pnlControls.Controls.Add(this.btnAddTextbox);
            this.pnlControls.Controls.Add(this.btnLaunch);
            this.pnlControls.Controls.Add(this.btnDelete);
            this.pnlControls.Controls.Add(this.btnSearch);
            this.pnlControls.Location = new System.Drawing.Point(12, 78);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(268, 58);
            this.pnlControls.TabIndex = 15;
            // 
            // FrmMain
            // 
            this.AcceptButton = this.btnLaunch;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(292, 148);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.chbTransparent);
            this.Controls.Add(this.chbAlwaysOnTop);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxPath1);
            this.Controls.Add(this.btnBrowseFolder);
            this.Controls.Add(this.chbText);
            this.Controls.Add(this.chbPicture);
            this.Controls.Add(this.chbVideo);
            this.Controls.Add(this.chbAudio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RFL";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.FrmMain_HelpButtonClicked);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbAudio;
        private System.Windows.Forms.CheckBox chbVideo;
        private System.Windows.Forms.CheckBox chbPicture;
        private System.Windows.Forms.CheckBox chbText;
        private System.Windows.Forms.Button btnBrowseFolder;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.TextBox tboxPath1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.CheckBox chbAlwaysOnTop;
        private System.Windows.Forms.CheckBox chbTransparent;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddTextbox;
        private System.Windows.Forms.Panel pnlControls;
    }
}

