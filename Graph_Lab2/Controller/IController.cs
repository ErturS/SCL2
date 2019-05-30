using Graph_Lab2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph_Lab2.Controller
{
    public interface IController
    {
        void LoadImage(ImageModel img);
        void RecognizeImage(ImageModel load, ImageModel recognize);
        void SaveImage(ImageModel img);
        void LoadPlugins();
    }
}
