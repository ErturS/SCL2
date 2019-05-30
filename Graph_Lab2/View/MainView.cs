using BLL;
using Graph_Lab2.Controller;
using Graph_Lab2.Model;
using Graph_Lab2.Plugin;
using Graph_Lab2.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph_Lab2
{
    public partial class MainView : System.Windows.Forms.Form,IView
    {
        IController _controller;
        ImageModel im;
        private readonly Dictionary<PluginTypeEnum, IPlugin> plugins = new Dictionary<PluginTypeEnum, IPlugin>();
        private IPlugin _currentPlugin = null;

        public MainView()
        {
            InitializeComponent();
            im = new ImageModel() ;
        }
        public void SetController(IController cont)
        {
            _controller = cont;
            try
            {
                _controller.LoadPlugins();
                foreach (var plugin in PluginLoader.Plugins)
                {
                    CreateControls(plugin);
                    plugins.Add(plugin.PluginType, plugin);
                    //List<string> lst = new List<string>();
                    //list.Add();
                    //comboBox1.DataSource=
                    //DrawPluginButtons();
                    //if (plugin.Name == "Flip")
                    //{
                    //    DrawPluginButtons();
                    //    break;
                    //}
                }
                List<ComboBoxItem> list =new  List<ComboBoxItem>();
                
                foreach(var plugin in plugins)
                {
                    ComboBoxItem ci = new ComboBoxItem();
                    ci.Name = plugin.Value.Name;
                    ci.Value = plugin.Value.PluginType;
                    list.Add(ci);
                }
                comboBox1.DataSource = list;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Value";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void CreateControls(IPlugin plugin)
        {
            plugin.Controls = new List<object>();
            for (int i = 0; i < plugin.ParamNumber; i++)
            {
                Label lbl = new Label();
                lbl.Text = plugin.ParamNames[i];
                lbl.Name = "lbl" + plugin.ParamNames[i];
                lbl.Visible = false;
                TextBox txtb = new TextBox();
                txtb.Name = "txt" + plugin.ParamNames[i];
                txtb.Text = "";
                txtb.Visible = false;
                Label lblDesc = new Label();
                lblDesc.Text = plugin.Description;
                lblDesc.Name = "lblDescription";
                lblDesc.Visible = false;
                plugin.Controls.AddRange(new Control[] { lbl, txtb, lblDesc });
            }
            PutControlsToPanel(plugin.Controls.Select(x => x as Control).ToList());
            //System.Windows.Forms.Button button1;
            //System.Windows.Forms.Button button2;
            //button1 = new System.Windows.Forms.Button();
            //button2 = new System.Windows.Forms.Button();
            //// 
            //// button1
            //// 
            //button1.Location = new System.Drawing.Point(516, 354);
            //button1.Name = "button1";
            //button1.Size = new System.Drawing.Size(75, 23);
            //button1.TabIndex = 11;
            //button1.Text = "H";
            //button1.UseVisualStyleBackColor = true;
            //// 
            //// button2
            //// 
            //button2.Location = new System.Drawing.Point(675, 354);
            //button2.Name = "button2";
            //button2.Size = new System.Drawing.Size(75, 23);
            //button2.TabIndex = 12;
            //button2.Text = "V";
            //button2.UseVisualStyleBackColor = true;
            //button1.Click += new System.EventHandler(this.button1_Click);
            //button2.Click += new System.EventHandler(this.button2_Click);

            //this.Controls.Add(button2);
            //this.Controls.Add(button1);

        }

        private void PutControlsToPanel(List<Control> controls)
        {
            var x = 0;
            var y = 0;
            foreach (var control in controls)
            {
                if (control.Name.StartsWith("lblDescription"))
                {
                    control.Location = new System.Drawing.Point(288, 400);
                    control.Width = 530;
                    control.Height = 61;
                    Controls.Add(control);
                    continue;

                }

                control.Left = x + 5;
                control.Top = y;
                control.Width = 150;
                control.Height = 18;
                pnlControls.Controls.Add(control);
                y += 20;
            }
        }
        private void button1_Click(object sender,EventArgs e)
        {
            //try
            //{
            //    IPlugin flipper = PluginLoader.Plugins.FirstOrDefault(x => x.Name == "Flip");
            //    RecImg.Image = flipper.Run("H", (Bitmap)RecImg.Image);
            //}catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    IPlugin flipper = PluginLoader.Plugins.FirstOrDefault(x => x.Name == "Flip");
            //    RecImg.Image = flipper.Run("V", (Bitmap)RecImg.Image);
            //}catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        private void LoadBtn_Click(object sender, EventArgs e)
        {
            _controller.LoadImage(im);
            LoadImg.Image = im.Image;
        }

        private void RecognizeBtn_Click(object sender, EventArgs e)
        {
            im.Image= (Bitmap)LoadImg.Image;
            ImageModel recImg = new ImageModel();
            _controller.RecognizeImage(im, recImg);
            RecImg.Image = recImg.Image;


        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            im.Image = (Bitmap)RecImg.Image;
            _controller.SaveImage(im);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Надо выбрать плагин");
                return;
            }

            if (im.Image == null)
            {
                MessageBox.Show("Надо выбрать изображение");
                return;
            }

            using (Bitmap bitmap = new Bitmap(im.Image))
            {
                var item = comboBox1.SelectedItem as ComboBoxItem;
                var plugin = plugins[(PluginTypeEnum)item.Value];
                var dstbitmap = new Bitmap(im.Image);
                Bitmap imgg=null;
                try
                {
                    if (plugin is IPlugin @default)
                    {
                        var cparams = new object[@default.ParamNumber];
                        int cnt = 0;
                        foreach (var param in @default.Controls)
                        {
                            if ((param is Control control))
                            {
                                if (!control.Name.StartsWith("lbl"))
                                {
                                    cparams[cnt] = Convert.ChangeType(control.Text, @default.TypeOfParams);
                                    cnt++;
                                }
                            }
                        }
                        imgg = @default.Run((Bitmap)im.Image, cparams);
                    }
                    RecImg.Image=imgg;
                }
               
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = comboBox1.SelectedItem as ComboBoxItem;
            var plugin = plugins[(PluginTypeEnum)item.Value];
            if (_currentPlugin != null)
            {
                foreach (var control in _currentPlugin.Controls)
                {
                    if (control is Control ctrl)
                        ctrl.Visible = false;
                }
            }

            _currentPlugin = plugin;
            foreach (var control in plugin.Controls)
            {
                if (control is Control ctrl)
                    ctrl.Visible = true;
            }
        }
    }
}
