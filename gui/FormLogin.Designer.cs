namespace GUI
{
    partial class FormLogin
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
            this.taikhoan = new System.Windows.Forms.Label();
            this.matkhau = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.checkBoxHTMK = new System.Windows.Forms.CheckBox();
            this.dangnhap = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taikhoan
            // 
            this.taikhoan.AutoSize = true;
            this.taikhoan.BackColor = System.Drawing.Color.Transparent;
            this.taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taikhoan.ForeColor = System.Drawing.Color.Black;
            this.taikhoan.Location = new System.Drawing.Point(114, 163);
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.Size = new System.Drawing.Size(108, 25);
            this.taikhoan.TabIndex = 1;
            this.taikhoan.Text = "Tài khoản";
            // 
            // matkhau
            // 
            this.matkhau.AutoSize = true;
            this.matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matkhau.Location = new System.Drawing.Point(121, 247);
            this.matkhau.Name = "matkhau";
            this.matkhau.Size = new System.Drawing.Size(101, 25);
            this.matkhau.TabIndex = 2;
            this.matkhau.Text = "Mật khẩu";
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(282, 154);
            this.user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(303, 34);
            this.user.TabIndex = 3;
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(282, 238);
            this.pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(303, 34);
            this.pass.TabIndex = 4;
            this.pass.UseSystemPasswordChar = true;
            // 
            // checkBoxHTMK
            // 
            this.checkBoxHTMK.AutoSize = true;
            this.checkBoxHTMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHTMK.Location = new System.Drawing.Point(282, 305);
            this.checkBoxHTMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxHTMK.Name = "checkBoxHTMK";
            this.checkBoxHTMK.Size = new System.Drawing.Size(130, 20);
            this.checkBoxHTMK.TabIndex = 5;
            this.checkBoxHTMK.Text = "Hiển thị mật khẩu";
            this.checkBoxHTMK.UseVisualStyleBackColor = true;
            this.checkBoxHTMK.CheckedChanged += new System.EventHandler(this.checkBoxHTMK_CheckedChanged);
            // 
            // dangnhap
            // 
            this.dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dangnhap.Location = new System.Drawing.Point(282, 354);
            this.dangnhap.Margin = new System.Windows.Forms.Padding(4);
            this.dangnhap.Name = "dangnhap";
            this.dangnhap.Size = new System.Drawing.Size(149, 39);
            this.dangnhap.TabIndex = 9;
            this.dangnhap.Text = "   Đăng nhập";
            this.dangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dangnhap.UseVisualStyleBackColor = true;
            this.dangnhap.Click += new System.EventHandler(this.dangnhap_Click);
            // 
            // thoat
            // 
            this.thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.thoat.Location = new System.Drawing.Point(456, 354);
            this.thoat.Margin = new System.Windows.Forms.Padding(4);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(129, 39);
            this.thoat.TabIndex = 10;
            this.thoat.Text = "Đăng ký";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 450);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.dangnhap);
            this.Controls.Add(this.checkBoxHTMK);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.matkhau);
            this.Controls.Add(this.taikhoan);
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taikhoan;
        private System.Windows.Forms.Label matkhau;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.CheckBox checkBoxHTMK;
        private System.Windows.Forms.Button dangnhap;
        private System.Windows.Forms.Button thoat;
    }
}

