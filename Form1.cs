using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_1_Click(object sender, EventArgs e)
        {
            string bt1;
            bt1 = button_1.Text;
            Text_Box1.Text = Text_Box1.Text + bt1;
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            string bt2;
            bt2 = button_2.Text;
            Text_Box1.Text = Text_Box1.Text + bt2;

        }

        private void button_3_Click(object sender, EventArgs e)
        {
            string bt3;
            bt3 = button_3.Text;
            Text_Box1.Text = Text_Box1.Text + bt3;

        }

        private void button_4_Click(object sender, EventArgs e)
        {
            string bt4;
            bt4 = button_4.Text;
            Text_Box1.Text = Text_Box1.Text + bt4;

        }

        private void button_5_Click(object sender, EventArgs e)
        {
            string bt5;
            bt5 = button_5.Text;
            Text_Box1.Text = Text_Box1.Text + bt5;

        }

        private void button_6_Click(object sender, EventArgs e)
        {
            string bt6;
            bt6 = button_6.Text;
            Text_Box1.Text = Text_Box1.Text + bt6;

        }

        private void button_7_Click(object sender, EventArgs e)
        {
            string bt7;
            bt7 = button_7.Text;
            Text_Box1.Text = Text_Box1.Text + bt7;

        }

        private void button_8_Click(object sender, EventArgs e)
        {
            string bt8;
            bt8 = button_8.Text;
            Text_Box1.Text = Text_Box1.Text + bt8;
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            int bt9;
            bt9 = int.Parse(button_9.Text);
            Text_Box1.Text = Text_Box1.Text + bt9.ToString();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (Text_Box1.Text.Contains("+") || Text_Box1.Text.Contains("-") || Text_Box1.Text.Contains("*") || Text_Box1.Text.Contains("/"))
                button_equ_Click(null, null);
            Text_Box1.Text = Text_Box1.Text + button_add.Text;
        }

        private void button_red_Click(object sender, EventArgs e)
        {
            if (Text_Box1.Text.Contains("+") || Text_Box1.Text.Contains("-") || Text_Box1.Text.Contains("*") || Text_Box1.Text.Contains("/"))
                button_equ_Click(null, null);
            Text_Box1.Text = Text_Box1.Text + button_red.Text;
        }

        private void button_mul_Click(object sender, EventArgs e)
        {
            if (Text_Box1.Text.Contains("+") || Text_Box1.Text.Contains("-") || Text_Box1.Text.Contains("*") || Text_Box1.Text.Contains("/"))
                button_equ_Click(null, null);
            Text_Box1.Text = Text_Box1.Text + button_mul.Text;
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            if (Text_Box1.Text.Contains("+") || Text_Box1.Text.Contains("-") || Text_Box1.Text.Contains("*") || Text_Box1.Text.Contains("/"))
                button_equ_Click(null, null);
            Text_Box1.Text = Text_Box1.Text + button_div.Text;
        }

        private void button_equ_Click(object sender, EventArgs e)
        {
            if (Text_Box1.Text.Contains("+"))
            {
                int n = Text_Box1.Text.IndexOf("+");
                int first = int.Parse(Text_Box1.Text.Substring(0, n));
                int second = int.Parse(Text_Box1.Text.Substring(n + 1));
                Text_Box1.Clear();
                Text_Box1.Text = (first + second).ToString();
            }
            else if (Text_Box1.Text.Contains("-"))
            {
                int n = Text_Box1.Text.IndexOf('-');
                long first = long.Parse(Text_Box1.Text.Substring(0, n));    //避免字符过长，超出Int范围
                long second = long.Parse(Text_Box1.Text.Substring(n + 1));
                Text_Box1.Clear();
                Text_Box1.Text = (first - second).ToString();
            }
            else if (Text_Box1.Text.Contains("*"))
            {
                int n = Text_Box1.Text.IndexOf('*');
                int first = int.Parse(Text_Box1.Text.Substring(0, n));
                int second = int.Parse(Text_Box1.Text.Substring(n + 1));

                Text_Box1.Clear();
                Text_Box1.Text = (first * second).ToString();
            }
            else if (Text_Box1.Text.Contains("/"))
            {
                int n = Text_Box1.Text.IndexOf('/');
                float first = int.Parse(Text_Box1.Text.Substring(0, n));        //float(除法)
                float second = int.Parse(Text_Box1.Text.Substring(n + 1));
                Text_Box1.Clear();
                Text_Box1.Text = (first / second).ToString();
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            Text_Box1.Clear();
        }

        private void 复制ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (Text_Box1.SelectedText.Equals(""))
                return;
            Clipboard.SetDataObject(Text_Box1.SelectedText,true);
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                this.粘贴ToolStripMenuItem.Enabled = true;
                this.Text_Box1.Paste();
            }
            else
            {
                this.粘贴ToolStripMenuItem.Enabled = false;   
            }
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Powered by puregardenia","版权");
        }

        private void Text_Box1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
