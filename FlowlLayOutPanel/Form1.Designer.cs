namespace FlowlLayOutPanel
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
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtrollno = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtclass = new System.Windows.Forms.TextBox();
            this.txtsubject = new System.Windows.Forms.TextBox();
            this.txtsection = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(506, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "DATA OF STUDENT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.HotTracking = true;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(12, 58);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(450, 496);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ROLL NO";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NAME";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "CLASS";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "SUBJECT";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SECTION";
            this.columnHeader3.Width = 146;
            // 
            // txtrollno
            // 
            this.txtrollno.Location = new System.Drawing.Point(596, 157);
            this.txtrollno.Name = "txtrollno";
            this.txtrollno.Size = new System.Drawing.Size(146, 20);
            this.txtrollno.TabIndex = 4;
         
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(596, 192);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(146, 20);
            this.txtname.TabIndex = 5;
        
            // 
            // txtclass
            // 
            this.txtclass.Location = new System.Drawing.Point(596, 228);
            this.txtclass.Name = "txtclass";
            this.txtclass.Size = new System.Drawing.Size(146, 20);
            this.txtclass.TabIndex = 6;
            
            // 
            // txtsubject
            // 
            this.txtsubject.Location = new System.Drawing.Point(596, 270);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(146, 20);
            this.txtsubject.TabIndex = 7;
            // 
            // txtsection
            // 
            this.txtsection.Location = new System.Drawing.Point(596, 308);
            this.txtsection.Name = "txtsection";
            this.txtsection.Size = new System.Drawing.Size(146, 20);
            this.txtsection.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "ROLL NO";
            this.button1.UseVisualStyleBackColor = true;
       
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(494, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "NAME";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(494, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "CLASS";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(494, 267);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "SUBJECT";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(494, 308);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "SECTION";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(504, 362);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(89, 47);
            this.btnclear.TabIndex = 14;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(624, 362);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(89, 47);
            this.btnsave.TabIndex = 15;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 697);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsection);
            this.Controls.Add(this.txtsubject);
            this.Controls.Add(this.txtclass);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtrollno);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtrollno;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtclass;
        private System.Windows.Forms.TextBox txtsubject;
        private System.Windows.Forms.TextBox txtsection;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsave;
    }
}

