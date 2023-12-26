using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottory
{
    public partial class Form1 : Form
    {
        public List<string> Nafarat = new List<string>();
        public int i = 0;
        public int res;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtAddName_MouseClick(object sender, MouseEventArgs e)
        {
            txtAddName.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtAddName.Text = "نام شرکت کننده";
            label2.Text = "";
        }

        private void btnSabt_Click(object sender, EventArgs e)
        {
            if(txtAddName.Text != "")
            {
                string Name = txtAddName.Text;
                string Txt = rtxtKol.Text;
                Nafarat.Insert(i, Name);
                foreach (var item in Nafarat)
                {
                    rtxtKol.Text = Txt + "\r\n" + Nafarat[i];
                    label1.Text = "تعداد شرکت کننده ها : " + Nafarat.Count;
                }
                i++;
                txtAddName.Clear();
            }
            else
            {
                MessageBox.Show("لطفا فیلد مربوطه را کامل کنید","خطا", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (button1.Text == "شروع")
                {
                    button1.Text = "انتخاب";
                    btnSabt.Enabled = false;
                    txtAddName.Enabled = false;
                }
                else
                {
                    Random r = new Random();
                    string txtwinners = rtxtwinners.Text;
                    res = r.Next(Nafarat.Count);
                    label2.Text = Nafarat[res];
                    Nafarat.RemoveAt(res);
                    rtxtwinners.Text = txtwinners + "\r\n" + label2.Text;
                }
            }
            catch
            {
                MessageBox.Show("تمامی برندگان این قرعه کشی مشخص شده است", "اتمام قرعه کشی", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnrepeat.Enabled = true;
                btnrepeat.Visible = true;
            }
         

        }

        private void btnrepeat_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/Psycho8247");
        }
    }
}
