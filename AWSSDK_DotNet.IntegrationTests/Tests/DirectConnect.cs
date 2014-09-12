using System;
using Amazon.DirectConnect;
using Amazon.DirectConnect.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class DirectConnect : TestBase<AmazonDirectConnectClient>
    {
        [TestMethod]
        [TestCategory("DirectConnect")]
        public void TestDescribeConnections()
        {
            var response = Client.DescribeConnections();
            Assert.IsNotNull(response);

            if (response.Connections.Count > 0)
            {
                // if we got some connections, verify that the data that is
                // mandatory when creating a connection marshalled correctly
                foreach (var c in response.Connections)
                {
                    Assert.IsFalse(string.IsNullOrEmpty(c.ConnectionId));
                    Assert.IsFalse(string.IsNullOrEmpty(c.ConnectionName));
                    Assert.IsFalse(string.IsNullOrEmpty(c.Location));
                    Assert.IsFalse(string.IsNullOrEmpty(c.Bandwidth));
                }
            }
        }

        [TestMethod]
        [TestCategory("DirectConnect")]
        public void TestDescribeLocations()
        {
            var response = Client.DescribeLocations();
            Assert.IsNotNull(response);

            if (response.Locations.Count > 0)
            {
                foreach (var l in response.Locations)
                {
                    Assert.IsFalse(string.IsNullOrEmpty(l.LocationCode));
                    Assert.IsFalse(string.IsNullOrEmpty(l.LocationName));
                }
            }
        }

        [TestMethod]
        [TestCategory("DirectConnect")]
        public void TestDescribeVirtualGateways()
        {
            var response = Client.DescribeVirtualGateways();
            Assert.IsNotNull(response);

            if (response.VirtualGateways.Count > 0)
            {
                foreach (var vg in response.VirtualGateways)
                {
                    Assert.IsFalse(string.IsNullOrEmpty(vg.VirtualGatewayId));
                    Assert.IsFalse(string.IsNullOrEmpty(vg.VirtualGatewayState));
                }
            }
        }

        [TestMethod]
        [TestCategory("DirectConnect")]
        public void TestDescribeVirtualInterfaces()
        {
            var response = Client.DescribeVirtualInterfaces();
            Assert.IsNotNull(response);

            if (response.VirtualInterfaces.Count > 0)
            {
                foreach (var vi in response.VirtualInterfaces)
                {
                    Assert.IsFalse(string.IsNullOrEmpty(vi.ConnectionId));
                    Assert.IsFalse(string.IsNullOrEmpty(vi.VirtualInterfaceId));
                }
            }
        }

        // Test constraint: account must have permissions to create connections
        //[TestMethod]
        //[TestCategory("DirectConnect")]
        public void TestCreateDeleteConnection()
        {
            const string BANDWIDTH = "1Gbps";

            var locations = Client.DescribeLocations().Locations;
            var connectionName = "dotnet-test-connection" + DateTime.Now.Ticks;
            string connectionId = null;

            try
            {
                var connection = Client.CreateConnection(new CreateConnectionRequest
                {
                    Bandwidth = BANDWIDTH,
                    ConnectionName = connectionName,
                    Location = locations[0].LocationCode
                });

                connectionId = connection.ConnectionId;
            }
            finally
            {
                if (!string.IsNullOrEmpty(connectionId))
                    Client.DeleteConnection(new DeleteConnectionRequest { ConnectionId = connectionId });
            }
        }
    }
}
