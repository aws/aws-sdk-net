using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AWSSDK_DotNet.IntegrationTests.Utils;
using Amazon.Runtime;
using Amazon;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class CredentialsTests
    {
        [TestMethod]
        [TestCategory("Credentials")]
        public void TestSessionCredentials()
        {
            using (var sts = new Amazon.SecurityToken.AmazonSecurityTokenServiceClient())
            {
                AWSCredentials credentials = sts.GetSessionToken().Credentials;

                var originalEC2Signature = AWSConfigs.EC2Config.UseSignatureVersion4;
                var originalS3Signature = AWSConfigs.S3Config.UseSignatureVersion4;
                AWSConfigs.EC2Config.UseSignatureVersion4 = true;
                AWSConfigs.S3Config.UseSignatureVersion4 = true;
                try
                {

                    using (var ec2 = new Amazon.EC2.AmazonEC2Client(credentials))
                    {
                        var regions = ec2.DescribeRegions().Regions;
                        Console.WriteLine(regions.Count);
                    }

                    using (var s3 = new Amazon.S3.AmazonS3Client(credentials))
                    {
                        var buckets = s3.ListBuckets().Buckets;
                        Console.WriteLine(buckets.Count);
                    }

                    using (var swf = new Amazon.SimpleWorkflow.AmazonSimpleWorkflowClient(credentials))
                    {
                        var domains = swf.ListDomains(new Amazon.SimpleWorkflow.Model.ListDomainsRequest { RegistrationStatus = "REGISTERED" }).DomainInfos;
                        Console.WriteLine(domains.Infos.Count);
                    }

                    using (var swf = new Amazon.SimpleWorkflow.AmazonSimpleWorkflowClient(credentials, new Amazon.SimpleWorkflow.AmazonSimpleWorkflowConfig { SignatureVersion = "4" }))
                    {
                        var domains = swf.ListDomains(new Amazon.SimpleWorkflow.Model.ListDomainsRequest { RegistrationStatus = "REGISTERED" }).DomainInfos;
                        Console.WriteLine(domains.Infos.Count);
                    }
                }
                finally
                {
                    AWSConfigs.EC2Config.UseSignatureVersion4 = originalEC2Signature;
                    AWSConfigs.S3Config.UseSignatureVersion4 = originalS3Signature;
                }
            }
        }
    }
}
