using Amazon.SecretsManager;
using Amazon.SecretsManager.Model;
using Xunit;

namespace AWSSDK.SmokeTests.SecretsManager
{
    [Trait("Category", "SmokeTests")]
    [Trait("Category", "SecretsManager")]
    public class SmokeTest
    {
        IAmazonSecretsManager secretsManagerClient;
        public SmokeTest()
        {
            secretsManagerClient = new AmazonSecretsManagerClient(Amazon.RegionEndpoint.USEast1);
        }

        [Fact]
        public void ListSecretsSmokeTest()
        {
#if BCL
            var response = secretsManagerClient.ListSecrets(new ListSecretsRequest
            {
            });
#elif NETSTANDARD
            var response = secretsManagerClient.ListSecretsAsync(new ListSecretsRequest
            {
            }).Result;
#endif
            Assert.NotNull(response);
        }
    }
}
