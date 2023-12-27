// See https://aka.ms/new-console-template for more information
using static System.Net.Mime.MediaTypeNames;
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("FFXI Steam Playtime Tracking Fixer by Sebastian Scaini");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Launching FFXI through Steam.");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Keep this window open while the game is running for Steam to track your playtime!");
//Console.WriteLine(AppContext.BaseDirectory + @"SquareEnix\PlayOnlineViewer\pol.exe");
System.Diagnostics.Process.Start(AppContext.BaseDirectory + @"SquareEnix\PlayOnlineViewer\pol.exe");
Console.ReadKey();
Console.ForegroundColor = ConsoleColor.White;
Environment.Exit(0);