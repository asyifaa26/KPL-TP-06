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

        }

        
        public void PrintVideoDetails()
        {
            Console.WriteLine($"Video ID: {id}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Play Count: {playCount}");
        }
    }
}
