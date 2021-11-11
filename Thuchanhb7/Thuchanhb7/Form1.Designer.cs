
namespace Thuchanhb7
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblHoten = new System.Windows.Forms.Label();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblDienthoai = new System.Windows.Forms.Label();
            this.lblTencoquan = new System.Windows.Forms.Label();
            this.lblGioitinh = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtDienthoai = new System.Windows.Forms.TextBox();
            this.txtTencoquan = new System.Windows.Forms.TextBox();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.rbtnNu = new System.Windows.Forms.RadioButton();
            this.dgrDanhsach = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDanhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(812, 67);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(812, 114);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(75, 23);
            this.btnBoqua.TabIndex = 1;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(812, 166);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 2;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(812, 229);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "In...";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(812, 295);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(812, 353);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.Location = new System.Drawing.Point(63, 67);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(50, 17);
            this.lblHoten.TabIndex = 6;
            this.lblHoten.Text = "Họ tên";
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Location = new System.Drawing.Point(385, 67);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(71, 17);
            this.lblNgaysinh.TabIndex = 7;
            this.lblNgaysinh.Text = "Ngày sinh";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Location = new System.Drawing.Point(63, 200);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(51, 17);
            this.lblDiachi.TabIndex = 8;
            this.lblDiachi.Text = "ĐỊa chỉ";
            // 
            // lblDienthoai
            // 
            this.lblDienthoai.AutoSize = true;
            this.lblDienthoai.Location = new System.Drawing.Point(385, 129);
            this.lblDienthoai.Name = "lblDienthoai";
            this.lblDienthoai.Size = new System.Drawing.Size(72, 17);
            this.lblDienthoai.TabIndex = 9;
            this.lblDienthoai.Text = "Điện thoại";
            // 
            // lblTencoquan
            // 
            this.lblTencoquan.AutoSize = true;
            this.lblTencoquan.Location = new System.Drawing.Point(63, 325);
            this.lblTencoquan.Name = "lblTencoquan";
            this.lblTencoquan.Size = new System.Drawing.Size(88, 17);
            this.lblTencoquan.TabIndex = 10;
            this.lblTencoquan.Text = "Tên cơ quan";
            // 
            // lblGioitinh
            // 
            this.lblGioitinh.AutoSize = true;
            this.lblGioitinh.Location = new System.Drawing.Point(63, 129);
            this.lblGioitinh.Name = "lblGioitinh";
            this.lblGioitinh.Size = new System.Drawing.Size(60, 17);
            this.lblGioitinh.TabIndex = 11;
            this.lblGioitinh.Text = "Giới tính";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(157, 67);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(204, 22);
            this.txtHoten.TabIndex = 12;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(500, 129);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(204, 22);
            this.txtDiachi.TabIndex = 13;
            // 
            // txtDienthoai
            // 
            this.txtDienthoai.Location = new System.Drawing.Point(157, 200);
            this.txtDienthoai.Name = "txtDienthoai";
            this.txtDienthoai.Size = new System.Drawing.Size(454, 22);
            this.txtDienthoai.TabIndex = 14;
            // 
            // txtTencoquan
            // 
            this.txtTencoquan.Location = new System.Drawing.Point(157, 320);
            this.txtTencoquan.Name = "txtTencoquan";
            this.txtTencoquan.Size = new System.Drawing.Size(454, 22);
            this.txtTencoquan.TabIndex = 15;
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.Location = new System.Drawing.Point(150, 124);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(58, 21);
            this.rbtnNam.TabIndex = 16;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Nam";
            this.rbtnNam.UseVisualStyleBackColor = true;
            // 
            // rbtnNu
            // 
            this.rbtnNu.AutoSize = true;
            this.rbtnNu.Location = new System.Drawing.Point(220, 124);
            this.rbtnNu.Name = "rbtnNu";
            this.rbtnNu.Size = new System.Drawing.Size(47, 21);
            this.rbtnNu.TabIndex = 17;
            this.rbtnNu.TabStop = true;
            this.rbtnNu.Text = "Nữ";
            this.rbtnNu.UseVisualStyleBackColor = true;
            // 
            // dgrDanhsach
            // 
            this.dgrDanhsach.AllowUserToAddRows = false;
            this.dgrDanhsach.AllowUserToDeleteRows = false;
            this.dgrDanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDanhsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2});
            this.dgrDanhsach.Location = new System.Drawing.Point(181, 398);
            this.dgrDanhsach.Name = "dgrDanhsach";
            this.dgrDanhsach.ReadOnly = true;
            this.dgrDanhsach.RowHeadersWidth = 51;
            this.dgrDanhsach.RowTemplate.Height = 24;
            this.dgrDanhsach.Size = new System.Drawing.Size(648, 202);
            this.dgrDanhsach.TabIndex = 18;
            this.dgrDanhsach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrDanhsach_CellContentClick);
            // 
            // col1
            // 
            this.col1.DataPropertyName = "sHoten";
            this.col1.HeaderText = "Họ tên";
            this.col1.MinimumWidth = 6;
            this.col1.Name = "col1";
            this.col1.ReadOnly = true;
            this.col1.Width = 125;
            // 
            // col2
            // 
            this.col2.DataPropertyName = "tNgaysinh";
            this.col2.HeaderText = "Năm sinh";
            this.col2.MinimumWidth = 6;
            this.col2.Name = "col2";
            this.col2.ReadOnly = true;
            this.col2.Width = 125;
            // 
            // dateTimeNgaysinh
            // 
            this.dateTimeNgaysinh.CustomFormat = "dd/MM/yyyy";
            this.dateTimeNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgaysinh.Location = new System.Drawing.Point(500, 67);
            this.dateTimeNgaysinh.Name = "dateTimeNgaysinh";
            this.dateTimeNgaysinh.Size = new System.Drawing.Size(200, 22);
            this.dateTimeNgaysinh.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 348);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(128, 378);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(743, 238);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 612);
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
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrDanhsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblDienthoai;
        private System.Windows.Forms.Label lblTencoquan;
        private System.Windows.Forms.Label lblGioitinh;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtDienthoai;
        private System.Windows.Forms.TextBox txtTencoquan;
        private System.Windows.Forms.RadioButton rbtnNam;
        private System.Windows.Forms.RadioButton rbtnNu;
        private System.Windows.Forms.DataGridView dgrDanhsach;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DateTimePicker dateTimeNgaysinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

