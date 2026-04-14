using Amazon.EC2;
using Amazon.EC2.Model;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.EC2
{
    /// <summary>
    /// xUnit fixture that creates a VPC and security group once for the lifetime of the
    /// <see cref="SecurityGroupTests"/> class and tears them down afterwards.
    /// </summary>
    public class SecurityGroupFixture : IAsyncLifetime
    {
        private static readonly Tag DotNetTag = new Tag("purpose", ".NET SDK integ test");

        public AmazonEC2Client Client { get; private set; }
        public string SecurityGroupId { get; private set; }

        public async ValueTask InitializeAsync()
        {
            Client = new AmazonEC2Client();
            RetryUtilities.ConfigureClient(Client);

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
                var describeVpcsResponse = await DescribeVpcsByTag(Client);
                if (describeVpcsResponse.Vpcs.Count > 0)
                {
                    return;
                }

                throw new Exception("VPC not ready yet, will continue waiting.");
            });

            var createSecurityGroup = await Client.CreateSecurityGroupAsync(new CreateSecurityGroupRequest
            {
                GroupName = "test-sg",
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
                var describeSecurityGroupsResponse = await DescribeSecurityGroupsByTag(Client);
                if (describeSecurityGroupsResponse.SecurityGroups.Count > 0)
                {
                    return;
                }

                throw new Exception("Security Group not ready yet, will continue waiting.");
            });

            SecurityGroupId = createSecurityGroup.GroupId;
        }

        public async ValueTask DisposeAsync()
        {
            await UtilityMethods.WaitUntilSuccessAsync(async () =>
            {
                // clean up all .net tagged security groups
                var describeSecurityGroupsResponse = await DescribeSecurityGroupsByTag(Client);
                foreach (var group in describeSecurityGroupsResponse.SecurityGroups)
                {
                    await Client.DeleteSecurityGroupAsync(new DeleteSecurityGroupRequest
                    {
                        GroupId = group.GroupId
                    });
                }

                // clean up all .net tagged vpcs
                var describeVpcsResponse = await DescribeVpcsByTag(Client);
                foreach (var vpc in describeVpcsResponse.Vpcs)
                {
                    await Client.DeleteVpcAsync(new DeleteVpcRequest
                    {
                        VpcId = vpc.VpcId
                    });
                }
            });

            Client?.Dispose();
        }

        internal static async Task<DescribeSecurityGroupsResponse> DescribeSecurityGroupsByTag(AmazonEC2Client client)
        {
            var describeSecurityGroupRequest = new DescribeSecurityGroupsRequest
            {
                Filters = new List<Filter>
                {
                    new Filter("tag-value", new List<string> { DotNetTag.Value }),
                }
            };

            return await client.DescribeSecurityGroupsAsync(describeSecurityGroupRequest);
        }

        internal static async Task<DescribeVpcsResponse> DescribeVpcsByTag(AmazonEC2Client client)
        {
            var describeVpcsRequest = new DescribeVpcsRequest
            {
                Filters = new List<Filter>
                {
                    new Filter("tag:" + DotNetTag.Key, new List<string> { DotNetTag.Value })
                }
            };

            return await client.DescribeVpcsAsync(describeVpcsRequest);
        }
    }

    [Trait("Category", "EC2")]
    public class SecurityGroupTests : IClassFixture<SecurityGroupFixture>
    {
        private readonly AmazonEC2Client _client;
        private readonly string _securityGroupId;

        public SecurityGroupTests(SecurityGroupFixture fixture)
        {
            _client = fixture.Client;
            _securityGroupId = fixture.SecurityGroupId;
        }

        /// <summary>
        /// Perform a lifecycle of SecurityGroupEgress requests to test the properties of IpRanges and Ipv4Ranges.
        /// Describe operation is performed at the end of each test to ensure actual behavior matches with the expected output.
        /// 1. A new CidrIp is added using Ipv4Ranges property and a AuthorizeSecurityGroupEgressRequest is made. 
        /// Validation is performed to check the updated values appears on Ipv4Ranges property.
        /// 2. A RevokeSecurityGroupEgressRequest operation is perfomed to remove all the IpPermissions added to the security group.
        /// </summary>
        [Fact]
        public async Task IpRangeRoundTripTest()
        {
            var describeSecurityGroupsResponse = await DescribeSecurityGroupById();

            var testCollection = new List<string>
            {
                "0.0.0.0/7"
            };

            var authorizeSecurityGroupEgressRequest = new AuthorizeSecurityGroupEgressRequest
            {
                GroupId = _securityGroupId
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
            var authorizeSecurityGroupEgressResponse = await _client.AuthorizeSecurityGroupEgressAsync(authorizeSecurityGroupEgressRequest);
            Assert.NotNull(authorizeSecurityGroupEgressResponse);

            await UtilityMethods.WaitUntilSuccessAsync(async () =>
                describeSecurityGroupsResponse = await DescribeSecurityGroupById()
            );

            var revokeSecurityGroupEgressRequest = new RevokeSecurityGroupEgressRequest
            {
                GroupId = _securityGroupId,
                IpPermissions = new List<IpPermission> { describeSecurityGroupsResponse.SecurityGroups[0].IpPermissionsEgress[1] }
            };

            var revokeSecurityGroupIngressResponse = await _client.RevokeSecurityGroupEgressAsync(revokeSecurityGroupEgressRequest);
            Assert.NotNull(revokeSecurityGroupIngressResponse);

            await UtilityMethods.WaitUntilSuccessAsync(async () =>
            {
                describeSecurityGroupsResponse = await DescribeSecurityGroupById();
                var ipEgress = describeSecurityGroupsResponse.SecurityGroups[0].IpPermissionsEgress ?? new List<IpPermission>();
                Assert.False(ipEgress
                    .Where(p => p.Ipv4Ranges != null && p.Ipv4Ranges.Contains(new IpRange { CidrIp = "0.0.0.0/7", Description = "test" }))
                    .ToList()
                    .Any()
                );
            });
        }

        private async Task<DescribeSecurityGroupsResponse> DescribeSecurityGroupById()
        {
            var describeSecurityGroupRequest = new DescribeSecurityGroupsRequest
            {
                GroupIds = new List<string> { _securityGroupId }
            };

            return await _client.DescribeSecurityGroupsAsync(describeSecurityGroupRequest);
        }
    }
}
