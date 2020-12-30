
namespace vtysprojedeneme
{
    partial class yeniMusteri
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
            this.label3 = new System.Windows.Forms.Label();
            this.adSoyad = new System.Windows.Forms.TextBox();
            this.adres = new System.Windows.Forms.TextBox();
            this.telNo = new System.Windows.Forms.TextBox();
            this.TC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad        :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adres              :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cep No           :";
            // 
            // adSoyad
            // 
            this.adSoyad.Location = new System.Drawing.Point(116, 36);
            this.adSoyad.Name = "adSoyad";
            this.adSoyad.Size = new System.Drawing.Size(100, 20);
            this.adSoyad.TabIndex = 3;
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(116, 70);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(100, 20);
            this.adres.TabIndex = 4;
            // 
            // telNo
            // 
            this.telNo.Location = new System.Drawing.Point(116, 103);
            this.telNo.Name = "telNo";
            this.telNo.Size = new System.Drawing.Size(100, 20);
            this.telNo.TabIndex = 5;
            // 
            // TC
            // 
            this.TC.Location = new System.Drawing.Point(116, 138);
            this.TC.Name = "TC";
            this.TC.Size = new System.Drawing.Size(100, 20);
            this.TC.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "T.C Kimlik No  :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yeniMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(252, 230);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TC);
            this.Controls.Add(this.telNo);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.adSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "yeniMusteri";
            this.Text = "Yeni Müşteri";
            this.Load += new System.EventHandler(this.yeniMusteri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adSoyad;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.TextBox telNo;
        private System.Windows.Forms.TextBox TC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}