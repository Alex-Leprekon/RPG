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
            this.DefaultMp = mp;
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
        public override string SecondSkill(List<Character> targets)
        {
            if (!this.Paralyzed)
            {
                if (!this.IsDead)
                {
                    if (!targets[0].IsDead)
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

