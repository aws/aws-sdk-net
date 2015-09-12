using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


using Amazon.SimpleSystemsManagement;
using Amazon.SimpleSystemsManagement.Model;
using Xunit;
using Amazon.DNXCore.IntegrationTests;

namespace Amazon.DNXCore.IntegrationTests
{
    
    public class SimpleSystemsManagement : TestBase<AmazonSimpleSystemsManagementClient>
    {
        [Fact]
        [Trait(CategoryAttribute,"SimpleSystemsManagement")]
        public void TestListDocuments()
        {
            var response = Client.ListDocumentsAsync().Result;
            Assert.NotNull(response);

            // if test a/c had some documents, iterate through
            // to verify marshal
            if (response.DocumentIdentifiers.Count > 0)
            {
                foreach (var d in response.DocumentIdentifiers)
                {
                    Assert.False(string.IsNullOrEmpty(d.Name));
                }
            }
        }
    }
}
