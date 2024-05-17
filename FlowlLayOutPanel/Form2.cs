using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowlLayOutPanel
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            panel2.Visible = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnentry_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
           
                panel2.Visible = true;
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
