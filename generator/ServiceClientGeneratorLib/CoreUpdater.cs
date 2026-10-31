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
            session["NumericsVersionRange"] = GetExtensionVersionRange(manifest, NumericsExtensionName);
        }

        // AWSSDK.Core depends on this extension because it provides the BigDecimal type used by the bigDecimal Smithy shape.
        private const string NumericsExtensionName = "Extensions.Numerics";

        /// <summary>
        /// Returns the NuGet version range for an extension that Core depends on, using the same
        /// "[version, nextMajor.0)" format that service packages use for their AWSSDK dependencies.
        /// </summary>
        private static string GetExtensionVersionRange(GenerationManifest manifest, string extensionName)
        {
            var extension = manifest.ExtensionConfigurations.FirstOrDefault(x => string.Equals(x.Name, extensionName, StringComparison.Ordinal));
            if (extension == null || string.IsNullOrEmpty(extension.FileVersion))
            {
                throw new InvalidOperationException($"AWSSDK.Core depends on AWSSDK.{extensionName}, but no version for it was found in the ExtensionVersions section of _sdk-versions.json.");
            }

            var previewFlag = extension.InPreview ? manifest.PreviewLabel : string.Empty;
            var majorVersion = int.Parse(extension.FileVersion.Split('.')[0], System.Globalization.CultureInfo.InvariantCulture);
            return $"[{extension.FileVersion}{previewFlag}, {majorVersion + 1}.0{previewFlag})";
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
