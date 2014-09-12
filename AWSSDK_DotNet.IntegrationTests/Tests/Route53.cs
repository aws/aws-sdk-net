using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Amazon.Route53;
using Amazon.Route53.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class Route53 : TestBase<AmazonRoute53Client>
    {
        private const string COMMENT = "comment";
        private const string ZONE_NAME = "aws.sdk.com.";
        private static readonly string CALLER_REFERENCE = Guid.NewGuid().ToString();

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
            try
            {
                Client.DeleteHostedZone(new DeleteHostedZoneRequest { Id = createdZoneId });
            }
            catch (Exception) { }
        }

        
        // Runs through each of the APIs in the Route 53 client to make sure we can
        // correct send requests and unmarshall responses.         
        [TestMethod]
        [TestCategory("Route53")]
        public void TestRoute53()
        {
            CreateHostedZoneRequest createRequest = new CreateHostedZoneRequest
            {
                Name = ZONE_NAME,
                CallerReference = CALLER_REFERENCE,
                HostedZoneConfig = new HostedZoneConfig { Comment = COMMENT }
            };
            // Create Hosted Zone
            var response = Client.CreateHostedZone(createRequest);

            createdZoneId = response.HostedZone.Id;
            createdZoneChangeId = response.ChangeInfo.Id;

            assertValidCreatedHostedZone(response.HostedZone);
            assertValidDelegationSet(response.DelegationSet);
            assertValidChangeInfo(response.ChangeInfo);
            Assert.IsNotNull(response.Location);


            // Get Hosted Zone
            GetHostedZoneRequest getRequest = new GetHostedZoneRequest { Id = createdZoneId };
            var getHostedZoneResponse = Client.GetHostedZone(getRequest);
            assertValidDelegationSet(getHostedZoneResponse.DelegationSet);
            assertValidCreatedHostedZone(getHostedZoneResponse.HostedZone);


            // List Hosted Zones
            List<HostedZone> hostedZones = Client.ListHostedZones(new ListHostedZonesRequest()).HostedZones;
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
                Type = existingResourceRecordSet.Type
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
            DeleteHostedZoneResult deleteHostedZoneResult = Client.DeleteHostedZone(new DeleteHostedZoneRequest { Id = createdZoneId });
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

            var listResponse = Client.ListHealthChecks();
            Assert.IsNotNull(listResponse.HealthChecks.FirstOrDefault(x => x.Id == createResponse.HealthCheck.Id));

            Client.DeleteHealthCheck(new DeleteHealthCheckRequest() { HealthCheckId = createResponse.HealthCheck.Id });

            listResponse = Client.ListHealthChecks();
            Assert.IsNull(listResponse.HealthChecks.FirstOrDefault(x => x.Id == createResponse.HealthCheck.Id));
        }


        
        // Asserts that the specified HostedZone is valid and represents the same
        // HostedZone that we initially created at the very start of this test.        
        private void assertValidCreatedHostedZone(HostedZone hostedZone)
        {
            Assert.AreEqual(CALLER_REFERENCE, hostedZone.CallerReference);
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
        }
    }
}
