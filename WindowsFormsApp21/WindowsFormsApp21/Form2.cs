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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked == false)
            {
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }
            else 
            {
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                radioButton4.Enabled = true;
            }
        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            if(radioButton6.Checked == true)
            {
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }
            else
            {
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                radioButton4.Enabled = true;
            }
        }



        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            label1.Text = "品名：";
            
            label1.Text = label1.Text + "咖啡拿鐵(M)";
            groupBox1.Enabled = true;
            panel4.Enabled = false;
            panel1.Enabled = true;
            panel2.Enabled = true;

        }


        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            label1.Text = "品名：";
            label5.Text = "總價：";
            label1.Text = label1.Text + "咖啡拿鐵(L)";
            groupBox1.Enabled = true;
            panel4.Enabled = false;
            panel1.Enabled = true;
            panel2.Enabled = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
            int startindex = 3;
            int length = 2;
            label5.Text = "總價：";
            if(label1.Text== "品名：咖啡拿鐵(M)"|| label1.Text == "品名：摩卡(M)"|| label1.Text == "品名：卡布奇諾(M)")
            {
                String substr = toolStripTextBox1.Text.Substring(startindex, length);
                int quantity = int.Parse(numericUpDown1.Value.ToString());
                int total = int.Parse(substr) * quantity;
                label5.Text = label5.Text + "$" + total.ToString();
                
            }
            if (label1.Text == "品名：咖啡拿鐵(L)" || label1.Text == "品名：摩卡(L)" || label1.Text == "品名：卡布奇諾(L)")
            {
                String substr = toolStripTextBox2.Text.Substring(startindex, length);
                int quantity = int.Parse(numericUpDown1.Value.ToString());
                int total = int.Parse(substr) * quantity;
                label5.Text = label5.Text + "$" + total.ToString();
            }
            if (label1.Text == "品名：美式咖啡(M)")
            {
                String substr = toolStripTextBox3.Text.Substring(startindex, length);
                int quantity = int.Parse(numericUpDown1.Value.ToString());
                int total = int.Parse(substr) * quantity;
                label5.Text = label5.Text + "$" + total.ToString();
            }
            if (label1.Text == "品名：美式咖啡(L)")
            {
                String substr = toolStripTextBox4.Text.Substring(startindex, length);
                int quantity = int.Parse(numericUpDown1.Value.ToString());
                int total = int.Parse(substr) * quantity;
                label5.Text = label5.Text + "$" + total.ToString();
            }
            if (label1.Text == "品名：濃縮咖啡(M)")
            {
                String substr = toolStripTextBox5.Text.Substring(startindex, length);
                int quantity = int.Parse(numericUpDown1.Value.ToString());
                int total = int.Parse(substr) * quantity;
                label5.Text = label5.Text + "$" + total.ToString();
            }
            if (label1.Text == "品名：焦糖瑪奇朵(M)")
            {
                String substr = toolStripTextBox6.Text.Substring(startindex, length);
                int quantity = int.Parse(numericUpDown1.Value.ToString());
                int total = int.Parse(substr) * quantity;
                label5.Text = label5.Text + "$" + total.ToString();
            }
            if (label1.Text == "品名：焦糖瑪奇朵(L)")
            {
                String substr = toolStripTextBox7.Text.Substring(startindex, length);
                int quantity = int.Parse(numericUpDown1.Value.ToString());
                int total = int.Parse(substr) * quantity;
                label5.Text = label5.Text + "$" + total.ToString();
            }
            if (label1.Text == "品名：草莓冰沙(L)")
            {
                String substr = toolStripMenuItem12.Text.Substring(startindex, length);
                int quantity = int.Parse(numericUpDown1.Value.ToString());
                int total = int.Parse(substr) * quantity;
                label5.Text = label5.Text + "$" + total.ToString();
            }
            if (label1.Text == "品名：巧克力冰沙(L)")
            {
                String substr = toolStripMenuItem15.Text.Substring(startindex, length);
                int quantity = int.Parse(numericUpDown1.Value.ToString());
                int total = int.Parse(substr) * quantity;
                label5.Text = label5.Text + "$" + total.ToString();
            }
            if (label1.Text == "品名：摩卡冰沙(L)")
            {
                String substr = toolStripMenuItem22.Text.Substring(startindex, length);
                int quantity = int.Parse(numericUpDown1.Value.ToString());
                int total = int.Parse(substr) * quantity;
                label5.Text = label5.Text + "$" + total.ToString();
            }
            if(label1.Text == "品名：英式紅茶(M)"|| label1.Text == "品名：伯爵茶(M)")
            {
                if(radioButton12.Checked == true)
                {
                    String substr = toolStripMenuItem16.Text.Substring(startindex, length);
                    int quantity = int.Parse(numericUpDown1.Value.ToString());
                    int total = (int.Parse(substr) + 10) * quantity ;
                    label5.Text = label5.Text + "$" + total.ToString();
                }
                else
                {
                    String substr = toolStripMenuItem16.Text.Substring(startindex, length);
                    int quantity = int.Parse(numericUpDown1.Value.ToString());
                    int total = int.Parse(substr) * quantity;
                    label5.Text = label5.Text + "$" + total.ToString();
                }
            }
            if (label1.Text == "品名：英式紅茶(L)"|| label1.Text == "品名：伯爵茶(L)")
            {
                if (radioButton12.Checked == true)
                {
                    String substr = toolStripMenuItem17.Text.Substring(startindex, length);
                    int quantity = int.Parse(numericUpDown1.Value.ToString());
                    int total = (int.Parse(substr) + 10) * quantity;
                    label5.Text = label5.Text + "$" + total.ToString();
                }
                else
                {
                    String substr = toolStripMenuItem17.Text.Substring(startindex, length);
                    int quantity = int.Parse(numericUpDown1.Value.ToString());
                    int total = int.Parse(substr) * quantity;
                    label5.Text = label5.Text + "$" + total.ToString();
                }
            }
            if (label1.Text == "品名：日式綠茶(M)")
            {
                if (radioButton12.Checked == true)
                {
                    String substr = toolStripMenuItem19.Text.Substring(startindex, length);
                    int quantity = int.Parse(numericUpDown1.Value.ToString());
                    int total = (int.Parse(substr) + 10) * quantity;
                    label5.Text = label5.Text + "$" + total.ToString();
                }
                else
                {
                    String substr = toolStripMenuItem19.Text.Substring(startindex, length);
                    int quantity = int.Parse(numericUpDown1.Value.ToString());
                    int total = int.Parse(substr) * quantity;
                    label5.Text = label5.Text + "$" + total.ToString();
                }
            }
            if (label1.Text == "品名：日式綠茶(L)")
            {
                if (radioButton12.Checked == true)
                {
                    String substr = toolStripMenuItem21.Text.Substring(startindex, length);
                    int quantity = int.Parse(numericUpDown1.Value.ToString());
                    int total = (int.Parse(substr) + 10) * quantity ;
                    label5.Text = label5.Text + "$" + total.ToString();
                }
                else
                {
                    String substr = toolStripMenuItem21.Text.Substring(startindex, length);
                    int quantity = int.Parse(numericUpDown1.Value.ToString());
                    int total = int.Parse(substr) * quantity;
                    label5.Text = label5.Text + "$" + total.ToString();
                }
            }
             string kind = "";
            string ice = "";
            string sugar = "";
            string milk = "";
            if (radioButton6.Checked == true)
            {
                kind = kind + "\t" + radioButton6.Text;
            }
            if (radioButton5.Checked == true)
            {
                kind = kind + "\t" + radioButton5.Text;
                if (radioButton1.Checked == true)
                {
                    ice = ice + "\t" + radioButton1.Text;
                }
                if (radioButton2.Checked == true)
                {
                    ice = ice + "\t" + radioButton2.Text;
                }
                if (radioButton3.Checked == true)
                {
                    ice = ice + "\t" + radioButton3.Text;
                }
                if (radioButton4.Checked == true)
                {
                    ice = ice + "\t" + radioButton4.Text;
                }
            }
            if (radioButton7.Checked == true)
            {
                sugar = sugar + "\t" + radioButton7.Text;
            }
            if (radioButton8.Checked == true)
            {
                sugar = sugar + "\t" + radioButton8.Text;
            }
            if (radioButton9.Checked == true)
            {
                sugar = sugar + "\t" + radioButton9.Text;
            }
            if (radioButton10.Checked == true)
            {
                sugar = sugar + "\t" + radioButton10.Text;
            }
            if (radioButton11.Checked == true)
            {
                sugar = sugar + "\t" + radioButton11.Text;
            }
            if (radioButton12.Checked == true)
            {
                milk = milk + "\t" + label6.Text;
            }
            if (numericUpDown1.Value != 0)
            {
                
                listBox1.Items.Add(label1.Text + "  " + label5.Text);
                
                richTextBox1.Text += "*. " + label1.Text + kind + ice + sugar  + milk + "\n" ;
                
            }
            numericUpDown1.Value = 0;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
            label1.Text = "品名：";
           
        }

        private void toolStripTextBox3_Click(object sender, EventArgs e)
        {
            label1.Text = "品名：";
            label5.Text = "總價：";
            label1.Text = label1.Text + "美式咖啡(M)";
            groupBox1.Enabled = true;
            panel4.Enabled = false;
            panel1.Enabled = true;
            panel2.Enabled = true;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
        }

        private void toolStripTextBox4_Click(object sender, EventArgs e)
        {
            label1.Text = "品名：";
            label5.Text = "總價：";
            label1.Text = label1.Text + "美式咖啡(L)";
            groupBox1.Enabled = true;
            panel4.Enabled = false;
            panel1.Enabled = true;
            panel2.Enabled = true;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
        }

        private void toolStripTextBox5_Click(object sender, EventArgs e)
        {
            label1.Text = "品名：";
            label5.Text = "總價：";
            label1.Text = label1.Text + "濃縮咖啡(M)";
            groupBox1.Enabled = true;
            panel4.Enabled = false;
            panel1.Enabled = true;
            panel2.Enabled = true;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
        }

        private void toolStripTextBox6_Click(object sender, EventArgs e)
        {
            label1.Text = "品名：";
            label5.Text = "總價：";
            label1.Text = label1.Text + "焦糖瑪奇朵(M)";
            groupBox1.Enabled = true;
            panel4.Enabled = false;
            panel1.Enabled = true;
            panel2.Enabled = true;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
        }

        private void toolStripTextBox7_Click(object sender, EventArgs e)
        {
            label1.Text = "品名：";
            label5.Text = "總價：";
            label1.Text = label1.Text + "焦糖瑪奇朵(L)";
            groupBox1.Enabled = true;
            panel4.Enabled = false;
            panel1.Enabled = true;
            panel2.Enabled = true;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
        }

        private void toolStripTextBox8_Click(object sender, EventArgs e)
        {
            label1.Text = "品名：";
            label5.Text = "總價：";
            label1.Text = label1.Text + "摩卡(M)";
            groupBox1.Enabled = true;
            panel4.Enabled = false;
            panel1.Enabled = true;
            panel2.Enabled = true;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
        }

        private void toolStripTextBox9_Click(object sender, EventArgs e)
        {
            label1.Text = "品名：";
            label5.Text = "總價：";
            label1.Text = label1.Text + "摩卡(L)";
            groupBox1.Enabled = true;
            panel4.Enabled = false;
            panel1.Enabled = true;
            panel2.Enabled = true;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
        }

        private void toolStripTextBox10_Click(object sender, EventArgs e)
        {
            label1.Text = "品名：";
            label5.Text = "總價：";
            label1.Text = label1.Text + "卡布奇諾(M)";
            groupBox1.Enabled = true;
            panel4.Enabled = false;
            panel1.Enabled = true;
            panel2.Enabled = true;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
        }

        private void toolStripTextBox11_Click(object sender, EventArgs e)
        {
            label1.Text = "品名：";
            label5.Text = "總價：";
            label1.Text = label1.Text + "卡布奇諾(L)";
            groupBox1.Enabled = true;
            panel4.Enabled = false;
            panel1.Enabled = true;
            panel2.Enabled = true;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            label1.Text = "品名：";
            label5.Text = "總價：";
            label1.Text = label1.Text + "英式紅茶(M)";
            groupBox1.Enabled = true;
            panel4.Enabled = true;
            panel1.Enabled = true;
            panel2.Enabled = true;
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            label1.Text = "品名：";
            label5.Text = "總價：";
            label1.Text = label1.Text + "英式紅茶(L)";
            groupBox1.Enabled = true;
            panel4.Enabled = true;
            panel1.Enabled = true;
            panel2.Enabled = true;
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            label1.Text = "品名：";
            label5.Text = "總價：";
            label1.Text = label1.Text + "伯爵茶(L)";
            groupBox1.Enabled = true;
            panel4.Enabled = true;
            panel1.Enabled = true;
            panel2.Enabled = true;
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            label1.Text = "品名：";
            label5.Text = "總價：";
            label1.Text = label1.Text + "伯爵茶(L)";
            groupBox1.Enabled = true;
            panel4.Enabled = true;
            panel1.Enabled = true;
            panel2.Enabled = true;
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            label1.Text = "品名：";
            label5.Text = "總價：";
            label1.Text = label1.Text + "日式綠茶(M)";
            groupBox1.Enabled = true;
            panel4.Enabled = true;
            panel1.Enabled = true;
            panel2.Enabled = true;
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            label1.Text = "品名：";
            label5.Text = "總價：";
            label1.Text = label1.Text + "日式綠茶(L)";
            groupBox1.Enabled = true;
            panel4.Enabled = true;
            panel1.Enabled = true;
            panel2.Enabled = true;
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            label1.Text = "品名：";
            label5.Text = "總價：";
            label1.Text = label1.Text + "草莓冰沙(L)";
            groupBox1.Enabled = true;
            panel4.Enabled = false;
            panel1.Enabled = false;
            panel2.Enabled = false;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;

        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            label1.Text = "品名：";
            label5.Text = "總價：";
            label1.Text = label1.Text + "巧克力冰沙(L)";
            groupBox1.Enabled = true;
            panel4.Enabled = false;
            panel1.Enabled = false;
            panel2.Enabled = false;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            label1.Text = "品名：";
            label5.Text = "總價：";
            label1.Text = label1.Text + "摩卡冰沙(L)";
            groupBox1.Enabled = true;
            panel4.Enabled = false;
            panel1.Enabled = false;
            panel2.Enabled = false;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RichTextBox tempRtb = new RichTextBox();
            //Controls.AddRange(new Control[] {richTextBox1, listBox1 });
            tempRtb.Text = richTextBox1.Text;
            richTextBox1.Text = "";
            string delItemName = listBox1.SelectedItem.ToString().Split(' ')[0];

            for(int i =0; i< tempRtb.Lines.Count()-1; i ++)
            {
                string tempItemName = tempRtb.Lines[i];
                tempItemName= tempItemName.Substring(3,tempItemName.Length-3).Split('\t')[0];
                if (tempItemName != delItemName)
                {
                    richTextBox1.Text += tempRtb.Lines[i] + '\n';
                }
            }
            if (listBox1.Text != "購物清單：")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = listBox1.Items.Count;
            if (count == 1)
            {
                MessageBox.Show("您尚未選擇任何商品！");
            }
            else
            {
                Form3 f3 = new Form3(listBox1.Items.Cast<object>().ToArray());
                f3.Show();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
                MessageBox.Show("您確定要清空購物清單？","清空清單項目",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                listBox1.Items.Clear();
                listBox1.Items.Add("購物清單：");
                richTextBox1.Text = "";
         }

        private void button5_Click(object sender, EventArgs e)
        {
            int count = listBox1.Items.Count;
            

            if (count == 1)
            {
                MessageBox.Show("尚未選取商品");
            }
            else
            {
                string merchandise = "";
                

                for (int i = 0; i < count; i++)
                {
                    merchandise = merchandise + "\n" + listBox1.Items[i].ToString();
                    
                }
                MessageBox.Show("您購買的商品如下：" + "\n" + merchandise );
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(button6.Text == "顯示商品細項")
            {
                richTextBox1.Visible = true;
                button6.Text = "隱藏商品細項";
            }
            else
            {
                richTextBox1.Visible = false;
                button6.Text = "顯示商品細項";
            }
            
            
        }
    }
}
