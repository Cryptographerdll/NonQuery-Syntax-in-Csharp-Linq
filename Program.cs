using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Linq__FluentSyntax_MethodSysntax
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Names = new List<string>()
            {
                "school","khalil","pen","software","tesla","microsoft","hardware",
                "good","slow","get","low","high","width","padding"
            };

            // Non Query Syntax 

            // FluentSyntax || MethodSyntax

            var Result = Names.Where(item => item.Contains("s")).Take(2);

            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
