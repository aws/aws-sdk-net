using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Amazon.Auth.AccessControlPolicy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

using AWSSDK_DotNet.IntegrationTests.Utils;

using Amazon.ServerMigrationService;
using Amazon.ServerMigrationService.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class SMS:TestBase<AmazonServerMigrationServiceClient>
    {
        [TestMethod]
        [TestCategory("ServerMigrationService")]
        public void SMSGetConnectors()
        {
            GetConnectorsResponse getConnectorResponse = Client.GetConnectors(new GetConnectorsRequest());
        }
    }
}
