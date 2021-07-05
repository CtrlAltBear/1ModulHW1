using System;
using System.IO;
namespace StyleCop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new Starter().Run();
            File.WriteAllText("log.txt", Logger.User.ToString());
        }
    }
}
