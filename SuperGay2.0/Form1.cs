namespace SuperGay2._0
{
    public partial class Form1 : Form
    {
        private Mine ironMine;
        private FormMine formIronMine;

        private Mine coalMine;
        private FormMine formCoalMine;
        private int Balance = 100;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            ironMine = new();
            coalMine = new();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ironMine.Tick();
            coalMine.Tick();
            showBalance();
            if (formIronMine != null)
            {
                formIronMine.Show(ironMine.Ore.ToString(), ironMine.Worker.ToString(), "Iron  ");
                ironMine.SellOre(formIronMine, ref Balance);
                ironMine.BuyWorker(formIronMine, ref Balance);
            }

            if (formCoalMine != null)
            {
                formCoalMine.Show(coalMine.Ore.ToString(), coalMine.Worker.ToString(), "Coal  ");
                coalMine.SellOre(formCoalMine, ref Balance);
                coalMine.BuyWorker(formCoalMine, ref Balance);
            }
        }

        private void pictureBoxIronMine_Click(object sender, EventArgs e)
        {
            formIronMine = new();
            formIronMine.Show();
        }
        private void pictureBoxCoalMine_Click_1(object sender, EventArgs e)
        {
            formCoalMine = new();
            formCoalMine.Show();
        }

        public void showBalance()
        {
            labelBalance.Text = "Balance: " + Balance.ToString() + "$";
        }
    }
}
