using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_eles_2__1504
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbSari_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btndDeşiştiir_Click(object sender, EventArgs e)
        {
            if (rbRenk1.Checked)
            {
                this.BackColor = Color.Pink;

            }
            else if (rbRenk2.Checked)
            {
                this.BackColor =Color.Yellow;
            }
            else if (rbRemk3.Checked)
            {
                this.BackColor=Color.Red;
            }
            else if (rbrenki4.Checked)
            {
                this.BackColor = Color.DarkOrange;
            }
       } 
    }
}
