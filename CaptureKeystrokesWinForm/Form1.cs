using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Demonstrates event handlers for capturing keystrokes and mouseclick in a windows forms app.
/// </summary>

namespace CaptureKeystrokesWinForm
{
    public partial class Form1 : Form
    {
        //Set up the counters
        private int keystrokeCounter = 0;
        private int rightclickCounter = 0;
        private int leftclickCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void countKeystrokes()
        {
            // Count all the keystrokes entered into any textbox including backspace char
            keystrokeCounter++;
            labelCount.Text = "Number of keystrokes = " + keystrokeCounter.ToString();


            /// The following code would cause something different 
            /// between keyup and keydown
            //if (keystrokeCounter==1) // first time only
            //{
           //     labelDuplicate.Text = ""; // clear it
           // }
           ///So we now ignore the code.
        }

        // This is the default event handler 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            countKeystrokes();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            countKeystrokes();
        }

        // To record the keystroke when the key is released:
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (sender == textBox1) // sender refers to the control that triggered the event
            {
                //if ((e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z) || (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || e.KeyCode == Keys.Back)
                labelDuplicate.Text += e.KeyCode.ToString();
                
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender == textBox2) // sender refers to the control that triggered the event
            {
                //The keystroke in the textBox2 is ignored so there is no code for it.
            }
        }


        private void ClickBtn_MouseClick(Object sender, MouseEventArgs e) {

            if (e.Button == MouseButtons.Right)
            {
                rightclickCounter++;
                RightClick_Count.Text = "Number of Mouse RightClick = " + rightclickCounter.ToString();
            }
            if (e.Button == MouseButtons.Left)
            {
                leftclickCounter++;
                LeftClick_Count.Text = "Number of Mouse LeftClick = " + leftclickCounter.ToString();
            }



        }
    }
}
