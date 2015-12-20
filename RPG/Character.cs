using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public abstract class Character
    {
        public abstract string FirstSkill(List<Character> target);
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
        private bool isdead = false;
        public bool IsDead
        {
            get { return isdead; }
            set { isdead = value; }
        }
        public void HpControl()
        {
            if (this.Hp > DefaultHp)
            {
                this.Hp = DefaultHp;
            }
            if (this.Hp <= 0)
            {
                IsDead = true;
                this.Hp = 0;
                this.Mp = 0;
                this.Armor = 0;
            }
        }
        private int paralyzedstepcounter;
        public int ParalyzedStepCounter
        {
            get { return paralyzedstepcounter; }
            set { paralyzedstepcounter = value; }
        }
    }
}
