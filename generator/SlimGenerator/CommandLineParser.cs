using System;
using System.Collections.Generic;

namespace SlimGenerator
{
    internal class CommandArguments
    {
        public string ModelPath { get; private set; }
        public string CoreVersion { get; private set; } = "4.0.7.4";
        public string OutputDir { get; private set; }
        public string Error { get; private set; }

        internal static CommandArguments Parse(string[] args)
        {
            var result = new CommandArguments();
            var i = 0;

            while (i < args.Length)
            {
                switch (args[i].ToLowerInvariant())
                {
                    case "--model-path":
                        if (i + 1 >= args.Length)
                        {
                            result.Error = "--model-path requires a value";
                            return result;
                        }
                        result.ModelPath = args[++i];
                        break;
                    case "--core-version":
                        if (i + 1 >= args.Length)
                        {
                            result.Error = "--core-version requires a value";
                            return result;
                        }
                        result.CoreVersion = args[++i];
                        break;
                    case "--output-dir":
                        if (i + 1 >= args.Length)
                        {
                            result.Error = "--output-dir requires a value";
                            return result;
                        }
                        result.OutputDir = args[++i];
                        break;
                    default:
                        result.Error = $"Unknown argument: {args[i]}";
                        return result;
                }
                i++;
            }

            if (string.IsNullOrEmpty(result.ModelPath))
            {
                result.Error = "Missing required argument: --model-path <path_to_model>";
            }

            return result;
        }

        internal static void PrintUsage()
        {
            Console.Error.WriteLine("Usage: slim-generator --model-path <path_to_model> [options]");
            Console.Error.WriteLine();
            Console.Error.WriteLine("Options:");
            Console.Error.WriteLine("  --model-path      (Required) Path to the service model directory");
            Console.Error.WriteLine("  --core-version    AWSSDK.Core NuGet version to compile against (default: 4.0.7.4)");
            Console.Error.WriteLine("  --output-dir      Directory for the output DLL (default: ./output)");
        }
    }
}
