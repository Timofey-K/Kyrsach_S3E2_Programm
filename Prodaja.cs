using Kyrsach_K3S2_V1.Models;
using Kyrsach_K3S2_V1.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Kyrsach_K3S2_V1
{
    public partial class Prodaja : Form
    {
        private ClientService client;
        private WorkerService worker;
        private PokypkaService pokypkaService;
        private WeaponService weaponService;

        public Prodaja()
        {
            InitializeComponent();
            //-----------------------------------------------------------------------------------------------------------

            // Создание списка Сотрудников для ctlWorker

            worker = new WorkerService();
            var workers = new List<Worker>();
            worker.GetWorker(workers);
            ctlWorker.DataSource = workers;
            ctlWorker.DisplayMember = "Fio";
            ctlWorker.ValueMember = "IdW";

            //-----------------------------------------------------------------------------------------------------------

            // Создание списка Клиентов для ctlClient

            client = new ClientService();
            var clients = new List<Client>();
            client.GetClient(clients);
            ctlClient.DataSource = clients;
            ctlClient.DisplayMember = "Fio";
            ctlClient.ValueMember = "Id";

            //-----------------------------------------------------------------------------------------------------------
            //Список типов и качества оружия

            var typeWeapon = new List<string>();
            typeWeapon.Add("Всё");
            typeWeapon.Add("ОружиеКолющее");
            typeWeapon.Add("ОружиеРубящее");
            typeWeapon.Add("ОружиеУдарное");
            typeWeapon.Add("ОружиеПодЗаказ");
            ctlTip.DataSource = typeWeapon;

            var qualityWeapon = new List<string>();
            qualityWeapon.Add("Всё");
            qualityWeapon.Add("Коллекционное");
            qualityWeapon.Add("Настоящее");
            qualityWeapon.Add("Бутафорное");
            ctlQuality.DataSource = qualityWeapon;
        }

        //-----------------------------------------------------------------------------------------------------------

        private void btnProdaja_Click(object sender, EventArgs e)
        {
            int idClient = int.Parse(ctlClient.SelectedValue.ToString());
            string nameClient = ctlClient.Text;
            int idWorker = int.Parse(ctlWorker.SelectedValue.ToString());
            string nameWorker = ctlWorker.Text;
            string resultOp;
            var kodWeapon = new List<int>();
            int count = dgvWeapon.RowCount;
            for (int i = 0; i < count; i++)
            {
                if (Convert.ToInt32(dgvWeapon[0, i].Value) == 1)
                {
                    kodWeapon.Add(int.Parse(dgvWeapon[1, i].Value.ToString()));
                }
            }


            pokypkaService = new PokypkaService();
            try
            {
                resultOp = pokypkaService.Pokypka(idClient, nameClient, idWorker, nameWorker, kodWeapon);
                MessageBox.Show(resultOp);
            }
            catch
            {
                MessageBox.Show("Ошибка выполнения операции");
            }
            
        }
        //-----------------------------------------------------------------------------------------------------------
        private void btnReset_Click(object sender, EventArgs e)
        {
            string from = ctlTip.Text;
            string quality = ctlQuality.Text;

            weaponService = new WeaponService();
            var weapon = new List<Weapon>();

            if (quality == "Всё")
            {
                if (from == "Всё")
                {
                    weaponService.GetListWeapon(weapon, "ОружиеКолющее");
                    weaponService.GetListWeapon(weapon, "ОружиеРубящее");
                    weaponService.GetListWeapon(weapon, "ОружиеУдарное");
                    weaponService.GetListWeapon(weapon, "ОружиеПодЗаказ");
                }
                else
                {
                    weaponService.GetListWeapon(weapon, from);
                }
            }
            else
            {
                if (from == "Всё")
                {
                    weaponService.GetListWeapon(weapon, quality, "ОружиеКолющее");
                    weaponService.GetListWeapon(weapon, quality, "ОружиеРубящее");
                    weaponService.GetListWeapon(weapon, quality, "ОружиеУдарное");
                    weaponService.GetListWeapon(weapon, quality, "ОружиеПодЗаказ");
                }
                else
                {
                    weaponService.GetListWeapon(weapon, quality, from);
                }
            }
            dgvWeapon.DataSource = weapon.AsReadOnly();
        }
    }
}
