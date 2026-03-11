using Amazon.EC2;
using Amazon.EC2.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.EC2
{
    [TestClass]
    [TestCategory("EC2")]
    public class TaggingTests : TestBase<AmazonEC2Client>
    {
        private const string tagName = "DotNetNullTestTag";

        [TestMethod]
        public async Task TestNullTags()
        {
            var createResponse = await Client.CreateVpcAsync(new CreateVpcRequest
            {
                CidrBlock = "10.0.0.0/16",
                InstanceTenancy = Tenancy.Default
            });

            // Wait to make sure VPC exists
            var vpcId = createResponse.Vpc.VpcId;
            await Task.Delay(2000);

            try
            {
                await Client.CreateTagsAsync(new CreateTagsRequest
                {
                    Resources = new List<string> { vpcId },
                    Tags = new List<Tag>
                    {
                        new Tag(tagName, "")
                    }
                });

                var describeTagsResponse = await Client.DescribeTagsAsync(new DescribeTagsRequest
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

                Assert.IsNotNull(newTag);
                Assert.IsTrue(string.IsNullOrEmpty(newTag.Value));

                var tags = tagDescriptions
                    .Select(td => new Tag(td.Key, td.Value ?? ""))
                    .ToList();
                await Client.CreateTagsAsync(new CreateTagsRequest
                {
                    Resources = new List<string> { vpcId },
                    Tags = tags
                });

                tags = tagDescriptions
                    .Select(td => new Tag(td.Key, td.Value))
                    .ToList();
                await Client.CreateTagsAsync(new CreateTagsRequest
                {
                    Resources = new List<string> { vpcId },
                    Tags = tags
                });
            }
            finally
            {
                await Client.DeleteVpcAsync(new DeleteVpcRequest
                {
                    VpcId = vpcId
                });
            }
        }
    }
}
