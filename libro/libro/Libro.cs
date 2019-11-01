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
    public partial class Libro : Form
    {
        private String fileName="";
        private String hoja= "LIBROS FÍSICOS MATRZ";
        public Libro()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_openfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx"; //le indicamos el tipo de filtro en este caso que busque
                                                                             //solo los archivos excel

            dialog.Title = "Seleccione el archivo de Excel";//le damos un titulo a la ventana

            dialog.FileName = string.Empty;//inicializamos con vacio el nombre del archivo

            //si al seleccionar el archivo damos Ok
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_archivoname.Text = dialog.FileName;

                fileName= dialog.FileName;
                if (!fileName.Equals("") || !hoja.Equals(""))
                {
                    XLSConectión conect = new XLSConectión(fileName, hoja);
                    cbo_filtro.DataSource = conect.GetColumnsFilter();
                    cbo_filtro.DisplayMember = "Nombre";
                    cbo_filtro.ValueMember = "Value";
                    cbo_filtro.SelectedIndex = 0;
                    grv_data.DataSource = conect.GetAllData().Tables[0];
                    
                }
                //el nombre del archivo sera asignado al textbox
                //txtArchivo.Text = dialog.FileName;
                //hoja = txtHoja.Text; //la variable hoja tendra el valor del textbox donde colocamos el nombre de la hoja
                //LLenarGrid(txtArchivo.Text, hoja); //se manda a llamar al metodo

                //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //se ajustan las
                //columnas al ancho del DataGridview para que no quede espacio en blanco (opcional)
            }
        }

        private void Btn_filter_Click(object sender, EventArgs e)
        {
            if (!fileName.Equals("")||!hoja.Equals(""))
            {
               
                //cbo_filtro.DataSource = conect.GetColumnsFilter();
                //cbo_filtro.DisplayMember = "Nombre";
                //cbo_filtro.ValueMember = "Value";
                //cbo_filtro.SelectedIndex = 0;
                String _filter = cbo_filtro.SelectedValue.ToString();
                if (_filter.Equals("1"))
                {
                    XLSConectión conect = new XLSConectión(fileName, hoja);
                    grv_data.DataSource = conect.GetAllData().Tables[0];
                }
                else
                {
                    String val = txt_filter.Text;
                    
                    XLSConectión conect = new XLSConectión(fileName, hoja);
                    grv_data.DataSource = conect.GetDataFilter(_filter, val).Tables[0];
                    
                }

            }
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            int index= grv_data.SelectedRows[0].Index;
            if (index!=-1)
            {
                DataGridViewRow row = grv_data.Rows[index];
                String pos = row.Cells[0].Value.ToString();
                XLSConectión conect = new XLSConectión(fileName, hoja);
                conect.DeleteRow(pos);
                grv_data.DataSource = conect.GetAllData().Tables[0];
            }
            else
            {
                MessageBox.Show("Seleccione una fila para elimnar");
            }
        }

        private void Btn_openCorreo_Click(object sender, EventArgs e)
        {
            EnviarCorreo correo = new EnviarCorreo();
            correo.Show();
        }
    }
}
