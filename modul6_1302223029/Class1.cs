using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302223029
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            
            Random acak = new Random();
            id = acak.Next(9999, 100001);

            
            Debug.Assert(title.Length <= 100 && title != null);
            this.title = title;

            
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
             Contract.Requires(count > 0 && count <= 10000000, "Input penambahan play count maximal 10.000.000 play count");
             Contract.Ensures(playCount <= int.MaxValue - count, "Penambahan play count melebihi maximal.");

             try
             {
                 checked
                 {
                     playCount += count;
                 }
             }
            
             catch (OverflowException)
             {
                 Console.WriteLine("Error: Penambahan play count melebihi batas maksimal, yakni melebihi 10.000.000.");
             }
        }

        
        public void PrintVideoDetails()
        {
            Console.WriteLine($"Video ID: {id}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Play Count: {playCount}");
        }
    }
}
