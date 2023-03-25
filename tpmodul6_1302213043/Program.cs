// See https://aka.ms/new-console-template for more information
public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Random random = new Random();
        this.title = title;
        id = random.Next(10000, 99999);
        playCount = 0;
    }

    public void IncreasePlayCount(int playCount)
    {
        this.playCount = playCount;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("Details Video : ");
        Console.WriteLine("ID : " + id);
        Console.WriteLine("Title : " + title);
        Console.WriteLine("Play Count : " + playCount);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo sayaTubeVideo = new SayaTubeVideo("Tutorial Design By Contract - [Jaatsiyah_Maulidina_Astrianto]");
        sayaTubeVideo.PrintVideoDetails();
    }
}