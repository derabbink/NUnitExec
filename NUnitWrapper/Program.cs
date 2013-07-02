using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using NUnit.Core;
using NUnit.Core.Filters;

namespace NUnitWrapper
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CoreExtensions.Host.InitializeService();
            SimpleTestRunner runner = new SimpleTestRunner();
            TestPackage package = new TestPackage("CodeTests");
            package.Assemblies.Add("..\\..\\..\\SomeLib.Test\\bin\\Debug\\SomeLib.Test.dll");
            if (runner.Load(package))
            {
                TestResult result = runner.Run(new NullListener(), TestFilter.Empty, true, LoggingThreshold.All);
            }

            Console.ReadLine();
        }
    }
}
