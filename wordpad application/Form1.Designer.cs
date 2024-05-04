namespace wordpad_application
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btnundo = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnfont = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnpaste = new System.Windows.Forms.Button();
            this.btncut = new System.Windows.Forms.Button();
            this.btncopy = new System.Windows.Forms.Button();
            this.btnbold = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 83);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(931, 495);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
         
            // 
            // button5
            // 
            this.button5.Image = global::wordpad_application.Properties.Resources.icons8_exit_32;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(822, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 40);
            this.button5.TabIndex = 11;
            this.button5.Text = "EXIT";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // btnundo
            // 
            this.btnundo.Image = global::wordpad_application.Properties.Resources.icons8_undo_32;
            this.btnundo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnundo.Location = new System.Drawing.Point(741, 12);
            this.btnundo.Name = "btnundo";
            this.btnundo.Size = new System.Drawing.Size(75, 40);
            this.btnundo.TabIndex = 10;
            this.btnundo.Text = "UNDO";
            this.btnundo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnundo.UseMnemonic = false;
            this.btnundo.UseVisualStyleBackColor = true;
            this.btnundo.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = global::wordpad_application.Properties.Resources.icons8_new_32;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(660, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 40);
            this.button3.TabIndex = 9;
            this.button3.Text = "NEW";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::wordpad_application.Properties.Resources.icons8_open_32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(579, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "open";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Image = global::wordpad_application.Properties.Resources.icons8_color_swatch_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(417, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "COLOR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnfont
            // 
            this.btnfont.Image = global::wordpad_application.Properties.Resources.icons8_font_32;
            this.btnfont.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfont.Location = new System.Drawing.Point(336, 12);
            this.btnfont.Name = "btnfont";
            this.btnfont.Size = new System.Drawing.Size(75, 40);
            this.btnfont.TabIndex = 6;
            this.btnfont.Text = "FONT";
            this.btnfont.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnfont.UseVisualStyleBackColor = true;
            this.btnfont.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnsave
            // 
            this.btnsave.Image = global::wordpad_application.Properties.Resources.icons8_save_32;
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(498, 12);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 40);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "SAVE";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnpaste
            // 
            this.btnpaste.Image = global::wordpad_application.Properties.Resources.icons8_paste_32;
            this.btnpaste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpaste.Location = new System.Drawing.Point(255, 12);
            this.btnpaste.Name = "btnpaste";
            this.btnpaste.Size = new System.Drawing.Size(75, 40);
            this.btnpaste.TabIndex = 4;
            this.btnpaste.Text = "PASTE";
            this.btnpaste.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnpaste.UseVisualStyleBackColor = true;
            this.btnpaste.Click += new System.EventHandler(this.btnpaste_Click);
            // 
            // btncut
            // 
            this.btncut.Image = global::wordpad_application.Properties.Resources.icons8_cut_32;
            this.btncut.Location = new System.Drawing.Point(174, 12);
            this.btncut.Name = "btncut";
            this.btncut.Size = new System.Drawing.Size(75, 40);
            this.btncut.TabIndex = 3;
            this.btncut.Text = "CUT";
            this.btncut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncut.UseVisualStyleBackColor = true;
            this.btncut.Click += new System.EventHandler(this.btncut_Click);
            // 
            // btncopy
            // 
            this.btncopy.Image = global::wordpad_application.Properties.Resources.icons8_copy_32;
            this.btncopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncopy.Location = new System.Drawing.Point(93, 12);
            this.btncopy.Name = "btncopy";
            this.btncopy.Size = new System.Drawing.Size(75, 40);
            this.btncopy.TabIndex = 2;
            this.btncopy.Text = "COPY";
            this.btncopy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncopy.UseVisualStyleBackColor = true;
            this.btncopy.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnbold
            // 
            this.btnbold.Image = global::wordpad_application.Properties.Resources.icons8_bold_32;
            this.btnbold.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbold.Location = new System.Drawing.Point(12, 12);
            this.btnbold.Name = "btnbold";
            this.btnbold.Size = new System.Drawing.Size(75, 40);
            this.btnbold.TabIndex = 1;
            this.btnbold.Text = "BOLD";
            this.btnbold.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbold.UseVisualStyleBackColor = true;
            this.btnbold.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 590);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnundo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnfont);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnpaste);
            this.Controls.Add(this.btncut);
            this.Controls.Add(this.btncopy);
            this.Controls.Add(this.btnbold);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnbold;
        private System.Windows.Forms.Button btncopy;
        private System.Windows.Forms.Button btncut;
        private System.Windows.Forms.Button btnpaste;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnfont;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnundo;
        private System.Windows.Forms.Button button5;
    }
}

