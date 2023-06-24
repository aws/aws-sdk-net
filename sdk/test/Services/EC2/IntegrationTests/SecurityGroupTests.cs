﻿using Amazon.EC2;
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
        /// 1. A new CidrIp is added using the deprected IpRanges property and a AuthorizeSecurityGroupEgressRequest is made. 
        /// Validation is performed to check the updated values appear on both IpRanges and Ipv4Ranges property.
        /// 2. A new IpRange is added to Ipv4Ranges property and a AuthorizeSecurityGroupEgressRequest is made.
        /// Validation is performed to check the updated values appear on both IpRanges and Ipv4Ranges property.
        /// 3. Different values are set on both IpRanges and Ipv4Ranges and a AuthorizeSecurityGroupEgressRequest is made.
        /// Validation is perfomed to ensure that an ArgumentExcpetions is returned.
        /// 4. A UpdateSecurityGroupRuleDescriptionsEgressRequest is made using the deprecated IpRanges property on a CidrIp for which a description exists.
        /// Validation is perfomed to ensure that the description is not lost.
        /// 5. A RevokeSecurityGroupEgressRequest operation is perfomed to remove all the IpPermissions added to the security group.
        /// </summary>
        [TestMethod]
        [TestCategory("EC2")]
        public void IpRangeRoundTripTest()
        {
            var describeSecurityGroupsResponse = DescribeSecurityGroupById();

            var testCollection = new List<string>();
            var authorizeSecurityGroupEgressRequest = new AuthorizeSecurityGroupEgressRequest();
            authorizeSecurityGroupEgressRequest.GroupId = SECURITY_GROUP_ID;
            IpPermission authorizeSecurityGroupEgressPermission = new IpPermission();
            authorizeSecurityGroupEgressPermission.IpRanges.Add("0.0.0.0/7");
            testCollection.Add("0.0.0.0/7");
            authorizeSecurityGroupEgressPermission.IpProtocol = "ICMP";
            authorizeSecurityGroupEgressPermission.FromPort = -1;
            authorizeSecurityGroupEgressPermission.ToPort = -1;
            authorizeSecurityGroupEgressRequest.IpPermissions = new List<IpPermission> { authorizeSecurityGroupEgressPermission };
            var authorizeSecurityGroupEgressResponse = Client.AuthorizeSecurityGroupEgress(authorizeSecurityGroupEgressRequest);

            Assert.IsNotNull(authorizeSecurityGroupEgressResponse);
            Assert.IsFalse(authorizeSecurityGroupEgressRequest.IpPermissions[0].Ipv4Ranges.Any());
            UtilityMethods.WaitUntilSuccess(() =>
            {
                describeSecurityGroupsResponse = DescribeSecurityGroupById();
                CollectionAssert.AreEqual(describeSecurityGroupsResponse.SecurityGroups[0].IpPermissionsEgress[1].IpRanges, testCollection);
                CollectionAssert.AreEqual(describeSecurityGroupsResponse.SecurityGroups[0].IpPermissionsEgress[1].Ipv4Ranges.Select(p => p.CidrIp).ToList(), testCollection);
            });

            authorizeSecurityGroupEgressRequest = new AuthorizeSecurityGroupEgressRequest();
            authorizeSecurityGroupEgressRequest.GroupId = SECURITY_GROUP_ID;
            describeSecurityGroupsResponse.SecurityGroups[0].IpPermissionsEgress[1].Ipv4Ranges = new List<IpRange> { new IpRange { CidrIp = "0.0.0.0/8", Description = "TestDescription" } };
            testCollection.Add("0.0.0.0/8");
            authorizeSecurityGroupEgressRequest.IpPermissions = new List<IpPermission> { describeSecurityGroupsResponse.SecurityGroups[0].IpPermissionsEgress[1] };
            authorizeSecurityGroupEgressResponse = Client.AuthorizeSecurityGroupEgress(authorizeSecurityGroupEgressRequest);

            var validationResult = new List<string>();
            UtilityMethods.WaitUntilSuccess(() =>
            {
                describeSecurityGroupsResponse = DescribeSecurityGroupById();
                validationResult = describeSecurityGroupsResponse.SecurityGroups[0].IpPermissionsEgress[1].Ipv4Ranges.Select(p => p.CidrIp).ToList();
                CollectionAssert.AreEqual(describeSecurityGroupsResponse.SecurityGroups[0].IpPermissionsEgress[1].IpRanges, testCollection);
                CollectionAssert.AreEqual(describeSecurityGroupsResponse.SecurityGroups[0].IpPermissionsEgress[1].IpRanges, validationResult);
            });

            authorizeSecurityGroupEgressRequest = new AuthorizeSecurityGroupEgressRequest();
            authorizeSecurityGroupEgressRequest.GroupId = SECURITY_GROUP_ID;
            describeSecurityGroupsResponse.SecurityGroups[0].IpPermissionsEgress[1].Ipv4Ranges = new List<IpRange> { new IpRange { CidrIp = "0.0.0.0/9", Description = "TestDescription" } };
            describeSecurityGroupsResponse.SecurityGroups[0].IpPermissionsEgress[1].IpRanges = new List<string> { "0.0.0.0/10" };
            authorizeSecurityGroupEgressRequest.IpPermissions = new List<IpPermission> { describeSecurityGroupsResponse.SecurityGroups[0].IpPermissionsEgress[1] };
            var authorizeSecurityGroupEgressException = Assert.ThrowsException<ArgumentException>(() => Client.AuthorizeSecurityGroupEgress(authorizeSecurityGroupEgressRequest));

            Assert.AreEqual(authorizeSecurityGroupEgressException.Message, "Cannot set values for both Ipv4Ranges and IpRanges properties on the IpPermission type which is part of the request. Consider using only Ipv4Ranges as IpRanges has been marked obsolete.");

            authorizeSecurityGroupEgressRequest = new AuthorizeSecurityGroupEgressRequest();
            authorizeSecurityGroupEgressRequest.GroupId = SECURITY_GROUP_ID;
            describeSecurityGroupsResponse.SecurityGroups[0].IpPermissionsEgress[1].Ipv4Ranges = new List<IpRange> { new IpRange { CidrIp = "0.0.0.0/9", Description = "TestDescription" } };
            describeSecurityGroupsResponse.SecurityGroups[0].IpPermissionsEgress[1].IpRanges = new List<string> { "0.0.0.0/9" };
            testCollection.Add("0.0.0.0/9");
            authorizeSecurityGroupEgressRequest.IpPermissions = new List<IpPermission> { describeSecurityGroupsResponse.SecurityGroups[0].IpPermissionsEgress[1] };
            authorizeSecurityGroupEgressResponse = Client.AuthorizeSecurityGroupEgress(authorizeSecurityGroupEgressRequest);

            UtilityMethods.WaitUntilSuccess(() =>
            {
                describeSecurityGroupsResponse = DescribeSecurityGroupById();
                validationResult = describeSecurityGroupsResponse.SecurityGroups[0].IpPermissionsEgress[1].Ipv4Ranges.Select(p => p.CidrIp).ToList();
                CollectionAssert.AreEqual(describeSecurityGroupsResponse.SecurityGroups[0].IpPermissionsEgress[1].IpRanges, testCollection);
                CollectionAssert.AreEqual(describeSecurityGroupsResponse.SecurityGroups[0].IpPermissionsEgress[1].IpRanges, validationResult);
            });

            authorizeSecurityGroupEgressRequest.IpPermissions[0].Ipv4Ranges = new List<IpRange> { new IpRange { CidrIp = "0.0.0.0/10", Description = "TestDescription" }, new IpRange { CidrIp = "0.0.0.0/11", Description = "TestDescription" } };
            authorizeSecurityGroupEgressRequest.IpPermissions[0].IpRanges = new List<string> { "0.0.0.0/10", "0.0.0.0/11" };
            testCollection.Add("0.0.0.0/10");
            testCollection.Add("0.0.0.0/11");
            authorizeSecurityGroupEgressResponse = Client.AuthorizeSecurityGroupEgress(authorizeSecurityGroupEgressRequest);

            UtilityMethods.WaitUntilSuccess(() =>
            {
                describeSecurityGroupsResponse = DescribeSecurityGroupById();
                validationResult = describeSecurityGroupsResponse.SecurityGroups[0].IpPermissionsEgress[1].Ipv4Ranges.Select(p => p.CidrIp).ToList();
                CollectionAssert.AreEqual(describeSecurityGroupsResponse.SecurityGroups[0].IpPermissionsEgress[1].IpRanges, testCollection);
                CollectionAssert.AreEqual(describeSecurityGroupsResponse.SecurityGroups[0].IpPermissionsEgress[1].IpRanges, validationResult);
            });

            var updateSecurityGroupEgressRequest = new UpdateSecurityGroupRuleDescriptionsEgressRequest();
            updateSecurityGroupEgressRequest.GroupId = SECURITY_GROUP_ID;
            describeSecurityGroupsResponse.SecurityGroups[0].IpPermissionsEgress[1].IpRanges = new List<string> { "0.0.0.0/8" };
            updateSecurityGroupEgressRequest.IpPermissions = new List<IpPermission> { describeSecurityGroupsResponse.SecurityGroups[0].IpPermissionsEgress[1] };
            var updateSecurityGroupEgressResponse = Client.UpdateSecurityGroupRuleDescriptionsEgress(updateSecurityGroupEgressRequest);

            Assert.IsNotNull(updateSecurityGroupEgressResponse);

            UtilityMethods.WaitUntilSuccess(() =>
            {
                describeSecurityGroupsResponse = DescribeSecurityGroupById();
                validationResult = describeSecurityGroupsResponse.SecurityGroups[0].IpPermissionsEgress[1].Ipv4Ranges.Select(p => p.CidrIp).ToList();
                CollectionAssert.AreEqual(describeSecurityGroupsResponse.SecurityGroups[0].IpPermissionsEgress[1].IpRanges, validationResult);

                var descriptionTest = describeSecurityGroupsResponse.SecurityGroups[0].IpPermissionsEgress[1].Ipv4Ranges.Where(p => p.CidrIp == "0.0.0.0/8").Select(p => p.Description).Single().ToString();
                Assert.AreEqual(descriptionTest, "TestDescription");
            });

            var revokeSecurityGroupEgressRequest = new RevokeSecurityGroupEgressRequest();
            revokeSecurityGroupEgressRequest.GroupId = SECURITY_GROUP_ID;
            revokeSecurityGroupEgressRequest.IpPermissions = new List<IpPermission> { describeSecurityGroupsResponse.SecurityGroups[0].IpPermissionsEgress[1] };
            var revokeSecurityGroupIngressResponse = Client.RevokeSecurityGroupEgress(revokeSecurityGroupEgressRequest);

            Assert.IsNotNull(revokeSecurityGroupIngressResponse);

            UtilityMethods.WaitUntilSuccess(() =>
            {
                describeSecurityGroupsResponse = DescribeSecurityGroupById();
                Assert.IsFalse(describeSecurityGroupsResponse.SecurityGroups[0].IpPermissionsEgress
                    .Where(p => p.Ipv4Ranges.Contains(new IpRange { CidrIp = "0.0.0.0/8", Description = "TestDescription" }) || p.Ipv4Ranges.Contains(new IpRange { CidrIp = "0.0.0.0/7" }) || p.IpRanges.Contains("0.0.0.0/7") || p.IpRanges.Contains("0.0.0.0/8")).ToList().Any());
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
