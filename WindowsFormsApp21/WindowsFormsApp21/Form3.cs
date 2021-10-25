using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp21
{
    public partial class Form3 : Form
    {
        public Form3(object[] o)
        {
            InitializeComponent();

            foreach(object i in o)
            {
                label1.Text += i.ToString()+'\n';
            }
            String[] arr = label1.Text.Split(separator: new char[] { '$', '\n' });
            int sum = 0;
            for (int i = 2; i < arr.Length; i++)
            {

                sum += int.Parse(arr[i]);
                i += 1;
            }
            label9.Text = sum.ToString();
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.MaxDate = DateTime.Today.AddDays(7);
        }
        public Form3()
        {
            InitializeComponent();

        }

        

        

        private void Payment_group(object sender, EventArgs e)
        {
            groupBox3.Show();
            
            if (radioButton1.Checked)
            {
                MessageBox.Show("請直接按結帳紐！");
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
            if (radioButton2.Checked)
            {
                panel1.Enabled = true;
                
                
            }
            else
            {
                panel1.Enabled = false;
                radioButton7.Checked = false;
                radioButton8.Checked = false;
                radioButton9.Checked = false;
                textBox2.Text = "";
            }
            if (radioButton3.Checked)
            {
                panel2.Enabled = true;
                
            }
            else
            {
                panel2.Enabled = false;
                textBox1.Text = "";
            }
            if (radioButton4.Checked)
            {
                panel3.Enabled = true;
                comboBox1.Enabled = true;
                
            }
            else
            {
                panel3.Enabled = false;
                comboBox1.SelectedItem = "";
                label11.Text = "";
                comboBox1.Enabled = false;
                if (comboBox1.Enabled == false)
                {
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                }
            }
            if (radioButton5.Checked)
            {
                panel4.Enabled = true;
               
            }
            else
            {
                panel4.Enabled = false;
                textBox3.Text = "";
            }
            if (radioButton6.Checked)
            {
                panel5.Enabled = true;
                
            }
            else
            {
                panel5.Enabled = false;
                textBox4.Text = "";
            }
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(label9.Text);
                if (num >= 500)
                {
                    this.Close();
                    Form4 f4 = new Form4();
                    f4.Show();
                }
                else
                {
                    MessageBox.Show("您已完成付款！");
                    this.Close();
                }

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            radioButton7.Checked = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            radioButton8.Checked = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            radioButton9.Checked = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label11.Text = comboBox1.SelectedItem.ToString();
            if (radioButton4.Checked == false)
            {
                label11.Text = "";
            }
            if(comboBox1.SelectedIndex == 0 &&radioButton4.Checked==true)
            {
                pictureBox4.Visible = true;
            }
            else
            {
                pictureBox4.Visible = false;
            }
            if (comboBox1.SelectedIndex == 1 && radioButton4.Checked == true)
            {
                pictureBox5.Visible = true;
            }
            else
            {
                pictureBox5.Visible = false;
            }
            if (comboBox1.SelectedIndex == 2 && radioButton4.Checked == true)
            {
                pictureBox6.Visible = true;
            }
            else
            {
                pictureBox6.Visible = false;
            }
            if (comboBox1.SelectedIndex == 3 && radioButton4.Checked == true)
            {
                pictureBox7.Visible = true;
            }
            else
            {
                pictureBox7.Visible = false;
            }
            if (comboBox1.SelectedIndex == 4 && radioButton4.Checked == true)
            {
                pictureBox8.Visible = true;
            }
            else
            {
                pictureBox8.Visible = false;
            }
            if (comboBox1.SelectedIndex == 5 && radioButton4.Checked == true)
            {
                pictureBox9.Visible = true;
            }
            else
            {
                pictureBox9.Visible = false;
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text != "")
            {
                if(radioButton7.Checked == true || radioButton8.Checked == true || radioButton9.Checked == true)
                {
                    button1.Enabled = true;
                }
                
            }
        }

        private void label11_TextChanged(object sender, EventArgs e)
        {
            if (label11.Text != "")
            {
                button1.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                button1.Enabled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                button1.Enabled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                button1.Enabled = true;
            }
        }
    }
}
