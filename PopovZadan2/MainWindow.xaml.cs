using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace PopovZadan2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection connection;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = VegAndFruits; Integrated Security = SSPI;");
                connection.Open();
                Out.Text = "Сервер подключен";
            }
            catch
            {
                Out.Text = "Не удалось подключиться";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                connection.Close();
                Out.Text = "Сервер отключен";
            }
            catch
            {
                Out.Text = "Не удалось отключиться";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string Select1 = @"SELECT * FROM VegFruits";
            SqlCommand command = new SqlCommand(Select1, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();

            Vivod.Text = "";
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    Vivod.Text += sqlDataReader[i] + "\t";
                }
                Vivod.Text += "\n";

            }
            sqlDataReader.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string Select1 = @"SELECT Name FROM VegFruits";
            SqlCommand command = new SqlCommand(Select1, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();

            Vivod.Text = "";
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    Vivod.Text += sqlDataReader[i] + "\t";
                }
                Vivod.Text += "\n";

            }
            sqlDataReader.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string Select1 = @"SELECT Color FROM VegFruits";
            SqlCommand command = new SqlCommand(Select1, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();

            Vivod.Text = "";
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    Vivod.Text += sqlDataReader[i] + "\t";
                }
                Vivod.Text += "\n";

            }
            sqlDataReader.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            string Select1 = @"SELECT MAX(Calories) FROM VegFruits";
            SqlCommand command = new SqlCommand(Select1, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();

            Vivod.Text = "";
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    Vivod.Text += sqlDataReader[i] + "\t";
                }
                Vivod.Text += "\n";

            }
            sqlDataReader.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            string Select1 = @"SELECT MIN(Calories) FROM VegFruits";
            SqlCommand command = new SqlCommand(Select1, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();

            Vivod.Text = "";
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    Vivod.Text += sqlDataReader[i] + "\t";
                }
                Vivod.Text += "\n";

            }
            sqlDataReader.Close();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            string Select1 = @"SELECT COUNT(*) as Type FROM VegFruits WHERE Type = 'Veg'";
            SqlCommand command = new SqlCommand(Select1, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();

            Viv.Text = "";
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    Viv.Text += sqlDataReader[i] + "\t";
                }
                Viv.Text += "\n";

            }
            sqlDataReader.Close();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            string Select1 = @"SELECT COUNT(*) as Type FROM VegFruits WHERE Type = 'Fruits'";
            SqlCommand command = new SqlCommand(Select1, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();

            Viv.Text = "";
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    Viv.Text += sqlDataReader[i] + "\t";
                }
                Viv.Text += "\n";

            }
            sqlDataReader.Close();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            string Color = InColor.Text;
            string Select1 = @"SELECT COUNT(*) as Type FROM VegFruits WHERE Color = '" + Color + "'";
            SqlCommand command = new SqlCommand(Select1, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();

            Viv.Text = "";
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    Viv.Text += sqlDataReader[i] + "\t";
                }
                Viv.Text += "\n";

            }
            sqlDataReader.Close();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            string Select1 = @"SELECT COUNT(*) as Type FROM VegFruits";
            SqlCommand command = new SqlCommand(Select1, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();

            Viv.Text = "";
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    Viv.Text += sqlDataReader[i] + "\t";
                }
                Viv.Text += "\n";

            }
            sqlDataReader.Close();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            string number = Convert.ToString(Ind.Text);
            string Select1 = @"SELECT COUNT(*) FROM VegFruits WHERE Calories < " + number;
            SqlCommand command = new SqlCommand(Select1, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();

            Viv.Text = "";
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    Viv.Text += sqlDataReader[i] + "\t";
                }
                Viv.Text += "\n";

            }
            sqlDataReader.Close();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            string Select1 = @"SELECT AVG(Calories) FROM VegFruits";
            SqlCommand command = new SqlCommand(Select1, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();

            Vivod.Text = "";
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    Vivod.Text += sqlDataReader[i] + "\t";
                }
                Vivod.Text += "\n";

            }
            sqlDataReader.Close();
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            string number = Convert.ToString(Ind1.Text);
            string Select1 = @"SELECT COUNT(*) FROM VegFruits WHERE Calories > " + number;
            SqlCommand command = new SqlCommand(Select1, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();

            Viv.Text = "";
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    Viv.Text += sqlDataReader[i] + "\t";
                }
                Viv.Text += "\n";

            }
            sqlDataReader.Close();
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            string number = Convert.ToString(Ind3.Text);
            string number1 = Convert.ToString(Ind2.Text);
            string Select1 = @"SELECT COUNT(*) FROM VegFruits WHERE Calories BETWEEN " + number + " AND " + number1;
            SqlCommand command = new SqlCommand(Select1, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();

            Viv.Text = "";
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    Viv.Text += sqlDataReader[i] + "\t";
                }
                Viv.Text += "\n";

            }
            sqlDataReader.Close();
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            string Select1 = @"SELECT COUNT(*) FROM VegFruits WHERE Color = 'Red' OR Color = 'Yellow'";
            SqlCommand command = new SqlCommand(Select1, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();

            Viv.Text = "";
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    Viv.Text += sqlDataReader[i] + "\t";
                }
                Viv.Text += "\n";

            }
            sqlDataReader.Close();
        }
    }
}
