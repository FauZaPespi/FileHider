namespace P_FileHider
{
    partial class Frm_FileHider
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_FileHider));
            this.btnHide = new CuoreUI.Controls.cuiButton();
            this.btnSelectImage = new Guna.UI2.WinForms.Guna2Button();
            this.btnSelectFile = new Guna.UI2.WinForms.Guna2Button();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2VSeparator2 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.pnlConsoleOutput = new System.Windows.Forms.Panel();
            this.lblConsole = new System.Windows.Forms.Label();
            this.tmResetConsole = new System.Windows.Forms.Timer(this.components);
            this.lblClear = new System.Windows.Forms.Label();
            this.pnlConsoleOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHide
            // 
            this.btnHide.CheckButton = false;
            this.btnHide.Checked = false;
            this.btnHide.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnHide.CheckedImageTint = System.Drawing.Color.White;
            this.btnHide.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.btnHide.Content = "Hide";
            this.btnHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHide.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHide.ForeColor = System.Drawing.Color.White;
            this.btnHide.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.btnHide.HoveredImageTint = System.Drawing.Color.White;
            this.btnHide.HoverOutline = System.Drawing.Color.White;
            this.btnHide.Image = null;
            this.btnHide.ImageAutoCenter = true;
            this.btnHide.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnHide.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnHide.ImageTint = System.Drawing.Color.White;
            this.btnHide.Location = new System.Drawing.Point(459, 185);
            this.btnHide.Margin = new System.Windows.Forms.Padding(0);
            this.btnHide.Name = "btnHide";
            this.btnHide.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnHide.NormalOutline = System.Drawing.Color.Empty;
            this.btnHide.OutlineThickness = 1.6F;
            this.btnHide.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnHide.PressedImageTint = System.Drawing.Color.White;
            this.btnHide.PressedOutline = System.Drawing.Color.Empty;
            this.btnHide.Rounding = new System.Windows.Forms.Padding(8);
            this.btnHide.Size = new System.Drawing.Size(197, 80);
            this.btnHide.TabIndex = 2;
            this.btnHide.TextOffset = new System.Drawing.Point(0, 0);
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Animated = true;
            this.btnSelectImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelectImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelectImage.Font = new System.Drawing.Font("OCR A Extended", 14F);
            this.btnSelectImage.ForeColor = System.Drawing.Color.White;
            this.btnSelectImage.Location = new System.Drawing.Point(144, 198);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(100, 54);
            this.btnSelectImage.TabIndex = 3;
            this.btnSelectImage.Text = "Select Image";
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Animated = true;
            this.btnSelectFile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectFile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelectFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelectFile.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.btnSelectFile.ForeColor = System.Drawing.Color.White;
            this.btnSelectFile.Location = new System.Drawing.Point(291, 198);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(147, 54);
            this.btnSelectFile.TabIndex = 4;
            this.btnSelectFile.Text = "Select Secret File";
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(444, 198);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(12, 54);
            this.guna2VSeparator1.TabIndex = 5;
            // 
            // guna2VSeparator2
            // 
            this.guna2VSeparator2.Location = new System.Drawing.Point(262, 198);
            this.guna2VSeparator2.Name = "guna2VSeparator2";
            this.guna2VSeparator2.Size = new System.Drawing.Size(12, 54);
            this.guna2VSeparator2.TabIndex = 6;
            // 
            // pnlConsoleOutput
            // 
            this.pnlConsoleOutput.Controls.Add(this.lblConsole);
            this.pnlConsoleOutput.Location = new System.Drawing.Point(12, 12);
            this.pnlConsoleOutput.Name = "pnlConsoleOutput";
            this.pnlConsoleOutput.Size = new System.Drawing.Size(776, 121);
            this.pnlConsoleOutput.TabIndex = 7;
            // 
            // lblConsole
            // 
            this.lblConsole.AutoSize = true;
            this.lblConsole.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsole.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblConsole.Location = new System.Drawing.Point(3, 0);
            this.lblConsole.MaximumSize = new System.Drawing.Size(776, 121);
            this.lblConsole.MinimumSize = new System.Drawing.Size(776, 121);
            this.lblConsole.Name = "lblConsole";
            this.lblConsole.Size = new System.Drawing.Size(776, 121);
            this.lblConsole.TabIndex = 0;
            this.lblConsole.Text = "System/FileHide> Hide Init\r\n\r\n";
            // 
            // tmResetConsole
            // 
            this.tmResetConsole.Enabled = true;
            this.tmResetConsole.Interval = 1000;
            this.tmResetConsole.Tick += new System.EventHandler(this.tmResetConsole_Tick);
            // 
            // lblClear
            // 
            this.lblClear.AutoSize = true;
            this.lblClear.Font = new System.Drawing.Font("OCR A Extended", 9F);
            this.lblClear.ForeColor = System.Drawing.Color.White;
            this.lblClear.Location = new System.Drawing.Point(15, 428);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(147, 13);
            this.lblClear.TabIndex = 8;
            this.lblClear.Text = "Time before clear: 0";
            // 
            // Frm_FileHider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblClear);
            this.Controls.Add(this.pnlConsoleOutput);
            this.Controls.Add(this.guna2VSeparator2);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.btnHide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Frm_FileHider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Hider";
            this.pnlConsoleOutput.ResumeLayout(false);
            this.pnlConsoleOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CuoreUI.Controls.cuiButton btnHide;
        private Guna.UI2.WinForms.Guna2Button btnSelectImage;
        private Guna.UI2.WinForms.Guna2Button btnSelectFile;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator2;
        private System.Windows.Forms.Panel pnlConsoleOutput;
        private System.Windows.Forms.Label lblConsole;
        private System.Windows.Forms.Timer tmResetConsole;
        private System.Windows.Forms.Label lblClear;
    }
}

