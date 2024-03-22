namespace GUII
{
    partial class FormMenu
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.lichday = new System.Windows.Forms.TabPage();
            this.thongtincanhan = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.them = new System.Windows.Forms.Button();
            this.luu = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.luong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.hanhd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sohd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.diachi = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sdt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hoten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.thongkevabaocao = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lsdangnhap = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.lichday.SuspendLayout();
            this.thongtincanhan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.lichday);
            this.tabControl1.Controls.Add(this.thongtincanhan);
            this.tabControl1.Controls.Add(this.thongkevabaocao);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.lsdangnhap);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl1.Location = new System.Drawing.Point(-2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1331, 660);
            this.tabControl1.TabIndex = 4;
            // 
            // lichday
            // 
            this.lichday.Controls.Add(this.dataGridView6);
            this.lichday.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lichday.Location = new System.Drawing.Point(4, 31);
            this.lichday.Name = "lichday";
            this.lichday.Padding = new System.Windows.Forms.Padding(3);
            this.lichday.Size = new System.Drawing.Size(1323, 625);
            this.lichday.TabIndex = 0;
            this.lichday.Text = "Lịch dạy";
            this.lichday.UseVisualStyleBackColor = true;
            // 
            // thongtincanhan
            // 
            this.thongtincanhan.Controls.Add(this.groupBox1);
            this.thongtincanhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.thongtincanhan.Location = new System.Drawing.Point(4, 31);
            this.thongtincanhan.Name = "thongtincanhan";
            this.thongtincanhan.Padding = new System.Windows.Forms.Padding(3);
            this.thongtincanhan.Size = new System.Drawing.Size(882, 449);
            this.thongtincanhan.TabIndex = 1;
            this.thongtincanhan.Text = "Thông tin cá nhân";
            this.thongtincanhan.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.them);
            this.groupBox1.Controls.Add(this.luu);
            this.groupBox1.Controls.Add(this.sua);
            this.groupBox1.Controls.Add(this.luong);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.hanhd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.sohd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.diachi);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.sdt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.hoten);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 454);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // them
            // 
            this.them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.them.Location = new System.Drawing.Point(453, 248);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(97, 32);
            this.them.TabIndex = 16;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            // 
            // luu
            // 
            this.luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.luu.Location = new System.Drawing.Point(734, 248);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(93, 32);
            this.luu.TabIndex = 15;
            this.luu.Text = "Lưu";
            this.luu.UseVisualStyleBackColor = true;
            // 
            // sua
            // 
            this.sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sua.Location = new System.Drawing.Point(594, 248);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(97, 32);
            this.sua.TabIndex = 14;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            // 
            // luong
            // 
            this.luong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.luong.Location = new System.Drawing.Point(157, 184);
            this.luong.Name = "luong";
            this.luong.Size = new System.Drawing.Size(246, 28);
            this.luong.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(18, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Lương theo giờ";
            // 
            // hanhd
            // 
            this.hanhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.hanhd.Location = new System.Drawing.Point(619, 134);
            this.hanhd.Name = "hanhd";
            this.hanhd.Size = new System.Drawing.Size(246, 28);
            this.hanhd.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(437, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ngày hết hạn HD";
            // 
            // sohd
            // 
            this.sohd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sohd.Location = new System.Drawing.Point(156, 137);
            this.sohd.Name = "sohd";
            this.sohd.Size = new System.Drawing.Size(246, 28);
            this.sohd.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(18, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số hợp đồng";
            // 
            // diachi
            // 
            this.diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.diachi.Location = new System.Drawing.Point(619, 85);
            this.diachi.Name = "diachi";
            this.diachi.Size = new System.Drawing.Size(246, 28);
            this.diachi.TabIndex = 7;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.email.Location = new System.Drawing.Point(619, 36);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(246, 28);
            this.email.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(437, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Địa chỉ\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(437, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // sdt
            // 
            this.sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sdt.Location = new System.Drawing.Point(156, 88);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(246, 28);
            this.sdt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(18, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số điện thoại";
            // 
            // hoten
            // 
            this.hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.hoten.Location = new System.Drawing.Point(156, 38);
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(246, 28);
            this.hoten.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(18, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên ";
            // 
            // thongkevabaocao
            // 
            this.thongkevabaocao.Location = new System.Drawing.Point(4, 31);
            this.thongkevabaocao.Name = "thongkevabaocao";
            this.thongkevabaocao.Size = new System.Drawing.Size(882, 449);
            this.thongkevabaocao.TabIndex = 2;
            this.thongkevabaocao.Text = "Thống kê và báo cáo";
            this.thongkevabaocao.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(882, 449);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Tính tiền lương";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lsdangnhap
            // 
            this.lsdangnhap.Location = new System.Drawing.Point(4, 31);
            this.lsdangnhap.Name = "lsdangnhap";
            this.lsdangnhap.Size = new System.Drawing.Size(882, 449);
            this.lsdangnhap.TabIndex = 4;
            this.lsdangnhap.Text = "Lịch sử đăng nhập";
            this.lsdangnhap.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            this.dataGridView6.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(0, 6);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowHeadersWidth = 51;
            this.dataGridView6.RowTemplate.Height = 24;
            this.dataGridView6.Size = new System.Drawing.Size(1327, 616);
            this.dataGridView6.TabIndex = 9;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 672);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.tabControl1.ResumeLayout(false);
            this.lichday.ResumeLayout(false);
            this.thongtincanhan.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage lichday;
        private System.Windows.Forms.TabPage thongtincanhan;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage thongkevabaocao;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage lsdangnhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button luu;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.TextBox luong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox hanhd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sohd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox diachi;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sdt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hoten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.DataGridView dataGridView6;
    }
}