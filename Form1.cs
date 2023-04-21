using System.Xml.Serialization;


namespace VehicleFinanceCalculator
{
    public partial class Form1 : Form


    {

        public Form1()
        {
            InitializeComponent();
        }
        double result;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = n.SelectedIndex;
            double year = Convert.ToDouble(n.GetItemText(index));
            double result = ((double.Parse(P.Text) - double.Parse(D.Text)) * (Math.Pow((double.Parse(r.Text) + 1), year)));
            A.Text = result.ToString();
        }

        private void n_SelectedValueChanged(object sender, EventArgs e)
        {
            int index = n.SelectedIndex;
            A.Text = n.GetItemText(index);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}