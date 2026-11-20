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
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.SharedInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Tests for the retry that <see cref="AssumeRoleWithWebIdentityCredentials"/> makes, within one refresh, when STS
    /// rejects the web identity token as expired: the provider reads the token file again and calls STS again.
    /// <list type="bullet">
    /// <item>The asynchronous refresh awaits the wait before each retry instead of blocking a thread while it holds the
    /// refresh lock.</item>
    /// <item>One STS client is created for the refresh and used for every attempt.</item>
    /// </list>
    /// The asynchronous wait is replaced by one the test completes, so no test waits for it.
    /// </summary>
    [TestClass]
    [TestCategory("UnitTest")]
    [TestCategory("Runtime")]
    public class CredentialRefreshWebIdentityTests
    {
        private static readonly TimeSpan WaitTimeout = TimeSpan.FromSeconds(30);

        // The STS client wraps the service's ExpiredTokenException in an AmazonClientException.
        private static AmazonClientException WrappedExpiredToken() =>
            new AmazonClientException("Error calling AssumeRole for role arn:aws:iam::123456789012:role/test",
                new AmazonServiceException("The web identity token that was passed is expired.", ErrorType.Sender,
                    "ExpiredTokenException", "req-id", HttpStatusCode.BadRequest));

        private static AssumeRoleImmutableCredentials NewCredentials() =>
            new AssumeRoleImmutableCredentials("ASIAWEBIDENTITY", "secret", "token", DateTime.UtcNow.AddHours(1));

        [TestMethod]
        public async Task ExpiredWebIdentityToken_AsyncRefresh_AwaitsEachWaitAndUsesOneStsClient()
        {
            var tokenPath = WriteTokenFile();
            try
            {
                var stsCalls = 0;
                var sts = new Mock<ICoreAmazonSTS>();
                sts.Setup(c => c.CredentialsFromAssumeRoleWithWebIdentityAuthenticationAsync(It.IsAny<string>(), It.IsAny<string>(),
                        It.IsAny<string>(), It.IsAny<AssumeRoleWithWebIdentityCredentialsOptions>()))
                   .Returns(() => Interlocked.Increment(ref stsCalls) <= 2
                       ? Task.FromException<AssumeRoleImmutableCredentials>(WrappedExpiredToken())
                       : Task.FromResult(NewCredentials()));

                using (var creds = new TestWebIdentityCredentials(tokenPath, sts.Object))
                {
                    var waits = new List<KeyValuePair<int, TaskCompletionSource<bool>>>();
                    creds.WaitBeforeExpiredTokenRetryAsync = retry =>
                    {
                        var wait = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
                        lock (waits)
                            waits.Add(new KeyValuePair<int, TaskCompletionSource<bool>>(retry, wait));
                        return wait.Task;
                    };
                    Func<int> waitCount = () => { lock (waits) return waits.Count; };

                    var fetch = creds.GetCredentialsAsync();

                    Assert.IsTrue(SpinWait.SpinUntil(() => waitCount() == 1, WaitTimeout), "the refresh did not wait before the first retry");
                    Assert.IsFalse(fetch.IsCompleted, "the refresh is waiting before it calls STS again");
                    Assert.AreEqual(1, Volatile.Read(ref stsCalls));
                    lock (waits)
                        waits[0].Value.SetResult(true);

                    Assert.IsTrue(SpinWait.SpinUntil(() => waitCount() == 2, WaitTimeout), "the refresh did not wait before the second retry");
                    Assert.IsFalse(fetch.IsCompleted);
                    Assert.AreEqual(2, Volatile.Read(ref stsCalls));
                    lock (waits)
                        waits[1].Value.SetResult(true);

                    Assert.IsTrue(fetch.Wait(WaitTimeout), "the refresh did not finish");
                    Assert.AreEqual("ASIAWEBIDENTITY", (await fetch).AccessKey);
                    Assert.AreEqual(3, Volatile.Read(ref stsCalls));
                    lock (waits)
                        CollectionAssert.AreEqual(new[] { 0, 1 }, waits.Select(w => w.Key).ToArray(), "the retry index of each wait");
                    Assert.AreEqual(1, creds.CreateClientCalls, "one STS client is created for the refresh");
                }
            }
            finally
            {
                File.Delete(tokenPath);
            }
        }

        [TestMethod]
        public void ExpiredWebIdentityToken_SyncRefresh_UsesOneStsClient()
        {
            var tokenPath = WriteTokenFile();
            try
            {
                var stsCalls = 0;
                var sts = new Mock<ICoreAmazonSTS>();
                sts.Setup(c => c.CredentialsFromAssumeRoleWithWebIdentityAuthentication(It.IsAny<string>(), It.IsAny<string>(),
                        It.IsAny<string>(), It.IsAny<AssumeRoleWithWebIdentityCredentialsOptions>()))
                   .Returns(() =>
                   {
                       if (Interlocked.Increment(ref stsCalls) == 1)
                           throw WrappedExpiredToken();
                       return NewCredentials();
                   });

                using (var creds = new TestWebIdentityCredentials(tokenPath, sts.Object))
                {
                    Assert.AreEqual("ASIAWEBIDENTITY", creds.GetCredentials().AccessKey);
                    Assert.AreEqual(2, stsCalls);
                    Assert.AreEqual(1, creds.CreateClientCalls, "one STS client is created for the refresh");
                }
            }
            finally
            {
                File.Delete(tokenPath);
            }
        }

        // A token file with a unique name in the temp folder, so tests never share a file.
        private static string WriteTokenFile()
        {
            var path = Path.Combine(Path.GetTempPath(), "web-identity-token-" + Guid.NewGuid().ToString("N") + ".jwt");
            File.WriteAllText(path, "dummy.oidc.token");
            return path;
        }

        /// <summary>
        /// Web identity credentials whose STS client is supplied by the test, counting the calls to
        /// <see cref="CreateClient"/>.
        /// </summary>
        private sealed class TestWebIdentityCredentials : AssumeRoleWithWebIdentityCredentials
        {
            private readonly ICoreAmazonSTS _client;
            private int _createClientCalls;

            public TestWebIdentityCredentials(string tokenFile, ICoreAmazonSTS client)
                : base(tokenFile, "arn:aws:iam::123456789012:role/test", "test-session", new AssumeRoleWithWebIdentityCredentialsOptions())
            {
                _client = client;
            }

            public int CreateClientCalls => Volatile.Read(ref _createClientCalls);

            protected override ICoreAmazonSTS CreateClient()
            {
                Interlocked.Increment(ref _createClientCalls);
                return _client;
            }
        }
    }
}
