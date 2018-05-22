using Amazon.Extensions.NETCore.Setup;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace Configuration.AWSSystemsManagerTests
{
    public class AWSSystemsManagerConfigurationSourceTests
    {
        [Fact]
        public void BuildSuccessTest()
        {
            var source = new AWSSystemsManagerConfigurationSource
            {
                AwsOptions = new AWSOptions(),
                Path = "/temp/"
            };
            var builder = new ConfigurationBuilder();

            var result = source.Build(builder);

            Assert.IsType<AWSSystemsManagerConfigurationProvider>(result);
        }
    }
}
