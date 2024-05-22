using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperGay2._0
{
    public partial class FormMine : Form
    {
        public bool isButtonSell = false;
        public bool isButtonBuy = false;
        public FormMine()
        {
            InitializeComponent();
        }

        private void FormMine_Load(object sender, EventArgs e)
        {

        }
        public void Show(string Ore, string Worker, string typeOre)
        {
            labelOre.Text = typeOre + "Ore: " + Ore;
            labelWorker.Text = "Worker: " + Worker;
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            isButtonSell = true;
        }
        public int SellOre()
        {
            int result = 0;
            if (int.TryParse(textBoxSellOre.Text, out result))
            {
                return result;
            }
            return result;
        }
        public void Clear()
        {
            textBoxSellOre.Text = "";
            isButtonSell = false;
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            isButtonBuy = true;
        }
    }
}
