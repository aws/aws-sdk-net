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
        public void TestDoesNotSkipsCborProtocol()
        {
            var model = GetServiceModel("ModelWithCborAndJson.json");
            Assert.Equal("smithy-rpc-v2-cbor", model.Protocol);
        }

        [Fact]
        public void TestDoesSupportCbor()
        {
            var model = GetServiceModel("ModelWithCborOnly.json");
            Assert.Equal("smithy-rpc-v2-cbor", model.Protocol);
        }

        [Theory]
        [InlineData("ModelWithMultipleProtocols.json", "smithy-rpc-v2-cbor")]
        [InlineData("ModelWithJsonAndQuery.json", "json")]
        public void TestPicksProtocolByPriority(string fileName, string expectedProtocol)
        {
            var model = GetServiceModel(fileName);
            Assert.Equal(expectedProtocol, model.Protocol);
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
