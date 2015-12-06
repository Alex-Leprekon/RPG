using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConsoleApplication1;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Astronomer a1 = new Astronomer(350, 700, 10, 50, 25, 8,1);
        Ninja n1 = new Ninja(300, 400, 3, 100, 20, 15,1);
        Sysadmin s1 = new Sysadmin(250, 500, 5, 20, 40, 10,1);
        Titan t1 = new Titan(500, 300, 15, 30, 15, 5,1);
        Frame f1 = new Frame(300, 400, 10, 25, 30, 8,1);
        Astronomer a2 = new Astronomer(350, 700, 10, 50, 25, 8,2);
        Ninja n2 = new Ninja(300, 400, 3, 100, 20, 15,2);
        Sysadmin s2 = new Sysadmin(250, 500, 5, 20, 40, 10,2);
        Titan t2 = new Titan(500, 300, 15, 30, 15, 5,2);
        Frame f2 = new Frame(300, 400, 10, 25, 30, 8,2);
        List<Character> command1 = new List<Character>();
        List<Character> command2 = new List<Character>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Character c in Controls)
            {
                if (c.Comm == 1)
                    command1.Add(c);
                else
                {
                    if (c.Comm == 2)
                        command2.Add(c);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            foreach (Character c in command2)
            {
                targets.Add(c);
            }
            listBox1.Items.Add(a1.FirstSkill(targets));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(t2);
            listBox1.Items.Add(f1.FirstSkill(targets));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(t2);
            listBox1.Items.Add(t1.FirstSkill(targets));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(t1);
            listBox1.Items.Add(s1.FirstSkill(targets));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(t2);
            listBox1.Items.Add(n1.FirstSkill(targets));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            foreach (Character c in command1)
            {
                targets.Add(c);
            }
            listBox1.Items.Add(a2.FirstSkill(targets));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(t1);
            listBox1.Items.Add(f2.FirstSkill(targets));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(t1);
            listBox1.Items.Add(t2.FirstSkill(targets));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(t2);
            listBox1.Items.Add(s2.FirstSkill(targets));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(t1);
            listBox1.Items.Add(n2.FirstSkill(targets));
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void armlabel1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            hplabel1.Text = Convert.ToString(a1.Hp);
            mplabel1.Text = Convert.ToString(a1.Mp);
            armlabel1.Text = Convert.ToString(a1.Armor);
            hplabel2.Text = Convert.ToString(f1.Hp);
            mplabel2.Text = Convert.ToString(f1.Mp);
            armlabel2.Text = Convert.ToString(f1.Armor);
            hplabel3.Text = Convert.ToString(t1.Hp);
            mplabel3.Text = Convert.ToString(t1.Mp);
            armlabel3.Text = Convert.ToString(t1.Armor);
            hplabel4.Text = Convert.ToString(s1.Hp);
            mplabel4.Text = Convert.ToString(s1.Mp);
            armlabel4.Text = Convert.ToString(s1.Armor);
            hplabel5.Text = Convert.ToString(n1.Hp);
            mplabel5.Text = Convert.ToString(n1.Mp);
            armlabel5.Text = Convert.ToString(n1.Armor);

            hplabel6.Text = Convert.ToString(a2.Hp);
            mplabel6.Text = Convert.ToString(a2.Mp);
            armlabel6.Text = Convert.ToString(a2.Armor);
            hplabel7.Text = Convert.ToString(f2.Hp);
            mplabel7.Text = Convert.ToString(f2.Mp);
            armlabel7.Text = Convert.ToString(f2.Armor);
            hplabel8.Text = Convert.ToString(t2.Hp);
            mplabel8.Text = Convert.ToString(t2.Mp);
            armlabel8.Text = Convert.ToString(t2.Armor);
            hplabel9.Text = Convert.ToString(s2.Hp);
            mplabel9.Text = Convert.ToString(s2.Mp);
            armlabel9.Text = Convert.ToString(s2.Armor);
            hplabel10.Text = Convert.ToString(n2.Hp);
            mplabel10.Text = Convert.ToString(n2.Mp);
            armlabel10.Text = Convert.ToString(n2.Armor);
        }

        private void hplabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
