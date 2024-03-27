using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caluculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { // Button1.Backcolor changes our button to green when we click the button
            button1.BackColor = Color.Green;
           
            // int a and b int.parse allows our text box 1 and 2 to be stored
            // and used as string data instead of their default int data
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            
            // int c is a variable that stores whatever calculation we make into it
            int c;
           
            // if radio button 1,2,3,4 and 5 act as a list a user can choose from(add,subtract,multiply,divide and mode.
            // Depending on what button they check the 
            // caluculation that would be made would change.For example ticking radio button 1 (addition) will cause whatever
            // two numbers the user inputs to be added.
            // c.to string() shows the result of the calculations.label 4.text prints data that gives context to your answer
            if (radioButton1.Checked)
            {
                c = a + b;
                label4.Text = "Sum =  " + c.ToString();
            }
            if (radioButton2.Checked)
            {
                c = a - b;
                label4.Text = "Diffrence = " + c.ToString();
            }
            if (radioButton3.Checked)
            {
                c = a * b;
                label4.Text = "Product =  " + c.ToString();
            }
            if (radioButton4.Checked)
            {
                c = a / b;
                label4.Text = "Quotient = " + c.ToString();
            }
            if (radioButton5.Checked)
            {
                
                c = a % b;
                label4.Text = "Remainder = " + c.ToString();

            }


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {   // button1.backcolor changes our button to collor to its assigned color which is red
            button1.BackColor = Color.IndianRed;
            
            // Label4.text chnages our text label 4 to "" whenever we click button 2 (Clear).A "" textbox is blank
            label4.Text = "";
           
            // textbox1.Clear and textbox2.Clear changes our first adn second textbox to blank whenever we click button 2
            textBox1.Clear();
            textBox2.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
