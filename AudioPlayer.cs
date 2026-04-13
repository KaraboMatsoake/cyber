using System.Media;
using System.IO;

public static class AudioPlayer
{
    public static void PlayGreeting()
    {
        try
        {
            string path = "Assets/greeting.wav";
            if (File.Exists(path))
            {
                SoundPlayer player = new SoundPlayer(path);
                player.PlaySync();
            }
        }
        catch {}
    }
}
