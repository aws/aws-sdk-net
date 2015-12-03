using System;
using Amazon.ElasticTranscoder.Model;
using Amazon.RDS;
using Amazon.RDS.Model;
using NUnit.Framework;
using CommonTests.Framework;

namespace AWSSDK_DotNet.IntegrationTests.Tests.RDS
{
    [TestFixture]
    public class BasicDescribes : TestBase<AmazonRDSClient>
    {
        [Test]
        [Category("RDS")]
        public void TestDescribeDBEngineVersions()
        {
            var response = Client.DescribeDBEngineVersionsAsync().Result;
            Assert.IsNotNull(response);

            string dbEngine = null;
            if (response.DBEngineVersions.Count > 0)
            {
                foreach (var dbev in response.DBEngineVersions)
                {
                    Assert.IsFalse(string.IsNullOrEmpty(dbev.Engine));
                    if (dbEngine == null)
                        dbEngine = dbev.Engine;

                    Assert.IsFalse(string.IsNullOrEmpty(dbev.EngineVersion));
                }
            }

            if (dbEngine != null)
            {
                // can perform a filtering test
                var specificEngineResponse =
                    Client.DescribeDBEngineVersionsAsync(new DescribeDBEngineVersionsRequest {Engine = dbEngine}).Result;
                Assert.IsNotNull(specificEngineResponse);
                foreach (var dbev in specificEngineResponse.DBEngineVersions)
                {
                    Assert.AreEqual(dbev.Engine, dbEngine);
                }
            }
        }

        [Test]
        [Category("RDS")]
        public void TestDescribeDBEngineVersionsForFamily()
        {
            var dbParamGroupFamily = Client.DescribeDBParameterGroupsAsync().Result.DBParameterGroups[0]; 

            var response = Client.DescribeDBEngineVersionsAsync(new DescribeDBEngineVersionsRequest
            {
                DBParameterGroupFamily = dbParamGroupFamily.DBParameterGroupFamily
            }).Result;
            Assert.IsNotNull(response);

            if (response.DBEngineVersions.Count > 0)
            {
                foreach (var dbev in response.DBEngineVersions)
                {
                    Assert.IsTrue(dbev.DBParameterGroupFamily.Equals(dbParamGroupFamily.DBParameterGroupFamily));
                }
            }
        }

        [Test]
        [Category("RDS")]
        public void TestDescribeDBParameterGroups()
        {
            var response = Client.DescribeDBParameterGroupsAsync().Result;
            Assert.IsNotNull(response);

            if (response.DBParameterGroups.Count > 0)
            {
                foreach (var dbpg in response.DBParameterGroups)
                {
                    Assert.IsFalse(string.IsNullOrEmpty(dbpg.DBParameterGroupFamily));
                    Assert.IsFalse(string.IsNullOrEmpty(dbpg.DBParameterGroupName));
                }
            }
        }

        [Test]
        [Category("RDS")]
        public void TestDescribeDBInstances()
        {
            var response = Client.DescribeDBInstancesAsync().Result;
            Assert.IsNotNull(response);

            string dbInstanceIdentifier = null;
            if (response.DBInstances.Count > 0)
            {
                foreach (var dbi in response.DBInstances)
                {
                    Assert.IsFalse(string.IsNullOrEmpty(dbi.DBInstanceIdentifier));
                    if (dbInstanceIdentifier == null)
                        dbInstanceIdentifier = dbi.DBInstanceIdentifier;

                    Assert.IsFalse(string.IsNullOrEmpty(dbi.Engine));
                    Assert.IsFalse(string.IsNullOrEmpty(dbi.EngineVersion));

                    if (dbi.DBParameterGroups.Count > 0)
                    {
                        foreach (var dbpg in dbi.DBParameterGroups)
                        {
                            Assert.IsFalse(string.IsNullOrEmpty(dbpg.DBParameterGroupName));
                        }
                    }
                }
            }

            if (dbInstanceIdentifier != null)
            {
                // can do a further filtering test
                var specificIdResponse =
                    Client.DescribeDBInstancesAsync(new DescribeDBInstancesRequest
                    {
                        DBInstanceIdentifier = dbInstanceIdentifier
                    }).Result;
                Assert.IsNotNull(specificIdResponse);
                Assert.AreEqual(specificIdResponse.DBInstances.Count, 1);
            }
        }

