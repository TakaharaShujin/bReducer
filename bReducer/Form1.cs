using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.IO.Ports;
using System.Reflection;
using Microsoft.Win32;


namespace bReducer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SerialPort SP   = new SerialPort();
        RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
        SaveINI INI     = new SaveINI(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Settings.ini");
        
        private int dragging = 0;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                openPort();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Arduino'yu COM3 portuna takın!");
                Application.ExitThread();
            }
            if (!File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Settings.ini"))
            {
                StreamWriter SettingFile = File.CreateText(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Settings.ini");
                SettingFile.WriteLine("[Settings]\nAutoStart=true\nLowPercent=30");
                SettingFile.Close();
            }
            checker.Start();
            getIniData();
        }

        private void Form1_Closing(object sender, EventArgs e)
        {
            if (SP.IsOpen) SP.Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            hideProgram();
        }

        private void menuKapat_Click(object sender, EventArgs e)
        {
            SetBrightness(100);
            if (SP.IsOpen) SP.Close();
            Application.ExitThread();
        }

        private void checker_Tick(object sender, EventArgs e)
        {
            if (checkPort())
                changeBrightness();
            else
                MessageBox.Show("Port Açılamadı!\n Hata Açıklaması : Port başka bir uygulama tarafından kullanılıyor.");
        }

        private void notifyIcon_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MethodInfo mi = typeof(NotifyIcon).GetMethod("ShowContextMenu", BindingFlags.Instance | BindingFlags.NonPublic);
                mi.Invoke(notifyIcon, null);
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (this.ShowInTaskbar)
                    hideProgram();
                else
                    showProgram();
            }
        }

        private void saveSettings_Click(object sender, EventArgs e)
        {
            if (autoStart.Checked)
            {
                INI.Write("Settings", "AutoStart", "true");
                key.SetValue("bReducer", Application.ExecutablePath);
            }
            else
            {
                INI.Write("Settings", "AutoStart", "false");
                if (key.GetValue("bReducer") != null)
                    key.DeleteValue("bReducer");
            }
            INI.Write("Settings", "LowPercent", yuzdeText.Text);

            MessageBox.Show("Ayarlar Kaydedildi!");
        }

        private void yuzdeScroll_Scroll(object sender, EventArgs e)
        {
            yuzdeText.Text = yuzdeScroll.Value.ToString();
        }

        private void yuzdeText_TextChanged(object sender, EventArgs e)
        {
            yuzdeScroll.Value = int.Parse(yuzdeText.Text);
        }

        private void openPort()
        {
            SP.PortName = "COM3";
            SP.BaudRate = 9600;
            SP.Open();
        }

        private bool checkPort()
        {
            if (SP.IsOpen)
            {
                portStatusLbl.Text = "Açık";
                return true;
            }
            else
            {
                portStatusLbl.Text = "Kapalı";
                return false;
            }
        }

        private void hideProgram()
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;

            notifyIcon.ShowBalloonTip(500, "Otomatik Başlat", "Uygulama çalışıyor..", ToolTipIcon.Info);
        }

        private void showProgram()
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void changeBrightness()
        {
            int sensorData = int.Parse(SP.ReadLine());
            if (sensorData < 300)
                SetBrightness(100);
            else
                SetBrightness(byte.Parse(INI.Read("Settings", "LowPercent")));
            readedDataLbl.Text = Convert.ToString(sensorData);
        }

        static void SetBrightness(byte targetBrightness)
        {
            ManagementScope scope = new ManagementScope("root\\WMI");
            SelectQuery query = new SelectQuery("WmiMonitorBrightnessMethods");
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query))
            {
                using (ManagementObjectCollection objectCollection = searcher.Get())
                {
                    foreach (ManagementObject mObj in objectCollection)
                    {
                        mObj.InvokeMethod("WmiSetBrightness",
                            new Object[] { UInt32.MaxValue, targetBrightness });
                        break;
                    }
                }
            }
        }

        private void getIniData()
        {
            bool AutoStart  = bool.Parse(INI.Read("Settings", "AutoStart"));
            int LowPercent  = int.Parse(INI.Read("Settings", "LowPercent"));
            if (AutoStart)
            {
                autoStart.Checked = true;
                key.SetValue("bReducer", Application.ExecutablePath);
            }
            else
            {
                autoStart.Checked = false;
                if (key.GetValue("bReducer") != null)
                    key.DeleteValue("bReducer");
            }
            yuzdeText.Text = LowPercent.ToString();
            yuzdeScroll.Value = LowPercent;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = 1;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging == 1)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));

            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = 0;
        }
    }
}
