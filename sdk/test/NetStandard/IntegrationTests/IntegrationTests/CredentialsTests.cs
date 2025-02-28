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
    }
}
