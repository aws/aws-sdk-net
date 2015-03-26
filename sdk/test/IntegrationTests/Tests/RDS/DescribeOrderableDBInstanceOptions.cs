using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.RDS;
using Amazon.RDS.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests.RDS
{
    [TestClass]
    public class DescribeOrderableDBInstanceOptions: TestBase<AmazonRDSClient>
    {
        [TestMethod]
        [TestCategory("RDS")]
        public void TestDescribeOrderableDBInstanceOptions()
        {
            const string engine = "mysql";
            var response =
                Client.DescribeOrderableDBInstanceOptions(new DescribeOrderableDBInstanceOptionsRequest
                {
                    Engine = engine
                });
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

        [TestMethod]
        [TestCategory("RDS")]
        public void TestFiltering()
        {
            const string engine = "mysql";
            const string engineVersion = "5.1.73a";

            var desResponse = Client.DescribeDBEngineVersions(new DescribeDBEngineVersionsRequest { Engine = engine });

            var response = Client.DescribeOrderableDBInstanceOptions(new DescribeOrderableDBInstanceOptionsRequest
            {
                Engine = engine,
                EngineVersion = engineVersion
            });

            Assert.IsNotNull(response);
            foreach (var opt in response.OrderableDBInstanceOptions)
            {
                Assert.AreEqual(engine, opt.Engine);
                Assert.AreEqual(engineVersion, opt.EngineVersion);
            }

            /*
             * Filter on a license model which is not restricted
             */
            var publicLicenseResponse = Client.DescribeOrderableDBInstanceOptions(new DescribeOrderableDBInstanceOptionsRequest
            {
                Engine = engine,
                LicenseModel = "general-public-license"
            });

            Assert.IsNotNull(publicLicenseResponse);
        }
        
        [TestMethod]
        [TestCategory("RDS")]
        public void TestPagination()
        {
            const string engine = "mysql";
            DescribeOrderableDBInstanceOptionsResponse response, oldResponse = null;
            var numResults = 0;
            const int pageSize = 20;  // min page size

            string marker = null;
            do {
                response = Client.DescribeOrderableDBInstanceOptions(new DescribeOrderableDBInstanceOptionsRequest
                {
                    Engine = engine,
                    MaxRecords = pageSize,
                    Marker = marker,
                });

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

        [TestMethod]
        [TestCategory("RDS")]
        public void TestInvalidParam()
        {
            try
            {
                Client.DescribeOrderableDBInstanceOptions(new DescribeOrderableDBInstanceOptionsRequest
                    {
                        Engine = "mysql",
                        LicenseModel = "not-a-valid-license",
                    });
            }
            catch (AmazonRDSException ex)
            {
                Assert.IsNotNull(ex.Message);
                Assert.IsTrue(ex.Message.IndexOf("license model", StringComparison.OrdinalIgnoreCase) >= 0);
                return;
            }
            catch (Exception ex)
            {
                Assert.Fail("Unexpected exception thrown:" + ex);
            }

            Assert.Fail("No exception thrown");
        }
        
        [TestMethod]
        [TestCategory("RDS")]
        public void TestEngineMissing()
        {
            try
            {
                Client.DescribeOrderableDBInstanceOptions(new DescribeOrderableDBInstanceOptionsRequest());
            }
            catch (AmazonRDSException ex)
            {
                Assert.IsNotNull(ex.Message);
                Assert.IsTrue(ex.Message.IndexOf("Invalid DB engine", StringComparison.OrdinalIgnoreCase) >= 0);
                return;
            }
            catch (Exception ex)
            {
                Assert.Fail("Unexpected exception thrown:" + ex);
            }

            Assert.Fail("No exception thrown");
        }
    }
}
