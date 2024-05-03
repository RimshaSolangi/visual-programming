namespace STUDENT_REGSTRATION_FORM
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comocity = new System.Windows.Forms.ComboBox();
            this.comoprovince = new System.Windows.Forms.ComboBox();
            this.comodistrict = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.rdomale = new System.Windows.Forms.RadioButton();
            this.rdofemale = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkfrelncr = new System.Windows.Forms.CheckBox();
            this.chksprtplr = new System.Windows.Forms.CheckBox();
            this.chkart = new System.Windows.Forms.CheckBox();
            this.chkhfzqrn = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdovded = new System.Windows.Forms.RadioButton();
            this.rdovcar = new System.Windows.Forms.RadioButton();
            this.rdosftwr = new System.Windows.Forms.RadioButton();
            this.rdogrpdes = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdotabletennis = new System.Windows.Forms.RadioButton();
            this.rdobadminton = new System.Windows.Forms.RadioButton();
            this.rdofootball = new System.Windows.Forms.RadioButton();
            this.rdocricket = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.numericUpDownmaxinter = new System.Windows.Forms.NumericUpDown();
            this.numericUpDowninter = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownmaxmatric = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownmatric = new System.Windows.Forms.NumericUpDown();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.txtdetails = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownmaxinter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowninter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownmaxmatric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownmatric)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.comocity);
            this.groupBox1.Controls.Add(this.comoprovince);
            this.groupBox1.Controls.Add(this.comodistrict);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.rdomale);
            this.groupBox1.Controls.Add(this.rdofemale);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.textbox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PERSONAL INFORMATON";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comocity
            // 
            this.comocity.FormattingEnabled = true;
            this.comocity.Location = new System.Drawing.Point(108, 183);
            this.comocity.Name = "comocity";
            this.comocity.Size = new System.Drawing.Size(264, 27);
            this.comocity.TabIndex = 11;
            this.comocity.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comoprovince
            // 
            this.comoprovince.ForeColor = System.Drawing.Color.Yellow;
            this.comoprovince.FormattingEnabled = true;
            this.comoprovince.Items.AddRange(new object[] {
            "punjab",
            "Sindh",
            "Khyber pakhtunkwan",
            "balochistan"});
            this.comoprovince.Location = new System.Drawing.Point(108, 120);
            this.comoprovince.Name = "comoprovince";
            this.comoprovince.Size = new System.Drawing.Size(264, 27);
            this.comoprovince.TabIndex = 10;
            this.comoprovince.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comodistrict
            // 
            this.comodistrict.FormattingEnabled = true;
            this.comodistrict.Location = new System.Drawing.Point(108, 151);
            this.comodistrict.Name = "comodistrict";
            this.comodistrict.Size = new System.Drawing.Size(264, 27);
            this.comodistrict.TabIndex = 9;
            this.comodistrict.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(6, 184);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 26);
            this.button6.TabIndex = 8;
            this.button6.Text = "City";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(6, 152);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 26);
            this.button5.TabIndex = 7;
            this.button5.Text = "District";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(6, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 26);
            this.button4.TabIndex = 6;
            this.button4.Text = "Province";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // rdomale
            // 
            this.rdomale.AutoSize = true;
            this.rdomale.Location = new System.Drawing.Point(229, 91);
            this.rdomale.Name = "rdomale";
            this.rdomale.Size = new System.Drawing.Size(60, 23);
            this.rdomale.TabIndex = 5;
            this.rdomale.TabStop = true;
            this.rdomale.Text = "male";
            this.rdomale.UseVisualStyleBackColor = true;
            this.rdomale.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdofemale
            // 
            this.rdofemale.AutoSize = true;
            this.rdofemale.Location = new System.Drawing.Point(108, 88);
            this.rdofemale.Name = "rdofemale";
            this.rdofemale.Size = new System.Drawing.Size(73, 23);
            this.rdofemale.TabIndex = 4;
            this.rdofemale.TabStop = true;
            this.rdofemale.Text = "female";
            this.rdofemale.UseVisualStyleBackColor = true;
            this.rdofemale.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button3
            // 
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(6, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 26);
            this.button3.TabIndex = 3;
            this.button3.Text = "Gender";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(108, 25);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(264, 25);
            this.textbox1.TabIndex = 1;
            this.textbox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Student Name";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(18, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 26);
            this.button2.TabIndex = 2;
            this.button2.Text = "Father Name";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkfrelncr);
            this.groupBox2.Controls.Add(this.chksprtplr);
            this.groupBox2.Controls.Add(this.chkart);
            this.groupBox2.Controls.Add(this.chkhfzqrn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(26, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 103);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EXTRA CIRRICULAR ACTIVATIES";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter_1);
            // 
            // chkfrelncr
            // 
            this.chkfrelncr.AutoSize = true;
            this.chkfrelncr.Location = new System.Drawing.Point(173, 72);
            this.chkfrelncr.Name = "chkfrelncr";
            this.chkfrelncr.Size = new System.Drawing.Size(106, 23);
            this.chkfrelncr.TabIndex = 3;
            this.chkfrelncr.Text = "Freelanceer";
            this.chkfrelncr.UseVisualStyleBackColor = true;
            // 
            // chksprtplr
            // 
            this.chksprtplr.AutoSize = true;
            this.chksprtplr.Location = new System.Drawing.Point(6, 72);
            this.chksprtplr.Name = "chksprtplr";
            this.chksprtplr.Size = new System.Drawing.Size(111, 23);
            this.chksprtplr.TabIndex = 2;
            this.chksprtplr.Text = "Sport Player";
            this.chksprtplr.UseVisualStyleBackColor = true;
            // 
            // chkart
            // 
            this.chkart.AutoSize = true;
            this.chkart.Location = new System.Drawing.Point(173, 34);
            this.chkart.Name = "chkart";
            this.chkart.Size = new System.Drawing.Size(64, 23);
            this.chkart.TabIndex = 1;
            this.chkart.Text = "Artist";
            this.chkart.UseVisualStyleBackColor = true;
            // 
            // chkhfzqrn
            // 
            this.chkhfzqrn.AutoSize = true;
            this.chkhfzqrn.Location = new System.Drawing.Point(6, 34);
            this.chkhfzqrn.Name = "chkhfzqrn";
            this.chkhfzqrn.Size = new System.Drawing.Size(116, 23);
            this.chkhfzqrn.TabIndex = 0;
            this.chkhfzqrn.Text = "Hafiza Quran";
            this.chkhfzqrn.UseVisualStyleBackColor = true;
            this.chkhfzqrn.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdovded);
            this.groupBox3.Controls.Add(this.rdovcar);
            this.groupBox3.Controls.Add(this.rdosftwr);
            this.groupBox3.Controls.Add(this.rdogrpdes);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(18, 441);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(366, 82);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Freelancer";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // rdovded
            // 
            this.rdovded.AutoSize = true;
            this.rdovded.Location = new System.Drawing.Point(191, 53);
            this.rdovded.Name = "rdovded";
            this.rdovded.Size = new System.Drawing.Size(110, 23);
            this.rdovded.TabIndex = 9;
            this.rdovded.TabStop = true;
            this.rdovded.Text = "Vedio Editor";
            this.rdovded.UseVisualStyleBackColor = true;
            this.rdovded.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rdovcar
            // 
            this.rdovcar.AutoSize = true;
            this.rdovcar.Location = new System.Drawing.Point(6, 44);
            this.rdovcar.Name = "rdovcar";
            this.rdovcar.Size = new System.Drawing.Size(139, 23);
            this.rdovcar.TabIndex = 8;
            this.rdovcar.TabStop = true;
            this.rdovcar.Text = "Voice over Artist";
            this.rdovcar.UseVisualStyleBackColor = true;
            this.rdovcar.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdosftwr
            // 
            this.rdosftwr.AutoSize = true;
            this.rdosftwr.Location = new System.Drawing.Point(191, 24);
            this.rdosftwr.Name = "rdosftwr";
            this.rdosftwr.Size = new System.Drawing.Size(161, 23);
            this.rdosftwr.TabIndex = 7;
            this.rdosftwr.TabStop = true;
            this.rdosftwr.Text = "Software Developer";
            this.rdosftwr.UseVisualStyleBackColor = true;
            this.rdosftwr.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // rdogrpdes
            // 
            this.rdogrpdes.AutoSize = true;
            this.rdogrpdes.Location = new System.Drawing.Point(6, 24);
            this.rdogrpdes.Name = "rdogrpdes";
            this.rdogrpdes.Size = new System.Drawing.Size(142, 23);
            this.rdogrpdes.TabIndex = 6;
            this.rdogrpdes.TabStop = true;
            this.rdogrpdes.Text = "Graphic Designer";
            this.rdogrpdes.UseVisualStyleBackColor = true;
            this.rdogrpdes.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdotabletennis);
            this.groupBox4.Controls.Add(this.rdobadminton);
            this.groupBox4.Controls.Add(this.rdofootball);
            this.groupBox4.Controls.Add(this.rdocricket);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(18, 550);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(360, 100);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sport Player";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // rdotabletennis
            // 
            this.rdotabletennis.AutoSize = true;
            this.rdotabletennis.Location = new System.Drawing.Point(167, 53);
            this.rdotabletennis.Name = "rdotabletennis";
            this.rdotabletennis.Size = new System.Drawing.Size(110, 23);
            this.rdotabletennis.TabIndex = 9;
            this.rdotabletennis.TabStop = true;
            this.rdotabletennis.Text = "Tabel Tennis";
            this.rdotabletennis.UseVisualStyleBackColor = true;
            // 
            // rdobadminton
            // 
            this.rdobadminton.AutoSize = true;
            this.rdobadminton.Location = new System.Drawing.Point(6, 53);
            this.rdobadminton.Name = "rdobadminton";
            this.rdobadminton.Size = new System.Drawing.Size(100, 23);
            this.rdobadminton.TabIndex = 8;
            this.rdobadminton.TabStop = true;
            this.rdobadminton.Text = "Badminton";
            this.rdobadminton.UseVisualStyleBackColor = true;
            this.rdobadminton.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // rdofootball
            // 
            this.rdofootball.AutoSize = true;
            this.rdofootball.Location = new System.Drawing.Point(171, 24);
            this.rdofootball.Name = "rdofootball";
            this.rdofootball.Size = new System.Drawing.Size(82, 23);
            this.rdofootball.TabIndex = 7;
            this.rdofootball.TabStop = true;
            this.rdofootball.Text = "Football";
            this.rdofootball.UseVisualStyleBackColor = true;
            this.rdofootball.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // rdocricket
            // 
            this.rdocricket.AutoSize = true;
            this.rdocricket.Location = new System.Drawing.Point(6, 24);
            this.rdocricket.Name = "rdocricket";
            this.rdocricket.Size = new System.Drawing.Size(74, 23);
            this.rdocricket.TabIndex = 6;
            this.rdocricket.TabStop = true;
            this.rdocricket.Text = "Cricket";
            this.rdocricket.UseVisualStyleBackColor = true;
            this.rdocricket.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numericUpDownmaxinter);
            this.groupBox5.Controls.Add(this.numericUpDowninter);
            this.groupBox5.Controls.Add(this.numericUpDownmaxmatric);
            this.groupBox5.Controls.Add(this.numericUpDownmatric);
            this.groupBox5.Controls.Add(this.button10);
            this.groupBox5.Controls.Add(this.button9);
            this.groupBox5.Controls.Add(this.button8);
            this.groupBox5.Controls.Add(this.button7);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(423, 37);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(368, 162);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "MARKS";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // numericUpDownmaxinter
            // 
            this.numericUpDownmaxinter.Location = new System.Drawing.Point(173, 119);
            this.numericUpDownmaxinter.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.numericUpDownmaxinter.Name = "numericUpDownmaxinter";
            this.numericUpDownmaxinter.Size = new System.Drawing.Size(120, 25);
            this.numericUpDownmaxinter.TabIndex = 16;
            this.numericUpDownmaxinter.ValueChanged += new System.EventHandler(this.numericUpDownmaxinter_ValueChanged);
            // 
            // numericUpDowninter
            // 
            this.numericUpDowninter.Location = new System.Drawing.Point(173, 88);
            this.numericUpDowninter.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.numericUpDowninter.Name = "numericUpDowninter";
            this.numericUpDowninter.Size = new System.Drawing.Size(120, 25);
            this.numericUpDowninter.TabIndex = 15;
            this.numericUpDowninter.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numericUpDownmaxmatric
            // 
            this.numericUpDownmaxmatric.Location = new System.Drawing.Point(173, 57);
            this.numericUpDownmaxmatric.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.numericUpDownmaxmatric.Name = "numericUpDownmaxmatric";
            this.numericUpDownmaxmatric.Size = new System.Drawing.Size(120, 25);
            this.numericUpDownmaxmatric.TabIndex = 14;
            this.numericUpDownmaxmatric.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDownmatric
            // 
            this.numericUpDownmatric.Location = new System.Drawing.Point(173, 26);
            this.numericUpDownmatric.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.numericUpDownmatric.Name = "numericUpDownmatric";
            this.numericUpDownmatric.Size = new System.Drawing.Size(120, 25);
            this.numericUpDownmatric.TabIndex = 13;
            this.numericUpDownmatric.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button10
            // 
            this.button10.AutoSize = true;
            this.button10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button10.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(6, 120);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(150, 26);
            this.button10.TabIndex = 12;
            this.button10.Text = "maximmum intermediat";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.AutoSize = true;
            this.button9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button9.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(6, 88);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(132, 26);
            this.button9.TabIndex = 11;
            this.button9.Text = "intermediat obtained";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button8.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(6, 56);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(122, 26);
            this.button8.TabIndex = 10;
            this.button8.Text = "maximmum matric";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button7.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(6, 24);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(104, 26);
            this.button7.TabIndex = 9;
            this.button7.Text = "matric obtained";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button11
            // 
            this.button11.AutoSize = true;
            this.button11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button11.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(423, 218);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(95, 26);
            this.button11.TabIndex = 10;
            this.button11.Text = "Net Prcentage";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(426, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 68);
            this.label1.TabIndex = 11;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnreset
            // 
            this.btnreset.AutoSize = true;
            this.btnreset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnreset.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(429, 327);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(51, 26);
            this.btnreset.TabIndex = 12;
            this.btnreset.Text = "RESET";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnsave
            // 
            this.btnsave.AutoSize = true;
            this.btnsave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnsave.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(533, 327);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(46, 26);
            this.btnsave.TabIndex = 13;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.AutoSize = true;
            this.button14.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button14.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(429, 369);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(52, 26);
            this.button14.TabIndex = 14;
            this.button14.Text = "details";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // txtdetails
            // 
            this.txtdetails.Location = new System.Drawing.Point(390, 412);
            this.txtdetails.Multiline = true;
            this.txtdetails.Name = "txtdetails";
            this.txtdetails.Size = new System.Drawing.Size(357, 264);
            this.txtdetails.TabIndex = 15;
            this.txtdetails.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(108, 60);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(264, 25);
            this.textBox4.TabIndex = 12;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox2_TextChanged_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 698);
            this.Controls.Add(this.txtdetails);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownmaxinter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowninter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownmaxmatric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownmatric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton rdofemale;
        private System.Windows.Forms.RadioButton rdomale;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comoprovince;
        private System.Windows.Forms.ComboBox comodistrict;
        private System.Windows.Forms.ComboBox comocity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkhfzqrn;
        private System.Windows.Forms.CheckBox chkfrelncr;
        private System.Windows.Forms.CheckBox chksprtplr;
        private System.Windows.Forms.CheckBox chkart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdovded;
        private System.Windows.Forms.RadioButton rdovcar;
        private System.Windows.Forms.RadioButton rdosftwr;
        private System.Windows.Forms.RadioButton rdogrpdes;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdofootball;
        private System.Windows.Forms.RadioButton rdocricket;
        private System.Windows.Forms.RadioButton rdobadminton;
        private System.Windows.Forms.RadioButton rdotabletennis;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.NumericUpDown numericUpDownmaxinter;
        private System.Windows.Forms.NumericUpDown numericUpDowninter;
        private System.Windows.Forms.NumericUpDown numericUpDownmaxmatric;
        private System.Windows.Forms.NumericUpDown numericUpDownmatric;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox txtdetails;
        private System.Windows.Forms.TextBox textBox4;
    }
}

