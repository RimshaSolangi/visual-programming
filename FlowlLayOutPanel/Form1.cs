using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FlowlLayOutPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DataTable DT = new DataTable();
            DT.Columns.Add("ROLL NUMBER", typeof(Int32));
            DT.Columns.Add("NAME", typeof(string));
            DT.Columns.Add("CLASS", typeof(string));
            DT.Columns.Add("SUBJECT", typeof(string));
            DT.Columns.Add("SECTION", typeof(string));
           DT.Rows.Add(1, "SANA", "MATRIC", "ARTS", "A");
            DT.Rows.Add(2, "ANITA", "MATRIC", "SCIENCE", "A");
            DT.Rows.Add(3, "ZAHRA",  "MATRIC", "SCIRNCE", "B");
            DT.Rows.Add(4, "SOBIA", "MATRIC", "ARTS", "B");
            DT.Rows.Add(5, "ARIBA", "MATRIC", "ARTS", "C");
            DT.Rows.Add(6, "AMNA", "MATRIC", "SCIENCE", "C");
            DT.Rows.Add(7, "TOOBA", "MATRIC", "SCIRNCE", "D");
            DT.Rows.Add(8, "zarmina", "MATRIC", "ARTS", "D");
            listView1.Items.Clear();
            foreach (DataRow row in DT.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = 0;
                item.Text = row["ROLL NUMBER"].ToString();
                item.SubItems.Add(row["NAME"].ToString());
                item.SubItems.Add(row["CLASS"].ToString());
                item.SubItems.Add(row["SUBJECT"].ToString());
                item.SubItems.Add(row["SECTION"].ToString());


                listView1.Items.Add(item);
            }


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                txtrollno.Text = item.Text;
                txtname.Text = item.SubItems[1].Text;
                txtclass.Text = item.SubItems[2].Text;
                txtsubject.Text = item.SubItems[3].Text;
                txtsection.Text = item.SubItems[4].Text;
            }
        }

       
        private void button6_Click(object sender, EventArgs e)
        {
            txtrollno.ReadOnly = false;
            txtname.ReadOnly = false;
            txtclass.ReadOnly = false;
            txtsubject.ReadOnly = false;
            txtsection.ReadOnly = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            ListViewItem item = new ListViewItem();
            item.Text = txtrollno.Text;
            item.SubItems.Add(txtname.Text);
            item.SubItems.Add(txtclass.Text);
            item.SubItems.Add(txtsubject.Text);
            item.SubItems.Add(txtsection.Text);


            listView1.Items.Add(item);
        }
    }
}
