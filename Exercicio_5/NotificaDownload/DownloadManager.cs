using System;
using System.Threading;


public class DownloadCompletedEventArgs : EventArgs
{
	public int TempoDownload { get; set; }

	public DownloadCompletedEventArgs(int tempoDownload)
    {
        this.TempoDownload = tempoDownload;
    }
}

public class DownloadManager
{
    public event EventHandler<DownloadCompletedEventArgs> DownloadCompleted;


    public void StartDownload()
    {
        Console.WriteLine("Iniciando download...");

        int tempo = 4000;

        Thread.Sleep(tempo);

        Console.WriteLine("Download concluído com sucesso!");

        QuandoDownloadCompletar(new DownloadCompletedEventArgs(tempo));
    }

    protected virtual void QuandoDownloadCompletar(DownloadCompletedEventArgs e)
    {
        DownloadCompleted?.Invoke(this, e);
    }
}
