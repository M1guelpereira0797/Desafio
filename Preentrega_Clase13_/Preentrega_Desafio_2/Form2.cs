using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Preentrega_Desafio_2;
using SistemaGestionEntities;
using SistemaGestionBussiness;
using SistemaGestionData;
using SistemaGestionUI;


namespace SistemaGestionUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;
            string Apellido = txtApellido.Text;
            string NombreUsuario = txtNombreUsuario.Text;
            string Contrasena = txtContrasena.Text;
            string Mail = txtMail.Text;
            int Id = Program.form1.Id;



            /*UsuarioData usuario = new UsuarioData(Nombre, Apellido, NombreUsuario, Contrasena, Mail, Id );
            UsuarioData gestorBaseDeDatos = new UsuarioData();

            if (Id < 0)
            {
                gestorBaseDeDatos.UpdateUser(Id,  newUser);
                MessageBox.Show("Se actualizo el usuario");
            }
            else
            {
                gestorBaseDeDatos.CreateUser(newUser);
                MessageBox.Show("Se creo nuevo el usuario");
            }
           */
            this.Close();
            Program.form1.Id = 0;
            Program.form1.Show();
        }
    }
}
