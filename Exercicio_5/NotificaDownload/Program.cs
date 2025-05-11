class Program
{
    static void Main(string[] args)
    {
        var manager = new DownloadManager();
        
        manager.DownloadCompleted += manager_DownloadCompleted;

        manager.StartDownload();

        Console.WriteLine("Pressione Enter para sair.");
        Console.ReadLine();

    }

    static void manager_DownloadCompleted(object sender, DownloadCompletedEventArgs e) 
    {
        Console.WriteLine($"O Download foi concluído em {e.TempoDownload} ms.");
    }
}