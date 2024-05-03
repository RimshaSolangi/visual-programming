using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDENT_REGSTRATION_FORM
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string province = comoprovince.SelectedItem.ToString();
            comodistrict.Items.Clear();
            if (province == "punjab")
            {
                comodistrict.Items.Add("Lahore");
                comodistrict.Items.Add("Faisalabad");
                comodistrict.Items.Add("Multan");
                comodistrict.Items.Add("Gujranwala");
            }
            else if (province == "Sindh")
            {
                comodistrict.Items.Add("Karachi");
                comodistrict.Items.Add("Hyderabad");
                comodistrict.Items.Add("Sukker");
                comodistrict.Items.Add("Larkana");
            }
            else if (province == "khyber pakhtunkhwan")
            {
                comodistrict.Items.Add("Peshwar");
                comodistrict.Items.Add("Swat");
                comodistrict.Items.Add("Mardan");
                comodistrict.Items.Add("Kohat");

            }
            else if (province == "balochistan")
            {
                comodistrict.Items.Add("Quatta");
                comodistrict.Items.Add("Gwadar");
                comodistrict.Items.Add("Khuzdar");
                comodistrict.Items.Add("Turbat");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string district = comodistrict.SelectedItem.ToString();
            comocity.Items.Clear();
            if (district == "Lahore")
            {
                comocity.Items.Add("lahore");
                comocity.Items.Add("shadara");
                comocity.Items.Add("wagah");
                comocity.Items.Add("kasur");
            }
            if (district == "Faisalabad")
            {
                comocity.Items.Add("faislabad");
                comocity.Items.Add("layallpur");
                comocity.Items.Add("sammundri");
                comocity.Items.Add("tandlianwala");
            }
            if (district == "Multan")
            {
                comocity.Items.Add("multan");
                comocity.Items.Add("khanwala");
                comocity.Items.Add("vehri");
                comocity.Items.Add("muzffarabd");
            }
            if (district =="Gujranwala ")
            {
                comocity.Items.Add("gujranwla");
                comocity.Items.Add("sialkot");
                comocity.Items.Add("gujrat");
                comocity.Items.Add("hafiza abad");
            }
            if (district == "Karachi")
            {
                comocity.Items.Add("karachi");
                comocity.Items.Add("layri");
                comocity.Items.Add("malri");
                comocity.Items.Add("korangi");
            }
            if (district == "Hyderabad")
            {
                comocity.Items.Add("hyderabad");
                comocity.Items.Add("shadara");
                comocity.Items.Add("tand m.khan");
                comocity.Items.Add("matiari");
            }
            if (district == "Sukker")
            {
                comocity.Items.Add("sukker");
                comocity.Items.Add("rohri");
                comocity.Items.Add("pano aqil");
                comocity.Items.Add("ghottki");
            }
            if (district == "Larkana")
            {
                comocity.Items.Add("larkana");
                comocity.Items.Add("ratodero");
                comocity.Items.Add("kandiarn");
                comocity.Items.Add("shikarpur");
            }
            if (district == "Peshware")
            {
                comocity.Items.Add("peshware");
                comocity.Items.Add("charsadda");
                comocity.Items.Add("noweshera");
                comocity.Items.Add("mardan");
            }
            if (district == "Swat")
            {
                comocity.Items.Add("saidu sharif");
                comocity.Items.Add("mingora");
                comocity.Items.Add("kabal");
                comocity.Items.Add("bahrain");
            }
            if (district == "Mardan")
            {
                comocity.Items.Add("mardan");
                comocity.Items.Add("takht bhat");
                comocity.Items.Add("katlang");
                comocity.Items.Add("ghalla dher");
            }
            if (district == "Kohat")
            {
                comocity.Items.Add("kohat");
                comocity.Items.Add("lachi");
                comocity.Items.Add("hangi");
                comocity.Items.Add("thall");
            }
            if (district == "Quetta")
            {
                comocity.Items.Add("quetta");
                comocity.Items.Add("zirat");
                comocity.Items.Add("herni");
                comocity.Items.Add("kuchlak");
            }
            if (district == "Gwadar")
            {
                comocity.Items.Add("gwadare");
                comocity.Items.Add("pasni");
                comocity.Items.Add("jiwani");
                comocity.Items.Add("ormara");
            }
            if (district == "Khuzdar")
            {
                comocity.Items.Add("khuzdar");
                comocity.Items.Add("wadh");
                comocity.Items.Add("bela");
            }
            if (district == "Turbat")
            {
                comocity.Items.Add("turbat");
                comocity.Items.Add("kech");
                comocity.Items.Add("mand");
                comocity.Items.Add("gwadar");
            }
        }


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            double matric = (double)numericUpDownmatric.Value;
            double maxmatric = (double)numericUpDownmaxmatric.Value;
            double inter = (double)numericUpDowninter.Value;
            double maxinter = (double)numericUpDownmaxinter.Value;
            double netpercentage = ((matric / maxmatric) * 50 + (inter / maxinter) * 50);
            label1.Text = netpercentage.ToString(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtdetails.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string student = textbox1.Text;
            string father = textBox4.Text;
            string province = comoprovince.Text;
            string district = comodistrict.Text;
            string city = comocity.Text;
            string gender = "";
            if (rdomale.Checked) gender = " male";
            else if (rdofemale.Checked) gender = "female";
            string activaties = "";
            if (chkhfzqrn.Checked)
                activaties += " hafiz quran/r/n";
            if (chksprtplr.Checked)
                activaties += "sport plyer";
            if (chkart.Checked) activaties += "artist";
            if (chkfrelncr.Checked) activaties += "freelancer";
            string freelancer = "";
            if (rdogrpdes.Checked) freelancer = "graphic desigining";

            else if (rdovded.Checked) freelancer = "vedio editor ";
            else if (rdovcar.Checked) freelancer = "voice over artist ";
            else if (rdosftwr.Checked) freelancer = " software devolper";
            string sportplayer = "";
            if (rdocricket.Checked) sportplayer = "circket";
            else if (rdobadminton.Checked) sportplayer = "badminton";
            else if (rdofootball.Checked) sportplayer = "football";
            else if (rdotabletennis.Checked) sportplayer = "table tennis";
            string matric = numericUpDowninter.Value.ToString();
            string maxmatric = numericUpDownmaxmatric.Value.ToString();
            string inter = numericUpDowninter.Value.ToString();
            string maxinter = numericUpDownmaxinter.Value.ToString();
            string details = "ALL DATA OF STUDENT";
            details += Environment.NewLine;
            details = details + $" student name {student}";
            details += Environment.NewLine;
            details += $" father name {father}";
            details += Environment.NewLine;
            details += $"gender {gender}";
            details += Environment.NewLine;
            details += $" province {province}";
            details += Environment.NewLine;
            details += $" district{district}";
            details = Environment.NewLine;
            details += $"city{city}";
            details += Environment.NewLine;
            details += $" extra criccular activaties{activaties}";
            details += Environment.NewLine;
            details += $"freelancer {freelancer}";
            details += Environment.NewLine;
            details += $"sport player {sportplayer}";
            details += Environment.NewLine;
            details += $" marks: matrics obtained{matric}";
            details += Environment.NewLine;
            details += $"maximmum marks of matriv{maxinter}";
            details += Environment.NewLine;
            details += $"intermediate obtained{inter}";
            details += Environment.NewLine;
            details += $"mximmum intermediate {maxinter}";
            txtdetails.Text = details;
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void numericUpDownmaxinter_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtfathername_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}