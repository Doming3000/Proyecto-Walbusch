namespace Proyecto_Walbusch
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Establecer placeholder al buscador
            BuscadorEmpleado.Text = "Ingrese nombre o rut";
            BuscadorEmpleado.ForeColor = Color.Gray;
        }

        private void BuscadorEmpleado_Enter(object sender, EventArgs e)
        {
            // Remover el placeholder de los buscadores cuando se haga click en ellos
            if (BuscadorEmpleado.Text == "Ingrese nombre o rut")
            {
                BuscadorEmpleado.Text = "";
                BuscadorEmpleado.ForeColor = Color.Black;
            }
        }

        private void BuscadorEmpleado_Leave(object sender, EventArgs e)
        {
            // Comprobar si el buscador est� vacio para colocar el placeholder
            if (BuscadorEmpleado.Text == "")
            {
                BuscadorEmpleado.Text = "Ingrese nombre o rut";
                BuscadorEmpleado.ForeColor = Color.Gray;
            }
        }

        private void RegresarButton_Click(object sender, EventArgs e)
        {
            // Regresar al formulario inicial
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}