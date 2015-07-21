using System;
using Amazon.DirectConnect;
using Amazon.DirectConnect.Model;
using NUnit.Framework;
using CommonTests.Framework;

namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class DirectConnect : TestBase<AmazonDirectConnectClient>
    {
        [Test]
        [Category("DirectConnect")]
        public void TestDescribeConnections()
        {
            var response = Client.DescribeConnectionsAsync().Result;
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

        [Test]
        [Category("DirectConnect")]
        public void TestDescribeLocations()
        {
            var response = Client.DescribeLocationsAsync().Result;
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

        [Test]
        [Category("DirectConnect")]
        public void TestDescribeVirtualGateways()
        {
            var response = Client.DescribeVirtualGatewaysAsync().Result;
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

        [Test]
        [Category("DirectConnect")]
        public void TestDescribeVirtualInterfaces()
        {
            var response = Client.DescribeVirtualInterfacesAsync().Result;
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
        //[Test]
        //[Category("DirectConnect")]
        public void TestCreateDeleteConnection()
        {
            const string BANDWIDTH = "1Gbps";

            var locations = Client.DescribeLocationsAsync().Result.Locations;
            var connectionName = "dotnet-test-connection" + DateTime.Now.Ticks;
            string connectionId = null;

            try
            {
                var connection = Client.CreateConnectionAsync(new CreateConnectionRequest
                {
                    Bandwidth = BANDWIDTH,
                    ConnectionName = connectionName,
                    Location = locations[0].LocationCode
                }).Result;

                connectionId = connection.ConnectionId;
            }
            finally
            {
                if (!string.IsNullOrEmpty(connectionId))
                    Client.DeleteConnectionAsync(new DeleteConnectionRequest { ConnectionId = connectionId }).Wait();
            }
        }
    }
}
