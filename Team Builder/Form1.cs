using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Team_Builder
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Server=localhost;Database=teambuilder;Uid=root;Password=123456789;";
        public Form1()
        {
            InitializeComponent();
            fillData();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void fillData()
        {
            string sql_query = "SELECT * FROM player;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(sql_query,connection);
            command.CommandType = CommandType.Text;
            connection.Open();
            try
            {
                DataTable playersDataTable = new DataTable();
                MySqlDataReader playerDataReader = command.ExecuteReader();
                playersDataTable.Load(playerDataReader);
                if (playersDataTable.Rows.Count > 0)
                {
                    mtGridPlayers.DataSource = playersDataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'teambuilderDataSet.actstyle'. Você pode movê-la ou removê-la conforme necessário.
            this.actstyleTableAdapter.Fill(this.teambuilderDataSet.actstyle);

        }
    }
}
