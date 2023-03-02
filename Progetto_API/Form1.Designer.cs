namespace Progetto_API
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
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
            this.panel_logo = new System.Windows.Forms.Panel();
            this.label_benv = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttons_delete_review = new Progetto_API.Buttons();
            this.buttons_add_review = new Progetto_API.Buttons();
            this.buttons_get_latest = new Progetto_API.Buttons();
            this.buttons_get_similar = new Progetto_API.Buttons();
            this.button_get_popular = new Progetto_API.Buttons();
            this.button_top_rated = new Progetto_API.Buttons();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_logo
            // 
            this.panel_logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_logo.Controls.Add(this.pictureBox1);
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(1104, 100);
            this.panel_logo.TabIndex = 7;
            // 
            // label_benv
            // 
            this.label_benv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_benv.AutoSize = true;
            this.label_benv.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_benv.ForeColor = System.Drawing.Color.Coral;
            this.label_benv.Location = new System.Drawing.Point(486, 121);
            this.label_benv.Name = "label_benv";
            this.label_benv.Size = new System.Drawing.Size(129, 25);
            this.label_benv.TabIndex = 8;
            this.label_benv.Text = "BENVENUTO!!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Progetto_API.Properties.Resources.esss;
            this.pictureBox1.Location = new System.Drawing.Point(48, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttons_delete_review
            // 
            this.buttons_delete_review.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttons_delete_review.BackColor = System.Drawing.Color.Brown;
            this.buttons_delete_review.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttons_delete_review.FlatAppearance.BorderSize = 0;
            this.buttons_delete_review.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons_delete_review.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttons_delete_review.ForeColor = System.Drawing.Color.White;
            this.buttons_delete_review.Image = global::Progetto_API.Properties.Resources.icons8_delete_45;
            this.buttons_delete_review.Location = new System.Drawing.Point(763, 420);
            this.buttons_delete_review.Margin = new System.Windows.Forms.Padding(4);
            this.buttons_delete_review.Name = "buttons_delete_review";
            this.buttons_delete_review.Size = new System.Drawing.Size(290, 138);
            this.buttons_delete_review.TabIndex = 6;
            this.buttons_delete_review.Text = "DELETE REVIEW";
            this.buttons_delete_review.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttons_delete_review.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttons_delete_review.UseVisualStyleBackColor = false;
            // 
            // buttons_add_review
            // 
            this.buttons_add_review.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttons_add_review.BackColor = System.Drawing.Color.Orange;
            this.buttons_add_review.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttons_add_review.FlatAppearance.BorderSize = 0;
            this.buttons_add_review.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons_add_review.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttons_add_review.ForeColor = System.Drawing.Color.White;
            this.buttons_add_review.Image = global::Progetto_API.Properties.Resources.icons8_thumbs_up_down_50;
            this.buttons_add_review.Location = new System.Drawing.Point(405, 420);
            this.buttons_add_review.Margin = new System.Windows.Forms.Padding(4);
            this.buttons_add_review.Name = "buttons_add_review";
            this.buttons_add_review.Size = new System.Drawing.Size(290, 138);
            this.buttons_add_review.TabIndex = 5;
            this.buttons_add_review.Text = "ADD REVIEW";
            this.buttons_add_review.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttons_add_review.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttons_add_review.UseVisualStyleBackColor = false;
            // 
            // buttons_get_latest
            // 
            this.buttons_get_latest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttons_get_latest.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttons_get_latest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttons_get_latest.FlatAppearance.BorderSize = 0;
            this.buttons_get_latest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons_get_latest.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttons_get_latest.ForeColor = System.Drawing.Color.White;
            this.buttons_get_latest.Image = global::Progetto_API.Properties.Resources.icons8_tv_50;
            this.buttons_get_latest.Location = new System.Drawing.Point(47, 420);
            this.buttons_get_latest.Margin = new System.Windows.Forms.Padding(4);
            this.buttons_get_latest.Name = "buttons_get_latest";
            this.buttons_get_latest.Size = new System.Drawing.Size(290, 138);
            this.buttons_get_latest.TabIndex = 4;
            this.buttons_get_latest.Text = "GET LATEST";
            this.buttons_get_latest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttons_get_latest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttons_get_latest.UseVisualStyleBackColor = false;
            // 
            // buttons_get_similar
            // 
            this.buttons_get_similar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttons_get_similar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttons_get_similar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttons_get_similar.FlatAppearance.BorderSize = 0;
            this.buttons_get_similar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons_get_similar.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttons_get_similar.ForeColor = System.Drawing.Color.White;
            this.buttons_get_similar.Image = global::Progetto_API.Properties.Resources.icons8_similar_items_60;
            this.buttons_get_similar.Location = new System.Drawing.Point(763, 230);
            this.buttons_get_similar.Margin = new System.Windows.Forms.Padding(4);
            this.buttons_get_similar.Name = "buttons_get_similar";
            this.buttons_get_similar.Size = new System.Drawing.Size(290, 138);
            this.buttons_get_similar.TabIndex = 3;
            this.buttons_get_similar.Text = "GET SIMILAR";
            this.buttons_get_similar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttons_get_similar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttons_get_similar.UseVisualStyleBackColor = false;
            this.buttons_get_similar.Click += new System.EventHandler(this.buttons2_Click);
            // 
            // button_get_popular
            // 
            this.button_get_popular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_get_popular.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_get_popular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_get_popular.FlatAppearance.BorderSize = 0;
            this.button_get_popular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_get_popular.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_get_popular.ForeColor = System.Drawing.Color.White;
            this.button_get_popular.Image = global::Progetto_API.Properties.Resources.icons8_discussione_molto_in_voga_40;
            this.button_get_popular.Location = new System.Drawing.Point(405, 230);
            this.button_get_popular.Margin = new System.Windows.Forms.Padding(4);
            this.button_get_popular.Name = "button_get_popular";
            this.button_get_popular.Size = new System.Drawing.Size(290, 138);
            this.button_get_popular.TabIndex = 2;
            this.button_get_popular.Text = "GET POPULAR";
            this.button_get_popular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_get_popular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_get_popular.UseVisualStyleBackColor = false;
            this.button_get_popular.Click += new System.EventHandler(this.button_get_popular_Click);
            // 
            // button_top_rated
            // 
            this.button_top_rated.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_top_rated.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_top_rated.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_top_rated.FlatAppearance.BorderSize = 0;
            this.button_top_rated.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_top_rated.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_top_rated.ForeColor = System.Drawing.Color.White;
            this.button_top_rated.Image = global::Progetto_API.Properties.Resources.icons8_top_rated_64__2_;
            this.button_top_rated.Location = new System.Drawing.Point(48, 231);
            this.button_top_rated.Margin = new System.Windows.Forms.Padding(4);
            this.button_top_rated.Name = "button_top_rated";
            this.button_top_rated.Size = new System.Drawing.Size(290, 138);
            this.button_top_rated.TabIndex = 0;
            this.button_top_rated.Text = "TOP RATED";
            this.button_top_rated.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_top_rated.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_top_rated.UseVisualStyleBackColor = false;
            this.button_top_rated.Click += new System.EventHandler(this.buttons1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 647);
            this.Controls.Add(this.label_benv);
            this.Controls.Add(this.panel_logo);
            this.Controls.Add(this.buttons_delete_review);
            this.Controls.Add(this.buttons_add_review);
            this.Controls.Add(this.buttons_get_latest);
            this.Controls.Add(this.buttons_get_similar);
            this.Controls.Add(this.button_get_popular);
            this.Controls.Add(this.button_top_rated);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_logo.ResumeLayout(false);
            this.panel_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Buttons button_top_rated;
        private Buttons button_get_popular;
        private Buttons buttons_get_similar;
        private Buttons buttons_delete_review;
        private Buttons buttons_add_review;
        private Buttons buttons_get_latest;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_benv;
    }
}

