using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.SimpleSystemsManagement;
using Amazon.SimpleSystemsManagement.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class SimpleSystemsManagement : TestBase<AmazonSimpleSystemsManagementClient>
    {
        [TestMethod]
        [TestCategory("SimpleSystemsManagement")]
        public void TestListDocuments()
        {
            var response = Client.ListDocuments();
            Assert.IsNotNull(response);

            // if test a/c had some documents, iterate through
            // to verify marshal
            if (response.DocumentIdentifiers.Count > 0)
            {
                foreach (var d in response.DocumentIdentifiers)
                {
                    Assert.IsFalse(string.IsNullOrEmpty(d.Name));
                }
            }
        }
    }
}
