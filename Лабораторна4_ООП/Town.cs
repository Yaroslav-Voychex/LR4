using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторна4_ООП
{
    public class Town
    {
        public string Model;
        public string Country;
        public string Type;
        public string Printing;
        public double Warranty;
        public double Price;
        public bool Wifi;
        public bool Color;
        public double GetYearIncomePerInhabitant()
        {
            return Price + Warranty;
        }
    }
}
