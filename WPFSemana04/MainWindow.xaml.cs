using System;
using System.Collections.Generic;
using System.Data;
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

namespace WPFSemana04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Person> people = new List<Person>();
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-1VIGL39\\SQLEXPRESS; initial catalog = School; Integrated Security=True;");

            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@FirstName";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Value = txtFirstName.Text.Trim();


            SqlParameter parameter2 = new SqlParameter();
            parameter2.ParameterName = "@LastName";
            parameter2.SqlDbType = SqlDbType.VarChar;
            parameter2.Value = txtLastName.Text.Trim();

            SqlCommand command = new SqlCommand("BuscarPersonaNombreCompleto", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(parameter);
            command.Parameters.Add(parameter2);


            connection.Open();


            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Person person = new Person
                {
                    PersonID = reader["PersonID"] != DBNull.Value ? (int)reader["PersonID"] : 0,
                    FirstName = reader["FirstName"] != DBNull.Value ? (string)reader["FirstName"] : string.Empty,
                    LastName = reader["LastName"] != DBNull.Value ? (string)reader["LastName"] : string.Empty,
                    FullName = string.Format("{0} {1}", reader["FirstName"], reader["LastName"]).Trim()

                };

                people.Add(person);

            }
            connection.Close();
            dgvPeople.ItemsSource = people;
        }

    }
}
