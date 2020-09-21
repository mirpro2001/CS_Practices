using System;
using System.IO;
namespace FileWatchingDemo
{
    class Program
    {
        static void watcher_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Changed: {0}", e.FullPath);
        }

        static void Main(string[] args)
        {
            FileSystemWatcher watcher =
            new FileSystemWatcher(@"C:\Documents");
            watcher.Filter = "*.*";
            watcher.IncludeSubdirectories = true;
            watcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.Size;
            watcher.Changed += new FileSystemEventHandler(watcher_Changed);
            Console.ReadKey();
        }
    }
}
