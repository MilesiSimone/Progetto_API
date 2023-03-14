namespace Progetto_API
{
    partial class FormReview
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_torna_indietro = new System.Windows.Forms.Label();
            this.label_id_series = new System.Windows.Forms.Label();
            this.label_value = new System.Windows.Forms.Label();
            this.textBox_id_series = new System.Windows.Forms.TextBox();
            this.comboBox_valutazione = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_titolo_series = new System.Windows.Forms.Label();
            this.buttons_send = new Progetto_API.Buttons();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_logo
            // 
            this.panel_logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_logo.Controls.Add(this.label_titolo);
            this.panel_logo.Controls.Add(this.pictureBox1);
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Margin = new System.Windows.Forms.Padding(4);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(1042, 123);
            this.panel_logo.TabIndex = 9;
            // 
            // label_titolo
            // 
            this.label_titolo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_titolo.AutoSize = true;
            this.label_titolo.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titolo.ForeColor = System.Drawing.Color.White;
            this.label_titolo.Location = new System.Drawing.Point(31, 37);
            this.label_titolo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_titolo.Name = "label_titolo";
            this.label_titolo.Size = new System.Drawing.Size(303, 51);
            this.label_titolo.TabIndex = 9;
            this.label_titolo.Text = "ADD REVIEW";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Progetto_API.Properties.Resources.esss;
            this.pictureBox1.Location = new System.Drawing.Point(816, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.label_torna_indietro.Location = new System.Drawing.Point(13, 127);
            this.label_torna_indietro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_torna_indietro.Name = "label_torna_indietro";
            this.label_torna_indietro.Size = new System.Drawing.Size(85, 29);
            this.label_torna_indietro.TabIndex = 10;
            this.label_torna_indietro.Text = "Indietro";
            this.label_torna_indietro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_torna_indietro.Click += new System.EventHandler(this.label_torna_indietro_Click);
            this.label_torna_indietro.MouseLeave += new System.EventHandler(this.label_torna_indietro_MouseLeave);
            this.label_torna_indietro.MouseHover += new System.EventHandler(this.label_torna_indietro_MouseHover);
            // 
            // label_id_series
            // 
            this.label_id_series.AutoSize = true;
            this.label_id_series.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label_id_series.Location = new System.Drawing.Point(564, 174);
            this.label_id_series.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_id_series.Name = "label_id_series";
            this.label_id_series.Size = new System.Drawing.Size(115, 32);
            this.label_id_series.TabIndex = 11;
            this.label_id_series.Text = "ID Series:";
            // 
            // label_value
            // 
            this.label_value.AutoSize = true;
            this.label_value.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label_value.Location = new System.Drawing.Point(564, 235);
            this.label_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_value.Name = "label_value";
            this.label_value.Size = new System.Drawing.Size(146, 32);
            this.label_value.TabIndex = 12;
            this.label_value.Text = "Valutazione:";
            this.label_value.Visible = false;
            // 
            // textBox_id_series
            // 
            this.textBox_id_series.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_id_series.Location = new System.Drawing.Point(676, 179);
            this.textBox_id_series.Name = "textBox_id_series";
            this.textBox_id_series.Size = new System.Drawing.Size(100, 30);
            this.textBox_id_series.TabIndex = 13;
            this.textBox_id_series.Text = "1562";
            this.textBox_id_series.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox_valutazione
            // 
            this.comboBox_valutazione.FormattingEnabled = true;
            this.comboBox_valutazione.Items.AddRange(new object[] {
            "0,5",
            "1",
            "1,5",
            "2",
            "2,5",
            "3",
            "3,5",
            "4",
            "4,5",
            "5",
            "5,5",
            "6",
            "6,5",
            "7",
            "7,5",
            "8",
            "8,5",
            "9",
            "9,5",
            "10"});
            this.comboBox_valutazione.Location = new System.Drawing.Point(707, 239);
            this.comboBox_valutazione.MaxLength = 3;
            this.comboBox_valutazione.Name = "comboBox_valutazione";
            this.comboBox_valutazione.Size = new System.Drawing.Size(113, 31);
            this.comboBox_valutazione.TabIndex = 0;
            this.comboBox_valutazione.Visible = false;
            this.comboBox_valutazione.SelectedIndexChanged += new System.EventHandler(this.comboBox_valutazione_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(114, 166);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(230, 365);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // label_titolo_series
            // 
            this.label_titolo_series.AutoSize = true;
            this.label_titolo_series.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label_titolo_series.Location = new System.Drawing.Point(196, 545);
            this.label_titolo_series.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_titolo_series.Name = "label_titolo_series";
            this.label_titolo_series.Size = new System.Drawing.Size(76, 32);
            this.label_titolo_series.TabIndex = 16;
            this.label_titolo_series.Text = "Titolo";
            this.label_titolo_series.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_titolo_series.Visible = false;
            // 
            // buttons_send
            // 
            this.buttons_send.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttons_send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttons_send.FlatAppearance.BorderSize = 0;
            this.buttons_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons_send.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttons_send.ForeColor = System.Drawing.Color.White;
            this.buttons_send.Location = new System.Drawing.Point(593, 335);
            this.buttons_send.Name = "buttons_send";
            this.buttons_send.Size = new System.Drawing.Size(205, 66);
            this.buttons_send.TabIndex = 17;
            this.buttons_send.Text = "SEND";
            this.buttons_send.UseVisualStyleBackColor = false;
            this.buttons_send.Click += new System.EventHandler(this.buttons_send_Click);
            // 
            // FormReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 596);
            this.Controls.Add(this.buttons_send);
            this.Controls.Add(this.label_titolo_series);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBox_valutazione);
            this.Controls.Add(this.textBox_id_series);
            this.Controls.Add(this.label_value);
            this.Controls.Add(this.label_id_series);
            this.Controls.Add(this.label_torna_indietro);
            this.Controls.Add(this.panel_logo);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReview";
            this.Load += new System.EventHandler(this.FormReview_Load);
            this.panel_logo.ResumeLayout(false);
            this.panel_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Label label_titolo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_torna_indietro;
        private System.Windows.Forms.Label label_id_series;
        private System.Windows.Forms.Label label_value;
        private System.Windows.Forms.TextBox textBox_id_series;
        private System.Windows.Forms.ComboBox comboBox_valutazione;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_titolo_series;
        private Buttons buttons_send;
    }
}