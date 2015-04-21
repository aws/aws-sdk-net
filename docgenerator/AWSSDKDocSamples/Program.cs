using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace AWSSDKDocSamples
{
    class Program
    {
        static int Main(string[] args)
        {
            bool allPass = true;

            var iSampleTypes = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.GetInterfaces().Contains(typeof(ISample)))
                .ToList();
            foreach (var iSampleType in iSampleTypes)
            {
                var iSample = Activator.CreateInstance(iSampleType) as ISample;
                try
                {
                    iSample.Run();
                }
                catch(Exception e)
                {
                    allPass = false;
                    Console.WriteLine("Error running sample in type {0}: {1}", iSampleType.FullName, e.ToString());
                }
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine();
                Console.WriteLine("Press enter to exit...");
                Console.ReadLine();
            }

            return (allPass ? 0 : 1);
        }
    }

    public interface ISample
    {
        void Run();
    }
}
