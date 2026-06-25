namespace Boletos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbTipoBoleto.Items.Add("General");
            cmbTipoBoleto.Items.Add("Estudiante");
            cmbTipoBoleto.Items.Add("Adulto Mayor");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoBoleto.Text == "General")
            {
                lbl_Dato.Hide();
                txtDato.Hide();
            }
            else if (cmbTipoBoleto.Text == "Estudiante")
            {
                lbl_Dato.Show();
                lbl_Dato.Text = "Matrícula:";
                txtDato.Show();
            }
            else if (cmbTipoBoleto.Text == "Adulto Mayor")
            {
                lbl_Dato.Show();
                lbl_Dato.Text = "Código INAPAM:";
                txtDato.Show();
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            Boleto boleto = null;

            if (cmbTipoBoleto.Text == "Estudiante")
            {
                // Aquí va BoletoEstudiante
            }
            else if (cmbTipoBoleto.Text == "Adulto Mayor")
            {
                // Aquí va BoletoAdultoMayor
            }
            else if (cmbTipoBoleto.Text == "General")
            {
                boleto = new BoletoGeneral();
            }
            else
            {
                MessageBox.Show("Selecciona un tipo de boleto.");
                return;
            }

            if (boleto != null)
            {
                double total = boleto.CalcularPrecioFinal();
                txtTotal.Text = total.ToString("0.00");
            }
        }
    }
}
