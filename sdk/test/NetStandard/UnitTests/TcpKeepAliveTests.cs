using System;
using Xunit;
using Amazon;
using Amazon.Runtime;

namespace UnitTests
{
    public class TcpKeepAliveTests
    {
        [Fact]
        [Trait("Category", "Core")]
        public void TcpKeepAlive_Defaults_EnabledFalseTimeout5MinInterval15Sec()
        {
            var tcpKeepAlive = new TcpKeepAlive();

            Assert.False(tcpKeepAlive.Enabled);
            Assert.Equal(TimeSpan.FromMinutes(5), tcpKeepAlive.Timeout);
            Assert.Equal(TimeSpan.FromSeconds(15), tcpKeepAlive.Interval);
        }

        [Fact]
        [Trait("Category", "Core")]
        public void ClientConfig_TcpKeepAliveProperty_IsAccessible()
        {
            var config = new MyClientConfig();
            config.RegionEndpoint = RegionEndpoint.USEast1;

            Assert.NotNull(config.TcpKeepAlive);
            Assert.IsType<TcpKeepAlive>(config.TcpKeepAlive);
        }

        [Fact]
        [Trait("Category", "Core")]
        public void Validate_TcpKeepAliveEnabledNullTimeout_Throws()
        {
            var config = new MyClientConfig();
            config.RegionEndpoint = RegionEndpoint.USEast1;
            config.TcpKeepAlive.Enabled = true;
            config.TcpKeepAlive.Timeout = null;

            Assert.Throws<ArgumentNullException>(() => config.Validate());
        }

        [Fact]
        [Trait("Category", "Core")]
        public void Validate_TcpKeepAliveEnabledNullInterval_Throws()
        {
            var config = new MyClientConfig();
            config.RegionEndpoint = RegionEndpoint.USEast1;
            config.TcpKeepAlive.Enabled = true;
            config.TcpKeepAlive.Interval = null;

            Assert.Throws<ArgumentNullException>(() => config.Validate());
        }

        [Fact]
        [Trait("Category", "Core")]
        public void Validate_TcpKeepAliveEnabledWithValidValues_Succeeds()
        {
            var config = new MyClientConfig();
            config.RegionEndpoint = RegionEndpoint.USEast1;
            config.TcpKeepAlive.Enabled = true;

            config.Validate(); // Should not throw with default valid values
        }

        [Fact]
        [Trait("Category", "Core")]
        public void Validate_TcpKeepAliveDisabled_SkipsValidation()
        {
            var config = new MyClientConfig();
            config.RegionEndpoint = RegionEndpoint.USEast1;
            config.TcpKeepAlive.Enabled = false;
            config.TcpKeepAlive.Timeout = null;
            config.TcpKeepAlive.Interval = null;

            config.Validate(); // Should not throw when disabled
        }
    }
}
