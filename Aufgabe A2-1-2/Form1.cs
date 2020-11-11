using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_A2_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdEnter_Click(object sender, EventArgs e)
        {
            lblResult.Text = txtFirstname.Text + "" + txtLastname.Text + "" + NudAge.Value;
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            txtFirstname.Text = "";
            txtLastname.Text = "";
            lblResult.Text = "";
            NudAge.Value = 0;
        }
    }
}
