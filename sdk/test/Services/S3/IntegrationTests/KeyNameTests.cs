using Amazon.S3;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using System;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Just a class to ensure customers who try the most awkward names for S3 objects
    /// will be fully satisfied and leave us alone :-)
    /// </summary>
    [Trait("Category", "S3")]
    public class KeyNameTests : IClassFixture<S3BucketFixture>
    {
        private readonly AmazonS3Client _client;
        private readonly string _bucketName;

        public KeyNameTests(S3BucketFixture bucket)
        {
            _client = bucket.Client;
            _bucketName = bucket.BucketName;
        }
                
        [Theory]
        [InlineData(@"ObjectWith!and?\+forgood:measureThis=And&InKeynÄme")]
        [InlineData(@"ObjectWith\InKeyname")]
        [InlineData(@"ObjectWith/InKeyname")]
        [InlineData(@"ObjectWith\InKeynÄme")]
        [InlineData(@"ObjectWith/InKeynÄme")]
        [InlineData(@"ObjectWith$InKeynÄme")]
        [InlineData(@"ObjectWith%2FInKeyname.Ext")]
        [InlineData(@"!@#$%^&*()_+_+!(@#*$)_@[]\/.txt")]
        [InlineData("b204a53f-781a-4cdd-a29c-3626818eb199:115740.pdf")]
        [InlineData("46dbc16e-5f55-4bda-b275-75e2a8ab243c:115740.pdf")]
        public async Task TestKeyNameWithAwkwardChars_AWS4Signing(string baseKeyName)
        {
            var keyName = baseKeyName + ".SigV4.AWS2.CLRv" + Environment.Version;
            await S3TestUtils.PutAndGetObjectTestHelper(_client, _bucketName, keyName);
        }
    }
}
