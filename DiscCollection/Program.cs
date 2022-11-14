namespace DiscCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool wantToExit = false;


            DiskCollection firstCollection = new DiskCollection();
            firstCollection.FillCollection();
            firstCollection.ShowCollection();
            while (!wantToExit)
            {
                Console.WriteLine("Press 1 if you want to see collection \nPress 2 if you want To search by singer name " +
                    "\nPress 3 if you want to search by disk name\nPress 4 if you want to add songn press\nPress 5 if you want to delate song\nPress e if you want to exit");
                string userData = Console.ReadLine();
                if (userData == "e")
                {
                    wantToExit = true;
                }

                switch (userData)
                {
                    case "1":
                        firstCollection.ShowCollection();
                        break;
                    case "2":
                        Console.WriteLine("Enter singer name:");
                        string name = Console.ReadLine();
                        firstCollection.ShowCollectionBySingerName(name);
                        break;
                    case "3":
                        Console.WriteLine("Enter disc name:");
                        string discName = Console.ReadLine();
                        firstCollection.ShowCollectionByName(discName);
                        break;
                    case "4":
                        Console.WriteLine("Do you want to add song to Disk 1 or Disk 2?");
                        string discNumber = Console.ReadLine();
                        if (discNumber == "1")
                        {
                            Console.WriteLine("Type song name");
                            string songName = Console.ReadLine();
                            firstCollection.AddSongToSongList1(songName);
                        }
                        if (discNumber == "2")
                        {
                            Console.WriteLine("Type song name");
                            string songName = Console.ReadLine();
                            firstCollection.AddSongToSongList2(songName);
                        }
                        break;
                    case "5":
                        Console.WriteLine("Do you want to remove song from Disk 1 or Disk 2?");
                        string _discNumber = Console.ReadLine();
                        if (_discNumber == "1")
                        {
                            Console.WriteLine("Type song name");
                            string songName = Console.ReadLine();
                            firstCollection.RemoveSongFromList1(songName);
                        }
                        if (_discNumber == "2")
                        {
                            Console.WriteLine("Type song name");
                            string songName = Console.ReadLine();
                            firstCollection.RemoveSongFromList2(songName);
                        }
                        break;

                }
            }
        }
    }
}