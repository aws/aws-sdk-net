using Amazon.CognitoIdentity;
using Amazon.CognitoIdentity.Model;
using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;
using Amazon.Runtime;
using System;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Amazon.DNXCore.IntegrationTests
{
    public class CognitoIdentity : TestBase<AmazonCognitoIdentityClient>
    {
        private readonly ITestOutputHelper output;
        private const string IdentityPoolName = "AWSSDKIntegrationTest";
        private const string UnauthRoleName = "AWSSDKIntegrationTest_Cognito_UnauthRole";

        public CognitoIdentity(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public async Task TestCognitoIdentity()
        {
            var iamClient = UtilityMethods.CreateClient<AmazonIdentityManagementServiceClient>();
            var identityPoolId = await CreateIdentityPoolAsync(iamClient);

            try
            {
                using (var cognitoCreds = new CognitoAWSCredentials(identityPoolId, ActualEndpoint))
                {
                    ImmutableCredentials creds;
                    int attempts = 5;

                    while (true)
                    {
                        --attempts;

                        Task<ImmutableCredentials> task = cognitoCreds.GetCredentialsAsync();

                        var firstCompletedTask = await Task.WhenAny(task, Task.Delay(TimeSpan.FromSeconds(10)));
                        Assert.True(firstCompletedTask == task, "GetCredentialsAsync timed out");

                        try
                        {
                            creds = await task;
                            break;
                        }
                        catch (InvalidIdentityPoolConfigurationException)
                        {
                            Assert.True(attempts > 0, "InvalidIdentityPoolConfigurationException, out of attempts");
                            output.WriteLine("InvalidIdentityPoolConfigurationException, retrying...");
                            await Task.Delay(TimeSpan.FromSeconds(5));
                        }
                    }

                    Assert.False(string.IsNullOrEmpty(creds.AccessKey));
                    output.WriteLine($"AccessKey:{creds.AccessKey}");
                }
            }
            finally
            {
                await Client.DeleteIdentityPoolAsync(identityPoolId);
                await iamClient.DeleteRoleAsync(new DeleteRoleRequest { RoleName = UnauthRoleName });
            }
        }

        private async Task<string> CreateIdentityPoolAsync(AmazonIdentityManagementServiceClient iamClient)
        {
            var createIdentityPoolRequest = new CreateIdentityPoolRequest()
            {
                AllowUnauthenticatedIdentities = true,
                IdentityPoolName = IdentityPoolName,
            };
            var createIdentityPoolResponse = await Client.CreateIdentityPoolAsync(createIdentityPoolRequest);
            string identityPoolId = createIdentityPoolResponse.IdentityPoolId;
            Assert.False(string.IsNullOrEmpty(identityPoolId));
            output.WriteLine($"identityPoolId:{identityPoolId}");

            string roleArn = await CreateUnauthRoleAsync(iamClient, identityPoolId);
            output.WriteLine($"roleArn:{roleArn}");

            SetIdentityPoolRolesRequest setIdentityPoolRolesRequest = new SetIdentityPoolRolesRequest
            {
                IdentityPoolId = identityPoolId,
                Roles = new System.Collections.Generic.Dictionary<string, string>
                {
                    { "unauthenticated", roleArn },
                }
            };
            var setIdentityPoolRolesResponse = await Client.SetIdentityPoolRolesAsync(setIdentityPoolRolesRequest);
            Assert.True(setIdentityPoolRolesResponse.HttpStatusCode == System.Net.HttpStatusCode.OK);

            return identityPoolId;
        }

        private async Task<string> CreateUnauthRoleAsync(AmazonIdentityManagementServiceClient iamClient, string identityPoolId)
        {
            string assumeRolePolicyDocument = $"{{\"Version\":\"2012-10-17\",\"Statement\":[{{\"Effect\":\"Allow\",\"Principal\":{{\"Federated\":\"cognito-identity.amazonaws.com\"}},\"Action\":\"sts:AssumeRoleWithWebIdentity\",\"Condition\":{{\"StringEquals\":{{\"cognito-identity.amazonaws.com:aud\":\"{identityPoolId}\"}},\"ForAnyValue:StringLike\":{{\"cognito-identity.amazonaws.com:amr\":\"unauthenticated\"}}}}}}]}}";

            CreateRoleRequest createRoleRequest = new CreateRoleRequest
            {
                RoleName = UnauthRoleName,
                AssumeRolePolicyDocument = assumeRolePolicyDocument,
            };
            var createRoleResponse = await iamClient.CreateRoleAsync(createRoleRequest);
            string roleArn = createRoleResponse.Role.Arn;
            Assert.False(string.IsNullOrEmpty(roleArn));
            return roleArn;
        }
    }
}
