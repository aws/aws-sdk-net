using System.Collections.Generic;
using System.IO;
namespace ServiceClientGenerator
{
    /// <summary>
    /// Command line options for the AWS SDK code generator.
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
        /// The name and location of the json manifest file listing all supported services
        /// for generation. By default this is located in the ServiceModels folder and is
        /// named '_manifests.json'.
        /// </summary>
        public string Manifest { get; set; }

        /// <summary>
        /// The name and location of the json versions file listing the versions of all supported
        /// services for generation. By default this is located in the ServiceModels folder and is
        /// named '_sdk-versions.json'.
        /// </summary>
        public string Versions { get; set; }

        /// <summary>
        /// The location of the folder containing the service model files.
        /// </summary>
        public string ModelsFolder { get; set; }

        /// <summary>
        /// The location of the folder containing the test service model files.
        /// </summary>
        public string TestModelsFolder { get; set; }

        /// <summary>
        /// The location of the folder containing the extension folders.
        /// </summary>
        public string ExtensionsSrcFolder { get; set; }

        /// <summary>
        /// The root folder beneath which the code for the SDK is arranged. Source code exists under
        /// a .\src folder, which is further partitioned into core runtime (.\Core) and service code 
        /// (.\Services). Tests are placed under a .\test folder, which is further partitioned into 
        /// unit tests (.\UnitTests) and integration tests (.\IntegrationTests).
        /// </summary>
        public string SdkRootFolder { get; set; }

        /// <summary>
        /// Collection of one or more service model identifiers. If null or empty, code for all 
        /// services listed in the GenerationManifest file will be generated. If set, only
        /// the services listed will be generated. The value(s) provided need to match the
        /// 'model' values in the service manifest file.
        /// </summary>
        public string ServiceModels { get; set; }

        /// <summary>
        /// Allows disabling orphaned shape and service cleanup.
        /// Useful to set if you a) specify <see cref="ServiceModels"/> and b)
        /// don't want to remove previously generated services.  This is often the case
        /// in a development environment.
        /// </summary>
        public bool SkipRemoveOrphanCleanup { get; set; }

        /// <summary>
        /// If set causes all servicename.customizations*.json files to be 'compiled' into 
        /// one json file during generation.
        /// </summary>
        public bool CompileCustomizations { get; set; }

        /// <summary>
        /// If set, the contents of the generated subfolder hierarchy are deleted prior
        /// to code generation. The default behavior is to leave existing generated
        /// content in-place and perform a cumulative generation pass.
        /// </summary>
        public bool Clean { get; set; }

        /// <summary>
        /// If set the solution files will be rebuilt even if no new projects were added.
        /// </summary>
        public bool ForceSolutionRebuilt { get; set; }

        /// <summary>
        /// If set, the generator will create a vsix (Visual Studio Extension) project and manifest.
        /// This project will reference all of the service specific code analysis projects.
        /// The default behavior is not to create any assets.
        /// </summary>
        public bool CreateCodeAnalysisVsixAssets { get; set; }

        public string SelfServiceModel { get; set; }
        public string SelfServiceBaseName { get; set; }
        public string SelfServiceEndpointPrefix { get; set; }
        public string SelfServiceSigV4Name { get; set; }

        public GeneratorOptions()
        {
            Verbose = false;
            WaitOnExit = false;

            // default paths are relative to executing generator assembly
            // in bin/debug or bin/release
            Manifest = Utils.PathCombineAlt("..", "..", "..", "ServiceModels", "_manifest.json");
            Versions = Utils.PathCombineAlt("..", "..", "..", "ServiceModels", "_sdk-versions.json");
            ModelsFolder = Utils.PathCombineAlt("..", "..", "..", "ServiceModels");
            TestModelsFolder = Utils.PathCombineAlt("..", "..", "..", "TestServiceModels");
            ExtensionsSrcFolder = Utils.PathCombineAlt("..", "..", "..", "..", "extensions", "src");
            SdkRootFolder = Utils.PathCombineAlt("..", "..", "..", "..", "sdk");
            ServiceModels = string.Empty; // process all services
            CompileCustomizations = true;
            Clean = false;
            CreateCodeAnalysisVsixAssets = false;
        }
    }
}
