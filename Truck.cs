using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruongHongAnh_SuDungLINQ
{
    class Truck : Vehicle
    {
        public string CTy { get; set; }
        public Truck(string tenpt, int namsx, double giatien, string cty) : base(tenpt, namsx, giatien)
        {
            CTy = cty;
        }
    }
}
