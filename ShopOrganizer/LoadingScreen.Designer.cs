
namespace ShopOrganizer
{
    partial class LoadingScreen
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingScreen));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.loading = new System.Windows.Forms.Label();
            this.statusPercent = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.progressBar1.Location = new System.Drawing.Point(-2, 176);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBar1.RightToLeftLayout = true;
            this.progressBar1.Size = new System.Drawing.Size(690, 37);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 50;
            // 
            // loading
            // 
            this.loading.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loading.AutoSize = true;
            this.loading.Location = new System.Drawing.Point(320, 160);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(41, 13);
            this.loading.TabIndex = 1;
            this.loading.Text = "loading";
            // 
            // statusPercent
            // 
            this.statusPercent.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.statusPercent.AutoSize = true;
            this.statusPercent.Location = new System.Drawing.Point(367, 160);
            this.statusPercent.Name = "statusPercent";
            this.statusPercent.Size = new System.Drawing.Size(24, 13);
            this.statusPercent.TabIndex = 2;
            this.statusPercent.Text = "0 %";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(690, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 211);
            this.Controls.Add(this.statusPercent);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop Organizer";
            this.Load += new System.EventHandler(this.LoadingScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label loading;
        private System.Windows.Forms.Label statusPercent;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

