
namespace HesaplamaUygulamasi
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
            this.lbl_Sayi1 = new System.Windows.Forms.Label();
            this.lbl_Sayi2 = new System.Windows.Forms.Label();
            this.txt_Sayi1 = new System.Windows.Forms.TextBox();
            this.txt_Sayi2 = new System.Windows.Forms.TextBox();
            this.btn_Topla = new System.Windows.Forms.Button();
            this.btn_Cikar = new System.Windows.Forms.Button();
            this.btn_Carp = new System.Windows.Forms.Button();
            this.btn_Bol = new System.Windows.Forms.Button();
            this.lbl_Sonuc = new System.Windows.Forms.Label();
            this.txt_Sonuc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Sayi1
            // 
            this.lbl_Sayi1.AutoSize = true;
            this.lbl_Sayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Sayi1.Location = new System.Drawing.Point(24, 22);
            this.lbl_Sayi1.Name = "lbl_Sayi1";
            this.lbl_Sayi1.Size = new System.Drawing.Size(193, 20);
            this.lbl_Sayi1.TabIndex = 0;
            this.lbl_Sayi1.Text = "Lütfen 1. Sayıyı Giriniz:";
            // 
            // lbl_Sayi2
            // 
            this.lbl_Sayi2.AutoSize = true;
            this.lbl_Sayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Sayi2.Location = new System.Drawing.Point(24, 57);
            this.lbl_Sayi2.Name = "lbl_Sayi2";
            this.lbl_Sayi2.Size = new System.Drawing.Size(193, 20);
            this.lbl_Sayi2.TabIndex = 0;
            this.lbl_Sayi2.Text = "Lütfen 2. Sayıyı Giriniz:";
            // 
            // txt_Sayi1
            // 
            this.txt_Sayi1.Location = new System.Drawing.Point(248, 22);
            this.txt_Sayi1.Name = "txt_Sayi1";
            this.txt_Sayi1.Size = new System.Drawing.Size(118, 20);
            this.txt_Sayi1.TabIndex = 1;
            this.txt_Sayi1.TextChanged += new System.EventHandler(this.txt_Sayi1_TextChanged);
            // 
            // txt_Sayi2
            // 
            this.txt_Sayi2.Location = new System.Drawing.Point(248, 57);
            this.txt_Sayi2.Name = "txt_Sayi2";
            this.txt_Sayi2.Size = new System.Drawing.Size(118, 20);
            this.txt_Sayi2.TabIndex = 1;
            // 
            // btn_Topla
            // 
            this.btn_Topla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Topla.Location = new System.Drawing.Point(156, 149);
            this.btn_Topla.Name = "btn_Topla";
            this.btn_Topla.Size = new System.Drawing.Size(36, 28);
            this.btn_Topla.TabIndex = 2;
            this.btn_Topla.Text = "+";
            this.btn_Topla.UseVisualStyleBackColor = true;
            this.btn_Topla.Click += new System.EventHandler(this.btn_Topla_Click);
            // 
            // btn_Cikar
            // 
            this.btn_Cikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Cikar.Location = new System.Drawing.Point(217, 149);
            this.btn_Cikar.Name = "btn_Cikar";
            this.btn_Cikar.Size = new System.Drawing.Size(36, 28);
            this.btn_Cikar.TabIndex = 2;
            this.btn_Cikar.Text = "-";
            this.btn_Cikar.UseVisualStyleBackColor = true;
            this.btn_Cikar.Click += new System.EventHandler(this.btn_Cikar_Click);
            // 
            // btn_Carp
            // 
            this.btn_Carp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Carp.Location = new System.Drawing.Point(268, 149);
            this.btn_Carp.Name = "btn_Carp";
            this.btn_Carp.Size = new System.Drawing.Size(36, 28);
            this.btn_Carp.TabIndex = 2;
            this.btn_Carp.Text = "*";
            this.btn_Carp.UseVisualStyleBackColor = true;
            this.btn_Carp.Click += new System.EventHandler(this.btn_Carp_Click);
            // 
            // btn_Bol
            // 
            this.btn_Bol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Bol.Location = new System.Drawing.Point(324, 149);
            this.btn_Bol.Name = "btn_Bol";
            this.btn_Bol.Size = new System.Drawing.Size(36, 28);
            this.btn_Bol.TabIndex = 2;
            this.btn_Bol.Text = "/";
            this.btn_Bol.UseVisualStyleBackColor = true;
            this.btn_Bol.Click += new System.EventHandler(this.btn_Bol_Click);
            // 
            // lbl_Sonuc
            // 
            this.lbl_Sonuc.AutoSize = true;
            this.lbl_Sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Sonuc.Location = new System.Drawing.Point(152, 96);
            this.lbl_Sonuc.Name = "lbl_Sonuc";
            this.lbl_Sonuc.Size = new System.Drawing.Size(65, 20);
            this.lbl_Sonuc.TabIndex = 0;
            this.lbl_Sonuc.Text = "Sonuç:";
            // 
            // txt_Sonuc
            // 
            this.txt_Sonuc.Location = new System.Drawing.Point(248, 98);
            this.txt_Sonuc.Name = "txt_Sonuc";
            this.txt_Sonuc.Size = new System.Drawing.Size(118, 20);
            this.txt_Sonuc.TabIndex = 1;
            this.txt_Sonuc.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 224);
            this.Controls.Add(this.btn_Bol);
            this.Controls.Add(this.btn_Carp);
            this.Controls.Add(this.btn_Cikar);
            this.Controls.Add(this.btn_Topla);
            this.Controls.Add(this.txt_Sonuc);
            this.Controls.Add(this.txt_Sayi2);
            this.Controls.Add(this.txt_Sayi1);
            this.Controls.Add(this.lbl_Sonuc);
            this.Controls.Add(this.lbl_Sayi2);
            this.Controls.Add(this.lbl_Sayi1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Sayi1;
        private System.Windows.Forms.Label lbl_Sayi2;
        private System.Windows.Forms.TextBox txt_Sayi1;
        private System.Windows.Forms.TextBox txt_Sayi2;
        private System.Windows.Forms.Button btn_Topla;
        private System.Windows.Forms.Button btn_Cikar;
        private System.Windows.Forms.Button btn_Carp;
        private System.Windows.Forms.Button btn_Bol;
        private System.Windows.Forms.Label lbl_Sonuc;
        private System.Windows.Forms.TextBox txt_Sonuc;
    }
}

