using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4._2_Forms
{
    public partial class Form1 : Form
    {
        public static string s = "";
        public Form1()
        {
            InitializeComponent();
        }
        public static void Rec(int n)
        {
            if (n > 0)
             {
                s += n + " ";
                 Rec(n - 1);
             }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
                int n = int.Parse(textBox1.Text);
                if (n == 0)
                textBox2.Text += "Ошибка: N = 0";
                else if (n < 0)
                textBox2.Text += "Ошибка: N меньше 0";
                else if (n > 1000)
                textBox2.Text += "Ошибка: N больше 1000";
                else
                    Rec(n);
            textBox2.Text = s;
            s = "";
        }
    }
}
