using Amazon.Util.Internal;
using Amazon.Util;
using Xunit;

namespace UnitTests.NetStandard
{
    public class JsonSerializationTests
    {
        [Fact]
        public void DeserializeCaseInsensitive()
        {
            var obj = JsonSerializerHelper.Deserialize<IAMInstanceProfileMetadata>("{\"Code\": \"foo\"}", EC2InstanceMetadataJsonSerializerContexts.Default);
            Assert.Equal("foo", obj.Code);
        }
    }
}
