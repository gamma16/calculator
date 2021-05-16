using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnoff();
        }

        Double answer = 0;
        string cal_operation = "";
        bool oper_pressed = false;
        string fnum = "";

        int number = 0;


        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            cal_operation = b.Text;
            answer = Double.Parse(display.Text);
            oper_pressed = true;
         
            display.Text = answer + " " + cal_operation;
            fnum =  answer + " " + cal_operation;

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((display.Text == "0") || (oper_pressed))
            {
                display.Clear();
                number = 0;
            }
                
            oper_pressed = false;
            Button b = (Button)sender;
            if(b.Text=="." && number<1)
            {
                number++;
                display.Text = display.Text + b.Text;
            }
            if(b.Text!=".")
            {
                display.Text = display.Text + b.Text;
            }
           
        }

        private void clear_click(object sender, EventArgs e)
        {
            display.Text = "0";
            number = 0;
        }

        private void clear_all(object sender, EventArgs e)
        {
            display.Text = "0";
            answer = 0;
            number = 0;
        }

        private void equal_click(object sender, EventArgs e)
        {
          
            switch (cal_operation)
            {
                case "+":
                    display.Text = (answer + Double.Parse(display.Text)).ToString();
                    break;
                case "-":
                    display.Text = (answer - Double.Parse(display.Text)).ToString();
                    break;
                case "*":
                    display.Text = (answer * Double.Parse(display.Text)).ToString();
                    break;
                case "/":
                    display.Text = (answer / Double.Parse(display.Text)).ToString();
                    break;
                default:
                    break;
            }
            double ans = double.Parse(display.Text);
            if(ans==(double)ans)
            {
                number = 1;
            }
            else
            number = 0;
              
        }

        private void button21_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            answer = 0;
            number = 0;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            btnon();
            display.Text = "0";
            answer = 0;
            number = 0;
            display.Enabled = true;

        }

        private void off_Click(object sender, EventArgs e)
        {
            btnoff();
            display.Text = "0";
            answer = 0;
            number = 0;
            
        }

        private void btnoff()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            off.Enabled = false;
            button21.Enabled = false;
            on.Enabled = true;
            display.Enabled = false;



        }

        private void btnon()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            off.Enabled = true;
            button21.Enabled = true;
            on.Enabled = false;



        }
    }
}
