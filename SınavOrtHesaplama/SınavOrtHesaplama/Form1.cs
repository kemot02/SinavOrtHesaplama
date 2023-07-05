namespace SınavOrtHesaplama
{
    public partial class Form1 : Form
    {
        double number1=0;
        double number2 = 0;
        double number3 = 0;
        double Result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void tbxSınav2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxSınav1.Text = "";
            tbxSınav2.Text = "";
            tbxSınav3.Text = "";
            tbxResult.Text = "";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool number10k = double.TryParse(tbxSınav1.Text, out number1);
            bool number20k = double.TryParse(tbxSınav2.Text, out number2);
            bool number30k = double.TryParse(tbxSınav3.Text, out number3);
            if(number10k && number20k && number30k)
            {
                Result = (number1 + number2 + number3) / 3;
                tbxResult.Text = Result.ToString();
            }
            else
            {
                MessageBox.Show("Data is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}