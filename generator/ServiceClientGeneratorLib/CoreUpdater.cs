using ServiceClientGenerator.Generators.NuGet;
using ServiceClientGenerator.Generators.SourceFiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClientGenerator
{
    public class CoreAssemblyInfoUpdater
    {
        public GenerationManifest Manifest { get; private set; }
        public GeneratorOptions Options { get; private set; }

        private Dictionary<string, object> session;
        private static string corePath = Utils.PathCombineAlt("src", "Core");
        private static string assemblyInfoPath = Utils.PathCombineAlt("Properties", "AssemblyInfo.cs");
        private static string internalSdkUtilPath = Utils.PathCombineAlt("Amazon.Util","Internal","InternalSDKUtils.generated.cs");
        private const string nuspecPath = "AWSSDK.Core.nuspec";


        public CoreAssemblyInfoUpdater(GeneratorOptions options, GenerationManifest manifest)
        {
            Manifest = manifest;
            Options = options;

            session = new Dictionary<string, object>
            {
                { "Version", Manifest.CoreVersion },
                { "FileVersion", Manifest.CoreFileVersion }
            };

            session["NuGetPreviewFlag"] = manifest.DefaultToPreview ? manifest.PreviewLabel : "";
        }

        public void Execute()
        {
            UpdateAssemblyVersion();
            UpdateNuspec();
        }

        private void UpdateNuspec()
        {
            var avi = new CoreNuspec { Session = session };
            var text = avi.TransformText();
            GeneratorDriver.WriteFile(
                Options.SdkRootFolder, corePath, nuspecPath, text);
        }

        private void UpdateAssemblyVersion()
        {
            var avi = new CoreAssemblyInfo { Session = session };
            var text = avi.TransformText();
            GeneratorDriver.WriteFile(
                Options.SdkRootFolder, corePath, assemblyInfoPath, text);

            var sdkUtil = new InternalSDKUtils { Session = session };
            var sdkUtilText = sdkUtil.TransformText();
            GeneratorDriver.WriteFile(
                Options.SdkRootFolder, corePath, internalSdkUtilPath, sdkUtilText);
        }
    }
}
