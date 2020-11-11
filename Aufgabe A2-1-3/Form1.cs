using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_A2_1_3
{
    public partial class Form1 : Form
    {
        int value1;
        int value2;
        int result;
        
        public Form1()
        {
            InitializeComponent();
            txtResultat.Enabled = false;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(TxtNumberone.Text);
            value2 = Convert.ToInt32(TxtNumbertwo.Text);

            result = value1 + value2;

            txtResultat.Text = Convert.ToString(result);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(TxtNumberone.Text);
            value2 = Convert.ToInt32(TxtNumbertwo.Text);

            result = value1 - value2;

            txtResultat.Text = Convert.ToString(result);
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(TxtNumberone.Text);
            value2 = Convert.ToInt32(TxtNumbertwo.Text);

            result = value1 * value2;

            txtResultat.Text = Convert.ToString(result);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(TxtNumberone.Text);
            value2 = Convert.ToInt32(TxtNumbertwo.Text);

            result = value1 / value2;

            txtResultat.Text = Convert.ToString(result);
        }
    }
}
