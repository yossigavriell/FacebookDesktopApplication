using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


// $G$ THE-001 (-14) your grade on diagrams document - 86. please see comments inside the document. (50% of your grade).

namespace FacebookAppForm
{

    
    // $G$ CSS-999 (-3) class must have access modifiers
    static class Program
    {

        // $G$ CSS-999 (-3) method must have access modifiers
        // $G$ CSS-999 (-3) class must have access modifiers
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
         
        }
    }
}
