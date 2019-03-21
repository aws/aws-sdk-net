
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Route53;
using Amazon.Route53.Model;
using System.Threading;
using Amazon;
using Xunit;
using Amazon.DNXCore.IntegrationTests;


namespace Amazon.DNXCore.IntegrationTests
{
    
    public class Route53 : TestBase<AmazonRoute53Client>
    {
        private const string COMMENT = "comment";
        private const string ZONE_NAME = "aws.sdk.com.";
        private static string CALLER_REFERENCE { get { return Guid.NewGuid().ToString(); } }
        private static TimeSpan pollingPeriod = TimeSpan.FromSeconds(30);
        private static TimeSpan maxWaitTime = TimeSpan.FromMinutes(5);

        // The ID of the zone we created in this test
        //private string createdZoneId;

        // The ID of the change that created our test zone
        //private string createdZoneChangeId;
                
        //// Ensures the HostedZone we create during this test is correctly released.
        //[TearDown]
        //public void TearDown()
        //{
        //    if (!string.IsNullOrEmpty(createdZoneId))
        //    {
        //        try
        //        {
        //            Client.DeleteHostedZoneAsync(new DeleteHostedZoneRequest { Id = createdZoneId }).Wait();
        //        }
        //        catch { }
        //    }
        //}

        async Task DeleteHostedZone(string hostedZoneId)
        {
            if (!string.IsNullOrEmpty(hostedZoneId))
            {
                try
                {
                    await Client.DeleteHostedZoneAsync(new DeleteHostedZoneRequest { Id = hostedZoneId });
                }
                catch { }
            }
        }

