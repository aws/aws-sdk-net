using System;
using System.Linq;
using ServiceClientGenerator.DefaultConfiguration;
using ServiceClientGeneratorTests.Utils;
using Should;
using Xunit;

namespace ServiceClientGeneratorTests
{
    [Trait("Category", "UnitTests")]
    public class DefaultConfigurationParserTests
    {
        private readonly DefaultConfigurationParser _defaultConfigurationParser;
        private readonly string _testDefaultConfigurationJson;

        public DefaultConfigurationParserTests()
        {
            _defaultConfigurationParser = new DefaultConfigurationParser();

            _testDefaultConfigurationJson =
                new EmbeddedResourceHelper().LoadContent($"{nameof(ServiceClientGeneratorTests)}.Content.sdk-default-configuration.json");
        }

        [Fact]
        public void ParsesExampleConfigurationFileAndDoesNotThrowException()
        {
            Exception exc = null;
            DefaultConfigurationModel config = null;
            try
            {
                config = _defaultConfigurationParser.Parse(_testDefaultConfigurationJson);
            }
            catch (Exception e)
            {
                exc = e;
            }
            
            exc.ShouldBeNull();
            config.ShouldNotBeNull();
        }

        /// <summary>
        /// The test json file has a value for every property.  This test make sure
        /// the Parser assigns a value to  every property in <see cref="DefaultConfigurationMode"/>.
        /// </summary>
        [Fact]
        public void AllPropertiesHaveAValue()
        {
            var config = _defaultConfigurationParser.Parse(_testDefaultConfigurationJson);

            // only need to check the first Mode
            var mode = config.Modes.First();

            // NOTE: Skip checking enums - they default to 0 anyway

            mode.Documentation.ShouldNotBeEmpty();
            mode.ConnectTimeout.ShouldBeGreaterThan(TimeSpan.Zero);
            mode.HttpRequestTimeout.ShouldBeGreaterThan(TimeSpan.Zero);
            mode.Name.ShouldNotBeEmpty();
            mode.TimeToFirstByteTimeout.ShouldBeGreaterThan(TimeSpan.Zero);
            mode.TlsNegotiationTimeout.ShouldBeGreaterThan(TimeSpan.Zero);
        }

        [Theory]
        [InlineData("Standard")] // replaced 'standard' - validates capitalize single word,
        [InlineData("InRegion")] // replaced 'in-region' - validates capitalize multi word and handle dash,
        public void NormalizesNames(string expectedName)
        {
            var config = _defaultConfigurationParser.Parse(_testDefaultConfigurationJson);

            var names = 
                config
                    .Modes
                    .Select(x => x.Name)
                    .ToArray();

            names.ShouldContain(expectedName);
        }

        /// <summary>
        /// <see cref="SdkDefaultConfigurationJsonDataModel.Documentation.Modes"/> is
        /// the complete list of configuration modes.  A mode does not need any overrides.
        /// <para />
        /// Requires the embedded sdk-default-configuration.json file
        /// to have the following:
        /// <code>
        /// <![CDATA[
        /// "modes": { },
        /// "documentation": {
        ///   "mode-with-no-overrides": ""
        /// ]]>
        /// </code>
        /// </summary>
        [Fact]
        public void IncludesModesWithNoOverrides()
        {
            var config = _defaultConfigurationParser.Parse(_testDefaultConfigurationJson);

            var foundModeWithNoOverride = config.Modes.Any(x => x.Name == "ModeWithNoOverrides");

            foundModeWithNoOverride.ShouldBeTrue();
        }

        /// <summary>
        /// Requires the embedded sdk-default-configuration.json file
        /// to have the following:
        /// <code>
        /// <![CDATA[
        /// "base": {
        ///   "connectTimeoutInMillis": 1100,
        /// },
        /// "modes": {
        ///   "standard": {
        ///     "connectTimeoutInMillis": {
        ///         "multiply": 2.8
        /// ]]>
        /// </code>
        /// </summary>
        [Fact]
        public void MultiplyOperationTest()
        {
            var config = _defaultConfigurationParser.Parse(_testDefaultConfigurationJson);

            config.Modes
                .First(x => x.Name == "Standard")
                .ConnectTimeout
                .Value
                .TotalMilliseconds
                .ShouldEqual(1100 * 2.8);
        }

        /// <summary>
        /// Requires the embedded sdk-default-configuration.json file
        /// to have the following:
        /// <code>
        /// <![CDATA[
        /// "base": {
        ///   "connectTimeoutInMillis": 1100,
        /// },
        /// "modes": {
        ///   "add-test": {
        ///     "connectTimeoutInMillis": {
        ///         "add": 42
        /// ]]>
        /// </code>
        /// </summary>
        [Fact]
        public void AddOperationTest()
        {
            var config = _defaultConfigurationParser.Parse(_testDefaultConfigurationJson);

            config.Modes
                .First(x => x.Name == "AddTest")
                .ConnectTimeout
                .Value
                .TotalMilliseconds
                .ShouldEqual(1100 + 42);
        }

        /// <summary>
        /// Requires the embedded sdk-default-configuration.json file
        /// to have the following:
        /// <code>
        /// <![CDATA[
        /// "base": {
        ///   "connectTimeoutInMillis": 1100,
        /// },
        /// "modes": {
        ///   "mobile": {
        ///     "connectTimeoutInMillis": {
        ///         "override": 10000
        /// ]]>
        /// </code>
        /// </summary>
        [Fact]
        public void OverrideNumberOperationTest()
        {
            var config = _defaultConfigurationParser.Parse(_testDefaultConfigurationJson);

            config.Modes
                .First(x => x.Name == "Mobile")
                .ConnectTimeout
                .Value
                .TotalMilliseconds
                .ShouldEqual(10000);
        }

        /// <summary>
        /// Requires the embedded sdk-default-configuration.json file
        /// to have the following:
        /// <code>
        /// <![CDATA[
        /// "base": {
        ///   "retryMode": "standard",
        /// },
        /// "modes": {
        ///   "override-enum-test": {
        ///     "retryMode": {
        ///         "override": "adaptive"
        /// ]]>
        /// </code>
        /// </summary>
        [Fact]
        public void OverrideEnumOperationTest()
        {
            var config = _defaultConfigurationParser.Parse(_testDefaultConfigurationJson);

            config.Modes
                .First(x => x.Name == "OverrideEnumTest")
                .RetryMode
                .ShouldEqual(RequestRetryMode.Adaptive);
        }
    }
}