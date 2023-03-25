// See https://aka.ms/new-console-template for more information
using System;

using System.Diagnostics.Contracts;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Contract.Requires(!string.IsNullOrEmpty(title));
        Contract.Requires(title.Length < 100);
        Random random = new Random();
        this.title = title;
        id = random.Next(10000, 99999);
        this.playCount = 0;
        
    }

    public void IncreasePlayCount(int playCount)
    {

        Contract.Requires(playCount <= 10000000);
        try
        {
            int check = checked(this.playCount + playCount);
            this.playCount = check;
        }
        catch(OverflowException overflow)
        {
            Console.WriteLine("Overflow Exception : " + overflow.Message);
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("Details Video : ");
        Console.WriteLine("ID : " + id);
        Console.WriteLine("Title : " + title);
        Console.WriteLine("Play Count : " + playCount);
        Console.WriteLine();
    }
}

public class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo sayaTubeVideo = new SayaTubeVideo("Tutorial Design By Contract - [Jaatsiyah_Maulidina_Astrianto]");

        sayaTubeVideo.IncreasePlayCount(2);
        sayaTubeVideo.PrintVideoDetails();

        sayaTubeVideo.IncreasePlayCount(2147483647);
        
    }
}