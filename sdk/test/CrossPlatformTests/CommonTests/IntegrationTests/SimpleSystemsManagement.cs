using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


using Amazon.SimpleSystemsManagement;
using Amazon.SimpleSystemsManagement.Model;
using NUnit.Framework;
using CommonTests.Framework;

namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class SimpleSystemsManagement : TestBase<AmazonSimpleSystemsManagementClient>
    {
        [Test]
        [Category("SimpleSystemsManagement")]
        public void TestListDocuments()
        {
            var response = Client.ListDocumentsAsync().Result;
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
