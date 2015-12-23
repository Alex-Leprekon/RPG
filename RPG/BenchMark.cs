using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Frame: Character
    {
        public Frame(int hp, int mp, int armor, int force, int mpreg, int hpreg, int comm)
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
        public override string FirstSkill(List<Character>targets)
        {
                if (this.Mp >= 100 && !this.IsDead)
                {
                    if (!targets[0].IsDead)
                    {
                        targets[0].Paralyzed = true;
                        targets[0].ParalyzedStepCounter = 1;
                    }
                    this.Mp -= 100;
                    return "Мой реп настолько плох, что ты парализован, йоу";
                }
                else
                {
                    return "либо мало маны, либо я сдох";
                }
            }
        }
    }

