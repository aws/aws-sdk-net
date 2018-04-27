using Amazon.SimpleWorkflow;
using Amazon.SimpleWorkflow.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class SimpleWorkflow : TestBase<AmazonSimpleWorkflowClient>
    {
        [TestMethod]
        [TestCategory("SimpleWorkflow")]
        public void SmokeTest()
        {
            var listDomainsRequest = new ListDomainsRequest
            {
                RegistrationStatus = RegistrationStatus.REGISTERED
            };
            var listDomainsResponse = Client.ListDomains(listDomainsRequest);
            Assert.AreEqual(listDomainsResponse.HttpStatusCode, System.Net.HttpStatusCode.OK);
        }
    }
}
