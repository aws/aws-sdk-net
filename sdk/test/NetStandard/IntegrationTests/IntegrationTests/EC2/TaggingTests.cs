using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Amazon.IdentityManagement.Model;
using Amazon.Runtime;
using Xunit;

using Amazon.EC2;
using Amazon.EC2.Model;

namespace Amazon.DNXCore.IntegrationTests.EC2
{
    
    public class TaggingTests : TestBase<AmazonEC2Client>
    {
        private const string tagName = "DotNetNullTestTag";
        [Fact]
        public async Task TestNullTags()
        {
            var vpcId = (await Client.CreateVpcAsync(new CreateVpcRequest
            {
                CidrBlock = "10.0.0.0/16",
                InstanceTenancy = Tenancy.Default
            })).Vpc.VpcId;

            try
            {
                await Client.CreateTagsAsync(new CreateTagsRequest
                {
                    Resources = new List<string> { vpcId },
                    Tags = new List<Amazon.EC2.Model.Tag>
                    {
                        new Amazon.EC2.Model.Tag(tagName, "")
                    }
                });

                var tagDescriptions = (await Client.DescribeTagsAsync(new DescribeTagsRequest
                {
                    Filters = new List<Filter>
                    {
                        new Filter("resource-id", new List<string> { vpcId })
                    }
                })).Tags;
                TagDescription newTag = null;
                foreach (var tag in tagDescriptions)
                    if (tag.Key == tagName)
                        newTag = tag;

                Assert.NotNull(newTag);
                Assert.True(string.IsNullOrEmpty(newTag.Value));

                var tags = tagDescriptions
                    .Select(td => new Amazon.EC2.Model.Tag(td.Key, td.Value ?? ""))
                    .ToList();
                await Client.CreateTagsAsync(new CreateTagsRequest
                {
                    Resources = new List<string> { vpcId },
                    Tags = tags
                });

                tags = tagDescriptions
                    .Select(td => new Amazon.EC2.Model.Tag(td.Key, td.Value))
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