        [Test]
        [Category("RDS")]
        public void DescribeDBSecurityGroups()
        {
            var response = Client.DescribeDBSecurityGroupsAsync().Result;
            Assert.IsNotNull(response);

            string dbSecurityGroupName = null;
            if (response.DBSecurityGroups.Count > 0)
            {
                foreach (var dbsg in response.DBSecurityGroups)
                {
                    Assert.IsFalse(string.IsNullOrEmpty(dbsg.DBSecurityGroupName));
                    if (dbSecurityGroupName == null)
                        dbSecurityGroupName = dbsg.DBSecurityGroupName;

                    Assert.IsFalse(string.IsNullOrEmpty(dbsg.OwnerId));
                }
            }

            if (dbSecurityGroupName != null)
            {
                // perform a filtering test
                var specificGroupResponse =
                    Client.DescribeDBSecurityGroupsAsync(new DescribeDBSecurityGroupsRequest
                    {
                        DBSecurityGroupName = dbSecurityGroupName
                    }).Result;
                Assert.IsNotNull(specificGroupResponse);
                Assert.AreEqual(specificGroupResponse.DBSecurityGroups.Count, 1);
            }
        }

        [Test]
        [Category("RDS")]
        public void DescribeDBSnapshots()
        {
            var response = Client.DescribeDBSnapshotsAsync().Result;
            Assert.IsNotNull(response);

            string dbInstanceIdentifier = null;
            string dbSnapshotIdentifier = null;

            if (response.DBSnapshots.Count > 0)
            {
                foreach (var dbss in response.DBSnapshots)
                {
                    Assert.IsFalse(string.IsNullOrEmpty(dbss.DBInstanceIdentifier));
                    if (dbInstanceIdentifier == null)
                        dbInstanceIdentifier = dbss.DBInstanceIdentifier;

                    Assert.IsFalse(string.IsNullOrEmpty(dbss.DBSnapshotIdentifier));
                    if (dbSnapshotIdentifier == null)
                        dbSnapshotIdentifier = dbss.DBSnapshotIdentifier;
                }
            }

            if (dbInstanceIdentifier != null)
            {
                var specificInstanceResponse =
                    Client.DescribeDBSnapshotsAsync(new DescribeDBSnapshotsRequest
                    {
                        DBInstanceIdentifier = dbInstanceIdentifier
                    }).Result;
                Assert.IsNotNull(specificInstanceResponse);
                Assert.IsTrue(specificInstanceResponse.DBSnapshots.Count > 0);
            }

            if (dbSnapshotIdentifier != null)
            {
                var specificSnapshotResponse =
                    Client.DescribeDBSnapshotsAsync(new DescribeDBSnapshotsRequest
                    {
                        DBSnapshotIdentifier = dbSnapshotIdentifier
                    }).Result;
                Assert.IsNotNull(specificSnapshotResponse);
                Assert.AreEqual(specificSnapshotResponse.DBSnapshots.Count, 1);
            }
        }

        [Test]
        [Category("RDS")]
        public void DescribeDBSubnetGroups()
        {
            var response = Client.DescribeDBSubnetGroupsAsync().Result;
            Assert.IsNotNull(response);

            string dbSubnetGroupName = null;
            if (response.DBSubnetGroups.Count > 0)
            {
                foreach (var dbsng in response.DBSubnetGroups)
                {
                    Assert.IsFalse(string.IsNullOrEmpty(dbsng.DBSubnetGroupName));
                    if (dbSubnetGroupName == null)
                        dbSubnetGroupName = dbsng.DBSubnetGroupName;

                    if (dbsng.Subnets.Count > 0)
                    {
                        foreach (var s in dbsng.Subnets)
                        {
                            Assert.IsFalse(string.IsNullOrEmpty(s.SubnetIdentifier));
                            Assert.IsNotNull(s.SubnetAvailabilityZone);
                            Assert.IsFalse(string.IsNullOrEmpty(s.SubnetAvailabilityZone.Name));
                        }
                    }
                }
            }

            if (dbSubnetGroupName != null)
            {
                var specificSubnetResponse =
                    Client.DescribeDBSubnetGroupsAsync(new DescribeDBSubnetGroupsRequest
                    {
                        DBSubnetGroupName = dbSubnetGroupName
                    }).Result;
                Assert.IsNotNull(specificSubnetResponse);
                Assert.AreEqual(specificSubnetResponse.DBSubnetGroups.Count, 1);
            }
        }

