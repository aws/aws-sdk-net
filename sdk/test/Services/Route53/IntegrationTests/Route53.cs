using Amazon;
using Amazon.Route53;
using Amazon.Route53.Model;
using Amazon.Runtime;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    /// <summary>
    /// xUnit fixture that owns a single <see cref="AmazonRoute53Client"/> for the lifetime
    /// of the <see cref="Route53Tests"/> class.
    /// </summary>
    public class Route53ClientFixture : IAsyncLifetime
    {
        public AmazonRoute53Client Client { get; private set; }

        public ValueTask InitializeAsync()
        {
            Client = new AmazonRoute53Client();
            RetryUtilities.ConfigureClient(Client);
            return default;
        }

        public ValueTask DisposeAsync()
        {
            Client?.Dispose();
            return default;
        }
    }

    [Trait("Category", "Route53")]
    public class Route53Tests : IClassFixture<Route53ClientFixture>, IAsyncLifetime
    {
        private const string COMMENT = "comment";
        private const string ZONE_NAME = "aws.sdk.com.";

        private static string CALLER_REFERENCE => Guid.NewGuid().ToString();
        private static readonly TimeSpan maxWaitTime = TimeSpan.FromMinutes(5);

        private readonly AmazonRoute53Client _client;

        // The ID of the zone we created in this test — instance field, isolated per test.
        private string _createdZoneId;

        public Route53Tests(Route53ClientFixture fixture)
        {
            _client = fixture.Client;
        }

        public ValueTask InitializeAsync() => default;

        // Ensures the HostedZone we create during this test is correctly released.
        public async ValueTask DisposeAsync()
        {
            if (!string.IsNullOrEmpty(_createdZoneId))
            {
                try
                {
                    await _client.DeleteHostedZoneAsync(new DeleteHostedZoneRequest { Id = _createdZoneId });
                }
                catch { }
            }
        }

        // Runs through a number of the APIs in the Route 53 client to make sure we can
        // correct send requests and unmarshall responses.
        [Fact]
        public async Task TestRoute53()
        {
            var listGeoLocationsResponse = await _client.ListGeoLocationsAsync();
            var geoLocations = listGeoLocationsResponse.GeoLocationDetailsList;
            Assert.NotNull(geoLocations);
            Assert.NotEqual(0, geoLocations.Count);

            CreateHostedZoneRequest createRequest = new CreateHostedZoneRequest
            {
                Name = ZONE_NAME,
                CallerReference = CALLER_REFERENCE,
                HostedZoneConfig = new HostedZoneConfig { Comment = COMMENT }
            };

            // Create Hosted Zone
            var createResponse = await UtilityMethods.WaitUntilSuccessAsync(
                () => _client.CreateHostedZoneAsync(createRequest)
            );
            _createdZoneId = createResponse.HostedZone.Id;
            var createdZoneChangeId = createResponse.ChangeInfo.Id;

            AssertValidCreatedHostedZone(createResponse.HostedZone);
            AssertValidDelegationSet(createResponse.DelegationSet);
            await AssertValidChangeInfo(createResponse.ChangeInfo);
            Assert.NotNull(createResponse.Location);

            // Get Hosted Zone
            GetHostedZoneRequest getRequest = new GetHostedZoneRequest { Id = _createdZoneId };
            var getHostedZoneResponse = await _client.GetHostedZoneAsync(getRequest);
            AssertValidDelegationSet(getHostedZoneResponse.DelegationSet);
            AssertValidCreatedHostedZone(getHostedZoneResponse.HostedZone);

            // List Hosted Zones
            var listZonesResponse = await _client.ListHostedZonesAsync();
            var hostedZones = listZonesResponse.HostedZones;
            Assert.True(hostedZones.Count > 0);
            foreach (HostedZone hostedZone in hostedZones)
            {
                Assert.NotNull(hostedZone.CallerReference);
                Assert.NotNull(hostedZone.Id);
                Assert.NotNull(hostedZone.Name);
            }

            // List Resource Record Sets
            var listRecordSetsResponse = await _client.ListResourceRecordSetsAsync(new ListResourceRecordSetsRequest
            {
                HostedZoneId = _createdZoneId,
                MaxItems = "10"
            });

            var resourceRecordSets = listRecordSetsResponse.ResourceRecordSets;
            Assert.True(resourceRecordSets.Count > 0);
            ResourceRecordSet existingResourceRecordSet = resourceRecordSets[0];
            foreach (ResourceRecordSet rrset in resourceRecordSets)
            {
                Assert.NotNull(rrset.Name);
                Assert.NotNull(rrset.Type);
                Assert.NotNull(rrset.TTL);
                Assert.True(rrset.ResourceRecords.Count > 0);
            }

            // Get Change
            var getChangeResponse = await _client.GetChangeAsync(new GetChangeRequest { Id = createdZoneChangeId });
            ChangeInfo changeInfo = getChangeResponse.ChangeInfo;
            Assert.True(changeInfo.Id.EndsWith(createdZoneChangeId));
            await AssertValidChangeInfo(changeInfo);

            // Change Resource Record Sets
            ResourceRecordSet newResourceRecordSet = new ResourceRecordSet
            {
                Name = ZONE_NAME,
                ResourceRecords = existingResourceRecordSet.ResourceRecords,
                TTL = existingResourceRecordSet.TTL + 100,
                Type = existingResourceRecordSet.Type,
                HealthCheckId = null
            };

            var changeResponse = await _client.ChangeResourceRecordSetsAsync(new ChangeResourceRecordSetsRequest
            {
                HostedZoneId = _createdZoneId,
                ChangeBatch = new ChangeBatch
                {
                    Comment = COMMENT,
                    Changes = new List<Change>
                    {
                        new Change { Action = "DELETE", ResourceRecordSet = existingResourceRecordSet },
                        new Change { Action = "CREATE", ResourceRecordSet = newResourceRecordSet }
                    }
                }
            });

            changeInfo = changeResponse.ChangeInfo;
            await AssertValidChangeInfo(changeInfo);

            // Delete Hosted Zone
            var deleteHostedZoneResult = await _client.DeleteHostedZoneAsync(new DeleteHostedZoneRequest { Id = _createdZoneId });
            await AssertValidChangeInfo(deleteHostedZoneResult.ChangeInfo);
            _createdZoneId = null; // already deleted, no need for DisposeAsync to retry
        }

        [Fact]
        public async Task HealthCheckTests()
        {
            var createRequest = new CreateHealthCheckRequest
            {
                CallerReference = Guid.NewGuid().ToString(),
                HealthCheckConfig = new HealthCheckConfig()
                {
                    Type = "TCP",
                    Port = 22,
                    IPAddress = "12.12.12.12",
                    RequestInterval = 10,
                    FailureThreshold = 5
                }
            };
            var createResponse = await _client.CreateHealthCheckAsync(createRequest);
            Assert.NotNull(createResponse.HealthCheck.Id);
            Assert.Equal(10, createResponse.HealthCheck.HealthCheckConfig.RequestInterval);
            Assert.Equal(5, createResponse.HealthCheck.HealthCheckConfig.FailureThreshold);
            string healthCheckId = createResponse.HealthCheck.Id;

            var listResponse = await _client.ListHealthChecksAsync();
            Assert.NotNull(listResponse.HealthChecks.FirstOrDefault(x => x.Id == healthCheckId));

            GetHealthCheckStatusResponse status = null;
            var stopTime = DateTime.UtcNow + maxWaitTime;

            while (DateTime.UtcNow < stopTime)
            {
                try
                {
                    status = await _client.GetHealthCheckStatusAsync(new GetHealthCheckStatusRequest
                    {
                        HealthCheckId = healthCheckId
                    });
                    break;
                }
                catch (NoSuchHealthCheckException)
                {
                    await Task.Delay(TimeSpan.FromSeconds(10));
                }
            }
            Assert.NotNull(status);

            if (status.HealthCheckObservations == null)
            {
                Assert.False(AWSConfigs.InitializeCollections);
            }
            else
            {
                Assert.NotNull(status.HealthCheckObservations);
            }

            var getResponse = await _client.GetHealthCheckAsync(new GetHealthCheckRequest
            {
                HealthCheckId = healthCheckId
            });
            var healthCheck = getResponse.HealthCheck;
            Assert.NotNull(healthCheck);
            Assert.NotNull(healthCheck.Id);
            Assert.NotNull(healthCheck.HealthCheckConfig);

            var listTagsBeforeResponse = await _client.ListTagsForResourceAsync(new ListTagsForResourceRequest
            {
                ResourceType = TagResourceType.Healthcheck,
                ResourceId = healthCheckId
            });
            var tagSet = listTagsBeforeResponse.ResourceTagSet;
            Assert.NotNull(tagSet);
            Assert.NotNull(tagSet.ResourceId);

            if (AWSConfigs.InitializeCollections)
            {
                Assert.NotNull(tagSet.Tags);
                Assert.Equal(0, tagSet.Tags.Count);
            }
            else
            {
                Assert.Null(tagSet.Tags);
            }

            await _client.ChangeTagsForResourceAsync(new ChangeTagsForResourceRequest
            {
                ResourceType = TagResourceType.Healthcheck,
                ResourceId = healthCheckId,
                AddTags = new List<Tag>
                {
                    new Tag { Key = "Test", Value = "true" }
                }
            });

            var listTagsAfterResponse = await _client.ListTagsForResourceAsync(new ListTagsForResourceRequest
            {
                ResourceType = TagResourceType.Healthcheck,
                ResourceId = healthCheckId
            });
            tagSet = listTagsAfterResponse.ResourceTagSet;
            Assert.NotNull(tagSet);
            Assert.NotNull(tagSet.ResourceId);
            Assert.NotNull(tagSet.ResourceType);
            Assert.NotNull(tagSet.Tags);
            Assert.Single(tagSet.Tags);
            Assert.Equal("Test", tagSet.Tags[0].Key);
            Assert.Equal("true", tagSet.Tags[0].Value);

            await _client.DeleteHealthCheckAsync(new DeleteHealthCheckRequest { HealthCheckId = healthCheckId });

            listResponse = await _client.ListHealthChecksAsync();
            if (listResponse.HealthChecks != null)
            {
                Assert.Null(listResponse.HealthChecks.FirstOrDefault(x => x.Id == healthCheckId));
            }
        }

        [Fact]
        public async Task VPCTests()
        {
            var vpc1 = await CreateVPC();
            var vpc2 = await CreateVPC();

            try
            {
                var createRequest = new CreateHostedZoneRequest
                {
                    Name = ZONE_NAME,
                    CallerReference = CALLER_REFERENCE,
                    HostedZoneConfig = new HostedZoneConfig { Comment = COMMENT },
                    VPC = vpc1
                };

                var createResponse = await UtilityMethods.WaitUntilSuccessAsync(
                    () => _client.CreateHostedZoneAsync(createRequest)
                );
                _createdZoneId = createResponse.HostedZone.Id;

                var hostedZoneInfo = await _client.GetHostedZoneAsync(new GetHostedZoneRequest
                {
                    Id = _createdZoneId
                });
                Assert.NotNull(hostedZoneInfo.VPCs);
                Assert.Single(hostedZoneInfo.VPCs);
                Assert.True(hostedZoneInfo.HostedZone.Config.PrivateZone.Value);

                var associateResponse = await _client.AssociateVPCWithHostedZoneAsync(new AssociateVPCWithHostedZoneRequest
                {
                    VPC = vpc2,
                    Comment = COMMENT,
                    HostedZoneId = _createdZoneId
                });
                var changeInfo = associateResponse.ChangeInfo;
                Assert.NotNull(changeInfo);
                Assert.NotNull(changeInfo.Comment);
                await AssertValidChangeInfo(changeInfo);

                hostedZoneInfo = await _client.GetHostedZoneAsync(new GetHostedZoneRequest
                {
                    Id = _createdZoneId
                });
                Assert.NotNull(hostedZoneInfo.VPCs);
                Assert.Equal(2, hostedZoneInfo.VPCs.Count);

                var disassociateResponse = await _client.DisassociateVPCFromHostedZoneAsync(new DisassociateVPCFromHostedZoneRequest
                {
                    HostedZoneId = _createdZoneId,
                    VPC = vpc2
                });
                changeInfo = disassociateResponse.ChangeInfo;
                await AssertValidChangeInfo(changeInfo);

                hostedZoneInfo = await _client.GetHostedZoneAsync(new GetHostedZoneRequest
                {
                    Id = _createdZoneId
                });
                Assert.NotNull(hostedZoneInfo.VPCs);
                Assert.Single(hostedZoneInfo.VPCs);

                var deleteResponse = await _client.DeleteHostedZoneAsync(new DeleteHostedZoneRequest
                {
                    Id = _createdZoneId
                });
                changeInfo = deleteResponse.ChangeInfo;
                await AssertValidChangeInfo(changeInfo);
                _createdZoneId = null; // already deleted
            }
            finally
            {
                await DeleteVPC(vpc1);
                await DeleteVPC(vpc2);
            }
        }

        private async Task DeleteVPC(VPC vpc)
        {
            using (var ec2 = new Amazon.EC2.AmazonEC2Client())
            {
                await ec2.DeleteVpcAsync(new Amazon.EC2.Model.DeleteVpcRequest
                {
                    VpcId = vpc.VPCId
                });
            }
        }

        private async Task<VPC> CreateVPC()
        {
            var region = AWSConfigs.RegionEndpoint ?? FallbackRegionFactory.GetRegionEndpoint();
            using (var ec2 = new Amazon.EC2.AmazonEC2Client())
            {
                var createResponse = await ec2.CreateVpcAsync(new Amazon.EC2.Model.CreateVpcRequest
                {
                    CidrBlock = "10.0.0.0/16",
                    InstanceTenancy = Amazon.EC2.Tenancy.Default
                });

                return new VPC
                {
                    VPCRegion = VPCRegion.FindValue(region.SystemName),
                    VPCId = createResponse.Vpc.VpcId
                };
            }
        }

        // Asserts that the specified HostedZone is valid and represents the same
        // HostedZone that we initially created at the very start of this test.
        private void AssertValidCreatedHostedZone(HostedZone hostedZone)
        {
            Assert.Equal(ZONE_NAME, hostedZone.Name);
            Assert.NotNull(hostedZone.Id);
            Assert.Equal(COMMENT, hostedZone.Config.Comment);
        }

        // Asserts that the specified DelegationSet is valid.
        private void AssertValidDelegationSet(DelegationSet delegationSet)
        {
            Assert.True(delegationSet.NameServers.Count > 0);
            foreach (string server in delegationSet.NameServers)
            {
                Assert.NotNull(server);
            }
        }

        // Asserts that the specified ChangeInfo is valid.
        private async Task AssertValidChangeInfo(ChangeInfo change)
        {
            Assert.NotNull(change.Id);
            Assert.NotNull(change.Status);
            Assert.NotNull(change.SubmittedAt);

            ChangeInfo retrievedChange = (await _client.GetChangeAsync(new GetChangeRequest { Id = change.Id })).ChangeInfo;
            Assert.NotNull(retrievedChange);
            Assert.NotNull(retrievedChange.Id);
            Assert.NotNull(retrievedChange.Status);
            Assert.NotNull(retrievedChange.SubmittedAt);
        }
    }
}
