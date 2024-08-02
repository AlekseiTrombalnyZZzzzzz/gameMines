namespace game3
{
    public partial class Form1 : Form
    {
        private Mine ironMine;
        private FormMine formIronMine;

        private Mine coalMine;
        private FormMine formCoalMine;

        private Mine rockMine;
        private FormMine formRockMine;

        private Mine medMine;
        private FormMine formMedMine;

        private int balance = 100;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            ironMine = new("Iron");
            coalMine = new("Coal");
            rockMine = new("Rock");
            medMine = new("MED");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ironMine.Tick();
            coalMine.Tick();
            rockMine.Tick();
            medMine.Tick();
            showBalance();

            if (formIronMine != null)
            {
                formIronMine.Show(ironMine.NameOre, ironMine.Ore.ToString(), ironMine.Worker.ToString());
                ironMine.SellOre(formIronMine, ref balance);
                ironMine.BuyWorker(formIronMine, ref balance);
            }

            if (formCoalMine != null)
            {
                formCoalMine.Show(coalMine.NameOre, coalMine.Ore.ToString(), coalMine.Worker.ToString());
                coalMine.SellOre(formCoalMine, ref balance);
                coalMine.BuyWorker(formCoalMine, ref balance);
            }

            if (formRockMine != null)
            {
                formRockMine.Show(rockMine.NameOre, rockMine.Ore.ToString(), rockMine.Worker.ToString());
                rockMine.SellOre(formRockMine, ref balance);
                rockMine.BuyWorker(formRockMine, ref balance);
            }

            if (formMedMine != null)
            {
                formMedMine.Show(medMine.NameOre, medMine.Ore.ToString(), medMine.Worker.ToString());
                medMine.SellOre(formMedMine, ref balance);
                medMine.BuyWorker(formMedMine, ref balance);
            }
        }

        private void pictureBoxIronMine_Click(object sender, EventArgs e)
        {
            formIronMine = new();
            formIronMine.Show();
        }
        private void pictureBoxCoalMine_Click(object sender, EventArgs e)
        {
            formCoalMine = new();
            formCoalMine.Show();
        }
        private void pictureBoxRockMine_Click(object sender, EventArgs e)
        {
            formRockMine = new();
            formRockMine.Show();
        }
        private void pictureBoxMedMine_Click(object sender, EventArgs e)
        {
            formMedMine = new();
            formMedMine.Show();
        }
        public void showBalance()
        {
            labelBalance.Text = "Balance: " + balance.ToString() + "$";
        }

        
    }
}
