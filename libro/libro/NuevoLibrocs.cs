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
    public partial class NuevoLibrocs : Form
    {
        public NuevoLibrocs()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            String orden = txt_orden.Text;
            String principal = cb_principal.Text;
            String nivel1 = cb_nivel1.Text;
            String nivel2 = cb_nivel2.Text;
            String titulo = txt_titulo.Text;
            String autor = txt_autor.Text;
            String iss = txt_is.Text;
            String idioma = cb_idioma.Text;
            String edicion = txt_edicion.Text;
            String editorial = txt_editorial.Text;
            String anno = txt_anno.Text;
            String ejemplar = txt_ejemplar.Text;
            String tipo = cb_tipo.Text;


        }
    }
}
