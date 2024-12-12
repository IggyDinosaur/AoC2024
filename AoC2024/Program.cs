using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("./Input/Day12.txt");

            /*Count perimeter*/
            /*AAAB
             *CBAB
             *DBBB
             * 
             * So we need to identify a region.  I don't care so much what the letters are as the comparison is if they're different or not on the comparison
             * Do we start at 0,0 and work across, with a mark on every block as to whether or not it's been part of a counted region?
             * So start on 0,0 - what letter am I? A - paint/pattern fill to find all of my neighbours and consider this a blob
        }
    }
}
