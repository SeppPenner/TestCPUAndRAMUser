// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   The main program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TestCPUAndRAMUser;

/// <summary>
/// The main program.
/// </summary>
public static class Program
{
    /// <summary>
    /// The random.
    /// </summary>
    private static readonly Random Random = new();

    /// <summary>
    /// The test list.
    /// </summary>
    private static readonly List<object> TestList = new();

    /// <summary>
    /// The main method.
    /// </summary>
    public static void Main()
    {
        while (true)
        {
            switch (Random.Next(0, 2))
            {
                case 0:
                    TestList.Add(
                        new List<string>
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
        }
    }

    /// <summary>
    /// Reads a sample file.
    /// </summary>
    private static void ReadSampleFile()
    {
        var text = File.ReadAllText(Directory.GetCurrentDirectory() + "\\Test.txt");
        Console.WriteLine(text);
    }
}
