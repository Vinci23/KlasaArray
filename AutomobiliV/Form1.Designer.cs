namespace AutomobiliV
{
    partial class Form1
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
            this.btnNovi = new System.Windows.Forms.Button();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.txtNovi = new System.Windows.Forms.TextBox();
            this.rtbispis = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnNovi
            // 
            this.btnNovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNovi.Location = new System.Drawing.Point(109, 33);
            this.btnNovi.Name = "btnNovi";
            this.btnNovi.Size = new System.Drawing.Size(163, 41);
            this.btnNovi.TabIndex = 0;
            this.btnNovi.Text = "Novi automobil";
            this.btnNovi.UseVisualStyleBackColor = true;
            this.btnNovi.Click += new System.EventHandler(this.btnNovi_Click);
            // 
            // btnUnesi
            // 
            this.btnUnesi.Enabled = false;
            this.btnUnesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUnesi.Location = new System.Drawing.Point(482, 98);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(93, 40);
            this.btnUnesi.TabIndex = 1;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisi.Location = new System.Drawing.Point(109, 377);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(90, 39);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // txtNovi
            // 
            this.txtNovi.Enabled = false;
            this.txtNovi.Location = new System.Drawing.Point(109, 98);
            this.txtNovi.Multiline = true;
            this.txtNovi.Name = "txtNovi";
            this.txtNovi.Size = new System.Drawing.Size(351, 40);
            this.txtNovi.TabIndex = 3;
            // 
            // rtbispis
            // 
            this.rtbispis.Location = new System.Drawing.Point(109, 159);
            this.rtbispis.Name = "rtbispis";
            this.rtbispis.Size = new System.Drawing.Size(507, 212);
            this.rtbispis.TabIndex = 4;
            this.rtbispis.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbispis);
            this.Controls.Add(this.txtNovi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.btnNovi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.TextBox txtNovi;
        private System.Windows.Forms.RichTextBox rtbispis;
    }
}

