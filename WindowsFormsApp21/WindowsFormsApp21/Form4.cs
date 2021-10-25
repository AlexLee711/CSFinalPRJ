using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp21
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] racies = { "九折優惠劵乙張", "咖啡買一送一", "美式咖啡免費", "冰沙券", "參傷悄浮-牛肉麵優惠券", "褲剩蝕-冰淇淋五折券", "單程臺北-高雄高鐵票", "迷你電扇" };
            Random num = new Random();
            textBox1.Text = racies[num.Next(0, 8)];
            button2.Visible = true;
            if(textBox1.Text != "")
            {
                button1.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("感謝您的消費！" + "\n" + textBox1.Text);
            this.Close();
        }
    }
}
