using Kyrsach_K3S2_V1.Services;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kyrsach_K3S2_V1
{
    public partial class AddClient : Form
    {

        private ClientService clientService;
        public AddClient()
        {
            InitializeComponent();
            clientService = new ClientService();            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                clientService.Insert(tbName.Text, mtbTel.Text);
                MessageBox.Show($"Клиент {tbName.Text} зарегестрирован");
            }
            catch
            {
                MessageBox.Show("Клиент с таким номером уже существует");
            }            
        }       
    }
}
