using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTesterApp
{
    class MusicAlbum
    {
        private const int maxElement = 20;
        private string title;
        private int numOfTracks;
        private string[] songNameList;
        private double[] playTimeList;
        //private int[] monthDays = { 31, 28, 31, 30, 31, 30 };

        public MusicAlbum()
        {
            songNameList = new string[maxElement];
            playTimeList = new double[maxElement];

            for (int index = 0; index < maxElement; index++)
            {
                songNameList[index] = string.Empty;
                playTimeList[index] = -1.0;
            }
        }

        public int SearchElement(string searchString)
        {
            int foundPos = -1;

            for (int index = 0; index < songNameList.Length; index++)
            {
                if (songNameList[index].Equals(searchString))
                {
                    foundPos = index;
                    break;
                }
            }

            return foundPos;
        }

        public bool AddNewValue(string songName, double playTime)
        {
            int pos = SearchElement(string.Empty); //search for an empty array sloth
            bool succes = pos >= 0;
            if (succes)
            {
                this.songNameList[pos] = songName;
                this.playTimeList[pos] = playTime;
            }
            return succes;
        }

        public bool ChangeValue(int index, string newTitle, double playTime)
        {
            bool ok = CheckIndex(index);
            if (ok)
            {
                songNameList[index] = newTitle;
                playTimeList[index] = playTime;
            }
            return ok;
        }

        public bool DeleteValue(int index)
        {
            bool ok = CheckIndex(index);
            if (ok)
            {
                songNameList[index] = string.Empty;
                playTimeList[index] = -1.0;
            }
            return ok;
        }

        public bool CheckIndex(int index)
        {
            bool ok = (index >= 0) && (index < songNameList.Length);
            return ok; 
        }

        private int GetNumberOfElementsUsed()
        {
            int occupied = 0;
            int index = 0;
            for (index = 0; index < maxElement; index++)
            {
                if (!songNameList[index].Equals(string.Empty))
                    occupied++;
            }
            return occupied;
        }

        public string[] GetInfo()
        {
            int numOfElementsUsed = GetNumberOfElementsUsed();

            if (numOfElementsUsed <= 0)
                return null;

            string[] infoStrings = new string[numOfElementsUsed];

            int p = 0;
            for (int index = 0; index < maxElement; index++)
            {
                if (!songNameList[index].Equals(string.Empty))
                {
                    infoStrings[p++] = String.Format("Title: {0, -15} Time: {1, 6:f2}",
                        songNameList[index], playTimeList[index]);
                }
            }
            return infoStrings;

        }

        public void SetTestValues()
        {
            Random rand = new Random();
            int numOfValues = rand.Next(0, maxElement);

            for (int i = 0; i < numOfValues; i++)
            {
                songNameList[i] = "Song nr. " + i;
                playTimeList[i] = rand.NextDouble() * 10.0 + 1.0;
            }

        }

        private void TestInitialization()
        {
            int[] daysOfMonth = { 31, 28, 31, 30, 31, 30, 31,
                                    31, 30, 31, 30, 31};

            //multidimensional arrays
            //two dimensions below
            //rows and column
            int[,] table = new int[5, 4];
        }
    }
}
