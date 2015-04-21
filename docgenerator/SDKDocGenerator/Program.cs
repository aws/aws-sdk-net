using System;

namespace SDKDocGenerator
{
    class Program
    {
        static int Main(string[] args)
        {
            var returnCode = -1;
            var commandArguments = CommandArguments.Parse(args);
            if (!string.IsNullOrEmpty(commandArguments.Error))
            {
                Console.WriteLine(commandArguments.Error);
                return returnCode;
            }

            try
            {
                var docGenerator = new SdkDocGenerator();
                returnCode = docGenerator.Execute(commandArguments.ParsedOptions);
                Console.WriteLine("Documentation generation completed in {0} minute {1} seconds", docGenerator.Duration.Minutes, docGenerator.Duration.Seconds);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                Console.WriteLine(e.StackTrace);
            }

            if (commandArguments.ParsedOptions.WaitOnExit)
            {
                Console.WriteLine("Press Enter to exit...");
                Console.ReadLine();
            }

            return returnCode;
        }
    }
}
