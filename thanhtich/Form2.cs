using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thanhtich
{
    public partial class frmThanhTich : Form
    {
        public frmThanhTich()
        {
            InitializeComponent();
        }

        private void dgvXepHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvXepHang.AutoGenerateColumns = false;
            dgvXepHang.Columns.Clear();

            dgvXepHang.Columns.Add("Hang", "Hạng");
            dgvXepHang.Columns.Add("Ten", "Tên");
            dgvXepHang.Columns.Add("Diem", "Điểm");
            dgvXepHang.Columns.Add("ThoiGian", "Thời gian");

            dgvXepHang.Columns["Hang"].DataPropertyName = "Hang";
            dgvXepHang.Columns["Ten"].DataPropertyName = "Ten";
            dgvXepHang.Columns["Diem"].DataPropertyName = "Diem";
            dgvXepHang.Columns["ThoiGian"].DataPropertyName = "ThoiGian";

            dgvXepHang.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvXepHang.ReadOnly = true;
            dgvXepHang.AllowUserToAddRows = false;
            dgvXepHang.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            TaiXepHang();
        }
        private void TaiXepHang()
        {
            var danhSach = QuanLyThanhTich.DocTatCa()
                .Take(10)
                .Select((x, index) => new
                {
                    Hang = index + 1,
                    Ten = x.Ten,
                    Diem = x.Diem,
                    ThoiGian = x.ThoiGian.ToString(@"mm\:ss")
                })
                .ToList();

            dgvXepHang.DataSource = danhSach;

            // Tô màu 3 vị trí đầu tiên
            dgvXepHang.ClearSelection();

            if (dgvXepHang.Rows.Count > 0)
            {
                dgvXepHang.Rows[0].DefaultCellStyle.BackColor =
                    System.Drawing.Color.Gold;
            }

            if (dgvXepHang.Rows.Count > 1)
            {
                dgvXepHang.Rows[1].DefaultCellStyle.BackColor =
                    System.Drawing.Color.Silver;
            }

            if (dgvXepHang.Rows.Count > 2)
            {
                dgvXepHang.Rows[2].DefaultCellStyle.BackColor =
                    System.Drawing.Color.Peru;
            }
        }
    }
}
