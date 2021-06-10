using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторна4_ООП
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnAddTown_Click(object sender, EventArgs e)
        {
            Town town = new Town();
            fTown ft = new fTown(town);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                tbTownsInfo.Text +=
                string.Format(
                "\r\n ------------------------------------" +
                "\r\nМодель : " + town.Model +
                "\r\nКраїна виробника : " + town.Country +
                "\r\nТип : " + town.Type +
                "\r\nТехнологiя друку : " + town.Printing +
                "\r\nГарантiйний термiн : " + town.Warranty +
                "\r\nЦiна : " + town.Price +
                "\r\nНаявнiсть WIFI : " + ( town.Wifi ? "Є" : "Немає" )+
                "\r\nКольоровий друк : " +  (town.Color ? "Є  " : "Немає ") +
               "\r\n Ціна гарантії за одиницю :" + town.GetYearIncomePerInhabitant()) ;
            
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?",
"Припинити роботу", MessageBoxButtons.OKCancel,
MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
    }
}
