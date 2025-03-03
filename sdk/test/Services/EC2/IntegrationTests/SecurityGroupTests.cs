using Amazon;
using Amazon.EC2;
using Amazon.EC2.Model;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AWSSDK_DotNet.IntegrationTests.Tests.EC2
{
    [TestClass]
    public class SecurityGroupTests : TestBase<AmazonEC2Client>
    {
        private static readonly string SECURITY_GROUP_NAME = "test-sg";
        private static string SECURITY_GROUP_ID;

        private static readonly Tag DotNetTag = new Tag("purpose", ".NET SDK integ test");

        public SecurityGroupTests()
        {
            var createVpcResponse = Client.CreateVpc(new CreateVpcRequest
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

            UtilityMethods.WaitUntilSuccess(() =>
            {
                var describVpcsResponse = DescribeVpcsByTag();
                if (describVpcsResponse.Vpcs.Count > 0)
                {
                    return;
                }

                throw new Exception("VPC not ready yet, will continue waiting.");
            });

            var createSecurityGroup = Client.CreateSecurityGroup(new CreateSecurityGroupRequest
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

            UtilityMethods.WaitUntilSuccess(() =>
            {
                var describeSecurityGroupsResponse = DescribeSecurityGroupsByTag();
                if (describeSecurityGroupsResponse.SecurityGroups.Count > 0)
                {
                    return;
                }

                throw new Exception("Security Group not ready yet, will continue waiting.");
            });

            SECURITY_GROUP_ID = createSecurityGroup.GroupId;
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            UtilityMethods.WaitUntilSuccess(() =>
            {
                // clean up all .net tagged security groups
                var describeSecurityGroupsResponse = DescribeSecurityGroupsByTag();
                foreach (var group in describeSecurityGroupsResponse.SecurityGroups)
                {
                    Client.DeleteSecurityGroup(new DeleteSecurityGroupRequest
                    {
                        GroupId = group.GroupId
                    });
                }

                // clean up all .net tagged vpcs
                var describVpcsResponse = DescribeVpcsByTag();
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
        [TestCategory("EC2")]
        public void IpRangeRoundTripTest()
        {
#pragma warning disable CS0618
            var describeSecurityGroupsResponse = DescribeSecurityGroupById();

            var testCollection = new List<string>();
            var authorizeSecurityGroupEgressRequest = new AuthorizeSecurityGroupEgressRequest();
            authorizeSecurityGroupEgressRequest.GroupId = SECURITY_GROUP_ID;
            IpPermission authorizeSecurityGroupEgressPermission = new IpPermission()
            {
                Ipv4Ranges = new List<IpRange>
                {
                    new IpRange{ CidrIp = "0.0.0.0/7", Description = "test"}
                }
            };
            testCollection.Add("0.0.0.0/7");
            authorizeSecurityGroupEgressPermission.IpProtocol = "ICMP";
            authorizeSecurityGroupEgressPermission.FromPort = -1;
            authorizeSecurityGroupEgressPermission.ToPort = -1;
            authorizeSecurityGroupEgressRequest.IpPermissions = new List<IpPermission> { authorizeSecurityGroupEgressPermission };
            var authorizeSecurityGroupEgressResponse = Client.AuthorizeSecurityGroupEgress(authorizeSecurityGroupEgressRequest);

            Assert.IsNotNull(authorizeSecurityGroupEgressResponse);

            UtilityMethods.WaitUntilSuccess(() =>
            {
                describeSecurityGroupsResponse = DescribeSecurityGroupById();
            });

            var revokeSecurityGroupEgressRequest = new RevokeSecurityGroupEgressRequest();
            revokeSecurityGroupEgressRequest.GroupId = SECURITY_GROUP_ID;
            revokeSecurityGroupEgressRequest.IpPermissions = new List<IpPermission> { describeSecurityGroupsResponse.SecurityGroups[0].IpPermissionsEgress[1] };
            var revokeSecurityGroupIngressResponse = Client.RevokeSecurityGroupEgress(revokeSecurityGroupEgressRequest);

            Assert.IsNotNull(revokeSecurityGroupIngressResponse);

            UtilityMethods.WaitUntilSuccess(() =>
            {
                describeSecurityGroupsResponse = DescribeSecurityGroupById();
                var ipEgress = describeSecurityGroupsResponse.SecurityGroups[0].IpPermissionsEgress ?? new List<IpPermission>();
                Assert.IsFalse(ipEgress
                    .Where(p => p.Ipv4Ranges != null && (p.Ipv4Ranges.Contains(new IpRange { CidrIp = "0.0.0.0/7", Description = "test" }))).ToList().Any());
            });
        }

        private static DescribeSecurityGroupsResponse DescribeSecurityGroupById()
        {
            var describeSecurityGroupRequest = new DescribeSecurityGroupsRequest
            {
                GroupIds = new List<string> { SECURITY_GROUP_ID }
            };

            return Client.DescribeSecurityGroups(describeSecurityGroupRequest);
        }

        private static DescribeSecurityGroupsResponse DescribeSecurityGroupsByTag()
        {
            var describeSecurityGroupRequest = new DescribeSecurityGroupsRequest
            {
                Filters = new List<Filter>
                {
                    new Filter("tag-value", new List<string> { DotNetTag.Value }),
                }
            };

            return Client.DescribeSecurityGroups(describeSecurityGroupRequest);
        }

        private static DescribeVpcsResponse DescribeVpcsByTag()
        {
            var describeVpcsRequest = new DescribeVpcsRequest
            {
                Filters = new List<Filter>
                {
                    new Filter("tag:" +  DotNetTag.Key, new List<string> { DotNetTag.Value })
                }
            };

            return Client.DescribeVpcs(describeVpcsRequest);
        }
    }
}
