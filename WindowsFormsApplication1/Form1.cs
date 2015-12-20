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
        Character attacker;
        public int step = 1;
        public int stepcounter = 0;
        int comm;
        public List<Character> command1 = new List<Character>();
        public List<Character> command2 = new List<Character>();
        List<Character> Paralyzed = new List<Character>();
        List<Character> AllCharacters = new List<Character>();
        public int a1HpDefault;
        public int a2HpDefault;
        public int n1HpDefault;
        public int n2HpDefault;
        public int s1HpDefault;
        public int s2HpDefault;
        public int t1HpDefault;
        public int t2HpDefault;
        public int f1HpDefault;
        public int f2HpDefault;
        List <Character> targets = new List<Character>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            command1.Add(a1);
            command1.Add(n1);
            command1.Add(s1);
            command1.Add(t1);
            command1.Add(f1);
            command2.Add(a2);
            command2.Add(n2);
            command2.Add(s2);
            command2.Add(t2);
            command2.Add(f2);
            progressBar1.Maximum = a1.Hp;
            progressBar2.Maximum = a1.Mp;
            progressBar3.Maximum = f1.Hp;
            progressBar4.Maximum = f1.Mp;
            progressBar5.Maximum = t1.Hp;
            progressBar6.Maximum = t1.Mp;
            progressBar7.Maximum = s1.Hp;
            progressBar8.Maximum = s1.Mp;
            progressBar9.Maximum = n1.Hp;
            progressBar10.Maximum = n1.Mp;
            progressBar11.Maximum = a2.Hp;
            progressBar12.Maximum = a2.Mp;
            progressBar13.Maximum = f2.Hp;
            progressBar14.Maximum = f2.Mp;
            progressBar15.Maximum = t2.Hp;
            progressBar16.Maximum = t2.Mp;
            progressBar17.Maximum = s2.Hp;
            progressBar18.Maximum = s2.Mp;
            progressBar19.Maximum = n2.Hp;
            progressBar20.Maximum = n2.Mp;
            a1HpDefault = a1.Hp;
            a2HpDefault = a2.Hp;
            s1HpDefault = s1.Hp;
            s2HpDefault = s2.Hp;
            t1HpDefault = t1.Hp;
            t2HpDefault = t2.Hp;
            n1HpDefault = n1.Hp;
            n2HpDefault = n2.Hp;
            f1HpDefault = f1.Hp;
            f2HpDefault = f2.Hp;
            foreach (Character c in command1)
            {
                AllCharacters.Add(c);
            }
            foreach (Character c in command2)
            {
                AllCharacters.Add(c);
            }
        }
        public void RefreshStats()
        {
            a1.HpControl();
            a2.HpControl();
            n1.HpControl();
            n2.HpControl();
            s1.HpControl();
            s2.HpControl();
            t1.HpControl();
            t2.HpControl();
            f1.HpControl();
            f2.HpControl();

            progressBar1.Value = a1.Hp;
            progressBar2.Value = a1.Mp;
            armlabel1.Text = Convert.ToString(a1.Armor);
            progressBar3.Value = f1.Hp;
            progressBar4.Value = f1.Mp;
            armlabel2.Text = Convert.ToString(f1.Armor);
            progressBar5.Value = t1.Hp;
            progressBar6.Value = t1.Mp;
            armlabel3.Text = Convert.ToString(t1.Armor);
            progressBar7.Value = s1.Hp;
            progressBar8.Value = s1.Mp;
            armlabel4.Text = Convert.ToString(s1.Armor);
            progressBar9.Value = n1.Hp;
            progressBar10.Value = n1.Mp;
            armlabel5.Text = Convert.ToString(n1.Armor);

            progressBar11.Value = a2.Hp;
            progressBar12.Value = a2.Mp;
            armlabel6.Text = Convert.ToString(a2.Armor);
            progressBar13.Value = f2.Hp;
            progressBar14.Value = f2.Mp;
            armlabel7.Text = Convert.ToString(f2.Armor);
            progressBar15.Value = t2.Hp;
            progressBar16.Value = t2.Mp;
            armlabel8.Text = Convert.ToString(t2.Armor);
            progressBar17.Value = s2.Hp;
            progressBar18.Value = s2.Mp;
            armlabel9.Text = Convert.ToString(s2.Armor);
            progressBar19.Value = n2.Hp;
            progressBar20.Value = n2.Mp;
            armlabel10.Text = Convert.ToString(n1.Armor);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            RefreshStats();
                targets.Clear();
                foreach (Character c in command2)
                {
                    targets.Add(c);
                }
                listBox1.Items.Add(a1.FirstSkill(targets));
                RefreshStats();
                step = 2;
                stepcounter += 1;
                StepControl();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshStats();
                targets.Clear();
                targets.Add(t2);
                listBox1.Items.Add(f1.FirstSkill(targets));
                RefreshStats();
                step = 2;
                stepcounter += 1;
                StepControl();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RefreshStats();
                targets.Clear();
                targets.Add(t2);
                listBox1.Items.Add(t1.FirstSkill(targets));
                RefreshStats();
                step = 2;
                stepcounter += 1;
                StepControl();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RefreshStats();
                attacker = s1;
                comm = 2;
                VisibleControl("sa");
                RefreshStats();
                step = 2;
                stepcounter += 1;
                StepControl();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RefreshStats();
                attacker = n1;
                comm = 1;
                VisibleControl("sa");
                RefreshStats();
                step = 2;
                stepcounter += 1;
                StepControl();
        }
        public void Attack(Character attacked)
        {
            RefreshStats();
            targets.Clear();
            targets.Add(attacked);
            listBox1.Items.Add(attacker.FirstSkill(targets));
            VisibleControl("ea");
            RefreshStats();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            RefreshStats();
                targets.Clear();
                foreach (Character c in command1)
                {
                    targets.Add(c);
                }
                listBox1.Items.Add(a2.FirstSkill(targets));
                RefreshStats();
                step = 1;
                stepcounter += 1;
                StepControl();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            RefreshStats();
                targets.Clear();
                targets.Add(t1);
                listBox1.Items.Add(f2.FirstSkill(targets));
                RefreshStats();
                step = 1;
                stepcounter += 1;
                StepControl();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RefreshStats();
                targets.Clear();
                targets.Add(t1);
                listBox1.Items.Add(t2.FirstSkill(targets));
                RefreshStats();
                step = 1;
                stepcounter += 1;
                StepControl();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RefreshStats();
                attacker = s2;
                comm = 1;
                VisibleControl("sa");
                RefreshStats();
                step = 1;
                stepcounter += 1;
                StepControl();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RefreshStats();
                attacker = n2;
                comm = 2;
                VisibleControl("sa");
                RefreshStats();
                step = 1;
                stepcounter += 1;
                StepControl();
        }
        public void StepControl()
        {
            if (step == 1)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
            }
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
           
        }

        private void hplabel1_Click(object sender, EventArgs e)
        {

        }
        public void VisibleControl(string mode)
        {
            if (mode == "sa")
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                button9.Visible = false;
                button10.Visible = false;
                button11.Visible = true;
                button12.Visible = true;
                button13.Visible = true;
                button14.Visible = true;
                button15.Visible = true;
            }
            else
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
                button9.Visible = true;
                button10.Visible = true;
                button11.Visible = false;
                button12.Visible = false;
                button13.Visible = false;
                button14.Visible = false;
                button15.Visible = false;
            }
        }
        public void ParalyzeControl()
        {
            foreach (Character c in AllCharacters)
            {
                if (c.Paralyzed)
                {
                    Paralyzed.Add(c);
                }
            }
            foreach (Character c in Paralyzed)
            {
                
            }
        }
        private void button11_Click_1(object sender, EventArgs e)
        {
            if (comm == 1)
                Attack(n2);
            else
                Attack(n1);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (comm == 1)
                Attack(t2);
            else
                Attack(t1);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (comm == 1)
                Attack(a2);
            else
                Attack(a1);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (comm == 1)
                Attack(s2);
            else
                Attack(s1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (comm == 1)
                Attack(f2);
            else
                Attack(f1);
        }
    }
}
