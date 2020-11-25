using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form_HabitChecking : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        public Form_HabitChecking()
        {
            InitializeComponent();
            Thread thread = new Thread(new ThreadStart(new Action(delegate
            {

                for (int i = 0; i < 76; i++)
                {
                    Thread.Sleep(i);
                    this.circleProgressBar.Progress = i + 1;
                }
            })));
            thread.IsBackground = true;
            thread.Start();
        }

        private void Form_HabitChecking_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void button_back_Click(object sender, EventArgs e) => this.Close();

    }
}
