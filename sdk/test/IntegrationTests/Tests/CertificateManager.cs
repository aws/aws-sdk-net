using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AWSSDK_DotNet.IntegrationTests.Utils;

using Amazon;
using Amazon.CertificateManager;
using Amazon.CertificateManager.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class CertificateManagerTests : TestBase<Amazon.CertificateManager.AmazonCertificateManagerClient>
    {
        [ClassCleanup]
        public static void ClassCleanup()
        {
            BaseClean();
        }


        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
        }

        [TestMethod]
        [TestCategory("CertificateManager")]
        public void TestListCertificates()
        {
            var response = Client.ListCertificates();
            Assert.IsNotNull(response);

            if (response.CertificateSummaryList.Any())
            {
                foreach (var c in response.CertificateSummaryList)
                {
                    Assert.IsFalse(string.IsNullOrEmpty(c.CertificateArn));
                    Assert.IsFalse(string.IsNullOrEmpty(c.DomainName));
                }
            }
        }

    }
}
