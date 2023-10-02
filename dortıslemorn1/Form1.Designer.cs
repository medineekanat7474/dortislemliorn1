namespace dortıslemorn1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblTopla = new System.Windows.Forms.Label();
            this.lblCikar = new System.Windows.Forms.Label();
            this.lblCarp = new System.Windows.Forms.Label();
            this.lblBol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(55, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "sayı1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(55, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "sayı2";
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(120, 43);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(100, 20);
            this.txtSayi1.TabIndex = 2;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(120, 83);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(100, 20);
            this.txtSayi2.TabIndex = 3;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(120, 131);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 37);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblTopla
            // 
            this.lblTopla.AutoSize = true;
            this.lblTopla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTopla.Location = new System.Drawing.Point(271, 51);
            this.lblTopla.Name = "lblTopla";
            this.lblTopla.Size = new System.Drawing.Size(46, 16);
            this.lblTopla.TabIndex = 5;
            this.lblTopla.Text = "Topla:";
            // 
            // lblCikar
            // 
            this.lblCikar.AutoSize = true;
            this.lblCikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCikar.Location = new System.Drawing.Point(271, 83);
            this.lblCikar.Name = "lblCikar";
            this.lblCikar.Size = new System.Drawing.Size(41, 16);
            this.lblCikar.TabIndex = 6;
            this.lblCikar.Text = "Çıkar:";
            // 
            // lblCarp
            // 
            this.lblCarp.AutoSize = true;
            this.lblCarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCarp.Location = new System.Drawing.Point(271, 112);
            this.lblCarp.Name = "lblCarp";
            this.lblCarp.Size = new System.Drawing.Size(39, 16);
            this.lblCarp.TabIndex = 7;
            this.lblCarp.Text = "Çarp:";
            // 
            // lblBol
            // 
            this.lblBol.AutoSize = true;
            this.lblBol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBol.Location = new System.Drawing.Point(271, 143);
            this.lblBol.Name = "lblBol";
            this.lblBol.Size = new System.Drawing.Size(30, 16);
            this.lblBol.TabIndex = 8;
            this.lblBol.Text = "Böl:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 245);
            this.Controls.Add(this.lblBol);
            this.Controls.Add(this.lblCarp);
            this.Controls.Add(this.lblCikar);
            this.Controls.Add(this.lblTopla);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblTopla;
        private System.Windows.Forms.Label lblCikar;
        private System.Windows.Forms.Label lblCarp;
        private System.Windows.Forms.Label lblBol;
    }
}

