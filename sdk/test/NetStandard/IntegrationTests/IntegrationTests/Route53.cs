
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Route53;
using Amazon.Route53.Model;
using Xunit;


namespace Amazon.DNXCore.IntegrationTests
{
    
    public class Route53 : TestBase<AmazonRoute53Client>
    {
        private const string COMMENT = "comment";
        private const string ZONE_NAME = "aws.sdk.com.";
        private static string CALLER_REFERENCE { get { return Guid.NewGuid().ToString(); } }
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
                Assert.NotEmpty(geoLocations);

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
                    Assert.True(rrset.ResourceRecords.Count > 0);
                }


                // Get Change
                ChangeInfo changeInfo = (await Client.GetChangeAsync(new GetChangeRequest { Id = createdZoneChangeId })).ChangeInfo;
                Assert.EndsWith(createdZoneChangeId, changeInfo.Id);
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
        public async Task HealthCheckTests()
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
            var createResponse = await Client.CreateHealthCheckAsync(createRequest);
            Assert.NotNull(createResponse.HealthCheck.Id);
            Assert.Equal(10, createResponse.HealthCheck.HealthCheckConfig.RequestInterval);
            Assert.Equal(5, createResponse.HealthCheck.HealthCheckConfig.FailureThreshold);
            string healthCheckId = createResponse.HealthCheck.Id;

