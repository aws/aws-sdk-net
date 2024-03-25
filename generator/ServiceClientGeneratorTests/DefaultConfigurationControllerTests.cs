using System;
using System.Collections.Generic;
using System.Linq;
using Moq;
using ServiceClientGenerator.DefaultConfiguration;
using ServiceClientGeneratorTests.Utils;
using Should;
using Xunit;

namespace ServiceClientGeneratorTests
{
    [Trait("Category", "UnitTests")]
    public class DefaultConfigurationControllerTests
    {
        /// <summary>
        /// Controller should ignore the 'Legacy' Default Configuration Mode.
        /// </summary>
        [Fact]
        public void ControllerIgnoresLegacyDefaultConfigurationMode()
        {
            var fakeJson = "fakeJson";
            var fakeDocumentation = "fakeDocumentation";
            var mockParsedDefaultConfigurationModel = new DefaultConfigurationModel
            {
                Modes = new List<DefaultConfigurationMode>
                {
                    new DefaultConfigurationMode
                    {
                        Name = "Legacy",
                        Documentation = fakeDocumentation,
                        TimeToFirstByteTimeout = TimeSpan.Zero
                    }
                }
            };

            var fakeParser = new Mock<IDefaultConfigurationParser>();
            fakeParser
                .Setup(x => x.Parse(It.Is<string>(j => j == fakeJson)))
                .Returns(mockParsedDefaultConfigurationModel);

            var controller = 
                new DefaultConfigurationController(
                    new FakeFileReader(fakeJson),
                    fakeParser.Object);

            var defaultConfigurationModel = controller.LoadDefaultConfiguration("../path/ignored/by/fake/parser");

            var legacyMode = 
                defaultConfigurationModel
                    .Modes
                    .FirstOrDefault(x => x.Name == "Legacy");

            legacyMode.ShouldBeNull();
        }
    }
}