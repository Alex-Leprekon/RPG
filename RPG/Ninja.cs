﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Ninja : Character
    {
        public Ninja(int hp, int mp, int armor, int force, int mpreg, int hpreg, int comm)
        {
            this.Hp = hp;
            this.Mp = mp;
            this.Armor = armor;
            this.Force = force;
            this.Mpreg = mpreg;
            this.Hpreg = hpreg;
            this.Comm = comm;
        }
        public override string FirstSkill(List<Character> targets)
        {
            if (this.Mp >= 120)
            {
                targets[0].Armor -= 1;
                targets[0].Hp -= (this.Force - targets[0].Armor);
                this.Mp -= 120;
                return "Я настолько крут, что отбираю у тебя броню";
            }
            else
            {
                return "Я настолько крут, что отбираю у тебя броню";
            }
        }
    }
}