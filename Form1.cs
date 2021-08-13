/*
 * Name- Saimen Preet Singh
 * Project Name- Lab 1
 * Description- This project records the number of disease cases and at the end of 7 entries, calculates the average number of cases
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Lab_1
{
    public partial class Form1 : Form
    {
        //initializing the variables
        int day = 1;
        int total = 0;
        double avg = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtInput.Text, out int k) || (Convert.ToInt32(txtInput.Text) < 0 || Convert.ToInt32(txtInput.Text) > int.MaxValue))
            {
                MessageBox.Show("Invalid case value");
                txtInput.Focus();
                //selecting the case entry value
                txtInput.SelectionStart = 0;
                txtInput.SelectionLength = txtInput.Text.Length;
            }

            else
            {
                //adding case value to text2 text box
                txtCases.Text = txtCases.Text + txtInput.Text;
                txtCases.Text += "\r\n";
                total += Convert.ToInt32(txtInput.Text);//adding case to total
                day += 1; //increment day
                txtInput.Text = "";//clearing case entry
                txtInput.Focus();//setting focus to case entry
                if (day == 8)
                {
                    //making enter and case entry button disable
                    btnEnter.Enabled = false;
                    txtInput.Enabled = false;
                    avg = Math.Round(total / 7.0, 2);
                    //setting average to this lablel
                    lblResult.Text = "Average per day : " + avg.ToString();
                    btnReset.Focus();
                }
                else
                    //set day number to this label
                    lblDays.Text = day.ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //reset button
            //clearing all the text boxes and labels
            btnEnter.Enabled = true;
            txtInput.Enabled = true;
            txtCases.Clear();
            day = 1;
            lblDays.Text = day.ToString();
            lblResult.Text = "";
            txtInput.Focus();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            //exit button
            Application.Exit();
        }


    }
}

