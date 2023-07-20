using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BistroWinforms
{
    public partial class Form1 : Form
    {
        List<Dish> dish = new List<Dish>{
    new Dish("Бургер",40),
    new Dish("Гамбургер", 30),
    new Dish("Чизбургер", 34)
    };
        List<Dish> salads = new List<Dish>(){
    new Dish("Цезарь",56),
    new Dish("Оливье", 40),
    new Dish("Крабовый", 74)
    };
        List<Dish> dessert = new List<Dish>(){
    new Dish("Мороженое",20),
    new Dish("Торт", 40),
    new Dish("Пироженое", 74)
    };
        List<Dish> drink = new List<Dish>(){
    new Dish("Чай",10),
    new Dish("Кофе", 15),
    new Dish("Компот", 4)
    };
        List<Dish> jam = new List<Dish>(){
    new Dish("Сливовый",5),
    new Dish("Абрикосовый", 10),
    new Dish("Малиновый", 8)
    };
        List<Dish> sauce = new List<Dish>(){
    new Dish("Чесночный",10),
    new Dish("Сырный", 15),
    new Dish("Томатный", 4)
    };
        List<Dish> container = new List<Dish>(){
    new Dish("Маленький",12),
    new Dish("Средний", 17),
    new Dish("Большой", 30)
    };
        List<Dish> milk = new List<Dish>(){
    new Dish("молоко",10)
    };
        List<Dish> sugar = new List<Dish>(){
    new Dish("сахар",11)
    };
        List<Dish> lemon = new List<Dish>(){
    new Dish("лемон",12)
    };

        List<Dish> shopping_basket = new List<Dish>();
        List<int> result = new List<int>();
        int sum;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //сложили меню  блюд в combBox 
            combBoxDish1.Items.AddRange(dish.ToArray());
            combBoxdrink.Items.AddRange(drink.ToArray());
            combBoxsalads.Items.AddRange(salads.ToArray());
            combBoxdessert.Items.AddRange(dessert.ToArray());
            combBoxsauce.Items.AddRange(sauce.ToArray());
            combBoxjam.Items.AddRange(jam.ToArray());
            combBoxcontainer.Items.AddRange(container.ToArray());
            checkBoxMilk.Checked = false;
            checkBoxsugar.Checked = false;
            radButtLemon.Checked = false;
            //combBoxDish1.SelectedIndexChanged += combBoxDish1_SelectedIndexChanged; 
            //listBoxDish.Items.AddRange(dish.ToArray());
            //listBoxBuyer.SelectedIndexChanged += listBoxBuyer_SelectedIndexChanged;
            //textBox1.SelectedText = string.Empty;
        }

        private void listBoxBuyer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void buttonSUM_Click(object sender, EventArgs e)//по нажатию кнопки сумма
        {
            //Из листа корзины мы достали значения стоимости продуктов
            foreach (Dish items in listBoxBuyer.Items)//сложили в корзину(shopping_basket) СОДЕРЖИМОЕ Из  listBoxBuyer
                shopping_basket.Add(items);
            sum = shopping_basket.Select(y => y.Price).Sum();
            textBox1.Text = string.Format("{0} рубль", sum);//вывели результат суммы покупки


        }

        private void textBox1_TextChanged(object sender, EventArgs e)//окошко для суммы покупки
        {

        }


        private void buttonChoise_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "myText";
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.InitialDirectory = @"D:/";
            saveFileDialog.Title = "Сохраните свой файл здесь";
            saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(@"D:/myText.txt", true))
                {
                    sw.WriteLine();
                }
            }
            MessageBox.Show("Файл сохранен");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void combBoxDish1_SelectedIndexChanged(object sender, EventArgs e)// в зависимости от выбора элемента в комбобокс. элемент попадает в корзину
        {
            switch (combBoxDish1.SelectedIndex)
            {
                case 0:
                    listBoxBuyer.Items.Add(combBoxDish1.SelectedItem);
                    break;
                case 1:
                    listBoxBuyer.Items.Add(combBoxDish1.SelectedItem);
                    break;
                case 2:
                    listBoxBuyer.Items.Add(combBoxDish1.SelectedItem);
                    break;
            }
        }
        private void combBoxsalads_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (combBoxsalads.SelectedIndex)
            {
                case 0:
                    listBoxBuyer.Items.Add(combBoxsalads.SelectedItem);
                    break;
                case 1:
                    listBoxBuyer.Items.Add(combBoxsalads.SelectedItem);
                    break;
                case 2:
                    listBoxBuyer.Items.Add(combBoxsalads.SelectedItem);
                    break;
            }
        }

        private void combBoxdessert_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (combBoxdessert.SelectedIndex)
            {
                case 0:
                    listBoxBuyer.Items.Add(combBoxdessert.SelectedItem);
                    break;
                case 1:
                    listBoxBuyer.Items.Add(combBoxdessert.SelectedItem);
                    break;
                case 2:
                    listBoxBuyer.Items.Add(combBoxdessert.SelectedItem);
                    break;
            }
        }

        private void combBoxdrink_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (combBoxdrink.SelectedIndex)
            {
                case 0:
                    listBoxBuyer.Items.Add(combBoxdrink.SelectedItem);
                    break;
                case 1:
                    listBoxBuyer.Items.Add(combBoxdrink.SelectedItem);
                    break;
                case 2:
                    listBoxBuyer.Items.Add(combBoxdrink.SelectedItem);
                    break;
            }
        }

        private void combBoxjam_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (combBoxjam.SelectedIndex)
            {
                case 0:
                    listBoxBuyer.Items.Add(combBoxjam.SelectedItem);
                    break;
                case 1:
                    listBoxBuyer.Items.Add(combBoxjam.SelectedItem);
                    break;
                case 2:
                    listBoxBuyer.Items.Add(combBoxjam.SelectedItem);
                    break;
            }
        }

        private void combBoxsauce_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (combBoxsauce.SelectedIndex)
            {
                case 0:
                    listBoxBuyer.Items.Add(combBoxsauce.SelectedItem);
                    break;
                case 1:
                    listBoxBuyer.Items.Add(combBoxsauce.SelectedItem);
                    break;
                case 2:
                    listBoxBuyer.Items.Add(combBoxsauce.SelectedItem);
                    break;
            }
        }

        private void combBoxcontainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (combBoxcontainer.SelectedIndex)
            {
                case 0:
                    listBoxBuyer.Items.Add(combBoxcontainer.SelectedItem);
                    break;
                case 1:
                    listBoxBuyer.Items.Add(combBoxcontainer.SelectedItem);
                    break;
                case 2:
                    listBoxBuyer.Items.Add(combBoxcontainer.SelectedItem);
                    break;
            }
        }

        private void checkBoxMilk_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMilk.Checked == true)
            {
                MessageBox.Show("Вы выбрали " + checkBoxMilk.Text);
            }
        }
            private void checkBoxsugar_CheckedChanged(object sender, EventArgs e)
            {
                if (checkBoxsugar.Checked == true)
                {
                MessageBox.Show("Вы выбрали " + checkBoxsugar.Text);
                }
            }

            private void radButtLemon_CheckedChanged(object sender, EventArgs e)
            {
                if (checkBoxsugar.Checked == true && checkBoxMilk.Checked == true)
                {
                    radButtLemon.Checked = false;
                }
                else
                MessageBox.Show("Вы выбрали " + radButtLemon.Text);
                }
            }
    } 
