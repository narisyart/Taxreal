using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace Taxdeduction
{
    public partial class TaxForm : Form
    {
        
        
        public TaxForm()
        {
            InitializeComponent();
            

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TaxForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = texBoxsalary.Text;
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            if((texBoxsalary.Text.Trim() == "") || (textBoxbonus.Text.Trim() == ""))
            {
                MessageBox.Show("Empty Fields", "Tax", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int salary = int.Parse(texBoxsalary.Text);
                int bonus = int.Parse(textBoxbonus.Text);
                int sum = (salary * 12) + bonus;
                int count = (sum * 50) / 100;
                int fifty = 100000;
                if (count > fifty)
                {
                    count = fifty;
                }
                int allsum = sum - count;
                textBoxSum.Text = allsum.ToString();
            }
    }
               
        public void NoString(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox12.Text.Trim() == "") )
            {
                MessageBox.Show("ERROR", "Tax", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else { 
            int xi = int.Parse(textBox14.Text);
            double final;
            if (int.Parse(textBox14.Text) < 150000)
            {
                final = xi * 0;
                textBox3.Text = final.ToString();
            }
            else if (int.Parse(textBox14.Text) < 300000)
            {
                final = xi * 0.05;
                textBox3.Text = final.ToString();
            }
            else if (int.Parse(textBox14.Text) < 500000)
            {
                final = xi * 0.1;
                textBox3.Text = final.ToString();
            }
            else if (int.Parse(textBox14.Text) < 750000)
            {
                final = xi * 0.15;
                textBox3.Text = final.ToString();
            }
            else if (int.Parse(textBox14.Text) < 1000000)
            {
                final = xi * 0.2;
                textBox3.Text = final.ToString();
            }
            else if (int.Parse(textBox14.Text) < 2000000)
            {
                final = xi * 0.25;
                textBox3.Text = final.ToString();
            }
            else if (int.Parse(textBox14.Text) < 5000000)
            {
                final = xi * 0.3;
                textBox3.Text = final.ToString();
            }
            else if (int.Parse(textBox14.Text) > 5000001)
            {
                final = xi * 0.35;
                textBox3.Text = final.ToString();
            }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((textBoxSum.Text.Trim() == ""))
            {
                MessageBox.Show("ERROR", "Tax", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
            /// หมวด 1 /// 
            int all1 = int.Parse(textBoxSum.Text);
            int auto = 60000;
            int status = 0;
            int butsum = 0;
            int sum1 = 0;
            int butnew = int.Parse(numericUpDownButNew.Text);
            int but = int.Parse(numericUpDownBut.Text);
            int womb = int.Parse(numericUpDown1.Text);
            int parent = 0;
            int cripple = int.Parse(numericUpDown6.Text);
            if (radioButton1.Checked)
            {
                    status = 0;
            }
            else if (radioButton2.Checked)
            {
                    status = 0;
            }
            else if (radioButton3.Checked)
            {
                    status = 60000;
            }
            
            butsum = (butnew * 60000) + (but*30000);
            if (radioButton10.Checked)
            {
                parent = parent + 30000;
            }
            if (radioButton12.Checked)
            {
                parent = parent + 30000;
            }
            if (radioButton14.Checked)
            {
                parent = parent + 30000;
            }
            if (radioButton16.Checked)
            {
                parent = parent + 30000;
            }
            cripple = cripple * 60000;
            {
                sum1 = auto + status + butsum + parent + womb + cripple;


            }
            /// จบหมวด 1 ///
            textBox4.Text = sum1.ToString();
            all1 = all1 - sum1;
            textBox8.Text = all1.ToString();
            }
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((textBox8.Text.Trim() == ""))
            {
                MessageBox.Show("ERROR", "Tax", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else { 
                //หมวด2//
                int all2 = int.Parse(textBox8.Text);
            int socail = int.Parse(numericUpDown8.Text);
            int live = int.Parse(numericUpDown7.Text);
            int health = int.Parse(numericUpDown4.Text);
            int pparent = int.Parse(numericUpDown5.Text);
            int slive = int.Parse(numericUpDown3.Text);
            int lhsum= 0;
            int marry = 0;
            int sum2 = 0;
            if (radioButton18.Checked)
            {
                marry = 10000;
            }
            else if (radioButton2.Checked)
            {
                marry = 0;
            }
            if ((live + health) > 100000)
            {
                lhsum = 100000;
            }
            else if ((live + health) < 100000)
            {
                lhsum = live + health;
            }
            sum2 = socail + lhsum + pparent + slive+ marry;

            textBox5.Text = sum2.ToString();
            all2 = all2 - sum2;
            textBox9.Text = all2.ToString();
            }
            //หมวด2//
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //หมวด3//
            if ((textBox9.Text.Trim() == ""))
            {
                MessageBox.Show("ERROR", "Tax", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else { 
                int all3 = int.Parse(textBox9.Text);
            int house1 = int.Parse(numericUpDown9.Text);
            int house01 = int.Parse(numericUpDown11.Text);
            int house001 = 0;
            int house02 = int.Parse(numericUpDown10.Text);
            int sum3 = 0;
            

            if (radioButton21.Checked)
            {
                house001 = (house01 * 4) / 100;

            }
            else if (radioButton20.Checked)
            {
                if (house02 > 200000)
                {
                    house02 = 200000;
                }

            }
            sum3 = house1 + house001 + house02;
            textBox6.Text = sum3.ToString();
            all3 = all3 - sum3;
            textBox10.Text = all3.ToString();
            }
            //หมวด3//
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            //หมวด4//
            if ((textBox10.Text.Trim() == ""))
            {
                MessageBox.Show("ERROR", "Tax", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else { 
            int all4;
            int alll4 = int.Parse(textBox10.Text);
            int foredu = int.Parse(numericUpDown16.Text);
            int fortuu = int.Parse(numericUpDown15.Text);
            int forsport = int.Parse(numericUpDown14.Text);
            int tester = alll4 * 10 / 100;
            int tester2 = (foredu * 2) + (fortuu * 2) + (forsport * 2);
            int sum4 = 0; 
            if (tester2 > tester)
            {
                tester2 = tester;

            }
            int payu = int.Parse(numericUpDown13.Text);
            int general = int.Parse(numericUpDown12.Text);
            int kanmueng = int.Parse(numericUpDown17.Text);
            int testerreal = (alll4 - tester2) * 10 / 100;
            if (general > testerreal)
            {
                general = testerreal;
            }
            sum4 = tester2 + payu + general+ kanmueng;
            all4 = alll4 - sum4;
            textBox11.Text = sum4.ToString();
            textBox7.Text = all4.ToString();
            }
            //หมวด4//
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //หมวด5//
            if ((textBox7.Text.Trim() == ""))
            {
                MessageBox.Show("ERROR", "Tax", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else { 
                int all5 = int.Parse(textBox7.Text);
            int shop = int.Parse(numericUpDown23.Text);
            int shopedusport = int.Parse(numericUpDown22.Text);
            int shopbook = int.Parse(numericUpDown21.Text);
            int shopotop = int.Parse(numericUpDown20.Text);
            int main = int.Parse(numericUpDown19.Text);
            int second = int.Parse(numericUpDown18.Text);
            int sum5;
            if (main + second > 20000)
            {
                main = 10000;
                second = 10000;
            }
            int phabban = int.Parse(numericUpDown27.Text);
            int phabrod = int.Parse(numericUpDown26.Text);
            int phayu5ban = int.Parse(numericUpDown25.Text);
            int phayu5rod = int.Parse(numericUpDown24.Text);

            sum5 = shop + shopedusport + shopbook + shopotop + main + second + phabban + phabrod + phayu5ban + phayu5rod;
            textBox13.Text = sum5.ToString();
            all5 = all5 - sum5;
            textBox12.Text = all5.ToString();
            textBox1.Text = textBoxSum.Text;
            textBox14.Text = textBox12.Text;            
            int s1 = int.Parse(textBox4.Text);
            int s2 = int.Parse(textBox5.Text);
            int s3 = int.Parse(textBox6.Text);
            int s4 = int.Parse(textBox11.Text);
            int showall = s1 + s2 + s3 + s4 + sum5; 

            textBox2.Text =showall.ToString();
            }//หมวด5//
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;

            }
            else
            {
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton19.Checked)
            {
                groupBox8.Enabled = false;
                groupBox9.Enabled = false;

            }
            else
            {
                groupBox8.Enabled = true;
                groupBox9.Enabled = true;
            }
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton21.Checked)
            {
                groupBox8.Enabled = false;
                groupBox9.Enabled = true;

            }
            else
            {
                groupBox8.Enabled = true;
                groupBox9.Enabled = false;
            }
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton20.Checked)
            {
                groupBox8.Enabled = true;
                groupBox9.Enabled = false;

            }
            else
            {
                groupBox8.Enabled = false;
                groupBox9.Enabled = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://masii.co.th/blog/%E0%B8%A5%E0%B8%94%E0%B8%AB%E0%B8%A2%E0%B9%88%E0%B8%AD%E0%B8%99%E0%B8%A0%E0%B8%B2%E0%B8%A9%E0%B8%B5%E0%B9%80%E0%B8%A1%E0%B8%B7%E0%B8%AD%E0%B8%87%E0%B8%A3%E0%B8%AD%E0%B8%87");
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
