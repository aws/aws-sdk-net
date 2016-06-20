using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Linq;

using Amazon;
using Amazon.CloudHSM;
using Amazon.CloudHSM.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class CloudHSM : TestBase<AmazonCloudHSMClient>
    {
        [TestMethod]
        [TestCategory("CloudHSM")]
        public void TestSimpleMethods()
        {
            var zones = Client.ListAvailableZones().AZList;
            Assert.IsNotNull(zones);
            Assert.IsTrue(zones.Count > 0);
            var hsms = Client.ListHsms().HsmList;
            Assert.IsNotNull(hsms);
        }

        [TestMethod]
        [TestCategory("CloudHSM")]
        public void TestHapg()
        {
            var arn = Client.CreateHapg(new CreateHapgRequest { Label = Utils.UtilityMethods.GenerateName() }).HapgArn;
            Assert.IsNotNull(arn);

            var hapgs = Client.ListHapgs().HapgList;
            Assert.IsTrue(hapgs.Contains(arn));

            var status = Client.DeleteHapg(arn).Status;

            Assert.IsNotNull(status);
        }
    }
}
