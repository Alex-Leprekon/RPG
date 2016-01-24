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
    public class Titan : Character
    {
        public Titan(int hp, int mp, int armor, int force, int mpreg, int hpreg, int comm)
        {
            this.Hp = hp;
            this.DefaultHp = hp;
            this.Mp = mp;
            this.Armor = armor;
            this.Force = force;
            this.Mpreg = mpreg;
            this.Hpreg = hpreg;
            this.DefaultMp = mp;
            this.Comm = comm;
        }
        public override string FirstSkill(List<Character> targets)
        {
            if (!this.Paralyzed)
            {
                if (this.Mp >= 20 && !this.IsDead)
                {
                    this.Armor += 2;
                    this.Mp -= 20;
                    return "Я добавляю себе бронь";
                }
                else
                {
                    return "либо недостаточно маны, либо я сдох";
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
                    return "титан сделал бум";
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
