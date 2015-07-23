using System.IO;

namespace SDKDocGenerator
{
    /// <summary>
    /// Command line options for the AWS SDK for .NET documentation generator
    /// </summary>
    public class GeneratorOptions
    {
        /// <summary>
        /// If set, causes the generator to emit additional diagnostic messages 
        /// whilst running.
        /// </summary>
        public bool Verbose { get; set; }

        /// <summary>
        /// If set, waits for keypress before exiting generation.
        /// </summary>
        public bool WaitOnExit { get; set; }

        /// <summary>
        /// If set, the contents of the generated subfolder hierarchy are deleted prior
        /// to code generation. The default behavior is to leave existing generated
        /// content in-place and perform a cumulative generation pass.
        /// </summary>
        public bool Clean { get; set; }

        /// <summary>
        /// If set, the generator runs against a predefined set of assemblies to
        /// generate a documentation subset. Use this mode when working on the generator
        /// code to test changes.
        /// </summary>
        public bool TestMode { get; set; }

        /// <summary>
        /// If set the static content forming the docset framework is also generated into
        /// the output folder. To generate framework only, and no service documentation,
        /// use this switch and omit -AssembliesFolder.
        /// </summary>
        public bool WriteStaticContent { get; set; }

        /// <summary>
        /// The root folder containing the per-platform subfolders of SDK assemblies.
        /// </summary>
        public string SDKAssembliesRoot { get; set; }

        /// <summary>
        /// The path to _sdk-versions.json
        /// </summary>
        string _sdkVersionFilePath;
        public string SDKVersionFilePath 
        {
            get 
            {
                if (string.IsNullOrWhiteSpace(this._sdkVersionFilePath))
                    return Path.Combine(Directory.GetParent(this.SDKAssembliesRoot).FullName, "_sdk-versions.json");
                return this._sdkVersionFilePath;
            }
            set { this._sdkVersionFilePath = value; }
        }

        /// <summary>
        /// The platform subfolder considered to be hosting the primary source of
        /// assemblies for doc generation. If not specified, we attempt to use 'net45'.
        /// If that subfolder platform does not exist, we'll use the first subfolder 
        /// under the SDKAssembliesRoot that we find.
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// The names of one or more services to limit the generation to. If not specified
        /// all assemblies matching the SDK naming pattern with SDKAssembliesRoot\PrimaryPlatform
        /// are used.
        /// </summary>
        public string[] Services { get; set; }

        /// <summary>
        /// The root folder beneath which the generated documentation will be placed.
        /// </summary>
        public string OutputFolder { get; set; }

        /// <summary>
        /// The subfolder where the dynamically generated content is placed (beneath
        /// output root). This defaults to "items".
        /// </summary>
        public string ContentSubFolderName { get; set; }

        /// <summary>
        /// Custom BJS region documentation domain - we should generalize this
        /// </summary>
        public string BJSDocsDomain { get; set; }

        /// <summary>
        /// The root folder containing SDK code samples
        /// </summary>
        public string CodeSamplesRootFolder { get; set; }

        /// <summary>
        /// Returns the concatenation of the output folder and the content subfolder
        /// </summary>
        public string ComputedContentFolder
        {
            get { return Path.Combine(OutputFolder, ContentSubFolderName); }
        }

        /// <summary>
        /// Constructs default options for the generator, which are to process
        /// all services found for the .Net 4.5 platform, and emit the doc 
        /// framework static content files. The default paths are relative to 
        /// the executing generator assembly.
        /// </summary>
        public GeneratorOptions()
        {
            Verbose = false;

            WriteStaticContent = true;

            // we don't default the sdk assembly root, as it can
            // change between invoking from within Visual Studio
            // or via our build scripts
            Platform = "net45";
            Services = new [] { "*" };
            OutputFolder = @"..\..\..\..\Deployment\docs";
            ContentSubFolderName = "items";

            BJSDocsDomain = "docs.amazonaws.cn";
        }
    }
}
