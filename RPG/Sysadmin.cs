using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Sysadmin : Character
    {
        public Sysadmin(int hp, int mp, int armor, int force, int mpreg, int hpreg, int comm)
        {
            this.Hp = hp;
            this.DefaultHp = hp;
            this.Mp = mp;
            this.Armor = armor;
            this.Force = force;
            this.Mpreg = mpreg;
            this.Hpreg = hpreg;
            this.Comm = comm;
        }
        public override string FirstSkill(List<Character> targets)
        {
            if (this.Mp >= 100 && !this.IsDead)
            {
                if (!targets[0].IsDead)
                {
                    targets[0].Hp += this.Force * 3;
                }
                this.Mp -= 100;
                return "Я кого-то лечу, хотя я сисадмин, а не врач. Это странно";
            }
            else
            {
                return "либо мало маны, либо я сдох";
            }
        }
    }
}
