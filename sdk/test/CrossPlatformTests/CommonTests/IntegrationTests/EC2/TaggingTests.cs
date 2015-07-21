using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Amazon.IdentityManagement.Model;
using Amazon.Runtime;
using NUnit.Framework;
using CommonTests.Framework;

using Amazon.EC2;
using Amazon.EC2.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests.EC2
{
    [TestFixture]
    public class TaggingTests : TestBase<AmazonEC2Client>
    {
        private const string tagName = "DotNetNullTestTag";
        [Test]
        public void TestNullTags()
        {
            var vpcId = Client.CreateVpcAsync(new CreateVpcRequest
            {
                CidrBlock = "10.0.0.0/16",
                InstanceTenancy = Tenancy.Default
            }).Result.Vpc.VpcId;

            try
            {
                Client.CreateTagsAsync(new CreateTagsRequest
                {
                    Resources = new List<string> { vpcId },
                    Tags = new List<Tag>
                    {
                        new Tag(tagName, "")
                    }
                }).Wait();

                var tagDescriptions = Client.DescribeTagsAsync(new DescribeTagsRequest
                {
                    Filters = new List<Filter>
                    {
                        new Filter("resource-id", new List<string> { vpcId })
                    }
                }).Result.Tags;
                TagDescription newTag = null;
                foreach (var tag in tagDescriptions)
                    if (tag.Key == tagName)
                        newTag = tag;

                Assert.IsNotNull(newTag);
                Assert.IsTrue(string.IsNullOrEmpty(newTag.Value));

                var tags = tagDescriptions
                    .Select(td => new Tag(td.Key, td.Value ?? ""))
                    .ToList();
                Client.CreateTagsAsync(new CreateTagsRequest
                {
                    Resources = new List<string> { vpcId },
                    Tags = tags
                }).Wait();

                tags = tagDescriptions
                    .Select(td => new Tag(td.Key, td.Value))
                    .ToList();
                Client.CreateTagsAsync(new CreateTagsRequest
                {
                    Resources = new List<string> { vpcId },
                    Tags = tags
                }).Wait();
            }
            finally
            {
                Client.DeleteVpcAsync(new DeleteVpcRequest
                {
                    VpcId = vpcId
                }).Wait();
            }
        }
    }
}
