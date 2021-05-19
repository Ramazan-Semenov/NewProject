using menu.Models.ModelDB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace menu.Views
{
    /// <summary>
    /// Логика взаимодействия для DBWork.xaml
    /// </summary>
    public partial class DBWork : UserControl
    {
        private static string Connstring { get; set; }
        string constr = "";
        LoadDBDataGrid LoadDBDataGrid;
        static Button[] _buttons;
        static int g = 0;
        List<string> list = new List<string>();
        bool on_off_edit = false;
        static string tablename;

        public DBWork()
        {
            InitializeComponent();
            Start(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @"D:\программирование\GenFormDBDll" + "\\Database1.mdf" + ";Integrated Security=True");


        }
        public void Start(string MssqlConnection)
        {

            Connstring = MssqlConnection;
            SqlConnection mySqlConnection = new SqlConnection(MssqlConnection);
            mySqlConnection.Open();

            SqlCommand com = new SqlCommand(@"SELECT Name
 FROM dbo.sysobjects
  WHERE(xtype = 'U')", mySqlConnection);

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {

                g++;
                list.Add(reader[0].ToString());
            }

            mySqlConnection.Close();
            mySqlConnection.Dispose();
            GenButton();
            Save.IsEnabled = false;

            del.IsEnabled = false;
            saveexc.IsEnabled = false;

        }
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            del.IsEnabled = true;
        }
        /// <summary>
        /// Метод для загрузки имен столбцов в Combobox
        /// </summary>
        /// <param name="text">Имя таблицы</param>
        void ds(string text)
        {
            //dataGridView1.Refresh();
            //dataGridView1.Update();

            DBConnectMsSql.connectionString = Connstring;//@"server=localhost;user=root;database=сеть_ресторанов;password=root";// Connstring;
            LoadDBDataGrid = new LoadDBDataGrid(text, dataGridView1);
            LoadDBDataGrid.LoadDB();

            Search search = new Search();
            search.combosearch(dataGridView1, comboBox1);


        }
        /// <summary>
        /// Метод для генерации кнопок
        /// </summary>
        void GenButton()
        {


            Button button = new Button();

            _buttons = new Button[g];
            for (int i = 0; i < _buttons.Length; i++)
            {
                _buttons[i] = new Button();
                //_buttons[i].Location = new Point(0, _buttons[i].Height * i);
                _buttons[i].Content = string.Format(list[i]);
                Console.WriteLine(string.Format(list[i]));
                _buttons[i].Tag = i;

                //_buttons[i].BackColor = System.Drawing.SystemColors.ActiveCaption;
                _buttons[i].Click += my_show_db_clicl;
                _buttons[i].Width = panel1.Width - 20;
                panel1.Children.Add(_buttons[i]);


            }
            g = 0;
        }
        private void my_show_db_clicl(object sender, RoutedEventArgs e)
        {
            string name = (sender as Button).Content.ToString();
            tablename = name;
            Save.IsEnabled = true;
            saveexc.IsEnabled = true;
            del.IsEnabled = true;
            ds(name);
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            LoadDBDataGrid.save();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            LoadDBDataGrid.del();

            del.IsEnabled = false;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SaveExcel saveExcel = new SaveExcel();
            saveExcel.Save(dataGridView1);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            Search search = new Search();
            search.search(textBox1, dataGridView1, tablename, comboBox1.Text);
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Window1 window1 = new Window1();
          //  window1.ShowDialog();
        }
    }
}
