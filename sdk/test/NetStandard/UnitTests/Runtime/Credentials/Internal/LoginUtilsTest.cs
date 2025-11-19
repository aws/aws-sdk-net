using Amazon.Runtime;
using Amazon.Runtime.Credentials.Internal;
using Xunit;
using System;

namespace AWSSDK.UnitTests
{
    public class LoginUtilsTest
    {
        [Fact]
        public void ExtractLoginSessionFromIdentityToken_ValidToken_ReturnsSession()
        {
            // JWT with payload: {"sub":"arn:aws:signin::123456789012:identity/test-session"}
            var jwt = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJhcm46YXdzOnNpZ25pbjo6MTIzNDU2Nzg5MDEyOmlkZW50aXR5L3Rlc3Qtc2Vzc2lvbiJ9.signature";
            
            var result = LoginUtils.ExtractLoginSessionFromIdentityToken(jwt);
            
            Assert.Equal("arn:aws:signin::123456789012:identity/test-session", result);
        }

        [Fact]
        public void ExtractAccountIdFromLoginSessionArn_ValidArn_ReturnsAccountId()
        {
            var arn = "arn:aws:signin::123456789012:identity/test-session";
            
            var result = LoginUtils.ExtractAccountIdFromLoginSessionArn(arn);
            
            Assert.Equal("123456789012", result);
        }

        [Fact]
        public void ExtractAccountIdFromLoginSessionArn_InvalidArn_ReturnsNull()
        {
            var invalidArn = "invalid-arn";
            
            Assert.Null(LoginUtils.ExtractAccountIdFromLoginSessionArn(invalidArn));
        }

        [Fact]
        public void IsExpired_ExpiredToken_ReturnsTrue()
        {
            var expiredToken = new LoginToken
            {
                AccessToken = new LoginImmutableCredentials("key", "secret", "token", DateTime.UtcNow.AddMinutes(-1), "123456789012")
            };
            
            Assert.True(expiredToken.IsExpired());
        }

        [Fact]
        public void IsExpired_ValidToken_ReturnsFalse()
        {
            var validToken = new LoginToken
            {
                AccessToken = new LoginImmutableCredentials("key", "secret", "token", DateTime.UtcNow.AddHours(1), "123456789012")
            };
            
            Assert.False(validToken.IsExpired());
        }

        [Fact]
        public void NeedsRefresh_TokenExpiringIn5Minutes_ReturnsTrue()
        {
            var tokenNearExpiry = new LoginToken
            {
                AccessToken = new LoginImmutableCredentials("key", "secret", "token", DateTime.UtcNow.AddMinutes(5), "123456789012")
            };
            
            Assert.True(tokenNearExpiry.NeedsRefresh());
        }

        [Fact]
        public void NeedsRefresh_TokenExpiringIn10Minutes_ReturnsFalse()
        {
            var tokenNotNearExpiry = new LoginToken
            {
                AccessToken = new LoginImmutableCredentials("key", "secret", "token", DateTime.UtcNow.AddMinutes(10), "123456789012")
            };
            
            Assert.False(tokenNotNearExpiry.NeedsRefresh());
        }

        [Fact]
        public void CanRefresh_TokenWithRefreshData_ReturnsTrue()
        {
            var refreshableToken = new LoginToken
            {
                RefreshToken = "refresh-token",
                ClientId = "client-id"
            };
            
            Assert.True(refreshableToken.CanRefresh());
        }

        [Fact]
        public void CanRefresh_TokenWithoutRefreshData_ReturnsFalse()
        {
            var nonRefreshableToken = new LoginToken();
            
            Assert.False(nonRefreshableToken.CanRefresh());
        }

        [Fact]
        public void ToJson_ValidToken_ReturnsJsonString()
        {
            var token = new LoginToken
            {
                AccessToken = new LoginImmutableCredentials("key", "secret", "token", DateTime.UtcNow.AddHours(1), "123456789012"),
                RefreshToken = "refresh-token"
            };
            
            var json = LoginUtils.ToJson(token);
            
            Assert.Contains("accessToken", json);
            Assert.Contains("refreshToken", json);
        }

