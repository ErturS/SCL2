using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Graph_Lab2.Model;
using Graph_Lab2.Plugin;
using Graph_Lab2.View;

namespace Graph_Lab2.Controller
{
    public class ImageProcessingController:IController
    {
        IView _view;
        PluginLoader _pluginLoader;
        public ImageProcessingController(IView view)
        {
            _view = view;
            _view.SetController(this);
            _pluginLoader = new PluginLoader();
        }
        public void LoadPlugins()
        {
            _pluginLoader = new PluginLoader();
            _pluginLoader.LoadPlugins();
            if(PluginLoader.Plugins.Count==0)
            {
                throw new Exception("Плагины не найдены!");
            }
        }
        public void LoadImage(ImageModel img)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG)|*.BMP;*.JPG";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap bmp = new Bitmap(ofd.FileName);
                    img.Image = bmp;

                }
                catch
                {
                    MessageBox.Show("Нельзя открыть этот файл");
                }
                img.Image = (Bitmap)Image.FromFile(ofd.FileName);
                Graphics.FromImage(img.Image);
            }
        }

        public void RecognizeImage(ImageModel load, ImageModel recognize)
        {
            try
            {
                var ip = new Processing();
                recognize.Image = ip.Recrecognize(new Bitmap(load.Image));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        public void SaveImage(ImageModel img)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Image Files(*.BMP;*.JPG)|*.BMP;*.JPG";
            saveFileDialog1.FilterIndex = 2;
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    img.Image.Save(saveFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
