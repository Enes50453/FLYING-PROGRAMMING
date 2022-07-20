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

namespace GCG
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        /// <summary>
        /// ////////////////////////INITIAL COORDINATES///////
        /// </summary>
        double x;
        double y;
        double z;
        double x2;
        double y2;
        double z2;
        double x3;
        double y3;
        double z3;
        double x4;
        double y4;
        double z4;
        /// <summary>
        /// /////////////////////////////////////////////////////////////
        /// </summary>
        int c1 = 2;
        int fn1 = 1;
        int c2 = 1;
        int fn2 = 1;
        int c3 = 1;
        int fn3 = 1;
        int c4 = 1;
        int fn4 = 1;
        /// <summary>
        /// //
        /// </summary>
        Form1 frm1 = new Form1();
        
        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /////////////////////////PORB 1 ////////////////////////////////////////////////
            textBox16.Text = "G1 X" + x + " Y" + y + " Z" + z + Environment.NewLine;//prob başlangıç
            double tx = Convert.ToDouble(textBox1.Text);
            double ty = Convert.ToDouble(textBox2.Text);
            double tz = Convert.ToDouble(textBox3.Text);

            //////if (x > tx)
            //////{
            //////    while (x != tx)
            //////    {
            //////        x = x - 1;
            //////        textBox16.Text = textBox16.Text + "G1 X" + x + " Y" + y + " Z" + z + Environment.NewLine;
            //////    }
            //////}
            //////else
            //////{
            //////    while (x != tx)
            //////    {
            //////        x = x + 1;
            //////        textBox16.Text = textBox16.Text + "G1 X" + x + " Y" + y + " Z" + z + Environment.NewLine;
            //////    }
            //////}

            //////if (y > ty)
            //////{
            //////    while (y != ty)
            //////    {
            //////        y = y - 1;
            //////        textBox16.Text = textBox16.Text + "G1 X" + x + " Y" + y + " Z" + z + Environment.NewLine;
            //////    }
            //////}
            //////else
            //////{
            //////    while (y != ty)
            //////    {
            //////        y = y + 1;
            //////        textBox16.Text = textBox16.Text + "G1 X" + x + " Y" + y + " Z" + z + Environment.NewLine;
            //////    }
            //////}

            //////if (z > tz)
            //////{
            //////    while (z != tz)
            //////    {
            //////        z = z - 1;
            //////        textBox16.Text = textBox16.Text + "G1 X" + x + " Y" + y + " Z" + z + Environment.NewLine;
            //////    }
            //////}
            //////else
            //////{
            //////    while (z != tz)
            //////    {
            //////        z = z + 1;
            //////        textBox16.Text = textBox16.Text + "G1 X" + x + " Y" + y + " Z" + z + Environment.NewLine;
            //////    }
            //////}
            textBox16.Text = textBox16.Text + "G1 X" + tx + " Y" + y + " Z" + z + Environment.NewLine;
            x = tx; // Inıtial coordinates has changed
            textBox16.Text = textBox16.Text + "G1 X" + tx + " Y" + ty + " Z" + z + Environment.NewLine;
            y = ty;
            textBox16.Text = textBox16.Text + "G1 X" + tx + " Y" + ty + " Z" + tz + Environment.NewLine;
            z = tz;
            string writeText1 = textBox16.Text;
            ////

            while (c1 > 1)
            {
                if (File.Exists(@"C:\TXTDOSYA\gcoduP1(" + fn1.ToString() + ").txt"))
                {
                    fn1 = fn1 + 1;
                }
                else
                {
                    c1 = 0;
                    try
                    {
                        string fileName1 = @"C:\TXTDOSYA\gcoduP1(" + fn1.ToString() + ").txt";
                        FileStream fs1 = new FileStream(fileName1, FileMode.OpenOrCreate, FileAccess.Write);
                        fs1.Close();

                        File.AppendAllText(fileName1, writeText1);// Environment.NewLine +
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message);
                    }
                }
            }
            
            /////
            {
                {
                    {
                        {
                            {
                                ////////////////////////////////////////////////////////////////
                            }
                        }
                    }
                }
            }


            /////////////////////////PORB 2 ////////////////////////////////////////////////
            textBox15.Text = "G1 X" + x2 + " Y" + y2 + " Z" + z2 + Environment.NewLine;//prob başlangıç
            double tx2 = Convert.ToDouble(textBox4.Text);
            double ty2 = Convert.ToDouble(textBox5.Text);
            double tz2 = Convert.ToDouble(textBox6.Text);

            //////if (x2 > tx2)
            //////{
            //////    while (x2 != tx2)
            //////    {
            //////        x2 = x2 - 1;
            //////        textBox15.Text = textBox15.Text + "G1 X" + x2 + " Y" + y2 + " Z" + z2 + Environment.NewLine;
            //////    }
            //////}
            //////else
            //////{
            //////    while (x2 != tx2)
            //////    {
            //////        x2 = x2 + 1;
            //////        textBox15.Text = textBox15.Text + "G1 X" + x2 + " Y" + y2 + " Z" + z2 + Environment.NewLine;
            //////    }
            //////}

            //////if (y2 > ty2)
            //////{
            //////    while (y2 != ty2)
            //////    {
            //////        y2 = y2 - 1;
            //////        textBox15.Text = textBox15.Text + "G1 X" + x2 + " Y" + y2 + " Z" + z2 + Environment.NewLine;
            //////    }
            //////}
            //////else
            //////{
            //////    while (y2 != ty2)
            //////    {
            //////        y2 = y2 + 1;
            //////        textBox15.Text = textBox15.Text + "G1 X" + x2 + " Y" + y2 + " Z" + z2 + Environment.NewLine;
            //////    }
            //////}

            //////if (z2 > tz2)
            //////{
            //////    while (z2 != tz2)
            //////    {
            //////        z2 = z2 - 1;
            //////        textBox15.Text = textBox15.Text + "G1 X" + x2 + " Y" + y2 + " Z" + z2 + Environment.NewLine;
            //////    }
            //////}
            //////else
            //////{
            //////    while (z2 != tz2)
            //////    {
            //////        z2 = z2 + 1;
            //////        textBox15.Text = textBox15.Text + "G1 X" + x2 + " Y" + y2 + " Z" + z2 + Environment.NewLine;
            //////    }
            //////}
            textBox15.Text = textBox15.Text + "G1 X" + tx2 + " Y" + y2 + " Z" + z2 + Environment.NewLine;
            x2 = tx2;
            textBox15.Text = textBox15.Text + "G1 X" + tx2 + " Y" + ty2 + " Z" + z2 + Environment.NewLine;
            y2 = ty2;
            textBox15.Text = textBox15.Text + "G1 X" + tx2 + " Y" + ty2 + " Z" + tz2 + Environment.NewLine;
            z2 = tz2;
            string writeText2 = textBox15.Text;

            while (c2 == 1)
            {
                if (File.Exists(@"C:\TXTDOSYA\gcoduP2(" + fn2.ToString() + ").txt"))
                {
                    fn2 = fn2 + 1;
                }
                else
                {
                    c2 = 0;
                    try
                    {
                        string fileName2 = @"C:\TXTDOSYA\gcoduP2(" + fn2.ToString() + ").txt";
                        FileStream fs2 = new FileStream(fileName2, FileMode.OpenOrCreate, FileAccess.Write);
                        fs2.Close();

                        File.AppendAllText(fileName2, writeText2);// Environment.NewLine +
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message);
                    }
                }
            }

            /////////////////////////PORB 3 ////////////////////////////////////////////////
            textBox14.Text = "G1 X" + x3 + " Y" + y3 + " Z" + z3 + Environment.NewLine;//prob başlangıç
            double tx3 = Convert.ToDouble(textBox7.Text);
            double ty3 = Convert.ToDouble(textBox8.Text);
            double tz3 = Convert.ToDouble(textBox9.Text);

            //////if (x3 > tx3)
            //////{
            //////    while (x3 != tx3)
            //////    {
            //////        x3 = x3 - 1;
            //////        textBox14.Text = textBox14.Text + "G1 X" + x3 + " Y" + y3 + " Z" + z3 + Environment.NewLine;
            //////    }
            //////}
            //////else
            //////{
            //////    while (x3 != tx3)
            //////    {
            //////        x3 = x3 + 1;
            //////        textBox14.Text = textBox14.Text + "G1 X" + x3 + " Y" + y3 + " Z" + z3 + Environment.NewLine;
            //////    }
            //////}

            //////if (y3 > ty3)
            //////{
            //////    while (y3 != ty3)
            //////    {
            //////        y3 = y3 - 1;
            //////        textBox14.Text = textBox14.Text + "G1 X" + x3 + " Y" + y3 + " Z" + z3 + Environment.NewLine;
            //////    }
            //////}
            //////else
            //////{
            //////    while (y3 != ty3)
            //////    {
            //////        y3 = y3 + 1;
            //////        textBox14.Text = textBox14.Text + "G1 X" + x3 + " Y" + y3 + " Z" + z3 + Environment.NewLine;
            //////    }
            //////}

            //////if (z3 > tz3)
            //////{
            //////    while (z3 != tz3)
            //////    {
            //////        z3 = z3 - 1;
            //////        textBox14.Text = textBox14.Text + "G1 X" + x3 + " Y" + y3 + " Z" + z3 + Environment.NewLine;
            //////    }
            //////}
            //////else
            //////{
            //////    while (z3 != tz3)
            //////    {
            //////        z3 = z3 + 1;
            //////        textBox14.Text = textBox14.Text + "G1 X" + x3 + " Y" + y3 + " Z" + z3 + Environment.NewLine;
            //////    }
            //////}
            textBox14.Text = textBox14.Text + "G1 X" + tx3 + " Y" + y3 + " Z" + z3 + Environment.NewLine;
            x3 = tx3;
            textBox14.Text = textBox14.Text + "G1 X" + tx3 + " Y" + ty3 + " Z" + z3 + Environment.NewLine;
            y3 = ty3;
            textBox14.Text = textBox14.Text + "G1 X" + tx3 + " Y" + ty3 + " Z" + tz3 + Environment.NewLine;
            z3 = tz3;
            string writeText3 = textBox14.Text;

            while (c3 == 1)
            {
                if (File.Exists(@"C:\TXTDOSYA\gcoduP3(" + fn3.ToString() + ").txt"))
                {
                    fn3 = fn3 + 1;
                }
                else
                {
                    c3 = 0;
                    try
                    {
                        string fileName3 = @"C:\TXTDOSYA\gcoduP3(" + fn3.ToString() + ").txt";
                        FileStream fs3 = new FileStream(fileName3, FileMode.OpenOrCreate, FileAccess.Write);
                        fs3.Close();

                        File.AppendAllText(fileName3, writeText3);// Environment.NewLine +
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message);
                    }
                }
            }
            /////////////////////////PORB 4 ////////////////////////////////////////////////
            textBox13.Text = "G1 X" + x4 + " Y" + y4 + " Z" + z4 + Environment.NewLine;//prob başlangıç
            double tx4 = Convert.ToDouble(textBox10.Text);
            double ty4 = Convert.ToDouble(textBox11.Text);
            double tz4 = Convert.ToDouble(textBox12.Text);

            //////if (x4 > tx4)
            //////{
            //////    while (x4 != tx4)
            //////    {
            //////        x4 = x4 - 1;
            //////        textBox13.Text = textBox13.Text + "G1 X" + x4 + " Y" + y4 + " Z" + y4 + Environment.NewLine;
            //////    }
            //////}
            //////else
            //////{
            //////    while (x4 != tx4)
            //////    {
            //////        x4 = x4 + 1;
            //////        textBox13.Text = textBox13.Text + "G1 X" + x4 + " Y" + y4 + " Z" + z4 + Environment.NewLine;
            //////    }
            //////}

            //////if (y4 > ty4)
            //////{
            //////    while (y4 != ty4)
            //////    {
            //////        y4 = y4 - 1;
            //////        textBox13.Text = textBox13.Text + "G1 X" + x4 + " Y" + y4 + " Z" + z4 + Environment.NewLine;
            //////    }
            //////}
            //////else
            //////{
            //////    while (y4 != ty4)
            //////    {
            //////        y4 = y4 + 1;
            //////        textBox13.Text = textBox13.Text + "G1 X" + x4 + " Y" + y4 + " Z" + z4 + Environment.NewLine;
            //////    }
            //////}

            //////if (z4 > tz4)
            //////{
            //////    while (z4 != tz4)
            //////    {
            //////        z4 = z4 - 1;
            //////        textBox13.Text = textBox13.Text + "G1 X" + x4 + " Y" + y4 + " Z" + z4 + Environment.NewLine;
            //////    }
            //////}
            //////else
            //////{
            //////    while (z4 != tz4)
            //////    {
            //////        z4 = z4 + 1;
            //////        textBox13.Text = textBox13.Text + "G1 X" + x4 + " Y" + y4 + " Z" + z4 + Environment.NewLine;
            //////    }
            //////}
            textBox13.Text = textBox13.Text + "G1 X" + tx4 + " Y" + y4 + " Z" + z4 + Environment.NewLine;
            x4 = tx4;
            textBox13.Text = textBox13.Text + "G1 X" + tx4 + " Y" + ty4 + " Z" + z4 + Environment.NewLine;
            y4 = ty4;
            textBox13.Text = textBox13.Text + "G1 X" + tx4 + " Y" + ty4 + " Z" + tz4 + Environment.NewLine;
            z4 = tz4;
            string writeText4 = textBox13.Text;

            while (c4 == 1)
            {
                if (File.Exists(@"C:\TXTDOSYA\gcoduP4(" + fn4.ToString() + ").txt"))
                {
                    fn4 = fn4 + 1;
                }
                else
                {
                    c4 = 0;
                    try
                    {
                        string fileName4 = @"C:\TXTDOSYA\gcoduP4(" + fn4.ToString() + ").txt";
                        FileStream fs4 = new FileStream(fileName4, FileMode.OpenOrCreate, FileAccess.Write);
                        fs4.Close();

                        File.AppendAllText(fileName4, writeText4);// Environment.NewLine +
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //////
            //////Form1 frm1 = new Form1();
            //////frm1.Hide();
            Form3 frm3 = new Form3();
            frm3.Show();
            ///

            //textBox13.Clear();
            //textBox14.Clear();
            //textBox15.Clear();
            //textBox16.Clear();
            try
            {
                if (File.Exists(@"C:\TXTDOSYA\gcoduP1(" + fn1.ToString() + ").txt"))
                {
                    string content1 = File.ReadAllText(@"C:\TXTDOSYA\gcoduP1(" + fn1.ToString() + ").txt", Encoding.UTF8);
                    char[] ch = content1.ToString().ToCharArray();
                    for (int i = 0; i < content1.ToString().Length; i++)
                    {
                        int value = Convert.ToInt32(ch[i]);
                        string hexOutput = String.Format("{0:X2}", value);
                        frm3.textBox1.Text = frm3.textBox1.Text + hexOutput + " ";

                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            try
            {
                if (File.Exists(@"C:\TXTDOSYA\gcoduP2(" + fn2.ToString() + ").txt"))
                {
                    string content2 = File.ReadAllText(@"C:\TXTDOSYA\gcoduP2(" + fn2.ToString() + ").txt", Encoding.UTF8);
                    char[] ch = content2.ToString().ToCharArray();
                    for (int i = 0; i < content2.ToString().Length; i++)
                    {
                        int value = Convert.ToInt32(ch[i]);
                        string hexOutput = String.Format("{0:X2}", value);
                        frm3.textBox2.Text = frm3.textBox2.Text + hexOutput + " ";

                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            try
            {
                if (File.Exists(@"C:\TXTDOSYA\gcoduP3(" + fn3.ToString() + ").txt"))
                {
                    string content3 = File.ReadAllText(@"C:\TXTDOSYA\gcoduP3(" + fn3.ToString() + ").txt", Encoding.UTF8);
                    char[] ch = content3.ToString().ToCharArray();
                    for (int i = 0; i < content3.ToString().Length; i++)
                    {
                        int value = Convert.ToInt32(ch[i]);
                        string hexOutput = String.Format("{0:X2}", value);
                        frm3.textBox3.Text = frm3.textBox3.Text + hexOutput + " ";

                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            try
            {
                if (File.Exists(@"C:\TXTDOSYA\gcoduP4(" + fn4.ToString() + ").txt"))
                {
                    string content4 = File.ReadAllText(@"C:\TXTDOSYA\gcoduP4(" + fn4.ToString() + ").txt", Encoding.UTF8);
                    char[] ch = content4.ToString().ToCharArray();
                    for (int i = 0; i < content4.ToString().Length; i++)
                    {
                        int value = Convert.ToInt32(ch[i]);
                        string hexOutput = String.Format("{0:X2}", value);
                        frm3.textBox4.Text = frm3.textBox4.Text + hexOutput + " ";

                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            this.Hide();
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            x = 0;
            y = 0;
            z = 0;
            x2 = 0;
            y2 = 0;
            z2 = 0;
            x3 = 0;
            y3 = 0;
            z3 = 0;
            x4 = 0;
            y4 = 0;
            z4 = 0;
        }
    }
}
