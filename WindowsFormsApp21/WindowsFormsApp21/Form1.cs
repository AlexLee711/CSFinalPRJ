using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp21
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            
            InitializeComponent();
        }

        ArrayList account = new ArrayList();    //設定帳號儲存之陣列
        ArrayList password = new ArrayList();   //設定密碼儲存之陣列
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox4.PasswordChar = '\0';   //顯示密碼
            }
            else
            {
                textBox4.PasswordChar = '#';    //將密碼轉換為符號 "#"
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';   //顯示密碼
            }
            else
            {
                textBox2.PasswordChar = '*';    //將密碼轉換為符號 "*"
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s1 = textBox3.Text;
            string s2 = textBox4.Text;
            bool a = account.Contains(s1);  //判斷帳戶名是否有重複
            bool b = password.Contains(s2);  //判斷密碼是否有重複
            if (textBox4.TextLength < 8 || textBox4.Text == textBox3.Text)  //如果密碼長度小於8位元且與帳號名相同，則無法註冊
            {
                MessageBox.Show("無效的申請帳密！！", "請重新註冊", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                textBox3.Text = "";
                textBox4.Text = "";
            }else if (a)    //如果帳號名有人使用，則須重新輸入
            {
                MessageBox.Show("無效的帳號名！！", "此帳號名已有人使用！", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                textBox3.Text = "";
            }
            else if (b)    //如果密碼有人使用，則須重新輸入
            {
                MessageBox.Show("無效的密碼！！", "此密碼已有人使用！", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                textBox4.Text = "";
            }
            else    //其他情況下則可註冊成功
            {
                account.Add(textBox3.Text);
                password.Add(textBox4.Text);
                groupBox2.Hide();   //關閉註冊畫面之groupBox2
                textBox3.Text = "";
                textBox4.Text = "";
                MessageBox.Show("註冊成功！！", "已成為會員", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (account.Contains(textBox1.Text)&&password.Contains(textBox2.Text))  //如果帳密相符則可登入，並開啟Form2
            {
                Form2 f2 = new Form2();
                f2.Show();

            }
            else    //若帳密不符合，則須重新輸入
            {
                MessageBox.Show("帳密錯誤！！","請檢查帳號密碼",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void linkLabel1_Click(object sender, EventArgs e)   //"註冊"連結點擊後，則開啟註冊的groupBox
        {
            groupBox2.Show();
        }
    }
}
