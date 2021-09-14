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
using Hardness_Revolted;
using static Hardness_Revolted.DlS;

namespace Hardness_Revolted.DEVlog
{
    public partial class DLS : Form
    {
        public DLS()
        {
            InitializeComponent();
        }

        private void DLS_Load(object sender, EventArgs e)
        {

        }

        private void loader_Tick(object sender, EventArgs e)
        {
            label1.Text = "Rntm.hardness :" + Rntm.hardness;
            label2.Text = "Rntm.nums :" + Rntm.nums;
            label3.Text = "Quizz.thhh :" + DlS.Quizz[0];
            label4.Text = "Quizz.isstarted :" + DlS.Quizz[1];
            label5.Text = "Quizz.know :" + DlS.Quizz[2];
            label6.Text = "Quizz.mkow :" + DlS.Quizz[3];
            label7.Text = "Quizz.numbers :" + DlS.Quizz[4];
            label8.Text = "Quizz.maxtime :" + DlS.Quizz[5];
            label9.Text = "Quizz.timleft :" + DlS.Quizz[6];
        }
    }
}
