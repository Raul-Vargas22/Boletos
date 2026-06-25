namespace Boletos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RBtnEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnNormal.Checked)
            {
                lbl_Dato.Hide();
                txtDato.Hide();
            }
            else if (RBtnEstudiante.Checked)
            {
                lbl_Dato.Show();
                lbl_Dato.Text = "Matricula";
                txtDato.Show();
            }
            else
            {
                lbl_Dato.Show();
                lbl_Dato.Text = "Codigo INAPAM";
                txtDato.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
