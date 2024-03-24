// See https://aka.ms/new-console-template for more information

using modul6_1302223029;

public class Program
{
    public static void Main(string[] args)
    {
        // state awal untuk video berisikan null
        SayaTubeVideo video = null;

        // Design Contract
        try
        {
            // Prekondisi
            video = new SayaTubeVideo("Tutorial Design By Contract");
            for (int i = 0; i < 10000000; i++)
            {
                video.IncreasePlayCount(1);
            }
        }
        // tes Exception
        catch (Exception tes)
        {
            Console.WriteLine("Error: " + tes.Message);
        }
        finally
        {
            // printoutput jika tidak terdeteksi error
            if (video != null)
            {
                video.PrintVideoDetails();
            }
        }
    }
}