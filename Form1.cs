using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalcClass;
using AnalaizerClass;
using calculator;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }
        
        int EndResult = 0;
        int MemoryStore = 0;

        private void buttonDigit_Click(object sender, EventArgs e) // вставка тексту (цифр)
        {
            Button button = (Button)sender;
            textBox_Expression.Text += (sender as Button).Text;

        }

        private void ButtonBackSpace_Click(object sender, EventArgs e)
        {
                int i = textBox_Expression.Text.Length;
                if (i == 1)
                    textBox_Expression.Clear();
                else if (i != 0)
                    textBox_Expression.Text = textBox_Expression.Text.Remove(textBox_Expression.Text.Length - 1);
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            this.textBox_Expression.Text = "";
            this.textBox_Result.Text = "";
        }

        private void memoryDigit_Click(object sender, EventArgs e)
        {
            Button ButtonThatWasPushed = (Button)sender;
            string ButtonText = ButtonThatWasPushed.Text;

            if (ButtonText == "MC") //Memory Clear
            {
                MemoryStore = 0;
                return;
            }

            if (ButtonText == "MR") //Memory Recall
            {
                textBox_Expression.Text = MemoryStore.ToString();
                return;
            }

            if (ButtonText == "M+") // Memory add
            {
                int num;
                bool isNum = int.TryParse(textBox_Result.Text, out num);
                if (isNum)
                {
                    EndResult = Convert.ToInt32(textBox_Result.Text);
                    MemoryStore += EndResult;
                    return;
                }
                else 
                {
                    Global.lastError = "The value of result cannot be converted to a number";
                    textBox_Result.Text = Global.lastError;
                }
            }

        }

        private void button_Equals_Click(object sender, EventArgs e)
        {
            Analaizer.expression = textBox_Expression.Text;
            /*Реалізувати щоб при натисненні на ENTER проводилось обчислення */
            textBox_Result.Text = Analaizer.Estimate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) //при натисненні на ESC програма припиняє роботу
        {
            if (e.KeyData == Keys.Escape)
            {
                ((Form1)sender).Close();
            }
        }
    }
}
