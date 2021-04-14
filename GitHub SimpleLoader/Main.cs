/*
///=================================================================================================\\\
\\\ SimpleLoader by Wilson, https://github.com/WilsonPublic/SimpleLoader [Open Source Cheat Loader] ///
///  Ported and revamped by core-hacked, https://github.com/core-hacked/SimpleLoader-dotNet5-Port   \\\
\\\   Keep in mind this does not have any encryption or protection, It can be cracked by people.    ///
///=================================================================================================\\\
*/

// Note: some of the things may not fully work without you having started visual studio in admin mode!

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManualMapInjection.Injection;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace SimpleLoader_dotNet5_by_core
{
    public partial class Main : Form
    {
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        public Main()
        {
            InitializeComponent();
        }

        string HWID;

        private void Main_Load(object sender, EventArgs e)
        {
            
            string ProjName = "SimpleLoader .NET5 Port by core"; // Change this to auto update name on both form and the label at the top
            this.Text = ProjName;
            NameLbl.Text = ProjName;
            HWID = System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;
            HwidTxtBox.Text = HWID;
            HwidTxtBox.ReadOnly = true;
            checkonline();
            CheckOnlineTimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkonline();
            WebClient wb = new WebClient();
            string HWIDLIST = wb.DownloadString("HWID List URL"); //Replace "HWID List URL" with your own URL to a RAW text (txt) file with all your wanted HWIDs [Example: http://myurl.com/HWID.txt]
            if (HWIDLIST.Contains(HwidTxtBox.Text)) //You can add a "!" before the "HWIDLIST" and after the "if (" to make it into a blacklist HWID system instead of a whitelist HWID system
            {
                string mainpath = "C:\\Windows\\random.dll"; // Here you can change the path where your DLL will be stored until the injection finishes. You will need to use '\\' instead of '\' due to slashes being classed as special characters.
                // Alternatively you can remove the double slashes if you put and @ after = [Example: string mainpath = @"C:\Windows\random.dll"]
                wb.DownloadFile("DLL URL", mainpath); // "DLL URL" you need to replace with the direct download link of your DLL [Example: example.com/myDLL]
                var name = "csgo"; // "csgo" You can replace with any name of your desired game [Example: "hl2"]
                var target = Process.GetProcessesByName(name).FirstOrDefault();
                var path = mainpath;
                var file = File.ReadAllBytes(path);

                //Checking if the DLL isn't found
                if (!File.Exists(path))
                {
                    MessageBox.Show("Error: DLL not found");
                    return;
                }
                
                //Injection, just leave this alone if you are a beginner
                var injector = new ManualMapInjector(target) { AsyncInjection = true };
                InjectVarLbl.Text = $"hmodule = 0x{injector.Inject(file).ToInt64():x8}";
                
                if (System.IO.File.Exists(mainpath)) //Checking if the DLL exists
                {
                    System.IO.File.Delete(mainpath); //Deleting the DLL
                }
            }
            else
            {
                MessageBox.Show("HWID Incorrect");
            }
        }

        private void checkonline() // This is now changed to live update. 
        {
            //Checking if the user can get a response from "https://duckduckgo.com/"
            try
            {
                using (var client = new WebClient())
                {
                    using (client.OpenRead("https://duckduckgo.com/")) // don't use google because they will deny the requests and it will return offline
                    {
                        StatusLbl.ForeColor = Color.Green;
                        StatusLbl.Text = ("You are online");
                    }
                }
            }
            catch
            {
                //If it does not get a response (This means the user is offline or duckduckgo is down for some reason) it will not Exit the application, you can change this by removing "//" before the Application.Exit();
                StatusLbl.ForeColor = Color.Red;
                StatusLbl.Text = ("You are offline");
                Application.Exit();
            }
        }

        async void button2_Click(object sender, EventArgs e) // the async void tells the form that we will use a delay of sorts to not do tasks to fast.
        {
            Clipboard.SetText(HWID);
            CopyHWIDbtn.ForeColor = Color.Green; // this will change the color of the text on the copy button, you can comment this out or use another color.
            //CopyHWIDbtn.ForeColor = Color.FromArgb(50, 205, 50); //This changes the color to be customizable via ARGB. Color code for green
            CopyHWIDbtn.Text = "Copied";
            await Task.Delay(500); // this can only be used with the async void property.
            CopyHWIDbtn.ForeColor = Color.White;
            CopyHWIDbtn.Text = "Copy";
        }

        private void button2_Click_1(object sender, EventArgs e) // if the window is maximized this will minimize it
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckOnlineTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                checkonline();
            }
            catch
            {

            }
        }

        //----------[ Code to enable dragging of the panel at the top, don't to touch or you might break it. ]----------\\
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);

            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
        //---------------------[ End of code to enable dragging of the panel at the top. ]-------------------------------\\

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
