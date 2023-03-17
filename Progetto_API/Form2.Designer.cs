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
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_selected_language = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_n_pagine = new System.Windows.Forms.NumericUpDown();
            this.label_total_results = new System.Windows.Forms.Label();
            this.label_ris_trovati = new System.Windows.Forms.Label();
            this.label_total_pages = new System.Windows.Forms.Label();
            this.label_total_pages_result = new System.Windows.Forms.Label();
            this.label_id_series = new System.Windows.Forms.Label();
            this.textBox_id_series = new System.Windows.Forms.TextBox();
            this.label_pag_0 = new System.Windows.Forms.Label();
            this.label_pag_1 = new System.Windows.Forms.Label();
            this.label_pag_2 = new System.Windows.Forms.Label();
            this.label_pag_3 = new System.Windows.Forms.Label();
            this.label_pag_4 = new System.Windows.Forms.Label();
            this.label_pag_5 = new System.Windows.Forms.Label();
            this.label_pag_puntini = new System.Windows.Forms.Label();
            this.label_pag_tot = new System.Windows.Forms.Label();
            this.label_pag_6 = new System.Windows.Forms.Label();
            this.buttons_avvia_ric = new Progetto_API.Buttons();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel_logo.Margin = new System.Windows.Forms.Padding(4);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(1560, 123);
            this.panel_logo.TabIndex = 8;
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
            this.label_titolo.Size = new System.Drawing.Size(270, 51);
            this.label_titolo.TabIndex = 9;
            this.label_titolo.Text = "TOP RATED";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Progetto_API.Properties.Resources.esss;
            this.pictureBox1.Location = new System.Drawing.Point(1316, 34);
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
            this.label_torna_indietro.TabIndex = 9;
            this.label_torna_indietro.Text = "Indietro";
            this.label_torna_indietro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_torna_indietro.Click += new System.EventHandler(this.label_torna_indietro_Click);
            this.label_torna_indietro.MouseLeave += new System.EventHandler(this.label_torna_indietro_MouseLeave);
            this.label_torna_indietro.MouseHover += new System.EventHandler(this.label_torna_indietro_MouseHover);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Seleziona la lingua:";
            // 
            // comboBox_selected_language
            // 
            this.comboBox_selected_language.DropDownWidth = 250;
            this.comboBox_selected_language.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_selected_language.FormattingEnabled = true;
            this.comboBox_selected_language.Items.AddRange(new object[] {
            "en-US (Inglese, Stati Uniti)",
            "en-GB (Inglese, Regno Unito)",
            "es-ES (Spagnolo, Spagna)",
            "fr-FR (Francese, Francia)",
            "it-IT (Italiano, Italia)",
            "de-DE (Tedesco, Germania)",
            "pt-PT (Portoghese, Portogallo)",
            "pt-BR (Portoghese, Brasile)",
            "zh-CN (Cinese semplificato, Cina)",
            "zh-TW (Cinese tradizionale, Taiwan)",
            "ja-JP (Giapponese, Giappone)",
            "ko-KR (Coreano, Corea del Sud)",
            "ar-SA (Arabo, Arabia Saudita)",
            "hi-IN (Hindi, India)",
            "bn-BD (Bengalese, Bangladesh)",
            "ru-RU (Russo, Russia)",
            "tr-TR (Turco, Turchia)"});
            this.comboBox_selected_language.Location = new System.Drawing.Point(379, 171);
            this.comboBox_selected_language.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_selected_language.Name = "comboBox_selected_language";
            this.comboBox_selected_language.Size = new System.Drawing.Size(267, 27);
            this.comboBox_selected_language.TabIndex = 12;
            this.comboBox_selected_language.Text = "it-IT (Italiano, Italia)";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(684, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Seleziona il numero della pagina:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // numericUpDown_n_pagine
            // 
            this.numericUpDown_n_pagine.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_n_pagine.Location = new System.Drawing.Point(688, 170);
            this.numericUpDown_n_pagine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.numericUpDown_n_pagine.Size = new System.Drawing.Size(79, 27);
            this.numericUpDown_n_pagine.TabIndex = 14;
            this.numericUpDown_n_pagine.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_total_results
            // 
            this.label_total_results.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_total_results.AutoSize = true;
            this.label_total_results.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total_results.Location = new System.Drawing.Point(1441, 231);
            this.label_total_results.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_total_results.Name = "label_total_results";
            this.label_total_results.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_total_results.Size = new System.Drawing.Size(46, 23);
            this.label_total_results.TabIndex = 16;
            this.label_total_results.Text = "7000";
            this.label_total_results.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_total_results.Visible = false;
            // 
            // label_ris_trovati
            // 
            this.label_ris_trovati.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ris_trovati.AutoSize = true;
            this.label_ris_trovati.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ris_trovati.Location = new System.Drawing.Point(1395, 210);
            this.label_ris_trovati.Name = "label_ris_trovati";
            this.label_ris_trovati.Size = new System.Drawing.Size(133, 21);
            this.label_ris_trovati.TabIndex = 18;
            this.label_ris_trovati.Text = "Risultati trovati:";
            this.label_ris_trovati.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_ris_trovati.Visible = false;
            // 
            // label_total_pages
            // 
            this.label_total_pages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_total_pages.AutoSize = true;
            this.label_total_pages.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total_pages.Location = new System.Drawing.Point(1240, 210);
            this.label_total_pages.Name = "label_total_pages";
            this.label_total_pages.Size = new System.Drawing.Size(131, 21);
            this.label_total_pages.TabIndex = 20;
            this.label_total_pages.Text = "Pagine trovate:";
            this.label_total_pages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_total_pages.Visible = false;
            // 
            // label_total_pages_result
            // 
            this.label_total_pages_result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_total_pages_result.AutoSize = true;
            this.label_total_pages_result.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total_pages_result.Location = new System.Drawing.Point(1285, 231);
            this.label_total_pages_result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_total_pages_result.Name = "label_total_pages_result";
            this.label_total_pages_result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_total_pages_result.Size = new System.Drawing.Size(46, 23);
            this.label_total_pages_result.TabIndex = 19;
            this.label_total_pages_result.Text = "7000";
            this.label_total_pages_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_total_pages_result.Visible = false;
            // 
            // label_id_series
            // 
            this.label_id_series.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_id_series.AutoSize = true;
            this.label_id_series.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id_series.Location = new System.Drawing.Point(161, 148);
            this.label_id_series.Name = "label_id_series";
            this.label_id_series.Size = new System.Drawing.Size(75, 19);
            this.label_id_series.TabIndex = 21;
            this.label_id_series.Text = "ID Serie:";
            this.label_id_series.Visible = false;
            // 
            // textBox_id_series
            // 
            this.textBox_id_series.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id_series.Location = new System.Drawing.Point(165, 171);
            this.textBox_id_series.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_id_series.Name = "textBox_id_series";
            this.textBox_id_series.Size = new System.Drawing.Size(167, 29);
            this.textBox_id_series.TabIndex = 22;
            this.textBox_id_series.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_id_series.Visible = false;
            this.textBox_id_series.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_id_series_KeyPress);
            // 
            // label_pag_0
            // 
            this.label_pag_0.AutoSize = true;
            this.label_pag_0.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pag_0.Location = new System.Drawing.Point(508, 582);
            this.label_pag_0.Name = "label_pag_0";
            this.label_pag_0.Size = new System.Drawing.Size(55, 30);
            this.label_pag_0.TabIndex = 23;
            this.label_pag_0.Text = "100";
            this.label_pag_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_pag_0.Visible = false;
            this.label_pag_0.Click += new System.EventHandler(this.label_pag_Click);
            // 
            // label_pag_1
            // 
            this.label_pag_1.AutoSize = true;
            this.label_pag_1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pag_1.Location = new System.Drawing.Point(569, 582);
            this.label_pag_1.Name = "label_pag_1";
            this.label_pag_1.Size = new System.Drawing.Size(55, 30);
            this.label_pag_1.TabIndex = 24;
            this.label_pag_1.Text = "100";
            this.label_pag_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_pag_1.Visible = false;
            this.label_pag_1.Click += new System.EventHandler(this.label_pag_Click);
            // 
            // label_pag_2
            // 
            this.label_pag_2.AutoSize = true;
            this.label_pag_2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pag_2.Location = new System.Drawing.Point(630, 582);
            this.label_pag_2.Name = "label_pag_2";
            this.label_pag_2.Size = new System.Drawing.Size(55, 30);
            this.label_pag_2.TabIndex = 25;
            this.label_pag_2.Text = "100";
            this.label_pag_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_pag_2.Visible = false;
            this.label_pag_2.Click += new System.EventHandler(this.label_pag_Click);
            // 
            // label_pag_3
            // 
            this.label_pag_3.AutoSize = true;
            this.label_pag_3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pag_3.Location = new System.Drawing.Point(691, 582);
            this.label_pag_3.Name = "label_pag_3";
            this.label_pag_3.Size = new System.Drawing.Size(55, 30);
            this.label_pag_3.TabIndex = 26;
            this.label_pag_3.Text = "100";
            this.label_pag_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_pag_3.Visible = false;
            this.label_pag_3.Click += new System.EventHandler(this.label_pag_Click);
            // 
            // label_pag_4
            // 
            this.label_pag_4.AutoSize = true;
            this.label_pag_4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pag_4.Location = new System.Drawing.Point(752, 582);
            this.label_pag_4.Name = "label_pag_4";
            this.label_pag_4.Size = new System.Drawing.Size(55, 30);
            this.label_pag_4.TabIndex = 27;
            this.label_pag_4.Text = "100";
            this.label_pag_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_pag_4.Visible = false;
            this.label_pag_4.Click += new System.EventHandler(this.label_pag_Click);
            // 
            // label_pag_5
            // 
            this.label_pag_5.AutoSize = true;
            this.label_pag_5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pag_5.Location = new System.Drawing.Point(813, 582);
            this.label_pag_5.Name = "label_pag_5";
            this.label_pag_5.Size = new System.Drawing.Size(55, 30);
            this.label_pag_5.TabIndex = 28;
            this.label_pag_5.Text = "100";
            this.label_pag_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_pag_5.Visible = false;
            this.label_pag_5.Click += new System.EventHandler(this.label_pag_Click);
            // 
            // label_pag_puntini
            // 
            this.label_pag_puntini.AutoSize = true;
            this.label_pag_puntini.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pag_puntini.Location = new System.Drawing.Point(935, 582);
            this.label_pag_puntini.Name = "label_pag_puntini";
            this.label_pag_puntini.Size = new System.Drawing.Size(34, 30);
            this.label_pag_puntini.TabIndex = 29;
            this.label_pag_puntini.Text = "...";
            this.label_pag_puntini.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_pag_puntini.Visible = false;
            // 
            // label_pag_tot
            // 
            this.label_pag_tot.AutoSize = true;
            this.label_pag_tot.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pag_tot.Location = new System.Drawing.Point(975, 582);
            this.label_pag_tot.Name = "label_pag_tot";
            this.label_pag_tot.Size = new System.Drawing.Size(55, 30);
            this.label_pag_tot.TabIndex = 30;
            this.label_pag_tot.Text = "190";
            this.label_pag_tot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_pag_tot.Visible = false;
            this.label_pag_tot.Click += new System.EventHandler(this.label_pag_Click);
            // 
            // label_pag_6
            // 
            this.label_pag_6.AutoSize = true;
            this.label_pag_6.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pag_6.Location = new System.Drawing.Point(874, 582);
            this.label_pag_6.Name = "label_pag_6";
            this.label_pag_6.Size = new System.Drawing.Size(55, 30);
            this.label_pag_6.TabIndex = 31;
            this.label_pag_6.Text = "100";
            this.label_pag_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_pag_6.Visible = false;
            this.label_pag_6.Click += new System.EventHandler(this.label_pag_Click);
            // 
            // buttons_avvia_ric
            // 
            this.buttons_avvia_ric.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttons_avvia_ric.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttons_avvia_ric.FlatAppearance.BorderSize = 0;
            this.buttons_avvia_ric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons_avvia_ric.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttons_avvia_ric.ForeColor = System.Drawing.Color.White;
            this.buttons_avvia_ric.Location = new System.Drawing.Point(1008, 148);
            this.buttons_avvia_ric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttons_avvia_ric.Name = "buttons_avvia_ric";
            this.buttons_avvia_ric.Size = new System.Drawing.Size(209, 70);
            this.buttons_avvia_ric.TabIndex = 15;
            this.buttons_avvia_ric.Text = "AVVIA RICERCA";
            this.buttons_avvia_ric.UseVisualStyleBackColor = false;
            this.buttons_avvia_ric.Click += new System.EventHandler(this.buttons1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1555, 684);
            this.Controls.Add(this.label_pag_6);
            this.Controls.Add(this.label_pag_tot);
            this.Controls.Add(this.label_pag_puntini);
            this.Controls.Add(this.label_pag_5);
            this.Controls.Add(this.label_pag_4);
            this.Controls.Add(this.label_pag_3);
            this.Controls.Add(this.label_pag_2);
            this.Controls.Add(this.label_pag_1);
            this.Controls.Add(this.label_pag_0);
            this.Controls.Add(this.textBox_id_series);
            this.Controls.Add(this.label_id_series);
            this.Controls.Add(this.label_total_pages);
            this.Controls.Add(this.label_total_pages_result);
            this.Controls.Add(this.label_ris_trovati);
            this.Controls.Add(this.label_total_results);
            this.Controls.Add(this.buttons_avvia_ric);
            this.Controls.Add(this.numericUpDown_n_pagine);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_selected_language);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_torna_indietro);
            this.Controls.Add(this.panel_logo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel_logo.ResumeLayout(false);
            this.panel_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_n_pagine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Label label_titolo;
        private System.Windows.Forms.Label label_torna_indietro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_selected_language;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_n_pagine;
        private Buttons buttons_avvia_ric;
        private System.Windows.Forms.Label label_total_results;
        private System.Windows.Forms.Label label_ris_trovati;
        private System.Windows.Forms.Label label_total_pages;
        private System.Windows.Forms.Label label_total_pages_result;
        private System.Windows.Forms.Label label_id_series;
        private System.Windows.Forms.TextBox textBox_id_series;
        private System.Windows.Forms.Label label_pag_0;
        private System.Windows.Forms.Label label_pag_1;
        private System.Windows.Forms.Label label_pag_2;
        private System.Windows.Forms.Label label_pag_3;
        private System.Windows.Forms.Label label_pag_4;
        private System.Windows.Forms.Label label_pag_5;
        private System.Windows.Forms.Label label_pag_puntini;
        private System.Windows.Forms.Label label_pag_tot;
        private System.Windows.Forms.Label label_pag_6;
    }
}