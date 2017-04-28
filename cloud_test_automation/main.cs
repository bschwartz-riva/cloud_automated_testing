using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class main
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            test next;
            //for each scenario in the xml file
            foreach (var scenario in "scenarios.xml".scenarios) {
                //create a queue of all applicable tests
                queue run = queue();
                //while the queue is not empty, and not "stalled" get the "next" test to be performed and run it
                while (!queue.empty && !queue.stalled) {
                    next = queue.next();
                    next.run();
                }
            }
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
