using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/************************************************************
 * Name: Jacob De Lio
 * Student #: 100588162
 * Date Created: May 29th, 2020
 * 
 * Purpose: To create a windows form that calculates the
 * average of the alotted units shipped over the course of
 * 1-7 weeks.
 * *********************************************************/

namespace NET_Lab_1
{
    public partial class frmUnitAverage : Form
    {
        /***************************
        *       DECLARATIONS       *
        ***************************/

        //Counter for later processes
        int generalCounter = 0;

        //Stores what day # it is
        int dayCount = 0;

        //Array for containing the inputted units shipped
        int[] unitAmount = new int[8];

        //The sum of all the units shipped. Used for calculation of average
        double unitSum = 0;

        //The final average of the units shipped
        double unitAverage = 0;

        

        public frmUnitAverage()
        {
            InitializeComponent();

            //Sets the day count to 1 from the get-go
            lblDay.Text = "Day 1";
        }

        //User presses the Exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the application
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //User presses the Reset button
        private void btnReset_Click(object sender, EventArgs e)
        {
            //Clears the units input box
            txtUnits.Clear();

            //Clears the previously recorded units
            txtDailyUnits.Clear();

            //Resets day counter to 0
            dayCount = 0;

            //Resets the day counter back to day 1
            lblDay.Text = "Day 1";

            //Resets the final average variable
            unitAverage = 0;

            //Resets the sum variable
            unitSum = 0;

            //Clears the input textbox
            txtUnits.Text = "";

            //Resets the counter
            generalCounter = 0;

            //Makes the enter button pressable again
            btnEnter.Enabled = true;

            //Clears the final results label
            lblResults.Text = "";

            //Clears the input history textbox
            txtDailyUnits.Text = "";

            //Lets you make inputs again
            txtUnits.ReadOnly = false;

            //Puts the focus on the inputs box
            txtUnits.Focus();
        }

        //User presses the Enter button
        private void btnEnter_Click(object sender, EventArgs e)
        {

            /***************************
            *          INPUTS          *
            ***************************/

            //Checks to see if user entry is a whole number
            if(int.TryParse(txtUnits.Text, out int valCheck))
            {
                //Check to see if user input is OUTSIDE the valid range
                if ((valCheck < 0) || (valCheck > 5000))
                {
                    //Error message
                    lblResults.Text = "ERROR unit amount must be between 0 and 5000. Please try again.";

                    //Clears the input textbox
                    txtUnits.Text = "";

                    //Focus' back onto the input textbox
                    txtUnits.Focus();
                }
                //User has entered a valid entry. Continue with program
                else
                {
                    //Makes the days count up per input
                    dayCount++;

                    //Makes a counter count up for later use
                    generalCounter++;

                    unitAmount[dayCount] = valCheck;

                    //Adds the inputted amounts to the array for later calculations
                    unitAmount[dayCount] = Convert.ToInt32(txtUnits.Text);

                    //Adds inputs to the input history box, making new lines for each entry
                    txtDailyUnits.Text += Convert.ToString(unitAmount[generalCounter]) + Environment.NewLine;

                    //Adds up all the units shipped
                    unitSum += Convert.ToDouble(txtUnits.Text);

                    //Clears the input textbox
                    txtUnits.Text = "";

                    //Formula for determining the overall average
                    unitAverage = unitSum / 7.0;

                    //Rounds results to the nearest decimal
                    Math.Round(unitAverage);
                }
            }
            //User has entered a non whole number. Displays error message
            else
            {
                //Error message
                lblResults.Text = "ERROR unit amounts can only be whole numbers. Please try again.";

                //Clears the input textbox
                txtUnits.Text = "";

                //Focus' back onto the input textbox
                txtUnits.Focus();
            }

            //If statement for if the final 7th day is reached
            if (dayCount == 7)
            {
                //Updates the day counter
                lblDay.Text = "Day " + dayCount;

                //Disables the Enter button
                btnEnter.Enabled = false;

                //Prevents user from inputting anything else
                txtUnits.ReadOnly = true;

                //Displays the final results
                lblResults.Text = "Average units per day: " + Convert.ToString(Math.Round(unitAverage, 2));
            }
            //For if it is not the final 7th day
            else
            {
                //Updates the day counter to the next day
                lblDay.Text = "Day " + Convert.ToInt32(dayCount + 1);
            }

        }
    }
}
