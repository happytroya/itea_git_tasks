using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    internal class Cars
    {
        public string pilotName;
        private bool hasNitro;
        private bool hasSpoiler;

        public int time = 0;
        public int timeWithPenalty = 0;

        private static string brand = "Subaru";

        public int moveSpeed = 10;

        public int MoveSpeed 
        { 
            get 
            {
                
                if (hasSpoiler && hasNitro)
                {
                    return (moveSpeed + 3);
                }
                else if (hasNitro || hasSpoiler)
                {
                    return (moveSpeed + 1);
                }

                return moveSpeed; 
            } 
        }

        public Cars(string pilotName, bool hasNitro, bool hasSpoiler)
        {
            this.pilotName = pilotName;
            this.hasNitro = hasNitro;
            this.hasSpoiler = hasSpoiler;
        }

        public void ShowCar()
        {
            Console.WriteLine($"Pilot: {pilotName}\tCar brand: {brand}\tMove speed: {MoveSpeed}\tCar has nitro: {hasNitro}\tCar has spoiler: {hasSpoiler}");
        }

        public int Go()
        {
            return MoveSpeed * 60;
        }

    }
}
