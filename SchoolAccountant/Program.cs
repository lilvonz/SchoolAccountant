﻿using System;
using System.Diagnostics;
using System.Windows.Forms;
using SchoolAccountant.Forms;
using SchoolAccountant.Helpers;
using SchoolAccountant.Models;

namespace SchoolAccountant
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
           
            // todo: remove the "femi", change to login
            Application.Run(new DashBoard("admin"));
//Application.Run(new SchoolSetup("admin"));
//            Application.Run(new Login());
//var rm = new ReceiptModel();
            
//            new ReceiptGenerator(rm).Generate();
//            Process.Start(@"E:\recipt.pdf");
        }
    }
}
