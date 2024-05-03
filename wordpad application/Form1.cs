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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Font font = richTextBox1.SelectionFont;
            font = new Font(font.FontFamily, font.Size, FontStyle.Bold);
            richTextBox1.SelectionFont = font;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog sdf = new SaveFileDialog();
            sdf.Filter = ".rtf Rich Text Format";
            sdf.DefaultExt = "rtf";
            if (sdf.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(sdf.FileName, RichTextBoxStreamType.RichText);
                MessageBox.Show("File is saveed");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
            MessageBox.Show("copy succssefully");
        }

        private void btnpaste_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog () == DialogResult.OK )
            {
                richTextBox1.SelectionFont = fd.Font;
            }

        }

        private void btncut_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog ();
            if(cd.ShowDialog ()== DialogResult.OK )
            {
                richTextBox1.SelectionColor = cd.Color;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Rich Text Formate|.rtf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Rtf = File.ReadAllText(ofd.FileName);
            } 
        
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
