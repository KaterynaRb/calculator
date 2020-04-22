using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string which_textBox;

        private void buttonDigit_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //if (which_textBox == textBox_Expression.Name)
            //{ 
                textBox_Expression.Text += (sender as Button).Text; // вставка тексту (цифр)
            //}
        }

        private void ButtonBackSpace_Click(object sender, EventArgs e)
        {
            if (which_textBox == textBox_Expression.Name)
            {
                int i = textBox_Expression.Text.Length;
                if (i == 1)
                    textBox_Expression.Clear();
                else if (i != 0)
                    textBox_Expression.Text = textBox_Expression.Text.Remove(textBox_Expression.Text.Length - 1);
            }
        
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            this.textBox_Expression.Text = "";
            this.textBox_Result.Text = "";
        }

        private void textBox_GotFocus(object sender, EventArgs e)
        {
            which_textBox = (sender as TextBox).Name;
        }
    }
}
