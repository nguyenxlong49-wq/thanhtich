using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thanhtich
{
    public class ThanhTich
    {
        public string Ten { get; set; }
        public int Diem { get; set; }
        public TimeSpan ThoiGian { get; set; }

        public ThanhTich(string ten, int diem, TimeSpan thoiGian)
        {
            Ten = ten;
            Diem = diem;
            ThoiGian = thoiGian;
        }
    }
}
