/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.Runtime;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.SharedInterfaces;
using Amazon.Util;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AWSSDK.UnitTests.Runtime
{
    /// <summary>
    /// Tests <see cref="SSOTokenProvider"/>
    /// </summary>
    [TestClass]
    public class SSOTokenProviderTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [DataTestMethod]
        [DynamicData(nameof(TestCases), DynamicDataSourceType.Method)]
        public void CachedTokenVariationCases(TestCase testCase)
        {
            // ARRANGE
            var sessionName = "admin";
            var startUrl = "https://d-abc123.awsapps.com/start";
            var cacheFile = "d033e22ae348aeb5660fc2140aec35850c4da997.json";
            var testCacheFolder = "test";

            var mockSSOOIDCClient = new Mock<ICoreAmazonSSOOIDC>(MockBehavior.Strict);
            if (null != testCase.MockSSOOIDCCLientRefreshDetails)
            {
                var responseFactory = new Func<GetSsoTokenResponse, GetSsoTokenResponse>(req =>
                    // duplicate CoreAmazonSSOOIDC.RefreshToken logic
                    new GetSsoTokenResponse
                    {
                        AccessToken = testCase.MockSSOOIDCCLientRefreshDetails.RefreshResponse.AccessToken,
                        ExpiresAt = testCase.MockSSOOIDCCLientRefreshDetails.RefreshResponse.ExpiresAt,
                        RefreshToken = testCase.MockSSOOIDCCLientRefreshDetails.RefreshResponse.RefreshToken,
                        ClientId = req.ClientId,
                        ClientSecret = req.ClientSecret,
                        Region = req.Region,
                        RegistrationExpiresAt = req.RegistrationExpiresAt,
                        StartUrl = req.StartUrl
                    });

                mockSSOOIDCClient
                    .Setup(x =>
                        x.RefreshToken(It.Is<GetSsoTokenResponse>(r => testCase.MockSSOOIDCCLientRefreshDetails.RefreshRequestMatchCriteria(r))))
                    .Returns(responseFactory);
            }
            
            var mockFileSystem = new MockFileSystem();
            mockFileSystem.WriteAllText(
                Path.Combine(testCacheFolder, cacheFile),
                testCase.CachedToken);

            var ssoTokenManager = new SSOTokenManager(
                mockSSOOIDCClient.Object,
                new SSOTokenFileCache(
                    CryptoUtilFactory.CryptoInstance,
                    mockFileSystem,
                    mockFileSystem));

            var ssoTokenProvider =
                new SSOTokenProvider(
                    ssoTokenManager,
                    sessionName,
                    startUrl,
                    "test-region",
                    testCacheFolder);

            bool success = false;
            AWSToken token = null;
            Exception exception = null;

            using (new AWSConfigsDateFaker(() => testCase.CurrentTime.ToUniversalTime()))
            {
                // ACT
                try
                {
                    success = ssoTokenProvider.TryResolveToken(out token);
                }
                catch (Exception e)
                {
                    exception = e;
                }

                // ASSERT
                if (null != testCase.AssertOnAWSToken)
                {
                    Assert.IsNotNull(token, $"token {exception?.Message}");
                    Assert.IsTrue(success);
                    testCase.AssertOnAWSToken(token);
                }

                if (null != testCase.AssertException)
                {
                    Assert.IsNotNull(exception, "exception");
                    Assert.IsFalse(success);
                    testCase.AssertException(exception);
                }

                if (null != testCase.AssertOnCachedSsoToken)
                {
                    var cachedTokenGetOptions = new SSOTokenManagerGetTokenOptions
                    {
                        Session = sessionName,
                        StartUrl = startUrl,
                        CacheFolderLocation = testCacheFolder,
                        SupportsGettingNewToken = false
                    };

                    var cachedToken = ssoTokenManager.GetToken(cachedTokenGetOptions);

                    testCase.AssertOnCachedSsoToken(cachedToken);
                }
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [DataTestMethod]
        [DynamicData(nameof(TestCases), DynamicDataSourceType.Method)]
        public async Task CachedTokenVariationCasesAsync(TestCase testCase)
        {
            // ARRANGE
            var sessionName = "admin";
            var startUrl = "https://d-abc123.awsapps.com/start";
            var cacheFile = "d033e22ae348aeb5660fc2140aec35850c4da997.json";
            var testCacheFolder = "test";

            var mockSSOOIDCClient = new Mock<ICoreAmazonSSOOIDC>(MockBehavior.Strict);
            if (null != testCase.MockSSOOIDCCLientRefreshDetails)
            {
                var asyncResponseFactory = new Func<GetSsoTokenResponse, Task<GetSsoTokenResponse>>(req =>
                    // duplicate CoreAmazonSSOOIDC.RefreshToken logic
                    Task.FromResult(new GetSsoTokenResponse
                    {
                        AccessToken = testCase.MockSSOOIDCCLientRefreshDetails.RefreshResponse.AccessToken,
                        ExpiresAt = testCase.MockSSOOIDCCLientRefreshDetails.RefreshResponse.ExpiresAt,
                        RefreshToken = testCase.MockSSOOIDCCLientRefreshDetails.RefreshResponse.RefreshToken,
                        ClientId = req.ClientId,
                        ClientSecret = req.ClientSecret,
                        Region = req.Region,
                        RegistrationExpiresAt = req.RegistrationExpiresAt,
                        StartUrl = req.StartUrl
                    }));
                
                mockSSOOIDCClient
                    .Setup(x =>
                        x.RefreshTokenAsync(It.Is<GetSsoTokenResponse>(r => testCase.MockSSOOIDCCLientRefreshDetails.RefreshRequestMatchCriteria(r))))
                    .Returns(asyncResponseFactory);
            }

            var mockFileSystem = new MockFileSystem();
            mockFileSystem.WriteAllText(
                Path.Combine(testCacheFolder, cacheFile),
                testCase.CachedToken);

            var ssoTokenManager = new SSOTokenManager(
                mockSSOOIDCClient.Object,
                new SSOTokenFileCache(
                    CryptoUtilFactory.CryptoInstance,
                    mockFileSystem,
                    mockFileSystem));

            var ssoTokenProvider =
                new SSOTokenProvider(
                    ssoTokenManager,
                    sessionName,
                    startUrl,
                    "test-region",
                    testCacheFolder);

            bool success = false;
            AWSToken token = null;
            Exception exception = null;

            using (new AWSConfigsDateFaker(() => testCase.CurrentTime.ToUniversalTime()))
            {
                // ACT
                try
                {
                    var result = await ssoTokenProvider.TryResolveTokenAsync();
                    success = result.Success;
                    token = result.Value;
                }
                catch (Exception e)
                {
                    exception = e;
                }

                // ASSERT
                if (null != testCase.AssertOnAWSToken)
                {
                    Assert.IsNotNull(token, $"token {exception?.Message}");
                    Assert.IsTrue(success);
                    testCase.AssertOnAWSToken(token);
                }

                if (null != testCase.AssertException)
                {
                    Assert.IsNotNull(exception, "exception");
                    Assert.IsFalse(success);
                    testCase.AssertException(exception);
                }

                if (null != testCase.AssertOnCachedSsoToken)
                {
                    var cachedTokenGetOptions = new SSOTokenManagerGetTokenOptions
                    {
                        Session = sessionName,
                        StartUrl = startUrl,
                        CacheFolderLocation = testCacheFolder,
                        SupportsGettingNewToken = false
                    };

                    testCase.AssertOnCachedSsoToken(await ssoTokenManager.GetTokenAsync(cachedTokenGetOptions));
                }
            }
        }

        public static IEnumerable<object[]> TestCases()
        {
            // Valid token with all fields
            yield return new object[] {new TestCase
            {
                TestName = "Valid Token with all fields",
                CurrentTime = DateTime.Parse("2021-12-25T13:30:00Z"),
                CachedToken = @"
                {
                    ""startUrl"": ""https://d-123.awsapps.com/start"",
                    ""region"": ""us-west-2"",
                    ""accessToken"": ""cachedtoken"",
                    ""expiresAt"": ""2021-12-25T21:30:00Z"",
                    ""clientId"": ""clientid"",
                    ""clientSecret"": ""YSBzZWNyZXQ="",
                    ""registrationExpiresAt"": ""2022-12-25T13:30:00Z"",
                    ""refreshToken"": ""cachedrefreshtoken""
                }",
                AssertOnAWSToken = token =>
                {
                    Assert.AreEqual("cachedtoken", token.Token);
                    Assert.AreEqual(DateTime.Parse("2021-12-25T21:30:00Z").ToUniversalTime(), token.ExpiresAt);
                }
            }};
            
            // Minimal valid cached token
            yield return new object[] {new TestCase
            {
                TestName = "Minimal valid cached token",
                CurrentTime = DateTime.Parse("2021-12-25T13:30:00Z"),
                CachedToken = @"{
                ""accessToken"": ""cachedtoken"",
                ""expiresAt"": ""2021-12-25T21:30:00Z""
                }",
                AssertOnAWSToken = token =>
                {
                    Assert.AreEqual("cachedtoken", token.Token);
                    Assert.AreEqual(DateTime.Parse("2021-12-25T21:30:00Z").ToUniversalTime(), token.ExpiresAt);
                }
            }};
            
            // Minimal expired cached token
            yield return new object[] {new TestCase
            {
                TestName = "Minimal expired cached token",
                CurrentTime = DateTime.Parse("2021-12-25T13:30:00Z"),
                CachedToken = @"{
                    ""accessToken"": ""cachedtoken"",
                    ""expiresAt"": ""2021-12-25T13:00:00Z""
                }",
                AssertException = e =>
                {
                    Assert.IsInstanceOfType(e, typeof(AmazonClientException));
                    Assert.IsTrue(e.Message.StartsWith("SSO Token has expired"), e.Message);
                }
            }};

            // Token missing the expiresAt fields
            yield return new object[] {new TestCase
            {
                TestName = "Token missing the expiresAt fields",
                CurrentTime = DateTime.Parse("2021-12-25T13:30:00Z"),
                CachedToken = @"{
                    ""accessToken"": ""cachedtoken""
                }",
                AssertException = e =>
                {
                    Assert.IsInstanceOfType(e, typeof(AmazonClientException));
                    Assert.IsTrue(e.Message.StartsWith("No valid SSO Token"), e.Message);
                }
            }};

            // Token missing the accessToken field
            yield return new object[] {new TestCase
            {
                TestName = "Token missing the accessToken field",
                CurrentTime = DateTime.Parse("2021-12-25T13:30:00Z"),
                CachedToken = @"{
                    ""expiresAt"": ""2021-12-25T13:00:00Z""
                }",
                AssertException = e =>
                {
                    Assert.IsInstanceOfType(e, typeof(AmazonClientException));
                    Assert.IsTrue(e.Message.StartsWith("No valid SSO Token"), e.Message);
                }
            }};

            // Expired token refresh with refresh token
            yield return new object[] {new TestCase
            {
                TestName = " Expired token refresh with refresh token",
                CurrentTime = DateTime.Parse("2021-12-25T13:30:00Z"),
                CachedToken = @"
                {
                    ""startUrl"": ""https://d-123.awsapps.com/start"",
                    ""region"": ""us-west-2"",
                    ""accessToken"": ""cachedtoken"",
                    ""expiresAt"": ""2021-12-25T13:00:00Z"",
                    ""clientId"": ""clientid"",
                    ""clientSecret"": ""YSBzZWNyZXQ="",
                    ""registrationExpiresAt"": ""2022-12-25T13:30:00Z"",
                    ""refreshToken"": ""cachedrefreshtoken""
                }",
                MockSSOOIDCCLientRefreshDetails = new TestCaseMockRefreshDetails
                {
                    RefreshRequestMatchCriteria = r =>
                        r.RefreshToken == "cachedrefreshtoken" &&
                        r.ClientId == "clientid" &&
                        r.ClientSecret == "YSBzZWNyZXQ=",

                    RefreshResponse = new GetSsoTokenResponse
                    {
                        AccessToken = "newtoken",
                        RefreshToken = "newrefreshtoken",
                        ExpiresAt =
                            DateTime.Parse("2021-12-25T13:30:00Z")
                                .ToUniversalTime()
                                .AddSeconds(28800)
                    }
                },
                AssertOnCachedSsoToken = ssoToken =>
                {
                    Assert.AreEqual("https://d-123.awsapps.com/start", ssoToken.StartUrl);
                    Assert.AreEqual("us-west-2", ssoToken.Region);
                    Assert.AreEqual("newtoken", ssoToken.AccessToken);
                    Assert.AreEqual(DateTime.Parse("2021-12-25T21:30:00Z").ToUniversalTime(), ssoToken.ExpiresAt);
                    Assert.AreEqual("clientid", ssoToken.ClientId);
                    Assert.AreEqual("YSBzZWNyZXQ=", ssoToken.ClientSecret);
                    Assert.AreEqual("2022-12-25T13:30:00Z", ssoToken.RegistrationExpiresAt);
                    Assert.AreEqual("newrefreshtoken", ssoToken.RefreshToken);
                },
                AssertOnAWSToken = token =>
                {
                    Assert.AreEqual("newtoken", token.Token);
                    Assert.AreEqual(DateTime.Parse("2021-12-25T21:30:00Z").ToUniversalTime(), token.ExpiresAt);
                }
            }};

            // Expired token refresh without new refresh token
            yield return new object[] {new TestCase
            {
                TestName = "Expired token refresh without new refresh token",
                CurrentTime = DateTime.Parse("2021-12-25T13:30:00Z"),
                CachedToken = @"
                {
                    ""startUrl"": ""https://d-123.awsapps.com/start"",
                    ""region"": ""us-west-2"",
                    ""accessToken"": ""cachedtoken"",
                    ""expiresAt"": ""2021-12-25T13:00:00Z"",
                    ""clientId"": ""clientid"",
                    ""clientSecret"": ""YSBzZWNyZXQ="",
                    ""registrationExpiresAt"": ""2022-12-25T13:30:00Z"",
                    ""refreshToken"": ""cachedrefreshtoken""
                }",
                MockSSOOIDCCLientRefreshDetails = new TestCaseMockRefreshDetails
                {
                    RefreshRequestMatchCriteria = r =>
                        r.RefreshToken == "cachedrefreshtoken" &&
                        r.ClientId == "clientid" &&
                        r.ClientSecret == "YSBzZWNyZXQ=",
                    RefreshResponse = new GetSsoTokenResponse
                    {
                        AccessToken = "newtoken",
                        ExpiresAt =
                            DateTime.Parse("2021-12-25T13:30:00Z")
                                .ToUniversalTime()
                                .AddSeconds(28800)
                    }
                },
                AssertOnCachedSsoToken = ssoToken =>
                {
                    Assert.AreEqual("https://d-123.awsapps.com/start", ssoToken.StartUrl);
                    Assert.AreEqual("us-west-2", ssoToken.Region);
                    Assert.AreEqual("newtoken", ssoToken.AccessToken);
                    Assert.AreEqual(DateTime.Parse("2021-12-25T21:30:00Z").ToUniversalTime(), ssoToken.ExpiresAt);
                    Assert.AreEqual("clientid", ssoToken.ClientId);
                    Assert.AreEqual("YSBzZWNyZXQ=", ssoToken.ClientSecret);
                    Assert.AreEqual("2022-12-25T13:30:00Z", ssoToken.RegistrationExpiresAt);
                    Assert.IsNull(ssoToken.RefreshToken);
                },
                AssertOnAWSToken = token =>
                {
                    Assert.AreEqual("newtoken", token.Token);
                    Assert.AreEqual(DateTime.Parse("2021-12-25T21:30:00Z").ToUniversalTime(), token.ExpiresAt);
                }
            }};

            // Expired token and expired client registration
            yield return new object[] {new TestCase
            {
                TestName = "Expired token and expired client registration",
                CurrentTime = DateTime.Parse("2021-12-25T13:30:00Z"),
                CachedToken = @"
                {
                    ""startUrl"": ""https://d-123.awsapps.com/start"",
                    ""region"": ""us-west-2"",
                    ""accessToken"": ""cachedtoken"",
                    ""expiresAt"": ""2021-10-25T13:00:00Z"",
                    ""clientId"": ""clientid"",
                    ""clientSecret"": ""YSBzZWNyZXQ="",
                    ""registrationExpiresAt"": ""2022-12-25T13:30:00Z"",
                    ""refreshToken"": ""cachedrefreshtoken""
                }",
                AssertException = e => 
                {
                    Assert.IsInstanceOfType(e, typeof(AmazonClientException));
                    Assert.IsTrue(e.Message.StartsWith("SSO Token has expired and failed to refresh"), e.Message);
                }
            }};
        }

        public class TestCase
        {
            public string TestName  { get; set; }
            public DateTime CurrentTime { get; set; } = DateTime.UtcNow;
            public string CachedToken { get; set; }
            public TestCaseMockRefreshDetails MockSSOOIDCCLientRefreshDetails { get; set; }
            public Action<AWSToken> AssertOnAWSToken { get; set; }
            public Action<Exception> AssertException { get; set; }
            public Action<SsoToken> AssertOnCachedSsoToken { get; set; }
        }

        public class TestCaseMockRefreshDetails
        {
            public Func<GetSsoTokenResponse, bool> RefreshRequestMatchCriteria { get; set; }
            public GetSsoTokenResponse RefreshResponse { get; set; }
        }
    }
}