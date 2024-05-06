using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView_Control
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
            DT.Rows.Add(3, "ZAHRA", "MATRIC", "SCIRNCE", "B");
            DT.Rows.Add(4, "SOBIA", "MATRIC", "ARTS", "B");
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
        //THIS BUTTON PERFORM TO MODIFIED THE LISTVIEW

        private void button1_Click(object sender, EventArgs e)
        {
            txtrollno.ReadOnly = false;
            txtname.ReadOnly = false;
            txtclass.ReadOnly = false;
            txtsubject.ReadOnly = false;
            txtsection.ReadOnly = false;
        }

    
        //THIS BUTTON  PERFRM SAVE ITEMS IN LISTVIEW
        private void button1_Click_2(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = txtrollno.Text;
            item.SubItems.Add(txtname.Text);
            item.SubItems.Add(txtclass.Text);
            item.SubItems.Add(txtsubject.Text);
            item.SubItems.Add(txtsection.Text);


            listView1.Items.Add(item);
        }

        private void rdolist_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdobtn = (RadioButton)sender;
            switch (rdobtn .Name )
            {
                case "rdolarge": listView1.View = View.LargeIcon; break;
                case "rdosmall": listView1.View = View.SmallIcon; break;
                case "rdodetails":listView1.View = View.Details; break;
                case "rdotile": listView1.View = View.Tile;break;
                case "rdolist": listView1.View = View.List;break;

            }
        }
    }
}
