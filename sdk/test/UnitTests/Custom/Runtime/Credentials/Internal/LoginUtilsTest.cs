using Amazon.Runtime;
using Amazon.Runtime.Credentials.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class LoginUtilsTest
    {
        [TestMethod]
        public void ExtractLoginSessionFromIdentityToken_ValidToken_ReturnsSession()
        {
            // JWT with payload: {"sub":"arn:aws:signin::123456789012:identity/test-session"}
            var jwt = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJhcm46YXdzOnNpZ25pbjo6MTIzNDU2Nzg5MDEyOmlkZW50aXR5L3Rlc3Qtc2Vzc2lvbiJ9.signature";
            
            var result = LoginUtils.ExtractLoginSessionFromIdentityToken(jwt);
            
            Assert.AreEqual("arn:aws:signin::123456789012:identity/test-session", result);
        }

        [TestMethod]
        public void ExtractAccountIdFromLoginSessionArn_ValidArn_ReturnsAccountId()
        {
            var arn = "arn:aws:signin::123456789012:identity/test-session";
            
            var result = LoginUtils.ExtractAccountIdFromLoginSessionArn(arn);
            
            Assert.AreEqual("123456789012", result);
        }

        [TestMethod]
        public void ExtractAccountIdFromLoginSessionArn_InvalidArn_ReturnsNull()
        {
            var invalidArn = "invalid-arn";
            
            Assert.IsNull(LoginUtils.ExtractAccountIdFromLoginSessionArn(invalidArn));
        }

        [TestMethod]
        public void IsExpired_ExpiredToken_ReturnsTrue()
        {
            var expiredToken = new LoginToken
            {
                AccessToken = new LoginImmutableCredentials("key", "secret", "token", DateTime.UtcNow.AddMinutes(-1), "123456789012")
            };
            
            Assert.IsTrue(expiredToken.IsExpired());
        }

        [TestMethod]
        public void IsExpired_ValidToken_ReturnsFalse()
        {
            var validToken = new LoginToken
            {
                AccessToken = new LoginImmutableCredentials("key", "secret", "token", DateTime.UtcNow.AddHours(1), "123456789012")
            };
            
            Assert.IsFalse(validToken.IsExpired());
        }

        [TestMethod]
        public void NeedsRefresh_TokenExpiringIn5Minutes_ReturnsTrue()
        {
            var tokenNearExpiry = new LoginToken
            {
                AccessToken = new LoginImmutableCredentials("key", "secret", "token", DateTime.UtcNow.AddMinutes(5), "123456789012")
            };
            
            Assert.IsTrue(tokenNearExpiry.NeedsRefresh());
        }

        [TestMethod]
        public void NeedsRefresh_TokenExpiringIn10Minutes_ReturnsFalse()
        {
            var tokenNotNearExpiry = new LoginToken
            {
                AccessToken = new LoginImmutableCredentials("key", "secret", "token", DateTime.UtcNow.AddMinutes(10), "123456789012")
            };
            
            Assert.IsFalse(tokenNotNearExpiry.NeedsRefresh());
        }

        [TestMethod]
        public void CanRefresh_TokenWithRefreshData_ReturnsTrue()
        {
            var refreshableToken = new LoginToken
            {
                RefreshToken = "refresh-token",
                ClientId = "client-id"
            };
            
            Assert.IsTrue(refreshableToken.CanRefresh());
        }

        [TestMethod]
        public void CanRefresh_TokenWithoutRefreshData_ReturnsFalse()
        {
            var nonRefreshableToken = new LoginToken();
            
            Assert.IsFalse(nonRefreshableToken.CanRefresh());
        }

        [TestMethod]
        public void ToJson_ValidToken_ReturnsJsonString()
        {
            var token = new LoginToken
            {
                AccessToken = new LoginImmutableCredentials("key", "secret", "token", DateTime.UtcNow.AddHours(1), "123456789012"),
                RefreshToken = "refresh-token"
            };
            
            var json = LoginUtils.ToJson(token);
            
            Assert.IsTrue(json.Contains("accessToken"));
            Assert.IsTrue(json.Contains("refreshToken"));
        }

        [TestMethod]
        public void FromJson_ValidJson_ReturnsToken()
        {
            var json = "{\"accessToken\":{\"accessKeyId\":\"key\",\"secretAccessKey\":\"secret\",\"sessionToken\":\"token\",\"accountId\":\"123456789012\",\"expiresAt\":\"2024-12-31T23:59:59.999Z\"},\"tokenType\":\"aws_sigv4\",\"idToken\":\"id-token\",\"refreshToken\":\"refresh-token\",\"clientId\":\"client-id\",\"dpopKey\":\"dpop-key\"}";
            
            var token = LoginUtils.FromJson(json);
            
            Assert.AreEqual("key", token.AccessToken.AccessKey);
            Assert.AreEqual("secret", token.AccessToken.SecretKey);
            Assert.AreEqual("token", token.AccessToken.Token);
            Assert.AreEqual("123456789012", token.AccessToken.AccountId);
            Assert.AreEqual("aws_sigv4", token.TokenType);
            Assert.AreEqual("id-token", token.IdentityToken);
            Assert.AreEqual("refresh-token", token.RefreshToken);
            Assert.AreEqual("client-id", token.ClientId);
            Assert.AreEqual("dpop-key", token.DPoPKey);
        }

        [TestMethod]
        public void Base64UrlDecode_ValidInput_ReturnsDecodedBytes()
        {
            var input = "SGVsbG8gV29ybGQ";
            
            var result = LoginUtils.Base64UrlDecode(input);
            var decoded = System.Text.Encoding.UTF8.GetString(result);
            
            Assert.AreEqual("Hello World", decoded);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsExpired_NullToken_ThrowsArgumentNullException()
        {
            LoginUtils.IsExpired(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ExtractLoginSessionFromIdentityToken_InvalidJwtFormat_ThrowsArgumentException()
        {
            LoginUtils.ExtractLoginSessionFromIdentityToken("invalid.jwt");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ExtractLoginSessionFromIdentityToken_MissingSubClaim_ThrowsInvalidOperationException()
        {
            var jwt = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJub3N1YiI6InRlc3QifQ.signature";
            LoginUtils.ExtractLoginSessionFromIdentityToken(jwt);
        }

        [TestMethod]
        public void Base64UrlEncode_NullInput_ReturnsNull()
        {
            Assert.IsNull(LoginUtils.Base64UrlEncode(null));
        }

        [TestMethod]
        public void Base64UrlDecode_NullInput_ReturnsNull()
        {
            Assert.IsNull(LoginUtils.Base64UrlDecode(null));
        }

        [TestMethod]
        public void ExtractAccountIdFromLoginSessionArn_NullInput_ReturnsNull()
        {
            Assert.IsNull(LoginUtils.ExtractAccountIdFromLoginSessionArn(null));
        }

        [TestMethod]
        public void ExtractAccountIdFromLoginSessionArn_EmptyString_ReturnsNull()
        {
            Assert.IsNull(LoginUtils.ExtractAccountIdFromLoginSessionArn(""));
        }

        [TestMethod]
        public void ExtractAccountIdFromLoginSessionArn_WhitespaceOnly_ReturnsNull()
        {
            Assert.IsNull(LoginUtils.ExtractAccountIdFromLoginSessionArn("   "));
        }

        [TestMethod]
        public void AsJson_ValidToken_ReturnsJsonString()
        {
            var token = new LoginToken
            {
                AccessToken = new LoginImmutableCredentials("key", "secret", "token", DateTime.UtcNow.AddHours(1), "123456789012"),
                RefreshToken = "refresh-token"
            };
            
            var json = token.AsJson();
            
            Assert.IsTrue(json.Contains("accessToken"));
            Assert.IsTrue(json.Contains("refreshToken"));
        }

        [TestMethod]
        public void NeedsRefresh_TokenExpiringExactlyAt6Minutes_ReturnsTrue()
        {
            var token = new LoginToken
            {
                AccessToken = new LoginImmutableCredentials("key", "secret", "token", DateTime.UtcNow.AddMinutes(6), "123456789012")
            };
            
            Assert.IsTrue(token.NeedsRefresh());
        }

        [TestMethod]
        public void CanRefresh_TokenWithEmptyRefreshToken_ReturnsFalse()
        {
            var token = new LoginToken
            {
                RefreshToken = "",
                ClientId = "client-id"
            };
            
            Assert.IsFalse(token.CanRefresh());
        }

        [TestMethod]
        public void CanRefresh_TokenWithEmptyClientId_ReturnsFalse()
        {
            var token = new LoginToken
            {
                RefreshToken = "refresh-token",
                ClientId = ""
            };
            
            Assert.IsFalse(token.CanRefresh());
        }
    }
}