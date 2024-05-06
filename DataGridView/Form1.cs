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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlaod_Click(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT.Columns.Add("ROLL NUMBER", typeof(Int32));
            DT.Columns.Add("NAME", typeof(string));
            DT.Columns.Add("CLASS", typeof(string));
            DT.Columns.Add("SUBJECT", typeof(string));
            DT.Columns.Add("SECTION", typeof(string));
            DT.Rows.Add(1, "SANA", "MATRIC", "ARTS", "A");
            DT.Rows.Add(2, "ANITA", "MATRIC", "SCIENCE", "A");
            DT.Rows.Add(3, "ZAHRA", "MATRIC", "SCIRNCE", "B");
            DT.Rows.Add(4, "SOBIA", "MATRIC", "ARTS", "B");

            dataGridView1.DataSource = DT;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"e:\Netflix dataset.csv";
            string[] lines = File.ReadAllLines(path);
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("col1", "id");
            dataGridView1.Columns.Add("col2", "Type");
            dataGridView1.Columns.Add("col3", "Title");
            dataGridView1.Columns.Add("col4", "Director");
            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                string id = columns[0];
                string type = columns[1];
                string title = columns[2];
                string director = columns[3];
                dataGridView1.Rows.Add(id, type, title, director);
            }


        }
    }
}
