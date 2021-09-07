using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Hardness_Revolted.Rntm;

namespace Hardness_Revolted
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hardness = 1;
            Quizz qz = new Quizz();
            qz.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hardness = 2;
            Quizz qz = new Quizz();
            qz.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hardness = 3;
            Quizz qz = new Quizz();
            qz.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hardness = 4;
            Quizz qz = new Quizz();
            qz.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hardness = 5;
            Quizz qz = new Quizz();
            qz.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hardness = 6;
            Quizz qz = new Quizz();
            qz.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hardness = 7;
            Quizz qz = new Quizz();
            qz.Show();
        }
    }
}
