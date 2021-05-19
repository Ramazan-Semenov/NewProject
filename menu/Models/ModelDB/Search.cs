using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace menu.Models.ModelDB
{
    class Search
    {
        public void combosearch(DataGrid DataGridViewReload, ComboBox comboBox1)
        {
            try
            {
                List<string> list = new List<string>();
                for (int i = 0; i < DataGridViewReload.Columns.Count; i++)
                {
                    list.Add(DataGridViewReload.Columns[i].Header.ToString());
                }
                comboBox1.ItemsSource = list;
            }
            catch (Exception exp)
            { MessageBox.Show(exp.Message); }

        }
        public void search(TextBox textBox, DataGrid dataGrid, string nametable, string nameCollumn)
        {
            SqlConnection connection = new SqlConnection(DBConnectMsSql.connectionString);
            try
            {
                string cmdCL = "SELECT * FROM [" + nametable + "] WHERE [" + nameCollumn + "] like N'%" + textBox.Text + "%' ";

                connection.Open();

                SqlCommand cmd = new SqlCommand(cmdCL, connection);

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dataGrid.ItemsSource = dt.DefaultView;

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                connection.Close();

            }

        }
    }
}
