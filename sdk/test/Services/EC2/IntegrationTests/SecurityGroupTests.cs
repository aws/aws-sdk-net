using Amazon.EC2;
using Amazon.EC2.Model;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.EC2
{
    [TestClass]
    [TestCategory("EC2")]
    public class SecurityGroupTests : TestBase<AmazonEC2Client>
    {
        private static readonly string SECURITY_GROUP_NAME = "test-sg";
        private static string SECURITY_GROUP_ID;
        private static readonly Tag DotNetTag = new Tag("purpose", ".NET SDK integ test");

        [ClassInitialize]
        public static async Task ClassInitialize(TestContext testContext)
        {
            var createVpcResponse = await Client.CreateVpcAsync(new CreateVpcRequest
            {
                CidrBlock = "10.0.0.0/16",
                TagSpecifications = new List<TagSpecification>
                {
                    new TagSpecification
                    {
                        Tags = new List<Tag> { DotNetTag },
                        ResourceType = ResourceType.Vpc
                    }
                }
            });

            await UtilityMethods.WaitUntilSuccessAsync(async () =>
            {
                var describVpcsResponse = await DescribeVpcsByTag();
                if (describVpcsResponse.Vpcs.Count > 0)
                {
                    return;
                }

                throw new Exception("VPC not ready yet, will continue waiting.");
            });

            var createSecurityGroup = await Client.CreateSecurityGroupAsync(new CreateSecurityGroupRequest
            {
                GroupName = SECURITY_GROUP_NAME,
                Description = "Test security Group",
                VpcId = createVpcResponse.Vpc.VpcId,
                TagSpecifications = new List<TagSpecification>
                {
                    new TagSpecification
                    {
                        Tags = new List<Tag> { DotNetTag },
                        ResourceType = ResourceType.SecurityGroup
                    }
                }
            });

            await UtilityMethods.WaitUntilSuccessAsync(async () =>
            {
                var describeSecurityGroupsResponse = await DescribeSecurityGroupsByTag();
                if (describeSecurityGroupsResponse.SecurityGroups.Count > 0)
                {
                    return;
                }

                throw new Exception("Security Group not ready yet, will continue waiting.");
            });

            SECURITY_GROUP_ID = createSecurityGroup.GroupId;
        }

        [ClassCleanup]
        public static async Task ClassCleanup()
        {
            await UtilityMethods.WaitUntilSuccessAsync(async () =>
            {
                // clean up all .net tagged security groups
                var describeSecurityGroupsResponse = await DescribeSecurityGroupsByTag();
                foreach (var group in describeSecurityGroupsResponse.SecurityGroups)
                {
                    Client.DeleteSecurityGroup(new DeleteSecurityGroupRequest
                    {
                        GroupId = group.GroupId
                    });
                }

                // clean up all .net tagged vpcs
                var describVpcsResponse = await DescribeVpcsByTag();
                foreach (var vpc in describVpcsResponse.Vpcs)
                {
                    Client.DeleteVpc(new DeleteVpcRequest
                    {
                        VpcId = vpc.VpcId
                    });
                }
            });

            BaseClean();
        }

        /// <summary>
        /// Perform a lifecycle of SecurityGroupEgress requests to test the properties of IpRanges and Ipv4Ranges.
        /// Describe operation is performed at the end of each test to ensure actual behavior matches with the expected output.
        /// 1. A new CidrIp is added using Ipv4Ranges property and a AuthorizeSecurityGroupEgressRequest is made. 
        /// Validation is performed to check the updated values appears on Ipv4Ranges property.
        /// 2. A RevokeSecurityGroupEgressRequest operation is perfomed to remove all the IpPermissions added to the security group.
        /// </summary>
        [TestMethod]
        public async Task IpRangeRoundTripTest()
        {
            var describeSecurityGroupsResponse = await DescribeSecurityGroupById();
            
            var testCollection = new List<string>
            {
                "0.0.0.0/7"
            };

            var authorizeSecurityGroupEgressRequest = new AuthorizeSecurityGroupEgressRequest
            {
                GroupId = SECURITY_GROUP_ID
            };

            var authorizeSecurityGroupEgressPermission = new IpPermission
            {
                Ipv4Ranges = new List<IpRange>
                {
                    new IpRange{ CidrIp = "0.0.0.0/7", Description = "test" }
                },
                IpProtocol = "ICMP",
                FromPort = -1,
                ToPort = -1
            };

            authorizeSecurityGroupEgressRequest.IpPermissions = new List<IpPermission> { authorizeSecurityGroupEgressPermission };
            var authorizeSecurityGroupEgressResponse = await Client.AuthorizeSecurityGroupEgressAsync(authorizeSecurityGroupEgressRequest);
            Assert.IsNotNull(authorizeSecurityGroupEgressResponse);

            await UtilityMethods.WaitUntilSuccessAsync(async () =>
                describeSecurityGroupsResponse = await DescribeSecurityGroupById()
            );

            var revokeSecurityGroupEgressRequest = new RevokeSecurityGroupEgressRequest
            {
                GroupId = SECURITY_GROUP_ID,
                IpPermissions = new List<IpPermission> { describeSecurityGroupsResponse.SecurityGroups[0].IpPermissionsEgress[1] }
            };

            var revokeSecurityGroupIngressResponse = await Client.RevokeSecurityGroupEgressAsync(revokeSecurityGroupEgressRequest);
            Assert.IsNotNull(revokeSecurityGroupIngressResponse);

            await UtilityMethods.WaitUntilSuccessAsync(async () =>
            {
                describeSecurityGroupsResponse = await DescribeSecurityGroupById();
                var ipEgress = describeSecurityGroupsResponse.SecurityGroups[0].IpPermissionsEgress ?? new List<IpPermission>();
                Assert.IsFalse(ipEgress
                    .Where(p => p.Ipv4Ranges != null && p.Ipv4Ranges.Contains(new IpRange { CidrIp = "0.0.0.0/7", Description = "test" }))
                    .ToList()
                    .Any()
                );
            });
        }

        private static async Task<DescribeSecurityGroupsResponse> DescribeSecurityGroupById()
        {
            var describeSecurityGroupRequest = new DescribeSecurityGroupsRequest
            {
                GroupIds = new List<string> { SECURITY_GROUP_ID }
            };

            return await Client.DescribeSecurityGroupsAsync(describeSecurityGroupRequest);
        }

        private static async Task<DescribeSecurityGroupsResponse> DescribeSecurityGroupsByTag()
        {
            var describeSecurityGroupRequest = new DescribeSecurityGroupsRequest
            {
                Filters = new List<Filter>
                {
                    new Filter("tag-value", new List<string> { DotNetTag.Value }),
                }
            };
            
            return await Client.DescribeSecurityGroupsAsync(describeSecurityGroupRequest);
        }

        private static async Task<DescribeVpcsResponse> DescribeVpcsByTag()
        {
            var describeVpcsRequest = new DescribeVpcsRequest
            {
                Filters = new List<Filter>
                {
                    new Filter("tag:" +  DotNetTag.Key, new List<string> { DotNetTag.Value })
                }
            };

            return await Client.DescribeVpcsAsync(describeVpcsRequest);
        }
    }
}
