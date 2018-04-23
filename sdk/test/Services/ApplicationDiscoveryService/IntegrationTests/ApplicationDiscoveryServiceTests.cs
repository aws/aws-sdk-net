using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AWSSDK_DotNet.IntegrationTests.Utils;

using Amazon.Runtime;
using Amazon.ApplicationDiscoveryService;
using Amazon.ApplicationDiscoveryService.Model;
using Amazon;
using System.IO;
using System.Text;
using Amazon.APIGateway.Model;
using Amazon.APIGateway;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class ApplicationDiscoveryServiceTests : TestBase<AmazonApplicationDiscoveryServiceClient>
    {
        [TestMethod]
        [TestCategory("ApplicationDiscoveryService")]
        public void TestListConfigurations()
        {
            IAmazonApplicationDiscoveryService client = new AmazonApplicationDiscoveryServiceClient(RegionEndpoint.USWest2);
            try
            {
                ListConfigurationsRequest request = new ListConfigurationsRequest { ConfigurationType = ConfigurationItemType.PROCESS };
                ListConfigurationsResponse response = client.ListConfigurations(request);
                Assert.IsNotNull(response.ResponseMetadata.RequestId);
            }
            catch (AmazonApplicationDiscoveryServiceException e)
            {
                // We're really just making sure we can contact this service.
                // So an error from the service that the account isn't whitelisted is acceptable.
                if (!e.Message.Contains("is not whitelisted to access"))
                    throw;
            }
        }
    }
}