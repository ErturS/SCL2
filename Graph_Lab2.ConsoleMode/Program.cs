using Graph_Lab2.Plugin;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Lab2.ConsoleMode
{
    class Program
    {

        static void Main(string[] args)
        {
        //    PluginLoader _pluginLoader = new PluginLoader();
        //    string imgPath;
        //    if(args.Length >= 1)
        //    {
        //        while (true)
        //        {
        //            imgPath = args[0];
        //            _pluginLoader.LoadPlugins();
        //            if (PluginLoader.Plugins.Count == 0)
        //            {
        //                Console.WriteLine("Нет доступных плагинов");
        //                Console.WriteLine("Нажмите любую клавишу для выхода");
        //                Console.ReadKey();
        //                return;
        //            }
        //            Console.WriteLine("Доступные плагины");
        //            int i = 0;
        //            foreach (var plugin in PluginLoader.Plugins)
        //            {

        //                Console.WriteLine("[" + i + "] " + plugin.Name);
        //                i++;
        //            }
        //            Console.WriteLine("Какую из них выбрать?");
        //            Console.WriteLine("Введите номер плагина:");
        //            int num;
        //            num = Int32.Parse(Console.ReadLine());
        //            i = 0;
        //            foreach (var plugin in PluginLoader.Plugins)
        //            {
        //                if (num == i)
        //                {

        //                    Console.WriteLine("Используется плагин:" + plugin.Name + "\n");
        //                    Console.WriteLine("Описание плагина:" + plugin.Description);
        //                    Console.WriteLine("Введите один из комманд V and H:");
        //                    string command = Console.ReadLine();
        //                    string[] commands = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        //                    if (commands[0] == "exit")
        //                    {
        //                        return;
        //                    }
        //                    else if (commands[0] == "V")
        //                    {
        //                        try
        //                        {
        //                            Bitmap bm = new Bitmap(imgPath);
        //                            bm = plugin.Run("V", bm);
        //                            bm.Save(imgPath);
        //                            Console.WriteLine("Изображение обработано и успешно сохранено по пути {0}", imgPath);
        //                            Console.ReadLine();
        //                        }
        //                        catch (Exception ex)
        //                        {
        //                            Console.WriteLine(Environment.NewLine + ex.Message + Environment.NewLine);
        //                            Console.ReadLine();
        //                        }

        //                    }
        //                    else if (commands[0] == "H")
        //                    {
        //                        try
        //                        {
        //                            Bitmap bm = new Bitmap(imgPath);
        //                            bm = plugin.Run("H", bm);
        //                            bm.Save(imgPath);
        //                            Console.WriteLine("Изображение обработано и успешно сохранено по пути {0}", imgPath);
        //                            Console.ReadLine();
        //                        }
        //                        catch (Exception ex)
        //                        {
        //                            Console.WriteLine(Environment.NewLine + ex.Message + Environment.NewLine);
        //                            Console.ReadLine();
        //                        }
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine(Environment.NewLine + "Комманда не верна" + Environment.NewLine);
        //                    }
        //                }
        //                i++;
        //            }


        //        }
        //    }else
        //    {
        //        Console.WriteLine("Запустите программу c одним параметром.Н:programname.exe pathToFileWithName");
        //        Console.ReadLine();
        //    }
        }
    }
}
