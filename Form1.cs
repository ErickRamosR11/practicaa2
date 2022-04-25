using MySql.Data.MySqlClient;
namespace practicaa2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            runQuery();
        }

        private void runQuery()
        {
            string query_person = "insert into persons (nombre,paterno,materno) values ('" + nombre.Text + "','" + paterno.Text + "','" + materno.Text + "');";
            string query_address = "insert into addresses (calle,colonia,numero) values ('" + calle.Text + "','" + colonia.Text + "','" + numero.Text + "');";
            string query_distributor = "insert into distribuitor (id,fecha_reg) values ('" + clave.Text + "','" + fecha.Text + "');";
            string MySQLConnectionString = "server = 127.0.0.1;port=3306; username = root; password = ; database = practica2";

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query_person, databaseConnection);
            MySqlCommand commandDatabase2 = new MySqlCommand(query_address, databaseConnection);
            MySqlCommand commandDatabase3 = new MySqlCommand(query_distributor, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            commandDatabase2.CommandTimeout = 60;
            commandDatabase3.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                databaseConnection.Open();
                MySqlDataReader myReader2 = commandDatabase2.ExecuteReader();
                databaseConnection.Close();
                databaseConnection.Open();
                MySqlDataReader myReader3 = commandDatabase3.ExecuteReader();
                databaseConnection.Close();

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        Console.WriteLine("Your query generated results, please see the console");
                    }
                }
                else
                {
                    MessageBox.Show("Query successfully executed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query error" + ex.Message);
            }
        }
    }
}