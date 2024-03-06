using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruongHongAnh_SuDungLINQ
{
    class Vehicle
    {
        public string TenPT { get; set; }
        public int NamSX { get; set; }
        public double GiaTien { get; set; }

        public Vehicle(string tenpt, int namsx, double giatien)
        {
            TenPT = tenpt;
            NamSX = namsx;
            GiaTien = giatien;
        }
    }
}
