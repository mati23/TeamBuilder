using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team_Builder.Forms;
using System.Windows.Controls;
using MySql.Data.MySqlClient;
namespace Team_Builder.Forms
{
    public partial class InitForm : Form
    {
		int count=0;
		private string connectionString = @"Server=localhost;Database=teambuilder;Uid=root;Password=123456789;";
		public InitForm()
        {
            InitializeComponent();
        }

        private void InitForm_Load(object sender, EventArgs e)
        {
			
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            AddPlayerForm addPlayer = new AddPlayerForm();
            addPlayer.Show();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

		private void UpdateTable(String playerName)
		{
			string sqlString = "SELECT * FROM player WHERE  player_name ='" + playerName + "';";
			MySqlConnection connection = new MySqlConnection(connectionString);
			MySqlCommand command = new MySqlCommand(sqlString, connection);
			command.CommandType = CommandType.Text;
			
			connection.Open();
			
			try
			{
				
				MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
				dataAdapter.SelectCommand = command;
				DataSet dataSet = new DataSet();
				
				//DataTable dataTable = new DataTable();
				//dataAdapter.Fill(dataTable);
				//BindingSource bindingSource = new BindingSource();

				//bindingSource.DataSource = dataTable;
				//mtPlayersGrid.DataSource = bindingSource;
				//mtPlayersGrid.Rows.
				//dataAdapter.Update(dataTable);
				dataAdapter.SelectCommand = command;
				
				dataAdapter.Fill(dataSet, 10, 5, "player");
				
				mtPlayersGrid.DataSource = dataSet.Tables[0];
				
				
				mtPlayersGrid.Columns[0].HeaderText = "ID";
				mtPlayersGrid.Columns[1].HeaderText = "Name";
				mtPlayersGrid.Columns[2].Visible = false;
				mtPlayersGrid.Columns[3].Visible = false;
				mtPlayersGrid.Columns[4].Visible = false;
				mtPlayersGrid.Columns[5].Visible = false;
				mtPlayersGrid.Columns[6].Visible = false;
				mtPlayersGrid.Columns[7].Visible = false;
				mtPlayersGrid.Columns[8].Visible = false;



				/*
				 DataTable dataTable = new DataTable();
				MySqlDataReader reader = command.ExecuteReader();
				dataTable.Load(reader);
				mtPlayersGrid.DataSource = dataTable;
				 */
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
		private void metroTextBox1_TextChanged(object sender, EventArgs e)
		{
			UpdateTable(mtPlayerNameTXT.Text.ToString());	
		}
	}
}
