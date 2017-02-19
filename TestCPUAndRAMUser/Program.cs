using System;
using System.Collections.Generic;
using System.IO;

namespace TestCPUAndRAMUser
{
    public static class Program
    {
        private static readonly Random Random = new Random();
        private static readonly List<object> TestList = new List<object>();

        public static void Main()
        {
            while (true)
                switch (Random.Next(0, 2))
                {
                    case 0:
                        TestList.Add(new List<string>
                        {
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb",
                            "a346thcg",
                            "sdbvsbb",
                            "scascvsdvsdv",
                            "we7tbgwsb"
                        });
                        break;
                    case 1:
                        ReadSampleFile();
                        break;
                }
            // ReSharper disable once FunctionNeverReturns
        }

        private static void ReadSampleFile()
        {
            var text = File.ReadAllText(Directory.GetCurrentDirectory() + "\\Test.txt");
            Console.WriteLine(text);
        }
    }
}