        // Runs through a number of the APIs in the Route 53 client to make sure we can
        // correct send requests and unmarshall responses.
        [Fact]
        [Trait(CategoryAttribute,"Route53")]
        public async Task TestRoute53()
        {
            string createdZoneId = null;
            try
            {
                var geoLocations = (await Client.ListGeoLocationsAsync()).GeoLocationDetailsList;
                Assert.NotNull(geoLocations);
                Assert.NotEqual(0, geoLocations.Count);

                CreateHostedZoneRequest createRequest = new CreateHostedZoneRequest
                {
                    Name = ZONE_NAME,
                    CallerReference = CALLER_REFERENCE,
                    HostedZoneConfig = new HostedZoneConfig { Comment = COMMENT }
                };
                // Create Hosted Zone

                var createResponse = await Client.CreateHostedZoneAsync(createRequest);

                createdZoneId = createResponse.HostedZone.Id;
                var createdZoneChangeId = createResponse.ChangeInfo.Id;

                assertValidCreatedHostedZone(createResponse.HostedZone);
                assertValidDelegationSet(createResponse.DelegationSet);
                assertValidChangeInfo(createResponse.ChangeInfo);
                Assert.NotNull(createResponse.Location);

                // Get Hosted Zone
                GetHostedZoneRequest getRequest = new GetHostedZoneRequest { Id = createdZoneId };
                var getHostedZoneResponse = await Client.GetHostedZoneAsync(getRequest);
                assertValidDelegationSet(getHostedZoneResponse.DelegationSet);
                assertValidCreatedHostedZone(getHostedZoneResponse.HostedZone);

                // List Hosted Zones
                List<HostedZone> hostedZones = (await Client.ListHostedZonesAsync()).HostedZones;
                Assert.True(hostedZones.Count > 0);
                foreach (HostedZone hostedZone in hostedZones)
                {
                    Assert.NotNull(hostedZone.CallerReference);
                    Assert.NotNull(hostedZone.Id);
                    Assert.NotNull(hostedZone.Name);
                }

                // List Resource Record Sets
                ListResourceRecordSetsRequest listRequest = new ListResourceRecordSetsRequest { HostedZoneId = createdZoneId, MaxItems = "10" };
                List<ResourceRecordSet> resourceRecordSets = (await Client.ListResourceRecordSetsAsync(listRequest)).ResourceRecordSets;

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
                ChangeInfo changeInfo = (await Client.GetChangeAsync(new GetChangeRequest { Id = createdZoneChangeId })).ChangeInfo;
                Assert.True(changeInfo.Id.EndsWith(createdZoneChangeId));
                assertValidChangeInfo(changeInfo);


                // Change Resource Record Sets
                ResourceRecordSet newResourceRecordSet = new ResourceRecordSet
                {
                    Name = ZONE_NAME,
                    ResourceRecords = existingResourceRecordSet.ResourceRecords,
                    TTL = existingResourceRecordSet.TTL + 100,
                    Type = existingResourceRecordSet.Type,
                    HealthCheckId = null
                };

                changeInfo = (await Client.ChangeResourceRecordSetsAsync(new ChangeResourceRecordSetsRequest
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
                })).ChangeInfo;

                assertValidChangeInfo(changeInfo);

                // Delete Hosted Zone
                var deleteHostedZoneResult = await Client.DeleteHostedZoneAsync(new DeleteHostedZoneRequest { Id = createdZoneId });
                assertValidChangeInfo(deleteHostedZoneResult.ChangeInfo);
            }
            finally
            {
                await DeleteHostedZone(createdZoneId);
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"Route53")]
        public void HealthCheckTests()
        {
            var createRequest = new CreateHealthCheckRequest()
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
            var createResponse = Client.CreateHealthCheckAsync(createRequest).Result;
            Assert.NotNull(createResponse.HealthCheck.Id);
            Assert.Equal(10, createResponse.HealthCheck.HealthCheckConfig.RequestInterval);
            Assert.Equal(5, createResponse.HealthCheck.HealthCheckConfig.FailureThreshold);
            string healthCheckId = createResponse.HealthCheck.Id;

            var listResponse = Client.ListHealthChecksAsync().Result;
            Assert.NotNull(listResponse.HealthChecks.FirstOrDefault(x => x.Id == healthCheckId));

            GetHealthCheckStatusResponse status = null;
            var stopTime = DateTime.Now + maxWaitTime;

            while (DateTime.Now < stopTime)
            {
                try
                {
                    status = Client.GetHealthCheckStatusAsync(new GetHealthCheckStatusRequest
                    {
                        HealthCheckId = healthCheckId
                    }).Result;
                    break;
                }
                catch
                {
                    UtilityMethods.Sleep(TimeSpan.FromSeconds(10));
                }
            }
            Assert.NotNull(status);
            Assert.NotNull(status.HealthCheckObservations);

            var healthCheck = Client.GetHealthCheckAsync(new GetHealthCheckRequest
            {
                HealthCheckId = healthCheckId
            }).Result.HealthCheck;
            Assert.NotNull(healthCheck);
            Assert.NotNull(healthCheck.Id);
            Assert.NotNull(healthCheck.HealthCheckConfig);

            var tagSet = Client.ListTagsForResourceAsync(new ListTagsForResourceRequest
            {
                ResourceType = TagResourceType.Healthcheck,
                ResourceId = healthCheckId
            }).Result.ResourceTagSet;
            Assert.NotNull(tagSet);
            Assert.NotNull(tagSet.ResourceId);
            Assert.NotNull(tagSet.ResourceType);
            Assert.NotNull(tagSet.Tags);
            Assert.Equal(0, tagSet.Tags.Count);

            Client.ChangeTagsForResourceAsync(new ChangeTagsForResourceRequest
            {
                ResourceType = TagResourceType.Healthcheck,
                ResourceId = healthCheckId,
                AddTags = new List<Tag>
                {
                    new Tag { Key = "Test", Value = "true" }
                }
            }).Wait();

            tagSet = Client.ListTagsForResourceAsync(new ListTagsForResourceRequest
            {
                ResourceType = TagResourceType.Healthcheck,
                ResourceId = healthCheckId
            }).Result.ResourceTagSet;
            Assert.NotNull(tagSet);
            Assert.NotNull(tagSet.ResourceId);
            Assert.NotNull(tagSet.ResourceType);
            Assert.NotNull(tagSet.Tags);
            Assert.Equal(1, tagSet.Tags.Count);
            Assert.Equal("Test", tagSet.Tags[0].Key);
            Assert.Equal("true", tagSet.Tags[0].Value);

            Client.DeleteHealthCheckAsync(new DeleteHealthCheckRequest() { HealthCheckId = healthCheckId }).Wait();

            listResponse = Client.ListHealthChecksAsync().Result;
            Assert.Null(listResponse.HealthChecks.FirstOrDefault(x => x.Id == healthCheckId));


        }

