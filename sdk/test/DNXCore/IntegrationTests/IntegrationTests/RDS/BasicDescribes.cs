using System;
using Amazon.ElasticTranscoder.Model;
using Amazon.RDS;
using Amazon.RDS.Model;
using Xunit;
using Amazon.DNXCore.IntegrationTests;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.RDS
{
    
    public class BasicDescribes : TestBase<AmazonRDSClient>
    {
        [Fact]
        [Trait(CategoryAttribute,"RDS")]
        public void TestDescribeDBEngineVersions()
        {
            var response = Client.DescribeDBEngineVersionsAsync().Result;
            Assert.NotNull(response);

            string dbEngine = null;
            if (response.DBEngineVersions.Count > 0)
            {
                foreach (var dbev in response.DBEngineVersions)
                {
                    Assert.False(string.IsNullOrEmpty(dbev.Engine));
                    if (dbEngine == null)
                        dbEngine = dbev.Engine;

                    Assert.False(string.IsNullOrEmpty(dbev.EngineVersion));
                }
            }

            if (dbEngine != null)
            {
                // can perform a filtering test
                var specificEngineResponse =
                    Client.DescribeDBEngineVersionsAsync(new DescribeDBEngineVersionsRequest {Engine = dbEngine}).Result;
                Assert.NotNull(specificEngineResponse);
                foreach (var dbev in specificEngineResponse.DBEngineVersions)
                {
                    Assert.Equal(dbev.Engine, dbEngine);
                }
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"RDS")]
        public void TestDescribeDBEngineVersionsForFamily()
        {
            var dbParamGroupFamily = Client.DescribeDBParameterGroupsAsync().Result.DBParameterGroups[0]; 

            var response = Client.DescribeDBEngineVersionsAsync(new DescribeDBEngineVersionsRequest
            {
                DBParameterGroupFamily = dbParamGroupFamily.DBParameterGroupFamily
            }).Result;
            Assert.NotNull(response);

            if (response.DBEngineVersions.Count > 0)
            {
                foreach (var dbev in response.DBEngineVersions)
                {
                    Assert.True(dbev.DBParameterGroupFamily.Equals(dbParamGroupFamily.DBParameterGroupFamily));
                }
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"RDS")]
        public void TestDescribeDBParameterGroups()
        {
            var response = Client.DescribeDBParameterGroupsAsync().Result;
            Assert.NotNull(response);

            if (response.DBParameterGroups.Count > 0)
            {
                foreach (var dbpg in response.DBParameterGroups)
                {
                    Assert.False(string.IsNullOrEmpty(dbpg.DBParameterGroupFamily));
                    Assert.False(string.IsNullOrEmpty(dbpg.DBParameterGroupName));
                }
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"RDS")]
        public void TestDescribeDBInstances()
        {
            var response = Client.DescribeDBInstancesAsync().Result;
            Assert.NotNull(response);

            string dbInstanceIdentifier = null;
            if (response.DBInstances.Count > 0)
            {
                foreach (var dbi in response.DBInstances)
                {
                    Assert.False(string.IsNullOrEmpty(dbi.DBInstanceIdentifier));
                    if (dbInstanceIdentifier == null)
                        dbInstanceIdentifier = dbi.DBInstanceIdentifier;

                    Assert.False(string.IsNullOrEmpty(dbi.Engine));
                    Assert.False(string.IsNullOrEmpty(dbi.EngineVersion));

                    if (dbi.DBParameterGroups.Count > 0)
                    {
                        foreach (var dbpg in dbi.DBParameterGroups)
                        {
                            Assert.False(string.IsNullOrEmpty(dbpg.DBParameterGroupName));
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
                Assert.NotNull(specificIdResponse);
                Assert.Equal(specificIdResponse.DBInstances.Count, 1);
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"RDS")]
        public void DescribeDBSecurityGroups()
        {
            var response = Client.DescribeDBSecurityGroupsAsync().Result;
            Assert.NotNull(response);

            string dbSecurityGroupName = null;
            if (response.DBSecurityGroups.Count > 0)
            {
                foreach (var dbsg in response.DBSecurityGroups)
                {
                    Assert.False(string.IsNullOrEmpty(dbsg.DBSecurityGroupName));
                    if (dbSecurityGroupName == null)
                        dbSecurityGroupName = dbsg.DBSecurityGroupName;

                    Assert.False(string.IsNullOrEmpty(dbsg.OwnerId));
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
                Assert.NotNull(specificGroupResponse);
                Assert.Equal(specificGroupResponse.DBSecurityGroups.Count, 1);
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"RDS")]
        public void DescribeDBSnapshots()
        {
            var response = Client.DescribeDBSnapshotsAsync().Result;
            Assert.NotNull(response);

            string dbInstanceIdentifier = null;
            string dbSnapshotIdentifier = null;

            if (response.DBSnapshots.Count > 0)
            {
                foreach (var dbss in response.DBSnapshots)
                {
                    Assert.False(string.IsNullOrEmpty(dbss.DBInstanceIdentifier));
                    if (dbInstanceIdentifier == null)
                        dbInstanceIdentifier = dbss.DBInstanceIdentifier;

                    Assert.False(string.IsNullOrEmpty(dbss.DBSnapshotIdentifier));
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
                Assert.NotNull(specificInstanceResponse);
                Assert.True(specificInstanceResponse.DBSnapshots.Count > 0);
            }

            if (dbSnapshotIdentifier != null)
            {
                var specificSnapshotResponse =
                    Client.DescribeDBSnapshotsAsync(new DescribeDBSnapshotsRequest
                    {
                        DBSnapshotIdentifier = dbSnapshotIdentifier
                    }).Result;
                Assert.NotNull(specificSnapshotResponse);
                Assert.Equal(specificSnapshotResponse.DBSnapshots.Count, 1);
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"RDS")]
        public void DescribeDBSubnetGroups()
        {
            var response = Client.DescribeDBSubnetGroupsAsync().Result;
            Assert.NotNull(response);

            string dbSubnetGroupName = null;
            if (response.DBSubnetGroups.Count > 0)
            {
                foreach (var dbsng in response.DBSubnetGroups)
                {
                    Assert.False(string.IsNullOrEmpty(dbsng.DBSubnetGroupName));
                    if (dbSubnetGroupName == null)
                        dbSubnetGroupName = dbsng.DBSubnetGroupName;

                    if (dbsng.Subnets.Count > 0)
                    {
                        foreach (var s in dbsng.Subnets)
                        {
                            Assert.False(string.IsNullOrEmpty(s.SubnetIdentifier));
                            Assert.NotNull(s.SubnetAvailabilityZone);
                            Assert.False(string.IsNullOrEmpty(s.SubnetAvailabilityZone.Name));
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
                Assert.NotNull(specificSubnetResponse);
                Assert.Equal(specificSubnetResponse.DBSubnetGroups.Count, 1);
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"RDS")]
        public void DescribeEventCategories()
        {
            var response = Client.DescribeEventCategoriesAsync().Result;
            Assert.NotNull(response);

            string sourceType = null;
            if (response.EventCategoriesMapList.Count > 0)
            {
                foreach (var ec in response.EventCategoriesMapList)
                {
                    Assert.False(string.IsNullOrEmpty(ec.SourceType));
                    if (sourceType == null)
                        sourceType = ec.SourceType;

                    if (ec.EventCategories.Count > 0)
                    {
                        foreach (var cat in ec.EventCategories)
                        {
                            Assert.False(string.IsNullOrEmpty(cat));
                        }
                    }
                }
            }

            if (sourceType != null)
            {
                var specificSourceResponse =
                    Client.DescribeEventCategoriesAsync(new DescribeEventCategoriesRequest { SourceType = sourceType }).Result;
                Assert.NotNull(specificSourceResponse);

                Assert.Equal(specificSourceResponse.EventCategoriesMapList.Count, 1);
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"RDS")]
        public void DescribeEventSubscriptions()
        {
            // subscriptions depend on what account has set up, so simply verify we get a response
            var response = Client.DescribeEventSubscriptionsAsync().Result;
            Assert.NotNull(response);
        }

        [Fact]
        [Trait(CategoryAttribute,"RDS")]
        public void DescribeEvents()
        {
            var response = Client.DescribeEventsAsync().Result;
            Assert.NotNull(response);

            string sourceIdentifier = null;
            string sourceType = null;
            if (response.Events.Count > 0)
            {
                foreach (var e in response.Events)
                {
                    Assert.False(string.IsNullOrEmpty(e.SourceType));
                    Assert.False(string.IsNullOrEmpty(e.SourceIdentifier));
                    if (sourceIdentifier == null)
                    {
                        sourceIdentifier = e.SourceIdentifier;
                        sourceType = e.SourceType;
                    }
                        
                    if (e.EventCategories.Count > 0)
                    {
                        foreach (var ec in e.EventCategories)
                        {
                            Assert.False(string.IsNullOrEmpty(ec));
                        }
                    }
                }
            }

            if (sourceIdentifier != null)
            {
                var specificSourceResponse =
                    Client.DescribeEventsAsync(new DescribeEventsRequest { SourceIdentifier = sourceIdentifier, SourceType = sourceType }).Result;
                Assert.NotNull(specificSourceResponse);
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"RDS")]
        public void DescribeOptionGroups()
        {
            var response = Client.DescribeOptionGroupsAsync().Result;
            Assert.NotNull(response);

            string engineName = null;
            string optionGroupName = null;
            if (response.OptionGroupsList.Count > 0)
            {
                foreach (var og in response.OptionGroupsList)
                {
                    Assert.False(string.IsNullOrEmpty(og.EngineName));
                    if (engineName == null)
                        engineName = og.EngineName;
                    Assert.False(string.IsNullOrEmpty(og.OptionGroupName));
                    if (optionGroupName == null)
                        optionGroupName = og.OptionGroupName;

                    if (og.Options.Count > 0)
                    {
                        foreach (var o in og.Options)
                        {
                            Assert.False(string.IsNullOrEmpty(o.OptionName));
                            if (o.OptionSettings.Count > 0)
                            {
                                foreach (var os in o.OptionSettings)
                                {
                                    Assert.False(string.IsNullOrEmpty(os.Name));
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
                Assert.NotNull(specificEngineResponse);
                Assert.True(specificEngineResponse.OptionGroupsList.Count > 0);
            }

            if (optionGroupName != null)
            {
                var specificGroupResponse =
                    Client.DescribeOptionGroupsAsync(new DescribeOptionGroupsRequest { OptionGroupName = optionGroupName }).Result;
                Assert.NotNull(specificGroupResponse);
                Assert.Equal(specificGroupResponse.OptionGroupsList.Count, 1);
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"RDS")]
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
            Assert.Equal(1, groups.Count);

            Client.DeleteOptionGroupAsync(new DeleteOptionGroupRequest
            {
                OptionGroupName = copyOptionGroupName
            }).Wait();
            Client.DeleteOptionGroupAsync(new DeleteOptionGroupRequest
            {
                OptionGroupName = optionGroupName
            }).Wait();
        }

        [Fact]
        [Trait(CategoryAttribute,"RDS")]
        public void DescribeReservedDBInstances()
        {
            var response = Client.DescribeReservedDBInstancesAsync().Result;
            Assert.NotNull(response);

            string reservedInstanceId = null;
            string dbInstanceClass = null;

            if (response.ReservedDBInstances.Count > 0)
            {
                foreach (var rdbi in response.ReservedDBInstances)
                {
                    Assert.False(string.IsNullOrEmpty(rdbi.ReservedDBInstanceId));
                    if (reservedInstanceId == null)
                        reservedInstanceId = rdbi.ReservedDBInstanceId;
                    Assert.False(string.IsNullOrEmpty(rdbi.DBInstanceClass));
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
                Assert.NotNull(specificClassResponse);
                Assert.True(specificClassResponse.ReservedDBInstances.Count > 0);
            }

            if (reservedInstanceId != null)
            {
                var specificInstanceResponse =
                    Client.DescribeReservedDBInstancesAsync(new DescribeReservedDBInstancesRequest
                    {
                        ReservedDBInstanceId = reservedInstanceId
                    }).Result;
                Assert.NotNull(specificInstanceResponse);
                Assert.Equal(specificInstanceResponse.ReservedDBInstances.Count, 1);
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"RDS")]
        public void DescribeReservedDBInstancesOfferings()
        {
            var response = Client.DescribeReservedDBInstancesOfferingsAsync().Result;
            Assert.NotNull(response);

            string offeringId = null;
            string offeringType = null;

            if (response.ReservedDBInstancesOfferings.Count > 0)
            {
                foreach (var ro in response.ReservedDBInstancesOfferings)
                {
                    Assert.False(string.IsNullOrEmpty(ro.OfferingType));
                    if (offeringType == null)
                        offeringType = ro.OfferingType;
                    Assert.False(string.IsNullOrEmpty(ro.ReservedDBInstancesOfferingId));
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
                Assert.NotNull(specificTypeResponse);
                Assert.True(specificTypeResponse.ReservedDBInstancesOfferings.Count > 0);
            }

            if (offeringId != null)
            {
                var specificIdResponse =
                    Client.DescribeReservedDBInstancesOfferingsAsync(new DescribeReservedDBInstancesOfferingsRequest
                    {
                        ReservedDBInstancesOfferingId = offeringId
                    }).Result;
                Assert.NotNull(specificIdResponse);
                Assert.Equal(specificIdResponse.ReservedDBInstancesOfferings.Count, 1);
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"RDS")]
        public void TestDescribeAccountAttributes()
        {
            var result = Client.DescribeAccountAttributesAsync().Result;
            var quotas = result.AccountQuotas;
            Assert.NotNull(quotas);
            Assert.NotEqual(0, quotas.Count);
            foreach(var quota in quotas)
            {
                Assert.False(string.IsNullOrEmpty(quota.AccountQuotaName));
                Assert.NotEqual(0, quota.Max);
            }
        }
        [Fact]
        [Trait(CategoryAttribute,"RDS")]
        public void TestDescribeCertificates()
        {
            var request = new DescribeCertificatesRequest();

            do
            {
                var response = Client.DescribeCertificatesAsync(request).Result;
                var certificates = response.Certificates;
                Assert.NotNull(certificates);
                Assert.NotEqual(0, certificates.Count);

                foreach(var cert in certificates)
                {
                    Assert.NotNull(cert);
                    Assert.False(string.IsNullOrEmpty(cert.CertificateIdentifier));
                    Assert.False(string.IsNullOrEmpty(cert.CertificateType));
                    Assert.False(string.IsNullOrEmpty(cert.Thumbprint));
                    Assert.True(cert.ValidFrom > DateTime.MinValue);
                    Assert.True(cert.ValidFrom < cert.ValidTill);
                }

                request.Marker = response.Marker;
            } while (!string.IsNullOrEmpty(request.Marker));
        }

        [Fact]
        public async Task  TestDescribeDBInstanceException()
        {
            var nfe = await Assert.ThrowsAsync<DBInstanceNotFoundException>(() =>
            {
                return Client.DescribeDBInstancesAsync(new DescribeDBInstancesRequest
                {
                    DBInstanceIdentifier = "DB" + Guid.NewGuid().ToString("N")
                });
            }
            );
            
            Assert.False(string.IsNullOrEmpty(nfe.ErrorCode));
            Assert.False(string.IsNullOrEmpty(nfe.Message));
            Assert.False(string.IsNullOrEmpty(nfe.RequestId));
            Assert.True((int)(nfe.StatusCode) >= 400);
        }        
    }
}
