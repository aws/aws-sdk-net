using Amazon.S3;
using Amazon.S3.Model;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class BucketPolicyTests : IClassFixture<S3PublicAclBucketFixture>
    {
        private readonly AmazonS3Client _client;
        private readonly string _bucketName;

        public BucketPolicyTests(S3PublicAclBucketFixture fixture)
        {
            _client = fixture.Client;
            _bucketName = fixture.BucketName;
        }

        [Fact]
        public async Task TestGetBucketPolicyStatus_IsPublic()
        {
            try
            {
                await _client.PutBucketPolicyAsync(new PutBucketPolicyRequest
                {
                    BucketName = _bucketName,
                    Policy = string.Format(@"{{
                        ""Version"":""2012-10-17"",
                        ""Statement"":[
                            {{
                                ""Sid"":""AddPerm"",
                                ""Effect"":""Allow"",
                                ""Principal"": ""*"",
                                ""Action"":[""s3:GetObject""],
                                ""Resource"":[""arn:aws:s3:::{0}/*""]
                            }}
                        ]
                    }}", _bucketName)
                });

                var getResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
                {
                    var res = await _client.GetBucketPolicyStatusAsync(new GetBucketPolicyStatusRequest
                    {
                        BucketName = _bucketName
                    });
                    return res.PolicyStatus?.IsPublic == true ? res : null;
                });
                Assert.Equal(true, getResponse.PolicyStatus.IsPublic);
            }
            finally
            {
                await _client.DeleteBucketPolicyAsync(new DeleteBucketPolicyRequest { BucketName = _bucketName });
            }
        }

        [Fact]
        public async Task TestGetBucketPolicyStatus_IsNotPublic()
        {
            try
            {
                await _client.PutBucketPolicyAsync(new PutBucketPolicyRequest
                {
                    BucketName = _bucketName,
                    Policy = string.Format(
                    @"{{
                        ""Version"":""2012-10-17"",
                        ""Statement"":[
                            {{
                                ""Sid"":""AddPerm"",
                                ""Effect"":""Deny"",
                                ""Principal"": ""*"",
                                ""Action"":[""s3:GetObject""],
                                ""Resource"":[""arn:aws:s3:::{0}/*""]
                            }}
                        ]
                    }}", _bucketName)
                });

                var getResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
                {
                    var res = await _client.GetBucketPolicyStatusAsync(new GetBucketPolicyStatusRequest
                    {
                        BucketName = _bucketName
                    });
                    return res.PolicyStatus?.IsPublic == false ? res : null;
                });
                Assert.Equal(false, getResponse.PolicyStatus.IsPublic);
            }
            finally
            {
                await _client.DeleteBucketPolicyAsync(new DeleteBucketPolicyRequest { BucketName = _bucketName });
            }
        }

        [Fact]
        public async Task TestGetBucketPolicyStatus_PolicyNotSet()
        {
            var exception = await Assert.ThrowsAsync<AmazonS3Exception>(() =>
                _client.GetBucketPolicyStatusAsync(new GetBucketPolicyStatusRequest
                {
                    BucketName = _bucketName
                })
            );

            Assert.Equal("The bucket policy does not exist", exception.Message);
        }
    }
}
