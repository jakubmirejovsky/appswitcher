using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MediaServerAppSwitcher
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer t1;
        private System.Windows.Forms.Timer t2;

        public bool savedSettings = false;

        public int secondsOne = 2000; // in ms
        public int secondsTwo = 2000; // in ms
        public int processIdOne = 0;
        public int processIdTwo = 0;

        public int activeProcess = 1;

        public DesktopWindow dw1;
        public DesktopWindow dw2;

        private List<DesktopWindow> listdw;

        public Form1()
        {
            InitializeComponent();

            this.listdw = User32Helper.GetDesktopWindows();

            foreach (DesktopWindow d in this.listdw)
            {
                if (d.IsVisible)
                {
                    listBox1.Items.Add(d);
                    listBox2.Items.Add(d);
                }
            }

            /*
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                if (p.ProcessName != "svchost")
                {
                    listBox1.Items.Add(new ProcessItem(p.Id, p.ProcessName));
                    listBox2.Items.Add(new ProcessItem(p.Id, p.ProcessName));
                }
            }
            */

            this.t1 = new System.Windows.Forms.Timer();

            this.t1.Interval = 1500;

            this.t1.Tick += new EventHandler(timer_Tick);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            this.t1.Interval = activeProcess == 1 ? this.secondsOne : this.secondsTwo;

            //Call method
            Debug.WriteLine("constructor fired");

            if (activeProcess == 1)
            {
                ProcessHelper.SetFocusToExternalApp(this.dw1.Handle);
                activeProcess = 2;
            }
            else
            {
                ProcessHelper.SetFocusToExternalApp(this.dw2.Handle);
                activeProcess = 1;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timerStatus.Text = "Timer is stopped";
            this.t1.Stop();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            //this.processIdOne = ((ProcessItem) lb.SelectedItem).id;
            this.dw1 = ((DesktopWindow) lb.SelectedItem);
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            //this.processIdTwo = ((ProcessItem)lb.SelectedItem).id;
            this.dw2 = ((DesktopWindow)lb.SelectedItem);
        }

        private void startTimerButton_Click(object sender, EventArgs e)
        {
            timerStatus.Text = "Timer is running";
            this.t1.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse((sender as TextBox).Text, out this.secondsOne);
            this.secondsOne *= 1000;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse((sender as TextBox).Text, out this.secondsTwo);
            this.secondsTwo *= 1000;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (this.dw1 == null || this.dw2 == null)
            {
                status.Text = "Please select both applications from lists.";
            }
            else
            {
                savedSettings = true;

                startTimerButton.Enabled = true;
                stopTimerButton.Enabled = true;

                status.Text = "App 1 (" + this.dw1.ToString() + ")¨will be shown for " + (this.secondsOne/1000) +
                              " seconds and then will " +
                              "switch to App 2 (" + this.dw2.ToString() + ") for " + (this.secondsTwo/1000) + " seconds.";
            }
        }

        private void status_Click(object sender, EventArgs e)
        {

        }

        private void secondsOneLabel_Click(object sender, EventArgs e)
        {

        }
    }

    public class ProcessHelper
    {
        public static void SetFocusToExternalApp(IntPtr ipHwnd)
        {
            //Process[] arrProcesses = Process.GetProcessesByName(strProcessName);
            //Process p = Process.GetProcessById(processId);

            //IntPtr ipHwnd = p.MainWindowHandle;
            Thread.Sleep(100);
            SetForegroundWindow(ipHwnd);
            ShowWindow(ipHwnd, 5);

        }

        //API-declaration
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        //API-declaration
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

    }

    class ProcessItem
    {
        public int id;
        public string name;

        public ProcessItem(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return this.name;
        }
    }

    public class DesktopWindow
    {
        public IntPtr Handle { get; set; }
        public string Title { get; set; }
        public bool IsVisible { get; set; }

        public override string ToString()
        {
            return this.Title;
        }
    }

    public class User32Helper
    {
        public delegate bool EnumDelegate(IntPtr hWnd, int lParam);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll", EntryPoint = "GetWindowText",
            ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpWindowText, int nMaxCount);

        [DllImport("user32.dll", EntryPoint = "EnumDesktopWindows",
            ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnumDesktopWindows(IntPtr hDesktop, EnumDelegate lpEnumCallbackFunction,
            IntPtr lParam);

        public static List<DesktopWindow> GetDesktopWindows()
        {
            var collection = new List<DesktopWindow>();
            EnumDelegate filter = delegate (IntPtr hWnd, int lParam)
            {
                var result = new StringBuilder(255);
                GetWindowText(hWnd, result, result.Capacity + 1);
                string title = result.ToString();

                var isVisible = !string.IsNullOrEmpty(title) && IsWindowVisible(hWnd);

                if (isVisible)
                collection.Add(new DesktopWindow { Handle = hWnd, Title = title, IsVisible = isVisible });

                return true;
            };

            EnumDesktopWindows(IntPtr.Zero, filter, IntPtr.Zero);
            return collection;
        }
    }
}
