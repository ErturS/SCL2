using Graph_Lab2.Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using BLL;
using System.Drawing.Drawing2D;

namespace Graph_Lab2.ImageRotationPlugin
{
    public class Rotation : IPlugin
    {
        public string Name { get { return "Rotation"; } }

        public int ParamNumber { get { return 1; } }

        public List<string> ParamNames
        {
            get
            {
                return new List<string>() { "Угол поворота" };
            }
        }
        public List<object> Controls
        {
            get;
            set;
        }
        public string Description { get { return "This plugin allows you to rotate the image by angle. Enter an angle in degrees in the text box"; } }

        public Type TypeOfParams
        {
            get { return typeof(int); }

        }

        public PluginTypeEnum PluginType { get { return PluginTypeEnum.Rotation; } }

        public Bitmap Run(Bitmap img, params object[] parameters)
        {
            
            if (parameters.Length != 1) throw new Exception("Ожидается " + ParamNumber + " параметра!");
            if (!(parameters[0] is int)) throw new Exception("Параметр должен быть типа int");
            //Bitmap resImage = img;
            int angle = (int)parameters[0];
            Bitmap result = new Bitmap(img.Width, img.Height);
            Graphics g = Graphics.FromImage(result);
            g.TranslateTransform(img.Width / 2, img.Height / 2);
            g.RotateTransform(angle);
            g.TranslateTransform(-img.Width / 2, -img.Height / 2);
            g.DrawImage(img, new Point(0, 0));
            return result;
        }
    }
}
