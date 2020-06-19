using Kyrsach_K3S2_V1.Models;
using Kyrsach_K3S2_V1.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kyrsach_K3S2_V1
{
    public partial class Prodaja : Form
    {
        private ClientService client;
        private WorkerService worker;
        private KolusheeService kolushee;
        private RubasheeService rubashee;
        private YdarnoeService ydarnoe;
        private PodZakazService podZakaz;
        private PokypkaService pokypkaService;
       
        public Prodaja()
        {
            InitializeComponent();
            //-----------------------------------------------------------------------------------------------------------

            // Создание списка Сотрудников для ctlWorker

            worker = new WorkerService();
            var workers = new List<Worker>();
            worker.GetWorker(workers);
            ctlWorker.DataSource = workers;
            ctlWorker.DisplayMember = "fioWorker";
            ctlWorker.ValueMember = "idWorker";

            //-----------------------------------------------------------------------------------------------------------

            // Создание списка Клиентов для ctlClient

            client = new ClientService();
            var Clients = new List<Client>();
            client.GetClient(Clients);
            ctlClient.DataSource = Clients;
            ctlClient.DisplayMember = "fioClient";
            ctlClient.ValueMember = "idClient";

            //-----------------------------------------------------------------------------------------------------------
            //Список типов и качества оружия

            var TipWeapon = new List<string>();
            TipWeapon.Add("Всё");
            TipWeapon.Add("Оружие Колющее");
            TipWeapon.Add("Оружие Рубящее");
            TipWeapon.Add("Оружие Ударное");
            TipWeapon.Add("Оружие Под Заказ");
            ctlTip.DataSource = TipWeapon;

            var QualityWeapon = new List<string>();
            QualityWeapon.Add("Всё");
            QualityWeapon.Add("Коллекционное");
            QualityWeapon.Add("Настоящее");
            QualityWeapon.Add("Бутафорное");
            ctlQuality.DataSource = QualityWeapon;
        }

        //-----------------------------------------------------------------------------------------------------------

        private void btnProdaja_Click(object sender, EventArgs e)
        {
            int idWeapon = int.Parse(mtbKodWeapon.Text);
            int idClient = int.Parse(ctlClient.SelectedValue.ToString());
            string nameClient = ctlClient.Text;
            int idWorker = int.Parse(ctlWorker.SelectedValue.ToString());            
            pokypkaService = new PokypkaService();
            pokypkaService.Pokypka(idClient, nameClient, idWeapon, idWorker);   
        }
        //-----------------------------------------------------------------------------------------------------------
        private void btnReset_Click(object sender, EventArgs e)
        {
            string from = ctlTip.Text;
            string quality = ctlQuality.Text;
            kolushee = new KolusheeService();
            rubashee = new RubasheeService();
            ydarnoe = new YdarnoeService();
            podZakaz = new PodZakazService();

            var weapon = new List<Weapon>();

            if (quality == "Всё")
            {
                if (from == "Оружие Колющее") kolushee.GetKolushee(weapon);
                else if (from == "Оружие Рубящее") rubashee.GetRubashee(weapon);
                else if (from == "Оружие Ударное") ydarnoe.GetYdarnoe(weapon);
                else if (from == "Оружие Под Заказ") podZakaz.GetPodZakaz(weapon);
                else
                {
                    kolushee.GetKolushee(weapon);
                    rubashee.GetRubashee(weapon);
                    ydarnoe.GetYdarnoe(weapon);
                    podZakaz.GetPodZakaz(weapon);
                }
            }
            else
            {
                if (from == "Оружие Колющее") kolushee.GetKolushee(weapon, quality);
                else if (from == "Оружие Рубящее") rubashee.GetRubashee(weapon, quality);
                else if (from == "Оружие Ударное") ydarnoe.GetYdarnoe(weapon, quality);
                else if (from == "Оружие Под Заказ") podZakaz.GetPodZakaz(weapon, quality);
                else
                {
                    kolushee.GetKolushee(weapon, quality);
                    rubashee.GetRubashee(weapon, quality);
                    ydarnoe.GetYdarnoe(weapon, quality);
                    podZakaz.GetPodZakaz(weapon, quality);
                }
            }
            dgvWeapon.DataSource = weapon;
        }
    }
}
