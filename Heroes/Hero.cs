using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    public abstract class Hero
    {
        public string Name;
        public string Weapon;
        public int Damage;

        public void Attack()
        {
            Console.WriteLine($"{Name} did {Damage} damage with {Weapon}");
        }
    }
}