        [Test]
        [Category("RDS")]
        public void DescribeEventCategories()
        {
            var response = Client.DescribeEventCategoriesAsync().Result;
            Assert.IsNotNull(response);

            string sourceType = null;
            if (response.EventCategoriesMapList.Count > 0)
            {
                foreach (var ec in response.EventCategoriesMapList)
                {
                    Assert.IsFalse(string.IsNullOrEmpty(ec.SourceType));
                    if (sourceType == null)
                        sourceType = ec.SourceType;

                    if (ec.EventCategories.Count > 0)
                    {
                        foreach (var cat in ec.EventCategories)
                        {
                            Assert.IsFalse(string.IsNullOrEmpty(cat));
                        }
                    }
                }
            }

            if (sourceType != null)
            {
                var specificSourceResponse =
                    Client.DescribeEventCategoriesAsync(new DescribeEventCategoriesRequest { SourceType = sourceType }).Result;
                Assert.IsNotNull(specificSourceResponse);

                Assert.AreEqual(specificSourceResponse.EventCategoriesMapList.Count, 1);
            }
        }

        [Test]
        [Category("RDS")]
        public void DescribeEventSubscriptions()
        {
            // subscriptions depend on what account has set up, so simply verify we get a response
            var response = Client.DescribeEventSubscriptionsAsync().Result;
            Assert.IsNotNull(response);
        }

        [Test]
        [Category("RDS")]
        public void DescribeEvents()
        {
            var response = Client.DescribeEventsAsync().Result;
            Assert.IsNotNull(response);

            string sourceIdentifier = null;
            string sourceType = null;
            if (response.Events.Count > 0)
            {
                foreach (var e in response.Events)
                {
                    Assert.IsFalse(string.IsNullOrEmpty(e.SourceType));
                    Assert.IsFalse(string.IsNullOrEmpty(e.SourceIdentifier));
                    if (sourceIdentifier == null)
                    {
                        sourceIdentifier = e.SourceIdentifier;
                        sourceType = e.SourceType;
                    }
                        
                    if (e.EventCategories.Count > 0)
                    {
                        foreach (var ec in e.EventCategories)
                        {
                            Assert.IsFalse(string.IsNullOrEmpty(ec));
                        }
                    }
                }
            }

            if (sourceIdentifier != null)
            {
                var specificSourceResponse =
                    Client.DescribeEventsAsync(new DescribeEventsRequest { SourceIdentifier = sourceIdentifier, SourceType = sourceType }).Result;
                Assert.IsNotNull(specificSourceResponse);
            }
        }

        [Test]
        [Category("RDS")]
        public void DescribeOptionGroups()
        {
            var response = Client.DescribeOptionGroupsAsync().Result;
            Assert.IsNotNull(response);

            string engineName = null;
            string optionGroupName = null;
            if (response.OptionGroupsList.Count > 0)
            {
                foreach (var og in response.OptionGroupsList)
                {
                    Assert.IsFalse(string.IsNullOrEmpty(og.EngineName));
                    if (engineName == null)
                        engineName = og.EngineName;
                    Assert.IsFalse(string.IsNullOrEmpty(og.OptionGroupName));
                    if (optionGroupName == null)
                        optionGroupName = og.OptionGroupName;

                    if (og.Options.Count > 0)
                    {
                        foreach (var o in og.Options)
                        {
                            Assert.IsFalse(string.IsNullOrEmpty(o.OptionName));
                            if (o.OptionSettings.Count > 0)
                            {
                                foreach (var os in o.OptionSettings)
                                {
                                    Assert.IsFalse(string.IsNullOrEmpty(os.Name));
                                }
                            }
                        }
                    }
                }
            }

            if (engineName != null)
            {
                var specificEngineResponse =
                    Client.DescribeOptionGroupsAsync(new DescribeOptionGroupsRequest { EngineName = engineName }).Result;
                Assert.IsNotNull(specificEngineResponse);
                Assert.IsTrue(specificEngineResponse.OptionGroupsList.Count > 0);
            }

            if (optionGroupName != null)
            {
                var specificGroupResponse =
                    Client.DescribeOptionGroupsAsync(new DescribeOptionGroupsRequest { OptionGroupName = optionGroupName }).Result;
                Assert.IsNotNull(specificGroupResponse);
                Assert.AreEqual(specificGroupResponse.OptionGroupsList.Count, 1);
            }
        }

