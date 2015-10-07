using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.IoT;
using Amazon.IoT.Model;
using Amazon.Runtime;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class IoT : TestBase<AmazonIoTClient>
    {
        [TestMethod]
        public void TestListCall()
        {
            Client.ListPolicies(new ListPoliciesRequest { AscendingOrder = true });
        }

        [TestMethod]
        public void TestThingOperations()
        {
            var thingName = Utils.UtilityMethods.GenerateName();
            var thingArn = Client.CreateThing(new CreateThingRequest
            {
                ThingName = thingName,
                AttributePayload = new AttributePayload { Attributes = new Dictionary<string, string> { { "foo", "bar" } } }
            }).ThingArn;

            Assert.IsNotNull(thingArn);

            var attr = Client.DescribeThing(new DescribeThingRequest { ThingName = thingName }).Attributes;

            Assert.IsTrue(attr.ContainsKey("foo"));
            Assert.AreEqual("bar", attr["foo"]);

            Utils.UtilityMethods.WaitUntilSuccess(() =>
                Client.DeleteThing(new DeleteThingRequest { ThingName = thingName })
            );
        }

        [TestMethod]
        public void TestErrorMessage()
        {
            try
            {
                Client.CreatePolicy("Foobar", "{}");
            }
            catch (AmazonIoTException e)
            {
                Assert.IsNotNull(e.Message);
            }
        }

        [TestMethod]
        public void TestCertificateOperations()
        {
            var response = Client.CreateKeysAndCertificate(new CreateKeysAndCertificateRequest { });
            Assert.IsNotNull(response.CertificateArn);
            Assert.IsNotNull(response.CertificateId);
            Assert.IsNotNull(response.CertificatePem);
            Assert.IsNotNull(response.KeyPair.PublicKey);
            Assert.IsNotNull(response.KeyPair.PrivateKey);

            Utils.UtilityMethods.WaitUntilSuccess(() =>
                Client.DeleteCertificate(new DeleteCertificateRequest { CertificateId = response.CertificateId })
            );
        }
    }
}
