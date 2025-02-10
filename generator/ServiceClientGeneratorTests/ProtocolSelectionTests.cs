using ServiceClientGenerator;
using System;
using System.IO;
using Xunit;

namespace ServiceClientGeneratorTests
{
    [Trait("Category", "UnitTests")]
    public class ProtocolSelectionTests
    {
        [Fact]
        public void TestSkipsCborProtocol()
        {
            var model = GetServiceModel("ModelWithCborAndJson.json");
            Assert.Equal("json", model.Protocol);
        }

        [Fact]
        public void TestDoesNotSupportCbor()
        {
            var model = GetServiceModel("ModelWithCborOnly.json");
            Assert.Equal(string.Empty, model.Protocol);

            var exception = Assert.Throws<Exception>(() => model.Type);
            Assert.Contains("TestService does not support any of the protocols available in the .NET SDK", exception.Message);
        }

        [Theory]
        [InlineData("ModelWithMultipleProtocols.json")]
        [InlineData("ModelWithJsonAndQuery.json")]
        public void TestPicksProtocolByPriority(string fileName)
        {
            var model = GetServiceModel(fileName);
            Assert.Equal("json", model.Protocol);
        }

        [Fact]
        public void TestRespectsLegacyProperty()
        {
            var model = GetServiceModel("ModelWithQueryOnly.json");
            Assert.Equal("query", model.Protocol);
        }

        private static ServiceModel GetServiceModel(string fileName)
        {
            var path = Path.Combine("..", "..", "Content", "Protocols", fileName);
            return new ServiceModel(serviceModelPath: path, customizationModelPath: null);
        }
    }
}
