using Amazon.Runtime;
using Amazon.Runtime.Credentials.Internal;
using Xunit;
using System;

namespace AWSSDK.UnitTests
{
    public class LoginTokenTest
    {
        [Fact]
        public void NeedsRefresh_ExpiredToken_ReturnsTrue()
        {
            var token = new LoginToken
            {
                AccessToken = new LoginImmutableCredentials("key", "secret", "token", DateTime.UtcNow.AddMinutes(-1), "123456789012")
            };

            Assert.True(token.NeedsRefresh());
        }

        [Fact]
        public void NeedsRefresh_ValidToken_ReturnsFalse()
        {
            var token = new LoginToken
            {
                AccessToken = new LoginImmutableCredentials("key", "secret", "token", DateTime.UtcNow.AddHours(1), "123456789012")
            };

            Assert.False(token.NeedsRefresh());
        }

        [Fact]
        public void CanRefresh_WithRefreshToken_ReturnsTrue()
        {
            var token = new LoginToken
            {
                RefreshToken = "refresh-token",
                ClientId = "client-id"
            };

            Assert.True(token.CanRefresh());
        }

        [Fact]
        public void CanRefresh_NoRefreshToken_ReturnsFalse()
        {
            var token = new LoginToken
            {
                RefreshToken = null
            };

            Assert.False(token.CanRefresh());
        }

        [Fact]
        public void IsExpired_ExpiredToken_ReturnsTrue()
        {
            var token = new LoginToken
            {
                AccessToken = new LoginImmutableCredentials("key", "secret", "token", DateTime.UtcNow.AddMinutes(-1), "123456789012")
            };

            Assert.True(token.IsExpired());
        }

        [Fact]
        public void IsExpired_ValidToken_ReturnsFalse()
        {
            var token = new LoginToken
            {
                AccessToken = new LoginImmutableCredentials("key", "secret", "token", DateTime.UtcNow.AddHours(1), "123456789012")
            };

            Assert.False(token.IsExpired());
        }

        [Fact]
        public void JsonSerialization_ValidToken_SerializesCorrectly()
        {
            var token = new LoginToken
            {
                AccessToken = new LoginImmutableCredentials("key", "secret", "token", DateTime.UtcNow.AddHours(1), "123456789012"),
                TokenType = "aws_sigv4",
                IdentityToken = "id-token",
                RefreshToken = "refresh-token",
                ClientId = "client-id",
                DPoPKey = "dpop-key"
            };

            var json = LoginUtils.ToJson(token);
            var deserializedToken = LoginUtils.FromJson(json);

            Assert.Equal(token.TokenType, deserializedToken.TokenType);
            Assert.Equal(token.IdentityToken, deserializedToken.IdentityToken);
            Assert.Equal(token.RefreshToken, deserializedToken.RefreshToken);
            Assert.Equal(token.ClientId, deserializedToken.ClientId);
            Assert.Equal(token.DPoPKey, deserializedToken.DPoPKey);
        }
    }
}