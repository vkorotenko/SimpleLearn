using System;
using System.Windows.Forms;

namespace SimpleLearn
{
    internal static class Program
    {
        private const string Filename = "test.xml";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new QuestionForm());
        }
    }
}
