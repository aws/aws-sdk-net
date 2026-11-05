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
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// S3 Express sessions must never be shared between clients that use different credentials,
    /// even when those clients are built from the same <see cref="AmazonS3Config"/> instance.
    /// </summary>
    [TestClass]
    public class S3ExpressSharedConfigTests
    {
        private const string Bucket = "bucket--use1-az4--x-s3";
        private const string OtherBucket = "other--use1-az4--x-s3";

        // CreateSession returns a session named after the access key that signed it, so every
        // data-plane request shows which identity's session it carries.
        private class Handler : HttpMessageHandler
        {
            public readonly List<string> CreateSessionKeys = new List<string>();
            public readonly List<string> DataPlaneTokens = new List<string>();

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
                {
                    lock (DataPlaneTokens)
                        DataPlaneTokens.Add(request.Headers.TryGetValues("x-amz-s3session-token", out var values) ? values.First() : null);
                }
                return Task.FromResult(new HttpResponseMessage { Content = new StringContent(body) });
            }

            protected override HttpResponseMessage Send(HttpRequestMessage request, CancellationToken token) => SendAsync(request, token).Result;
        }

        private class Factory : HttpClientFactory
        {
            public readonly Handler Handler = new Handler();
            public override HttpClient CreateHttpClient(IClientConfig config) => new HttpClient(Handler, false);
        }

        private class SwitchableCredentials : AWSCredentials
        {
            public string Key = "AKIAFIRST";
            public override ImmutableCredentials GetCredentials() => new ImmutableCredentials(Key, "secret" + Key, null);
        }

        private class TrackingProvider : IS3ExpressCredentialProvider
        {
            public bool Disposed;
            public SessionCredentials ResolveSessionCredentials(string bucketName) =>
                new SessionCredentials { AccessKeyId = "C", SecretAccessKey = "s", SessionToken = "custom-" + bucketName };
            public Task<SessionCredentials> ResolveSessionCredentialsAsync(string bucketName, CancellationToken token = default) =>
                Task.FromResult(ResolveSessionCredentials(bucketName));
            public void Dispose() => Disposed = true;
        }

        private Factory _factory;
        private AmazonS3Config _sharedConfig;

        [TestInitialize]
        public void Initialize()
        {
            _factory = new Factory();
            _sharedConfig = new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USEast1,
                HttpClientFactory = _factory,
                ResponseChecksumValidation = ResponseChecksumValidation.WHEN_REQUIRED,
            };
        }

        private AmazonS3Client Client(string accessKey, string secretKey = null) =>
            new AmazonS3Client(new BasicAWSCredentials(accessKey, secretKey ?? "secret" + accessKey), _sharedConfig);

        private string LastToken => _factory.Handler.DataPlaneTokens.Last();

        [TestMethod]
        [TestCategory("S3")]
        public async Task SharedConfig_Async_EachClientUsesItsOwnSession()
        {
            var victim = Client("AKIAVICTIM");
            await victim.PutObjectAsync(new PutObjectRequest { BucketName = Bucket, Key = "victim-secret", ContentBody = "TOP-SECRET" });
            Assert.AreEqual("session-AKIAVICTIM", LastToken);

            var attacker = Client("AKIAATTACKER");
            (await attacker.GetObjectAsync(Bucket, "victim-secret")).Dispose();
            Assert.AreEqual("session-AKIAATTACKER", LastToken);
            await attacker.PutObjectAsync(new PutObjectRequest { BucketName = Bucket, Key = "victim-owned", ContentBody = "x" });
            Assert.AreEqual("session-AKIAATTACKER", LastToken);

            CollectionAssert.AreEqual(new[] { "AKIAVICTIM", "AKIAATTACKER" }, _factory.Handler.CreateSessionKeys);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void SharedConfig_Sync_EachClientUsesItsOwnSession()
        {
            var victim = Client("AKIAVICTIM");
            victim.PutObject(new PutObjectRequest { BucketName = Bucket, Key = "victim-secret", ContentBody = "TOP-SECRET" });
            Assert.AreEqual("session-AKIAVICTIM", LastToken);

            var attacker = Client("AKIAATTACKER");
            attacker.GetObject(new GetObjectRequest { BucketName = Bucket, Key = "victim-secret" }).Dispose();
            Assert.AreEqual("session-AKIAATTACKER", LastToken);
            attacker.PutObject(new PutObjectRequest { BucketName = Bucket, Key = "victim-owned", ContentBody = "x" });
            Assert.AreEqual("session-AKIAATTACKER", LastToken);

            CollectionAssert.AreEqual(new[] { "AKIAVICTIM", "AKIAATTACKER" }, _factory.Handler.CreateSessionKeys);
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task SharedConfig_PresignedUrl_UsesPresigningClientSession()
        {
            (await Client("AKIAVICTIM").GetObjectAsync(Bucket, "key")).Dispose();

            var request = new GetPreSignedUrlRequest { BucketName = Bucket, Key = "key", Expires = DateTime.UtcNow.AddMinutes(1) };
            var attacker = Client("AKIAATTACKER");
            StringAssert.Contains(attacker.GetPreSignedURL(request), "session-AKIAATTACKER");
            StringAssert.Contains(await attacker.GetPreSignedURLAsync(request), "session-AKIAATTACKER");
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task SharedConfig_CredentialsDifferingOnlyBySecret_GetSeparateSessions()
        {
            (await Client("AKIASAME", "secret-one").GetObjectAsync(Bucket, "key")).Dispose();
            (await Client("AKIASAME", "secret-two").GetObjectAsync(Bucket, "key")).Dispose();
            Assert.AreEqual(2, _factory.Handler.CreateSessionKeys.Count);
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task SameClient_ChangedCredentials_CreateNewSession()
        {
            var credentials = new SwitchableCredentials();
            var client = new AmazonS3Client(credentials, _sharedConfig);
            (await client.GetObjectAsync(Bucket, "key")).Dispose();
            Assert.AreEqual("session-AKIAFIRST", LastToken);

            credentials.Key = "AKIASECOND";
            (await client.GetObjectAsync(Bucket, "key")).Dispose();
            Assert.AreEqual("session-AKIASECOND", LastToken);
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task SharedConfig_DisposingOneClient_DoesNotBreakAnother()
        {
            var first = Client("AKIAFIRST");
            (await first.GetObjectAsync(Bucket, "key")).Dispose();
            var second = Client("AKIASECOND");
            first.Dispose();

            // A bucket with no cached session forces a new CreateSession call.
            (await second.GetObjectAsync(OtherBucket, "key")).Dispose();
            Assert.AreEqual("session-AKIASECOND", LastToken);
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task SharedConfig_CustomProvider_IsUsedAndNotDisposedByClients()
        {
            var provider = new TrackingProvider();
            _sharedConfig.S3ExpressCredentialProvider = provider;

            var first = Client("AKIAFIRST");
            (await first.GetObjectAsync(Bucket, "key")).Dispose();
            first.Dispose();
            Assert.IsFalse(provider.Disposed, "A client must not dispose a provider it does not own.");

            (await Client("AKIASECOND").GetObjectAsync(Bucket, "key")).Dispose();
            Assert.AreEqual("custom-" + Bucket, LastToken);
            Assert.AreEqual(0, _factory.Handler.CreateSessionKeys.Count);
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task SharedConfig_ExposesDefaultProvider_ButEachClientUsesItsOwn()
        {
            var first = Client("AKIAFIRST");
            var exposed = _sharedConfig.S3ExpressCredentialProvider;
            Assert.IsNotNull(exposed, "The config still exposes a default provider after client construction.");

            var second = Client("AKIASECOND");
            Assert.AreSame(exposed, _sharedConfig.S3ExpressCredentialProvider);

            (await second.GetObjectAsync(Bucket, "key")).Dispose();
            Assert.AreEqual("session-AKIASECOND", LastToken);
            (await first.GetObjectAsync(Bucket, "key")).Dispose();
            Assert.AreEqual("session-AKIAFIRST", LastToken);
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task Refresh_EvictsSessionWhoseCredentialsChanged()
        {
            var credentials = new SwitchableCredentials();
            (await new AmazonS3Client(credentials, _sharedConfig).GetObjectAsync(Bucket, "key")).Dispose();
            var provider = _sharedConfig.S3ExpressCredentialProvider;
            var cache = ReflectionHelpers.Invoke(provider, "_cache");
            Assert.IsNotNull(ReflectionHelpers.Invoke(cache, "FindOldestItem"));

            credentials.Key = "AKIASECOND";
            ReflectionHelpers.Invoke(provider, "_lastRefreshedTime", DateTime.UtcNow.AddMinutes(-1));
            ReflectionHelpers.Invoke(provider, "RefreshCredentials", (object)null);

            Assert.IsTrue(SpinWait.SpinUntil(() => ReflectionHelpers.Invoke(cache, "FindOldestItem") == null, 5000));
            CollectionAssert.AreEqual(new[] { "AKIAFIRST" }, _factory.Handler.CreateSessionKeys);
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task AnonymousClient_CreatesUnsignedSession()
        {
            (await new AmazonS3Client(new AnonymousAWSCredentials(), _sharedConfig).GetObjectAsync(Bucket, "key")).Dispose();
            Assert.AreEqual("session-", LastToken);
        }
    }
}
#endif
