using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.SSOOIDC;
using Amazon.SSOOIDC.Model;

namespace AWSSDKDocSamples.Amazon.SSOOIDC.Generated
{
    class SSOOIDCSamples : ISample
    {
        public void SSOOIDCCreateToken()
        {
            #region create-token-for-device-code

            var client = new AmazonSSOOIDCClient();
            var response = client.CreateToken(new CreateTokenRequest 
            {
                ClientId = "_yzkThXVzLWVhc3QtMQEXAMPLECLIENTID",
                ClientSecret = "VERYLONGSECRETeyJraWQiOiJrZXktMTU2NDAyODA5OSIsImFsZyI6IkhTMzg0In0",
                DeviceCode = "yJraWQiOiJrZXktMTU2Njk2ODA4OCIsImFsZyI6IkhTMzIn0EXAMPLEDEVICECODE",
                GrantType = "urn:ietf:params:oauth:grant-type:device-code"
            });

            string accessToken = response.AccessToken;
            int expiresIn = response.ExpiresIn;
            string refreshToken = response.RefreshToken;
            string tokenType = response.TokenType;

            #endregion
        }

        public void SSOOIDCCreateToken()
        {
            #region create-token-for-refresh-token

            var client = new AmazonSSOOIDCClient();
            var response = client.CreateToken(new CreateTokenRequest 
            {
                ClientId = "_yzkThXVzLWVhc3QtMQEXAMPLECLIENTID",
                ClientSecret = "VERYLONGSECRETeyJraWQiOiJrZXktMTU2NDAyODA5OSIsImFsZyI6IkhTMzg0In0",
                GrantType = "refresh_token",
                RefreshToken = "aorvJYubGpU6i91YnH7Mfo-AT2fIVa1zCfA_Rvq9yjVKIP3onFmmykuQ7E93y2I-9Nyj-A_sVvMufaLNL0bqnDRtgAkc0:MGUCMFrRsktMRVlWaOR70XGMFGLL0SlcCw4DiYveIiOVx1uK9BbD0gvAddsW3UTLozXKMgIxAJ3qxUvjpnlLIOaaKOoa/FuNgqJVvr9GMwDtnAtlh9iZzAkEXAMPLEREFRESHTOKEN",
                Scope = new List<string> {
                    "codewhisperer:completions"
                }
            });

            string accessToken = response.AccessToken;
            int expiresIn = response.ExpiresIn;
            string refreshToken = response.RefreshToken;
            string tokenType = response.TokenType;

            #endregion
        }

        public void SSOOIDCCreateTokenWithIAM()
        {
            #region create-token-with-iam-for-auth-code

            var client = new AmazonSSOOIDCClient();
            var response = client.CreateTokenWithIAM(new CreateTokenWithIAMRequest 
            {
                ClientId = "arn:aws:sso::123456789012:application/ssoins-111111111111/apl-222222222222",
                Code = "yJraWQiOiJrZXktMTU2Njk2ODA4OCIsImFsZyI6IkhTMzg0In0EXAMPLEAUTHCODE",
                GrantType = "authorization_code",
                RedirectUri = "https://mywebapp.example/redirect",
                Scope = new List<string> {
                    "openid",
                    "aws",
                    "sts:identity_context"
                }
            });

            string accessToken = response.AccessToken;
            AwsAdditionalDetails awsAdditionalDetails = response.AwsAdditionalDetails;
            int expiresIn = response.ExpiresIn;
            string idToken = response.IdToken;
            string issuedTokenType = response.IssuedTokenType;
            string refreshToken = response.RefreshToken;
            List<string> scope = response.Scope;
            string tokenType = response.TokenType;

            #endregion
        }

