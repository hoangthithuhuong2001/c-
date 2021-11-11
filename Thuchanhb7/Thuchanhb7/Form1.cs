using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Thuchanhb7
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        private DataTable getKhachhang()
        {

            string connectionString = ConfigurationManager.ConnectionStrings["db_Shop4Training"].ConnectionString;


            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand Cmd = new SqlCommand("spKhachhang_Get", Cnn))
                {
                    Cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter da = new SqlDataAdapter(Cmd))
                    {
                        DataTable tbl = new DataTable("tblKhachhang");
                        da.Fill(tbl);
                        return tbl;
                    }

                }

            }
        }
        private void hienDanhsachKhachhang()
        {


            using (DataTable tblKhachhang = getKhachhang())
            {
                DataView dvKhachhang = new DataView(tblKhachhang);
                dgrDanhsach.AutoGenerateColumns = false;
                dgrDanhsach.ReadOnly = true;
                dgrDanhsach.DataSource = dvKhachhang;
            }

        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["db_Shop4Training"].ConnectionString;
            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand Cmd = new SqlCommand ("", Cnn))
                {
                    Cmd.CommandType = CommandType.StoredProcedure;
                    if(
                        !(btnThem.Tag==null 
                            || string.IsNullOrEmpty(btnThem.Tag.ToString()))
                       )
                        {
                        Cmd.CommandText = "spKhachhang_Update";
                        Cmd.Parameters.AddWithValue("@PK_iKhachhangID", btnThem.Tag);
                    }
                    else
                    {
                        Cmd.CommandText = "spKhachhang_Insert";
                        Cmd.Parameters.Add("@PK_iKhachhangID", SqlDbType.Int).Direction = ParameterDirection.Output;
                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                    }
                    Cmd.Parameters.AddWithValue("@sHoten", txtHoten.Text);
                    Cmd.Parameters.AddWithValue("@sDiachi", txtDiachi.Text);
                    Cmd.Parameters.AddWithValue("@sDienthoai", txtDienthoai.Text);
                    Cmd.Parameters.AddWithValue("@bGioitinh", rbtnNam.Checked);
                    Cmd.Parameters.AddWithValue("@tNgaysinh", Convert.ToDateTime(dateTimeNgaysinh.Text));
                    Cmd.Parameters.AddWithValue("@sTencoquan", txtTencoquan.Text);
                    Cnn.Open();
                    Cmd.ExecuteNonQuery();
                    Cnn.Close();
                    btnBoqua_Click(sender, e);
                    Form1_Load(sender, e);
                }    
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
        private void dgrDanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;

            try
            {
                txtHoten.Text = dgrDanhsach[0, e.RowIndex].Value.ToString();
                txtDiachi.Text = dgrDanhsach[1, e.RowIndex].Value.ToString();
                txtDienthoai.Text = dgrDanhsach[2, e.RowIndex].Value.ToString();

                dateTimeNgaysinh.Value = (DateTime)dgrDanhsach[4, e.RowIndex].Value;
                txtTencoquan.Text = dgrDanhsach[5, e.RowIndex].Value.ToString();

            }
            catch (Exception ex)
            {
            }
        }
        private void HienChiTiet(Boolean hien)
        {
            txtHoten.Enabled = hien;
            txtDiachi.Enabled = hien;
            txtDienthoai.Enabled = hien;
            rbtnNam.Enabled = hien;
            rbtnNu.Enabled = hien;
            dateTimeNgaysinh.Enabled = hien;
            txtTencoquan.Enabled = hien;
            
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["db_Shop4Training"].ConnectionString;
            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                string sqlDelete = "delete from tblKhachhang where sHoten = @sHoten";

                using (SqlCommand Cmd = new SqlCommand(sqlDelete, Cnn))
                {
                    Cnn.Open();
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.AddWithValue("sHoten", txtHoten.Text);
                    Cmd.Parameters.AddWithValue("sDiachi", txtDiachi.Text);
                    Cmd.Parameters.AddWithValue("sDienthoai", txtDienthoai.Text);
                    Cmd.Parameters.AddWithValue("bGioitinh", rbtnNam.Checked);
                    Cmd.Parameters.AddWithValue("tNgaysinh", Convert.ToDateTime(dateTimeNgaysinh.Text));
                    Cmd.Parameters.AddWithValue("sTencoquan", txtTencoquan.Text);
                    Cmd.ExecuteNonQuery();
                    Form1_Load(sender, e);
                    Cnn.Close();

                }
                    //if (MessageBox.Show("Bạn có chắc chắn xóa " + txtHoten.Text + " không? ", "Xóa sản phẩm" , MessageBoxButtons.YesNo) == DialogResult.Yes)
                    //{

                    //    btnThem.Enabled = false;
                    //    btnSua.Enabled = false;
                    //    //Hiện gropbox chi tiết
                    //    HienChiTiet(true);
                    //    Form1_Load(sender, e);
                    //}

                }
        }
        

        private void btnIn_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hienDanhsachKhachhang();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = true;
            
            HienChiTiet(false);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string dieukienloc = "PK_iKhachhangID > 0";

            if (!string.IsNullOrEmpty(txtHoten.Text))
                dieukienloc += string.Format("and sHoten like '%{0}%'"
                    , txtHoten.Text) ;

            DialogResult timtheoGioitinh = MessageBox.Show("Có tìm theo giới tính không"
                , "Tìm kiếm"
                , MessageBoxButtons.YesNo);

            if (timtheoGioitinh==DialogResult.Yes)
                dieukienloc += string.Format("and bGioitinh = {0}"
                    , rbtnNam.Checked);

            if (!string.IsNullOrEmpty(txtDiachi.Text))
                dieukienloc += string.Format("and sDiachi like '%{0}%'"
                    , txtDiachi.Text);

            DataView dvKH = dgrDanhsach.DataSource as DataView;
            dvKH.RowFilter = dieukienloc;
            dgrDanhsach.DataSource = dvKH;
        }
    }
}
