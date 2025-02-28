using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon;
using Amazon.S3;
using System.Threading.Tasks;
using System.IO;
using Xunit;
using Amazon.DNXCore.IntegrationTests;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;

namespace Amazon.DNXCore.IntegrationTests
{
    [Trait(TestBase.CategoryAttribute, "RequiresIAMUser")]
    public class CredentialsTests
    {
        [Fact]
        [Trait(TestBase.CategoryAttribute,"Credentials")]
        public async Task TestSessionCredentials()
        {
            using (var sts = TestBase.CreateClient<AmazonSecurityTokenServiceClient>())
            {
                AWSCredentials credentials = (await sts.GetSessionTokenAsync()).Credentials;

                using (var ec2 = TestBase.CreateClient < Amazon.EC2.AmazonEC2Client>(credentials))
                {
                    var regions = (await ec2.DescribeRegionsAsync()).Regions;
                    Console.WriteLine(regions.Count);
                }

                using (var s3 = TestBase.CreateClient < Amazon.S3.AmazonS3Client>(credentials))
                {
                    var buckets = (await s3.ListBucketsAsync()).Buckets;
                    Console.WriteLine(buckets.Count);
                }

                using (var swf = TestBase.CreateClient < Amazon.SimpleWorkflow.AmazonSimpleWorkflowClient>(credentials))
                {
                    var domains = (await swf.ListDomainsAsync(new Amazon.SimpleWorkflow.Model.ListDomainsRequest { RegistrationStatus = "REGISTERED" })).DomainInfos;
                    Console.WriteLine(domains.Infos.Count);
                }

                using (var swf = TestBase.CreateClient < Amazon.SimpleWorkflow.AmazonSimpleWorkflowClient>(credentials))
                {
                    var domains = (await swf.ListDomainsAsync(new Amazon.SimpleWorkflow.Model.ListDomainsRequest { RegistrationStatus = "REGISTERED" })).DomainInfos;
                    Console.WriteLine(domains.Infos.Count);
                }
            }
        }

        [Fact]
        [Trait(TestBase.CategoryAttribute, "Credentials")]
        public async Task TestAssumeRoleAWSCredentialsAsyncGet()
        {
            using (var sts = TestBase.CreateClient<AmazonSecurityTokenServiceClient>())
            using (var iam = TestBase.CreateClient<AmazonIdentityManagementServiceClient>())
            {
                var callerIdentity = await sts.GetCallerIdentityAsync(new GetCallerIdentityRequest());

                var roleName = "sdk-testrole-" + DateTime.UtcNow.Ticks;
                var createRoleRequest = new CreateRoleRequest()
                {
                    RoleName = roleName,
                    AssumeRolePolicyDocument = "{\"Version\": \"2012-10-17\", \"Statement\": [{ \"Effect\": \"Allow\",\"Principal\": {\"AWS\": [\"" + callerIdentity.Account + "\"]},\"Action\": \"sts:AssumeRole\",\"Condition\": {}}]}"
                };
                var role = await iam.CreateRoleAsync(createRoleRequest);

                var sourceCredentials = FallbackCredentialsFactory.GetCredentials();

                var assumeRoleAWSCredentials = new AssumeRoleAWSCredentials(sourceCredentials, role.Role.Arn, "dummyRoleSessionName");
                try
                {
                    var credentials = await assumeRoleAWSCredentials.GetCredentialsAsync();
                    Assert.NotNull(credentials);
                }
                finally
                {
                    var deleteRoleRequest = new DeleteRoleRequest() { RoleName = role.Role.RoleName };
                    await iam.DeleteRoleAsync(deleteRoleRequest);
                }
            }
        }
    }
}
