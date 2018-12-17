using System;
using Newtonsoft.Json;

namespace CSharpScratchspace
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var json = JsonConvert.SerializeObject(new { TestJsonObj = "test" });

            Console.WriteLine(json);
        }
    }
}
