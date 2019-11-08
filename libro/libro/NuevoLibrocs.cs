using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

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

            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = xla.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)xla.ActiveSheet;
            xla.Visible = true;

            ws.Cells[1, 1] = "Ord";
            ws.Cells[1, 2] = "PRINCIPAL";
            ws.Cells[1, 3] = "SUBNIVEL 1";
            ws.Cells[1, 4] = "SUBNIVEL 2";
            ws.Cells[1, 5] = "Titúlo";
            ws.Cells[1, 6] = "Autor";
            ws.Cells[1, 7] = "isbn/issn";
            ws.Cells[1, 8] = "idioma";
            ws.Cells[1, 9] = "Edicion";
            ws.Cells[1, 10] = "Editorial";
            ws.Cells[1, 11] = "Año";
            ws.Cells[1, 12] = "Ejemplar";
            ws.Cells[1, 13] = "Tipo";

            ws.Cells[2, 1] = orden;
            ws.Cells[2, 2] = principal;
            ws.Cells[2, 3] = nivel1;
            ws.Cells[2, 4] = nivel2;
            ws.Cells[2, 5] = titulo;
            ws.Cells[2, 6] = autor;
            ws.Cells[2, 7] = iss;
            ws.Cells[2, 8] = idioma;
            ws.Cells[2, 9] = edicion;
            ws.Cells[2, 10] = editorial;
            ws.Cells[2, 11] = anno;
            ws.Cells[2, 12] = ejemplar;
            ws.Cells[2, 13] = tipo;



        }

        private void NuevoLibrocs_Load(object sender, EventArgs e)
        {

        }

        private void cb_principal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
