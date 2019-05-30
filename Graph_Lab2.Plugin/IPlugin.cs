using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace Graph_Lab2.Plugin
{
    public interface IPlugin
    {
        string Name { get; }
        int ParamNumber { get; }
        Type TypeOfParams { get; }
        PluginTypeEnum PluginType { get; }
        List<string> ParamNames { get; }
        List<object> Controls { get; set; }
        string Description { get; }
        Bitmap Run(Bitmap img,params object[]parameters);
    }
}
