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
using System.Globalization;
using System.Net;
using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.EventStreams;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// End-to-end validation of the Clock Skew Correction specification against the official
    /// clock-skew-test-cases.json. There is one [TestMethod] per JSON test (the team
    /// convention is explicit tests, not importing the JSON at runtime).
    ///
    /// Each test drives the REAL specification components with an injected clock:
    ///   * signing time is asserted via CorrectClockSkew.GetCorrectedUtcNowForEndpoint
    ///     (which returns now() + ClientSkew) — validates "sign with now() + AttemptSkew";
    ///   * ClientSkew recording is driven through ClockSkewPipelineHelper.RecordFromResponse
    ///     (the same hook the HttpHandler calls) and asserted via the endpoint store;
    ///   * the 4-minute retry gate is asserted via ClockSkewPipelineHelper.AttemptSkewExceedsThreshold.
    ///
    /// Clock skew correction is gated only by configuration (CorrectForClockSkew),
    /// enabled here per-test.
    /// </summary>
    [TestClass]
    public class ClockSkewSpecificationTestCasesTests
    {
        /// <summary>Snapshot of the process-global AWSConfigs state these tests mutate.</summary>
        private readonly struct SavedClockState
        {
            public readonly Func<DateTime> UtcNowSource;
            public readonly bool CorrectForClockSkew;

            public SavedClockState(Func<DateTime> utcNowSource, bool correctForClockSkew)
            {
                UtcNowSource = utcNowSource;
                CorrectForClockSkew = correctForClockSkew;
            }
        }

        /// <summary>Captures the current process-global clock state (does not mutate).</summary>
        private static SavedClockState SaveClockState() =>
            new SavedClockState(AWSConfigs.utcNowSource, AWSConfigs.CorrectForClockSkew);

        /// <summary>Restores a previously captured clock state. Call from a finally block.</summary>
        private static void RestoreClockState(SavedClockState saved)
        {
            AWSConfigs.utcNowSource = saved.UtcNowSource;
            AWSConfigs.CorrectForClockSkew = saved.CorrectForClockSkew;
        }

        // ---- Test cases (mirror clock-skew-test-cases.json) --------------------

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void ClocksAgree_SucceedsFirstAttempt_SkewZero()
        {
            var ctx = NewContext();
            var op = new Op(initialClientSkew: 0, expectedClientSkew: 0)
                .Attempt(send: "2026-01-01T00:00:00Z", receive: "2026-01-01T00:00:02Z",
                         expectedSigningTime: "2026-01-01T00:00:00Z", status: 200, date: "Thu, 01 Jan 2026 00:00:01 GMT");
            RunOperations(ctx, op);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void ClockSkewError_RetryCorrects_SkewPersistsToNextOperation()
        {
            var ctx = NewContext();
            var op1 = new Op(initialClientSkew: 0, expectedClientSkew: 300)
                .Attempt(send: "2026-01-01T00:00:00Z", receive: "2026-01-01T00:00:02Z",
                         expectedSigningTime: "2026-01-01T00:00:00Z", status: 403,
                         date: "Thu, 01 Jan 2026 00:05:01 GMT", errorCode: "RequestTimeTooSkewed", expectRetry: true)
                .Attempt(send: "2026-01-01T00:00:02Z", receive: "2026-01-01T00:00:04Z",
                         expectedSigningTime: "2026-01-01T00:05:02Z", status: 200, date: "Thu, 01 Jan 2026 00:05:03 GMT");
            var op2 = new Op(initialClientSkew: 300, expectedClientSkew: 300)
                .Attempt(send: "2026-01-01T00:01:00Z", receive: "2026-01-01T00:01:02Z",
                         expectedSigningTime: "2026-01-01T00:06:00Z", status: 200, date: "Thu, 01 Jan 2026 00:06:01 GMT");
            RunOperations(ctx, op1, op2);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void ClockSkewError_NoRetryBudget_StillUpdatesClientSkew()
        {
            var ctx = NewContext();
            var op = new Op(initialClientSkew: 0, expectedClientSkew: 300)
                .Attempt(send: "2026-01-01T00:00:00Z", receive: "2026-01-01T00:00:02Z",
                         expectedSigningTime: "2026-01-01T00:00:00Z", status: 403,
                         date: "Thu, 01 Jan 2026 00:05:01 GMT", errorCode: "RequestTimeTooSkewed");
            RunOperations(ctx, op);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void DelayedResponse_ExceedsTrustThreshold_DoesNotUpdateClientSkew()
        {
            var ctx = NewContext();
            var op1 = new Op(initialClientSkew: 0, expectedClientSkew: 0)
                .Attempt(send: "2026-01-01T00:00:00Z", receive: "2026-01-01T00:16:00Z",
                         expectedSigningTime: "2026-01-01T00:00:00Z", status: 200, date: "Thu, 01 Jan 2026 00:10:00 GMT");
            var op2 = new Op(initialClientSkew: 0, expectedClientSkew: 300)
                .Attempt(send: "2026-01-01T00:17:00Z", receive: "2026-01-01T00:17:02Z",
                         expectedSigningTime: "2026-01-01T00:17:00Z", status: 200, date: "Thu, 01 Jan 2026 00:22:01 GMT");
            RunOperations(ctx, op1, op2);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void StaleClientSkew_SilentlyCorrectedBySuccessfulResponse()
        {
            var ctx = NewContext();
            var op = new Op(initialClientSkew: 300, expectedClientSkew: 0)
                .Attempt(send: "2026-01-01T00:00:00Z", receive: "2026-01-01T00:00:02Z",
                         expectedSigningTime: "2026-01-01T00:05:00Z", status: 200, date: "Thu, 01 Jan 2026 00:00:01 GMT");
            RunOperations(ctx, op);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void PossibleSkewError_BelowThreshold_NotRetried_ButClientSkewUpdated()
        {
            var ctx = NewContext();
            var op = new Op(initialClientSkew: 0, expectedClientSkew: 120)
                .Attempt(send: "2026-01-01T00:00:00Z", receive: "2026-01-01T00:00:02Z",
                         expectedSigningTime: "2026-01-01T00:00:00Z", status: 400,
                         date: "Thu, 01 Jan 2026 00:02:01 GMT", errorCode: "InvalidSignatureException",
                         expectRetry: false);
            RunOperations(ctx, op);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void PossibleSkewError_AboveThreshold_RetriedAndSucceeds()
        {
            var ctx = NewContext();
            var op = new Op(initialClientSkew: 0, expectedClientSkew: 300)
                .Attempt(send: "2026-01-01T00:00:00Z", receive: "2026-01-01T00:00:02Z",
                         expectedSigningTime: "2026-01-01T00:00:00Z", status: 400,
                         date: "Thu, 01 Jan 2026 00:05:01 GMT", errorCode: "InvalidSignatureException", expectRetry: true)
                .Attempt(send: "2026-01-01T00:00:02Z", receive: "2026-01-01T00:00:04Z",
                         expectedSigningTime: "2026-01-01T00:05:02Z", status: 200, date: "Thu, 01 Jan 2026 00:05:03 GMT");
            RunOperations(ctx, op);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void ClockSkewError_NoDateHeader_NotCandidate_ClientSkewNotUpdated()
        {
            var ctx = NewContext();
            var op = new Op(initialClientSkew: 0, expectedClientSkew: 0)
                .Attempt(send: "2026-01-01T00:00:00Z", receive: "2026-01-01T00:00:02Z",
                         expectedSigningTime: "2026-01-01T00:00:00Z", status: 403,
                         date: null, errorCode: "RequestTimeTooSkewed", expectRetry: false);
            RunOperations(ctx, op);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void CachedResponse_AgeHeader_DoesNotUpdateClientSkew()
        {
            var ctx = NewContext();
            var op1 = new Op(initialClientSkew: 0, expectedClientSkew: 0)
                .Attempt(send: "2026-01-01T16:51:00Z", receive: "2026-01-01T16:51:02Z",
                         expectedSigningTime: "2026-01-01T16:51:00Z", status: 200,
                         date: "Thu, 01 Jan 2026 12:03:01 GMT", age: "17280");
            var op2 = new Op(initialClientSkew: 0, expectedClientSkew: 300)
                .Attempt(send: "2026-01-01T16:51:10Z", receive: "2026-01-01T16:51:12Z",
                         expectedSigningTime: "2026-01-01T16:51:10Z", status: 200, date: "Thu, 01 Jan 2026 16:56:11 GMT");
            RunOperations(ctx, op1, op2);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void CachedResponse_AgeHeader_DoesNotPoison_FollowedByAlignedResponse()
        {
            var ctx = NewContext();
            var op1 = new Op(initialClientSkew: 0, expectedClientSkew: 0)
                .Attempt(send: "2026-01-01T16:51:00Z", receive: "2026-01-01T16:51:02Z",
                         expectedSigningTime: "2026-01-01T16:51:00Z", status: 200,
                         date: "Thu, 01 Jan 2026 12:03:01 GMT", age: "17280");
            var op2 = new Op(initialClientSkew: 0, expectedClientSkew: 0)
                .Attempt(send: "2026-01-01T16:51:10Z", receive: "2026-01-01T16:51:12Z",
                         expectedSigningTime: "2026-01-01T16:51:10Z", status: 200, date: "Thu, 01 Jan 2026 16:51:11 GMT");
            RunOperations(ctx, op1, op2);
        }

        // ---- Harness -----------------------------------------------------------

        private static DateTime Utc(string iso) =>
            DateTime.Parse(iso, CultureInfo.InvariantCulture,
                DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal);

        private sealed class Attempt
        {
            public DateTime Send, Receive, ExpectedSigningTime;
            public int Status;
            public string Date;
            public string Age;
            public string ErrorCode;
            public bool? ExpectRetry;
        }

        private sealed class Op
        {
            public readonly int InitialClientSkew;
            public readonly int ExpectedClientSkew;
            public readonly List<Attempt> Attempts = new List<Attempt>();

            public Op(int initialClientSkew, int expectedClientSkew)
            {
                InitialClientSkew = initialClientSkew;
                ExpectedClientSkew = expectedClientSkew;
            }

            public Op Attempt(string send, string receive, string expectedSigningTime, int status,
                string date = null, string age = null, string errorCode = null, bool? expectRetry = null)
            {
                Attempts.Add(new Attempt
                {
                    Send = Utc(send),
                    Receive = Utc(receive),
                    ExpectedSigningTime = Utc(expectedSigningTime),
                    Status = status,
                    Date = date,
                    Age = age,
                    ErrorCode = errorCode,
                    ExpectRetry = expectRetry,
                });
                return this;
            }
        }

        private IExecutionContext NewContext()
        {
            var request = new ListBucketsRequest();
            var ctx = new Amazon.Runtime.Internal.ExecutionContext(
                new RequestContext(true, new NullSigner())
                {
                    ClientConfig = new AmazonS3Config(),
                    OriginalRequest = request,
                    Request = new ListBucketsRequestMarshaller().Marshall(request),
                },
                new ResponseContext());

            // Unique endpoint per context so the process-global endpoint store does not
            // leak state between tests.
            ctx.RequestContext.Request.Endpoint = new Uri("https://skew-" + Guid.NewGuid().ToString("N"));
            return ctx;
        }

        private void RunOperations(IExecutionContext ctx, params Op[] operations)
        {
            // Save/restore global clock state around every spec test via a guaranteed finally,
            // independent of the MSTest TestInitialize/TestCleanup lifecycle.
            var saved = SaveClockState();
            try
            {
                AWSConfigs.CorrectForClockSkew = true;
                RunOperationsCore(ctx, operations);
            }
            finally
            {
                RestoreClockState(saved);
            }
        }

        private void RunOperationsCore(IExecutionContext ctx, params Op[] operations)
        {
            var endpoint = ctx.RequestContext.Request.Endpoint.ToString();

            // Seed initial ClientSkew for the first operation; subsequent operations must
            // carry the value forward from the prior operation (asserted below).
            CorrectClockSkew.SetClockCorrectionForEndpoint(endpoint, TimeSpan.FromSeconds(operations[0].InitialClientSkew));

            for (int o = 0; o < operations.Length; o++)
            {
                var op = operations[o];

                Assert.AreEqual(op.InitialClientSkew,
                    CorrectClockSkew.GetClockCorrectionForEndpoint(endpoint).TotalSeconds, 0.001,
                    $"operation {o}: ClientSkew carried forward mismatch");

                foreach (var attempt in op.Attempts)
                {
                    // 1. Sign using now() + ClientSkew (AttemptSkew under Option A).
                    AWSConfigs.utcNowSource = () => attempt.Send;
                    var signingTime = CorrectClockSkew.GetCorrectedUtcNowForEndpoint(endpoint);
                    Assert.AreEqual(attempt.ExpectedSigningTime, signingTime,
                        $"operation {o}: signing time mismatch");

                    // 2. Record ClientSkew from the response (raw receive time), exactly as
                    //    the HttpHandler does on every response.
                    AWSConfigs.utcNowSource = () => attempt.Receive;
                    var response = new SkewTestResponse((HttpStatusCode)attempt.Status, attempt.Date, attempt.Age);
                    ClockSkewPipelineHelper.RecordFromResponse(ctx, attempt.Send, response);

                    // 3. Retry gate (4-minute detection threshold), where the scenario asserts it.
                    if (attempt.ExpectRetry.HasValue)
                    {
                        Assert.AreEqual(attempt.ExpectRetry.Value,
                            ClockSkewPipelineHelper.AttemptSkewExceedsThreshold(ctx),
                            $"operation {o}: retry-gate (skew > 4 min) mismatch");
                    }
                }

                Assert.AreEqual(op.ExpectedClientSkew,
                    CorrectClockSkew.GetClockCorrectionForEndpoint(endpoint).TotalSeconds, 0.001,
                    $"operation {o}: expectedClientSkew mismatch");
            }
        }

        /// <summary>Minimal <see cref="IWebResponseData"/> carrying scripted status + headers.</summary>
        private sealed class SkewTestResponse : IWebResponseData
        {
            private readonly Dictionary<string, string> _headers =
                new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            public SkewTestResponse(HttpStatusCode statusCode, string date, string age)
            {
                StatusCode = statusCode;
                if (!string.IsNullOrEmpty(date)) _headers[HeaderKeys.DateHeader] = date;
                if (!string.IsNullOrEmpty(age)) _headers[HeaderKeys.AgeHeader] = age;
            }

            public long ContentLength => 0;
            public string ContentType => null;
            public HttpStatusCode StatusCode { get; }
            public bool IsSuccessStatusCode => (int)StatusCode >= 200 && (int)StatusCode <= 299;
            public string[] GetHeaderNames()
            {
                var names = new string[_headers.Count];
                _headers.Keys.CopyTo(names, 0);
                return names;
            }
            public bool IsHeaderPresent(string headerName) => _headers.ContainsKey(headerName);
            public string GetHeaderValue(string headerName) =>
                _headers.TryGetValue(headerName, out var v) ? v : null;
            public IHttpResponseBody ResponseBody => null;
            public IEventStreamHeader GetEventStreamHeader(string headerName) => null;
            public bool IsEventHeaderPresent(string headerName) => false;
        }
    }
}
