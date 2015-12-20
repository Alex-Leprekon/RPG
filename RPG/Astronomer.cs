using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Astronomer : Character
    {
       public Astronomer(int hp, int mp, int armor, int force, int mpreg, int hpreg, int comm)
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
           if(!this.Paralyzed)
           { 
           if (this.Mp >= 120 && !this.IsDead)
           {
               foreach (Character c in targets)
               {
                   if (!c.IsDead)
                   {
                       c.Hp -= this.Force - c.Armor;
                   }
               }
               this.Mp -= 120;
               this.Hp -= this.Force - this.Armor;
               return "Я бью всех врагов и, по какой-то причине, бью себя";
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
    }
}
