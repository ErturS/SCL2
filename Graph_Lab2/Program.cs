using Graph_Lab2.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph_Lab2
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainView view = new MainView();
            view.Visible=false;
            ImageProcessingController controller = new ImageProcessingController(view);
            view.ShowDialog();
        }
    }
}
