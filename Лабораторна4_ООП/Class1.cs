using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторна4_ООП
{
    class Printer
    {
        public string Number, Segment;
        public int Type, Year;
        public double Inkjet, Laser;
        public bool FastPrint;
        public int GetYearIncomePerInhabitant()
        {
            if (FastPrint == true) return (Type * 2);
            else return (Type);

        }
     }

}
