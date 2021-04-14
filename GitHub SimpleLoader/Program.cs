/*
///=================================================================================================\\\
\\\ SimpleLoader by Wilson, https://github.com/WilsonPublic/SimpleLoader [Open Source Cheat Loader] ///
///  Ported and revamped by core-hacked, https://github.com/core-hacked/SimpleLoader-dotNet5-Port   \\\
\\\   Keep in mind this does not have any encryption or protection, It can be cracked by people.    ///
///=================================================================================================\\\
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleLoader_dotNet5_by_core
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
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
