using System;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace ProjectOne
{
    internal class Calendar
    {
        [STAThread] // Это необходимо для работы с компонентами Windows Forms
        public static void Main()
        {
            DateTime now = GetCurrentDate();
           MessageBox.Show($"Today's date is {now}")
        }

        static DateTime GetCurrentDate()
        {
            return DateTime.Now.Date;
        }
    }
}