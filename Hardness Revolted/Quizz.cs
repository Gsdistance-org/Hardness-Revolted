using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Hardness_Revolted.Rntm;

namespace Hardness_Revolted
{
    public partial class Quizz : Form
    {
        bool isstarted = false;
        int know = 0;
        int rknow;
        int mknow;
        Random rng = new Random();
        Quetsion[] quizz;
        int timeleft = 5000000;
        int maxtime;
        public Quizz()
        {
            InitializeComponent();
        }

        private void Quizz_Load(object sender, EventArgs e)
        {
            if(hardness == 1)
            {
                label9.Text = "Easy";
                quizz = new Quetsion[5];
                maxtime = 50000;
            }
            if (hardness == 2)
            {
                label9.Text = "Normal";
                quizz = new Quetsion[10];
                maxtime = 80000;
            }
            if (hardness == 3)
            {
                label9.Text = "Medium";
                quizz = new Quetsion[15];
                maxtime = 100000;
            }
            if (hardness == 4)
            {
                label9.Text = "Hard";
                quizz = new Quetsion[20];
                maxtime = 150000;
            }
            if (hardness == 5)
            {
                label9.Text = "Insane";
                quizz = new Quetsion[30];
                maxtime = 100000;
            }
            if (hardness == 6)
            {
                label9.Text = "Expert";
                quizz = new Quetsion[40];
                maxtime = 150000;
            }
            if (hardness == 7)
            {
                label9.Text = "Why?";
                quizz = new Quetsion[9999];
                maxtime = 100000;
            }
            timeleft = maxtime;
        }
        private void tofile()
        {
            int i = 0;
            while(i < quizz.Length)
            {
                string[] write = new string[4];
                write[0] = Convert.ToString(quizz[i].a);
                write[1] = Convert.ToString(quizz[i].b);
                write[2] = Convert.ToString(quizz[i].c);
                write[3] = Convert.ToString(quizz[i].d);
                write[4] = Convert.ToString(quizz[i].op);
                File.AppendAllLines(@".\writtenfile.loaded",write);
            }
        }
        private Quetsion[] gen(Quetsion[] quetsion,int hardness)
        {
            int i = 0;
            while(i < quetsion.Length)
            {
                if (hardness == 1)
                {
                    Quetsion gened;
                    gened.a = rng.Next(1, 99);
                    gened.b = rng.Next(1, 99);
                    gened.c = rng.Next(1, 99);
                    gened.d = rng.Next(1, 99);
                    gened.op = rng.Next(1, 2);
                    quetsion[i] = gened;
                    i++;
                }
                if (hardness == 2)
                {
                    Quetsion gened;
                    gened.a = rng.Next(1, 999);
                    gened.b = rng.Next(1, 999);
                    gened.c = rng.Next(1, 999);
                    gened.d = rng.Next(1, 999);
                    gened.op = rng.Next(1, 4);
                    quetsion[i] = gened;
                    i++;
                }
                if (hardness == 3)
                {
                    Quetsion gened;
                    gened.a = rng.Next(1, 9999);
                    gened.b = rng.Next(1, 9999);
                    gened.c = rng.Next(1, 9999);
                    gened.d = rng.Next(1, 9999);
                    gened.op = rng.Next(1, 4);
                    quetsion[i] = gened;
                    i++;
                }
                if (hardness == 4)
                {
                    Quetsion gened;
                    gened.a = rng.Next(1, 99999);
                    gened.b = rng.Next(1, 99999);
                    gened.c = rng.Next(1, 99999);
                    gened.d = rng.Next(1, 99999);
                    gened.op = rng.Next(1, 4);
                    quetsion[i] = gened;
                    i++;
                }
                if (hardness == 5)
                {
                    Quetsion gened;
                    gened.a = rng.Next(1, 999999);
                    gened.b = rng.Next(1, 999999);
                    gened.c = rng.Next(1, 999999);
                    gened.d = rng.Next(1, 999999);
                    gened.op = rng.Next(1, 4);
                    quetsion[i] = gened;
                    i++;
                }
                if (hardness == 6)
                {
                    Quetsion gened;
                    gened.a = rng.Next(1, 9999999);
                    gened.b = rng.Next(1, 9999999);
                    gened.c = rng.Next(1, 9999999);
                    gened.d = rng.Next(1, 9999999);
                    gened.op = rng.Next(1, 4);
                    quetsion[i] = gened;
                    i++;
                }
                if (hardness == 7)
                {
                    Quetsion gened;
                    gened.a = rng.Next(1, 999999999);
                    gened.b = rng.Next(1, 999999999);
                    gened.c = rng.Next(1, 99999999);
                    gened.d = rng.Next(1, 99999999);
                    gened.op = rng.Next(1, 5);
                    quetsion[i] = gened;
                    i++;
                }
            }
            return quetsion;
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            label7.Text = timeleft / 100 + "/" + maxtime / 100;
            label10.Text = Convert.ToString(rknow);
            label8.Text = know + "/" + mknow;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeleft--;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isstarted)
            {
                isstarted = true;
                timer1.Enabled = true;
                tick.Enabled = true;
                quizz = gen(quizz, hardness);
                label1.Text = Convert.ToString(quizz[0].a);
                label2.Text = Convert.ToString(quizz[0].b);
                label3.Text = Convert.ToString(quizz[0].c);
                label4.Text = Convert.ToString(quizz[0].d);
                mknow = quizz.Length;
                if(quizz[0].op == 1)
                {
                    label5.Text = "+";
                }
                if (quizz[0].op == 2)
                {
                    label5.Text = "-";
                }
                if (quizz[0].op == 3)
                {
                    label5.Text = "*";
                }
                if (quizz[0].op == 4)
                {
                    label5.Text = "/";
                }
                if (quizz[0].op == 5)
                {
                    label5.Text = "%";
                }
            }
            else
            {
                if(know < mknow)
                {
                    label1.Text = Convert.ToString(quizz[know].a);
                    label2.Text = Convert.ToString(quizz[know].b);
                    label3.Text = Convert.ToString(quizz[know].c);
                    label4.Text = Convert.ToString(quizz[know].d);
                    if (quizz[know].op == 1)
                    {
                        label5.Text = "+";
                    }
                    if (quizz[know].op == 2)
                    {
                        label5.Text = "-";
                    }
                    if (quizz[know].op == 3)
                    {
                        label5.Text = "*";
                    }
                    if (quizz[know].op == 4)
                    {
                        label5.Text = "/";
                    }
                    if (quizz[know].op == 5)
                    {
                        label5.Text = "%";
                    }
                    if (quizz[know].op == 1)
                    {
                        if (textBox1.Text == Convert.ToString(quizz[know].a + quizz[know].b + quizz[know].c + quizz[know].d))
                        {
                            MessageBox.Show("Right Answer!");
                            rknow++;
                        }
                        else
                        {
                            MessageBox.Show("Wrong answer!");
                        }
                    }
                    if (quizz[know].op == 2)
                    {
                        if (textBox1.Text == Convert.ToString(quizz[know].a - quizz[know].b - quizz[know].c - quizz[know].d))
                        {
                            MessageBox.Show("Right Answer!");
                            rknow++;
                        }
                        else
                        {
                            MessageBox.Show("Wrong answer!");
                        }
                    }
                    if (quizz[know].op == 3)
                    {
                        if (textBox1.Text == Convert.ToString(quizz[know].a * quizz[know].b * quizz[know].c * quizz[know].d))
                        {
                            MessageBox.Show("Right Answer!");
                            rknow++;
                        }
                        else
                        {
                            MessageBox.Show("Wrong answer!");
                        }
                    }
                    if (quizz[know].op == 4)
                    {
                        if (textBox1.Text == Convert.ToString(quizz[know].a / quizz[know].b / quizz[know].c / quizz[know].d))
                        {
                            MessageBox.Show("Right Answer!");
                            rknow++;
                        }
                        else
                        {
                            MessageBox.Show("Wrong answer!");
                        }
                    }
                    if (quizz[know].op == 5)
                    {
                        if (textBox1.Text == Convert.ToString(quizz[know].a % quizz[know].b % quizz[know].c % quizz[know].d))
                        {
                            MessageBox.Show("Right Answer!");
                            rknow++;
                        }
                        else
                        {
                            MessageBox.Show("Wrong answer!");
                        }
                    }
                    know++;
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Test done\nAnswers:" + rknow + "/" + mknow);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Notepad np = new Notepad();
            np.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tofile();
        }
    }
}