        public void SSOOIDCCreateTokenWithIAM()
        {
            #region create-token-with-iam-for-refresh-token

            var client = new AmazonSSOOIDCClient();
            var response = client.CreateTokenWithIAM(new CreateTokenWithIAMRequest 
            {
                ClientId = "arn:aws:sso::123456789012:application/ssoins-111111111111/apl-222222222222",
                GrantType = "refresh_token",
                RefreshToken = "aorvJYubGpU6i91YnH7Mfo-AT2fIVa1zCfA_Rvq9yjVKIP3onFmmykuQ7E93y2I-9Nyj-A_sVvMufaLNL0bqnDRtgAkc0:MGUCMFrRsktMRVlWaOR70XGMFGLL0SlcCw4DiYveIiOVx1uK9BbD0gvAddsW3UTLozXKMgIxAJ3qxUvjpnlLIOaaKOoa/FuNgqJVvr9GMwDtnAtlh9iZzAkEXAMPLEREFRESHTOKEN"
            });

            string accessToken = response.AccessToken;
            int expiresIn = response.ExpiresIn;
            string issuedTokenType = response.IssuedTokenType;
            string refreshToken = response.RefreshToken;
            List<string> scope = response.Scope;
            string tokenType = response.TokenType;

            #endregion
        }

        public void SSOOIDCCreateTokenWithIAM()
        {
            #region create-token-with-iam-for-jwt-bearer

            var client = new AmazonSSOOIDCClient();
            var response = client.CreateTokenWithIAM(new CreateTokenWithIAMRequest 
            {
                Assertion = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6IjFMVE16YWtpaGlSbGFfOHoyQkVKVlhlV01xbyJ9.eyJ2ZXIiOiIyLjAiLCJpc3MiOiJodHRwczovL2xvZ2luLm1pY3Jvc29mdG9ubGluZS5jb20vOTEyMjA0MGQtNmM2Ny00YzViLWIxMTItMzZhMzA0YjY2ZGFkL3YyLjAiLCJzdWIiOiJBQUFBQUFBQUFBQUFBQUFBQUFBQUFJa3pxRlZyU2FTYUZIeTc4MmJidGFRIiwiYXVkIjoiNmNiMDQwMTgtYTNmNS00NmE3LWI5OTUtOTQwYzc4ZjVhZWYzIiwiZXhwIjoxNTM2MzYxNDExLCJpYXQiOjE1MzYyNzQ3MTEsIm5iZiI6MTUzNjI3NDcxMSwibmFtZSI6IkFiZSBMaW5jb2xuIiwicHJlZmVycmVkX3VzZXJuYW1lIjoiQWJlTGlAbWljcm9zb2Z0LmNvbSIsIm9pZCI6IjAwMDAwMDAwLTAwMDAtMDAwMC02NmYzLTMzMzJlY2E3ZWE4MSIsInRpZCI6IjkxMjIwNDBkLTZjNjctNGM1Yi1iMTEyLTM2YTMwNGI2NmRhZCIsIm5vbmNlIjoiMTIzNTIzIiwiYWlvIjoiRGYyVVZYTDFpeCFsTUNXTVNPSkJjRmF0emNHZnZGR2hqS3Y4cTVnMHg3MzJkUjVNQjVCaXN2R1FPN1lXQnlqZDhpUURMcSFlR2JJRGFreXA1bW5PcmNkcUhlWVNubHRlcFFtUnA2QUlaOGpZIn0.1AFWW-Ck5nROwSlltm7GzZvDwUkqvhSQpm55TQsmVo9Y59cLhRXpvB8n-55HCr9Z6G_31_UbeUkoz612I2j_Sm9FFShSDDjoaLQr54CreGIJvjtmS3EkK9a7SJBbcpL1MpUtlfygow39tFjY7EVNW9plWUvRrTgVk7lYLprvfzw-CIqw3gHC-T7IK_m_xkr08INERBtaecwhTeN4chPC4W3jdmw_lIxzC48YoQ0dB1L9-ImX98Egypfrlbm0IBL5spFzL6JDZIRRJOu8vecJvj1mq-IUhGt0MacxX8jdxYLP-KUu2d9MbNKpCKJuZ7p8gwTL5B7NlUdh_dmSviPWrw",
                ClientId = "arn:aws:sso::123456789012:application/ssoins-111111111111/apl-222222222222",
                GrantType = "urn:ietf:params:oauth:grant-type:jwt-bearer"
            });

            string accessToken = response.AccessToken;
            AwsAdditionalDetails awsAdditionalDetails = response.AwsAdditionalDetails;
            int expiresIn = response.ExpiresIn;
            string idToken = response.IdToken;
            string issuedTokenType = response.IssuedTokenType;
            string refreshToken = response.RefreshToken;
            List<string> scope = response.Scope;
            string tokenType = response.TokenType;

            #endregion
        }

