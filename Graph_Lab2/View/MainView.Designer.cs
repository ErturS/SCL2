namespace Graph_Lab2
{
    partial class MainView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoadImg = new System.Windows.Forms.PictureBox();
            this.RecImg = new System.Windows.Forms.PictureBox();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.RecognizeBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LoadImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecImg)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadImg
            // 
            this.LoadImg.ErrorImage = null;
            this.LoadImg.InitialImage = null;
            this.LoadImg.Location = new System.Drawing.Point(9, 13);
            this.LoadImg.Name = "LoadImg";
            this.LoadImg.Size = new System.Drawing.Size(374, 270);
            this.LoadImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoadImg.TabIndex = 0;
            this.LoadImg.TabStop = false;
            // 
            // RecImg
            // 
            this.RecImg.Location = new System.Drawing.Point(430, 13);
            this.RecImg.Name = "RecImg";
            this.RecImg.Size = new System.Drawing.Size(374, 270);
            this.RecImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RecImg.TabIndex = 1;
            this.RecImg.TabStop = false;
            // 
            // LoadBtn
            // 
            this.LoadBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LoadBtn.Location = new System.Drawing.Point(12, 1);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(95, 38);
            this.LoadBtn.TabIndex = 2;
            this.LoadBtn.Text = "Загрузить картинку";
            this.LoadBtn.UseVisualStyleBackColor = false;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // RecognizeBtn
            // 
            this.RecognizeBtn.Location = new System.Drawing.Point(433, 347);
            this.RecognizeBtn.Name = "RecognizeBtn";
            this.RecognizeBtn.Size = new System.Drawing.Size(86, 36);
            this.RecognizeBtn.TabIndex = 3;
            this.RecognizeBtn.Text = "Распознать 1 и 0";
            this.RecognizeBtn.UseVisualStyleBackColor = true;
            this.RecognizeBtn.Click += new System.EventHandler(this.RecognizeBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SaveBtn.Location = new System.Drawing.Point(723, 5);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(95, 34);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Сохранить картинку";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Исходная картинка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(428, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Обработанная картинка";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 467);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 102);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(363, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "*Плагин находиться в папке \"Plugins\" рядом с  исполняемым файлом";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(550, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "*С начала нужно загрузить картинку с папки simple,потом нажимается кнопка \"Обрабо" +
    "тать изображение\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(459, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "*Алгоритм разпознавания единиц  и нулей работает только для картинок  в папке sim" +
    "ple";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.RecImg);
            this.panel2.Controls.Add(this.LoadImg);
            this.panel2.Location = new System.Drawing.Point(3, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 296);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(394, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(28, 340);
            this.panel3.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "->";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(298, 347);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pnlControls
            // 
            this.pnlControls.Location = new System.Drawing.Point(3, 347);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(279, 114);
            this.pnlControls.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Выполнить плагин";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(844, 581);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RecognizeBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.LoadBtn);
            this.Name = "MainView";
            this.Text = "Распознавание  единиц и нулей";
            ((System.ComponentModel.ISupportInitialize)(this.LoadImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecImg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LoadImg;
        private System.Windows.Forms.PictureBox RecImg;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button RecognizeBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button button1;
    }
}

