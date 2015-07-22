using System;

using System.Linq;

using Amazon;
using Amazon.CloudHSM;
using Amazon.CloudHSM.Model;
using NUnit.Framework;
using CommonTests.Framework;

namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class CloudHSM : TestBase<AmazonCloudHSMClient>
    {
        [Test]
        public void TestSimpleMethods()
        {
            var zones = Client.ListAvailableZonesAsync().Result.AZList;
            Assert.IsNotNull(zones);
            Assert.IsTrue(zones.Count > 0);
            var hsms = Client.ListHsmsAsync().Result.HsmList;
            Assert.IsNotNull(hsms);
        }

        [Test]
        public void TestHapg()
        {
            var arn = Client.CreateHapgAsync(new CreateHapgRequest { Label = UtilityMethods.GenerateName() }).Result.HapgArn;
            Assert.IsNotNull(arn);

            var hapgs = Client.ListHapgsAsync().Result.HapgList;
            Assert.IsTrue(hapgs.Contains(arn));

            var status = Client.DeleteHapgAsync(arn).Result.Status;

            Assert.IsNotNull(status);
        }
    }
}
