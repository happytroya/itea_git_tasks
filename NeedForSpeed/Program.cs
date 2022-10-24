namespace NeedForSpeed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cars[] carArr = new Cars[3];
            Race race = new Race(carArr);

            carArr[0] = new Cars("Ivan",false, false);
            carArr[1] = new Cars("Denys",true, true);
            carArr[2] = new Cars("Petro",true, false);

            for (int i = 0; i < 3; i++)
            {
                carArr[i].ShowCar();
            }

            Console.WriteLine("Press s if you want to start race");

            char start = char.Parse(Console.ReadLine());

            if (start == 's')
            {
                race.StartRace();
                race.RaceResult();
            }  
            
        }
    }
}