        [Test]
        [Category("RDS")]
        public void OptionGroupTests()
        {
            string ogNamePrefix = "simple-og";

            var groups = Client.DescribeOptionGroupsAsync().Result.OptionGroupsList;
            foreach(var group in groups)
            {
                var groupName = group.OptionGroupName;

                if (groupName.IndexOf(ogNamePrefix, StringComparison.OrdinalIgnoreCase) >= 0)
                    Client.DeleteOptionGroupAsync(new DeleteOptionGroupRequest
                    {
                        OptionGroupName = groupName
                    }).Wait();
            }


            var name = "simple-og" + DateTime.Now.Ticks;
            var optionGroup = Client.CreateOptionGroupAsync(new CreateOptionGroupRequest
            {
                EngineName = "mysql",
                MajorEngineVersion = "5.1",
                 OptionGroupName = name,
                 OptionGroupDescription = "Basic test OptionGroup"
            }).Result.OptionGroup;

            var optionGroupName = optionGroup.OptionGroupName;
            var copyOptionGroupName = optionGroupName + "copy";
            Client.CopyOptionGroupAsync(new CopyOptionGroupRequest
            {
                SourceOptionGroupIdentifier = optionGroupName,
                TargetOptionGroupIdentifier = copyOptionGroupName,
                TargetOptionGroupDescription = "copy"
            }).Wait();

            groups = Client.DescribeOptionGroupsAsync(new DescribeOptionGroupsRequest
            {
                OptionGroupName = copyOptionGroupName
            }).Result.OptionGroupsList;
            Assert.AreEqual(1, groups.Count);

            Client.DeleteOptionGroupAsync(new DeleteOptionGroupRequest
            {
                OptionGroupName = copyOptionGroupName
            }).Wait();
            Client.DeleteOptionGroupAsync(new DeleteOptionGroupRequest
            {
                OptionGroupName = optionGroupName
            }).Wait();
        }

        [Test]
        [Category("RDS")]
        public void DescribeReservedDBInstances()
        {
            var response = Client.DescribeReservedDBInstancesAsync().Result;
            Assert.IsNotNull(response);

            string reservedInstanceId = null;
            string dbInstanceClass = null;

            if (response.ReservedDBInstances.Count > 0)
            {
                foreach (var rdbi in response.ReservedDBInstances)
                {
                    Assert.IsFalse(string.IsNullOrEmpty(rdbi.ReservedDBInstanceId));
                    if (reservedInstanceId == null)
                        reservedInstanceId = rdbi.ReservedDBInstanceId;
                    Assert.IsFalse(string.IsNullOrEmpty(rdbi.DBInstanceClass));
                    if (dbInstanceClass == null)
                        dbInstanceClass = rdbi.DBInstanceClass;
                }
            }

            if (dbInstanceClass != null)
            {
                var specificClassResponse =
                    Client.DescribeReservedDBInstancesAsync(new DescribeReservedDBInstancesRequest
                    {
                        DBInstanceClass = dbInstanceClass
                    }).Result;
                Assert.IsNotNull(specificClassResponse);
                Assert.IsTrue(specificClassResponse.ReservedDBInstances.Count > 0);
            }

            if (reservedInstanceId != null)
            {
                var specificInstanceResponse =
                    Client.DescribeReservedDBInstancesAsync(new DescribeReservedDBInstancesRequest
                    {
                        ReservedDBInstanceId = reservedInstanceId
                    }).Result;
                Assert.IsNotNull(specificInstanceResponse);
                Assert.AreEqual(specificInstanceResponse.ReservedDBInstances.Count, 1);
            }
        }

