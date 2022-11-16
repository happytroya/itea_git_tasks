using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    internal class HeroController<T> where T : Hero
    {
        public T Data;

        public HeroController(T data)
        {
            Data = data;
        }

        public void Print()
        {
            Console.WriteLine(Data);
        }

        public void ForceToAttack()
        {
            Data.Attack();
        }
    }
}
