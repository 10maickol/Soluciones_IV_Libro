using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libro
{
    class XLSConectión
    {
        OleDbConnection conexion = null;
        //DataSet dataSet = null;
        OleDbDataAdapter dataAdapter = null;
        String hoja;
        public XLSConectión(string archivo, string hoja)
        {
            string cadenaConexionArchivoExcel = "provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + archivo + "';Extended Properties=Excel 8.0;";
            conexion = new OleDbConnection(cadenaConexionArchivoExcel);
            this.hoja = hoja;

        }
        public  DataSet GetAllData()
        {        
            
            string consultaHojaExcel = "Select * from [" + hoja + "$]";
            DataSet _dataSet = new DataSet();
            try
            {
                dataAdapter = new OleDbDataAdapter(consultaHojaExcel, conexion); //traemos los datos de la hoja y las guardamos en un dataSdapter
                 // creamos la instancia del objeto DataSet
                dataAdapter.Fill(_dataSet, hoja);//llenamos el dataset
                                                //dataGridView1.DataSource = dataSet.Tables[0]; //le asignamos al DataGridView el contenido del dataSet
                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            return _dataSet;
        }
        public DataTable GetColumnsFilter()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Value");
            Object[] _dato = { "Todos", "1" };
            dt.Rows.Add(_dato);
            string consultaHojaExcel = "Select * from [" + hoja + "$]";
            DataSet _dataSet = new DataSet();
            try
            {
                dataAdapter = new OleDbDataAdapter(consultaHojaExcel, conexion); //traemos los datos de la hoja y las guardamos en un dataSdapter
                                                                                 // creamos la instancia del objeto DataSet
                dataAdapter.Fill(_dataSet, hoja);//llenamos el dataset
                                                 //dataGridView1.DataSource = dataSet.Tables[0]; //le asignamos al DataGridView el contenido del dataSet
                conexion.Close();
                foreach (DataColumn column in _dataSet.Tables[0].Columns)
                {
                    Object[] dato = { column.ColumnName, column.ColumnName };
                    dt.Rows.Add(dato);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public DataSet GetDataFilter(String ColumnFilter,String Value)
        {
            string consultaHojaExcel = "Select * from [" + hoja + "$] WHERE ["+ ColumnFilter.Trim() + "] LIKE '%"+ Value + "%'";
            DataSet _dataSet2 = new DataSet();
            try
            {
                dataAdapter = new OleDbDataAdapter(consultaHojaExcel, conexion); //traemos los datos de la hoja y las guardamos en un dataSdapter
                                                                                 // creamos la instancia del objeto DataSet
                dataAdapter.Fill(_dataSet2, hoja);//llenamos el dataset
                                                 //dataGridView1.DataSource = dataSet.Tables[0]; //le asignamos al DataGridView el contenido del dataSet
                conexion.Close();
            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
            }

            return _dataSet2;
        }
        public void DeleteRow(String pos)
        {
            string consultaHojaExcel = "delete from [" + hoja + "$] WHERE [Ord] = '" + pos + "'";
            DataSet _dataSet2 = new DataSet();
            try
            {
                dataAdapter = new OleDbDataAdapter(consultaHojaExcel, conexion); //traemos los datos de la hoja y las guardamos en un dataSdapter
                                                                                 // creamos la instancia del objeto DataSet
                dataAdapter.Fill(_dataSet2, hoja);//llenamos el dataset
                                                  //dataGridView1.DataSource = dataSet.Tables[0]; //le asignamos al DataGridView el contenido del dataSet
                conexion.Close();
            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
            }
        }
    }
}
