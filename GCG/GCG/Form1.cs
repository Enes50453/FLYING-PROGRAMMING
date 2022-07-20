using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "1";
            textBox2.Text = "1";
            textBox3.Text = "1";
            textBox4.Text = "1";
            textBox5.Text = "1";
            textBox6.Text = "1";
            textBox7.Text = "1";
            textBox8.Text = "1";
            textBox9.Text = "1";
            textBox10.Text = "1";
            textBox11.Text = "1";
            textBox12.Text = "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tx1 = Convert.ToDouble(textBox1.Text);
            double ty1 = Convert.ToDouble(textBox2.Text);
            double tz1 = Convert.ToDouble(textBox3.Text);
            double tx2 = Convert.ToDouble(textBox4.Text);
            double ty2 = Convert.ToDouble(textBox5.Text);
            double tz2 = Convert.ToDouble(textBox6.Text);
            double tx3 = Convert.ToDouble(textBox7.Text);
            double ty3 = Convert.ToDouble(textBox8.Text);
            double tz3 = Convert.ToDouble(textBox9.Text);
            double tx4 = Convert.ToDouble(textBox10.Text);
            double ty4 = Convert.ToDouble(textBox11.Text);
            double tz4 = Convert.ToDouble(textBox12.Text);
            Form2 frm2 = new Form2();
            frm2.Show();
            frm2.textBox1.Text = tx1.ToString();
            frm2.textBox2.Text = ty1.ToString();
            frm2.textBox3.Text = tz1.ToString();
            frm2.textBox4.Text = tx2.ToString();
            frm2.textBox5.Text = ty2.ToString();
            frm2.textBox6.Text = tz2.ToString();
            frm2.textBox7.Text = tx3.ToString();
            frm2.textBox8.Text = ty3.ToString();
            frm2.textBox9.Text = tz3.ToString();
            frm2.textBox10.Text = tx4.ToString();
            frm2.textBox11.Text = ty4.ToString();
            frm2.textBox12.Text = tz4.ToString();
            this.Hide();
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //////////this.BackColor = Color.Red;
        }
    }
}
