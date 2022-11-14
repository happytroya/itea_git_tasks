using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscCollection
{
    internal class DiskCollection
    {
        List<string> songList1 = new List<string>();
        List<string> songList2 = new List<string>();

        public ArrayList discCollection = new ArrayList();

        public List<string> FillFirstDisk()
        {
            songList1.Add("I'm not afraid");
            songList1.Add("Matshal");

            return songList1;
        }

        public List<string> FillSecondDisk()
        {
            songList2.Add("Go go go");
            songList2.Add("Back back back");

            return songList2;
        }

        public List<String> AddSongToSongList1(string songToAdd)
        {
            songList1.Add(songToAdd);
            return songList1;
        }

        public List<string> AddSongToSongList2(string songToAdd)
        {
            songList2.Add(songToAdd);
            return songList2;
        }

        public List<string> RemoveSongFromList1(string songName)
        {
            songList1.Remove(songName);
            return songList1;
        }
        public List<string> RemoveSongFromList2(string songName)
        {
            songList2.Remove(songName);
            return songList2;
        }

        public void FillCollection()
        {
            discCollection.Add(new DisK("Disk1", "Eminem", FillFirstDisk()));
            discCollection.Add(new DisK("Disk2", "Nobody", FillSecondDisk()));
        }

        public void ShowCollection()
        {
            foreach (DisK d in discCollection)
            {
                d.ShowDiscInfo();
            }
        }

        public void ShowCollectionBySingerName(string singerName)
        {
            foreach (DisK d in discCollection)
            {
                if (d.singer == singerName)
                {
                    d.ShowDiscInfo();
                }
            }
        }

        public void ShowCollectionByName(string diskName)
        {
            foreach (DisK d in discCollection)
            {
                if (d.diskName == diskName)
                {
                    d.ShowDiscInfo();
                }
            }
        }
    }
}
