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
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Util.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Runs the test cases that accompany the credential refresh specification against
    /// <see cref="RefreshingAWSCredentials"/>. The cases are read from credential-refresh-tests.json, an embedded copy of
    /// the specification's test case file, and every case is a data row named by its <c>id</c>. Each case runs twice:
    /// through <see cref="RefreshingAWSCredentials.GetCredentials()"/> and through
    /// <see cref="RefreshingAWSCredentials.GetCredentialsAsync()"/> (the row name ends in "(async)").
    /// <para />
    /// Setup. The credentials under test are an in-scope provider whose credential source is scripted step by step, and
    /// time comes from a fake clock. For a <c>given</c> state other than <c>none</c>, a first fetch at T0 returns
    /// credentials with the given access key ID (AKID-CACHED when none is given) and a 60-minute lifetime, so the lifetime
    /// table selects a 15-minute advisory window: the advisory window opens at T0+45m, the mandatory window (the last
    /// <see cref="RefreshingAWSCredentials.ExpirationBuffer"/>, one minute, before the reported expiration) at T0+59m, and
    /// the credentials expire at T0+60m. The clock is then set to T0+30m (valid), T0+50m (advisory), T0+59m30s
    /// (mandatory) or T0+61m (expired), and the provider's own classification of that state is checked before the first
    /// step runs. A <c>freshCredentials</c> response returns credentials with a new access key ID and a 60-minute lifetime
    /// unless the step sets <c>lifetimeSeconds</c>; a <c>staleCredentials</c> response returns credentials that expire at
    /// the current time. <c>refreshBackoffSeconds</c> pins the refresh backoff; otherwise the refresh backoff and the
    /// non-recoverable error cache use their production durations (random, 300-600 and 1-5 seconds), which every case
    /// tolerates.
    /// <para />
    /// Observables:
    /// <list type="bullet">
    /// <item><c>result</c>: <c>newCredentials</c> is the credentials instance the source returned most recently, and
    /// <c>cachedCredentials</c> is the instance cached when the step started. <c>nonRecoverableError</c> is the
    /// <see cref="AmazonNonRecoverableCredentialsException"/> instance the source raised. <c>noCredentialsError</c> is a
    /// call made with no credentials cached that raised the source's recoverable error unchanged: the SDK has no separate
    /// "no credentials" exception and reports the credential source's error instead. Any other outcome is a
    /// mismatch.</item>
    /// <item><c>sourceContacted</c>: the scripted source counts its calls, including the call a background refresh
    /// makes. A call that the step did not script, and a scripted response that is not used, fail the step.</item>
    /// <item><c>rateLimited</c>: read from the provider's refresh backoff deadline when the step starts. It is true when
    /// a deadline is set and the current time is before it, which is how the specification defines
    /// RefreshRateLimited().</item>
    /// <item><c>advisoryWindowSeconds</c>: measured from the refresh schedule the provider computed for the credentials it
    /// holds after the step, as the time from the advisory refresh instant to the reported expiration. A configured
    /// window (<see cref="RefreshingAWSCredentials.PreemptExpiryTime"/>) keeps the meaning it had in earlier versions of
    /// the SDK: it is measured from <see cref="RefreshingAWSCredentials.Expiration"/>, which is the reported expiration
    /// minus ExpirationBuffer. For a configured window the harness therefore measures from Expiration, and also checks
    /// that the window measured from the reported expiration is longer by exactly ExpirationBuffer.</item>
    /// </list>
    /// Refreshes in the advisory window. Inside the advisory window a call returns the cached credentials at once and the
    /// refresh runs in the background, so the caller is not blocked. The outcome of that refresh reaches the next caller:
    /// the refreshed credentials, the cached credentials after a recoverable failure (with the refresh backoff applied), or
    /// the non-recoverable error, which the next call raises. When a step's call serves the cached credentials in the
    /// advisory window, the harness waits until the background refresh has finished and calls again at the same time. That
    /// second call's outcome is compared with <c>result</c>, and <c>sourceContacted</c> counts the source calls made by both
    /// calls and by the background refresh. The cases advisory-refresh-succeeds, advisory-window-recomputed-after-refresh,
    /// advisory-non-recoverable-raises-then-recovers and non-recoverable-error-cached-on-retry depend on this. After a
    /// non-recoverable failure, the next call in the advisory window refreshes while the caller waits, so the recovery step
    /// of advisory-non-recoverable-raises-then-recovers is compared directly.
    /// </summary>
    [TestClass]
    [DoNotParallelize]
    [TestCategory("UnitTest")]
    [TestCategory("Runtime")]
    public sealed class CredentialRefreshVectorTests
    {
        private const string TestCasesFileName = "credential-refresh-tests.json";

        // The number of cases in the embedded copy. Update it together with the copy.
        private const int ExpectedTestCaseCount = 25;

        private const string DefaultCachedAccessKeyId = "AKID-CACHED";
        private static readonly DateTime T0 = new DateTime(2020, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        private static readonly TimeSpan CachedLifetime = TimeSpan.FromMinutes(60);
        private static readonly TimeSpan DefaultFreshLifetime = TimeSpan.FromMinutes(60);
        private static readonly TimeSpan WaitTimeout = TimeSpan.FromSeconds(30);

        // Values of the JSON enums.
        private const string NoneState = "none";
        private const string ValidState = "valid";
        private const string AdvisoryState = "advisory";
        private const string MandatoryState = "mandatory";
        private const string ExpiredState = "expired";
        private const string GetCredentialsStep = "getCredentials";
        private const string InvalidateStep = "invalidate";
        private const string AdvanceTimeStep = "advanceTime";
        private const string FreshCredentialsResponse = "freshCredentials";
        private const string StaleCredentialsResponse = "staleCredentials";
        private const string ErrorResponse = "error";
        private const string NonRecoverableErrorResponse = "nonRecoverableError";
        private const string NewCredentialsResult = "newCredentials";
        private const string CachedCredentialsResult = "cachedCredentials";
        private const string NoCredentialsErrorResult = "noCredentialsError";
        private const string NonRecoverableErrorResult = "nonRecoverableError";

        private static readonly Lazy<IReadOnlyList<RefreshTestCase>> TestCases =
            new Lazy<IReadOnlyList<RefreshTestCase>>(LoadTestCases, LazyThreadSafetyMode.ExecutionAndPublication);

        /// <summary>One row per test case and entry point: the case id, and whether GetCredentialsAsync is used.</summary>
        public static IEnumerable<object[]> TestCaseRows =>
            TestCases.Value.SelectMany(c => new[] { new object[] { c.Id, false }, new object[] { c.Id, true } });

        public static string TestCaseDisplayName(MethodInfo methodInfo, object[] data)
            => (bool)data[1] ? (string)data[0] + " (async)" : (string)data[0];

        [TestMethod]
        [DynamicData(nameof(TestCaseRows), DynamicDataDisplayName = nameof(TestCaseDisplayName))]
        public async Task RunTestCase(string id, bool useAsync)
        {
            var testCase = TestCases.Value.Single(c => c.Id == id);
            var clock = new TestClock(T0);
            var creds = new ScriptedCredentials(clock);

            var report = new StringBuilder();
            report.AppendLine(testCase.Id + (useAsync ? " through GetCredentialsAsync" : " through GetCredentials") + ": " + testCase.Documentation);

            await EstablishGivenState(creds, clock, testCase.Given, useAsync).ConfigureAwait(false);
            report.AppendLine("  given " + testCase.Given.CachedCredentials + " at " + Describe(clock.Now));

            var mismatches = 0;
            for (var i = 0; i < testCase.Steps.Count; i++)
            {
                var step = testCase.Steps[i];
                switch (step.Type)
                {
                    case AdvanceTimeStep:
                        clock.Advance(TimeSpan.FromSeconds(step.Seconds));
                        report.AppendLine("  step " + i + " advanceTime " + step.Seconds + "s -> " + Describe(clock.Now));
                        break;

                    case InvalidateStep:
                        report.AppendLine("  step " + i + " invalidate " + step.RejectedAccessKeyId
                                          + " (cached access key ID " + (creds.State?.Credentials?.AccessKey ?? "none") + ")");
                        creds.Invalidate(new ImmutableCredentials(step.RejectedAccessKeyId, "rejected-secret", "rejected-token"));
                        break;

                    case GetCredentialsStep:
                        mismatches += await RunGetCredentialsStep(creds, clock, step, i, useAsync, testCase.Given, report).ConfigureAwait(false);
                        break;

                    default:
                        throw new InvalidDataException("Unsupported step type " + step.Type);
                }
            }

            if (mismatches > 0)
                Assert.Fail(report.ToString());
        }

        [TestMethod]
        public void TestCases_AllCasesAreLoadedAndRun()
        {
            var cases = TestCases.Value;
            Assert.AreEqual(ExpectedTestCaseCount, cases.Count,
                "the embedded " + TestCasesFileName + " must contain every test case of the specification's file");

            var ids = cases.Select(c => c.Id).ToList();
            CollectionAssert.AllItemsAreUnique(ids, "test case ids must be unique");
            foreach (var id in ids)
                Assert.IsTrue(Regex.IsMatch(id, "^[A-Za-z0-9-]+$"), "test case id '" + id + "' must use only letters, digits and dashes");

            // No case is skipped: each runs through both entry points.
            var rows = TestCaseRows.Select(r => (string)r[0] + "|" + (bool)r[1]).ToList();
            var expectedRows = ids.SelectMany(i => new[] { i + "|" + false, i + "|" + true }).ToList();
            CollectionAssert.AreEquivalent(expectedRows, rows);
        }

        #region Harness

        private static async Task EstablishGivenState(ScriptedCredentials creds, TestClock clock, GivenState given, bool useAsync)
        {
            if (given.RefreshBackoffSeconds.HasValue)
            {
                var backoff = TimeSpan.FromSeconds(given.RefreshBackoffSeconds.Value);
                creds.RefreshBackoffGenerator = () => backoff;
            }
            if (given.ConfiguredAdvisoryWindowSeconds.HasValue)
                creds.PreemptExpiryTime = TimeSpan.FromSeconds(given.ConfiguredAdvisoryWindowSeconds.Value);

            if (given.CachedCredentials == NoneState)
            {
                Assert.IsNull(creds.State, "precondition: no credentials are cached");
                return;
            }

            var accessKeyId = given.AccessKeyId ?? DefaultCachedAccessKeyId;
            creds.Script(FreshCredentialsResponse, CachedLifetime, accessKeyId);
            var cached = await Call(creds, useAsync).ConfigureAwait(false);
            Assert.IsNull(cached.Error, "precondition: the first fetch succeeds");
            Assert.AreEqual(accessKeyId, cached.Credentials.AccessKey, "precondition: the cached credentials carry the given access key ID");

            clock.Now = T0 + OffsetFor(given.CachedCredentials);
            Assert.AreEqual(PhaseNameFor(given.CachedCredentials), ClassifyState(creds),
                "precondition: the provider classifies the cached credentials as " + given.CachedCredentials + " at " + Describe(clock.Now));
        }

        private static async Task<int> RunGetCredentialsStep(ScriptedCredentials creds, TestClock clock, TestStep step, int index,
            bool useAsync, GivenState given, StringBuilder report)
        {
            var cachedCredentials = creds.State?.Credentials;
            var phaseAtStart = ClassifyState(creds);
            var rateLimitedAtStart = IsRefreshRateLimited(creds, clock);
            var sourceCallsBefore = creds.SourceCalls;
            var unscriptedCallsBefore = creds.UnscriptedSourceCalls;

            var lifetime = step.LifetimeSeconds.HasValue ? TimeSpan.FromSeconds(step.LifetimeSeconds.Value) : DefaultFreshLifetime;
            creds.Script(step.Response, lifetime, accessKeyId: null);

            report.AppendLine("  step " + index + " getCredentials at " + Describe(clock.Now) + " (state " + phaseAtStart
                              + ", response " + (step.Response ?? "none") + ")"
                              + (step.Documentation == null ? string.Empty : ": " + step.Documentation));

            var outcome = await Call(creds, useAsync).ConfigureAwait(false);
            WaitUntilIdle(creds);

            if (phaseAtStart == "Advisory" && outcome.Error == null && cachedCredentials != null
                && ReferenceEquals(outcome.Credentials, cachedCredentials))
            {
                // The call served the cached credentials without waiting for the refresh. The refresh outcome reaches
                // the next caller, so read it from a second call made now that the background refresh has finished.
                report.AppendLine("      the call returned the cached credentials at once; reading the refresh outcome from the next call");
                outcome = await Call(creds, useAsync).ConfigureAwait(false);
                WaitUntilIdle(creds);
            }

            var mismatches = 0;
            mismatches += Compare(report, "result", step.Expected.Result, DescribeResult(outcome, cachedCredentials, creds));
            mismatches += Compare(report, "sourceContacted", step.Expected.SourceContacted, creds.SourceCalls > sourceCallsBefore);
            if (step.Expected.RateLimited.HasValue)
                mismatches += Compare(report, "rateLimited", step.Expected.RateLimited.Value, rateLimitedAtStart);
            if (step.Expected.AdvisoryWindowSeconds.HasValue)
                mismatches += CompareAdvisoryWindow(report, creds, outcome, step.Expected.AdvisoryWindowSeconds.Value, given);

            if (creds.UnscriptedSourceCalls > unscriptedCallsBefore)
            {
                report.AppendLine("      the credential source was called without a scripted response   <-- MISMATCH");
                mismatches++;
            }
            if (creds.TakeUnusedScript())
            {
                report.AppendLine("      the scripted response " + step.Response + " was not used   <-- MISMATCH");
                mismatches++;
            }

            return mismatches;
        }

        private static int CompareAdvisoryWindow(StringBuilder report, ScriptedCredentials creds, CallOutcome outcome, int expectedSeconds,
            GivenState given)
        {
            var state = creds.State;
            if (state == null || outcome.Credentials == null || !ReferenceEquals(state.Credentials, outcome.Credentials))
            {
                report.AppendLine("      advisoryWindowSeconds: the returned credentials are not the ones the provider holds   <-- MISMATCH");
                return 1;
            }

            var fromReportedExpiration = WholeSeconds(state.RawExpiration - state.AdvisoryRefreshAt);
            if (!given.ConfiguredAdvisoryWindowSeconds.HasValue)
                return Compare(report, "advisoryWindowSeconds", expectedSeconds, fromReportedExpiration);

            var mismatches = Compare(report, "advisoryWindowSeconds (measured from Expiration)", expectedSeconds,
                WholeSeconds(state.ExpirationUtc - state.AdvisoryRefreshAt));
            mismatches += Compare(report, "advisory window measured from the reported expiration",
                expectedSeconds + WholeSeconds(creds.ExpirationBuffer), fromReportedExpiration);
            return mismatches;
        }

        private static string DescribeResult(CallOutcome outcome, ImmutableCredentials cachedCredentials, ScriptedCredentials creds)
        {
            if (outcome.Error != null)
            {
                if (outcome.Error is AmazonNonRecoverableCredentialsException && ReferenceEquals(outcome.Error, creds.LastNonRecoverableError))
                    return NonRecoverableErrorResult;
                if (cachedCredentials == null && ReferenceEquals(outcome.Error, creds.LastRecoverableError))
                    return NoCredentialsErrorResult;
                return "unexpected " + outcome.Error.GetType().Name + " (" + outcome.Error.Message + ")";
            }

            if (cachedCredentials != null && ReferenceEquals(outcome.Credentials, cachedCredentials))
                return CachedCredentialsResult;
            if (outcome.Credentials != null && ReferenceEquals(outcome.Credentials, creds.LastFreshCredentials))
                return NewCredentialsResult;
            // An initial fetch that returned stale credentials caches and returns them: they are newly obtained.
            if (cachedCredentials == null && outcome.Credentials != null && ReferenceEquals(outcome.Credentials, creds.LastStaleCredentials))
                return NewCredentialsResult;
            return "unexpected credentials " + (outcome.Credentials?.AccessKey ?? "(null)");
        }

        private static int Compare<T>(StringBuilder report, string name, T expected, T actual)
        {
            var match = EqualityComparer<T>.Default.Equals(expected, actual);
            report.AppendLine("      " + name + ": expected " + expected + ", actual " + actual + (match ? string.Empty : "   <-- MISMATCH"));
            return match ? 0 : 1;
        }

        private static async Task<CallOutcome> Call(RefreshingAWSCredentials creds, bool useAsync)
        {
            try
            {
                var credentials = useAsync ? await creds.GetCredentialsAsync().ConfigureAwait(false) : creds.GetCredentials();
                return new CallOutcome(credentials, null);
            }
            catch (Exception e)
            {
                return new CallOutcome(null, e);
            }
        }

        private static TimeSpan OffsetFor(string cachedCredentials)
        {
            switch (cachedCredentials)
            {
                case ValidState: return TimeSpan.FromMinutes(30);
                case AdvisoryState: return TimeSpan.FromMinutes(50);
                case MandatoryState: return TimeSpan.FromMinutes(59.5);
                case ExpiredState: return TimeSpan.FromMinutes(61);
                default: throw new InvalidDataException("Unsupported cachedCredentials state " + cachedCredentials);
            }
        }

        // The name of the provider's lifecycle phase for a given state ("advisory" -> "Advisory").
        private static string PhaseNameFor(string cachedCredentials)
            => char.ToUpperInvariant(cachedCredentials[0]) + cachedCredentials.Substring(1);

        private static int WholeSeconds(TimeSpan span) => (int)Math.Round(span.TotalSeconds);

        private static string Describe(DateTime now)
            => "T0+" + (now - T0).TotalSeconds.ToString("0.###", CultureInfo.InvariantCulture) + "s";

        #endregion

        #region Provider internals read by the harness

        private static readonly MethodInfo ClassifyStateMethod =
            typeof(RefreshingAWSCredentials).GetMethod("ClassifyState", BindingFlags.Instance | BindingFlags.NonPublic);
        private static readonly FieldInfo NextRefreshAllowedAtTicksField =
            typeof(RefreshingAWSCredentials).GetField("_nextRefreshAllowedAtTicks", BindingFlags.Instance | BindingFlags.NonPublic);

        // The provider's own classification of its cached credentials at the current time (NoCredentials, Valid,
        // Advisory, Mandatory or Expired).
        private static string ClassifyState(ScriptedCredentials creds)
            => RefreshingCredentialsTestProbes.Require(ClassifyStateMethod, "ClassifyState")
                .Invoke(creds, new object[] { creds.State }).ToString();

        // RefreshRateLimited(): a refresh backoff deadline is set and has not been reached.
        private static bool IsRefreshRateLimited(RefreshingAWSCredentials creds, TestClock clock)
        {
            var ticks = (long)RefreshingCredentialsTestProbes.Require(NextRefreshAllowedAtTicksField, "_nextRefreshAllowedAtTicks")
                .GetValue(creds);
            return ticks != 0 && clock.Now.Ticks < ticks;
        }

        // Waits until no refresh holds the lock and no background refresh is pending. The timeout only elapses when a
        // test fails.
        private static void WaitUntilIdle(RefreshingAWSCredentials creds)
        {
            Assert.IsTrue(SpinWait.SpinUntil(() => RefreshingCredentialsTestProbes.IsIdle(creds), WaitTimeout),
                "the provider did not finish its refresh");
        }

        #endregion

        #region Test case file

        private static IReadOnlyList<RefreshTestCase> LoadTestCases()
        {
            using (var document = JsonDocument.Parse(ReadEmbeddedTestCases()))
            {
                if (document.RootElement.ValueKind != JsonValueKind.Array)
                    throw new InvalidDataException(TestCasesFileName + " must contain an array of test cases.");
                return document.RootElement.EnumerateArray().Select(ParseTestCase).ToList();
            }
        }

        // The manifest resource name includes the assembly's root namespace and folder path, which differ between the
        // test projects that compile this file, so the resource is found by its file name.
        private static string ReadEmbeddedTestCases()
        {
            var assembly = typeof(CredentialRefreshVectorTests).Assembly;
            var resourceName = assembly.GetManifestResourceNames()
                .FirstOrDefault(n => n.EndsWith("." + TestCasesFileName, StringComparison.OrdinalIgnoreCase));
            if (resourceName == null)
                throw new InvalidOperationException("Embedded resource " + TestCasesFileName + " was not found in "
                    + assembly.GetName().Name + ". Available resources: " + string.Join(", ", assembly.GetManifestResourceNames()));

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            using (var reader = new StreamReader(stream))
                return reader.ReadToEnd();
        }

        // Parses one test case. Unknown properties and enum values fail the load, so a change to the specification's test
        // case file that this harness does not understand cannot pass unnoticed.
        private static RefreshTestCase ParseTestCase(JsonElement element)
        {
            var id = RequiredString(element, "id", "test case");
            var context = "test case " + id;
            CheckProperties(element, context, "id", "documentation", "given", "steps");

            var givenElement = Required(element, "given", context);
            CheckProperties(givenElement, context + " given", "cachedCredentials", "accessKeyId", "refreshBackoffSeconds", "configuredAdvisoryWindowSeconds");
            var given = new GivenState
            {
                CachedCredentials = RequiredEnum(givenElement, "cachedCredentials", context, NoneState, ValidState, AdvisoryState, MandatoryState, ExpiredState),
                AccessKeyId = OptionalString(givenElement, "accessKeyId"),
                RefreshBackoffSeconds = OptionalInt(givenElement, "refreshBackoffSeconds"),
                ConfiguredAdvisoryWindowSeconds = OptionalInt(givenElement, "configuredAdvisoryWindowSeconds"),
            };

            var steps = new List<TestStep>();
            foreach (var stepElement in Required(element, "steps", context).EnumerateArray())
            {
                var stepContext = context + " step " + steps.Count;
                var type = RequiredEnum(stepElement, "type", stepContext, GetCredentialsStep, InvalidateStep, AdvanceTimeStep);
                var step = new TestStep { Type = type, Documentation = OptionalString(stepElement, "documentation") };
                switch (type)
                {
                    case GetCredentialsStep:
                        CheckProperties(stepElement, stepContext, "type", "documentation", "response", "lifetimeSeconds", "expected");
                        step.Response = OptionalEnum(stepElement, "response", stepContext,
                            FreshCredentialsResponse, StaleCredentialsResponse, ErrorResponse, NonRecoverableErrorResponse);
                        step.LifetimeSeconds = OptionalInt(stepElement, "lifetimeSeconds");
                        var expectedElement = Required(stepElement, "expected", stepContext);
                        CheckProperties(expectedElement, stepContext + " expected", "result", "sourceContacted", "rateLimited", "advisoryWindowSeconds");
                        step.Expected = new ExpectedOutcome
                        {
                            Result = RequiredEnum(expectedElement, "result", stepContext,
                                NewCredentialsResult, CachedCredentialsResult, NoCredentialsErrorResult, NonRecoverableErrorResult),
                            SourceContacted = Required(expectedElement, "sourceContacted", stepContext).GetBoolean(),
                            RateLimited = expectedElement.TryGetProperty("rateLimited", out var rateLimited) ? rateLimited.GetBoolean() : (bool?)null,
                            AdvisoryWindowSeconds = OptionalInt(expectedElement, "advisoryWindowSeconds"),
                        };
                        break;
                    case InvalidateStep:
                        CheckProperties(stepElement, stepContext, "type", "rejectedAccessKeyId");
                        step.RejectedAccessKeyId = RequiredString(stepElement, "rejectedAccessKeyId", stepContext);
                        break;
                    case AdvanceTimeStep:
                        CheckProperties(stepElement, stepContext, "type", "seconds");
                        step.Seconds = Required(stepElement, "seconds", stepContext).GetInt32();
                        break;
                }
                steps.Add(step);
            }
            if (steps.Count == 0)
                throw new InvalidDataException(context + " has no steps.");

            return new RefreshTestCase
            {
                Id = id,
                Documentation = RequiredString(element, "documentation", context),
                Given = given,
                Steps = steps,
            };
        }

        private static void CheckProperties(JsonElement element, string context, params string[] allowed)
        {
            foreach (var property in element.EnumerateObject())
            {
                if (Array.IndexOf(allowed, property.Name) < 0)
                    throw new InvalidDataException(context + " has the unsupported property '" + property.Name + "'.");
            }
        }

        private static JsonElement Required(JsonElement element, string name, string context)
        {
            if (!element.TryGetProperty(name, out var value))
                throw new InvalidDataException(context + " is missing the required property '" + name + "'.");
            return value;
        }

        private static string RequiredString(JsonElement element, string name, string context)
            => Required(element, name, context).GetString();

        private static string OptionalString(JsonElement element, string name)
            => element.TryGetProperty(name, out var value) ? value.GetString() : null;

        private static int? OptionalInt(JsonElement element, string name)
            => element.TryGetProperty(name, out var value) ? value.GetInt32() : (int?)null;

        private static string RequiredEnum(JsonElement element, string name, string context, params string[] values)
            => CheckEnum(RequiredString(element, name, context), name, context, values);

        private static string OptionalEnum(JsonElement element, string name, string context, params string[] values)
        {
            var value = OptionalString(element, name);
            return value == null ? null : CheckEnum(value, name, context, values);
        }

        private static string CheckEnum(string value, string name, string context, string[] values)
        {
            if (Array.IndexOf(values, value) < 0)
                throw new InvalidDataException(context + " has the unsupported " + name + " value '" + value + "'.");
            return value;
        }

        private sealed class RefreshTestCase
        {
            public string Id;
            public string Documentation;
            public GivenState Given;
            public List<TestStep> Steps;
        }

        private sealed class GivenState
        {
            public string CachedCredentials;
            public string AccessKeyId;
            public int? RefreshBackoffSeconds;
            public int? ConfiguredAdvisoryWindowSeconds;
        }

        private sealed class TestStep
        {
            public string Type;
            public string Documentation;
            public string Response;
            public int? LifetimeSeconds;
            public ExpectedOutcome Expected;
            public string RejectedAccessKeyId;
            public int Seconds;
        }

        private sealed class ExpectedOutcome
        {
            public string Result;
            public bool SourceContacted;
            public bool? RateLimited;
            public int? AdvisoryWindowSeconds;
        }

        #endregion

        #region Test doubles

        private sealed class CallOutcome
        {
            public CallOutcome(ImmutableCredentials credentials, Exception error)
            {
                Credentials = credentials;
                Error = error;
            }

            public ImmutableCredentials Credentials { get; }
            public Exception Error { get; }
        }

        private sealed class TestClock : ITimeProvider
        {
            private long _nowTicks;

            public TestClock(DateTime now)
            {
                Now = now;
            }

            public DateTime Now
            {
                get => new DateTime(Interlocked.Read(ref _nowTicks), DateTimeKind.Utc);
                set => Interlocked.Exchange(ref _nowTicks, value.ToUniversalTime().Ticks);
            }

            public void Advance(TimeSpan by) => Now = Now + by;

            public DateTime CorrectedUtcNow => Now;
        }

        /// <summary>
        /// An in-scope <see cref="RefreshingAWSCredentials"/> whose credential source answers each call with the response
        /// scripted for the current step. A response is used once; a call with no scripted response fails and is counted.
        /// </summary>
        private sealed class ScriptedCredentials : RefreshingAWSCredentials
        {
            private readonly object _scriptLock = new object();
            private string _scriptedResponse;
            private TimeSpan _scriptedLifetime;
            private string _scriptedAccessKeyId;
            private int _sourceCalls;
            private int _unscriptedSourceCalls;
            private int _freshCount;
            private int _staleCount;
            private ImmutableCredentials _lastFreshCredentials;
            private ImmutableCredentials _lastStaleCredentials;
            private Exception _lastRecoverableError;
            private Exception _lastNonRecoverableError;

            public ScriptedCredentials(ITimeProvider clock) : base(clock) { }

            protected override bool UsesManagedRefreshLifecycle => true;

            public CredentialsRefreshState State => currentState;
            public int SourceCalls => Volatile.Read(ref _sourceCalls);
            public int UnscriptedSourceCalls => Volatile.Read(ref _unscriptedSourceCalls);
            public ImmutableCredentials LastFreshCredentials => Volatile.Read(ref _lastFreshCredentials);
            public ImmutableCredentials LastStaleCredentials => Volatile.Read(ref _lastStaleCredentials);
            public Exception LastRecoverableError => Volatile.Read(ref _lastRecoverableError);
            public Exception LastNonRecoverableError => Volatile.Read(ref _lastNonRecoverableError);

            /// <summary>Sets the response to the next source call. A null response expects no source call.</summary>
            public void Script(string response, TimeSpan lifetime, string accessKeyId)
            {
                lock (_scriptLock)
                {
                    _scriptedResponse = response;
                    _scriptedLifetime = lifetime;
                    _scriptedAccessKeyId = accessKeyId;
                }
            }

            /// <summary>Removes a scripted response that no source call used, and returns whether there was one.</summary>
            public bool TakeUnusedScript()
            {
                lock (_scriptLock)
                {
                    var unused = _scriptedResponse != null;
                    _scriptedResponse = null;
                    return unused;
                }
            }

            protected override CredentialsRefreshState GenerateNewCredentials() => Generate();

            protected override Task<CredentialsRefreshState> GenerateNewCredentialsAsync()
            {
                try
                {
                    return Task.FromResult(Generate());
                }
                catch (Exception e)
                {
                    return Task.FromException<CredentialsRefreshState>(e);
                }
            }

            private CredentialsRefreshState Generate()
            {
                Interlocked.Increment(ref _sourceCalls);
                string response;
                TimeSpan lifetime;
                string accessKeyId;
                lock (_scriptLock)
                {
                    response = _scriptedResponse;
                    lifetime = _scriptedLifetime;
                    accessKeyId = _scriptedAccessKeyId;
                    _scriptedResponse = null;
                }

                var now = _timeProvider.CorrectedUtcNow;
                switch (response)
                {
                    case FreshCredentialsResponse:
                    {
                        var n = Interlocked.Increment(ref _freshCount);
                        var fresh = new ImmutableCredentials(accessKeyId ?? "AKID-FRESH-" + n, "fresh-secret-" + n, "fresh-token-" + n);
                        Volatile.Write(ref _lastFreshCredentials, fresh);
                        return new CredentialsRefreshState(fresh, now + lifetime, _timeProvider);
                    }
                    case StaleCredentialsResponse:
                    {
                        // Expiration at the current time: already stale when it arrives.
                        var n = Interlocked.Increment(ref _staleCount);
                        var stale = new ImmutableCredentials("AKID-STALE-" + n, "stale-secret-" + n, "stale-token-" + n);
                        Volatile.Write(ref _lastStaleCredentials, stale);
                        return new CredentialsRefreshState(stale, now, _timeProvider);
                    }
                    case ErrorResponse:
                    {
                        var error = new AmazonClientException("Simulated recoverable credential source failure.");
                        Volatile.Write(ref _lastRecoverableError, error);
                        throw error;
                    }
                    case NonRecoverableErrorResponse:
                    {
                        var error = new AmazonNonRecoverableCredentialsException("Simulated non-recoverable credential source failure.");
                        Volatile.Write(ref _lastNonRecoverableError, error);
                        throw error;
                    }
                    default:
                        Interlocked.Increment(ref _unscriptedSourceCalls);
                        throw new AmazonClientException("The test case did not expect the credential source to be called.");
                }
            }
        }

        #endregion
    }
}
