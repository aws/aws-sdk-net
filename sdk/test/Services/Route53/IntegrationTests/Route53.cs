using Amazon;
using Amazon.Route53;
using Amazon.Route53.Model;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    [TestCategory("Route53")]
    public class Route53 : TestBase<AmazonRoute53Client>
    {
        private const string COMMENT = "comment";
        private const string ZONE_NAME = "aws.sdk.com.";

        private static string CALLER_REFERENCE { get { return Guid.NewGuid().ToString(); } }
        private static readonly TimeSpan maxWaitTime = TimeSpan.FromMinutes(5);

        // The ID of the zone we created in this test
        private string createdZoneId;

        // The ID of the change that created our test zone
        private string createdZoneChangeId;

        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
        }

        // Ensures the HostedZone we create during this test is correctly released.
        [TestCleanup]
        public async Task TearDown()
        {
            if (!string.IsNullOrEmpty(createdZoneId))
            {
                try
                {
                    await Client.DeleteHostedZoneAsync(new DeleteHostedZoneRequest { Id = createdZoneId });
                }
                catch { }
            }
        }

        // Runs through a number of the APIs in the Route 53 client to make sure we can
        // correct send requests and unmarshall responses.
        [TestMethod]
        public async Task TestRoute53()
        {
            var listGeoLocationsResponse = await Client.ListGeoLocationsAsync();
            var geoLocations = listGeoLocationsResponse.GeoLocationDetailsList;
            Assert.IsNotNull(geoLocations);
            Assert.AreNotEqual(0, geoLocations.Count);

            CreateHostedZoneRequest createRequest = new CreateHostedZoneRequest
            {
                Name = ZONE_NAME,
                CallerReference = CALLER_REFERENCE,
                HostedZoneConfig = new HostedZoneConfig { Comment = COMMENT }
            };

            // Create Hosted Zone
            var createResponse = await UtilityMethods.WaitUntilSuccessAsync(
                () => Client.CreateHostedZoneAsync(createRequest)
            );
            createdZoneId = createResponse.HostedZone.Id;
            createdZoneChangeId = createResponse.ChangeInfo.Id;

            AssertValidCreatedHostedZone(createResponse.HostedZone);
            AssertValidDelegationSet(createResponse.DelegationSet);
            AssertValidChangeInfo(createResponse.ChangeInfo);
            Assert.IsNotNull(createResponse.Location);

            // Get Hosted Zone
            GetHostedZoneRequest getRequest = new GetHostedZoneRequest { Id = createdZoneId };
            var getHostedZoneResponse = await Client.GetHostedZoneAsync(getRequest);
            AssertValidDelegationSet(getHostedZoneResponse.DelegationSet);
            AssertValidCreatedHostedZone(getHostedZoneResponse.HostedZone);

            // List Hosted Zones
            var listZonesResponse = await Client.ListHostedZonesAsync();
            var hostedZones = listZonesResponse.HostedZones;
            Assert.IsTrue(hostedZones.Count > 0);
            foreach (HostedZone hostedZone in hostedZones)
            {
                Assert.IsNotNull(hostedZone.CallerReference);
                Assert.IsNotNull(hostedZone.Id);
                Assert.IsNotNull(hostedZone.Name);
            }

            // List Resource Record Sets
            var listRecordSetsResponse = await Client.ListResourceRecordSetsAsync(new ListResourceRecordSetsRequest 
            { 
                HostedZoneId = createdZoneId,
                MaxItems = "10" 
            });

            var resourceRecordSets = listRecordSetsResponse.ResourceRecordSets;
            Assert.IsTrue(resourceRecordSets.Count > 0);
            ResourceRecordSet existingResourceRecordSet = resourceRecordSets[0];
            foreach (ResourceRecordSet rrset in resourceRecordSets)
            {
                Assert.IsNotNull(rrset.Name);
                Assert.IsNotNull(rrset.Type);
                Assert.IsNotNull(rrset.TTL);
                Assert.IsTrue(rrset.ResourceRecords.Count > 0);
            }

            // Get Change
            var getChangeResponse = await Client.GetChangeAsync(new GetChangeRequest { Id = createdZoneChangeId });
            ChangeInfo changeInfo = getChangeResponse.ChangeInfo;
            Assert.IsTrue(changeInfo.Id.EndsWith(createdZoneChangeId));
            AssertValidChangeInfo(changeInfo);

            // Change Resource Record Sets
            ResourceRecordSet newResourceRecordSet = new ResourceRecordSet
            {
                Name = ZONE_NAME,
                ResourceRecords = existingResourceRecordSet.ResourceRecords,
                TTL = existingResourceRecordSet.TTL + 100,
                Type = existingResourceRecordSet.Type,
                HealthCheckId = null
            };

            var changeResponse = await Client.ChangeResourceRecordSetsAsync(new ChangeResourceRecordSetsRequest
            {
                HostedZoneId = createdZoneId,
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
            AssertValidChangeInfo(changeInfo);

            // Delete Hosted Zone
            var deleteHostedZoneResult = await Client.DeleteHostedZoneAsync(new DeleteHostedZoneRequest { Id = createdZoneId });
            AssertValidChangeInfo(deleteHostedZoneResult.ChangeInfo);
        }

        [TestMethod]
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
            var createResponse = await Client.CreateHealthCheckAsync(createRequest);
            Assert.IsNotNull(createResponse.HealthCheck.Id);
            Assert.AreEqual(10, createResponse.HealthCheck.HealthCheckConfig.RequestInterval);
            Assert.AreEqual(5, createResponse.HealthCheck.HealthCheckConfig.FailureThreshold);
            string healthCheckId = createResponse.HealthCheck.Id;

            var listResponse = await Client.ListHealthChecksAsync();
            Assert.IsNotNull(listResponse.HealthChecks.FirstOrDefault(x => x.Id == healthCheckId));

            GetHealthCheckStatusResponse status = null;
            var stopTime = DateTime.UtcNow + maxWaitTime;

            while (DateTime.UtcNow < stopTime)
            {
                try
                {
                    status = await Client.GetHealthCheckStatusAsync(new GetHealthCheckStatusRequest
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
            Assert.IsNotNull(status);

            if (status.HealthCheckObservations == null)
            {
                Assert.IsFalse(AWSConfigs.InitializeCollections);
            }
            else
            {
                Assert.IsNotNull(status.HealthCheckObservations);
            }

            var getResponse = await Client.GetHealthCheckAsync(new GetHealthCheckRequest
            {
                HealthCheckId = healthCheckId
            });
            var healthCheck = getResponse.HealthCheck;
            Assert.IsNotNull(healthCheck);
            Assert.IsNotNull(healthCheck.Id);
            Assert.IsNotNull(healthCheck.HealthCheckConfig);

            var listTagsBeforeResponse = await Client.ListTagsForResourceAsync(new ListTagsForResourceRequest
            {
                ResourceType = TagResourceType.Healthcheck,
                ResourceId = healthCheckId
            });
            var tagSet = listTagsBeforeResponse.ResourceTagSet;
            Assert.IsNotNull(tagSet);
            Assert.IsNotNull(tagSet.ResourceId);

            if (AWSConfigs.InitializeCollections)
            {
                Assert.IsNotNull(tagSet.Tags);
                Assert.AreEqual(0, tagSet.Tags.Count);
            }
            else
            {
                Assert.IsNull(tagSet.Tags);
            }

            await Client.ChangeTagsForResourceAsync(new ChangeTagsForResourceRequest
            {
                ResourceType = TagResourceType.Healthcheck,
                ResourceId = healthCheckId,
                AddTags = new List<Tag>
                {
                    new Tag { Key = "Test", Value = "true" }
                }
            });

            var listTagsAfterResponse = await Client.ListTagsForResourceAsync(new ListTagsForResourceRequest
            {
                ResourceType = TagResourceType.Healthcheck,
                ResourceId = healthCheckId
            });
            tagSet = listTagsAfterResponse.ResourceTagSet;
            Assert.IsNotNull(tagSet);
            Assert.IsNotNull(tagSet.ResourceId);
            Assert.IsNotNull(tagSet.ResourceType);
            Assert.IsNotNull(tagSet.Tags);
            Assert.AreEqual(1, tagSet.Tags.Count);
            Assert.AreEqual("Test", tagSet.Tags[0].Key);
            Assert.AreEqual("true", tagSet.Tags[0].Value);

            await Client.DeleteHealthCheckAsync(new DeleteHealthCheckRequest { HealthCheckId = healthCheckId });

            listResponse = await Client.ListHealthChecksAsync();
            if (listResponse.HealthChecks != null)
            {
                Assert.IsNull(listResponse.HealthChecks.FirstOrDefault(x => x.Id == healthCheckId));
            }
        }

        [TestMethod]
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
                    () => Client.CreateHostedZoneAsync(createRequest)
                );
                createdZoneId = createResponse.HostedZone.Id;

                var hostedZoneInfo = await Client.GetHostedZoneAsync(new GetHostedZoneRequest
                {
                    Id = createdZoneId
                });
                Assert.IsNotNull(hostedZoneInfo.VPCs);
                Assert.AreEqual(1, hostedZoneInfo.VPCs.Count);
                Assert.IsTrue(hostedZoneInfo.HostedZone.Config.PrivateZone.Value);

                var associateResponse = await Client.AssociateVPCWithHostedZoneAsync(new AssociateVPCWithHostedZoneRequest
                {
                    VPC = vpc2,
                    Comment = COMMENT,
                    HostedZoneId = createdZoneId
                });
                var changeInfo = associateResponse.ChangeInfo;
                Assert.IsNotNull(changeInfo);
                Assert.IsNotNull(changeInfo.Comment);
                AssertValidChangeInfo(changeInfo);

                hostedZoneInfo = await Client.GetHostedZoneAsync(new GetHostedZoneRequest
                {
                    Id = createdZoneId
                });
                Assert.IsNotNull(hostedZoneInfo.VPCs);
                Assert.AreEqual(2, hostedZoneInfo.VPCs.Count);

                var disassociateResponse = await Client.DisassociateVPCFromHostedZoneAsync(new DisassociateVPCFromHostedZoneRequest
                {
                    HostedZoneId = createdZoneId,
                    VPC = vpc2
                });
                changeInfo = disassociateResponse.ChangeInfo;
                AssertValidChangeInfo(changeInfo);

                hostedZoneInfo = await Client.GetHostedZoneAsync(new GetHostedZoneRequest
                {
                    Id = createdZoneId
                });
                Assert.IsNotNull(hostedZoneInfo.VPCs);
                Assert.AreEqual(1, hostedZoneInfo.VPCs.Count);

                var deleteResponse = await Client.DeleteHostedZoneAsync(new DeleteHostedZoneRequest
                {
                    Id = createdZoneId
                });
                changeInfo = deleteResponse.ChangeInfo;
                AssertValidChangeInfo(changeInfo);
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
            var region = VPCRegion.FindValue(AWSConfigs.RegionEndpoint.SystemName);
            using (var ec2 = new Amazon.EC2.AmazonEC2Client())
            {
                var createResponse = await ec2.CreateVpcAsync(new Amazon.EC2.Model.CreateVpcRequest
                {
                    CidrBlock = "10.0.0.0/16",
                    InstanceTenancy = Amazon.EC2.Tenancy.Default
                });

                return new VPC
                {
                    VPCRegion = region,
                    VPCId = createResponse.Vpc.VpcId
                };
            }
        }

        // Asserts that the specified HostedZone is valid and represents the same
        // HostedZone that we initially created at the very start of this test.        
        private void AssertValidCreatedHostedZone(HostedZone hostedZone)
        {
            Assert.AreEqual(ZONE_NAME, hostedZone.Name);
            Assert.IsNotNull(hostedZone.Id);
            Assert.AreEqual(COMMENT, hostedZone.Config.Comment);
        }

        // Asserts that the specified DelegationSet is valid.                 
        private void AssertValidDelegationSet(DelegationSet delegationSet)
        {
            Assert.IsTrue(delegationSet.NameServers.Count > 0);
            foreach (string server in delegationSet.NameServers)
            {
                Assert.IsNotNull(server);
            }
        }
        
        // Asserts that the specified ChangeInfo is valid.         
        private void AssertValidChangeInfo(ChangeInfo change)
        {
            Assert.IsNotNull(change.Id);
            Assert.IsNotNull(change.Status);
            Assert.IsNotNull(change.SubmittedAt);

            ChangeInfo retrievedChange = Client.GetChange(new GetChangeRequest { Id = change.Id }).ChangeInfo;
            Assert.IsNotNull(retrievedChange);
            Assert.IsNotNull(retrievedChange.Id);
            Assert.IsNotNull(retrievedChange.Status);
            Assert.IsNotNull(retrievedChange.SubmittedAt);
        }
    }
}
