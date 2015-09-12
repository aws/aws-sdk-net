using System;
using System.Linq;
using Xunit;
using Amazon.DNXCore.IntegrationTests;

using Amazon.RDS;
using Amazon.RDS.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests.RDS
{
    
    public class DescribeOrderableDBInstanceOptions: TestBase<AmazonRDSClient>
    {
        [Fact]
        [Trait(CategoryAttribute,"RDS")]
        public void TestDescribeOrderableDBInstanceOptions()
        {
            const string engine = "mysql";
            var response =
                Client.DescribeOrderableDBInstanceOptionsAsync(new DescribeOrderableDBInstanceOptionsRequest
                {
                    Engine = engine
                }).Result;
            Assert.NotNull(response);

            Assert.NotNull(response.OrderableDBInstanceOptions);
            foreach (var opt in response.OrderableDBInstanceOptions)
            {
                Assert.NotNull(opt.AvailabilityZones);
                Assert.True(opt.AvailabilityZones.Count > 0);
                Assert.False(string.IsNullOrEmpty(opt.DBInstanceClass));
                Assert.Equal(engine, opt.Engine);
                Assert.False(string.IsNullOrEmpty(opt.EngineVersion));
                Assert.False(string.IsNullOrEmpty(opt.LicenseModel));
                Assert.NotNull(opt.MultiAZCapable);
                Assert.NotNull(opt.ReadReplicaCapable);
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"RDS")]
        public void TestFiltering()
        {
            const string engine = "mysql";
            const string engineVersion = "5.1.73a";

            var desResponse = Client.DescribeDBEngineVersionsAsync(new DescribeDBEngineVersionsRequest { Engine = engine }).Result;

            var response = Client.DescribeOrderableDBInstanceOptionsAsync(new DescribeOrderableDBInstanceOptionsRequest
            {
                Engine = engine,
                EngineVersion = engineVersion
            }).Result;

            Assert.NotNull(response);
            foreach (var opt in response.OrderableDBInstanceOptions)
            {
                Assert.Equal(engine, opt.Engine);
                Assert.Equal(engineVersion, opt.EngineVersion);
            }

            /*
             * Filter on a license model which is not restricted
             */
            var publicLicenseResponse = Client.DescribeOrderableDBInstanceOptionsAsync(new DescribeOrderableDBInstanceOptionsRequest
            {
                Engine = engine,
                LicenseModel = "general-public-license"
            }).Result;

            Assert.NotNull(publicLicenseResponse);
        }
        
        [Fact]
        [Trait(CategoryAttribute,"RDS")]
        public void TestPagination()
        {
            const string engine = "mysql";
            DescribeOrderableDBInstanceOptionsResponse response, oldResponse = null;
            var numResults = 0;
            const int pageSize = 20;  // min page size

            string marker = null;
            do {
                response = Client.DescribeOrderableDBInstanceOptionsAsync(new DescribeOrderableDBInstanceOptionsRequest
                {
                    Engine = engine,
                    MaxRecords = pageSize,
                    Marker = marker,
                }).Result;

                Assert.NotNull(response);
                Assert.True(response.OrderableDBInstanceOptions.Count <= pageSize);

                if (oldResponse != null)
                {
                    Assert.True(!response.OrderableDBInstanceOptions.Intersect(oldResponse.OrderableDBInstanceOptions).Any());
                }

                numResults += response.OrderableDBInstanceOptions.Count;
                marker = response.Marker;
                oldResponse = response;
            } while (!string.IsNullOrEmpty(response.Marker));
        }

        [Fact]
        [Trait(CategoryAttribute,"RDS")]
        public void TestInvalidParam()
        {
            var ex = AssertExtensions.ExpectExceptionAsync<AmazonRDSException>(Client.DescribeOrderableDBInstanceOptionsAsync(
                new DescribeOrderableDBInstanceOptionsRequest
                {
                    Engine = "mysql",
                    LicenseModel = "not-a-valid-license",
                })).Result;

            Assert.NotNull(ex.Message);
            Assert.True(ex.Message.IndexOf("license model", StringComparison.OrdinalIgnoreCase) >= 0);
        }
        
        [Fact]
        [Trait(CategoryAttribute,"RDS")]
        public void TestEngineMissing()
        {
            var ex = AssertExtensions
                .ExpectExceptionAsync<AmazonRDSException>
                (Client.DescribeOrderableDBInstanceOptionsAsync(new DescribeOrderableDBInstanceOptionsRequest()))
                .Result;
            Assert.NotNull(ex.Message);
            Assert.True(ex.Message.IndexOf("Invalid DB engine", StringComparison.OrdinalIgnoreCase) >= 0);
        }
    }
}
