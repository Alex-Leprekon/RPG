﻿using System;
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
            this.Mp = mp;
            this.Armor = armor;
            this.Force = force;
            this.Mpreg = mpreg;
            this.Hpreg = hpreg;
            this.Comm = comm;
        }
        public override string FirstSkill(List<Character>targets)
        {
            this.Mp -= 100;
            return "Мой реп настолько плох, что ты парализован, йоу";
        }
    }
}