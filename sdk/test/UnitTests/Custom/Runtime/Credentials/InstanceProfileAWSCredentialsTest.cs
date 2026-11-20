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
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using AWSSDK_DotNet.CommonTest.Utils;
using AWSSDK_DotNet.IntegrationTests.Utils;
using AWSSDK_DotNet.UnitTests.TestTools;
using Amazon.Runtime;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class InstanceProfileAWSCredentialsTest
    {
        [TestMethod]
        public void TestNullRole()
        {
            AssertExtensions.ExpectException(() => new InstanceProfileAWSCredentials(role: null), typeof(ArgumentNullException));
        }

        [TestMethod]
        public void TestEmptyRole()
        {
            AssertExtensions.ExpectException(() =>
            {
                var creds = new InstanceProfileAWSCredentials(String.Empty);
            }, typeof(ArgumentException), "The argument 'role' must contain a valid role name.");
        }

        [TestMethod]
        public void TestWhitespaceRole()
        {
            AssertExtensions.ExpectException(() =>
            {
                var creds = new InstanceProfileAWSCredentials(" ");
            }, typeof(ArgumentException), "The argument 'role' must contain a valid role name.");
        }

        /// <summary>
        /// Covers the InstanceProfile refresh lifecycle. The provider does not fabricate a short expiry or extend
        /// <c>Expiration</c> on an IMDS outage; it surfaces the failure and the base
        /// <see cref="RefreshingAWSCredentials"/> lifecycle owns static stability and refresh backoff. This test asserts:
        ///  1. the provider can be used if the INITIAL IMDS call returns already-expired credentials: they are
        ///     served without arming the refresh backoff, so the next call contacts IMDS again; when IMDS still
        ///     returns expired credentials, that failed refresh arms the backoff, and IMDS is not called again until
        ///     it elapses;
        ///  2. once that backoff elapses, a healthy fetch returns the live credentials;
        ///  3. an IMDS outage after those credentials pass expiry serves the cached credentials (static
        ///     stability) and arms the refresh backoff, rather than fabricating a new window;
        ///  3b. WITHIN the (deterministically pinned) backoff window the provider serves the cached
        ///     credentials and issues NO new IMDS request -- proven by a single sentinel
        ///     response surviving unconsumed in the queue, which the deleted <c>now + 2 min</c> fabrication
        ///     path could not satisfy;
        ///  4. once the refresh backoff elapses, a recovered IMDS produces fresh credentials and the queued
        ///     responses are fully consumed (proving a real request was issued);
        ///  5. a multi-hour (4h15m-at-fetch) credential lifetime yields the ~60-minute advisory (preempt)
        ///     window, not the ~15-minute window the old local one-hour truncation produced.
        /// </summary>
        [TestMethod]
        public void StaticStabilityWhenIMDSExperiencesAnOutageScenarioTest()
        {
            var currentTime = new DateTime(1997, 8, 29, 16, 20, 0, DateTimeKind.Utc);

            var token = "ValidToken";

            var profileMetadata = new IAMInstanceProfileMetadata
            {
                InstanceProfileArn = "profile_arn",
                InstanceProfileId = "profile_id"
            };

            var validCredentialMetadata = new IAMSecurityCredentialMetadata
            {
                AccessKeyId = "value1",
                SecretAccessKey = "secret1",
                Expiration = currentTime.AddMinutes(75)
            };

            var expiredCredentialMetadata = new IAMSecurityCredentialMetadata
            {
                AccessKeyId = "expired",
                SecretAccessKey = "expired",
                Expiration = currentTime.Subtract(TimeSpan.FromMinutes(5))
            };

            var validCredentialMetadata2 = new IAMSecurityCredentialMetadata
            {
                AccessKeyId = "value2",
                SecretAccessKey = "secret2",
                Expiration = currentTime.AddHours(6)
            };

            using (new AWSConfigsDateFaker(() => currentTime.ToUniversalTime()))
            using (var imdsServlet = new EC2InstanceMetadataServlet())
            // EC2InstanceMetadataServlet redirects EC2InstanceMetadata calls via the env var, but
            // InstanceProfileAWSCredentials.Server is a static field initialized at class load time.
            // If the class was loaded before this test (e.g. by a prior test in the same process),
            // Server still points to the real IMDS endpoint. Reset it now so InfoUri and
            // CurrentRoleUri resolve to the local test servlet for the duration of this test.
            using (new DisposableSwitch(
                onStart: () => InstanceProfileAWSCredentials.ResetServiceEndpoint(),
                onEnd:   () => InstanceProfileAWSCredentials.ResetServiceEndpoint()))
            {
                var instanceProfileAwsCredentials =
                    new InstanceProfileAWSCredentials(
                        // use a dummy role so InstanceProfileAWSCredentials doesn't try and call imds server to resolve role
                        role: "dummyRole",
                        proxy: null,
                        scheduledRefreshInterval: null); // no timer: the test drives every IMDS request

                // Pin the refresh backoff to a fixed 10 minutes so the within-backoff / recovery boundary is
                // deterministic (the production default is random, between 60s and half the remaining lifetime of
                // the cached credentials). 10 min is strictly longer than the deleted fabrication's fixed
                // `now + 2 min` window -- that gap is exactly what lets step 3b below tell the base-owned
                // static-stability path apart from the old fabrication.
                instanceProfileAwsCredentials.RefreshBackoffGenerator = () => TimeSpan.FromMinutes(10);

                // 1. INITIAL FETCH, IMDS RETURNS EXPIRED -- the provider can still be used: with nothing cached,
                // the expired credentials are served (IMDS static stability). No refresh backoff is armed: the
                // cached credentials are expired, so the next call refreshes them.
                imdsServlet.AddTokenFetchResponse(token);
                imdsServlet.AddMetadataSecurityInfoResponse(profileMetadata, token);
                imdsServlet.AddMetadataGetSecurityCredentialsResponse(expiredCredentialMetadata, token);
                var expiredInitialCreds = instanceProfileAwsCredentials.GetCredentials();
                AssertAreEqual(expiredCredentialMetadata, expiredInitialCreds);
                Assert.AreEqual(0, imdsServlet.Responses.Count);

                // 1b. THE NEXT CALL REFRESHES, IMDS STILL RETURNS EXPIRED -- the queued triplet is fully consumed
                // (a real IMDS request is issued although only 5 minutes have passed), and the expired response is
                // a failed refresh: the cached credentials are served and the refresh backoff (pinned to 10 min
                // above) is armed.
                currentTime += TimeSpan.FromMinutes(5); // 16:25
                imdsServlet.AddTokenFetchResponse(token);
                imdsServlet.AddMetadataSecurityInfoResponse(profileMetadata, token);
                imdsServlet.AddMetadataGetSecurityCredentialsResponse(expiredCredentialMetadata, token);
                AssertAreEqual(expiredCredentialMetadata, instanceProfileAwsCredentials.GetCredentials());
                Assert.AreEqual(0, imdsServlet.Responses.Count); // all three responses consumed -> request issued

                // 1c. WITHIN THAT BACKOFF the expired credentials keep being served with no IMDS request. As in
                // step 3b, a sentinel response is the oracle: a refresh's first (token) request would consume it.
                currentTime += TimeSpan.FromMinutes(5); // 16:30, inside the 16:35 backoff
                imdsServlet.AddTokenFetchResponse(token);
                AssertAreEqual(expiredCredentialMetadata, instanceProfileAwsCredentials.GetCredentials());
                Assert.AreEqual(1, imdsServlet.Responses.Count); // sentinel unconsumed -> no IMDS request
                imdsServlet.Responses.Dequeue();

                // 2. HEALTHY FETCH -- once the backoff has elapsed, IMDS returns live credentials, which replace
                // the expired ones with their real (provider-reported) expiration.
                currentTime += TimeSpan.FromMinutes(10); // 16:40, past the 16:35 backoff
                imdsServlet.AddTokenFetchResponse(token);
                imdsServlet.AddMetadataSecurityInfoResponse(profileMetadata, token);
                imdsServlet.AddMetadataGetSecurityCredentialsResponse(validCredentialMetadata, token);
                var initialCreds = instanceProfileAwsCredentials.GetCredentials();
                AssertAreEqual(validCredentialMetadata, initialCreds);

                // 3. IMDS OUTAGE (500) AFTER THE CACHED CREDENTIALS PASS EXPIRY -- the mandatory refresh
                // fails, so the base serves the previously cached credentials (static stability) and arms the
                // refresh backoff (pinned to 10 min above), instead of fabricating a fresh 2-minute window.
                currentTime += TimeSpan.FromMinutes(65); // now 17:45, past validCredentialMetadata's 17:35 expiry
                imdsServlet.AddTokenFetchResponse(token);
                imdsServlet.AddMetadataSecurityInfoResponse(profileMetadata, token);
                imdsServlet.AddMetadataGenericResponse(contents: "", token: token, HttpStatusCode.ServiceUnavailable);
                var badCreds = instanceProfileAwsCredentials.GetCredentials();
                AssertAreEqual(validCredentialMetadata, badCreds);
                // The outage response was the last one queued and the mandatory refresh consumed the whole
                // token/info/500 triplet, so the servlet's response queue is now empty. This confirms the
                // mandatory refresh in this step really did issue its requests; step 3b installs its own
                // sentinel response rather than relying on this empty-queue state as an oracle (see the note
                // there for why an empty queue cannot prove a request did NOT fire).
                Assert.AreEqual(0, imdsServlet.Responses.Count);

                // 3b. WITHIN THE BACKOFF WINDOW -- the credentials are past expiry AND the provider is in
                // refresh backoff. The provider must serve the cached credentials and issue
                // NO new IMDS request until the backoff elapses. We advance only 5 min past the outage (< the
                // pinned 10-min backoff), so the base must NOT refresh.
                //
                // The "no request was issued" oracle is a SENTINEL response, not an empty queue. An empty-queue
                // check is unsound here: Servlet.RethrowExceptions defaults false, so when a request hits an
                // empty queue SetupResponseHandler's Assert.Fail is raised on the servlet listener thread, caught
                // by Servlet.HttpWebListenerCallback, and written back as an HTTP 200 body (Servlet.cs:149-165)
                // -- it never reaches this test thread. The client then turns that synthetic 200 into a
                // source/parse failure and static stability returns the same cached key, leaving Responses.Count
                // at 0 whether or not a request fired. So a Count==0 check cannot distinguish "no request" from
                // "a request that failed against the empty queue."
                //
                // Instead we queue exactly ONE sentinel response and assert it SURVIVES. If the provider
                // (wrongly) issued a refresh during backoff, its first sub-request -- the token fetch -- would
                // dequeue the sentinel, dropping Count to 0 and failing the post-call assertion deterministically
                // on this thread. A surviving sentinel (Count==1) is direct, cross-thread-independent proof that
                // zero IMDS requests were issued. This is what the deleted `now + 2 min` fabrication path could
                // not satisfy: with no base backoff its window is already expired at +5 min, so it would attempt
                // a refresh and consume the sentinel.
                currentTime += TimeSpan.FromMinutes(5); // 17:50, still inside the 17:55 backoff
                imdsServlet.AddTokenFetchResponse(token); // sentinel: a refresh's first request would consume it
                Assert.AreEqual(1, imdsServlet.Responses.Count);
                var cachedDuringBackoff = instanceProfileAwsCredentials.GetCredentials();
                AssertAreEqual(validCredentialMetadata, cachedDuringBackoff);
                Assert.AreEqual(1, imdsServlet.Responses.Count); // sentinel unconsumed -> no IMDS request during backoff

                // Explicitly remove the sentinel so it cannot be mistaken for a step-4 recovery response.
                imdsServlet.Responses.Dequeue();
                Assert.AreEqual(0, imdsServlet.Responses.Count);

                // 4. RECOVERY -- advance past the pinned 10-min backoff so the provider is no longer rate
                // limited, then a healthy IMDS produces fresh credentials. The queued triplet below MUST be
                // fully consumed (queue drains back to 0), proving a real IMDS request was issued once the
                // backoff elapsed -- the counterpart to the no-request assertion in step 3b.
                currentTime += TimeSpan.FromMinutes(15); // 18:05, past the 17:55 backoff
                imdsServlet.AddTokenFetchResponse(token);
                imdsServlet.AddMetadataSecurityInfoResponse(profileMetadata, token);
                imdsServlet.AddMetadataGetSecurityCredentialsResponse(validCredentialMetadata2, token);
                var goodCreds2 = instanceProfileAwsCredentials.GetCredentials();
                AssertAreEqual(validCredentialMetadata2, goodCreds2);
                Assert.AreEqual(0, imdsServlet.Responses.Count); // all three responses consumed -> request issued

                // 5. ADVISORY WINDOW -- validCredentialMetadata2 is fetched at 18:05 with a 22:20 expiry, a
                // 4h15m remaining lifetime, which the advisory-window lifetime table maps to the long (60 minute)
                // window. Earlier versions of the SDK truncated the effective lifetime to ~1h15m,
                // which the table mapped to the 15 minute window. Reading the (unset) PreemptExpiryTime returns
                // the computed effective window and proves the fix.
                Assert.AreEqual(TimeSpan.FromMinutes(60), instanceProfileAwsCredentials.PreemptExpiryTime);
            }
        }

        /// <summary>
        /// <see cref="RefreshingAWSCredentials.GetCredentials(TimeSpan)"/>, which the RDS and DSQL auth token generators
        /// and presigning use, behaves as <see cref="RefreshingAWSCredentials.GetCredentials()"/>: IMDS cannot supply
        /// longer-lived credentials on request, so valid cached credentials are returned without an IMDS request even when
        /// they expire within the requested lifetime, and an IMDS outage returns the cached credentials and applies the
        /// refresh backoff, so IMDS is not contacted again until the backoff has elapsed.
        /// </summary>
        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task MinimumLifetime_BehavesAsGetCredentials(bool useAsync)
        {
            var currentTime = new DateTime(1997, 8, 29, 16, 20, 0, DateTimeKind.Utc);
            var token = "ValidToken";
            var minimumLifetime = TimeSpan.FromHours(2);

            var profileMetadata = new IAMInstanceProfileMetadata
            {
                InstanceProfileArn = "profile_arn",
                InstanceProfileId = "profile_id"
            };

            var validCredentialMetadata = new IAMSecurityCredentialMetadata
            {
                AccessKeyId = "value1",
                SecretAccessKey = "secret1",
                Expiration = currentTime.AddMinutes(75)
            };

            var validCredentialMetadata2 = new IAMSecurityCredentialMetadata
            {
                AccessKeyId = "value2",
                SecretAccessKey = "secret2",
                Expiration = currentTime.AddHours(6)
            };

            using (new AWSConfigsDateFaker(() => currentTime.ToUniversalTime()))
            using (var imdsServlet = new EC2InstanceMetadataServlet())
            // See StaticStabilityWhenIMDSExperiencesAnOutageScenarioTest for why the endpoint is reset.
            using (new DisposableSwitch(
                onStart: () => InstanceProfileAWSCredentials.ResetServiceEndpoint(),
                onEnd:   () => InstanceProfileAWSCredentials.ResetServiceEndpoint()))
            {
                var credentials = new InstanceProfileAWSCredentials(role: "dummyRole", proxy: null, scheduledRefreshInterval: null);
                credentials.RefreshBackoffGenerator = () => TimeSpan.FromMinutes(10);
                Func<Task<ImmutableCredentials>> getCredentials = () => useAsync
                    ? credentials.GetCredentialsAsync(minimumLifetime)
                    : Task.FromResult(credentials.GetCredentials(minimumLifetime));

                // 16:20: the first call fetches the credentials, which expire at 17:35.
                imdsServlet.AddTokenFetchResponse(token);
                imdsServlet.AddMetadataSecurityInfoResponse(profileMetadata, token);
                imdsServlet.AddMetadataGetSecurityCredentialsResponse(validCredentialMetadata, token);
                AssertAreEqual(validCredentialMetadata, await getCredentials());
                Assert.AreEqual(0, imdsServlet.Responses.Count);

                // 16:30: the cached credentials expire within the 2-hour minimum lifetime but are valid, and their
                // background refresh window has not started, so IMDS is not contacted. A sentinel response that a request
                // would consume shows it (see StaticStabilityWhenIMDSExperiencesAnOutageScenarioTest).
                currentTime += TimeSpan.FromMinutes(10);
                imdsServlet.AddTokenFetchResponse(token);
                AssertAreEqual(validCredentialMetadata, await getCredentials());
                Assert.AreEqual(1, imdsServlet.Responses.Count, "IMDS is not contacted for valid credentials");
                imdsServlet.Responses.Dequeue();

                // 17:36: the cached credentials have expired and IMDS fails, so the cached credentials are returned and
                // the 10-minute refresh backoff is applied.
                currentTime += TimeSpan.FromMinutes(66);
                imdsServlet.AddTokenFetchResponse(token);
                imdsServlet.AddMetadataSecurityInfoResponse(profileMetadata, token);
                imdsServlet.AddMetadataGenericResponse(contents: "", token: token, HttpStatusCode.ServiceUnavailable);
                AssertAreEqual(validCredentialMetadata, await getCredentials());
                Assert.AreEqual(0, imdsServlet.Responses.Count, "IMDS was contacted");

                // 17:40: inside the refresh backoff, IMDS is not contacted.
                currentTime += TimeSpan.FromMinutes(4);
                imdsServlet.AddTokenFetchResponse(token);
                AssertAreEqual(validCredentialMetadata, await getCredentials());
                Assert.AreEqual(1, imdsServlet.Responses.Count, "IMDS is not contacted while the refresh backoff lasts");
                imdsServlet.Responses.Dequeue();

                // 17:47: the backoff has elapsed and IMDS has recovered, so the next call gets new credentials.
                currentTime += TimeSpan.FromMinutes(7);
                imdsServlet.AddTokenFetchResponse(token);
                imdsServlet.AddMetadataSecurityInfoResponse(profileMetadata, token);
                imdsServlet.AddMetadataGetSecurityCredentialsResponse(validCredentialMetadata2, token);
                AssertAreEqual(validCredentialMetadata2, await getCredentials());
                Assert.AreEqual(0, imdsServlet.Responses.Count);
            }
        }

        /// <summary>
        /// With no credentials cached, a failed request for credentials is made once more before the fetch fails, as in
        /// earlier versions of the SDK, so one dropped or throttled IMDS response does not fail the first call. The
        /// request is not made again when IMDS rejects it as unauthorized, and it is made only once more.
        /// </summary>
        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task InitialFetch_ImdsFailsOnce_RequestIsMadeAgain(bool useAsync)
        {
            using (var fixture = new InitialFetchFixture())
            {
                fixture.Servlet.AddTokenFetchResponse(fixture.Token);
                fixture.Servlet.AddMetadataSecurityInfoResponse(fixture.ProfileMetadata, fixture.Token);
                fixture.Servlet.AddMetadataGenericResponse(contents: "", token: fixture.Token, HttpStatusCode.ServiceUnavailable);
                fixture.Servlet.AddMetadataSecurityInfoResponse(fixture.ProfileMetadata, fixture.Token);
                fixture.Servlet.AddMetadataGetSecurityCredentialsResponse(fixture.CredentialMetadata, fixture.Token);

                AssertAreEqual(fixture.CredentialMetadata, await fixture.GetCredentials(useAsync));
                Assert.AreEqual(0, fixture.Servlet.Responses.Count, "the request for credentials was made again");
            }
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task InitialFetch_ImdsFailsTwice_Throws(bool useAsync)
        {
            using (var fixture = new InitialFetchFixture())
            {
                fixture.Servlet.AddTokenFetchResponse(fixture.Token);
                fixture.Servlet.AddMetadataSecurityInfoResponse(fixture.ProfileMetadata, fixture.Token);
                fixture.Servlet.AddMetadataGenericResponse(contents: "", token: fixture.Token, HttpStatusCode.ServiceUnavailable);
                fixture.Servlet.AddMetadataSecurityInfoResponse(fixture.ProfileMetadata, fixture.Token);
                fixture.Servlet.AddMetadataGenericResponse(contents: "", token: fixture.Token, HttpStatusCode.ServiceUnavailable);
                fixture.Servlet.AddMetadataSecurityInfoResponse(fixture.ProfileMetadata, fixture.Token); // sentinel

                await fixture.AssertGetCredentialsThrows(useAsync);
                Assert.AreEqual(1, fixture.Servlet.Responses.Count, "the request for credentials was made once more, not twice");
            }
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task InitialFetch_ImdsRejectsTheRequestAsUnauthorized_RequestIsNotMadeAgain(bool useAsync)
        {
            using (var fixture = new InitialFetchFixture())
            {
                fixture.Servlet.AddTokenFetchResponse(fixture.Token);
                fixture.Servlet.AddMetadataGenericResponse(contents: "", token: fixture.Token, HttpStatusCode.Unauthorized);
                fixture.Servlet.AddMetadataSecurityInfoResponse(fixture.ProfileMetadata, fixture.Token); // sentinel

                await fixture.AssertGetCredentialsThrows(useAsync);
                Assert.AreEqual(1, fixture.Servlet.Responses.Count, "an unauthorized request is not made again");
            }
        }

        /// <summary>
        /// The provider looks for newer credentials on a timer (every 2 minutes in production), even while the cached
        /// credentials are valid, so credentials that IMDS rotates in are cached without waiting for their refresh
        /// window. The SDK clock does not move, so only the timer can start the second IMDS request. Both IMDS responses
        /// are queued before the first call, because the timer does nothing until credentials are cached. The wait is
        /// bounded by a timeout that only elapses when the test fails.
        /// </summary>
        [TestMethod]
        public void ScheduledRefresh_CachesRotatedCredentialsWithoutCalls()
        {
            Assert.IsTrue(EC2InstanceMetadata.IsIMDSEnabled, "precondition: the scheduled refresh runs only while IMDS is enabled");
            using (var fixture = new InitialFetchFixture(TimeSpan.FromMilliseconds(50)))
            {
                var rotated = new IAMSecurityCredentialMetadata
                {
                    AccessKeyId = "value2",
                    SecretAccessKey = "secret2",
                    Expiration = fixture.CredentialMetadata.Expiration.AddHours(1)
                };
                fixture.Servlet.AddTokenFetchResponse(fixture.Token);
                fixture.Servlet.AddMetadataSecurityInfoResponse(fixture.ProfileMetadata, fixture.Token);
                fixture.Servlet.AddMetadataGetSecurityCredentialsResponse(fixture.CredentialMetadata, fixture.Token);
                fixture.Servlet.AddTokenFetchResponse(fixture.Token);
                fixture.Servlet.AddMetadataSecurityInfoResponse(fixture.ProfileMetadata, fixture.Token);
                fixture.Servlet.AddMetadataGetSecurityCredentialsResponse(rotated, fixture.Token);

                AssertAreEqual(fixture.CredentialMetadata, fixture.Credentials.GetCredentials());

                Assert.IsTrue(SpinWait.SpinUntil(() => fixture.Credentials.GetCredentials().AccessKey == "value2", TimeSpan.FromSeconds(30)),
                    "the rotated credentials from the scheduled refresh were not cached");
                Assert.AreEqual(0, fixture.Servlet.Responses.Count);
            }
        }

        /// <summary>
        /// A local instance metadata servlet, the SDK clock faked to a fixed time, and an
        /// <see cref="InstanceProfileAWSCredentials"/> for a dummy role that has fetched nothing yet.
        /// </summary>
        private sealed class InitialFetchFixture : IDisposable
        {
            private static readonly DateTime CurrentTime = new DateTime(1997, 8, 29, 16, 20, 0, DateTimeKind.Utc);

            private readonly AWSConfigsDateFaker _dateFaker;
            private readonly DisposableSwitch _endpointReset;

            public InitialFetchFixture(TimeSpan? scheduledRefreshInterval = null)
            {
                _dateFaker = new AWSConfigsDateFaker(() => CurrentTime);
                Servlet = new EC2InstanceMetadataServlet();
                // See StaticStabilityWhenIMDSExperiencesAnOutageScenarioTest for why the endpoint is reset.
                _endpointReset = new DisposableSwitch(
                    onStart: () => InstanceProfileAWSCredentials.ResetServiceEndpoint(),
                    onEnd: () => InstanceProfileAWSCredentials.ResetServiceEndpoint());
                Credentials = new InstanceProfileAWSCredentials(role: "dummyRole", proxy: null, scheduledRefreshInterval);
            }

            public string Token { get; } = "ValidToken";

            public IAMInstanceProfileMetadata ProfileMetadata { get; } = new IAMInstanceProfileMetadata
            {
                InstanceProfileArn = "profile_arn",
                InstanceProfileId = "profile_id"
            };

            public IAMSecurityCredentialMetadata CredentialMetadata { get; } = new IAMSecurityCredentialMetadata
            {
                AccessKeyId = "value1",
                SecretAccessKey = "secret1",
                Expiration = CurrentTime.AddMinutes(75)
            };

            public EC2InstanceMetadataServlet Servlet { get; }

            public InstanceProfileAWSCredentials Credentials { get; }

            public Task<ImmutableCredentials> GetCredentials(bool useAsync)
                => useAsync ? Credentials.GetCredentialsAsync() : Task.FromResult(Credentials.GetCredentials());

            public async Task AssertGetCredentialsThrows(bool useAsync)
            {
                if (useAsync)
                    await Assert.ThrowsAsync<AmazonServiceException>(() => Credentials.GetCredentialsAsync());
                else
                    Assert.Throws<AmazonServiceException>(() => Credentials.GetCredentials());
                Assert.IsNull(Credentials.Expiration, "nothing is cached");
            }

            public void Dispose()
            {
                Credentials.Dispose();
                _endpointReset.Dispose();
                Servlet.Dispose();
                _dateFaker.Dispose();
            }
        }

        private void AssertAreEqual(IAMSecurityCredentialMetadata metadata, ImmutableCredentials creds)
        {
            Assert.AreEqual(metadata.AccessKeyId, creds.AccessKey);
            Assert.AreEqual(metadata.SecretAccessKey, creds.SecretKey);
            Assert.AreEqual(metadata.Token ?? "", creds.Token ?? "");
        }
    }
}
