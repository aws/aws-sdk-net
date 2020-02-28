using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class ArnParserTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        public void IsArnTest()
        {
            Assert.IsTrue(Arn.IsArn("arn:aws:s3:::mybucket"));
            Assert.IsFalse(Arn.IsArn("mybucket"));
            Assert.IsFalse(Arn.IsArn("arnfakename"));
            Assert.IsFalse(Arn.IsArn(""));
            Assert.IsFalse(Arn.IsArn(null));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        public void TestValidArns()
        {
            var arn = Arn.Parse("arn:aws:s3:::mybucket");
            Assert.AreEqual("aws", arn.Partition);
            Assert.AreEqual("s3", arn.Service);
            Assert.AreEqual("mybucket", arn.Resource);
            Assert.AreEqual(string.Empty, arn.Region);
            Assert.AreEqual(arn.AccountId, string.Empty);
            Assert.AreEqual("arn:aws:s3:::mybucket", arn.ToString());

            arn = Arn.Parse("arn:partition:service:region:123412341234:resourcetype:resource:qualifier");
            Assert.AreEqual("partition", arn.Partition);
            Assert.AreEqual("service", arn.Service);
            Assert.AreEqual("region", arn.Region);
            Assert.AreEqual("123412341234", arn.AccountId);
            Assert.AreEqual("resourcetype:resource:qualifier", arn.Resource);
            Assert.AreEqual("arn:partition:service:region:123412341234:resourcetype:resource:qualifier", arn.ToString());

            arn = Arn.Parse("arn:partition:service:region:123412341234:resourcetype/resource/qualifier");
            Assert.AreEqual("partition", arn.Partition);
            Assert.AreEqual("service", arn.Service);
            Assert.AreEqual("region", arn.Region);
            Assert.AreEqual("123412341234", arn.AccountId);
            Assert.AreEqual("resourcetype/resource/qualifier", arn.Resource);
            Assert.AreEqual("arn:partition:service:region:123412341234:resourcetype/resource/qualifier", arn.ToString());

            arn = Arn.Parse("arn:partition:service:region:123412341234:resourcetype:resource:qualifier");
            Assert.AreEqual("partition", arn.Partition);
            Assert.AreEqual("service", arn.Service);
            Assert.AreEqual("region", arn.Region);
            Assert.AreEqual("123412341234", arn.AccountId);
            Assert.AreEqual("resourcetype:resource:qualifier", arn.Resource);
            Assert.AreEqual("arn:partition:service:region:123412341234:resourcetype:resource:qualifier", arn.ToString());
        }


        [DataTestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        [DataRow("arn", "ARN is in incorrect format. ARN format is: arn:<partition>:<service>:<region>:<account-id>:<resource>")]
        [DataRow("arn:partition", "ARN is in incorrect format. ARN format is: arn:<partition>:<service>:<region>:<account-id>:<resource>")]
        [DataRow("arn:partition:service", "ARN is in incorrect format. ARN format is: arn:<partition>:<service>:<region>:<account-id>:<resource>")]
        [DataRow("arn:partition:service:region", "ARN is in incorrect format. ARN format is: arn:<partition>:<service>:<region>:<account-id>:<resource>")]
        [DataRow("arn:partition:service:region:account-id", "ARN is in incorrect format. ARN format is: arn:<partition>:<service>:<region>:<account-id>:<resource>")]
        [DataRow("arn::service:region:account-id:resource", "Malformed ARN - no partition specified")]
        [DataRow("arn:partition::region:account-id:resource", "Malformed ARN - no service specified")]
        [DataRow("arn:partition:service:region:account-id:", "Malformed ARN - no resource specified")]
        public void InvalidArnChecks(string arn, string message)
        {
            ArgumentException caught = null;
            try
            {
                Arn.Parse(arn);
            }
            catch(ArgumentException e)
            {
                caught = e;
            }

            Assert.IsNotNull(caught);
            Assert.AreEqual(message, caught.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        [ExpectedException(typeof(ArgumentException))]
        public void IncorrectArnPrefix()
        {
            Arn.Parse("foo:aws:s3:::mybucket");
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullArn()
        {
            Arn.Parse(null);
        }
    }
}
