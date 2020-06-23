using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrsach_K3S2_V1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnProdaja_Click(object sender, EventArgs e)
        {
            var newForm = new Prodaja();
            newForm.ShowDialog();
        }

        private void btnMerop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Операция не доступна");
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Операция не доступна");
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            var newForm = new AddClient();
            newForm.ShowDialog();
        }

        private void btnAddWeapon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Операция не доступна");
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            var newForm = new Log();
            newForm.ShowDialog();
        }
    }
}
