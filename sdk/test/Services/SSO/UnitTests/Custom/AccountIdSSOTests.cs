using Amazon.Runtime;
using Amazon.SSO;
using Amazon.SSO.Internal;
using Amazon.SSO.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class AccountIdSSOTests
    {
        /// <summary>
        /// When calling Sso::GetCredentials successfully, find account ID in request
        /// SSO:1
        /// </summary>
        [TestMethod]
        public async Task SsoSuccessfulGetCredentialsFindsAccountIdInRequest()
        {
            var mockSsoClient = new Mock<IAmazonSSO>();
            var getRoleCredentialsRequest = new GetRoleCredentialsRequest
            {
                AccountId = "123456789001",
                RoleName = "anything",
                AccessToken = "anything"
            };
            var expectedResponse = new GetRoleCredentialsResponse
            {
                RoleCredentials = new RoleCredentials
                {
                    AccessKeyId = "foo",
                    SecretAccessKey = "bar",
                    SessionToken = "baz"
                }
            };
            mockSsoClient.Setup(client => client.GetRoleCredentialsAsync(It.IsAny<GetRoleCredentialsRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(expectedResponse);

            var credentials = await CoreAmazonSSO.CredentialsFromSsoAccessTokenAsync(
                mockSsoClient.Object,
                getRoleCredentialsRequest.AccountId,
                getRoleCredentialsRequest.RoleName,
                getRoleCredentialsRequest.AccessToken,
                null);

            Assert.AreEqual("123456789001", credentials.AccountId);
            Assert.AreEqual("foo", credentials.AccessKey);
            Assert.AreEqual("bar", credentials.SecretKey);
            Assert.AreEqual("baz", credentials.Token);
        }

        /// <summary>
        /// SSO:2
        /// When calling Sso::GetCredentials unsuccessfully, does not find account ID
        /// </summary>
        [TestMethod]
        public async Task SsoUnsuccessfulCallDoesNotFindAccountIdInRequest()
        {
            var mockSsoClient = new Mock<IAmazonSSO>();
            var getRoleCredentialsRequest = new GetRoleCredentialsRequest
            {
                AccountId = "123456789001",
                RoleName = "anything",
                AccessToken = "anything"
            };
            var expectedResponse = new ResourceNotFoundException("The request resource doesn't exist");
            mockSsoClient.Setup(client => client.GetRoleCredentialsAsync(It.IsAny<GetRoleCredentialsRequest>(), It.IsAny<CancellationToken>())).ThrowsAsync(expectedResponse);
            ImmutableCredentials credentials = null;
            try
            {
                credentials = await CoreAmazonSSO.CredentialsFromSsoAccessTokenAsync(
                    mockSsoClient.Object,
                    getRoleCredentialsRequest.AccountId,
                    getRoleCredentialsRequest.RoleName,
                    getRoleCredentialsRequest.AccessToken,
                    null);
            }
            catch (ResourceNotFoundException e)
            {
                Assert.IsNull(credentials);
                Assert.IsNotNull(e);
            }
        }
    }
}
