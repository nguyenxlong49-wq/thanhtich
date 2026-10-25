using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thanhtich
{
  
    public partial class frmNhapTen : Form
    {
        private int diem;
        private TimeSpan thoiGian;
        public frmNhapTen(int diemSo, TimeSpan thoiGianChoi)
        {
            InitializeComponent();
            diem = diemSo;
            thoiGian = thoiGianChoi;

            lblDiem.Text = "Điểm: " + diem;
            lblThoiGian.Text =
                "Thời gian: " + thoiGian.ToString(@"mm\:ss");
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();

            if (string.IsNullOrWhiteSpace(ten))
            {
                MessageBox.Show("Vui lòng nhập tên của bạn!");
                txtTen.Focus();
                return;
            }

            try
            {
                ThanhTich thanhTich =
                    new ThanhTich(ten, diem, thoiGian);

                QuanLyThanhTich.Luu(thanhTich);

                MessageBox.Show("Đã lưu thành tích!");

                
                frmThanhTich
                    form =
                    new frmThanhTich ();

                form.ShowDialog();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể lưu thành tích: " + ex.Message);
            }
        }
    }
}
