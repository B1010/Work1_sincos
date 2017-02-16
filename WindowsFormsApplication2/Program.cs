using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    static class DataSettings
    {
        public static decimal numericUpDown1 { get; set; } = 10;
        public static decimal numericUpDown2 { get; set; } = 50;
        public static bool radioButton1 { get; set; } = true;
        public static bool radioButton2 { get; set; } = false;
        public static bool radioButton3 { get; set; } = false;
        public static bool radioButton4 { get; set; } = false;
    }
}
