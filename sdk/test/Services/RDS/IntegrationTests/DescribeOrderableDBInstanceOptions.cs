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
