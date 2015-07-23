using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKDocGenerator
{
    /// <summary>
    /// Parses the command line into argument settings controlling the documentation
    /// generator.
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
                OptionName = "clean", 
                ShortName = "c", 
                Parse = (arguments, argValue) => arguments.ParsedOptions.Clean = true, 
                HelpText = "Deletes all content in the specified out folder prior to generation.\n"
                            + "The default behavior is to keep existing generated content and overwrite only changed items."
            },
            new ArgDeclaration
            {
                OptionName = "testmode", 
                ShortName = "t", 
                Parse = (arguments, argValue) => arguments.ParsedOptions.TestMode = true, 
                HelpText = "If set, generates a subset of the documentation for a predefined set of assemblies. Use for testing generator code changes."
            },
            new ArgDeclaration
            {
                OptionName = "writestaticcontent", 
                ShortName = "wsc", 
                Parse = (arguments, argValue) => arguments.ParsedOptions.WriteStaticContent = true, 
                HelpText = "If set, also generates the static content of the documentation framework."
            },
            new ArgDeclaration
            {
                OptionName = "sdkassembliesroot", 
                ShortName = "sdk", 
                HasValue = true,
                Parse = (arguments, argValue) => arguments.ParsedOptions.SDKAssembliesRoot = argValue, 
                HelpText = "The folder containing the version info manifest file (_sdk-versions.json) and the built SDK assemblies, organized into per-platform subfolders."
            },
            new ArgDeclaration
            {
                OptionName = "sdkversionfile", 
                ShortName = "sdkversion", 
                HasValue = true,
                Parse = (arguments, argValue) => arguments.ParsedOptions.SDKVersionFilePath = argValue, 
                HelpText = "The path to the _sdk-versions.json."
            },
            new ArgDeclaration
            {
                OptionName = "platform", 
                ShortName = "p", 
                HasValue = true,
                Parse = (arguments, argValue) => arguments.ParsedOptions.Platform = argValue,
                HelpText = "The primary platform subfolder used for assembly discovery, controlling which assemblies get used in doc generation. "
                            + "'net45', or the first available subfolder, is used if not specified."
            },    
            new ArgDeclaration
            {
                OptionName = "services", 
                ShortName = "svc", 
                HasValue = true,
                Parse = (arguments, argValue) => arguments.ParsedOptions.Services = argValue.Split(','), 
                HelpText = "Comma-delimited set of service names to process. If not specified all assemblies within the primary platform folder matching the SDK naming pattern are used."
            },    
            new ArgDeclaration
            {
                OptionName = "samplesfolder", 
                ShortName = "sf", 
                HasValue = true,
                Parse = (arguments, argValue) => arguments.ParsedOptions.CodeSamplesRootFolder = argValue, 
                HelpText = "The root folder containing the SDK code samples."
            },
            new ArgDeclaration
            {
                OptionName = "outputfolder", 
                ShortName = "o", 
                HasValue = true,
                Parse = (arguments, argValue) => arguments.ParsedOptions.OutputFolder = argValue, 
                HelpText = "The root folder beneath which the generated documentation will be placed."
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
