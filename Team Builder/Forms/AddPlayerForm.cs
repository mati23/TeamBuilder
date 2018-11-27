using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Builder.Forms
{
    
    public partial class AddPlayerForm : Form
    {   
        
       
        public AddPlayerForm()
        {
            InitializeComponent();
            
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void AddPlayerForm_Load(object sender, EventArgs e)
        {

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

        private void AnyMetroLabel_ValueChanged(MetroFramework.Controls.MetroTrackBar trackBar,
            MetroFramework.Controls.MetroLabel label)
        {
            trackBar.Value = int.Parse(label.Text);
           
            //
        }

        private void mtAttackLabel_Click(object sender, EventArgs e)
        {

        }

        private void mtTrackBarBallControl_Scroll(object sender, ScrollEventArgs e)
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

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

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

        }

        private void metroLabel25_Click(object sender, EventArgs e)
        {

        }

        private void metroTrackBar9_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void metroLabel22_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel23_Click(object sender, EventArgs e)
        {

        }

        private void metroTrackBar8_Scroll(object sender, ScrollEventArgs e)
        {

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

        }

        private void metroLabel19_Click(object sender, EventArgs e)
        {

        }

        private void metroTrackBar6_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void metroLabel16_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel17_Click(object sender, EventArgs e)
        {

        }

        private void metroTrackBar5_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }

        private void metroTrackBar4_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void metroLabel14_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel15_Click(object sender, EventArgs e)
        {

        }

        private void metroTrackBar3_Scroll(object sender, ScrollEventArgs e)
        {

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
    }
}
