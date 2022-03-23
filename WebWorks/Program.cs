using System;
using WebWorks.Framework;
using WebWorks.Framework.Elements;

namespace WebWorks
{
    class Program
    {
        public static void Main()
        {
            WebWorksModule module = new WebWorksModule();
            DivElement div = new DivElement(module.MarkupBase);

            Console.WriteLine(WebWorksModule.CodeConstructor.GenerateCode());

            Console.ReadLine();
        }
    }
}