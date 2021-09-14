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
            label1.Text = "Rntm.Hardness :" + Rntm.hardness;
            label2.Text = "Rntm.Nums :" + Rntm.nums;
            label3 .Text = "Quizz.thhh :" + Convert.ToString(Quizz.)
        }
    }
}