        [Test]
        [Category("RDS")]
        public void DescribeReservedDBInstancesOfferings()
        {
            var response = Client.DescribeReservedDBInstancesOfferingsAsync().Result;
            Assert.IsNotNull(response);

            string offeringId = null;
            string offeringType = null;

            if (response.ReservedDBInstancesOfferings.Count > 0)
            {
                foreach (var ro in response.ReservedDBInstancesOfferings)
                {
                    Assert.IsFalse(string.IsNullOrEmpty(ro.OfferingType));
                    if (offeringType == null)
                        offeringType = ro.OfferingType;
                    Assert.IsFalse(string.IsNullOrEmpty(ro.ReservedDBInstancesOfferingId));
                    if (offeringId == null)
                        offeringId = ro.ReservedDBInstancesOfferingId;
                }
            }

            if (offeringType != null)
            {
                var specificTypeResponse =
                    Client.DescribeReservedDBInstancesOfferingsAsync(new DescribeReservedDBInstancesOfferingsRequest
                    {
                        OfferingType = offeringType
                    }).Result;
                Assert.IsNotNull(specificTypeResponse);
                Assert.IsTrue(specificTypeResponse.ReservedDBInstancesOfferings.Count > 0);
            }

            if (offeringId != null)
            {
                var specificIdResponse =
                    Client.DescribeReservedDBInstancesOfferingsAsync(new DescribeReservedDBInstancesOfferingsRequest
                    {
                        ReservedDBInstancesOfferingId = offeringId
                    }).Result;
                Assert.IsNotNull(specificIdResponse);
                Assert.AreEqual(specificIdResponse.ReservedDBInstancesOfferings.Count, 1);
            }
        }

        [Test]
        [Category("RDS")]
        public void TestDescribeAccountAttributes()
        {
            var result = Client.DescribeAccountAttributesAsync().Result;
            var quotas = result.AccountQuotas;
            Assert.IsNotNull(quotas);
            Assert.AreNotEqual(0, quotas.Count);
            foreach(var quota in quotas)
            {
                Assert.IsFalse(string.IsNullOrEmpty(quota.AccountQuotaName));
                Assert.AreNotEqual(0, quota.Max);
            }
        }
        [Test]
        [Category("RDS")]
        public void TestDescribeCertificates()
        {
            var request = new DescribeCertificatesRequest();

            do
            {
                var response = Client.DescribeCertificatesAsync(request).Result;
                var certificates = response.Certificates;
                Assert.IsNotNull(certificates);
                Assert.AreNotEqual(0, certificates.Count);

                foreach(var cert in certificates)
                {
                    Assert.IsNotNull(cert);
                    Assert.IsFalse(string.IsNullOrEmpty(cert.CertificateIdentifier));
                    Assert.IsFalse(string.IsNullOrEmpty(cert.CertificateType));
                    Assert.IsFalse(string.IsNullOrEmpty(cert.Thumbprint));
                    Assert.IsTrue(cert.ValidFrom > DateTime.MinValue);
                    Assert.IsTrue(cert.ValidFrom < cert.ValidTill);
                }

                request.Marker = response.Marker;
            } while (!string.IsNullOrEmpty(request.Marker));
        }

        [Test]
        [Category("RDS")]
        public void TestDescribeDBInstanceException()
        {
            var nfe = AssertExtensions.ExpectExceptionAsync<DBInstanceNotFoundException>(
                Client.DescribeDBInstancesAsync(new DescribeDBInstancesRequest
                {
                    DBInstanceIdentifier = "fake-identifier"
                })).Result;

            Assert.IsFalse(string.IsNullOrEmpty(nfe.ErrorCode));
            Assert.IsFalse(string.IsNullOrEmpty(nfe.Message));
            Assert.IsFalse(string.IsNullOrEmpty(nfe.RequestId));
            Assert.IsTrue((int)(nfe.StatusCode) >= 400);
        }
    }
}
