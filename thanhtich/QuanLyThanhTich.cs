using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thanhtich
{
    public static class QuanLyThanhTich
    {
        private static readonly string duongDan =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                         "thanhtichs.txt");
        public static void Luu(ThanhTich thanhTich)
        {
            string ten = thanhTich.Ten
                .Replace("|", " ")
                .Replace("\r", " ")
                .Replace("\n", " ");

            string dong = string.Format(
                CultureInfo.InvariantCulture,
                "{0}|{1}|{2:mm\\:ss}",
                ten,
                thanhTich.Diem,
                thanhTich.ThoiGian);

            File.AppendAllText(
                duongDan,
                dong + Environment.NewLine,
                new UTF8Encoding(false));
        }

        public static List<ThanhTich> DocTatCa()
        {
            List<ThanhTich> danhSach = new List<ThanhTich>();

            if (!File.Exists(duongDan))
                return danhSach;

            string[] cacDong = File.ReadAllLines(
                duongDan, Encoding.UTF8);

            foreach (string dong in cacDong)
            {
                string[] parts = dong.Split('|');

                if (parts.Length != 3)
                    continue;

                if (!int.TryParse(parts[1], out int diem))
                    continue;

                if (!TimeSpan.TryParseExact(
                    parts[2],
                    @"mm\:ss",
                    CultureInfo.InvariantCulture,
                    out TimeSpan thoiGian))
                    continue;

                danhSach.Add(new ThanhTich(
                    parts[0], diem, thoiGian));
            }

            return danhSach
                .OrderByDescending(x => x.Diem)
                .ThenBy(x => x.ThoiGian)
                .ToList();
        }
    }
}
