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
            // 畫進度條
            Thread thread = new Thread(new ThreadStart(new Action(delegate
            {

                for (int i = 0; i < 76; i++)
                {
                    Thread.Sleep(i/5);
                    this.circleProgressBar.Progress = i + 1;
                }
            })));
            thread.IsBackground = true;
            thread.Start();

            Bitmap waterIcon = new Bitmap("../../../res/habitCheckingRes/waterIcon.png");
            Bitmap studyIcon = new Bitmap("../../../res/habitCheckingRes/studyIcon.png");
            Bitmap fitnessIcon = new Bitmap("../../../res/habitCheckingRes/fitnessIcon.png");
            Bitmap meditationIcon = new Bitmap("../../../res/habitCheckingRes/meditationIcon.png");
            button1.BackgroundImage = waterIcon;
            button2.BackgroundImage = studyIcon;
            button3.BackgroundImage = fitnessIcon;
            button4.BackgroundImage = meditationIcon;
            button1.Click += new EventHandler(this.button_Click);
            button2.Click += new EventHandler(this.button_Click);
            button3.Click += new EventHandler(this.button_Click);
            button4.Click += new EventHandler(this.button_Click);
        }
        private void button_Click(object sender, System.EventArgs e)
        {
            Random random = new Random();
            int full = random.Next(0, 101);
            int sleep = 1000 / full;
            // 畫進度條
            Thread thread = new Thread(new ThreadStart(new Action(delegate
            {

                for (int i = 0; i < full; i++)
                {
                    Thread.Sleep(sleep);
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
