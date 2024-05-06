namespace ListView_Control
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtrollno = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtclass = new System.Windows.Forms.TextBox();
            this.txtsubject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsection = new System.Windows.Forms.TextBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.imagelistlarge = new System.Windows.Forms.ImageList(this.components);
            this.imagelistsmall = new System.Windows.Forms.ImageList(this.components);
            this.rdolarge = new System.Windows.Forms.RadioButton();
            this.rdosmall = new System.Windows.Forms.RadioButton();
            this.rdodetails = new System.Windows.Forms.RadioButton();
            this.rdotile = new System.Windows.Forms.RadioButton();
            this.rdolist = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.HotTracking = true;
            this.listView1.HoverSelection = true;
            this.listView1.LargeImageList = this.imagelistlarge;
            this.listView1.Location = new System.Drawing.Point(3, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(629, 302);
            this.listView1.SmallImageList = this.imagelistsmall;
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ROLL NUMBER";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NAME";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CLASS";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SUBJECT";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SECTION";
            this.columnHeader5.Width = 80;
            // 
            // txtrollno
            // 
            this.txtrollno.Location = new System.Drawing.Point(695, 71);
            this.txtrollno.Name = "txtrollno";
            this.txtrollno.Size = new System.Drawing.Size(137, 20);
            this.txtrollno.TabIndex = 2;
           
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(695, 97);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(137, 20);
            this.txtname.TabIndex = 3;
           
            // 
            // txtclass
            // 
            this.txtclass.Location = new System.Drawing.Point(695, 123);
            this.txtclass.Name = "txtclass";
            this.txtclass.Size = new System.Drawing.Size(137, 20);
            this.txtclass.TabIndex = 4;
        
            // 
            // txtsubject
            // 
            this.txtsubject.Location = new System.Drawing.Point(695, 149);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(137, 20);
            this.txtsubject.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(654, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Roll No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(654, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
         
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(654, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(646, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Subject";
            
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(654, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Section";
         
            // 
            // txtsection
            // 
            this.txtsection.Location = new System.Drawing.Point(695, 175);
            this.txtsection.Name = "txtsection";
            this.txtsection.Size = new System.Drawing.Size(137, 20);
            this.txtsection.TabIndex = 11;
         
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(670, 215);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(71, 37);
            this.btnnew.TabIndex = 12;
            this.btnnew.Text = "NEW";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(770, 215);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(70, 37);
            this.btnsave.TabIndex = 13;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // imagelistlarge
            // 
            this.imagelistlarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagelistlarge.ImageStream")));
            this.imagelistlarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imagelistlarge.Images.SetKeyName(0, "icons8-student-48.png");
            // 
            // imagelistsmall
            // 
            this.imagelistsmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagelistsmall.ImageStream")));
            this.imagelistsmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imagelistsmall.Images.SetKeyName(0, "icons8-student-32.png");
            // 
            // rdolarge
            // 
            this.rdolarge.AutoSize = true;
            this.rdolarge.Location = new System.Drawing.Point(683, 355);
            this.rdolarge.Name = "rdolarge";
            this.rdolarge.Size = new System.Drawing.Size(71, 17);
            this.rdolarge.TabIndex = 14;
            this.rdolarge.Text = "large icon";
            this.rdolarge.UseVisualStyleBackColor = true;
            this.rdolarge.CheckedChanged += new System.EventHandler(this.rdolist_CheckedChanged);
            // 
            // rdosmall
            // 
            this.rdosmall.AutoSize = true;
            this.rdosmall.Location = new System.Drawing.Point(714, 332);
            this.rdosmall.Name = "rdosmall";
            this.rdosmall.Size = new System.Drawing.Size(65, 17);
            this.rdosmall.TabIndex = 15;
            this.rdosmall.Text = "smll icon";
            this.rdosmall.UseVisualStyleBackColor = true;
            this.rdosmall.CheckedChanged += new System.EventHandler(this.rdolist_CheckedChanged);
            // 
            // rdodetails
            // 
            this.rdodetails.AutoSize = true;
            this.rdodetails.Checked = true;
            this.rdodetails.Location = new System.Drawing.Point(713, 309);
            this.rdodetails.Name = "rdodetails";
            this.rdodetails.Size = new System.Drawing.Size(58, 17);
            this.rdodetails.TabIndex = 16;
            this.rdodetails.TabStop = true;
            this.rdodetails.Text = " details";
            this.rdodetails.UseVisualStyleBackColor = true;
            this.rdodetails.CheckedChanged += new System.EventHandler(this.rdolist_CheckedChanged);
            // 
            // rdotile
            // 
            this.rdotile.AutoSize = true;
            this.rdotile.Location = new System.Drawing.Point(670, 332);
            this.rdotile.Name = "rdotile";
            this.rdotile.Size = new System.Drawing.Size(38, 17);
            this.rdotile.TabIndex = 17;
            this.rdotile.Text = "tile";
            this.rdotile.UseVisualStyleBackColor = true;
            this.rdotile.CheckedChanged += new System.EventHandler(this.rdolist_CheckedChanged);
            // 
            // rdolist
            // 
            this.rdolist.AutoSize = true;
            this.rdolist.Location = new System.Drawing.Point(670, 309);
            this.rdolist.Name = "rdolist";
            this.rdolist.Size = new System.Drawing.Size(37, 17);
            this.rdolist.TabIndex = 18;
            this.rdolist.Text = "list";
            this.rdolist.UseVisualStyleBackColor = true;
            this.rdolist.CheckedChanged += new System.EventHandler(this.rdolist_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 619);
            this.Controls.Add(this.rdolist);
            this.Controls.Add(this.rdotile);
            this.Controls.Add(this.rdodetails);
            this.Controls.Add(this.rdosmall);
            this.Controls.Add(this.rdolarge);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.txtsection);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsubject);
            this.Controls.Add(this.txtclass);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtrollno);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtrollno;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtclass;
        private System.Windows.Forms.TextBox txtsubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsection;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.ImageList imagelistlarge;
        private System.Windows.Forms.ImageList imagelistsmall;
        private System.Windows.Forms.RadioButton rdolarge;
        private System.Windows.Forms.RadioButton rdosmall;
        private System.Windows.Forms.RadioButton rdodetails;
        private System.Windows.Forms.RadioButton rdotile;
        private System.Windows.Forms.RadioButton rdolist;
    }
}

