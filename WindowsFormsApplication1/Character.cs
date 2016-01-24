using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    public abstract class Character
    {
        public abstract string FirstSkill(List<Character> target);
        public abstract string SecondSkill(List<Character> target);
        private int hp;
        public int Hp
        {
            get {return hp;}
            set {hp = value;}
        }
        private bool paralyzed = false;
        public bool Paralyzed
        {
            get { return paralyzed; }
            set { paralyzed = value; }
        }
        private int mp;
        public int Mp
        {
            get { return mp; }
            set { mp = value; }
        }
        private int armor;
        public int Armor
        {
            get { return armor; }
            set { armor = value; }
        }
        private int force;
        public int Force
        {
            get { return force; }
            set { force = value; }
        }
        private int hpreg;
        public int Hpreg
        {
            get {return hpreg;}
            set {hpreg = value;}
        }
        private int mpreg;
        public int Mpreg
        {
            get { return mpreg; }
            set { mpreg = value; }
        }
        private int comm;
        public int Comm
        {
            get { return comm; }
            set { comm = value; }
        }
        private int defaulthp;
        public int DefaultHp
        {
            get { return defaulthp; }
            set { defaulthp = value; }
        }
        private int defaultmp;
        public int DefaultMp
        {
            get { return defaultmp; }
            set { defaultmp = value; }
        }
        private bool isdead = false;
        public bool IsDead
        {
            get { return isdead; }
            set { isdead = value; }
        }
        public void HpMpControl()
        {
            if (this.Hp > DefaultHp)
            {
                this.Hp = DefaultHp;
            }
            if (this.Mp > DefaultMp)
            {
                this.Mp = DefaultMp;
            }
            if (this.Hp <= 0)
            {
                this.IsDead = true;
                this.Hp = 0;
                this.Mp = 0;
                this.Armor = 0;
                this.hpbar.Visible = false;
                this.mpbar.Visible = false;
                this.armorlabel.Visible = false;
                this.skillbutton.Visible = false;
                this.attackbutton.Visible = false;
            }
            if (this.IsDead)
            {
                this.Hp = 0;
                this.Mp = 0;
            }
        }
        private int paralyzedstepcounter = 0;
        public int ParalyzedStepCounter
        {
            get { return paralyzedstepcounter; }
            set { paralyzedstepcounter = value; }
        }
        public void ParalyzeControl()
        {
            if(this.Paralyzed)
            {
                this.attackbutton.Enabled = false;
                this.skillbutton.Enabled = false;
            }
        }
        public Button skillbutton;
        public Button attackbutton;
        public Label armorlabel;
        public ProgressBar hpbar;
        public ProgressBar mpbar;
    }
}
