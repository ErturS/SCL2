using Graph_Lab2.Plugin;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
namespace Graph_Lab2.ImageFlippingPlugin
{
    public class Flip : IPlugin
    {
        public string Name { get { return "Flip"; } }
        public int ParamNumber {get { return 1; } }
        public List<string> ParamNames
        {
            get {
                   return new List<string>() { "Зеркальное отражение"};
                }
        }
        public List<object> Controls {
            get;
            set;
        }
        public string Description { get { return "This plugin allows you to flip an image vertically and horizontally!Commands:V-flip vertically,H-Horizontally"; }  }

        public Type TypeOfParams { get { return typeof(string); }

        }

        public PluginTypeEnum PluginType { get { return PluginTypeEnum.Reflection; } }

        public Bitmap Run(Bitmap img, params object[] parameters )
        {
            if (parameters.Length != 1) throw new Exception("Ожидается "+ ParamNumber+" параметра!");
            if (!(parameters[0] is string)) throw new Exception("Параметр должен быть типа string");
                if ((string)parameters[0] == "H")
                {
                    return HorizontalReflection(img);
                } else if ((string)parameters[0] == "V")
                {
                    return VerticalReflection(img);
                }
                else throw new Exception("Входные параметры метода Run не верны");
        }
        public Bitmap HorizontalReflection(Bitmap input)
        {
            Bitmap result = input;
            result.RotateFlip(RotateFlipType.RotateNoneFlipX);
            return result;
        }

        public Bitmap VerticalReflection(Bitmap input)
        {
            Bitmap result = input;
            result.RotateFlip(RotateFlipType.RotateNoneFlipY);
            return result;
        }
    }
}
