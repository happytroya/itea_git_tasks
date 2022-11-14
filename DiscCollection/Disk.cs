using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscCollection
{
    internal class DisK
    {
        public string diskName;
        public string singer;
        public List<string> songs;

        public DisK(string diskName, string singer, List<string> songs)
        {
            this.diskName = diskName;
            this.singer = singer;
            this.songs = songs;
        }

        public void ShowDiscInfo()
        {
            Console.WriteLine($"Disk: {diskName}\nSinger: {singer}");
            foreach (string songTitle in songs)
            {
                Console.WriteLine($"Title: {songTitle}");
            }
        }
    }
}
