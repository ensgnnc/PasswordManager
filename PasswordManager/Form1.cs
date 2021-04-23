using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        public string CreatePassword(int length, string valid)
        {
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            label1.Text = res.ToString();
            return res.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "";

            string harf = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string sayi = "1234567890";
            string sekl = "!@#$%+^&*!@#$%+^&*";

            if (checkBox1.Checked)
            {
                text += harf;
            }
            if (checkBox2.Checked)
            {
                text += harf;
            }
            if (checkBox3.Checked)
            {
                text += sekl;
            }

            int count = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            CreatePassword(count, text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label1.Text);
        }
    }
}
