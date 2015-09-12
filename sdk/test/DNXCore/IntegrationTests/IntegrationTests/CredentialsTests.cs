using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon;
using Amazon.S3;
using System.IO;
using Xunit;
using Amazon.DNXCore.IntegrationTests;
using Amazon.SecurityToken;

namespace Amazon.DNXCore.IntegrationTests
{
    
    public class CredentialsTests
    {
        [Fact]
        [Trait(TestBase.CategoryAttribute,"Credentials")]
        public void TestSessionCredentials()
        {
            using (var sts = TestBase.CreateClient<AmazonSecurityTokenServiceClient>())
            {
                AWSCredentials credentials = sts.GetSessionTokenAsync().Result.Credentials;

                var originalS3Signature = AWSConfigsS3.UseSignatureVersion4;
                AWSConfigsS3.UseSignatureVersion4 = true;
                try
                {

                    using (var ec2 = TestBase.CreateClient < Amazon.EC2.AmazonEC2Client>(credentials))
                    {
                        var regions = ec2.DescribeRegionsAsync().Result.Regions;
                        Console.WriteLine(regions.Count);
                    }

                    using (var s3 = TestBase.CreateClient < Amazon.S3.AmazonS3Client>(credentials))
                    {
                        var buckets = s3.ListBucketsAsync().Result.Buckets;
                        Console.WriteLine(buckets.Count);
                    }

                    using (var swf = TestBase.CreateClient < Amazon.SimpleWorkflow.AmazonSimpleWorkflowClient>(credentials))
                    {
                        var domains = swf.ListDomainsAsync(new Amazon.SimpleWorkflow.Model.ListDomainsRequest { RegistrationStatus = "REGISTERED" }).Result.DomainInfos;
                        Console.WriteLine(domains.Infos.Count);
                    }

                    using (var swf = TestBase.CreateClient < Amazon.SimpleWorkflow.AmazonSimpleWorkflowClient>(credentials))
                    {
                        var domains = swf.ListDomainsAsync(new Amazon.SimpleWorkflow.Model.ListDomainsRequest { RegistrationStatus = "REGISTERED" }).Result.DomainInfos;
                        Console.WriteLine(domains.Infos.Count);
                    }
                }
                finally
                {
                    AWSConfigsS3.UseSignatureVersion4 = originalS3Signature;
                }
            }
        }
    }
}
