namespace CSharp_TinhDiem
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
            this.lblTen = new System.Windows.Forms.Label();
            this.lblToan = new System.Windows.Forms.Label();
            this.lblVan = new System.Windows.Forms.Label();
            this.lblTB = new System.Windows.Forms.Label();
            this.lblXepLoai = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtToan = new System.Windows.Forms.TextBox();
            this.txtVan = new System.Windows.Forms.TextBox();
            this.txtTB = new System.Windows.Forms.TextBox();
            this.txtXepLoai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTTBinh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(50, 77);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(34, 18);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Tên";
            // 
            // lblToan
            // 
            this.lblToan.AutoSize = true;
            this.lblToan.Location = new System.Drawing.Point(50, 130);
            this.lblToan.Name = "lblToan";
            this.lblToan.Size = new System.Drawing.Size(47, 18);
            this.lblToan.TabIndex = 0;
            this.lblToan.Text = "Toán ";
            // 
            // lblVan
            // 
            this.lblVan.AutoSize = true;
            this.lblVan.Location = new System.Drawing.Point(50, 183);
            this.lblVan.Name = "lblVan";
            this.lblVan.Size = new System.Drawing.Size(38, 18);
            this.lblVan.TabIndex = 0;
            this.lblVan.Text = "Văn ";
            // 
            // lblTB
            // 
            this.lblTB.AutoSize = true;
            this.lblTB.Location = new System.Drawing.Point(50, 236);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(84, 18);
            this.lblTB.TabIndex = 0;
            this.lblTB.Text = "Trung Bình ";
            // 
            // lblXepLoai
            // 
            this.lblXepLoai.AutoSize = true;
            this.lblXepLoai.Location = new System.Drawing.Point(50, 289);
            this.lblXepLoai.Name = "lblXepLoai";
            this.lblXepLoai.Size = new System.Drawing.Size(63, 18);
            this.lblXepLoai.TabIndex = 0;
            this.lblXepLoai.Text = "Xếp loại ";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(172, 77);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(268, 26);
            this.txtTen.TabIndex = 1;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // txtToan
            // 
            this.txtToan.Location = new System.Drawing.Point(172, 130);
            this.txtToan.Name = "txtToan";
            this.txtToan.Size = new System.Drawing.Size(268, 26);
            this.txtToan.TabIndex = 1;
            // 
            // txtVan
            // 
            this.txtVan.Location = new System.Drawing.Point(172, 183);
            this.txtVan.Name = "txtVan";
            this.txtVan.Size = new System.Drawing.Size(268, 26);
            this.txtVan.TabIndex = 1;
            // 
            // txtTB
            // 
            this.txtTB.Location = new System.Drawing.Point(172, 236);
            this.txtTB.Name = "txtTB";
            this.txtTB.Size = new System.Drawing.Size(268, 26);
            this.txtTB.TabIndex = 1;
            // 
            // txtXepLoai
            // 
            this.txtXepLoai.Location = new System.Drawing.Point(172, 289);
            this.txtXepLoai.Name = "txtXepLoai";
            this.txtXepLoai.Size = new System.Drawing.Size(268, 26);
            this.txtXepLoai.TabIndex = 1;
            this.txtXepLoai.TextChanged += new System.EventHandler(this.txtXepLoai_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(456, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 35);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tính Điểm";
            this.label6.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label6_MouseDoubleClick);
            // 
            // btnTTBinh
            // 
            this.btnTTBinh.Location = new System.Drawing.Point(182, 404);
            this.btnTTBinh.Name = "btnTTBinh";
            this.btnTTBinh.Size = new System.Drawing.Size(177, 38);
            this.btnTTBinh.TabIndex = 3;
            this.btnTTBinh.Text = "Tính Trung Bình";
            this.btnTTBinh.UseVisualStyleBackColor = true;
            this.btnTTBinh.Click += new System.EventHandler(this.btnTTBinh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(506, 404);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(177, 38);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát ";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 623);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTTBinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtXepLoai);
            this.Controls.Add(this.txtTB);
            this.Controls.Add(this.txtVan);
            this.Controls.Add(this.txtToan);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblXepLoai);
            this.Controls.Add(this.lblTB);
            this.Controls.Add(this.lblVan);
            this.Controls.Add(this.lblToan);
            this.Controls.Add(this.lblTen);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblToan;
        private System.Windows.Forms.Label lblVan;
        private System.Windows.Forms.Label lblTB;
        private System.Windows.Forms.Label lblXepLoai;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtToan;
        private System.Windows.Forms.TextBox txtVan;
        private System.Windows.Forms.TextBox txtTB;
        private System.Windows.Forms.TextBox txtXepLoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTTBinh;
        private System.Windows.Forms.Button btnThoat;
    }
}

