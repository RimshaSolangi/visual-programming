namespace treeview
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imagelistfolder = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageListfile = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.rdodetails = new System.Windows.Forms.RadioButton();
            this.rdotile = new System.Windows.Forms.RadioButton();
            this.rdolarge = new System.Windows.Forms.RadioButton();
            this.rdosmall = new System.Windows.Forms.RadioButton();
            this.rdolist = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imagelistfolder;
            this.treeView1.Location = new System.Drawing.Point(0, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(312, 609);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // imagelistfolder
            // 
            this.imagelistfolder.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagelistfolder.ImageStream")));
            this.imagelistfolder.TransparentColor = System.Drawing.Color.Transparent;
            this.imagelistfolder.Images.SetKeyName(0, "icons8-folder-16.png");
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(308, 47);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(628, 574);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // imageListfile
            // 
            this.imageListfile.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListfile.ImageStream")));
            this.imageListfile.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListfile.Images.SetKeyName(0, "icons8-file-16.png");
            // 
            // label1
            // 
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(338, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Windows Drive Explorer";
            // 
            // rdodetails
            // 
            this.rdodetails.Checked = true;
            this.rdodetails.Location = new System.Drawing.Point(78, 644);
            this.rdodetails.Name = "rdodetails";
            this.rdodetails.Size = new System.Drawing.Size(84, 24);
            this.rdodetails.TabIndex = 3;
            this.rdodetails.TabStop = true;
            this.rdodetails.Text = "Details";
            this.rdodetails.UseVisualStyleBackColor = true;
            this.rdodetails.CheckedChanged += new System.EventHandler(this.rdolist_CheckedChanged);
            // 
            // rdotile
            // 
            this.rdotile.Location = new System.Drawing.Point(177, 644);
            this.rdotile.Name = "rdotile";
            this.rdotile.Size = new System.Drawing.Size(84, 24);
            this.rdotile.TabIndex = 4;
            this.rdotile.Text = "Tile";
            this.rdotile.UseVisualStyleBackColor = true;
            this.rdotile.CheckedChanged += new System.EventHandler(this.rdolist_CheckedChanged);
            // 
            // rdolarge
            // 
            this.rdolarge.Location = new System.Drawing.Point(515, 644);
            this.rdolarge.Name = "rdolarge";
            this.rdolarge.Size = new System.Drawing.Size(84, 24);
            this.rdolarge.TabIndex = 5;
            this.rdolarge.Text = "Large icon";
            this.rdolarge.UseVisualStyleBackColor = true;
            this.rdolarge.CheckedChanged += new System.EventHandler(this.rdolist_CheckedChanged);
            // 
            // rdosmall
            // 
            this.rdosmall.Location = new System.Drawing.Point(390, 644);
            this.rdosmall.Name = "rdosmall";
            this.rdosmall.Size = new System.Drawing.Size(84, 24);
            this.rdosmall.TabIndex = 6;
            this.rdosmall.Text = "Small icon";
            this.rdosmall.UseVisualStyleBackColor = true;
            this.rdosmall.CheckedChanged += new System.EventHandler(this.rdolist_CheckedChanged);
            // 
            // rdolist
            // 
            this.rdolist.Location = new System.Drawing.Point(267, 644);
            this.rdolist.Name = "rdolist";
            this.rdolist.Size = new System.Drawing.Size(84, 24);
            this.rdolist.TabIndex = 7;
            this.rdolist.Text = "List";
            this.rdolist.UseVisualStyleBackColor = true;
            this.rdolist.CheckedChanged += new System.EventHandler(this.rdolist_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 673);
            this.Controls.Add(this.rdolist);
            this.Controls.Add(this.rdosmall);
            this.Controls.Add(this.rdolarge);
            this.Controls.Add(this.rdotile);
            this.Controls.Add(this.rdodetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imagelistfolder;
        private System.Windows.Forms.ImageList imageListfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdodetails;
        private System.Windows.Forms.RadioButton rdotile;
        private System.Windows.Forms.RadioButton rdolarge;
        private System.Windows.Forms.RadioButton rdosmall;
        private System.Windows.Forms.RadioButton rdolist;
    }
}

