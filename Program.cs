﻿namespace AudioMP3Player;

{
  static void Main(string[] args)
  {
    Console.WriteLine("Enter music folder path:");
    string? folderPath = Console.ReadLine();

    if (string.IsNullOrEmpty(folderPath) || !Directory.Exists(folderPath))
    {
      Console.WriteLine("Invalid folder path.");
    }

    AudioMP3Player player = new AudioMP3Player(folderPath);

    Console.WriteLine("Press 'P' to play/resume, 'S' to stop, 'A' to pause, 'N' for next 'B' for previous track, 'Q' to quit");

    while (true)
    {
      var key = Console.ReadKey(true).Key;

      if(key == ConsoleKey.P)
      {
        player.Play();
      }
      else if (key == ConsoleKey.S)
      {
        player.Stop();
      }
      else if (key == ConsoleKey.A)
      {
        player.Pause();
      }
      else if (key == ConsoleKey.N)
      {
        player.NextTrack();
      }
      else if (key == ConsoleKey.B)
      {
        player.PreviousTrack();
      }
      else if (key == ConsoleKey.Q)
      {
        player.Stop();
        break;
      }
    }
  }

}
