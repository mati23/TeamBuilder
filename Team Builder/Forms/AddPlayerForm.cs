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
using LiveCharts; //Core of the library
using LiveCharts.Wpf; //The WPF controls
using LiveCharts.WinForms; //the WinForm wrappers
using Team_Builder.Classes;
using System.Windows.Forms.DataVisualization.Charting;
namespace Team_Builder.Forms
{
    
    public partial class AddPlayerForm : Form
    {
        private string connectionString = @"Server=localhost;Database=teambuilder;Uid=root;Password=123456789;";
        Player new_player = new Player();
        public AddPlayerForm()
        {
            InitializeComponent();
			Timer timer = new Timer();
			timer.Interval = (100); // 10 secs
			timer.Tick += new EventHandler(Timer_Tick);
			timer.Start();
			LoadComboBoxes();
			MetroFramework.Controls.MetroTrackBar[] trackBars = new MetroFramework.Controls.MetroTrackBar[20];
        }
		public void Timer_Tick(object sender, EventArgs e)
		{
			AddPlayerForm_Load(sender,e);
		}
        //add registry to database
        private void metroTile2_Click(object sender, EventArgs e)
        {
            
            int playerStatsId;//this variable will receive the last id registered in the stats_player's table
            //string of the statement for insertion in stats_player table
            string sqlInsertStats = "INSERT INTO `stats_player` (date_updated,attack,ball_control,dribbling,low_pass,lofted_pass,finishing,curve,header,defensive_skill,ball_winning,kick_power,speed,explosion,body_strenght,physical_contact,jump,goalkeeping,catching,clearing,coverage,reflexes,stamina,non_domminant_foot_usage,non_domminant_foot_precision,`condition`,injury_resistence,stats_club_id,stats_player_name) VALUES (CURDATE()," +
            
             mtTrackBarAttack.Value           + "," +
             mtTrackBarBallControl.Value      + "," +
             mtTrackBarDribbling.Value        + "," +
             mtLowPassTB.Value                + "," +
             mtLoftedPassTB.Value             + "," +
             mtFinishingTB.Value              + "," +
             mtCurveTB.Value                  + "," +
             mtHeadingTB.Value                + "," +
             mtDefensiveTB.Value              + "," +
             mtBallWinningTB.Value            + "," +
             mtKickPowerTB.Value              + "," +
             mtSpeedTB.Value                  + "," +
             mtExplosionTB.Value              + "," +
             mtBodyStrenghtTB.Value           + "," +
             mtPhysicalContactTB.Value        + "," +
             mtJumpTB.Value                   + "," +
             mtGoalkeepingTB.Value            + "," +
             mtCatchingTB.Value               + "," +
             mtClearingTB.Value               + "," +
             mtCoverageTB.Value               + "," +
             mtReflexesTB.Value               + "," +
             mtStaminaTB.Value                + "," +
             mtNDFUsageTB.Value               + "," +
             mtNDFPrecisionTB.Value           + "," +
             mtConditionTB.Value              + "," +
             mtInjuryResistenceTB.Value       + "," +
             "1,'Messi'" + ");";
            

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand commandInsertStats = new MySqlCommand(sqlInsertStats, connection);
            
            commandInsertStats.CommandType = CommandType.Text;
            
            connection.Open();
            try
            {

                List<int> i = new List<int>();
                
                //this part will get the ID of the player just registered and link his ID to the player_stats_id
                var idGetter = new MySqlCommand("SELECT player_id FROM player where player_name ='"
                    + txtPlayerName.Text + "' ORDER BY player_id DESC;", connection);
                playerStatsId = (int)idGetter.ExecuteScalar();
                try
                {
                    string sqlInsertPlayer = "INSERT INTO player (player_name,player_age,player_weight,player_height," +
                    "player_nationality_id,player_dominant_foot,player_stats_id) VALUES ('" +
                    txtPlayerName.Text + "'," +
                    int.Parse(txtPlayerAge.Text) + "," +
                    int.Parse(txtPlayerWeight.Text) + "," +
                    int.Parse(txtPlayerHeight.Text) + "," +
                    1 + "," +
                    "''" + "," +
                    playerStatsId + ");";

                    MySqlCommand commandInsertPlayer = new MySqlCommand(sqlInsertPlayer, connection);
                    commandInsertPlayer.CommandType = CommandType.Text;
                    i.Add(commandInsertPlayer.ExecuteNonQuery());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                i.Add(commandInsertStats.ExecuteNonQuery());
                if (i[0] > 0 && i[1]>0)
                {
                    MessageBox.Show("Player successfully registered!");
                    MessageBox.Show(playerStatsId.ToString());
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
            finally
            {
                connection.Close();
            }
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {
            
        }
		//loads the Chart Content
        private void AddPlayerForm_Load(object sender, EventArgs e)
        {
			/*I tried to clear the current chart to recalculate and redraw the chart in every cycle
			but its not working this way*/
			chart1.Series["s1"].Points.Clear();
			
			chart1.Series.Clear();//clear the current chart
			//
            new_player.SetPlayerStats(	//get values from TrackBars
             mtTrackBarAttack.Value,
             mtTrackBarBallControl.Value,
             mtTrackBarDribbling.Value,
             mtLowPassTB.Value,
             mtLoftedPassTB.Value,
             mtFinishingTB.Value,
             mtCurveTB.Value,
             mtHeadingTB.Value,
             mtDefensiveTB.Value,
             mtBallWinningTB.Value,
             mtKickPowerTB.Value,
             mtSpeedTB.Value,
             mtExplosionTB.Value,
             mtBodyStrenghtTB.Value,
             mtPhysicalContactTB.Value,
             mtJumpTB.Value,
             mtGoalkeepingTB.Value,
             mtCatchingTB.Value,
             mtClearingTB.Value,
             mtCoverageTB.Value,
             mtReflexesTB.Value,
             mtStaminaTB.Value,
             mtNDFUsageTB.Value,
             mtNDFPrecisionTB.Value,
             mtConditionTB.Value,
             mtInjuryResistenceTB.Value,
             1,
             "Messi");
			//recalculate the arithimetic mean and returns as a tag to the chart
			//Ex: {"Agility",60.4}
			Dictionary<string, float> tags = new_player.MeanStats(); 
            //creates a new series of data
            chart1.Series.Add("s1");
			chart1.ChartAreas[0].AxisY.Maximum = 100;
			chart1.ChartAreas[0].AxisY.Minimum = 0;
			
			chart1.Series["s1"].ChartType = SeriesChartType.Radar;
            
            
            foreach (string tagname in tags.Keys)
            {
				//for each set of data, plots the name and its value in the Chart
                chart1.Series["s1"].Points.AddXY(tagname, tags[tagname]);
                
            }

			
		}

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
            /*As there is a lot of input fields with trackbars I decided to make a function
            that take as parameters the input trackbars and use the same behaviour 
            varying only with the maximum and minimum limits*/
            AnyMetroTrackBar_ValueChanged(mtTrackBarAttack, mtAttackLabel, 40, 99);
            
        }
        
        private void MTTrackBarAttack_ValueChanged(Object sernder, System.EventArgs e)
        {
            //updates the int value in the label of its perspective trackbar
            AnyMetroLabel_ValueChanged(mtTrackBarAttack, mtAttackLabel);
        }

        private void AnyMetroTrackBar_ValueChanged(MetroFramework.Controls.MetroTrackBar trackBar,
            MetroFramework.Controls.MetroLabel label, int minimum_limit, int maximum_limit )
        {
            //set maximum and minimum limits as there are players with min of 1 or 40 and max of
            //99 or 3, etc.
            trackBar.Maximum = maximum_limit;
            trackBar.Minimum = minimum_limit;
            //turn the value of the label into the value of the trackbar
            label.Text = trackBar.Value.ToString();
            /*For the fact that some fields have 40 to 99 and other 1 to 3 or even 1 to 7
             The best way to put this is to set 70%,90% or higher for any value of the field
             given as parameter
             */
            if (trackBar.Value < (70 * 100) / maximum_limit)
            {
                label.ForeColor = Color.Red;
            }
            else if(trackBar.Value>= (70 * 100) / maximum_limit && trackBar.Value< (90 * 100) / maximum_limit)
            {
                label.ForeColor = Color.Goldenrod;
            }
            else
            {
                label.ForeColor = Color.DodgerBlue;
            }
            
        }

        private void LoadComboBoxes()
        {   
            //loads the player's dominant foot
            mtDominantFootCB.Items.Add("L");
            mtDominantFootCB.Items.Add("R");
            mtDominantFootCB.Items.Add("LR");

            //load nationality
            List<String> nationality = new List<string>();
            string sqlSelectNationality = "SELECT * FROM nationality";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand commandSelect = new MySqlCommand(sqlSelectNationality, connection);
            commandSelect.CommandType = CommandType.Text;
            connection.Open();
            try
            {
                MySqlDataReader dataReader = commandSelect.ExecuteReader();
                while (dataReader.Read())
                {
                    nationality.Add(dataReader["nationality_name"].ToString());

                }
                mtNationalityCB.DataSource = nationality;
                

            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

        }

        private void AnyMetroLabel_ValueChanged(MetroFramework.Controls.MetroTrackBar trackBar,
            MetroFramework.Controls.MetroLabel label)
        {
            trackBar.Value = int.Parse(label.Text);
           
            //
        }

        private void mtAttackLabel_Click(object sender, EventArgs e)
        {

        }

        public void mtTrackBarBallControl_Scroll(object sender, ScrollEventArgs e)
        {
            AnyMetroTrackBar_ValueChanged(mtTrackBarBallControl, mtLabelBallControl,40,99);
        }

        private void mtLabelBallControl_Click(object sender, EventArgs e)
        {
            AnyMetroLabel_ValueChanged(mtTrackBarBallControl, mtLabelBallControl);
        }

        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void lbBallControl_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				


				//System.IO.StreamReader streamReader = new System.IO.StreamReader(openFileDialog.FileName);
				Image playerImage = Image.FromFile(openFileDialog.FileName);
				playerImage = new Bitmap(playerImage, 130, 140);
				MessageBox.Show("Image Successfully Loaded!");// streamReader.ReadToEnd().ToString()
				playerPictureBox.Image = playerImage;
				//streamReader.Close();
			}
        }

       

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Load += AddPlayerForm_Load;
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtPlayerName_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel32_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel33_Click(object sender, EventArgs e)
        {

        }

        private void metroTrackBar13_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void metroLabel34_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel35_Click(object sender, EventArgs e)
        {

        }

        private void metroTrackBar14_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void metroLabel36_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel37_Click(object sender, EventArgs e)
        {

        }

        private void metroTrackBar15_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void metroLabel38_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel39_Click(object sender, EventArgs e)
        {

        }

        private void metroTrackBar16_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void metroLabel40_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel41_Click(object sender, EventArgs e)
        {

        }

        private void metroTrackBar17_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void metroLabel42_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel43_Click(object sender, EventArgs e)
        {

        }

        private void metroTrackBar18_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void metroLabel30_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel31_Click(object sender, EventArgs e)
        {

        }

        private void metroTrackBar12_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void metroLabel28_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel29_Click(object sender, EventArgs e)
        {

        }

        private void metroTrackBar11_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void metroLabel26_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel27_Click(object sender, EventArgs e)
        {

        }

        private void metroTrackBar10_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void metroLabel24_Click(object sender, EventArgs e)
        {
            AnyMetroLabel_ValueChanged(mtDefensiveTB, mtDefensiveLabel);
        }

        private void metroLabel25_Click(object sender, EventArgs e)
        {

        }

        private void metroTrackBar9_Scroll(object sender, ScrollEventArgs e)
        {
            AnyMetroTrackBar_ValueChanged(mtDefensiveTB, mtDefensiveLabel, 40, 99);
        }

        private void metroLabel22_Click(object sender, EventArgs e)
        {
            AnyMetroLabel_ValueChanged(mtHeadingTB, mtHeadingLabel);
        }

        private void metroLabel23_Click(object sender, EventArgs e)
        {

        }

        private void metroTrackBar8_Scroll(object sender, ScrollEventArgs e)
        {
            AnyMetroTrackBar_ValueChanged(mtHeadingTB, mtHeadingLabel, 40, 99);
        }

        private void metroLabel20_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel21_Click(object sender, EventArgs e)
        {

        }

        private void metroTrackBar7_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void metroLabel18_Click(object sender, EventArgs e)
        {
            AnyMetroLabel_ValueChanged(mtFinishingTB, mtFinishingLabel);
        }

        private void metroLabel19_Click(object sender, EventArgs e)
        {

        }

        private void metroTrackBar6_Scroll(object sender, ScrollEventArgs e)
        {
            AnyMetroTrackBar_ValueChanged(mtFinishingTB, mtFinishingLabel, 40, 90);
        }

        private void metroLabel16_Click(object sender, EventArgs e)
        {
            AnyMetroLabel_ValueChanged(mtLoftedPassTB, mtLoftedPassLabel);
        }

        private void metroLabel17_Click(object sender, EventArgs e)
        {

        }

        private void metroTrackBar5_Scroll(object sender, ScrollEventArgs e)
        {
            AnyMetroTrackBar_ValueChanged(mtLoftedPassTB,mtLoftedPassLabel, 40, 99);
        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {
            AnyMetroLabel_ValueChanged(mtLowPassTB, mtLowPassLabel);
        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTrackBar4_Scroll(object sender, ScrollEventArgs e)
        {
            AnyMetroTrackBar_ValueChanged(mtLowPassTB, mtLowPassLabel, 40, 99);
        }

        private void metroLabel14_Click(object sender, EventArgs e)
        {
            AnyMetroLabel_ValueChanged(mtTrackBarDribbling, mtDribblingLabel);
        }

        private void metroLabel15_Click(object sender, EventArgs e)
        {

        }

        private void metroTrackBar3_Scroll(object sender, ScrollEventArgs e)
        {
            AnyMetroTrackBar_ValueChanged(mtTrackBarDribbling, mtDribblingLabel, 40, 99);
        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel12_Click(object sender, EventArgs e)
        {

        }

        private void metroTrackBar1_Scroll_1(object sender, ScrollEventArgs e)
        {

        }

        private void metroLabel13_Click(object sender, EventArgs e)
        {

        }

        private void metroTrackBar2_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void metroLabel44_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel45_Click(object sender, EventArgs e)
        {

        }

        private void metroTrackBar19_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void metroLabel46_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel47_Click(object sender, EventArgs e)
        {

        }

        private void metroTrackBar20_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void metroLabel48_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel49_Click(object sender, EventArgs e)
        {

        }

        private void metroTrackBar21_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void metroLabel50_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel51_Click(object sender, EventArgs e)
        {

        }

        private void metroTrackBar22_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void metroTrackBar23_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
