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
/// \author    Yujia
/// \version   V1.0
/// \date      2017-11-01
/// </summary>


namespace CapturesWinForm
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Set up some counters
        /// </summary>
        private int keystrokeCounter = 0;
        private int rightclickCounter = 0;
        private int leftclickCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// @brief Change and display the counter
        /// </summary>
        private void countKeystrokes()
        {
            // Count all the keystrokes entered into any textbox including backspace char
            keystrokeCounter++;
            labelCount.Text = "Number of keystrokes = " + keystrokeCounter.ToString();


            /// @deprecated The following code would cause something different 
            /// between keyup and keydown
            ///  
            // <code>
            //if (keystrokeCounter==1) // first time only
            //{
            //     labelDuplicate.Text = ""; // clear it
            // }
            // </code>
            /// @deprecated  So we now ignore the code.
        }


        /// <summary>
        /// @brief Record the key stroke in TextBox1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            countKeystrokes();
        }


        /// <summary>
        /// @brief Record the key stroke in TextBox2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            countKeystrokes();
        }

        /// <summary>
        /// @brief To record the keystroke when the key is released:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (sender == textBox1) // sender refers to the control that triggered the event
            {
                labelDuplicate.Text += e.KeyCode.ToString();
                
            }
        }

        /// <summary>
        /// @brief To record the keystroke when the key is released:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender == textBox2) //!< sender refers to the control that triggered the event
            {
                //The keystroke in the textBox2 is ignored so there is no code for it.
            }
        }

        /// <summary>
        /// @brief To record the Mouse Click:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
