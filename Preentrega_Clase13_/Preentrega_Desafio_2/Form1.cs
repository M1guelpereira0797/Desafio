using SistemaGestionEntities;
using SistemaGestionData;
using SistemaGestionBussiness;
using SistemaGestionUI;

namespace Preentrega_Desafio_2
{
    public partial class Form1 : Form
    {
        public int Id;
        public Form1()
        {
            InitializeComponent();
        }
        public void cargarUsuarios()
        {
            List<Usuario> usuarios = UsuarioBussiness.GetUsuarios();
            dgvCliente.AutoGenerateColumns = true;
            dgvCliente.DataSource = usuarios;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           cargarUsuarios();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            Program.form1.Hide();
            form2.Show();
        }
    }
}