        [Fact]
        [Trait(CategoryAttribute,"Route53")]
        public void DelegationSetTests()
        {
            string createdZoneId = null;
            try
            {
                List<string> createdSets = new List<string>();

                var sets = Client.ListReusableDelegationSetsAsync(new ListReusableDelegationSetsRequest()).Result;
                var setCount = sets.DelegationSets.Count;

                var callerReference = "DNSMigration" + DateTime.Now.ToFileTime();
                var createResponse = Client.CreateReusableDelegationSetAsync(new CreateReusableDelegationSetRequest
                {
                    CallerReference = callerReference
                }).Result;
                Assert.NotNull(createResponse.Location);
                var delegationSet = createResponse.DelegationSet;
                Assert.NotNull(delegationSet);
                Assert.NotNull(delegationSet.CallerReference);
                Assert.NotNull(delegationSet.Id);
                Assert.NotNull(delegationSet.NameServers);
                Assert.NotEqual(0, delegationSet.NameServers.Count);
                createdSets.Add(delegationSet.Id);

                sets = Client.ListReusableDelegationSetsAsync(new ListReusableDelegationSetsRequest()).Result;
                Assert.Equal(setCount + 1, sets.DelegationSets.Count);

                CreateHostedZoneRequest createRequest = new CreateHostedZoneRequest
                {
                    Name = ZONE_NAME,
                    CallerReference = CALLER_REFERENCE,
                    HostedZoneConfig = new HostedZoneConfig { Comment = COMMENT },
                    DelegationSetId = delegationSet.Id
                };
                createdZoneId = UtilityMethods.WaitUntilSuccess<string>(() =>
                    Client.CreateHostedZoneAsync(createRequest).Result.HostedZone.Id
                );

                var hostedZoneInfo = Client.GetHostedZoneAsync(new GetHostedZoneRequest
                {
                    Id = createdZoneId
                }).Result;
                Assert.NotNull(hostedZoneInfo.VPCs);
                Assert.False(hostedZoneInfo.HostedZone.Config.PrivateZone);
                Assert.Equal(delegationSet.Id, hostedZoneInfo.DelegationSet.Id);

                var hostedZones = Client.ListHostedZonesAsync(new ListHostedZonesRequest
                {
                    DelegationSetId = delegationSet.Id
                }).Result.HostedZones;
                Assert.Equal(1, hostedZones.Count);

                // add a second set
                callerReference = "DNSMigration" + DateTime.Now.ToFileTime();
                createResponse = Client.CreateReusableDelegationSetAsync(new CreateReusableDelegationSetRequest
                {
                    CallerReference = callerReference
                }).Result;
                delegationSet = createResponse.DelegationSet;
                createdSets.Add(delegationSet.Id);

                int totalSetCount = 0;
                string nextMarker = null;
                do
                {
                    var response = Client.ListReusableDelegationSetsAsync(new ListReusableDelegationSetsRequest
                    {
                        MaxItems = "1",
                        Marker = nextMarker
                    }).Result;
                    totalSetCount += response.DelegationSets.Count;
                    nextMarker = response.NextMarker;
                } while (!string.IsNullOrEmpty(nextMarker));
                Assert.Equal(setCount + 2, totalSetCount);

                Client.DeleteHostedZoneAsync(new DeleteHostedZoneRequest
                {
                    Id = createdZoneId
                }).Wait();
                createdZoneId = null;

                foreach (var setId in createdSets)
                {
                    Client.DeleteReusableDelegationSetAsync(new DeleteReusableDelegationSetRequest
                    {
                        Id = setId
                    }).Wait();
                }

                sets = Client.ListReusableDelegationSetsAsync(new ListReusableDelegationSetsRequest()).Result;
                Assert.Equal(setCount, sets.DelegationSets.Count);
            }
            finally
            {
                DeleteHostedZone(createdZoneId);
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"Route53")]
        public void VPCTests()
        {
            var vpc1 = CreateVPC();
            var vpc2 = CreateVPC();
            string createdZoneId = null;
            try
            {
                CreateHostedZoneRequest createRequest = new CreateHostedZoneRequest
                {
                    Name = ZONE_NAME,
                    CallerReference = CALLER_REFERENCE,
                    HostedZoneConfig = new HostedZoneConfig { Comment = COMMENT },
                    VPC = vpc1
                };
                createdZoneId = UtilityMethods.WaitUntilSuccess<string>(() =>
                    Client.CreateHostedZoneAsync(createRequest).Result.HostedZone.Id
                );

                var hostedZoneInfo = Client.GetHostedZoneAsync(new GetHostedZoneRequest
                {
                    Id = createdZoneId
                }).Result;
                Assert.NotNull(hostedZoneInfo.VPCs);
                Assert.Equal(1, hostedZoneInfo.VPCs.Count);
                Assert.True(hostedZoneInfo.HostedZone.Config.PrivateZone);

                var changeInfo = Client.AssociateVPCWithHostedZoneAsync(new AssociateVPCWithHostedZoneRequest
                {
                    VPC = vpc2,
                    Comment = COMMENT,
                    HostedZoneId = createdZoneId
                }).Result.ChangeInfo;
                Assert.NotNull(changeInfo);
                Assert.NotNull(changeInfo.Comment);
                assertValidChangeInfo(changeInfo);

                hostedZoneInfo = Client.GetHostedZoneAsync(new GetHostedZoneRequest
                {
                    Id = createdZoneId
                }).Result;
                Assert.NotNull(hostedZoneInfo.VPCs);
                Assert.Equal(2, hostedZoneInfo.VPCs.Count);

                changeInfo = Client.DisassociateVPCFromHostedZoneAsync(new DisassociateVPCFromHostedZoneRequest
                {
                    HostedZoneId = createdZoneId,
                    VPC = vpc2
                }).Result.ChangeInfo;
                assertValidChangeInfo(changeInfo);

                hostedZoneInfo = Client.GetHostedZoneAsync(new GetHostedZoneRequest
                {
                    Id = createdZoneId
                }).Result;
                Assert.NotNull(hostedZoneInfo.VPCs);
                Assert.Equal(1, hostedZoneInfo.VPCs.Count);

                changeInfo = Client.DeleteHostedZoneAsync(new DeleteHostedZoneRequest
                {
                    Id = createdZoneId
                }).Result.ChangeInfo;
                assertValidChangeInfo(changeInfo);
            }
            finally
            {
                DeleteVPC(vpc1);
                DeleteVPC(vpc2);
                DeleteHostedZone(createdZoneId);
            }
        }

