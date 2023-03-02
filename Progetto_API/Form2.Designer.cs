namespace Progetto_API
{
    partial class Form2
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
            this.panel_logo = new System.Windows.Forms.Panel();
            this.label_titolo = new System.Windows.Forms.Label();
            this.label_torna_indietro = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_logo
            // 
            this.panel_logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_logo.Controls.Add(this.label_titolo);
            this.panel_logo.Controls.Add(this.pictureBox1);
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(1124, 100);
            this.panel_logo.TabIndex = 8;
            // 
            // label_titolo
            // 
            this.label_titolo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_titolo.AutoSize = true;
            this.label_titolo.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titolo.ForeColor = System.Drawing.Color.White;
            this.label_titolo.Location = new System.Drawing.Point(23, 30);
            this.label_titolo.Name = "label_titolo";
            this.label_titolo.Size = new System.Drawing.Size(210, 41);
            this.label_titolo.TabIndex = 9;
            this.label_titolo.Text = "TOP RATED";
            // 
            // label_torna_indietro
            // 
            this.label_torna_indietro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_torna_indietro.AutoSize = true;
            this.label_torna_indietro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_torna_indietro.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_torna_indietro.ForeColor = System.Drawing.Color.White;
            this.label_torna_indietro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_torna_indietro.Location = new System.Drawing.Point(12, 112);
            this.label_torna_indietro.Name = "label_torna_indietro";
            this.label_torna_indietro.Size = new System.Drawing.Size(68, 23);
            this.label_torna_indietro.TabIndex = 9;
            this.label_torna_indietro.Text = "Indietro";
            this.label_torna_indietro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_torna_indietro.Click += new System.EventHandler(this.label_torna_indietro_Click);
            this.label_torna_indietro.MouseHover += new System.EventHandler(this.label_torna_indietro_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Progetto_API.Properties.Resources.esss;
            this.pictureBox1.Location = new System.Drawing.Point(908, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 596);
            this.Controls.Add(this.label_torna_indietro);
            this.Controls.Add(this.panel_logo);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel_logo.ResumeLayout(false);
            this.panel_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Label label_titolo;
        private System.Windows.Forms.Label label_torna_indietro;
    }
}