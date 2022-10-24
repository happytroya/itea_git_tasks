using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NeedForSpeed
{
    internal class Race
    {
        private List<int> result = new List<int>();

        private Random random = new Random();

        private int distance = 50000;

        private Cars[] carArr;

        public Race(Cars[] carArr)
        {
            this.carArr = carArr;
        }

        public void StartRace()
        {
            int bampedCount = 0;

            for (int i = 0; i < this.carArr.Length; i++)
            {
                while (distance > 0)
                {
                    this.carArr[i].time++;     
                    distance -= this.carArr[i].Go();

                    if (this.carArr[i].time % 10 == 0)
                    {
                        bool randomBool = random.Next(2) == 1; // 0 = false, 1 = true;

                        if (randomBool)
                        {
                            Console.WriteLine($"Car {i+1} bamped in {this.carArr[i].time} sec!");
                            bampedCount++;
                            this.carArr[i].timeWithPenalty = this.carArr[i].time + 5;
                        }
                    }
                }

            Console.WriteLine($"Time for car{(i+1)} is: {this.carArr[i].timeWithPenalty} and bamped {bampedCount} times" );
            bampedCount = 0;
            distance = 50000;      
            }  
        }

        public void RaceResult()
        {
            Array.Sort(carArr, (a, b) => a.timeWithPenalty.CompareTo(b.timeWithPenalty));
            for (int i = 0; i < carArr.Length; i++)
            {
                Console.WriteLine($"{carArr[i].pilotName} finishes {(i+1)}");
            }
        }
    }
}
