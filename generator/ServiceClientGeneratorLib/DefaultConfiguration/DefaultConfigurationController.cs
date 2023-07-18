using System;
using System.IO;
using System.Linq;

namespace ServiceClientGenerator.DefaultConfiguration
{
    /// <inheritdoc cref="LoadDefaultConfiguration"/>
    public interface IDefaultConfigurationController
    {
        /// <summary>
        /// Fully loads and populates <see cref="DefaultConfigurationModel"/> by parsing the
        /// sdk-default-configurations.json file from disk.  Also adds the 'Legacy'
        /// <see cref="DefaultConfigurationMode"/> with the correct defaults.
        /// </summary>
        /// <param name="repositoryRootDirectoryPath">
        /// Full path to the root directory, ie contains the 'sdk' directory.
        /// </param>
        /// <remarks>
        /// The sdk-default-configuration.json file is placed into the
        /// repository by an upstream process in ServiceBuildAutomation.
        /// </remarks>
        DefaultConfigurationModel LoadDefaultConfiguration(string repositoryRootDirectoryPath);
    }

    /// <inheritdoc cref="IDefaultConfigurationController"/>
    public class DefaultConfigurationController : IDefaultConfigurationController
    {
        private readonly IFileReader _fileReader;
        private readonly IDefaultConfigurationParser _defaultConfigurationParser;

        public DefaultConfigurationController(
            IFileReader fileReader, 
            IDefaultConfigurationParser defaultConfigurationParser)
        {
            _fileReader = fileReader;
            _defaultConfigurationParser = defaultConfigurationParser;
        }

        /// <inheritdoc cref="IDefaultConfigurationController.LoadDefaultConfiguration"/>
        public DefaultConfigurationModel LoadDefaultConfiguration(string repositoryRootDirectoryPath)
        {
            var filePath = Utils.PathCombineAlt(repositoryRootDirectoryPath, "sdk","src","Core","sdk-default-configuration.json");

            string json;
            try
            {
                json = _fileReader.ReadAllText(filePath);
            }
            catch (Exception e)
            {
                throw new Exception($"Error reading Json from [{filePath}]: {e.Message}", e);
            }

            var parsedModel = _defaultConfigurationParser.Parse(json);

            EnrichLegacyMode(parsedModel);

            return parsedModel;
        }

        private void EnrichLegacyMode(DefaultConfigurationModel parsedModel)
        {
            var legacyMode = 
                parsedModel
                    .Modes
                    .FirstOrDefault(x => string.Equals(x.Name, "Legacy", StringComparison.OrdinalIgnoreCase));

            if (legacyMode == null)
                throw new Exception(
                    "Did not find required Default Configuration mode 'Legacy'.  " +
                    $"Found: {string.Join(",", parsedModel.Modes.Select(x => x.Name))}");

            legacyMode.RetryMode = RequestRetryMode.Legacy;
            legacyMode.S3UsEast1RegionalEndpoint = S3UsEast1RegionalEndpointValue.Legacy;
            legacyMode.StsRegionalEndpoints = StsRegionalEndpointsValue.Legacy;
            // default to null for timeouts - this preserves the ServiceConfig
            // behavior of defaulting configurable timeouts to null
            legacyMode.TimeToFirstByteTimeout = null;
            legacyMode.ConnectTimeout = null;
            legacyMode.HttpRequestTimeout = null;
            legacyMode.TlsNegotiationTimeout = null;
        }
    }
}