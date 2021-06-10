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
    public partial class fTown : Form
    {
        public fTown()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        public Town TheTown;

        public fTown(Town t)
        {
            TheTown = t;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TheTown.Model = Model.Text.Trim();
            TheTown.Country = Country.Text.Trim();
            TheTown.Type = Type.Text.Trim();
            TheTown.Printing = Printing.Text.Trim();
            TheTown.Warranty = double.Parse(Warranty.Text.Trim());
            TheTown.Price = double.Parse(Price.Text.Trim());
            TheTown.Wifi = Wifi.Checked;
            TheTown.Color = Color.Checked;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fTown_Load(object sender, EventArgs e)
        {
            if (TheTown != null)
            {
                Model.Text = TheTown.Model;
                Country.Text = TheTown.Country;
                Type.Text = TheTown.Type;
                Printing.Text = TheTown.Printing;
                Warranty.Text = TheTown.Warranty.ToString();
                Price.Text = TheTown.Price.ToString("0.00");
                Wifi.Checked = TheTown.Wifi;
                Color.Checked = TheTown.Color;
            }
        }
    }
}

