using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ServiceClientGenerator
{
    /// <summary>
    /// Parses the command line into argument settings controlling the
    /// sdk code generator.
    /// </summary>
    internal class CommandArguments
    {
        /// <summary>
        /// Takes the command line arguments, fuses them with any response file that may also have
        /// been specified, and parses them.
        /// </summary>
        /// <param name="cmdlineArgs">The set of arguments supplied to the program</param>
        /// <returns></returns>
        public static CommandArguments Parse(string[] cmdlineArgs)
        {
            var arguments = new CommandArguments();
            arguments.Process(cmdlineArgs);
            return arguments;
        }

        /// <summary>
        /// Set if an error is encountered whilst parsing arguments.
        /// </summary>
        public string Error { get; private set; }

        /// <summary>
        /// <para>
        /// The collection of options parsed from the command line.
        /// These arguments exist on the command line as individual entries
        /// prefixed with '-' or '/'. Options can be set in a response file
        /// and indicated with a '@' prefix, in which case the contents
        /// of the file will be read and inserted into the same relative
        /// location in the arguments to parse (allowing for later
        /// arguments to override).
        /// </para>
        /// <para>
        /// Options not specified on the command line are set from internal
        /// defaults.
        /// </para>
        /// </summary>
        public GeneratorOptions ParsedOptions { get; private set; }

        private CommandArguments()
        {
            ParsedOptions = new GeneratorOptions();
        }

        private void Process(IEnumerable<string> cmdlineArgs)
        {
            // walk the supplied command line looking for any response file(s), indicated using
            // @filename, and fuse into one logical set of arguments we can parse
            var argsToParse = new List<string>();
            foreach (var a in cmdlineArgs)
            {
                if (a.StartsWith("@", StringComparison.OrdinalIgnoreCase))
                    AddResponseFileArguments(a.Substring(1), argsToParse);
                else
                    argsToParse.Add(a);
            }

            if (string.IsNullOrEmpty(Error))
            {
                for (var argIndex = 0; argIndex < argsToParse.Count; argIndex++)
                {
                    if (!IsSwitch(argsToParse[argIndex])) continue;

                    var argDeclaration = FindArgDeclaration(argsToParse[argIndex]);
                    if (argDeclaration != null)
                    {
                        if (argDeclaration.HasValue)
                            argIndex++;
                        if (argIndex < argsToParse.Count)
                            argDeclaration.Parse(this, argsToParse[argIndex]);
                        else
                            Error = "Expected value for argument: " + argDeclaration.OptionName;
                    }
                    else
                        Error = "Unrecognised argument: " + argsToParse[argIndex];

                    if (!string.IsNullOrEmpty(Error))
                        break;
                }
            }
        }

        private void AddResponseFileArguments(string responseFile, ICollection<string> args)
        {
            try
            {
                // Response file format is one argument (plus optional value)
                // per line. Comments can be used by putting # as the first char.
                using (var s = new StreamReader(ResolvePath(responseFile)))
                {
                    var line = s.ReadLine();
                    while (line != null)
                    {
                        if (line.Length != 0 && line[0] != '#')
                        {
                            // trying to be flexible here and allow for lines with or without keyword 
                            // prefix in the response file
                            var keywordEnd = line.IndexOf(' ');
                            var keyword = keywordEnd > 0 ? line.Substring(0, keywordEnd) : line;

                            if (ArgumentPrefixes.Any(prefix => keyword.StartsWith(prefix.ToString(CultureInfo.InvariantCulture))))
                                args.Add(keyword);
                            else
                                args.Add(ArgumentPrefixes[0] + keyword);

                            if (keywordEnd > 0)
                            {
                                keywordEnd++;
                                if (keywordEnd < line.Length)
                                {
                                    var value = line.Substring(keywordEnd).Trim(' ');
                                    if (!string.IsNullOrEmpty(value))
                                        args.Add(value);
                                }
                            }
                        }
                        line = s.ReadLine();
                    }
                }
            }
            catch (Exception e)
            {
                Error = string.Format("Caught exception processing response file {0} - {1}", responseFile, e.Message);
            }
        }

        delegate void ParseArgument(CommandArguments arguments, string argValue = null);

        class ArgDeclaration
        {
            public string OptionName { get; set; }
            public string ShortName { get; set; }
            public bool HasValue { get; set; }
            public ParseArgument Parse { get; set; }
            public string HelpText { get; set; }
            public string HelpExample { get; set; }
        }

        static readonly ArgDeclaration[] ArgumentsTable =
        {
            new ArgDeclaration
            {
                OptionName = "verbose", 
                ShortName = "v", 
                Parse = (arguments, argValue) => arguments.ParsedOptions.Verbose = true, 
                HelpText = "Enable verbose output."
            },    
            new ArgDeclaration
            {
                OptionName = "waitonexit", 
                ShortName = "w", 
                Parse = (arguments, argValue) => arguments.ParsedOptions.WaitOnExit = true, 
                HelpText = "Pauses waiting for a keypress after code generation completes."
            },    
            new ArgDeclaration
            {
                OptionName = "manifest", 
                ShortName = "m", 
                HasValue = true,
                Parse = (arguments, argValue) => arguments.ParsedOptions.Manifest = argValue, 
                HelpText = "The name and location of the control manifest listing all supported services for generation."
            },    
            new ArgDeclaration
            {
                OptionName = "versions", 
                ShortName = "vs", 
                HasValue = true,
                Parse = (arguments, argValue) => arguments.ParsedOptions.Versions = argValue, 
                HelpText = "The name and location of the manifest listing versions of all supported services."
            },    
            new ArgDeclaration
            {
                OptionName = "modelsfolder", 
                ShortName = "mf", 
                HasValue = true,
                Parse = (arguments, argValue) => arguments.ParsedOptions.ModelsFolder = argValue, 
                HelpText = "The location of the folder containing the service model files."
            },    
            new ArgDeclaration
            {
                OptionName = "sdkroot", 
                ShortName = "sdk", 
                HasValue = true,
                Parse = (arguments, argValue) => arguments.ParsedOptions.SdkRootFolder = argValue, 
                HelpText = "The root folder beneath which the source and test code for the SDK is arranged."
            },    
            new ArgDeclaration
            {
                OptionName = "servicemodels", 
                ShortName = "sm", 
                HasValue = true,
                Parse = (arguments, argValue) => arguments.ParsedOptions.ServiceModels = argValue, 
                HelpText = "Collection of one or more service model identifiers, separated by the ';' character.\n"
                            + "If specified only these service(s) will be generated. The values specified are matched with\n"
                            + "the 'model' entry values in the service manifest file."
            },
            new ArgDeclaration
            {
                OptionName = "clean", 
                ShortName = "c", 
                Parse = (arguments, argValue) => arguments.ParsedOptions.Clean = true, 
                HelpText = "Deletes all content in the 'Generated' subfolder for services prior to generation.\n"
                            + "The default behavior is to keep existing generated content."
            },
            new ArgDeclaration
            {
                OptionName = "disable.pcl-support",
                Parse = (arguments, argValue) => arguments.ParsedOptions.DisablePCLSupport = true,
                HasValue = false,
                HelpText = "Disable PCL as part of the nuget package. Useful for creating nupkg on machines that don't have Xamarin installed"
            },
            new ArgDeclaration
            {
                OptionName = "unitypath", 
                ShortName = "u", 
                HasValue = true,
                Parse = (arguments, argValue) => arguments.ParsedOptions.UnityPath = argValue, 
                HelpText = "Specifies the path to the Unity installation directory, e.g. 'C:\\Program Files\\Unity'."
            },
            new ArgDeclaration
            {
                OptionName = "self.modelpath", 
                Parse = (arguments, argValue) => arguments.ParsedOptions.SelfServiceModel = argValue, 
                HasValue = true,
                HelpText = "Path to service model for self service."
            },
            new ArgDeclaration
            {
                OptionName = "self.basename", 
                Parse = (arguments, argValue) => arguments.ParsedOptions.SelfServiceBaseName = argValue, 
                HasValue = true,
                HelpText = "Self Service base name used for namespace and client name."
            },
            new ArgDeclaration
            {
                OptionName = "self.endpoint-prefix", 
                Parse = (arguments, argValue) => arguments.ParsedOptions.SelfServiceEndpointPrefix = argValue, 
                HasValue = true,
                HelpText = "Endpoint prefix for self service."
            },
            new ArgDeclaration
            {
                OptionName = "self.sig-v4-service-name", 
                Parse = (arguments, argValue) => arguments.ParsedOptions.SelfServiceSigV4Name = argValue, 
                HasValue = true,
                HelpText = "Sig V4 service signing name."
            }
        };

        static readonly char[] ArgumentPrefixes = { '-', '/' };

        /// <summary>
        /// Returns true if the supplied value has a argument prefix indicator, marking it as
        /// an argumentkeyword.
        /// </summary>
        /// <param name="argument"></param>
        /// <returns></returns>
        static bool IsSwitch(string argument)
        {
            return ArgumentPrefixes.Any(c => argument.StartsWith(c.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Scans the argument declaration table to find a matching entry for a token from the command line
        /// that is potentially an option keyword.
        /// </summary>
        /// <param name="argument">Keyword found on the command line. Any prefixes will be removed before attempting to match.</param>
        /// <returns>Matching declaration or null if keyword not recognised</returns>
        static ArgDeclaration FindArgDeclaration(string argument)
        {
            var keyword = argument.TrimStart(ArgumentPrefixes);
            return ArgumentsTable.FirstOrDefault(argDeclation
                => keyword.Equals(argDeclation.ShortName, StringComparison.OrdinalIgnoreCase)
                   || keyword.Equals(argDeclation.OptionName, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Resolves any relatively pathed filename.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        static string ResolvePath(string filePath)
        {
            if (Path.IsPathRooted(filePath))
                return filePath;

            return Path.GetFullPath(filePath);
        }
    }
}
