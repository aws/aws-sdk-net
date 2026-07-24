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
using System.Text;
using System.Threading.Tasks;
using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.Signing;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests.Signing
{
    [TestClass]
    [TestCategory("Core")]
    [TestCategory("Signer")]
    public class AWSSigV4SignerTests
    {
        // The canonical AWS SigV4 test-suite example credentials and time.
        private const string AccessKey = "AKIDEXAMPLE";
        private const string SecretKey = "wJalrXUtnFEMI/K7MDENG+bPxRfiCYEXAMPLEKEY";
        private const string Region = "us-east-1";
        private const string Service = "service";
        private static readonly DateTime SignedAt = new DateTime(2015, 8, 30, 12, 36, 0, DateTimeKind.Utc);

        private static AWSSigV4Parameters BaseParameters(bool signPayload = true) => new AWSSigV4Parameters
        {
            Credentials = new BasicAWSCredentials(AccessKey, SecretKey),
            Region = RegionEndpoint.GetBySystemName(Region),
            Service = Service,
            SignedAt = SignedAt,
            SignPayload = signPayload,
        };

        // -----------------------------------------------------------------------
        // Header signing — result projection
        //
        // Signature correctness over a scenario table (known-answer vectors for both header signing and
        // presign) lives in AWSSigV4SignerParityTests. The tests here cover behavior that suite does not: the
        // header projection, presigning, validation/throw paths, and the escape hatch.
        // -----------------------------------------------------------------------

        [TestMethod]
        public void Sign_ReturnsExpectedSigningHeaders()
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://example.amazonaws.com/"),
                Headers = new Dictionary<string, string>(),
            };

            var result = AWSSigV4Signer.Sign(request, BaseParameters());

            Assert.IsTrue(result.Headers.ContainsKey(HeaderKeys.AuthorizationHeader));
            Assert.AreEqual("20150830T123600Z", result.Headers[HeaderKeys.XAmzDateHeader]);
            Assert.AreEqual(AWS4Signer.EmptyBodySha256, result.Headers[HeaderKeys.XAmzContentSha256Header]);
            Assert.IsFalse(result.Headers.ContainsKey(HeaderKeys.XAmzSecurityTokenHeader));
        }

        [TestMethod]
        public async Task SignAsync_MatchesSync()
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://example.amazonaws.com/"),
                Headers = new Dictionary<string, string>(),
            };

            var sync = AWSSigV4Signer.Sign(request, BaseParameters());
            var async = await AWSSigV4Signer.SignAsync(request, BaseParameters());

            Assert.AreEqual(sync.Headers[HeaderKeys.AuthorizationHeader], async.Headers[HeaderKeys.AuthorizationHeader]);
        }

        // -----------------------------------------------------------------------
        // Multi-valued headers: the caller must supply a single comma-delimited, per-value-trimmed
        // string (documented on AWSSigningRequest.Headers). These guard that contract.
        // -----------------------------------------------------------------------

        [TestMethod]
        public void Sign_MultiValuedHeader_IsCoveredBySignature()
        {
            // A caller-supplied header is included in the signed-headers set and covered by the signature.
            var request = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://example.amazonaws.com/"),
                Headers = new Dictionary<string, string> { ["x-custom-multi"] = "value1,value2" },
            };

            var result = AWSSigV4Signer.Sign(request, BaseParameters());

            // The Authorization header carries the SignedHeaders list; the custom header must be in it.
            var authorization = result.Headers[HeaderKeys.AuthorizationHeader];
            StringAssert.Contains(authorization, "x-custom-multi", authorization);
        }

        [TestMethod]
        public void Sign_MultiValuedHeader_ValueFormIsSignedVerbatim()
        {
            // The exact value the caller supplies is what gets signed (modulo the signer's own end-trim and
            // sequential-space compression). The signer does NOT trim around the commas of a multi-value string,
            // so "value1,value2" and "value1, value2" (a stray space after the comma) sign differently. This is
            // why the caller must join with commas and trim each value per the AWSSigningRequest.Headers contract:
            // supplying the wrong interior form yields a signature the service rejects.
            var trimmed = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://example.amazonaws.com/"),
                Headers = new Dictionary<string, string> { ["x-custom-multi"] = "value1,value2" },
            };
            var untrimmed = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://example.amazonaws.com/"),
                Headers = new Dictionary<string, string> { ["x-custom-multi"] = "value1, value2" },
            };

            var trimmedResult = AWSSigV4Signer.Sign(trimmed, BaseParameters());
            var untrimmedResult = AWSSigV4Signer.Sign(untrimmed, BaseParameters());

            Assert.AreNotEqual(untrimmedResult.Headers[HeaderKeys.AuthorizationHeader], trimmedResult.Headers[HeaderKeys.AuthorizationHeader],
                "The interior form of a multi-valued header value is signed, so a stray space must change the signature.");
        }

        [TestMethod]
        public void Sign_MultiValuedHeader_LeadingAndTrailingWhitespaceDoesNotChangeSignature()
        {
            // The signer trims the whole value's leading/trailing whitespace before signing (SigV4 canonical
            // step 4), so a value that differs only in outer whitespace signs identically to its trimmed form.
            // This is the part the caller does NOT have to worry about; the per-value/interior trimming (previous
            // test) is the part they do.
            var tight = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://example.amazonaws.com/"),
                Headers = new Dictionary<string, string> { ["x-custom-multi"] = "value1,value2" },
            };
            var padded = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://example.amazonaws.com/"),
                Headers = new Dictionary<string, string> { ["x-custom-multi"] = "  value1,value2  " },
            };

            var tightResult = AWSSigV4Signer.Sign(tight, BaseParameters());
            var paddedResult = AWSSigV4Signer.Sign(padded, BaseParameters());

            Assert.AreEqual(tightResult.Headers[HeaderKeys.AuthorizationHeader], paddedResult.Headers[HeaderKeys.AuthorizationHeader],
                "Leading/trailing whitespace on the whole value is trimmed by the signer and must not change the signature.");
        }

        // -----------------------------------------------------------------------
        // Signer-refactor regression: the new time-accepting overload with the default
        // time must be byte-identical to the original method.
        // -----------------------------------------------------------------------

        [TestMethod]
        public void SignRequestOverload_DefaultTime_MatchesExplicitTimeWithSameInstant()
        {
            // Guards the behavior-preserving refactor: the original 5-arg SignRequest computed its signing
            // time via CorrectClockSkew.GetCorrectedUtcNowForEndpoint and used it. The refactor moved the
            // logic into a 6-arg time-accepting overload and made the 5-arg delegate with that same computed
            // default.
            //
            // We can't independently recompute the default instant and expect a match, since the default
            // overload computes its own corrected-now that would differ from ours by the wall-clock elapsed
            // between the two calls. Instead we capture the exact instant the default path actually used
            // (surfaced on the result as DateTime), then re-sign with the explicit overload using that same
            // instant and compare a time-sensitive output. A broken delegation (wrong default, double header
            // init, dropped reassignment) would make ForAuthorizationHeader diverge here.
            var config = new MockClientConfig { AuthenticationRegion = Region };

            var rDefault = BuildInternalRequest();
            var defaultResult = new AWS4Signer().SignRequest(rDefault, config, new RequestMetrics(), AccessKey, SecretKey);

            var rExplicit = BuildInternalRequest();
            var explicitResult = new AWS4Signer().SignRequest(rExplicit, config, new RequestMetrics(), AccessKey, SecretKey, defaultResult.DateTime);

            // ForAuthorizationHeader folds in the full signature (down to the second via the credential scope
            // date and x-amz-date), so it only matches if both paths signed at the identical instant.
            Assert.AreEqual(explicitResult.ForAuthorizationHeader, defaultResult.ForAuthorizationHeader);
        }

        private static IRequest BuildInternalRequest()
        {
            var request = new DefaultRequest(new StubRequest(), Service)
            {
                HttpMethod = "GET",
                Endpoint = new Uri("https://example.amazonaws.com"),
                ResourcePath = "/",
                OverrideSigningServiceName = Service,
                AuthenticationRegion = Region,
            };
            return request;
        }

        private class StubRequest : AmazonWebServiceRequest { }

        // -----------------------------------------------------------------------
        // Session tokens
        // -----------------------------------------------------------------------

        [TestMethod]
        public void Sign_WithSessionToken_IncludesAndSignsSecurityTokenHeader()
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://example.amazonaws.com/"),
                Headers = new Dictionary<string, string>(),
            };

            var parameters = BaseParameters();
            parameters.Credentials = new SessionAWSCredentials(AccessKey, SecretKey, "the-session-token");

            var result = AWSSigV4Signer.Sign(request, parameters);

            Assert.AreEqual("the-session-token", result.Headers[HeaderKeys.XAmzSecurityTokenHeader]);
            // The token header must be covered by the signature.
            var authorization = result.Headers[HeaderKeys.AuthorizationHeader];
            Assert.IsTrue(authorization.Contains("x-amz-security-token"), authorization);
        }

        // -----------------------------------------------------------------------
        // Presign
        // -----------------------------------------------------------------------

        [TestMethod]
        public void Presign_ProducesExpectedQueryParameters()
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://sts.us-east-1.amazonaws.com/?Action=GetCallerIdentity&Version=2011-06-15"),
                Headers = new Dictionary<string, string>(),
            };

            var parameters = BaseParameters();
            parameters.Service = "sts";

            var result = AWSSigV4Signer.Presign(request, parameters, TimeSpan.FromSeconds(60));

            var query = result.Uri.Query;
            StringAssert.Contains(query, "X-Amz-Algorithm=AWS4-HMAC-SHA256");
            StringAssert.Contains(query, "X-Amz-Credential=");
            StringAssert.Contains(query, "X-Amz-Date=20150830T123600Z");
            StringAssert.Contains(query, "X-Amz-Expires=60");
            StringAssert.Contains(query, "X-Amz-SignedHeaders=host");
            StringAssert.Contains(query, "X-Amz-Signature=");
            // Original query parameters are preserved.
            StringAssert.Contains(query, "Action=GetCallerIdentity");
        }

        [TestMethod]
        public void Presign_WithExtraSignedHeader_ReturnsItInSignedHeaders()
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://sts.us-east-1.amazonaws.com/?Action=GetCallerIdentity&Version=2011-06-15"),
                Headers = new Dictionary<string, string> { ["x-k8s-aws-id"] = "my-cluster" },
            };

            var parameters = BaseParameters();
            parameters.Service = "sts";

            var result = AWSSigV4Signer.Presign(request, parameters, TimeSpan.FromSeconds(60));

            Assert.IsTrue(result.SignedHeaders.ContainsKey("x-k8s-aws-id"));
            Assert.AreEqual("my-cluster", result.SignedHeaders["x-k8s-aws-id"]);
            // host is implicit and must not be surfaced.
            Assert.IsFalse(result.SignedHeaders.ContainsKey("host"));
        }

        [TestMethod]
        public void Presign_UppercaseRegion_IsNormalizedToLowercaseInCredentialScope()
        {
            // The presign path passes Region to the signer as overrideSigningRegion, which the signer uses
            // verbatim (no normalization). The header path lowercases it via DetermineSigningRegion, so an
            // uppercase region must be normalized here too or the presigned URL's credential scope
            // ("US-EAST-1") is one the service rejects. Assert the emitted X-Amz-Credential uses the
            // lowercase region and that an uppercase-region presign equals a lowercase-region one.
            var request = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://sts.us-east-1.amazonaws.com/?Action=GetCallerIdentity&Version=2011-06-15"),
                Headers = new Dictionary<string, string>(),
            };

            var upper = BaseParameters();
            upper.Service = "sts";
            upper.Region = RegionEndpoint.GetBySystemName("US-EAST-1");
            var lower = BaseParameters();
            lower.Service = "sts";
            lower.Region = RegionEndpoint.GetBySystemName("us-east-1");

            var upperResult = AWSSigV4Signer.Presign(request, upper, TimeSpan.FromSeconds(60));
            var lowerResult = AWSSigV4Signer.Presign(request, lower, TimeSpan.FromSeconds(60));

            StringAssert.Contains(Uri.UnescapeDataString(upperResult.Uri.Query), "/us-east-1/sts/aws4_request");
            Assert.IsFalse(Uri.UnescapeDataString(upperResult.Uri.Query).Contains("/US-EAST-1/"),
                "The credential-scope region must be normalized to lowercase.");
            Assert.AreEqual(lowerResult.Uri.Query, upperResult.Uri.Query,
                "An uppercase region must presign identically to its lowercase form.");
        }

        // -----------------------------------------------------------------------
        // Path encoding (review comment #6)
        //
        // The facade treats RequestUri as the authoritative, already-encoded wire path (same contract as the
        // JS/@smithy, Python/botocore, and Java v2 SDKs — see the sigv4-cross-sdk oracles). It never decodes or
        // re-interprets the path. The service recomputes the canonical path from the wire path: one extra
        // encode pass for non-S3, zero passes (verbatim) for S3. These tests pin that behavior observably.
        //
        // Canonical-path unit coverage of the underlying primitive is in SignerTests
        // (TestCanonicalizeResourcePathAlreadyEncoded); these assert the facade wires it correctly end to end.
        // -----------------------------------------------------------------------

        private static AWSSigV4Parameters S3Parameters()
        {
            var p = BaseParameters();
            p.Service = "s3";
            return p;
        }

        private static AWSSigningRequest GetRequest(string url) => new AWSSigningRequest
        {
            HttpMethod = "GET",
            RequestUri = new Uri(url),
            Headers = new Dictionary<string, string>(),
        };

        [TestMethod]
        public void Presign_S3_SpecialCharPath_WireUrlPreservesCallerEncodingVerbatim()
        {
            // For S3 the presigned URL's path must be the caller's encoded path byte-for-byte (zero encode
            // passes), so the service — which recomputes the canonical path verbatim — accepts the signature.
            // Regression guard for the original bug where the facade double-encoded ("%20" -> "%2520").
            var request = GetRequest("https://bucket.s3.us-east-1.amazonaws.com/hello%20world/a%2Bb%3Dc");
            var result = AWSSigV4Signer.Presign(request, S3Parameters(), TimeSpan.FromSeconds(60));

            var path = result.Uri.AbsolutePath;
            Assert.AreEqual("/hello%20world/a%2Bb%3Dc", path,
                "S3 presign must keep the caller's encoded path verbatim (no extra encode pass).");
            Assert.IsFalse(path.Contains("%2520"), "The path must not be double-encoded.");
        }

        [TestMethod]
        public void Presign_S3_EncodedSlashInSegment_IsPreservedNotSplit()
        {
            // "%2F" is an encoded slash inside a single segment. It must be preserved (kept as "%2F" for S3),
            // never decoded into a real separator — matching botocore/@smithy/Java. A signer that decoded the
            // path would sign "/a/b" (two segments) and produce a URL the service resolves to the wrong key.
            var request = GetRequest("https://bucket.s3.us-east-1.amazonaws.com/a%2Fb");
            var result = AWSSigV4Signer.Presign(request, S3Parameters(), TimeSpan.FromSeconds(60));

            Assert.AreEqual("/a%2Fb", result.Uri.AbsolutePath,
                "An encoded slash must be preserved within the segment for S3, not re-encoded or split.");
        }

        [TestMethod]
        public void Sign_S3_And_NonS3_SpecialCharPath_SignDifferently()
        {
            // Same encoded path, two services: S3 signs it verbatim (0 passes); a non-S3 service applies one
            // more encode pass. The canonical paths differ ("/hello%20world" vs "/hello%2520world"), so the
            // signatures must differ. This guards that the S3 zero-pass branch is actually taken.
            var request = GetRequest("https://host.us-east-1.amazonaws.com/hello%20world");

            var s3 = AWSSigV4Signer.Sign(request, S3Parameters());
            var nonS3Params = BaseParameters();
            nonS3Params.Service = "execute-api";
            var nonS3 = AWSSigV4Signer.Sign(request, nonS3Params);

            Assert.AreNotEqual(nonS3.Headers[HeaderKeys.AuthorizationHeader], s3.Headers[HeaderKeys.AuthorizationHeader],
                "S3 (verbatim) and non-S3 (one extra encode pass) must produce different signatures for an encoded path.");
        }

        [TestMethod]
        public void Sign_S3_EncodedSlash_DiffersFromRealSlash()
        {
            // "/a%2Fb" (one segment, encoded slash) and "/a/b" (two segments) are different resources and must
            // sign differently. If the facade decoded the path, both would collapse to "/a/b" and sign the same
            // — the exact interop bug this fix avoids.
            var encodedSlash = AWSSigV4Signer.Sign(GetRequest("https://bucket.s3.us-east-1.amazonaws.com/a%2Fb"), S3Parameters());
            var realSlash = AWSSigV4Signer.Sign(GetRequest("https://bucket.s3.us-east-1.amazonaws.com/a/b"), S3Parameters());

            Assert.AreNotEqual(realSlash.Headers[HeaderKeys.AuthorizationHeader], encodedSlash.Headers[HeaderKeys.AuthorizationHeader],
                "An encoded slash must not be signed the same as a real path separator.");
        }

        [TestMethod]
        public void Sign_AnonymousCredentials_Throws()
        {
            // AnonymousAWSCredentials.GetCredentials() returns null; the facade must fail with a clear
            // ArgumentException rather than an opaque NullReferenceException when it reads credentials.UseToken.
            var request = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://example.amazonaws.com/"),
                Headers = new Dictionary<string, string>(),
            };
            var parameters = BaseParameters();
            parameters.Credentials = new AnonymousAWSCredentials();

            AssertThrows<ArgumentException>(() => AWSSigV4Signer.Sign(request, parameters));
        }

        [TestMethod]
        public void Presign_AnonymousCredentials_Throws()
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://sts.us-east-1.amazonaws.com/"),
                Headers = new Dictionary<string, string>(),
            };
            var parameters = BaseParameters();
            parameters.Service = "sts";
            parameters.Credentials = new AnonymousAWSCredentials();

            AssertThrows<ArgumentException>(() => AWSSigV4Signer.Presign(request, parameters, TimeSpan.FromSeconds(60)));
        }

        [TestMethod]
        public void Presign_WithSessionToken_AddsSecurityTokenQueryParam()
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://sts.us-east-1.amazonaws.com/?Action=GetCallerIdentity&Version=2011-06-15"),
                Headers = new Dictionary<string, string>(),
            };

            var parameters = BaseParameters();
            parameters.Service = "sts";
            parameters.Credentials = new SessionAWSCredentials(AccessKey, SecretKey, "the-session-token");

            var result = AWSSigV4Signer.Presign(request, parameters, TimeSpan.FromSeconds(60));

            StringAssert.Contains(result.Uri.Query, "X-Amz-Security-Token=");
        }

        [TestMethod]
        public void Presign_ExpiryOverSevenDays_Throws()
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://sts.us-east-1.amazonaws.com/"),
                Headers = new Dictionary<string, string>(),
            };

            AssertThrows<ArgumentOutOfRangeException>(() =>
                AWSSigV4Signer.Presign(request, BaseParameters(), TimeSpan.FromDays(7) + TimeSpan.FromSeconds(1)));
        }

        [TestMethod]
        public void Presign_ZeroExpiry_Throws()
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://sts.us-east-1.amazonaws.com/"),
                Headers = new Dictionary<string, string>(),
            };

            AssertThrows<ArgumentOutOfRangeException>(() =>
                AWSSigV4Signer.Presign(request, BaseParameters(), TimeSpan.Zero));
        }

        [TestMethod]
        public void Presign_SubSecondExpiry_Throws()
        {
            // A sub-second expiry would truncate to X-Amz-Expires=0 (an already-expired URL), so it must be
            // rejected rather than silently produce an invalid URL.
            var request = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://sts.us-east-1.amazonaws.com/"),
                Headers = new Dictionary<string, string>(),
            };

            AssertThrows<ArgumentOutOfRangeException>(() =>
                AWSSigV4Signer.Presign(request, BaseParameters(), TimeSpan.FromMilliseconds(500)));
        }

        [TestMethod]
        public void Presign_WithRefreshingCredentials_ForcesRefreshForExpiryWindow()
        {
            // A presign expiry longer than the current credentials' remaining lifetime must force a refresh,
            // so the URL is signed with credentials that outlive the presign window (matching RDS/DSQL).
            var creds = new CountingRefreshingCredentials(credentialsLifetime: TimeSpan.FromMinutes(1));
            var request = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://sts.us-east-1.amazonaws.com/"),
                Headers = new Dictionary<string, string>(),
            };
            var parameters = BaseParameters();
            parameters.Credentials = creds;
            parameters.Service = "sts";

            // First presign with a 1-hour expiry: current 1-minute creds don't cover it, so a refresh happens.
            AWSSigV4Signer.Presign(request, parameters, TimeSpan.FromHours(1));
            Assert.AreEqual(1, creds.GenerateCount, "Expected a credential refresh to satisfy the presign expiry window.");
        }

        [TestMethod]
        public void Presign_WithBody_Throws()
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = "POST",
                RequestUri = new Uri("https://sts.us-east-1.amazonaws.com/"),
                Headers = new Dictionary<string, string>(),
                Content = Encoding.UTF8.GetBytes("body"),
            };

            AssertThrows<ArgumentException>(() =>
                AWSSigV4Signer.Presign(request, BaseParameters(), TimeSpan.FromSeconds(60)));
        }

        [TestMethod]
        public void Presign_WithPrecomputedHashHeader_Throws()
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://sts.us-east-1.amazonaws.com/"),
                Headers = new Dictionary<string, string> { [HeaderKeys.XAmzContentSha256Header] = new string('a', 64) },
            };

            AssertThrows<ArgumentException>(() =>
                AWSSigV4Signer.Presign(request, BaseParameters(), TimeSpan.FromSeconds(60)));
        }

        // -----------------------------------------------------------------------
        // Query string handling (duplicate keys, valueless flags)
        // -----------------------------------------------------------------------

        [TestMethod]
        public void Presign_DuplicateQueryKeys_AreAllPreserved()
        {
            // ?x=1&x=2 must not collapse to a single value: both must appear in the presigned URL and be
            // covered by the signature. (A name-keyed parse would silently keep only x=2.)
            var request = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://example.amazonaws.com/?x=1&x=2"),
                Headers = new Dictionary<string, string>(),
            };

            var result = AWSSigV4Signer.Presign(request, BaseParameters(), TimeSpan.FromSeconds(60));

            StringAssert.Contains(result.Uri.Query, "x=1");
            StringAssert.Contains(result.Uri.Query, "x=2");
            // Both occurrences are in the signed header set's canonical query, so the signature covers them.
            StringAssert.Contains(result.Uri.Query, "X-Amz-Signature=");
        }

        [TestMethod]
        public void Sign_DuplicateQueryKeys_MatchesInternalSignerWithListParam()
        {
            // The facade must sign ?x=1&x=2 as two values. Cross-check against the internal signer given a
            // request whose parameter collection holds the same list — proves neither value is dropped.
            var facade = AWSSigV4Signer.Sign(
                new AWSSigningRequest
                {
                    HttpMethod = "GET",
                    RequestUri = new Uri("https://example.amazonaws.com/?x=1&x=2"),
                    Headers = new Dictionary<string, string>(),
                },
                BaseParameters());

            var internalRequest = new DefaultRequest(new StubRequest(), Service)
            {
                HttpMethod = "GET",
                Endpoint = new Uri("https://example.amazonaws.com"),
                ResourcePath = "/",
                UseQueryString = true,
                OverrideSigningServiceName = Service,
                AuthenticationRegion = Region,
            };
            internalRequest.ParameterCollection.Add("x", new List<string> { "1", "2" });
            var config = new MockClientConfig { AuthenticationRegion = Region };
            var expected = new AWS4Signer().SignRequest(
                internalRequest, config, new RequestMetrics(), AccessKey, SecretKey, SignedAt);

            Assert.AreEqual(expected.ForAuthorizationHeader, facade.Headers[HeaderKeys.AuthorizationHeader]);
        }

        [TestMethod]
        public void Presign_ValuelessQueryFlag_IsPreservedAsEmptyValue()
        {
            // ?acl (no '=') must be signed and emitted as "acl=" — the form a service canonicalizes a bare
            // flag into — rather than dropped from the signature.
            var request = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://example.amazonaws.com/?acl"),
                Headers = new Dictionary<string, string>(),
            };

            var result = AWSSigV4Signer.Presign(request, BaseParameters(), TimeSpan.FromSeconds(60));

            StringAssert.Contains(result.Uri.Query, "acl=");
        }

        // -----------------------------------------------------------------------
        // Precomputed-hash escape hatch (§5.5)
        // -----------------------------------------------------------------------

        [TestMethod]
        public void Sign_WithPrecomputedContentHash_UsesItVerbatim()
        {
            var precomputed = "1234567890123456789012345678901234567890123456789012345678901234";
            var request = new AWSSigningRequest
            {
                HttpMethod = "POST",
                RequestUri = new Uri("https://example.amazonaws.com/"),
                Headers = new Dictionary<string, string> { [HeaderKeys.XAmzContentSha256Header] = precomputed },
            };

            var result = AWSSigV4Signer.Sign(request, BaseParameters());

            // The caller-supplied hash must survive the InitializeHeaders/CleanHeaders scrub and land verbatim.
            Assert.AreEqual(precomputed, result.Headers[HeaderKeys.XAmzContentSha256Header]);
        }

        [TestMethod]
        public void PipelineResign_StillScrubsStaleContentHash()
        {
            // Guards the escape-hatch change: the standard signer path (no PrecomputedContentSha256 set) must
            // still recompute x-amz-content-sha256 rather than trusting a stale header value.
            var config = new MockClientConfig { AuthenticationRegion = Region };

            var request = new DefaultRequest(new StubRequest(), Service)
            {
                HttpMethod = "GET",
                Endpoint = new Uri("https://example.amazonaws.com"),
                ResourcePath = "/",
                OverrideSigningServiceName = Service,
                AuthenticationRegion = Region,
            };
            // Inject a stale hash as though from a prior signing pass.
            request.Headers[HeaderKeys.XAmzContentSha256Header] = "staleeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee";

            new AWS4Signer().SignRequest(request, config, new RequestMetrics(), AccessKey, SecretKey);

            // Empty body → the signer should have replaced the stale value with the empty-body SHA.
            Assert.AreEqual(AWS4Signer.EmptyBodySha256, request.Headers[HeaderKeys.XAmzContentSha256Header]);
        }

        [TestMethod]
        public void Sign_SignPayloadFalseWithPrecomputedHash_Throws()
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = "POST",
                RequestUri = new Uri("https://example.amazonaws.com/"),
                Headers = new Dictionary<string, string> { [HeaderKeys.XAmzContentSha256Header] = new string('a', 64) },
            };

            AssertThrows<ArgumentException>(() => AWSSigV4Signer.Sign(request, BaseParameters(signPayload: false)));
        }

        // -----------------------------------------------------------------------
        // Non-seekable stream (decision #9)
        // -----------------------------------------------------------------------

        [TestMethod]
        public void Sign_NonSeekableStreamWithSignPayload_Throws()
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = "POST",
                RequestUri = new Uri("https://example.amazonaws.com/"),
                Headers = new Dictionary<string, string>(),
                ContentStream = new NonSeekableStream(Encoding.UTF8.GetBytes("body")),
            };

            AssertThrows<ArgumentException>(() => AWSSigV4Signer.Sign(request, BaseParameters()));
        }

        [TestMethod]
        [DataRow("")]
        [DataRow("   ")]
        public void Sign_NonSeekableStreamWithBlankPrecomputedHash_StillThrows(string blankHash)
        {
            // A blank (empty or whitespace-only) x-amz-content-sha256 is not a usable hash: the downstream
            // signer ignores it and would silently downgrade to UNSIGNED-PAYLOAD (or sign the blank verbatim).
            // The non-seekable guard must treat it as "no hash supplied" and fail loud rather than let either
            // happen.
            var request = new AWSSigningRequest
            {
                HttpMethod = "POST",
                RequestUri = new Uri("https://example.amazonaws.com/"),
                Headers = new Dictionary<string, string> { [HeaderKeys.XAmzContentSha256Header] = blankHash },
                ContentStream = new NonSeekableStream(Encoding.UTF8.GetBytes("body")),
            };

            AssertThrows<ArgumentException>(() => AWSSigV4Signer.Sign(request, BaseParameters()));
        }

        [TestMethod]
        public void Sign_NonSeekableStreamWithUnsignedPayload_DoesNotThrow()
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = "POST",
                RequestUri = new Uri("https://example.amazonaws.com/"),
                Headers = new Dictionary<string, string>(),
                ContentStream = new NonSeekableStream(Encoding.UTF8.GetBytes("body")),
            };

            var result = AWSSigV4Signer.Sign(request, BaseParameters(signPayload: false));
            Assert.AreEqual(AWS4Signer.UnsignedPayload, result.Headers[HeaderKeys.XAmzContentSha256Header]);
        }

        [TestMethod]
        public void Sign_BodyWithSignPayloadFalse_SignsUnsignedPayloadAndIgnoresBody()
        {
            // SignPayload = false is the outer gate (see §5.4): the internal AWS4Signer.SetRequestBodyHash
            // returns the UNSIGNED-PAYLOAD magic string before it ever reads the body, so a supplied body is
            // legitimately ignored rather than hashed. This is the streaming/large-upload case and matches the
            // internal signer + sibling SDKs, so the facade allows it (unlike a *precomputed hash* +
            // SignPayload = false, which is contradictory and throws). Assert x-amz-content-sha256 is the magic
            // string, and that the signature is identical whether or not a body is present.
            var withBody = new AWSSigningRequest
            {
                HttpMethod = "POST",
                RequestUri = new Uri("https://example.amazonaws.com/"),
                Headers = new Dictionary<string, string>(),
                Content = Encoding.UTF8.GetBytes("this body is not signed"),
            };
            var withoutBody = new AWSSigningRequest
            {
                HttpMethod = "POST",
                RequestUri = new Uri("https://example.amazonaws.com/"),
                Headers = new Dictionary<string, string>(),
            };

            var withBodyResult = AWSSigV4Signer.Sign(withBody, BaseParameters(signPayload: false));
            var withoutBodyResult = AWSSigV4Signer.Sign(withoutBody, BaseParameters(signPayload: false));

            Assert.AreEqual(AWS4Signer.UnsignedPayload, withBodyResult.Headers[HeaderKeys.XAmzContentSha256Header]);
            Assert.AreEqual(withoutBodyResult.Headers[HeaderKeys.AuthorizationHeader], withBodyResult.Headers[HeaderKeys.AuthorizationHeader],
                "With SignPayload = false the body is not read, so its presence must not change the signature.");
        }

        [TestMethod]
        public void Sign_SeekableStreamWithSignPayload_ComputesHash()
        {
            var body = Encoding.UTF8.GetBytes("hello world");
            var request = new AWSSigningRequest
            {
                HttpMethod = "POST",
                RequestUri = new Uri("https://example.amazonaws.com/"),
                Headers = new Dictionary<string, string>(),
                ContentStream = new MemoryStream(body),
            };

            var result = AWSSigV4Signer.Sign(request, BaseParameters());

            var expectedHash = AWSSDKUtils.ToHex(CryptoUtilFactory.CryptoInstance.ComputeSHA256Hash(body), true);
            Assert.AreEqual(expectedHash, result.Headers[HeaderKeys.XAmzContentSha256Header]);
        }

        // -----------------------------------------------------------------------
        // Validation
        // -----------------------------------------------------------------------

        [TestMethod]
        public void Sign_ContentAndContentStreamBothSet_Throws()
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = "POST",
                RequestUri = new Uri("https://example.amazonaws.com/"),
                Headers = new Dictionary<string, string>(),
                Content = new byte[] { 1 },
                ContentStream = new MemoryStream(new byte[] { 1 }),
            };

            AssertThrows<ArgumentException>(() => AWSSigV4Signer.Sign(request, BaseParameters()));
        }

        [TestMethod]
        public void Sign_UnsignedPayloadOverHttp_Throws()
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("http://example.amazonaws.com/"),
                Headers = new Dictionary<string, string>(),
            };

            AssertThrows<ArgumentException>(() => AWSSigV4Signer.Sign(request, BaseParameters(signPayload: false)));
        }

        [TestMethod]
        public void Sign_MissingRegion_Throws()
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://example.amazonaws.com/"),
                Headers = new Dictionary<string, string>(),
            };
            var parameters = BaseParameters();
            parameters.Region = null;

            AssertThrows<ArgumentException>(() => AWSSigV4Signer.Sign(request, parameters));
        }

        // -----------------------------------------------------------------------
        // Helpers
        // -----------------------------------------------------------------------

        private static void AssertThrows<TException>(Action action) where TException : Exception
        {
            try
            {
                action();
            }
            catch (TException)
            {
                return;
            }
            catch (Exception ex)
            {
                Assert.Fail($"Expected {typeof(TException).Name} but got {ex.GetType().Name}: {ex.Message}");
            }

            Assert.Fail($"Expected {typeof(TException).Name} but no exception was thrown.");
        }

        private sealed class NonSeekableStream : Stream
        {
            private readonly MemoryStream _inner;
            public NonSeekableStream(byte[] data) => _inner = new MemoryStream(data);
            public override bool CanRead => true;
            public override bool CanSeek => false;
            public override bool CanWrite => false;
            public override long Length => throw new NotSupportedException();
            public override long Position { get => _inner.Position; set => throw new NotSupportedException(); }
            public override void Flush() { }
            public override int Read(byte[] buffer, int offset, int count) => _inner.Read(buffer, offset, count);
            public override long Seek(long offset, SeekOrigin origin) => throw new NotSupportedException();
            public override void SetLength(long value) => throw new NotSupportedException();
            public override void Write(byte[] buffer, int offset, int count) => throw new NotSupportedException();
        }

        /// <summary>
        /// A RefreshingAWSCredentials whose generated credentials expire after a fixed lifetime, counting how
        /// many times it regenerates. Used to verify the presign path forces a refresh keyed off the expiry.
        /// </summary>
        private sealed class CountingRefreshingCredentials : RefreshingAWSCredentials
        {
            private readonly TimeSpan _credentialsLifetime;
            public int GenerateCount { get; private set; }

            public CountingRefreshingCredentials(TimeSpan credentialsLifetime)
            {
                _credentialsLifetime = credentialsLifetime;
            }

            protected override CredentialsRefreshState GenerateNewCredentials()
            {
                GenerateCount++;
                return new CredentialsRefreshState(
                    new ImmutableCredentials(AccessKey, SecretKey, null),
                    DateTime.UtcNow + _credentialsLifetime);
            }
        }
    }
}
