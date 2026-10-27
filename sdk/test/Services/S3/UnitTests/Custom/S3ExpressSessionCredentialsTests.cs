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
#if NET8_0_OR_GREATER
using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using AWSSDK_DotNet.CommonTest.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class S3ExpressSessionCredentialsTests
    {
        private const string Bucket = "bucket--use1-az4--x-s3";

        // CreateSession returns a session token named after the signing access key.
        private class Handler : HttpMessageHandler
        {
            public readonly List<string> CreateSessionKeys = new List<string>();
            public string LastToken;

            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken token)
            {
                var auth = request.Headers.TryGetValues("Authorization", out var authValues) ? authValues.First() : "";
                var key = Regex.Match(auth, "Credential=([^/]+)/").Groups[1].Value;
                var body = "";
                if (request.RequestUri.Query.Contains("session"))
                {
                    lock (CreateSessionKeys) CreateSessionKeys.Add(key);
                    body = $"<CreateSessionResult><Credentials><SessionToken>session-{key}</SessionToken><SecretAccessKey>s</SecretAccessKey>" +
                        $"<AccessKeyId>S{key}</AccessKeyId><Expiration>{DateTime.UtcNow.AddMinutes(5):yyyy-MM-ddTHH:mm:ssZ}</Expiration></Credentials></CreateSessionResult>";
                }
                else
                    LastToken = request.Headers.TryGetValues("x-amz-s3session-token", out var values) ? values.First() : null;
                return Task.FromResult(new HttpResponseMessage { Content = new StringContent(body) });
            }

            protected override HttpResponseMessage Send(HttpRequestMessage request, CancellationToken token) => SendAsync(request, token).Result;
        }

        private class Factory : HttpClientFactory
        {
            public readonly Handler Handler = new Handler();
            public override HttpClient CreateHttpClient(IClientConfig config) => new HttpClient(Handler, false);
        }

        private class ChangingCredentials : AWSCredentials
        {
            public string Key = "AKIAA";
            public override ImmutableCredentials GetCredentials() => new ImmutableCredentials(Key, "secret" + Key, null);
        }

        private class BucketOnlyProvider : IS3ExpressCredentialProvider
        {
            public SessionCredentials ResolveSessionCredentials(string bucketName) =>
                new SessionCredentials { AccessKeyId = "C", SecretAccessKey = "s", SessionToken = "custom-" + bucketName };
            public Task<SessionCredentials> ResolveSessionCredentialsAsync(string bucketName, CancellationToken token = default) =>
                Task.FromResult(ResolveSessionCredentials(bucketName));
            public void Dispose() { }
        }

        private readonly Factory _factory = new Factory();
        private AmazonS3Config _config;

        [TestInitialize]
        public void Initialize()
        {
            _config = new AmazonS3Config { RegionEndpoint = RegionEndpoint.USEast1, HttpClientFactory = _factory, ResponseChecksumValidation = ResponseChecksumValidation.WHEN_REQUIRED };
        }

        private AmazonS3Client Client(string key) => new AmazonS3Client(new BasicAWSCredentials(key, "secret" + key), _config);

        private async Task<string> Token(AmazonS3Client client)
        {
            (await client.GetObjectAsync(Bucket, "key")).Dispose();
            return _factory.Handler.LastToken;
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task SharedConfig_SessionsArePerCredentials()
        {
            Assert.AreEqual("session-AKIAA", await Token(Client("AKIAA")));
            Assert.AreEqual("session-AKIAB", await Token(Client("AKIAB")));
            Assert.AreEqual("session-AKIAA", await Token(Client("AKIAA")));
            CollectionAssert.AreEqual(new[] { "AKIAA", "AKIAB" }, _factory.Handler.CreateSessionKeys);
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task ChangedClientCredentials_CreateNewSession()
        {
            var credentials = new ChangingCredentials();
            var client = new AmazonS3Client(credentials, _config);
            Assert.AreEqual("session-AKIAA", await Token(client));
            credentials.Key = "AKIAB";
            Assert.AreEqual("session-AKIAB", await Token(client));
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task PresignedUrl_UsesRequestingClientSession()
        {
            await Token(Client("AKIAA"));
            var request = new GetPreSignedUrlRequest { BucketName = Bucket, Key = "key", Expires = DateTime.UtcNow.AddMinutes(1) };
            StringAssert.Contains(Client("AKIAB").GetPreSignedURL(request), "session-AKIAB");
            StringAssert.Contains(await Client("AKIAB").GetPreSignedURLAsync(request), "session-AKIAB");
        }

        private void Refresh()
        {
            ReflectionHelpers.Invoke(_config.S3ExpressCredentialProvider, "_lastRefreshedTime", DateTime.UtcNow.AddMinutes(-1));
            ReflectionHelpers.Invoke(_config.S3ExpressCredentialProvider, "RefreshCredentials", (object)null);
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task Refresh_UsesSessionCredentialsNotProviderClient()
        {
            Client("AKIAA"); // creates the provider
            await Token(Client("AKIAB"));
            Refresh();
            Assert.IsTrue(SpinWait.SpinUntil(() => _factory.Handler.CreateSessionKeys.Count == 2, 5000));
            CollectionAssert.AreEqual(new[] { "AKIAB", "AKIAB" }, _factory.Handler.CreateSessionKeys);
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task Refresh_SkipsSessionWhoseCredentialsChanged()
        {
            var credentials = new ChangingCredentials();
            await Token(new AmazonS3Client(credentials, _config));
            credentials.Key = "AKIAB";
            Refresh();
            Assert.IsTrue(SpinWait.SpinUntil(() => !(bool)ReflectionHelpers.Invoke(_config.S3ExpressCredentialProvider, "_timerStarted"), 5000));
            CollectionAssert.AreEqual(new[] { "AKIAA" }, _factory.Handler.CreateSessionKeys);
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task CacheKey_IsCredentialsHashAndBucketName()
        {
            await Token(Client("AKIAA"));
            var item = ReflectionHelpers.Invoke(ReflectionHelpers.Invoke(_config.S3ExpressCredentialProvider, "_cache"), "FindOldestItem");
            StringAssert.Matches((string)ReflectionHelpers.Invoke(item, "Key"), new Regex("^[0-9a-f]{64}" + Bucket + "$"));
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task CustomProvider_IsCalledWithBucketName()
        {
            _config.S3ExpressCredentialProvider = new BucketOnlyProvider();
            Assert.AreEqual("custom-" + Bucket, await Token(Client("AKIAA")));
            Assert.AreEqual(0, _factory.Handler.CreateSessionKeys.Count);
        }
    }
}
#endif