        [Fact]
        public void FromJson_ValidJson_ReturnsToken()
        {
            var json = "{\"accessToken\":{\"accessKeyId\":\"key\",\"secretAccessKey\":\"secret\",\"sessionToken\":\"token\",\"accountId\":\"123456789012\",\"expiresAt\":\"2024-12-31T23:59:59.999Z\"},\"tokenType\":\"aws_sigv4\",\"idToken\":\"id-token\",\"refreshToken\":\"refresh-token\",\"clientId\":\"client-id\",\"dpopKey\":\"dpop-key\"}";
            
            var token = LoginUtils.FromJson(json);
            
            Assert.Equal("key", token.AccessToken.AccessKey);
            Assert.Equal("secret", token.AccessToken.SecretKey);
            Assert.Equal("token", token.AccessToken.Token);
            Assert.Equal("123456789012", token.AccessToken.AccountId);
            Assert.Equal("aws_sigv4", token.TokenType);
            Assert.Equal("id-token", token.IdentityToken);
            Assert.Equal("refresh-token", token.RefreshToken);
            Assert.Equal("client-id", token.ClientId);
            Assert.Equal("dpop-key", token.DPoPKey);
        }

        [Fact]
        public void Base64UrlDecode_ValidInput_ReturnsDecodedBytes()
        {
            var input = "SGVsbG8gV29ybGQ";
            
            var result = LoginUtils.Base64UrlDecode(input);
            var decoded = System.Text.Encoding.UTF8.GetString(result);
            
            Assert.Equal("Hello World", decoded);
        }

        [Fact]
        public void IsExpired_NullToken_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => LoginUtils.IsExpired(null));
        }

        [Fact]
        public void ExtractLoginSessionFromIdentityToken_InvalidJwtFormat_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => LoginUtils.ExtractLoginSessionFromIdentityToken("invalid.jwt"));
        }

        [Fact]
        public void ExtractLoginSessionFromIdentityToken_MissingSubClaim_ThrowsInvalidOperationException()
        {
            var jwt = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJub3N1YiI6InRlc3QifQ.signature";
            Assert.Throws<InvalidOperationException>(() => LoginUtils.ExtractLoginSessionFromIdentityToken(jwt));
        }

        [Fact]
        public void Base64UrlEncode_NullInput_ReturnsNull()
        {
            Assert.Null(LoginUtils.Base64UrlEncode(null));
        }

        [Fact]
        public void Base64UrlDecode_NullInput_ReturnsNull()
        {
            Assert.Null(LoginUtils.Base64UrlDecode(null));
        }

        [Fact]
        public void ExtractAccountIdFromLoginSessionArn_NullInput_ReturnsNull()
        {
            Assert.Null(LoginUtils.ExtractAccountIdFromLoginSessionArn(null));
        }

        [Fact]
        public void ExtractAccountIdFromLoginSessionArn_EmptyString_ReturnsNull()
        {
            Assert.Null(LoginUtils.ExtractAccountIdFromLoginSessionArn(""));
        }

        [Fact]
        public void ExtractAccountIdFromLoginSessionArn_WhitespaceOnly_ReturnsNull()
        {
            Assert.Null(LoginUtils.ExtractAccountIdFromLoginSessionArn("   "));
        }

        [Fact]
        public void AsJson_ValidToken_ReturnsJsonString()
        {
            var token = new LoginToken
            {
                AccessToken = new LoginImmutableCredentials("key", "secret", "token", DateTime.UtcNow.AddHours(1), "123456789012"),
                RefreshToken = "refresh-token"
            };
            
            var json = LoginUtils.ToJson(token);
            
            Assert.Contains("accessToken", json);
            Assert.Contains("refreshToken", json);
        }

        [Fact]
        public void NeedsRefresh_TokenExpiringExactlyAt6Minutes_ReturnsTrue()
        {
            var token = new LoginToken
            {
                AccessToken = new LoginImmutableCredentials("key", "secret", "token", DateTime.UtcNow.AddMinutes(6), "123456789012")
            };
            
            Assert.True(token.NeedsRefresh());
        }

        [Fact]
        public void CanRefresh_TokenWithEmptyRefreshToken_ReturnsFalse()
        {
            var token = new LoginToken
            {
                RefreshToken = "",
                ClientId = "client-id"
            };
            
            Assert.False(token.CanRefresh());
        }

        [Fact]
        public void CanRefresh_TokenWithEmptyClientId_ReturnsFalse()
        {
            var token = new LoginToken
            {
                RefreshToken = "refresh-token",
                ClientId = ""
            };
            
            Assert.False(token.CanRefresh());
        }
    }
}