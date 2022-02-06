/*
///===================================================================================================\\\
\\\ SimpleLoader by Wilson, https://github.com/WilsonPublic/SimpleLoader [Open Source Cheat Loader]   ///
///  Ported and revamped by core-hacked, https://github.com/core-hacked/SimpleLoader-dotNet6-WPF-Port \\\
\\\   Keep in mind this does not have any encryption or protection, It can be cracked by people.      ///
///===================================================================================================\\\
*/

// Note: some of the things may not fully work without you having started visual studio in admin mode!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using ManualMapInjection.Injection;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Net.Http;

namespace SimpleLoader_dotNet5_Port_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string HWID;
        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HWID = System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;
            HwidTxtBox.Text = HWID;
            checkonline();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 5, 0);
            dispatcherTimer.Start();
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
                        StatusLbl.Foreground = new SolidColorBrush(Colors.Green);
                        StatusLbl.Content = ("You are online");
                    }
                }
            }
            catch
            {
                //If it does not get a response (This means the user is offline or duckduckgo is down for some reason) it will not Exit the application, you can change this by removing "//" before the System.Windows.Application.Current.Shutdown();
                StatusLbl.Foreground = new SolidColorBrush(Colors.Red);
                StatusLbl.Content = ("You are offline");
                //System.Windows.Application.Current.Shutdown(); // you can comment/uncomment this to close the app if it returns that you are offline.
            }
        }

        private async void CopyHWIDbtn_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(HWID);
            CopyHWIDbtn.Foreground = new SolidColorBrush(Colors.Green); // this will change the color of the text on the copy button, you can comment this out or use another color.
            CopyHWIDbtn.Content = "Copied";
            await Task.Delay(500); // this can only be used with the async void property.
            CopyHWIDbtn.Foreground = new SolidColorBrush(Colors.White);
            CopyHWIDbtn.Content = "Copy";
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void MinimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            try { checkonline(); } catch { }
        }

        private void InjectBtn_Click(object sender, RoutedEventArgs e)
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
                InjectVarLbl.Content = $"hmodule = 0x{injector.Inject(file).ToInt64():x8}";

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

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
    }
}
