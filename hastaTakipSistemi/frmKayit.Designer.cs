namespace hastaTakipSistemi
{
    partial class frmKayit
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKAdi1 = new System.Windows.Forms.TextBox();
            this.txtSifre1 = new System.Windows.Forms.TextBox();
            this.btnKayit = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtKAdi1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtSifre1, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(65, 27);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(473, 88);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 44);
            this.label4.TabIndex = 5;
            this.label4.Text = "Şifre";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Adı ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKAdi1
            // 
            this.txtKAdi1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKAdi1.Location = new System.Drawing.Point(239, 3);
            this.txtKAdi1.Multiline = true;
            this.txtKAdi1.Name = "txtKAdi1";
            this.txtKAdi1.Size = new System.Drawing.Size(231, 38);
            this.txtKAdi1.TabIndex = 4;
            this.txtKAdi1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKAdi1.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtSifre1
            // 
            this.txtSifre1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSifre1.Location = new System.Drawing.Point(239, 47);
            this.txtSifre1.Multiline = true;
            this.txtSifre1.Name = "txtSifre1";
            this.txtSifre1.Size = new System.Drawing.Size(231, 38);
            this.txtSifre1.TabIndex = 6;
            this.txtSifre1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(235, 155);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(134, 37);
            this.btnKayit.TabIndex = 6;
            this.btnKayit.Text = "Kayıt Ol";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // frmKayit
            // 
            this.ClientSize = new System.Drawing.Size(599, 261);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "frmKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmKayit_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label txtSifre;
        private System.Windows.Forms.Label txtKAdi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtSifre1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKAdi1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKayit;
    }
}