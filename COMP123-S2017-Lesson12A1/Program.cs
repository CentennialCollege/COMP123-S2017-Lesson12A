﻿using System;
using System.Collections.Generic;
using System.Linq;
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
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Demo());
        }
    }
}
