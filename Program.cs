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
        public static ResetPass ResetPassForm; //Создание пользователей
        public static StopIt stopItForm; // Lol
        internal static string name = "AD User & Group: Manager";
        internal static string version = "ver.1.0 release";

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new Main(args[0], args[1]));
            }
            catch (IndexOutOfRangeException) {
                    MessageBox.Show("RU: Ошибка, запустите программу через окно авторизации \n - - - \nEN: Error, run the program through the authorization window", "Ошибка \\ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
