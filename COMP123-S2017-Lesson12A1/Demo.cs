using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Tom Tsilipoulos
 * Date: August 1, 2017
 * Description: This is a Demo Application to showcase User Interface Controls
 * Version: 0.1 - Created the Project
 */

namespace COMP123_S2017_Lesson12A1
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the Event Handler for the HelloButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelloButton_Click(object sender, EventArgs e)
        {
            if(InputTextBox.Text.Length > 0)
            {
                HelloLabel.Text = "Hello, World " + InputTextBox.Text;
            }
            else
            {
                HelloLabel.Text = "Hello, World!";
            }
            
        }


    }
}
