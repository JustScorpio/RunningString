using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunningString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (textBoxStaticString.TextLength == 0)
                return;
            else
                timer1.Enabled = true;

            var runningStringWidth = textBoxRunningString.Width;
            var text = textBoxStaticString.Text.Trim();
            while (text.Length < runningStringWidth) //Ширина задаётся в пикселях. Исходим из того что минимальный размер символа - 1 пиксель
                text += " | " + textBoxStaticString.Text.Trim();

            textBoxRunningString.Text = text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBoxRunningString.Text = textBoxRunningString.Text.Substring(1) + textBoxRunningString.Text[0];
        }
    }
}
