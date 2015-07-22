using System;
using System.Linq;
using NUnit.Framework;
using CommonTests.Framework;

using Amazon.RDS;
using Amazon.RDS.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests.RDS
{
    [TestFixture]
    public class DescribeOrderableDBInstanceOptions: TestBase<AmazonRDSClient>
    {
        [Test]
        [Category("RDS")]
        public void TestDescribeOrderableDBInstanceOptions()
        {
            const string engine = "mysql";
            var response =
                Client.DescribeOrderableDBInstanceOptionsAsync(new DescribeOrderableDBInstanceOptionsRequest
                {
                    Engine = engine
                }).Result;
            Assert.IsNotNull(response);

            Assert.IsNotNull(response.OrderableDBInstanceOptions);
            foreach (var opt in response.OrderableDBInstanceOptions)
            {
                Assert.IsNotNull(opt.AvailabilityZones);
                Assert.IsTrue(opt.AvailabilityZones.Count > 0);
                Assert.IsFalse(string.IsNullOrEmpty(opt.DBInstanceClass));
                Assert.AreEqual(engine, opt.Engine);
                Assert.IsFalse(string.IsNullOrEmpty(opt.EngineVersion));
                Assert.IsFalse(string.IsNullOrEmpty(opt.LicenseModel));
                Assert.IsNotNull(opt.MultiAZCapable);
                Assert.IsNotNull(opt.ReadReplicaCapable);
            }
        }

        [Test]
        [Category("RDS")]
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

            Assert.IsNotNull(response);
            foreach (var opt in response.OrderableDBInstanceOptions)
            {
                Assert.AreEqual(engine, opt.Engine);
                Assert.AreEqual(engineVersion, opt.EngineVersion);
            }

            /*
             * Filter on a license model which is not restricted
             */
            var publicLicenseResponse = Client.DescribeOrderableDBInstanceOptionsAsync(new DescribeOrderableDBInstanceOptionsRequest
            {
                Engine = engine,
                LicenseModel = "general-public-license"
            }).Result;

            Assert.IsNotNull(publicLicenseResponse);
        }
        
        [Test]
        [Category("RDS")]
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

                Assert.IsNotNull(response);
                Assert.IsTrue(response.OrderableDBInstanceOptions.Count <= pageSize);

                if (oldResponse != null)
                {
                    Assert.IsTrue(!response.OrderableDBInstanceOptions.Intersect(oldResponse.OrderableDBInstanceOptions).Any());
                }

                numResults += response.OrderableDBInstanceOptions.Count;
                marker = response.Marker;
                oldResponse = response;
            } while (!string.IsNullOrEmpty(response.Marker));
        }

        [Test]
        [Category("RDS")]
        public void TestInvalidParam()
        {
            var ex = AssertExtensions.ExpectExceptionAsync<AmazonRDSException>(Client.DescribeOrderableDBInstanceOptionsAsync(
                new DescribeOrderableDBInstanceOptionsRequest
                {
                    Engine = "mysql",
                    LicenseModel = "not-a-valid-license",
                })).Result;

            Assert.IsNotNull(ex.Message);
            Assert.IsTrue(ex.Message.IndexOf("license model", StringComparison.OrdinalIgnoreCase) >= 0);
        }
        
        [Test]
        [Category("RDS")]
        public void TestEngineMissing()
        {
            var ex = AssertExtensions
                .ExpectExceptionAsync<AmazonRDSException>
                (Client.DescribeOrderableDBInstanceOptionsAsync(new DescribeOrderableDBInstanceOptionsRequest()))
                .Result;
            Assert.IsNotNull(ex.Message);
            Assert.IsTrue(ex.Message.IndexOf("Invalid DB engine", StringComparison.OrdinalIgnoreCase) >= 0);
        }
    }
}
