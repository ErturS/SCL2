﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Lab2.Plugin
{
    public class PluginLoader
    {
        public static List<IPlugin> Plugins { get; set; }
        public void LoadPlugins()
        {
            Plugins = new List<IPlugin>();
            if(Directory.Exists(Constants.FolderName))
            {
                string[] files = Directory.GetFiles(Constants.FolderName);
                foreach(string file in files)
                {
                    if(file.EndsWith(".dll"))
                    {
                        Assembly.LoadFile(Path.GetFullPath(file));

                    }
                }
            }
            Type interfaceType = typeof(IPlugin);

            Type[] types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(p => interfaceType.IsAssignableFrom(p) && p.IsClass)
                .ToArray(); 
            foreach(Type type in types)
            {
                Plugins.Add((IPlugin)Activator.CreateInstance(type));
            }


        }
    }
}
