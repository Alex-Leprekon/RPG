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
        Astronomer a1 = new Astronomer(350, 700, 10, 50, 12, 8,1);
        Ninja n1 = new Ninja(300, 400, 3, 100, 10, 15,1);
        Sysadmin s1 = new Sysadmin(250, 500, 5, 20, 20, 10,1);
        Titan t1 = new Titan(500, 300, 15, 30, 7, 5,1);
        Frame f1 = new Frame(300, 400, 10, 25, 15, 8,1);
        Astronomer a2 = new Astronomer(350, 700, 10, 50, 12, 8,2);
        Ninja n2 = new Ninja(300, 400, 3, 100, 10, 15,2);
        Sysadmin s2 = new Sysadmin(250, 500, 5, 20, 20, 10,2);
        Titan t2 = new Titan(500, 300, 15, 30, 7, 5,2);
        Frame f2 = new Frame(300, 400, 10, 25, 15, 8,2);
        Character attacker;
        public double realstepcounter = 0;
        public int step = 1;
        public int stepcounter = 0;
        int comm;
        int skillnomber;
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
            a1.hpbar = progressBar1;
            a1.mpbar = progressBar2;
            a1.armorlabel = armlabel1;
            a1.skillbutton = button1;
            a1.attackbutton = button19;
            f1.hpbar = progressBar3;
            f1.mpbar = progressBar4;
            f1.armorlabel = armlabel2;
            f1.skillbutton = button2;
            f1.attackbutton = button18;
            t1.hpbar = progressBar5;
            t1.mpbar = progressBar6;
            t1.armorlabel = armlabel3;
            t1.skillbutton = button3;
            t1.attackbutton = button16;
            s1.hpbar = progressBar7;
            s1.mpbar = progressBar8;
            s1.armorlabel = armlabel4;
            s1.skillbutton = button4;
            s1.attackbutton = button20;
            n1.hpbar = progressBar9;
            n1.mpbar = progressBar10;
            n1.armorlabel = armlabel5;
            n1.skillbutton = button5;
            n1.attackbutton = button21;

            a2.hpbar = progressBar11;
            a2.mpbar = progressBar12;
            a2.armorlabel = armlabel6;
            a2.skillbutton = button10;
            a2.attackbutton = button22;
            f2.hpbar = progressBar13;
            f2.mpbar = progressBar14;
            f2.armorlabel = armlabel7;
            f2.skillbutton = button9;
            f2.attackbutton = button23;
            t2.hpbar = progressBar15;
            t2.mpbar = progressBar16;
            t2.armorlabel = armlabel8;
            t2.skillbutton = button8;
            t2.attackbutton = button17;
            s2.hpbar = progressBar17;
            s2.mpbar = progressBar18;
            s2.armorlabel = armlabel9;
            s2.skillbutton = button7;
            s2.attackbutton = button24;
            n2.hpbar = progressBar19;
            n2.mpbar = progressBar20;
            n2.armorlabel = armlabel10;
            n2.skillbutton = button6;
            n2.attackbutton = button25;
        }
        public void RefreshStats()
        {
            ParalyzeControl();
            a1.HpMpControl();
            a2.HpMpControl();
            n1.HpMpControl();
            n2.HpMpControl();
            s1.HpMpControl();
            s2.HpMpControl();
            t1.HpMpControl();
            t2.HpMpControl();
            f1.HpMpControl();
            f2.HpMpControl();

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
            skillnomber = 1;
                targets.Clear();
                foreach (Character c in command2)
                {
                    targets.Add(c);
                }
                listBox1.Items.Add(a1.FirstSkill(targets));
                step = 2;
                StepControl();
                RefreshStats();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            skillnomber = 1;
            attacker = f1;
            comm = 1;
            VisibleControl("sa");
            step = 2;
            StepControl();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            skillnomber = 1;
                targets.Clear();
                targets.Add(t2);
                listBox1.Items.Add(t1.FirstSkill(targets));
                step = 2;
                StepControl();
                RefreshStats();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            skillnomber = 1;
                attacker = s1;
                comm = 2;
                VisibleControl("sa");
                step = 2;
                StepControl();
        }

        private void button5_Click(object sender, EventArgs e)
        {
                attacker = n1;
                skillnomber = 1;
                comm = 1;
                VisibleControl("sa");
                step = 2;
                StepControl();
        }
        public void Attack(Character attacked)
        {
            if (skillnomber == 1)
            {
                targets.Clear();
                targets.Add(attacked);
                listBox1.Items.Add(attacker.FirstSkill(targets));
                VisibleControl("ea");
                RefreshStats();
            }
            else
            {
                if (skillnomber == 2)
                {
                    targets.Clear();
                    targets.Add(attacked);
                    listBox1.Items.Add(attacker.SecondSkill(targets));
                    VisibleControl("ea");
                    RefreshStats();
                }
            }
        }
        public void CheckWin()
        {
            int DeadCharactersComm1 = 0;
            int DeadCharactersComm2 = 0;
            foreach (Character c in command1)
            {
                if (c.IsDead)
                {
                    DeadCharactersComm1++;
                }
            }
            foreach (Character c in command2)
            {
                if (c.IsDead)
                {
                    DeadCharactersComm2++;
                }
            }
            if(DeadCharactersComm1 == 5)
            {
                MessageBox.Show("Вторая комманда победила!");
                Close();
            }
            if (DeadCharactersComm2 == 5)
            {
                MessageBox.Show("Первая комманда победила!");
                Close();
            }
            if (DeadCharactersComm2 == 5 && DeadCharactersComm1 == 5)
            {
                MessageBox.Show("Ничья!");
                Close();
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            skillnomber = 1;
                targets.Clear();
                foreach (Character c in command1)
                {
                    targets.Add(c);
                }
                listBox1.Items.Add(a2.FirstSkill(targets));
                step = 1;
                StepControl();
                RefreshStats();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            skillnomber = 1;
            attacker = f2;
            comm = 2;
            VisibleControl("sa");
            step = 1;
            StepControl();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            skillnomber = 1;
                targets.Clear();
                targets.Add(t1);
                listBox1.Items.Add(t2.FirstSkill(targets));
                step = 1;
                StepControl();
                RefreshStats();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            skillnomber = 1;
                attacker = s2;
                comm = 1;
                VisibleControl("sa");
                step = 1;
                StepControl();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            skillnomber = 1;
                attacker = n2;
                comm = 2;
                VisibleControl("sa");
                step = 1;
                StepControl();
        }
        public void StepControl()
        {
            stepcounter++;
            realstepcounter = stepcounter / 2;
            int rsti = Convert.ToInt32(realstepcounter);
            if(rsti == realstepcounter)
            {
                HpMpRegen();
            }
            if (step == 1)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button16.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = true;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button17.Enabled = false;
                button22.Enabled = false;
                button23.Enabled = false;
                button24.Enabled = false;
                button25.Enabled = false;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button16.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button17.Enabled = true;
                button22.Enabled = true;
                button23.Enabled = true;
                button24.Enabled = true;
                button25.Enabled = true;
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
                button16.Visible = false;
                button17.Visible = false;
                button18.Visible = false;
                button19.Visible = false;
                button20.Visible = false;
                button21.Visible = false;
                button22.Visible = false;
                button23.Visible = false;
                button24.Visible = false;
                button25.Visible = false;
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
                button16.Visible = true;
                button17.Visible = true;
                button18.Visible = true;
                button19.Visible = true;
                button20.Visible = true;
                button21.Visible = true;
                button22.Visible = true;
                button23.Visible = true;
                button24.Visible = true;
                button25.Visible = true;
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
                if (c.ParalyzedStepCounter <= 2)
                {
                    c.ParalyzedStepCounter++;
                }
                else
                {
                    c.Paralyzed = false;
                    c.ParalyzedStepCounter = 0;
                }
            }
            a1.ParalyzeControl();
            f1.ParalyzeControl();
            s1.ParalyzeControl();
            t1.ParalyzeControl();
            n1.ParalyzeControl();
            a2.ParalyzeControl();
            f2.ParalyzeControl();
            s2.ParalyzeControl();
            t2.ParalyzeControl();
            n2.ParalyzeControl();
        }
        public void HpMpRegen()
        {
            foreach (Character c in AllCharacters)
            {
                c.Hp += c.Hpreg;
                c.Mp += c.Mpreg;
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

        private void button16_Click(object sender, EventArgs e)
        {
            attacker = t1;
            skillnomber = 2;
            comm = 1;
            VisibleControl("sa");
            step = 2;
            StepControl();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            attacker = t2;
            skillnomber = 2;
            comm = 2;
            VisibleControl("sa");
            step = 1;
            StepControl();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            attacker = s1;
            skillnomber = 2;
            comm = 1;
            VisibleControl("sa");
            step = 2;
            StepControl();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            attacker = n1;
            skillnomber = 2;
            comm = 1;
            VisibleControl("sa");
            step = 2;
            StepControl();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            attacker = f1;
            skillnomber = 2;
            comm = 1;
            VisibleControl("sa");
            step = 2;
            StepControl();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            attacker = a1;
            skillnomber = 2;
            comm = 1;
            VisibleControl("sa");
            step = 2;
            StepControl();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            attacker = a2;
            skillnomber = 2;
            comm = 2;
            VisibleControl("sa");
            step = 1;
            StepControl();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            attacker = f2;
            skillnomber = 2;
            comm = 2;
            VisibleControl("sa");
            step = 1;
            StepControl();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            attacker = s2;
            skillnomber = 2;
            comm = 2;
            VisibleControl("sa");
            step = 1;
            StepControl();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            attacker = n2;
            skillnomber = 2;
            comm = 2;
            VisibleControl("sa");
            step = 1;
            StepControl();
        }
    }
}
