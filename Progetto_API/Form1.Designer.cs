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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button__top_rated = new Progetto_API.Buttons();
            this.button_get_popular = new Progetto_API.Buttons();
            this.buttons2 = new Progetto_API.Buttons();
            this.buttons1 = new Progetto_API.Buttons();
            this.buttons3 = new Progetto_API.Buttons();
            this.buttons4 = new Progetto_API.Buttons();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(374, 90);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(379, 30);
            this.textBox1.TabIndex = 1;
            // 
            // button__top_rated
            // 
            this.button__top_rated.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button__top_rated.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button__top_rated.FlatAppearance.BorderSize = 0;
            this.button__top_rated.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button__top_rated.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button__top_rated.ForeColor = System.Drawing.Color.White;
            this.button__top_rated.Location = new System.Drawing.Point(47, 230);
            this.button__top_rated.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button__top_rated.Name = "button__top_rated";
            this.button__top_rated.Size = new System.Drawing.Size(290, 138);
            this.button__top_rated.TabIndex = 0;
            this.button__top_rated.Text = "TOP RATED";
            this.button__top_rated.UseVisualStyleBackColor = false;
            this.button__top_rated.Click += new System.EventHandler(this.buttons1_Click);
            // 
            // button_get_popular
            // 
            this.button_get_popular.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_get_popular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_get_popular.FlatAppearance.BorderSize = 0;
            this.button_get_popular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_get_popular.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_get_popular.ForeColor = System.Drawing.Color.White;
            this.button_get_popular.Location = new System.Drawing.Point(405, 230);
            this.button_get_popular.Margin = new System.Windows.Forms.Padding(4);
            this.button_get_popular.Name = "button_get_popular";
            this.button_get_popular.Size = new System.Drawing.Size(290, 138);
            this.button_get_popular.TabIndex = 2;
            this.button_get_popular.Text = "GET POPULAR";
            this.button_get_popular.UseVisualStyleBackColor = false;
            // 
            // buttons2
            // 
            this.buttons2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttons2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttons2.FlatAppearance.BorderSize = 0;
            this.buttons2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttons2.ForeColor = System.Drawing.Color.White;
            this.buttons2.Location = new System.Drawing.Point(763, 230);
            this.buttons2.Margin = new System.Windows.Forms.Padding(4);
            this.buttons2.Name = "buttons2";
            this.buttons2.Size = new System.Drawing.Size(290, 138);
            this.buttons2.TabIndex = 3;
            this.buttons2.Text = "GET SIMILAR";
            this.buttons2.UseVisualStyleBackColor = false;
            this.buttons2.Click += new System.EventHandler(this.buttons2_Click);
            // 
            // buttons1
            // 
            this.buttons1.BackColor = System.Drawing.Color.Brown;
            this.buttons1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttons1.FlatAppearance.BorderSize = 0;
            this.buttons1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttons1.ForeColor = System.Drawing.Color.White;
            this.buttons1.Location = new System.Drawing.Point(763, 420);
            this.buttons1.Margin = new System.Windows.Forms.Padding(4);
            this.buttons1.Name = "buttons1";
            this.buttons1.Size = new System.Drawing.Size(290, 138);
            this.buttons1.TabIndex = 6;
            this.buttons1.Text = "DELETE REVIEW";
            this.buttons1.UseVisualStyleBackColor = false;
            // 
            // buttons3
            // 
            this.buttons3.BackColor = System.Drawing.Color.Orange;
            this.buttons3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttons3.FlatAppearance.BorderSize = 0;
            this.buttons3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttons3.ForeColor = System.Drawing.Color.White;
            this.buttons3.Location = new System.Drawing.Point(405, 420);
            this.buttons3.Margin = new System.Windows.Forms.Padding(4);
            this.buttons3.Name = "buttons3";
            this.buttons3.Size = new System.Drawing.Size(290, 138);
            this.buttons3.TabIndex = 5;
            this.buttons3.Text = "ADD REVIEW";
            this.buttons3.UseVisualStyleBackColor = false;
            // 
            // buttons4
            // 
            this.buttons4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttons4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttons4.FlatAppearance.BorderSize = 0;
            this.buttons4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttons4.ForeColor = System.Drawing.Color.White;
            this.buttons4.Location = new System.Drawing.Point(47, 420);
            this.buttons4.Margin = new System.Windows.Forms.Padding(4);
            this.buttons4.Name = "buttons4";
            this.buttons4.Size = new System.Drawing.Size(290, 138);
            this.buttons4.TabIndex = 4;
            this.buttons4.Text = "GET LATEST";
            this.buttons4.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 647);
            this.Controls.Add(this.buttons1);
            this.Controls.Add(this.buttons3);
            this.Controls.Add(this.buttons4);
            this.Controls.Add(this.buttons2);
            this.Controls.Add(this.button_get_popular);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button__top_rated);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Buttons button__top_rated;
        private System.Windows.Forms.TextBox textBox1;
        private Buttons button_get_popular;
        private Buttons buttons2;
        private Buttons buttons1;
        private Buttons buttons3;
        private Buttons buttons4;
    }
}

