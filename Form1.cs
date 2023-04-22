using System.Data.SqlClient;
using System.Xml.Serialization;


namespace VehicleFinanceCalculator
{
    public partial class Form1 : Form


    {

        public Form1()
        {
            InitializeComponent();
        }
        Calculator Calculator = new Calculator();
        Bank banks = new Bank();
        Cars carz = new Cars();



        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(P.Text) || string.IsNullOrEmpty(r.Text) || string.IsNullOrEmpty(D.Text) || bank.SelectedIndex == -1 || n.SelectedIndex == -1)
            {
                MessageBox.Show("Enter all fields");
                return;
            }
            int index = n.SelectedIndex + 1;
            int year = Convert.ToInt32(n.GetItemText(index));
            decimal rate = Convert.ToDecimal(r.Text) / 100;
            decimal result = (decimal.Parse(P.Text) - decimal.Parse(D.Text));
            A.Text = (result + Calculator.CalculateSimpleInterest(result, rate, year)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(p1.Text) || string.IsNullOrEmpty(r1.Text) || string.IsNullOrEmpty(d1.Text) || bank2.SelectedIndex == -1)
            {
                MessageBox.Show("Enter all fields");
                return;
            }
            decimal rate = Convert.ToDecimal(r1.Text) / 100;
            A.Text = (Calculator.CalculateSimpleInterestTerm(Convert.ToDecimal(p1.Text), rate, Convert.ToDecimal(d1.Text))).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(r2.Text) || string.IsNullOrEmpty(textBox4.Text) || bank3.SelectedIndex == -1 || n1.SelectedIndex == -1)
            {
                MessageBox.Show("Enter all fields");
                return;
            }
            int index = n1.SelectedIndex + 1;
            int year = Convert.ToInt32(n1.GetItemText(index));
            decimal actual_amount = Convert.ToDecimal(textBox6.Text) - Convert.ToDecimal(textBox4.Text);
            decimal rate = Convert.ToDecimal(r.Text) / 100;
            A.Text = (Calculator.CalculateSimpleInterestMonthlyRepayments(actual_amount, rate, year)).ToString();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                Monthly.Visible = false;
                Total.Visible = false;
                Term.Visible = true;
                carP.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Monthly.Visible = false;
                Total.Visible = true;
                Term.Visible = false;
                carP.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                Monthly.Visible = true;
                Total.Visible = false;
                Term.Visible = false;
                carP.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                Monthly.Visible = false;
                Total.Visible = false;
                Term.Visible = false;
                carP.Visible = true;

            }
        }

        private void bank_DropDown(object sender, EventArgs e)
        {

            banks.PopulateComboBox(bank);
        }

        private void bank2_DropDown(object sender, EventArgs e)
        {
            banks.PopulateComboBox(bank2);
        }

        private void bank3_DropDown(object sender, EventArgs e)
        {
            banks.PopulateComboBox(bank3);
        }

        private void bank_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBankName = bank.SelectedItem.ToString();
            r.Text = banks.GetDataFromBankTable(selectedBankName);
        }

        private void bank2_SelectedIndexChanged_1(object sender, EventArgs e)
        {


            string selectedBankName = bank2.SelectedItem.ToString();
            r1.Text = banks.GetDataFromBankTable(selectedBankName);
        }

        private void bank3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedBankName = bank3.SelectedItem.ToString();
            r2.Text = banks.GetDataFromBankTable(selectedBankName);
        }

        private void cars_DropDown(object sender, EventArgs e)
        {
            carz.PopulateComboBox(cars);
        }

        private void bank5_DropDown(object sender, EventArgs e)
        {
            banks.PopulateComboBox(bank5);
        }

        private void bank5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBankName = bank5.SelectedItem.ToString();
            rate.Text = banks.GetDataFromBankTable(selectedBankName);
        }

        private void cars_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedVehicleName = cars.SelectedItem.ToString();
            carPrice.Text = carz.GetDataFromBankTable(selectedVehicleName);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(deposit.Text) || string.IsNullOrEmpty(carPrice.Text) || string.IsNullOrEmpty(rate.Text) || bank5.SelectedIndex == -1 || cars.SelectedIndex == -1 || years.SelectedIndex == -1)
            {
                MessageBox.Show("Enter all fields");
                return;
            }
            int index = years.SelectedIndex + 1;
            int year = Convert.ToInt32(n1.GetItemText(index));
            decimal actual_amount = Convert.ToDecimal(carPrice.Text)-Convert.ToDecimal(deposit.Text);
            decimal interest_rate = Convert.ToDecimal(rate.Text) / 100;
            A.Text = (Calculator.CalculateSimpleInterestMonthlyRepayments(actual_amount, interest_rate, year)).ToString();
        
        


        }
    }
}