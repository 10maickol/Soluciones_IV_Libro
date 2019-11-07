using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libro
{
    public partial class EnviarCorreo : Form
    {
        public String FilePath { get; set; }
        Correo c = new Correo();
        public EnviarCorreo(String FilePath)
        {
            InitializeComponent();
            txtarchivoruta.Text = FilePath;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btnarchivo_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    txtarchivoruta.Text = this.openFileDialog1.FileName;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la ruta del archivo: " + ex.ToString());
            }
        }

        private void Btnenviar_Click(object sender, EventArgs e)
        {
            c.enviarCorreo(txtemisor.Text,txtcontraseña.Text,txtmensaje.Text,txtasunto.Text,txtreceptor.Text,txtarchivoruta.Text);
        }
    }
}