        // Deletes a VPC
        private void DeleteVPC(VPC vpc)
        {
            using (var ec2 = TestBase.CreateClient<Amazon.EC2.AmazonEC2Client>())
            {
                ec2.DeleteVpcAsync(new Amazon.EC2.Model.DeleteVpcRequest
                {
                    VpcId = vpc.VPCId
                }).Wait();
            }
        }

        // Creates a VPC
        private VPC CreateVPC()
        {
            var region = VPCRegion.FindValue(ActualEndpoint.SystemName);

            using (var ec2 = TestBase.CreateClient<Amazon.EC2.AmazonEC2Client>())
            {
                var ec2Vpc = ec2.CreateVpcAsync(new Amazon.EC2.Model.CreateVpcRequest
                {
                    CidrBlock = "10.0.0.0/16",
                    InstanceTenancy = Amazon.EC2.Tenancy.Default
                }).Result.Vpc;

                return new VPC
                {
                    VPCRegion = region,
                    VPCId = ec2Vpc.VpcId
                };
            }
        }

        // Asserts that the specified HostedZone is valid and represents the same
        // HostedZone that we initially created at the very start of this test.        
        private void assertValidCreatedHostedZone(HostedZone hostedZone)
        {
            Assert.Equal(ZONE_NAME, hostedZone.Name);
            Assert.NotNull(hostedZone.Id);
            Assert.Equal(COMMENT, hostedZone.Config.Comment);
        }

        // Asserts that the specified DelegationSet is valid.                 
        private void assertValidDelegationSet(DelegationSet delegationSet)
        {
            Assert.True(delegationSet.NameServers.Count > 0);
            foreach (string server in delegationSet.NameServers)
            {
                Assert.NotNull(server);
            }
        }
        
        // Asserts that the specified ChangeInfo is valid.         
        private void assertValidChangeInfo(ChangeInfo change)
        {
            Assert.NotNull(change.Id);
            Assert.NotNull(change.Status);
            Assert.NotNull(change.SubmittedAt);

            ChangeInfo retrievedChange = Client.GetChangeAsync(new GetChangeRequest { Id = change.Id }).Result.ChangeInfo;
            Assert.NotNull(retrievedChange);
            Assert.NotNull(retrievedChange.Id);
            Assert.NotNull(retrievedChange.Status);
            Assert.NotNull(retrievedChange.SubmittedAt);
        }
    }
}
