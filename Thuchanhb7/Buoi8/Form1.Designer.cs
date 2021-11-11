
namespace Buoi8
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
            this.dateTimeNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.dgrDanhsach = new System.Windows.Forms.DataGridView();
            this.rbtnNu = new System.Windows.Forms.RadioButton();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.txtTencoquan = new System.Windows.Forms.TextBox();
            this.txtDienthoai = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.lblGioitinh = new System.Windows.Forms.Label();
            this.lblTencoquan = new System.Windows.Forms.Label();
            this.lblDienthoai = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.lblHoten = new System.Windows.Forms.Label();
            this.btnBaocao = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDanhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimeNgaysinh
            // 
            this.dateTimeNgaysinh.CustomFormat = "dd/MM/yyyy";
            this.dateTimeNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgaysinh.Location = new System.Drawing.Point(451, -28);
            this.dateTimeNgaysinh.Name = "dateTimeNgaysinh";
            this.dateTimeNgaysinh.Size = new System.Drawing.Size(200, 22);
            this.dateTimeNgaysinh.TabIndex = 43;
            // 
            // dgrDanhsach
            // 
            this.dgrDanhsach.AllowUserToAddRows = false;
            this.dgrDanhsach.AllowUserToDeleteRows = false;
            this.dgrDanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDanhsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2,
            this.col3});
            this.dgrDanhsach.Location = new System.Drawing.Point(132, 303);
            this.dgrDanhsach.Name = "dgrDanhsach";
            this.dgrDanhsach.ReadOnly = true;
            this.dgrDanhsach.RowHeadersWidth = 51;
            this.dgrDanhsach.RowTemplate.Height = 24;
            this.dgrDanhsach.Size = new System.Drawing.Size(648, 202);
            this.dgrDanhsach.TabIndex = 42;
            // 
            // rbtnNu
            // 
            this.rbtnNu.AutoSize = true;
            this.rbtnNu.Location = new System.Drawing.Point(171, 29);
            this.rbtnNu.Name = "rbtnNu";
            this.rbtnNu.Size = new System.Drawing.Size(47, 21);
            this.rbtnNu.TabIndex = 41;
            this.rbtnNu.TabStop = true;
            this.rbtnNu.Text = "Nữ";
            this.rbtnNu.UseVisualStyleBackColor = true;
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.Location = new System.Drawing.Point(101, 29);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(58, 21);
            this.rbtnNam.TabIndex = 40;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Nam";
            this.rbtnNam.UseVisualStyleBackColor = true;
            // 
            // txtTencoquan
            // 
            this.txtTencoquan.Location = new System.Drawing.Point(108, 225);
            this.txtTencoquan.Name = "txtTencoquan";
            this.txtTencoquan.Size = new System.Drawing.Size(454, 22);
            this.txtTencoquan.TabIndex = 39;
            // 
            // txtDienthoai
            // 
            this.txtDienthoai.Location = new System.Drawing.Point(108, 105);
            this.txtDienthoai.Name = "txtDienthoai";
            this.txtDienthoai.Size = new System.Drawing.Size(454, 22);
            this.txtDienthoai.TabIndex = 38;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(451, 34);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(204, 22);
            this.txtDiachi.TabIndex = 37;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(108, -28);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(204, 22);
            this.txtHoten.TabIndex = 36;
            // 
            // lblGioitinh
            // 
            this.lblGioitinh.AutoSize = true;
            this.lblGioitinh.Location = new System.Drawing.Point(14, 34);
            this.lblGioitinh.Name = "lblGioitinh";
            this.lblGioitinh.Size = new System.Drawing.Size(60, 17);
            this.lblGioitinh.TabIndex = 35;
            this.lblGioitinh.Text = "Giới tính";
            // 
            // lblTencoquan
            // 
            this.lblTencoquan.AutoSize = true;
            this.lblTencoquan.Location = new System.Drawing.Point(14, 230);
            this.lblTencoquan.Name = "lblTencoquan";
            this.lblTencoquan.Size = new System.Drawing.Size(88, 17);
            this.lblTencoquan.TabIndex = 34;
            this.lblTencoquan.Text = "Tên cơ quan";
            // 
            // lblDienthoai
            // 
            this.lblDienthoai.AutoSize = true;
            this.lblDienthoai.Location = new System.Drawing.Point(336, 34);
            this.lblDienthoai.Name = "lblDienthoai";
            this.lblDienthoai.Size = new System.Drawing.Size(72, 17);
            this.lblDienthoai.TabIndex = 33;
            this.lblDienthoai.Text = "Điện thoại";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Location = new System.Drawing.Point(14, 105);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(51, 17);
            this.lblDiachi.TabIndex = 32;
            this.lblDiachi.Text = "ĐỊa chỉ";
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Location = new System.Drawing.Point(336, -28);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(71, 17);
            this.lblNgaysinh.TabIndex = 31;
            this.lblNgaysinh.Text = "Ngày sinh";
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.Location = new System.Drawing.Point(14, -28);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(50, 17);
            this.lblHoten.TabIndex = 30;
            this.lblHoten.Text = "Họ tên";
            // 
            // btnBaocao
            // 
            this.btnBaocao.Location = new System.Drawing.Point(763, 258);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(75, 23);
            this.btnBaocao.TabIndex = 29;
            this.btnBaocao.Text = "Báo Cáo";
            this.btnBaocao.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(763, 200);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 28;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(763, 134);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(75, 23);
            this.btnBoqua.TabIndex = 27;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(763, 71);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(763, 19);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 25;
            this.btnNhap.Text = "Nhap";
            this.btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(763, -28);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(79, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(743, 238);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(-37, -71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 348);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // col1
            // 
            this.col1.DataPropertyName = "PK_iKhachhangID";
            this.col1.HeaderText = "Ma";
            this.col1.MinimumWidth = 6;
            this.col1.Name = "col1";
            this.col1.ReadOnly = true;
            this.col1.Width = 125;
            // 
            // col2
            // 
            this.col2.DataPropertyName = "sHoten";
            this.col2.HeaderText = "Họ tên";
            this.col2.MinimumWidth = 6;
            this.col2.Name = "col2";
            this.col2.ReadOnly = true;
            this.col2.Width = 125;
            // 
            // col3
            // 
            this.col3.DataPropertyName = "sDiachi";
            this.col3.FillWeight = 200F;
            this.col3.HeaderText = "Địa chỉ";
            this.col3.MinimumWidth = 6;
            this.col3.Name = "col3";
            this.col3.ReadOnly = true;
            this.col3.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 708);
            this.Controls.Add(this.dateTimeNgaysinh);
            this.Controls.Add(this.dgrDanhsach);
            this.Controls.Add(this.rbtnNu);
            this.Controls.Add(this.rbtnNam);
            this.Controls.Add(this.txtTencoquan);
            this.Controls.Add(this.txtDienthoai);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.lblGioitinh);
            this.Controls.Add(this.lblTencoquan);
            this.Controls.Add(this.lblDienthoai);
            this.Controls.Add(this.lblDiachi);
            this.Controls.Add(this.lblNgaysinh);
            this.Controls.Add(this.lblHoten);
            this.Controls.Add(this.btnBaocao);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgrDanhsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeNgaysinh;
        private System.Windows.Forms.DataGridView dgrDanhsach;
        private System.Windows.Forms.RadioButton rbtnNu;
        private System.Windows.Forms.RadioButton rbtnNam;
        private System.Windows.Forms.TextBox txtTencoquan;
        private System.Windows.Forms.TextBox txtDienthoai;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label lblGioitinh;
        private System.Windows.Forms.Label lblTencoquan;
        private System.Windows.Forms.Label lblDienthoai;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.Button btnBaocao;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
    }
}

