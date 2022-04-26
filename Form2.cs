
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaa2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            string stored = "call practica2.consulta('" + clave.Text + "');";
            string MySQLConnectionString = "server = 127.0.0.1;port=3306; username = root; password = ; database = practica2";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand commandDatabase = new MySqlCommand(stored, databaseConnection);

            try
            {
                databaseConnection.Open();
                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = commandDatabase;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                grid.DataSource = tabla;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query error" + ex.Message);
            }
            databaseConnection.Close();
        }
    }
}
