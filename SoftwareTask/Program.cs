namespace SoftwareTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Software[] softwares = new Software[6];


            Free freeSoft1 = new Free("PixilArt", "PixilArtLtd");
            Free freeSoft2 = new Free("Paint", "Microsoft");

            Trial trialSoft1 = new Trial("CapturingReality", "Epic Games", DateTime.Now, 14);
            Trial trialSoft2 = new Trial("Pixlr", "Pixlr.LTD", new DateTime(2022, 5, 1), 14);

            Commercial commercialSoft1 = new Commercial("Photoshop", "Adobe", DateTime.Now, 30);
            Commercial commercialSoft2 = new Commercial("Adobe Premiere", "Adobe", DateTime.Now, 60);

            softwares[0] = freeSoft1;
            softwares[1] = freeSoft2;
            softwares[2] = trialSoft1;
            softwares[3] = trialSoft2;
            softwares[4] = commercialSoft1;
            softwares[5] = commercialSoft2;

            foreach (Software soft in softwares)
            {
                soft.ShowInfo();
            }

            Console.WriteLine("\nAwailable today:");

            foreach (Software soft in softwares)
            {
                if (soft.IsAwailable())
                {
                    Console.WriteLine(soft.SoftwareName);
                }      
            }


        }
    }
}