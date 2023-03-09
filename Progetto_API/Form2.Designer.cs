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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_torna_indietro = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_titolo_series = new System.Windows.Forms.Label();
            this.pictureBox_image_serie = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_selected_language = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_n_pagine = new System.Windows.Forms.NumericUpDown();
            this.buttons_avvia_ric = new Progetto_API.Buttons();
            this.label_total_results = new System.Windows.Forms.Label();
            this.label_prova = new System.Windows.Forms.Label();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image_serie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_n_pagine)).BeginInit();
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label_titolo_series);
            this.panel1.Controls.Add(this.pictureBox_image_serie);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(30, 210);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 342);
            this.panel1.TabIndex = 10;
            // 
            // label_titolo_series
            // 
            this.label_titolo_series.AutoSize = true;
            this.label_titolo_series.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titolo_series.Location = new System.Drawing.Point(98, 271);
            this.label_titolo_series.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_titolo_series.Name = "label_titolo_series";
            this.label_titolo_series.Size = new System.Drawing.Size(57, 16);
            this.label_titolo_series.TabIndex = 11;
            this.label_titolo_series.Text = "TITOLO";
            // 
            // pictureBox_image_serie
            // 
            this.pictureBox_image_serie.Location = new System.Drawing.Point(59, 40);
            this.pictureBox_image_serie.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_image_serie.Name = "pictureBox_image_serie";
            this.pictureBox_image_serie.Size = new System.Drawing.Size(136, 189);
            this.pictureBox_image_serie.TabIndex = 11;
            this.pictureBox_image_serie.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Seleziona la lingua:";
            // 
            // comboBox_selected_language
            // 
            this.comboBox_selected_language.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_selected_language.FormattingEnabled = true;
            this.comboBox_selected_language.Location = new System.Drawing.Point(289, 136);
            this.comboBox_selected_language.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_selected_language.Name = "comboBox_selected_language";
            this.comboBox_selected_language.Size = new System.Drawing.Size(104, 24);
            this.comboBox_selected_language.TabIndex = 12;
            this.comboBox_selected_language.Text = "it-IT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(444, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Seleziona il numero di pagine:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // numericUpDown_n_pagine
            // 
            this.numericUpDown_n_pagine.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_n_pagine.Location = new System.Drawing.Point(446, 137);
            this.numericUpDown_n_pagine.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_n_pagine.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_n_pagine.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_n_pagine.Name = "numericUpDown_n_pagine";
            this.numericUpDown_n_pagine.Size = new System.Drawing.Size(38, 23);
            this.numericUpDown_n_pagine.TabIndex = 14;
            this.numericUpDown_n_pagine.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttons_avvia_ric
            // 
            this.buttons_avvia_ric.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttons_avvia_ric.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttons_avvia_ric.FlatAppearance.BorderSize = 0;
            this.buttons_avvia_ric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons_avvia_ric.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttons_avvia_ric.ForeColor = System.Drawing.Color.White;
            this.buttons_avvia_ric.Location = new System.Drawing.Point(654, 120);
            this.buttons_avvia_ric.Margin = new System.Windows.Forms.Padding(2);
            this.buttons_avvia_ric.Name = "buttons_avvia_ric";
            this.buttons_avvia_ric.Size = new System.Drawing.Size(131, 46);
            this.buttons_avvia_ric.TabIndex = 15;
            this.buttons_avvia_ric.Text = "AVVIA RICERCA";
            this.buttons_avvia_ric.UseVisualStyleBackColor = false;
            this.buttons_avvia_ric.Click += new System.EventHandler(this.buttons1_Click);
            // 
            // label_total_results
            // 
            this.label_total_results.AutoSize = true;
            this.label_total_results.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total_results.Location = new System.Drawing.Point(962, 132);
            this.label_total_results.Name = "label_total_results";
            this.label_total_results.Size = new System.Drawing.Size(122, 20);
            this.label_total_results.TabIndex = 16;
            this.label_total_results.Text = "label_total_results";
            // 
            // label_prova
            // 
            this.label_prova.AutoSize = true;
            this.label_prova.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prova.Location = new System.Drawing.Point(348, 330);
            this.label_prova.Name = "label_prova";
            this.label_prova.Size = new System.Drawing.Size(83, 18);
            this.label_prova.TabIndex = 17;
            this.label_prova.Text = "label_prova";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 596);
            this.Controls.Add(this.label_prova);
            this.Controls.Add(this.label_total_results);
            this.Controls.Add(this.buttons_avvia_ric);
            this.Controls.Add(this.numericUpDown_n_pagine);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_selected_language);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_torna_indietro);
            this.Controls.Add(this.panel_logo);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel_logo.ResumeLayout(false);
            this.panel_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image_serie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_n_pagine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Label label_titolo;
        private System.Windows.Forms.Label label_torna_indietro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_titolo_series;
        private System.Windows.Forms.PictureBox pictureBox_image_serie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_selected_language;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_n_pagine;
        private Buttons buttons_avvia_ric;
        private System.Windows.Forms.Label label_total_results;
        private System.Windows.Forms.Label label_prova;
    }
}