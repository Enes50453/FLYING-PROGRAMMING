using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;

namespace GCG
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
                foreach (var seriport in SerialPort.GetPortNames())
                {
                    comboBox1.Items.Add(seriport);
                }
                comboBox1.SelectedIndex = 0;
                disconnectbuton.Enabled = false;
                SPAktar.Enabled = false;
        }

        private void connectbuton_Click(object sender, EventArgs e)
        {
            seriport.PortName = comboBox1.Text;
            seriport.BaudRate = 9600;
            seriport.Parity = Parity.Even;
            seriport.StopBits = StopBits.One;
            seriport.DataBits = 8;
            try
            {
                seriport.Open();
            }
            catch (Exception Hata)
            {
                MessageBox.Show("Serial port connection failed \n Hata:" + Hata.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (seriport.IsOpen)
            {
                connectbuton.Enabled = false;
                disconnectbuton.Enabled = true;
                SPAktar.Enabled = true;
            }
        }

        private void disconnectbuton_Click(object sender, EventArgs e)
        {
            if (seriport.IsOpen)
            {
                seriport.Close();
                connectbuton.Enabled = true;
                disconnectbuton.Enabled = false;
                SPAktar.Enabled = false;
            }
        }
        /// <summary>
        /// 
        
        Form4 frm4 = new Form4();
        //FORM4 TEXT1
        public delegate void verigoster1(String s1);
        public void textboxyaz1(String s1)
        {
            frm4.textBox1.Text += s1;
            
        }
        //FORM4 TEXT2
        public delegate void verigoster2(String s2);
        public void textboxyaz2(String s2)
        {
            frm4.textBox2.Text += s2;
        }
        //FORM4 TEXT3
        public delegate void verigoster3(String s3);
        public void textboxyaz3(String s3)
        {
            frm4.textBox3.Text += s3;
        }
        //FORM4 TEXT4
        public delegate void verigoster4(String s4);
        public void textboxyaz4(String s4)
        {
            frm4.textBox4.Text += s4;
        }
        /// </summary>


        int x = 1;
        private void SPAktar_Click(object sender, EventArgs e)
        {
            ///////     
            ///
            /// 
            //////////////////
            
                frm4.Show();
            
            
           
            
            ////FORM3 TEXT1
            //while (x == 1)
            //{
            //    button1_Click_1(SPAktar, new EventArgs());
            //}
            ////FORM3 TEXT2
            //while (x == 2)
            //{
            //    button2_Click_1(SPAktar, new EventArgs());
            //}
            ////FORM3 TEXT3
            //while (x == 3)
            //{
            //    button3_Click_1(SPAktar, new EventArgs());
            //}
            ////FORM3 TEXT4
            //while (x == 4)
            //{
            //    button4_Click_1(SPAktar, new EventArgs());

            //}

        }
        
        private void seriport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //FORM4 TEXT1
            
            if (x == 1)
            {
                string gelenveri1 = seriport.ReadExisting();
                frm4.textBox1.Invoke(new verigoster1(textboxyaz1), gelenveri1);
                // SPAktar_Click(SPAktar, new EventArgs());
            }
            //FORM4 TEXT2
            else if (x == 2)
            {
                string gelenveri2 = seriport.ReadExisting();
                frm4.textBox2.Invoke(new verigoster2(textboxyaz2), gelenveri2);
                //SPAktar_Click(SPAktar, new EventArgs());
            }
            //FORM4 TEXT3
            else if (x == 3)
            {
                string gelenveri3 = seriport.ReadExisting();
                frm4.textBox3.Invoke(new verigoster3(textboxyaz3), gelenveri3);
                //SPAktar_Click(SPAktar, new EventArgs());
            }
            //FORM4 TEXT4
            else if (x == 4)
            {
                string gelenveri4 = seriport.ReadExisting();
                frm4.textBox4.Invoke(new verigoster4(textboxyaz4), gelenveri4);
                ///SPAktar_Click(SPAktar, new EventArgs());
            }
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (var seriport in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(seriport);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            x = 1;
            seriport.Write(textBox1.Text);
            button1.BackColor = Color.Green;
            button1.Enabled = false;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            x = 2;
            seriport.Write(textBox2.Text);
            button2.BackColor = Color.Green;
            button2.Enabled = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            x = 3;
            seriport.Write(textBox3.Text);
            button3.BackColor = Color.Green;
            button3.Enabled = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            x = 4;
            seriport.Write(textBox4.Text);
            button4.BackColor = Color.Green;
            button4.Enabled = false;
        }
        Form1 frm1 = new Form1();
        private void button6_Click(object sender, EventArgs e)
        {
            
            seriport.Close();
            frm4.Hide();
            frm1.Show();
            this.Hide();

        }
    }
}
