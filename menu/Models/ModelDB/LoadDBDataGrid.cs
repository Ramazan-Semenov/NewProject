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
    class LoadDBDataGrid : DBConnectMsSql
    {
        protected SqlCommandBuilder sqlCommandBuilder { get; set; }
        protected static DataSet dataSet = null;
        private readonly DataGrid datagridView;
        private readonly string NameTable;
        protected SqlDataAdapter SqlDataAdapter = null;
        public int CountTableInDB { get; set; }


        public LoadDBDataGrid(string NameTable, DataGrid datagridView)
        {
            this.datagridView = datagridView;
            this.NameTable = NameTable;

        }

        public void save()
        {
            SqlConnection connection = new SqlConnection(DBConnectMsSql.connectionString);
            connection.Open();
            //фиксируем измененные данные
            SqlDataAdapter.Update(dataSet.Tables[0]);
            connection.Close();
            Reload();
        }

        public void Reload()
        {
            SqlConnection connection = new SqlConnection(DBConnectMsSql.connectionString);
            try
            {


                connection.Open();
                dataSet.Clear();
                dataSet.Tables[NameTable].Clear();
                SqlDataAdapter.Fill(dataSet, NameTable);
                datagridView.ItemsSource = dataSet.Tables[NameTable].DefaultView;


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
        public async Task AsyncLoadDB(DataGrid datagridView)
        {
            await Task.Run(() => LoadDB());


        }
        public int countdtb()
        {




            return dataSet.Tables.Count;
        }
        public void LoadDB()
        {
            SqlConnection connection = new SqlConnection(DBConnectMsSql.connectionString);

            try
            {

                string commantext = "SELECT * FROM " + "[" + NameTable + "] ";

                connection.Open();

                SqlCommand mySqlCommand = new SqlCommand(commantext, connection);

                SqlDataAdapter = new SqlDataAdapter(mySqlCommand);
                sqlCommandBuilder = new SqlCommandBuilder(SqlDataAdapter);
                sqlCommandBuilder.GetDeleteCommand();

                dataSet = new DataSet();

                SqlDataAdapter.Fill(dataSet, NameTable);




                // обновление datagridview

                datagridView.ItemsSource = dataSet.Tables[NameTable].DefaultView;


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

        public void del()
        {
            try
            {

                int ind = datagridView.SelectedIndex;


                dataSet.Tables[NameTable].Rows[ind].Delete();
                SqlDataAdapter.Update(dataSet, NameTable);
                Reload();

            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message.ToString());
            }
        }

        private List<string> ListTableName()
        {
            List<string> list = new List<string>();


            connection.Open();

            SqlCommand com = new SqlCommand("SHOW TABLES", connection);
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                CountTableInDB++;
                ///   comboBox1.Items.Add(reader[0].ToString());
                list.Add(reader[0].ToString());
            }

            connection.Close();
            return list;

        }



    }
}
