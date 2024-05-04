using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wordpad_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //this button perform bold selected text
        private void button1_Click(object sender, EventArgs e)
        {
            Font font = richTextBox1.SelectionFont;
            font = new Font(font.FontFamily, font.Size, FontStyle.Bold);
            richTextBox1.SelectionFont = font;
        }
        // this button perform open new file
        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog sdf = new SaveFileDialog();
            sdf.Filter = "*.rtf|Rich Text Format";
            sdf.DefaultExt = "rtf";
            if (sdf.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(sdf.FileName, RichTextBoxStreamType.RichText);
                MessageBox.Show("File is saveed");
            }
        }
        //this button perform copy function
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
            MessageBox.Show("copy succssefully");
        }
        //this button perform past function

        private void btnpaste_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
           
        }
        // this button perform font display

        private void button1_Click_1(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog () == DialogResult.OK )
            {
                richTextBox1.SelectionFont = fd.Font;
            }

        }
        //this button perform selcted text delete

        private void btncut_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
        //this button perform chnge colour
        private void button1_Click_2(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog ();
            if(cd.ShowDialog ()== DialogResult.OK )
            {
                richTextBox1.SelectionColor = cd.Color;
            }
        }
        // this button perform open new file
        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Rich Text Formate|*.rtf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Rtf = File.ReadAllText(ofd.FileName);
            } 
        
        }
        //this button perform undo operation
        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }
        //this button perform exit opretion
        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
