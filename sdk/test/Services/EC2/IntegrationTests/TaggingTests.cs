using Amazon.EC2;
using Amazon.EC2.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.EC2
{
    [Trait("Category", "EC2")]
    public class TaggingTests : IClassFixture<EC2ClientFixture>
    {
        private const string tagName = "DotNetNullTestTag";
        private readonly AmazonEC2Client _client;

        public TaggingTests(EC2ClientFixture fixture)
        {
            _client = fixture.Client;
        }

        [Fact]
        public async Task TestNullTags()
        {
            var createResponse = await _client.CreateVpcAsync(new CreateVpcRequest
            {
                CidrBlock = "10.0.0.0/16",
                InstanceTenancy = Tenancy.Default
            });

            // Wait to make sure VPC exists
            var vpcId = createResponse.Vpc.VpcId;
            await Task.Delay(2000);

            try
            {
                await _client.CreateTagsAsync(new CreateTagsRequest
                {
                    Resources = new List<string> { vpcId },
                    Tags = new List<Tag>
                    {
                        new Tag(tagName, "")
                    }
                });

                var describeTagsResponse = await _client.DescribeTagsAsync(new DescribeTagsRequest
                {
                    Filters = new List<Filter>
                    {
                        new Filter("resource-id", new List<string> { vpcId })
                    }
                });

                var tagDescriptions = describeTagsResponse.Tags;
                TagDescription newTag = null;

                foreach (var tag in tagDescriptions)
                {
                    if (tag.Key == tagName)
                    {
                        newTag = tag;
                    }
                }

                Assert.NotNull(newTag);
                Assert.True(string.IsNullOrEmpty(newTag.Value));

                var tags = tagDescriptions
                    .Select(td => new Tag(td.Key, td.Value ?? ""))
                    .ToList();
                await _client.CreateTagsAsync(new CreateTagsRequest
                {
                    Resources = new List<string> { vpcId },
                    Tags = tags
                });

                tags = tagDescriptions
                    .Select(td => new Tag(td.Key, td.Value))
                    .ToList();
                await _client.CreateTagsAsync(new CreateTagsRequest
                {
                    Resources = new List<string> { vpcId },
                    Tags = tags
                });
            }
            finally
            {
                await _client.DeleteVpcAsync(new DeleteVpcRequest
                {
                    VpcId = vpcId
                });
            }
        }
    }
}
