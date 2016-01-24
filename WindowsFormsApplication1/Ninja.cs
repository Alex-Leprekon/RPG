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
    public class Ninja : Character
    {
        public Ninja(int hp, int mp, int armor, int force, int mpreg, int hpreg, int comm)
        {
            this.DefaultHp = hp;
            this.Hp = hp;
            this.Mp = mp;
            this.Armor = armor;
            this.Force = force;
            this.Mpreg = mpreg;
            this.Hpreg = hpreg;
            this.Comm = comm;
            this.DefaultMp = mp;
        }
        public override string FirstSkill(List<Character> targets)
        {
            if (!this.Paralyzed)
            {
                if (this.Mp >= 120 && !this.IsDead)
                {
                    if (!targets[0].IsDead)
                    {
                        targets[0].Armor -= 1;
                        targets[0].Hp -= (this.Force - targets[0].Armor);
                    }
                    this.Mp -= 120;
                    return "Я настолько крут, что отбираю у тебя броню";
                }
                else
                {
                    return "либо мало маны, либо я сдох";
                }
            }
            else
            {
                return "*пускает пену изо рта*";
            }
        }
            public override string SecondSkill(List<Character> targets)
        {
            if (!this.Paralyzed)
            {
                if (!this.IsDead)
                {
                    if(!targets[0].IsDead)
                    {
                        targets[0].Hp -= this.Force;
                    }
                    return "бдыщ!";
                }
                else
                {
                    return "я труп";
                }
            }
            else
            {
                return "*пускает пену изо рта*";
            }
        }
    }
}
