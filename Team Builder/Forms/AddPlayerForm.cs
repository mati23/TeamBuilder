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
    }
}
