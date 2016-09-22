using System;
using System.Threading.Tasks;
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
        public async Task TestDescribeDBEngineVersions()
        {
            var response = await Client.DescribeDBEngineVersionsAsync();
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
                    await Client.DescribeDBEngineVersionsAsync(new DescribeDBEngineVersionsRequest {Engine = dbEngine});
                Assert.NotNull(specificEngineResponse);
                foreach (var dbev in specificEngineResponse.DBEngineVersions)
                {
                    Assert.Equal(dbev.Engine, dbEngine);
                }
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"RDS")]
        public async Task TestDescribeDBEngineVersionsForFamily()
        {
            var dbParamGroupFamily = Client.DescribeDBParameterGroupsAsync().Result.DBParameterGroups[0]; 

            var response = await Client.DescribeDBEngineVersionsAsync(new DescribeDBEngineVersionsRequest
            {
                DBParameterGroupFamily = dbParamGroupFamily.DBParameterGroupFamily
            });
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
        public async Task TestDescribeDBParameterGroups()
        {
            var response = await Client.DescribeDBParameterGroupsAsync();
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
        public async Task TestDescribeDBInstances()
        {
            var response = await Client.DescribeDBInstancesAsync();
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
    }
}
