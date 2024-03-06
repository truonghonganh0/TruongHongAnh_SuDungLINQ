using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruongHongAnh_SuDungLINQ
{
    class Car : Vehicle
    {
        public string NhaSX { get; set; }
        public Car(string tenpt, int namsx, double giatien, string nhasx) : base(tenpt, namsx, giatien)
        {
            NhaSX = NhaSX;
        }
    }
}
