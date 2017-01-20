using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Amazon.IdentityManagement.Model;
using Amazon.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.EC2;
using Amazon.EC2.Model;

using AWSSDK_DotNet.IntegrationTests.Utils;

namespace AWSSDK_DotNet.IntegrationTests.Tests.EC2
{
    [TestClass]
    public class TaggingTests : TestBase<AmazonEC2Client>
    {
        private const string tagName = "DotNetNullTestTag";
        [TestMethod]
        [TestCategory("EC2")]
        public void TestNullTags()
        {
            var vpcId = Client.CreateVpc(new CreateVpcRequest
            {
                CidrBlock = "10.0.0.0/16",
                InstanceTenancy = Tenancy.Default
            }).Vpc.VpcId;

            // Wait to make sure VPC exists
            Thread.Sleep(2000);
            try
            {
                Client.CreateTags(new CreateTagsRequest
                {
                    Resources = new List<string> { vpcId },
                    Tags = new List<Tag>
                {
                    new Tag(tagName, "")
                }
                });

                var tagDescriptions = Client.DescribeTags(new DescribeTagsRequest
                {
                    Filters = new List<Filter>
                    {
                        new Filter("resource-id", new List<string> { vpcId })
                    }
                }).Tags;
                TagDescription newTag = null;
                foreach (var tag in tagDescriptions)
                    if (tag.Key == tagName)
                        newTag = tag;

                Assert.IsNotNull(newTag);
                Assert.IsTrue(string.IsNullOrEmpty(newTag.Value));

                var tags = tagDescriptions
                    .Select(td => new Tag(td.Key, td.Value ?? ""))
                    .ToList();
                Client.CreateTags(new CreateTagsRequest
                {
                    Resources = new List<string> { vpcId },
                    Tags = tags
                });

                tags = tagDescriptions
                    .Select(td => new Tag(td.Key, td.Value))
                    .ToList();
                Client.CreateTags(new CreateTagsRequest
                {
                    Resources = new List<string> { vpcId },
                    Tags = tags
                });
            }
            finally
            {
                Client.DeleteVpc(new DeleteVpcRequest
                {
                    VpcId = vpcId
                });
            }
        }
    }
}