            var listResponse = await Client.ListHealthChecksAsync();
            Assert.NotNull(listResponse.HealthChecks.FirstOrDefault(x => x.Id == healthCheckId));

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
                catch
                {
                    UtilityMethods.Sleep(TimeSpan.FromSeconds(10));
                }
            }
            Assert.NotNull(status);

            var healthCheck = (await Client.GetHealthCheckAsync(new GetHealthCheckRequest
            {
                HealthCheckId = healthCheckId
            })).HealthCheck;
            Assert.NotNull(healthCheck);
            Assert.NotNull(healthCheck.Id);
            Assert.NotNull(healthCheck.HealthCheckConfig);

            var tagSet = (await Client.ListTagsForResourceAsync(new ListTagsForResourceRequest
            {
                ResourceType = TagResourceType.Healthcheck,
                ResourceId = healthCheckId
            })).ResourceTagSet;
            Assert.NotNull(tagSet);
            Assert.NotNull(tagSet.ResourceId);
            Assert.NotNull(tagSet.ResourceType);

            if (AWSConfigs.InitializeCollections)
            {
                Assert.Empty(tagSet.Tags);
            }
            else
            {
                Assert.Null(tagSet.Tags);
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

            tagSet = (await Client.ListTagsForResourceAsync(new ListTagsForResourceRequest
            {
                ResourceType = TagResourceType.Healthcheck,
                ResourceId = healthCheckId
            })).ResourceTagSet;
            Assert.NotNull(tagSet);
            Assert.NotNull(tagSet.ResourceId);
            Assert.NotNull(tagSet.ResourceType);
            Assert.NotNull(tagSet.Tags);
            Assert.Single(tagSet.Tags);
            Assert.Equal("Test", tagSet.Tags[0].Key);
            Assert.Equal("true", tagSet.Tags[0].Value);

            Client.DeleteHealthCheckAsync(new DeleteHealthCheckRequest() { HealthCheckId = healthCheckId }).Wait();

            listResponse = await Client.ListHealthChecksAsync();
            if (listResponse.HealthChecks != null)
            {
                Assert.Null(listResponse.HealthChecks.FirstOrDefault(x => x.Id == healthCheckId));
            }
        }

        [Fact(Skip = "Excluding flaky Route53 delegation set test.")]
        [Trait(CategoryAttribute,"Route53")]
        public async Task DelegationSetTests()
        {
            string createdZoneId = null;
            try
            {
                List<string> createdSets = new List<string>();

                var sets = await Client.ListReusableDelegationSetsAsync(new ListReusableDelegationSetsRequest());
                var setCount = sets.DelegationSets.Count;

                var callerReference = "DNSMigration" + DateTime.UtcNow.ToFileTime();
                var createResponse = await Client.CreateReusableDelegationSetAsync(new CreateReusableDelegationSetRequest
                {
                    CallerReference = callerReference
                });
                Assert.NotNull(createResponse.Location);
                var delegationSet = createResponse.DelegationSet;
                Assert.NotNull(delegationSet);
                Assert.NotNull(delegationSet.CallerReference);
                Assert.NotNull(delegationSet.Id);
                Assert.NotNull(delegationSet.NameServers);
                Assert.NotEmpty(delegationSet.NameServers);
                createdSets.Add(delegationSet.Id);

                sets = await Client.ListReusableDelegationSetsAsync(new ListReusableDelegationSetsRequest());
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

                var hostedZoneInfo = await Client.GetHostedZoneAsync(new GetHostedZoneRequest
                {
                    Id = createdZoneId
                });
                Assert.NotNull(hostedZoneInfo.VPCs);
                Assert.False(hostedZoneInfo.HostedZone.Config.PrivateZone);
                Assert.Equal(delegationSet.Id, hostedZoneInfo.DelegationSet.Id);

                var hostedZones = (await Client.ListHostedZonesAsync(new ListHostedZonesRequest
                {
                    DelegationSetId = delegationSet.Id
                })).HostedZones;
                Assert.Single(hostedZones);

                // add a second set
                callerReference = "DNSMigration" + DateTime.UtcNow.ToFileTime();
                createResponse = await Client.CreateReusableDelegationSetAsync(new CreateReusableDelegationSetRequest
                {
                    CallerReference = callerReference
                });
                delegationSet = createResponse.DelegationSet;
                createdSets.Add(delegationSet.Id);

                int totalSetCount = 0;
                string nextMarker = null;
                do
                {
                    var response = await Client.ListReusableDelegationSetsAsync(new ListReusableDelegationSetsRequest
                    {
                        MaxItems = "1",
                        Marker = nextMarker
                    });
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

                sets = await Client.ListReusableDelegationSetsAsync(new ListReusableDelegationSetsRequest());
                Assert.Equal(setCount, sets.DelegationSets.Count);
            }
            finally
            {
                DeleteHostedZone(createdZoneId).Wait();
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"Route53")]
        public async Task VPCTests()
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

                var hostedZoneInfo = await Client.GetHostedZoneAsync(new GetHostedZoneRequest
                {
                    Id = createdZoneId
                });
                Assert.NotNull(hostedZoneInfo.VPCs);
                Assert.Single(hostedZoneInfo.VPCs);
                Assert.True(hostedZoneInfo.HostedZone.Config.PrivateZone);

                var changeInfo = (await Client.AssociateVPCWithHostedZoneAsync(new AssociateVPCWithHostedZoneRequest
                {
                    VPC = vpc2,
                    Comment = COMMENT,
                    HostedZoneId = createdZoneId
                })).ChangeInfo;
                Assert.NotNull(changeInfo);
                Assert.NotNull(changeInfo.Comment);
                assertValidChangeInfo(changeInfo);

                hostedZoneInfo = await Client.GetHostedZoneAsync(new GetHostedZoneRequest
                {
                    Id = createdZoneId
                });
                Assert.NotNull(hostedZoneInfo.VPCs);
                Assert.Equal(2, hostedZoneInfo.VPCs.Count);

                changeInfo = (await Client.DisassociateVPCFromHostedZoneAsync(new DisassociateVPCFromHostedZoneRequest
                {
                    HostedZoneId = createdZoneId,
                    VPC = vpc2
                })).ChangeInfo;
                assertValidChangeInfo(changeInfo);

                hostedZoneInfo = await Client.GetHostedZoneAsync(new GetHostedZoneRequest
                {
                    Id = createdZoneId
                });
                Assert.NotNull(hostedZoneInfo.VPCs);
                Assert.Single(hostedZoneInfo.VPCs);

                changeInfo = (await Client.DeleteHostedZoneAsync(new DeleteHostedZoneRequest
                {
                    Id = createdZoneId
                })).ChangeInfo;
                assertValidChangeInfo(changeInfo);
            }
            finally
            {
                DeleteVPC(vpc1);
                DeleteVPC(vpc2);
                DeleteHostedZone(createdZoneId).Wait();
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
            Assert.NotEqual(DateTime.MinValue, change.SubmittedAt);

            ChangeInfo retrievedChange = Client.GetChangeAsync(new GetChangeRequest { Id = change.Id }).Result.ChangeInfo;
            Assert.NotNull(retrievedChange);
            Assert.NotNull(retrievedChange.Id);
            Assert.NotNull(retrievedChange.Status);
            Assert.NotEqual(DateTime.MinValue, retrievedChange.SubmittedAt);
        }
    }
}
