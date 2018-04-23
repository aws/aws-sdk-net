using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Amazon.Route53;
using Amazon.Route53.Model;
using System.Threading;
using Amazon;
using AWSSDK_DotNet.IntegrationTests.Utils;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class Route53 : TestBase<AmazonRoute53Client>
    {
        private const string COMMENT = "comment";
        private const string ZONE_NAME = "aws.sdk.com.";
        private static string CALLER_REFERENCE { get { return Guid.NewGuid().ToString(); } }
        private static TimeSpan pollingPeriod = TimeSpan.FromSeconds(30);
        private static TimeSpan maxWaitTime = TimeSpan.FromMinutes(5);

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
        [TestCleanup()]
        public void TearDown()
        {
            if (!string.IsNullOrEmpty(createdZoneId))
            {
                try
                {
                    Client.DeleteHostedZone(new DeleteHostedZoneRequest { Id = createdZoneId });
                }
                catch { }
            }
        }

        // Runs through a number of the APIs in the Route 53 client to make sure we can
        // correct send requests and unmarshall responses.
        [TestMethod]
        [TestCategory("Route53")]
        public void TestRoute53()
        {
            var geoLocations = Client.ListGeoLocations().GeoLocationDetailsList;
            Assert.IsNotNull(geoLocations);
            Assert.AreNotEqual(0, geoLocations.Count);

            CreateHostedZoneRequest createRequest = new CreateHostedZoneRequest
            {
                Name = ZONE_NAME,
                CallerReference = CALLER_REFERENCE,
                HostedZoneConfig = new HostedZoneConfig { Comment = COMMENT }
            };
            // Create Hosted Zone

            var createResponse = UtilityMethods.WaitUntilSuccess<CreateHostedZoneResponse>(
                () => Client.CreateHostedZone(createRequest)
            );

            createdZoneId = createResponse.HostedZone.Id;
            createdZoneChangeId = createResponse.ChangeInfo.Id;

            assertValidCreatedHostedZone(createResponse.HostedZone);
            assertValidDelegationSet(createResponse.DelegationSet);
            assertValidChangeInfo(createResponse.ChangeInfo);
            Assert.IsNotNull(createResponse.Location);

            // Get Hosted Zone
            GetHostedZoneRequest getRequest = new GetHostedZoneRequest { Id = createdZoneId };
            var getHostedZoneResponse = Client.GetHostedZone(getRequest);
            assertValidDelegationSet(getHostedZoneResponse.DelegationSet);
            assertValidCreatedHostedZone(getHostedZoneResponse.HostedZone);

            // List Hosted Zones
            List<HostedZone> hostedZones = Client.ListHostedZones().HostedZones;
            Assert.IsTrue(hostedZones.Count > 0);
            foreach (HostedZone hostedZone in hostedZones)
            {
                Assert.IsNotNull(hostedZone.CallerReference);
                Assert.IsNotNull(hostedZone.Id);
                Assert.IsNotNull(hostedZone.Name);
            }

            // List Resource Record Sets
            ListResourceRecordSetsRequest listRequest = new ListResourceRecordSetsRequest { HostedZoneId = createdZoneId, MaxItems = "10" };
            List<ResourceRecordSet> resourceRecordSets = Client.ListResourceRecordSets(listRequest).ResourceRecordSets;

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
            ChangeInfo changeInfo = Client.GetChange(new GetChangeRequest { Id = createdZoneChangeId }).ChangeInfo;
            Assert.IsTrue(changeInfo.Id.EndsWith(createdZoneChangeId));
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

            changeInfo = Client.ChangeResourceRecordSets(new ChangeResourceRecordSetsRequest
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
            }).ChangeInfo;

            assertValidChangeInfo(changeInfo);

            // Delete Hosted Zone
            var deleteHostedZoneResult = Client.DeleteHostedZone(new DeleteHostedZoneRequest { Id = createdZoneId });
            assertValidChangeInfo(deleteHostedZoneResult.ChangeInfo);
        }

        [TestMethod]
        [TestCategory("Route53")]
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
            var createResponse = Client.CreateHealthCheck(createRequest);
            Assert.IsNotNull(createResponse.HealthCheck.Id);
            Assert.AreEqual(10, createResponse.HealthCheck.HealthCheckConfig.RequestInterval);
            Assert.AreEqual(5, createResponse.HealthCheck.HealthCheckConfig.FailureThreshold);
            string healthCheckId = createResponse.HealthCheck.Id;

            var listResponse = Client.ListHealthChecks();
            Assert.IsNotNull(listResponse.HealthChecks.FirstOrDefault(x => x.Id == healthCheckId));

            GetHealthCheckStatusResponse status = null;
            var stopTime = DateTime.Now + maxWaitTime;

            while (DateTime.Now < stopTime)
            {
                try
                {
                    status = Client.GetHealthCheckStatus(new GetHealthCheckStatusRequest
                    {
                        HealthCheckId = healthCheckId
                    });
                    break;
                }
                catch (NoSuchHealthCheckException)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(10));
                }
            }
            Assert.IsNotNull(status);
            Assert.IsNotNull(status.HealthCheckObservations);

            var healthCheck = Client.GetHealthCheck(new GetHealthCheckRequest
            {
                HealthCheckId = healthCheckId
            }).HealthCheck;
            Assert.IsNotNull(healthCheck);
            Assert.IsNotNull(healthCheck.Id);
            Assert.IsNotNull(healthCheck.HealthCheckConfig);

            var tagSet = Client.ListTagsForResource(new ListTagsForResourceRequest
            {
                ResourceType = TagResourceType.Healthcheck,
                ResourceId = healthCheckId
            }).ResourceTagSet;
            Assert.IsNotNull(tagSet);
            Assert.IsNotNull(tagSet.ResourceId);
            Assert.IsNotNull(tagSet.ResourceType);
            Assert.IsNotNull(tagSet.Tags);
            Assert.AreEqual(0, tagSet.Tags.Count);

            Client.ChangeTagsForResource(new ChangeTagsForResourceRequest
            {
                ResourceType = TagResourceType.Healthcheck,
                ResourceId = healthCheckId,
                AddTags = new List<Tag>
                {
                    new Tag { Key = "Test", Value = "true" }
                }
            });

            tagSet = Client.ListTagsForResource(new ListTagsForResourceRequest
            {
                ResourceType = TagResourceType.Healthcheck,
                ResourceId = healthCheckId
            }).ResourceTagSet;
            Assert.IsNotNull(tagSet);
            Assert.IsNotNull(tagSet.ResourceId);
            Assert.IsNotNull(tagSet.ResourceType);
            Assert.IsNotNull(tagSet.Tags);
            Assert.AreEqual(1, tagSet.Tags.Count);
            Assert.AreEqual("Test", tagSet.Tags[0].Key);
            Assert.AreEqual("true", tagSet.Tags[0].Value);

            Client.DeleteHealthCheck(new DeleteHealthCheckRequest() { HealthCheckId = healthCheckId });

            listResponse = Client.ListHealthChecks();
            Assert.IsNull(listResponse.HealthChecks.FirstOrDefault(x => x.Id == healthCheckId));


        }

        [TestMethod]
        [TestCategory("Route53")]
        public void DelegationSetTests()
        {
            List<string> createdSets = new List<string>();

            var sets = Client.ListReusableDelegationSets(new ListReusableDelegationSetsRequest());
            var setCount = sets.DelegationSets.Count;

            var callerReference = "DNSMigration" + DateTime.Now.ToFileTime();
            var createResponse = Client.CreateReusableDelegationSet(new CreateReusableDelegationSetRequest
            {
                CallerReference = callerReference
            });
            Assert.IsNotNull(createResponse.Location);
            var delegationSet = createResponse.DelegationSet;
            Assert.IsNotNull(delegationSet);
            Assert.IsNotNull(delegationSet.CallerReference);
            Assert.IsNotNull(delegationSet.Id);
            Assert.IsNotNull(delegationSet.NameServers);
            Assert.AreNotEqual(0, delegationSet.NameServers.Count);
            createdSets.Add(delegationSet.Id);

            sets = Client.ListReusableDelegationSets(new ListReusableDelegationSetsRequest());
            Assert.AreEqual(setCount + 1, sets.DelegationSets.Count);

            CreateHostedZoneRequest createRequest = new CreateHostedZoneRequest
            {
                Name = ZONE_NAME,
                CallerReference = CALLER_REFERENCE,
                HostedZoneConfig = new HostedZoneConfig { Comment = COMMENT },
                DelegationSetId = delegationSet.Id
            };
            createdZoneId = UtilityMethods.WaitUntilSuccess<string>(() => 
                Client.CreateHostedZone(createRequest).HostedZone.Id
            );

            var hostedZoneInfo = Client.GetHostedZone(new GetHostedZoneRequest
            {
                Id = createdZoneId
            });
            Assert.IsNotNull(hostedZoneInfo.VPCs);
            Assert.IsFalse(hostedZoneInfo.HostedZone.Config.PrivateZone);
            Assert.AreEqual(delegationSet.Id, hostedZoneInfo.DelegationSet.Id);

            var hostedZones = Client.ListHostedZones(new ListHostedZonesRequest
            {
                DelegationSetId = delegationSet.Id
            }).HostedZones;
            Assert.AreEqual(1, hostedZones.Count);

            // add a second set
            callerReference = "DNSMigration" + DateTime.Now.ToFileTime();
            createResponse = Client.CreateReusableDelegationSet(new CreateReusableDelegationSetRequest
            {
                CallerReference = callerReference
            });
            delegationSet = createResponse.DelegationSet;
            createdSets.Add(delegationSet.Id);

            int totalSetCount = 0;
            string nextMarker = null;
            do
            {
                var response = Client.ListReusableDelegationSets(new ListReusableDelegationSetsRequest
                {
                    MaxItems = "1",
                    Marker = nextMarker
                });
                totalSetCount += response.DelegationSets.Count;
                nextMarker = response.NextMarker;
            } while (!string.IsNullOrEmpty(nextMarker));
            Assert.AreEqual(setCount + 2, totalSetCount);

            Client.DeleteHostedZone(new DeleteHostedZoneRequest
            {
                Id = createdZoneId
            });
            createdZoneId = null;

            foreach (var setId in createdSets)
            {
                Client.DeleteReusableDelegationSet(new DeleteReusableDelegationSetRequest
                {
                    Id = setId
                });
            }

            sets = Client.ListReusableDelegationSets(new ListReusableDelegationSetsRequest());
            Assert.AreEqual(setCount, sets.DelegationSets.Count);
        }

        [TestMethod]
        [TestCategory("Route53")]
        public void VPCTests()
        {
            var vpc1 = CreateVPC();
            var vpc2 = CreateVPC();

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
                    Client.CreateHostedZone(createRequest).HostedZone.Id
                );

                var hostedZoneInfo = Client.GetHostedZone(new GetHostedZoneRequest
                {
                    Id = createdZoneId
                });
                Assert.IsNotNull(hostedZoneInfo.VPCs);
                Assert.AreEqual(1, hostedZoneInfo.VPCs.Count);
                Assert.IsTrue(hostedZoneInfo.HostedZone.Config.PrivateZone);

                var changeInfo = Client.AssociateVPCWithHostedZone(new AssociateVPCWithHostedZoneRequest
                {
                    VPC = vpc2,
                    Comment = COMMENT,
                    HostedZoneId = createdZoneId
                }).ChangeInfo;
                Assert.IsNotNull(changeInfo);
                Assert.IsNotNull(changeInfo.Comment);
                assertValidChangeInfo(changeInfo);

                hostedZoneInfo = Client.GetHostedZone(new GetHostedZoneRequest
                {
                    Id = createdZoneId
                });
                Assert.IsNotNull(hostedZoneInfo.VPCs);
                Assert.AreEqual(2, hostedZoneInfo.VPCs.Count);

                changeInfo = Client.DisassociateVPCFromHostedZone(new DisassociateVPCFromHostedZoneRequest
                {
                    HostedZoneId = createdZoneId,
                    VPC = vpc2
                }).ChangeInfo;
                assertValidChangeInfo(changeInfo);

                hostedZoneInfo = Client.GetHostedZone(new GetHostedZoneRequest
                {
                    Id = createdZoneId
                });
                Assert.IsNotNull(hostedZoneInfo.VPCs);
                Assert.AreEqual(1, hostedZoneInfo.VPCs.Count);

                changeInfo = Client.DeleteHostedZone(new DeleteHostedZoneRequest
                {
                    Id = createdZoneId
                }).ChangeInfo;
                assertValidChangeInfo(changeInfo);
            }
            finally
            {
                DeleteVPC(vpc1);
                DeleteVPC(vpc2);
            }
        }

        // Deletes a VPC
        private void DeleteVPC(VPC vpc)
        {
            using (var ec2 = new Amazon.EC2.AmazonEC2Client())
            {
                ec2.DeleteVpc(new Amazon.EC2.Model.DeleteVpcRequest
                {
                    VpcId = vpc.VPCId
                });
            }
        }

        // Creates a VPC
        private VPC CreateVPC()
        {
            var region = VPCRegion.FindValue(AWSConfigs.RegionEndpoint.SystemName);

            using(var ec2 = new Amazon.EC2.AmazonEC2Client())
            {
                var ec2Vpc = ec2.CreateVpc(new Amazon.EC2.Model.CreateVpcRequest
                {
                    CidrBlock = "10.0.0.0/16",
                    InstanceTenancy = Amazon.EC2.Tenancy.Default
                }).Vpc;

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
            Assert.AreEqual(ZONE_NAME, hostedZone.Name);
            Assert.IsNotNull(hostedZone.Id);
            Assert.AreEqual(COMMENT, hostedZone.Config.Comment);
        }

        // Asserts that the specified DelegationSet is valid.                 
        private void assertValidDelegationSet(DelegationSet delegationSet)
        {
            Assert.IsTrue(delegationSet.NameServers.Count > 0);
            foreach (string server in delegationSet.NameServers)
            {
                Assert.IsNotNull(server);
            }
        }
        
        // Asserts that the specified ChangeInfo is valid.         
        private void assertValidChangeInfo(ChangeInfo change)
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
