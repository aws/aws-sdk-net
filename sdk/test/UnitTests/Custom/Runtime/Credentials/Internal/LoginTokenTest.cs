using Amazon.Runtime;
using Amazon.Runtime.Credentials.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.Json;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class LoginTokenTest
    {
        [TestMethod]
        public void NeedsRefresh_ExpiredToken_ReturnsTrue()
        {
            var token = new LoginToken
            {
                AccessToken = new LoginImmutableCredentials("key", "secret", "token", DateTime.UtcNow.AddMinutes(-1), "123456789012")
            };

            Assert.IsTrue(token.NeedsRefresh());
        }

        [TestMethod]
        public void NeedsRefresh_ValidToken_ReturnsFalse()
        {
            var token = new LoginToken
            {
                AccessToken = new LoginImmutableCredentials("key", "secret", "token", DateTime.UtcNow.AddHours(1), "123456789012")
            };

            Assert.IsFalse(token.NeedsRefresh());
        }

        [TestMethod]
        public void CanRefresh_WithRefreshToken_ReturnsTrue()
        {
            var token = new LoginToken
            {
                RefreshToken = "refresh-token",
                ClientId = "client-id"
            };

            Assert.IsTrue(token.CanRefresh());
        }

        [TestMethod]
        public void CanRefresh_NoRefreshToken_ReturnsFalse()
        {
            var token = new LoginToken
            {
                RefreshToken = null
            };

            Assert.IsFalse(token.CanRefresh());
        }

        [TestMethod]
        public void IsExpired_ExpiredToken_ReturnsTrue()
        {
            var token = new LoginToken
            {
                AccessToken = new LoginImmutableCredentials("key", "secret", "token", DateTime.UtcNow.AddMinutes(-1), "123456789012")
            };

            Assert.IsTrue(token.IsExpired());
        }

        [TestMethod]
        public void IsExpired_ValidToken_ReturnsFalse()
        {
            var token = new LoginToken
            {
                AccessToken = new LoginImmutableCredentials("key", "secret", "token", DateTime.UtcNow.AddHours(1), "123456789012")
            };

            Assert.IsFalse(token.IsExpired());
        }

        [TestMethod]
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

            var json = JsonSerializer.Serialize(token);
            var deserializedToken = JsonSerializer.Deserialize<LoginToken>(json);

            Assert.AreEqual(token.TokenType, deserializedToken.TokenType);
            Assert.AreEqual(token.IdentityToken, deserializedToken.IdentityToken);
            Assert.AreEqual(token.RefreshToken, deserializedToken.RefreshToken);
            Assert.AreEqual(token.ClientId, deserializedToken.ClientId);
            Assert.AreEqual(token.DPoPKey, deserializedToken.DPoPKey);
        }
    }
}