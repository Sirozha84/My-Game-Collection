﻿using System;
using System.Windows.Forms;

namespace My_Games
{
    static class Program
    {
        public static string Version = "2.0 (27.02.2020)";

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
