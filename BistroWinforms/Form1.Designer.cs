namespace BistroWinforms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labeladd = new System.Windows.Forms.Label();
            this.listBoxBuyer = new System.Windows.Forms.ListBox();
            this.labelBuyer = new System.Windows.Forms.Label();
            this.labelSumBuyer = new System.Windows.Forms.Label();
            this.buttonSUM = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.combBoxDish1 = new System.Windows.Forms.ComboBox();
            this.buttonChoise = new System.Windows.Forms.Button();
            this.combBoxsalads = new System.Windows.Forms.ComboBox();
            this.combBoxdessert = new System.Windows.Forms.ComboBox();
            this.labelsalads = new System.Windows.Forms.Label();
            this.labeldessert = new System.Windows.Forms.Label();
            this.combBoxdrink = new System.Windows.Forms.ComboBox();
            this.labeldrink = new System.Windows.Forms.Label();
            this.labeljam = new System.Windows.Forms.Label();
            this.combBoxjam = new System.Windows.Forms.ComboBox();
            this.labelsauce = new System.Windows.Forms.Label();
            this.combBoxsauce = new System.Windows.Forms.ComboBox();
            this.labelcontainer = new System.Windows.Forms.Label();
            this.combBoxcontainer = new System.Windows.Forms.ComboBox();
            this.checkBoxMilk = new System.Windows.Forms.CheckBox();
            this.checkBoxsugar = new System.Windows.Forms.CheckBox();
            this.radButtLemon = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labeldish = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labeladd
            // 
            this.labeladd.AutoSize = true;
            this.labeladd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeladd.Location = new System.Drawing.Point(202, 13);
            this.labeladd.Name = "labeladd";
            this.labeladd.Size = new System.Drawing.Size(200, 25);
            this.labeladd.TabIndex = 1;
            this.labeladd.Text = "Добавить в напиток";
            // 
            // listBoxBuyer
            // 
            this.listBoxBuyer.FormattingEnabled = true;
            this.listBoxBuyer.ItemHeight = 20;
            this.listBoxBuyer.Location = new System.Drawing.Point(441, 56);
            this.listBoxBuyer.Name = "listBoxBuyer";
            this.listBoxBuyer.Size = new System.Drawing.Size(197, 144);
            this.listBoxBuyer.TabIndex = 4;
            this.listBoxBuyer.SelectedIndexChanged += new System.EventHandler(this.listBoxBuyer_SelectedIndexChanged);
            // 
            // labelBuyer
            // 
            this.labelBuyer.AutoSize = true;
            this.labelBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBuyer.Location = new System.Drawing.Point(436, 13);
            this.labelBuyer.Name = "labelBuyer";
            this.labelBuyer.Size = new System.Drawing.Size(202, 25);
            this.labelBuyer.TabIndex = 5;
            this.labelBuyer.Text = "Корзина покупателя";
            // 
            // labelSumBuyer
            // 
            this.labelSumBuyer.AutoSize = true;
            this.labelSumBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumBuyer.Location = new System.Drawing.Point(445, 347);
            this.labelSumBuyer.Name = "labelSumBuyer";
            this.labelSumBuyer.Size = new System.Drawing.Size(156, 25);
            this.labelSumBuyer.TabIndex = 6;
            this.labelSumBuyer.Text = "Сумма покупки";
            // 
            // buttonSUM
            // 
            this.buttonSUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSUM.Location = new System.Drawing.Point(441, 229);
            this.buttonSUM.Name = "buttonSUM";
            this.buttonSUM.Size = new System.Drawing.Size(193, 36);
            this.buttonSUM.TabIndex = 8;
            this.buttonSUM.Text = "Посчитать";
            this.buttonSUM.UseVisualStyleBackColor = true;
            this.buttonSUM.Click += new System.EventHandler(this.buttonSUM_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(441, 385);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 26);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // combBoxDish1
            // 
            this.combBoxDish1.FormattingEnabled = true;
            this.combBoxDish1.Location = new System.Drawing.Point(28, 41);
            this.combBoxDish1.Name = "combBoxDish1";
            this.combBoxDish1.Size = new System.Drawing.Size(121, 28);
            this.combBoxDish1.TabIndex = 10;
            this.combBoxDish1.SelectedIndexChanged += new System.EventHandler(this.combBoxDish1_SelectedIndexChanged);
            // 
            // buttonChoise
            // 
            this.buttonChoise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChoise.Location = new System.Drawing.Point(441, 467);
            this.buttonChoise.Name = "buttonChoise";
            this.buttonChoise.Size = new System.Drawing.Size(193, 36);
            this.buttonChoise.TabIndex = 8;
            this.buttonChoise.Text = "Сохранить заказ ";
            this.buttonChoise.UseVisualStyleBackColor = true;
            this.buttonChoise.Click += new System.EventHandler(this.buttonChoise_Click);
            // 
            // combBoxsalads
            // 
            this.combBoxsalads.FormattingEnabled = true;
            this.combBoxsalads.Location = new System.Drawing.Point(28, 122);
            this.combBoxsalads.Name = "combBoxsalads";
            this.combBoxsalads.Size = new System.Drawing.Size(121, 28);
            this.combBoxsalads.TabIndex = 10;
            this.combBoxsalads.SelectedIndexChanged += new System.EventHandler(this.combBoxsalads_SelectedIndexChanged);
            // 
            // combBoxdessert
            // 
            this.combBoxdessert.FormattingEnabled = true;
            this.combBoxdessert.Location = new System.Drawing.Point(30, 211);
            this.combBoxdessert.Name = "combBoxdessert";
            this.combBoxdessert.Size = new System.Drawing.Size(121, 28);
            this.combBoxdessert.TabIndex = 10;
            this.combBoxdessert.SelectedIndexChanged += new System.EventHandler(this.combBoxdessert_SelectedIndexChanged);
            // 
            // labelsalads
            // 
            this.labelsalads.AutoSize = true;
            this.labelsalads.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelsalads.Location = new System.Drawing.Point(25, 94);
            this.labelsalads.Name = "labelsalads";
            this.labelsalads.Size = new System.Drawing.Size(83, 25);
            this.labelsalads.TabIndex = 1;
            this.labelsalads.Text = "Салаты";
            this.labelsalads.Click += new System.EventHandler(this.label1_Click);
            // 
            // labeldessert
            // 
            this.labeldessert.AutoSize = true;
            this.labeldessert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeldessert.Location = new System.Drawing.Point(28, 183);
            this.labeldessert.Name = "labeldessert";
            this.labeldessert.Size = new System.Drawing.Size(98, 25);
            this.labeldessert.TabIndex = 1;
            this.labeldessert.Text = "Десерты";
            this.labeldessert.Click += new System.EventHandler(this.label1_Click);
            // 
            // combBoxdrink
            // 
            this.combBoxdrink.FormattingEnabled = true;
            this.combBoxdrink.Location = new System.Drawing.Point(28, 284);
            this.combBoxdrink.Name = "combBoxdrink";
            this.combBoxdrink.Size = new System.Drawing.Size(121, 28);
            this.combBoxdrink.TabIndex = 10;
            this.combBoxdrink.SelectedIndexChanged += new System.EventHandler(this.combBoxdrink_SelectedIndexChanged);
            // 
            // labeldrink
            // 
            this.labeldrink.AutoSize = true;
            this.labeldrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeldrink.Location = new System.Drawing.Point(36, 256);
            this.labeldrink.Name = "labeldrink";
            this.labeldrink.Size = new System.Drawing.Size(90, 25);
            this.labeldrink.TabIndex = 1;
            this.labeldrink.Text = "Напитки";
            this.labeldrink.Click += new System.EventHandler(this.label1_Click);
            // 
            // labeljam
            // 
            this.labeljam.AutoSize = true;
            this.labeljam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeljam.Location = new System.Drawing.Point(36, 334);
            this.labeljam.Name = "labeljam";
            this.labeljam.Size = new System.Drawing.Size(74, 25);
            this.labeljam.TabIndex = 1;
            this.labeljam.Text = "Джем";
            this.labeljam.Click += new System.EventHandler(this.label1_Click);
            // 
            // combBoxjam
            // 
            this.combBoxjam.FormattingEnabled = true;
            this.combBoxjam.Location = new System.Drawing.Point(28, 362);
            this.combBoxjam.Name = "combBoxjam";
            this.combBoxjam.Size = new System.Drawing.Size(121, 28);
            this.combBoxjam.TabIndex = 10;
            this.combBoxjam.SelectedIndexChanged += new System.EventHandler(this.combBoxjam_SelectedIndexChanged);
            // 
            // labelsauce
            // 
            this.labelsauce.AutoSize = true;
            this.labelsauce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelsauce.Location = new System.Drawing.Point(36, 412);
            this.labelsauce.Name = "labelsauce";
            this.labelsauce.Size = new System.Drawing.Size(55, 25);
            this.labelsauce.TabIndex = 1;
            this.labelsauce.Text = "Соус";
            this.labelsauce.Click += new System.EventHandler(this.label1_Click);
            // 
            // combBoxsauce
            // 
            this.combBoxsauce.FormattingEnabled = true;
            this.combBoxsauce.Location = new System.Drawing.Point(28, 440);
            this.combBoxsauce.Name = "combBoxsauce";
            this.combBoxsauce.Size = new System.Drawing.Size(121, 28);
            this.combBoxsauce.TabIndex = 10;
            this.combBoxsauce.SelectedIndexChanged += new System.EventHandler(this.combBoxsauce_SelectedIndexChanged);
            // 
            // labelcontainer
            // 
            this.labelcontainer.AutoSize = true;
            this.labelcontainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelcontainer.Location = new System.Drawing.Point(36, 497);
            this.labelcontainer.Name = "labelcontainer";
            this.labelcontainer.Size = new System.Drawing.Size(113, 25);
            this.labelcontainer.TabIndex = 1;
            this.labelcontainer.Text = "Контейнер";
            this.labelcontainer.Click += new System.EventHandler(this.label1_Click);
            // 
            // combBoxcontainer
            // 
            this.combBoxcontainer.FormattingEnabled = true;
            this.combBoxcontainer.Location = new System.Drawing.Point(28, 525);
            this.combBoxcontainer.Name = "combBoxcontainer";
            this.combBoxcontainer.Size = new System.Drawing.Size(121, 28);
            this.combBoxcontainer.TabIndex = 10;
            this.combBoxcontainer.SelectedIndexChanged += new System.EventHandler(this.combBoxcontainer_SelectedIndexChanged);
            // 
            // checkBoxMilk
            // 
            this.checkBoxMilk.AutoSize = true;
            this.checkBoxMilk.Location = new System.Drawing.Point(21, 18);
            this.checkBoxMilk.Name = "checkBoxMilk";
            this.checkBoxMilk.Size = new System.Drawing.Size(92, 24);
            this.checkBoxMilk.TabIndex = 11;
            this.checkBoxMilk.Text = "молоко";
            this.checkBoxMilk.UseVisualStyleBackColor = true;
            this.checkBoxMilk.CheckedChanged += new System.EventHandler(this.checkBoxMilk_CheckedChanged);
            // 
            // checkBoxsugar
            // 
            this.checkBoxsugar.AutoSize = true;
            this.checkBoxsugar.Location = new System.Drawing.Point(21, 62);
            this.checkBoxsugar.Name = "checkBoxsugar";
            this.checkBoxsugar.Size = new System.Drawing.Size(78, 24);
            this.checkBoxsugar.TabIndex = 12;
            this.checkBoxsugar.Text = "сахар";
            this.checkBoxsugar.UseVisualStyleBackColor = true;
            this.checkBoxsugar.CheckedChanged += new System.EventHandler(this.checkBoxsugar_CheckedChanged);
            // 
            // radButtLemon
            // 
            this.radButtLemon.AutoSize = true;
            this.radButtLemon.Location = new System.Drawing.Point(21, 92);
            this.radButtLemon.Name = "radButtLemon";
            this.radButtLemon.Size = new System.Drawing.Size(82, 24);
            this.radButtLemon.TabIndex = 13;
            this.radButtLemon.TabStop = true;
            this.radButtLemon.Text = "лимон";
            this.radButtLemon.UseVisualStyleBackColor = true;
            this.radButtLemon.CheckedChanged += new System.EventHandler(this.radButtLemon_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxMilk);
            this.panel1.Controls.Add(this.radButtLemon);
            this.panel1.Controls.Add(this.checkBoxsugar);
            this.panel1.Location = new System.Drawing.Point(207, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 141);
            this.panel1.TabIndex = 14;
            // 
            // labeldish
            // 
            this.labeldish.AutoSize = true;
            this.labeldish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeldish.Location = new System.Drawing.Point(25, 13);
            this.labeldish.Name = "labeldish";
            this.labeldish.Size = new System.Drawing.Size(146, 25);
            this.labeldish.TabIndex = 1;
            this.labeldish.Text = "Первое блюдо";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(682, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.combBoxcontainer);
            this.Controls.Add(this.combBoxsauce);
            this.Controls.Add(this.combBoxjam);
            this.Controls.Add(this.combBoxdrink);
            this.Controls.Add(this.combBoxdessert);
            this.Controls.Add(this.combBoxsalads);
            this.Controls.Add(this.combBoxDish1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonChoise);
            this.Controls.Add(this.buttonSUM);
            this.Controls.Add(this.labelcontainer);
            this.Controls.Add(this.labelSumBuyer);
            this.Controls.Add(this.labelsauce);
            this.Controls.Add(this.labelBuyer);
            this.Controls.Add(this.labeljam);
            this.Controls.Add(this.listBoxBuyer);
            this.Controls.Add(this.labeldrink);
            this.Controls.Add(this.labeldessert);
            this.Controls.Add(this.labelsalads);
            this.Controls.Add(this.labeldish);
            this.Controls.Add(this.labeladd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "BistroMenu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labeladd;
        private System.Windows.Forms.ListBox listBoxBuyer;
        private System.Windows.Forms.Label labelBuyer;
        private System.Windows.Forms.Label labelSumBuyer;
        private System.Windows.Forms.Button buttonSUM;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox combBoxDish1;
        private System.Windows.Forms.Button buttonChoise;
        private System.Windows.Forms.ComboBox combBoxsalads;
        private System.Windows.Forms.ComboBox combBoxdessert;
        private System.Windows.Forms.Label labelsalads;
        private System.Windows.Forms.Label labeldessert;
        private System.Windows.Forms.ComboBox combBoxdrink;
        private System.Windows.Forms.Label labeldrink;
        private System.Windows.Forms.Label labeljam;
        private System.Windows.Forms.ComboBox combBoxjam;
        private System.Windows.Forms.Label labelsauce;
        private System.Windows.Forms.ComboBox combBoxsauce;
        private System.Windows.Forms.Label labelcontainer;
        private System.Windows.Forms.ComboBox combBoxcontainer;
        private System.Windows.Forms.CheckBox checkBoxMilk;
        private System.Windows.Forms.CheckBox checkBoxsugar;
        private System.Windows.Forms.RadioButton radButtLemon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labeldish;
    }
}

