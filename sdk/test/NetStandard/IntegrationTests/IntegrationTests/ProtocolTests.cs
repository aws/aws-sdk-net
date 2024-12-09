using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Amazon.ElasticTranscoder;
using Amazon.ElasticTranscoder.Model;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.SimpleWorkflow;
using Amazon.SimpleWorkflow.Model;
using Amazon.DNXCore.IntegrationTests;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.DNXCore.IntegrationTests
{
    /// <summary>
    /// Test class for testing various AWS protocols.
    /// </summary>
    
    public class ProtocolTests
    {
        //[Fact]
        public void TestJson()
        {
            UtilityMethods.RunAsSync(TestJson_Async);
        }

        private async Task TestJson_Async()
        {
            using (var client = UtilityMethods.CreateClient<AmazonSimpleWorkflowClient>())
            {
                var domainName = "dotnet-test-domain-" + DateTime.UtcNow.ToFileTime();

                await client.RegisterDomainAsync(new RegisterDomainRequest
                {
                    Name = domainName,
                    Description = "Test domain",
                    WorkflowExecutionRetentionPeriodInDays = "5"
                });

                var domains = (await client.ListDomainsAsync(new ListDomainsRequest
                {
                    RegistrationStatus = RegistrationStatus.REGISTERED
                })).DomainInfos;

                Assert.NotNull(domains);
                Assert.NotNull(domains.Infos);
                Assert.NotEmpty(domains.Infos);

                await client.DeprecateDomainAsync(new DeprecateDomainRequest
                {
                    Name = domainName
                });

                var ure = await AssertExtensions.ExpectExceptionAsync<UnknownResourceException>(client.DeprecateDomainAsync(new DeprecateDomainRequest
                {
                    Name = "really-fake-domain-that-should-not-exist" + DateTime.UtcNow.ToFileTime()
                }));
                Assert.NotNull(ure);
                Assert.NotNull(ure.Message);
                Assert.NotNull(ure.ErrorCode);
                Assert.Equal(ErrorType.Unknown, ure.ErrorType);
            }
        }

        [Fact]
        public async Task TestRestXml()
        {
            using (var client = UtilityMethods.CreateClient<AmazonS3Client>())
            {
                var bucketName = await UtilityMethods.CreateBucketAsync(client, "TestRestXml_Async");
                try
                {
                    var buckets = (await client.ListBucketsAsync(new ListBucketsRequest())).Buckets;
                    Assert.NotNull(buckets);
                    Assert.NotEmpty(buckets);
                    Assert.Equal(1, buckets
                        .Count(b =>
                            string.Equals(bucketName, b.BucketName, StringComparison.OrdinalIgnoreCase)));

                    var fakeBucketName = ("really-fake-bucket-that-shout-not-exist" + DateTime.UtcNow.ToFileTime()).ToLower();
                    var as3e = await AssertExtensions.ExpectExceptionAsync<AmazonS3Exception>(client.DeleteBucketAsync(new DeleteBucketRequest
                    {
                        BucketName = fakeBucketName
                    }));
                    Assert.NotNull(as3e);
                    Assert.NotNull(as3e.Message);
                    //Assert.NotNull(aete.ErrorCode);
                    Assert.Equal(ErrorType.Sender, as3e.ErrorType);
                }
                finally
                {
                    await UtilityMethods.DeleteBucketWithObjectsAsync(client, bucketName);
                }
            }
        }
    }
}
