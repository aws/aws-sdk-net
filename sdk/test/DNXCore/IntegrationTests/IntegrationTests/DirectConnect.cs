using System;
using Amazon.DirectConnect;
using Amazon.DirectConnect.Model;
using Xunit;
using Amazon.DNXCore.IntegrationTests;

namespace Amazon.DNXCore.IntegrationTests
{
    
    public class DirectConnect : TestBase<AmazonDirectConnectClient>
    {
        [Fact]
        [Trait(CategoryAttribute,"DirectConnect")]
        public void TestDescribeConnections()
        {
            var response = Client.DescribeConnectionsAsync().Result;
            Assert.NotNull(response);

            if (response.Connections.Count > 0)
            {
                // if we got some connections, verify that the data that is
                // mandatory when creating a connection marshalled correctly
                foreach (var c in response.Connections)
                {
                    Assert.False(string.IsNullOrEmpty(c.ConnectionId));
                    Assert.False(string.IsNullOrEmpty(c.ConnectionName));
                    Assert.False(string.IsNullOrEmpty(c.Location));
                    Assert.False(string.IsNullOrEmpty(c.Bandwidth));
                }
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"DirectConnect")]
        public void TestDescribeLocations()
        {
            var response = Client.DescribeLocationsAsync().Result;
            Assert.NotNull(response);

            if (response.Locations.Count > 0)
            {
                foreach (var l in response.Locations)
                {
                    Assert.False(string.IsNullOrEmpty(l.LocationCode));
                    Assert.False(string.IsNullOrEmpty(l.LocationName));
                }
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"DirectConnect")]
        public void TestDescribeVirtualGateways()
        {
            var response = Client.DescribeVirtualGatewaysAsync().Result;
            Assert.NotNull(response);

            if (response.VirtualGateways.Count > 0)
            {
                foreach (var vg in response.VirtualGateways)
                {
                    Assert.False(string.IsNullOrEmpty(vg.VirtualGatewayId));
                    Assert.False(string.IsNullOrEmpty(vg.VirtualGatewayState));
                }
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"DirectConnect")]
        public void TestDescribeVirtualInterfaces()
        {
            var response = Client.DescribeVirtualInterfacesAsync().Result;
            Assert.NotNull(response);

            if (response.VirtualInterfaces.Count > 0)
            {
                foreach (var vi in response.VirtualInterfaces)
                {
                    Assert.False(string.IsNullOrEmpty(vi.ConnectionId));
                    Assert.False(string.IsNullOrEmpty(vi.VirtualInterfaceId));
                }
            }
        }

        // Test constraint: account must have permissions to create connections
        //[Fact]
        //[Trait(CategoryAttribute,"DirectConnect")]
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
