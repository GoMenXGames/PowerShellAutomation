using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerShellAutomation
{
    static class Program
    {
        public static Main Mainform; //Сыллка на основную форму
        public static UserGroupConfig UserGroupConfigForm; // Конфиг Групп безопасности
        public static UserCreateForm UserCreateform; //Создание пользователей
        public static StopIt stopItForm; // Lol
        internal static string version = "v.0.5 alpha";

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