        public void SSOOIDCCreateTokenWithIAM()
        {
            #region create-token-with-iam-for-token-exchange

            var client = new AmazonSSOOIDCClient();
            var response = client.CreateTokenWithIAM(new CreateTokenWithIAMRequest 
            {
                ClientId = "arn:aws:sso::123456789012:application/ssoins-111111111111/apl-222222222222",
                GrantType = "urn:ietf:params:oauth:grant-type:token-exchange",
                RequestedTokenType = "urn:ietf:params:oauth:token-type:access_token",
                SubjectToken = "aoak-Hig8TUDPNX1xZwOMXM5MxOWDL0E0jg9P6_C_jKQPxS_SKCP6f0kh1Up4g7TtvQqkMnD-GJiU_S1gvug6SrggAkc0:MGYCMQD3IatVjV7jAJU91kK3PkS/SfA2wtgWzOgZWDOR7sDGN9t0phCZz5It/aes/3C1Zj0CMQCKWOgRaiz6AIhza3DSXQNMLjRKXC8F8ceCsHlgYLMZ7hZDIFFERENTACCESSTOKEN",
                SubjectTokenType = "urn:ietf:params:oauth:token-type:access_token"
            });

            string accessToken = response.AccessToken;
            AwsAdditionalDetails awsAdditionalDetails = response.AwsAdditionalDetails;
            int expiresIn = response.ExpiresIn;
            string idToken = response.IdToken;
            string issuedTokenType = response.IssuedTokenType;
            List<string> scope = response.Scope;
            string tokenType = response.TokenType;

            #endregion
        }

        public void SSOOIDCRegisterClient()
        {
            #region register-client

            var client = new AmazonSSOOIDCClient();
            var response = client.RegisterClient(new RegisterClientRequest 
            {
                ClientName = "My IDE Plugin",
                ClientType = "public",
                EntitledApplicationArn = "arn:aws:sso::ACCOUNTID:application/ssoins-1111111111111111/apl-1111111111111111",
                GrantTypes = new List<string> {
                    "authorization_code",
                    "refresh_token"
                },
                IssuerUrl = "https://identitycenter.amazonaws.com/ssoins-1111111111111111",
                RedirectUris = new List<string> {
                    "127.0.0.1:PORT/oauth/callback"
                },
                Scopes = new List<string> {
                    "sso:account:access",
                    "codewhisperer:completions"
                }
            });

            string clientId = response.ClientId;
            long clientIdIssuedAt = response.ClientIdIssuedAt;
            string clientSecret = response.ClientSecret;
            long clientSecretExpiresAt = response.ClientSecretExpiresAt;

            #endregion
        }

        public void SSOOIDCStartDeviceAuthorization()
        {
            #region start-device-authorization

            var client = new AmazonSSOOIDCClient();
            var response = client.StartDeviceAuthorization(new StartDeviceAuthorizationRequest 
            {
                ClientId = "_yzkThXVzLWVhc3QtMQEXAMPLECLIENTID",
                ClientSecret = "VERYLONGSECRETeyJraWQiOiJrZXktMTU2NDAyODA5OSIsImFsZyI6IkhTMzg0In0",
                StartUrl = "https://identitycenter.amazonaws.com/ssoins-111111111111"
            });

            string deviceCode = response.DeviceCode;
            int expiresIn = response.ExpiresIn;
            int interval = response.Interval;
            string userCode = response.UserCode;
            string verificationUri = response.VerificationUri;
            string verificationUriComplete = response.VerificationUriComplete;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}