using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    [TestCategory("Core")]
    public class AWS4SignerTests
    {
        // -----------------------------------------------------------------------
        // CanonicalizeHeaderNames
        // -----------------------------------------------------------------------

        [TestMethod]
        public void CanonicalizeHeaderNames_LowercasesAndJoinsWithSemicolon()
        {
            var headers = new Dictionary<string, string>
            {
                { "Header1", "Value1" },
                { "Header2", "Value2" },
                { "Header3", "Value3" }
            };

            Assert.AreEqual("header1;header2;header3", AWS4SignerTestee.TestCanonicalizeHeaderNames(headers));
        }

        [TestMethod]
        public void CanonicalizeHeaderNames_AlreadyLowercasePassthrough()
        {
            var headers = new Dictionary<string, string> { { "content-type", "text/plain" }, { "host", "example.com" } };
            Assert.AreEqual("content-type;host", AWS4SignerTestee.TestCanonicalizeHeaderNames(headers));
        }

        [TestMethod]
        public void CanonicalizeHeaderNames_EmptyCollection_ReturnsEmpty()
        {
            Assert.AreEqual(string.Empty, AWS4SignerTestee.TestCanonicalizeHeaderNames(new Dictionary<string, string>()));
        }

        // -----------------------------------------------------------------------
        // CanonicalizeHeaders
        // -----------------------------------------------------------------------

        [TestMethod]
        public void CanonicalizeHeaders_LowercasesKeysAndTrimsValues()
        {
            var headers = new Dictionary<string, string>
            {
                { "Header1", "Value1" },
                { "Header2", " Value2 " },
                { "Header3", "   Value3   " }
            };

            Assert.AreEqual("header1:Value1\nheader2:Value2\nheader3:Value3\n",
                AWS4SignerTestee.TestCanonicalizeHeaders(headers));
        }

        [TestMethod]
        public void CanonicalizeHeaders_CompressesMultipleSpacesInValue()
        {
            var headers = new Dictionary<string, string> { { "X-Custom", "a  b   c" } };
            Assert.AreEqual("x-custom:a b c\n", AWS4SignerTestee.TestCanonicalizeHeaders(headers));
        }

        [TestMethod]
        public void CanonicalizeHeaders_NullInput_ReturnsEmpty()
        {
            Assert.AreEqual(string.Empty, AWS4SignerTestee.TestCanonicalizeHeaders(null));
        }

        [TestMethod]
        public void CanonicalizeHeaders_EmptyCollection_ReturnsEmpty()
        {
            Assert.AreEqual(string.Empty, AWS4SignerTestee.TestCanonicalizeHeaders(new Dictionary<string, string>()));
        }

        // -----------------------------------------------------------------------
        // SortAndPruneHeaders
        // -----------------------------------------------------------------------

        [TestMethod]
        public void SortAndPruneHeaders_SortsAscendingCaseInsensitive()
        {
            var headers = new Dictionary<string, string>
            {
                { "Zoo", "last" },
                { "Alpha", "first" },
                { "Middle", "mid" }
            };
            var sorted = AWS4Signer.SortAndPruneHeaders(headers);
            var keys = sorted.Keys.ToList();
            // Keys are lowercased; Ordinal sort on lowercase equals case-insensitive alphabetic order for plain ASCII.
            Assert.AreEqual("alpha",  keys[0]);
            Assert.AreEqual("middle", keys[1]);
            Assert.AreEqual("zoo",    keys[2]);
        }

        [TestMethod]
        public void SortAndPruneHeaders_LowercasesKeys()
        {
            // SortAndPruneHeaders lowercases keys as part of its public contract
            // (required by callers such as ChunkedUploadWrapperStream).
            var headers = new Dictionary<string, string> { { "Content-Type", "application/json" } };
            var sorted = AWS4Signer.SortAndPruneHeaders(headers);
            Assert.IsTrue(sorted.ContainsKey("content-type"));
            Assert.IsFalse(sorted.ContainsKey("Content-Type"));
        }

        [TestMethod]
        public void SortAndPruneHeaders_RemovesXAmznTraceId()
        {
            var headers = new Dictionary<string, string>
            {
                { HeaderKeys.XAmznTraceIdHeader, "Root=1-abc" },
                { "host", "example.com" }
            };
            var sorted = AWS4Signer.SortAndPruneHeaders(headers);
            Assert.IsFalse(sorted.ContainsKey(HeaderKeys.XAmznTraceIdHeader));
            Assert.IsTrue(sorted.ContainsKey("host"));
        }

        [TestMethod]
        public void SortAndPruneHeaders_RemovesAllIgnoredHeaders()
        {
            var ignored = new[]
            {
                HeaderKeys.XAmznTraceIdHeader,
                HeaderKeys.TransferEncodingHeader,
                HeaderKeys.AmzSdkInvocationId,
                HeaderKeys.AmzSdkRequest,
                HeaderKeys.UserAgentHeader,
                HeaderKeys.XAmzUserAgentHeader
            };

            var headers = ignored.ToDictionary(k => k, _ => "value");
            headers["host"] = "example.com";

            var sorted = AWS4Signer.SortAndPruneHeaders(headers);

            Assert.AreEqual(1, sorted.Count);
            Assert.IsTrue(sorted.ContainsKey("host"));
        }

        [TestMethod]
        public void SortAndPruneHeaders_IgnoreListMatchesCaseInsensitively()
        {
            var headers = new Dictionary<string, string>
            {
                { HeaderKeys.UserAgentHeader.ToUpperInvariant(), "aws-sdk" },
                { "host", "example.com" }
            };
            var sorted = AWS4Signer.SortAndPruneHeaders(headers);
            Assert.AreEqual(1, sorted.Count);
            Assert.IsTrue(sorted.ContainsKey("host"));
        }

        [TestMethod]
        public void SortAndPruneHeaders_EmptyInput_ReturnsEmptyDictionary()
        {
            var sorted = AWS4Signer.SortAndPruneHeaders(new Dictionary<string, string>());
            Assert.AreEqual(0, sorted.Count);
        }

        [TestMethod]
        public void SortAndPruneHeaders_UnderscoreHeaderSortsBeforeLowercaseLetters()
        {
            // SigV4 spec requires byte-value (Ordinal) sort on lowercased header names.
            // '_' is 0x5F; lowercase letters start at 'a' = 0x61, so x_foo must sort
            // BEFORE xa-foo and xb-foo. StringComparer.OrdinalIgnoreCase case-folds to
            // uppercase first, making '_' (0x5F) > 'Z' (0x5A) and therefore placing
            // underscore AFTER all letters — violating the spec.
            var headers = new Dictionary<string, string>
            {
                { "xb-foo", "c" },
                { "x_foo",  "a" },
                { "xa-foo", "b" }
            };
            var sorted = AWS4Signer.SortAndPruneHeaders(headers);
            var keys = sorted.Keys.ToList();
            Assert.AreEqual("x_foo",  keys[0]); // '_' (0x5F) < 'a' (0x61)
            Assert.AreEqual("xa-foo", keys[1]);
            Assert.AreEqual("xb-foo", keys[2]);
        }

        [TestMethod]                                                                         
        public void SortAndPruneHeaders_CaseVariantDuplicates_ThrowsOnAmbiguousValue()
        {
            // "X-Foo: first" and "x-FOO: second" both normalize to "x-foo" but carry
            // different values. Silently picking one would produce an unpredictably signed
            // request, so the method must fail loudly rather than swallow the conflict.
            var headers = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("X-Foo", "first"),
                new KeyValuePair<string, string>("x-FOO", "second"),
                new KeyValuePair<string, string>("host", "example.com")
            };
            Assert.ThrowsExactly<ArgumentException>(
                () => AWS4Signer.SortAndPruneHeaders(headers),
                "Case-variant headers with conflicting values must throw rather than silently drop one.");
        }

        // -----------------------------------------------------------------------
        // CanonicalizeRequest  (exercises CanonicalizeRequestHelper)
        // -----------------------------------------------------------------------

        [TestMethod]
        public void CanonicalizeRequest_StructureMatchesSigV4Spec()
        {
            // Expected canonical-request format (per AWS docs):
            //   HTTPMethod\n
            //   CanonicalURI\n
            //   CanonicalQueryString\n
            //   CanonicalHeaders\n        <- one line per header ending in \n
            //   \n                         <- blank line after headers block
            //   SignedHeaders\n
            //   HexEncodedBodyHash
            var endpoint = new Uri("https://example.amazonaws.com");
            var sortedHeaders = new SortedDictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "host", "example.amazonaws.com" },
                { "X-Amz-Date", "20240101T000000Z" },
                { HeaderKeys.XAmzContentSha256Header, "abc123" }
            };

            var result = AWS4SignerTestee.TestCanonicalizeRequest(
                endpoint,
                resourcePath: "/bucket/key",
                httpMethod: "PUT",
                sortedHeaders: sortedHeaders,
                canonicalQueryString: string.Empty,
                precomputedBodyHash: "abc123",
                pathResources: null,
                doubleEncode: true);

            var lines = result.Split('\n');
            Assert.AreEqual("PUT",                      lines[0], "HTTP method");
            Assert.AreEqual("/bucket/key",              lines[1], "canonical URI");
            Assert.AreEqual(string.Empty,               lines[2], "canonical query string");
            // lines[3..5] are canonical headers (host:, x-amz-content-sha256:, x-amz-date:)
            Assert.AreEqual(string.Empty,               lines[6], "blank line after headers");
            Assert.IsTrue(lines[7].Contains(";"),                  "signed headers separator");
            Assert.AreEqual("abc123",                   lines[8], "body hash");
        }

        [TestMethod]
        public void CanonicalizeRequest_HeaderKeysAreLowercasedInOutput()
        {
            var endpoint = new Uri("https://s3.amazonaws.com");
            var sortedHeaders = new SortedDictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Host", "s3.amazonaws.com" },
                { "Content-Type", "application/json" }
            };

            var result = AWS4SignerTestee.TestCanonicalizeRequest(
                endpoint, "/", "GET", sortedHeaders, string.Empty, "UNSIGNED-PAYLOAD", null, true);

            Assert.IsTrue(result.Contains("\ncontent-type:"), "Content-Type must be lowercased");
            Assert.IsTrue(result.Contains("\nhost:"),         "Host must be lowercased");
            Assert.IsFalse(result.Contains("\nContent-Type:"), "Mixed-case key must not appear");
        }

        [TestMethod]
        public void CanonicalizeRequest_SignedHeaderNamesAreLowercasedAndSorted()
        {
            var endpoint = new Uri("https://example.amazonaws.com");
            var sortedHeaders = new SortedDictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Zoo", "zval" },
                { "Alpha", "aval" }
            };

            var result = AWS4SignerTestee.TestCanonicalizeRequest(
                endpoint, "/", "GET", sortedHeaders, string.Empty, "hash", null, true);

            // signed-header line is the second-to-last line (before body hash)
            var lines = result.Split('\n');
            var signedHeaderLine = lines[lines.Length - 2];
            Assert.AreEqual("alpha;zoo", signedHeaderLine);
        }

        [TestMethod]
        public void CanonicalizeRequest_HeaderValuesAreTrimmedAndCompressed()
        {
            var endpoint = new Uri("https://example.amazonaws.com");
            var sortedHeaders = new SortedDictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "x-custom", "  hello   world  " }
            };

            var result = AWS4SignerTestee.TestCanonicalizeRequest(
                endpoint, "/", "GET", sortedHeaders, string.Empty, "hash", null, true);

            Assert.IsTrue(result.Contains("\nx-custom:hello world\n"));
        }

        [TestMethod]
        public void CanonicalizeRequest_FallsBackToXAmzContentSha256HeaderWhenNoPrecomputedHash()
        {
            var endpoint = new Uri("https://example.amazonaws.com");
            var sha = "deadbeef";
            var sortedHeaders = new SortedDictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { HeaderKeys.XAmzContentSha256Header, sha }
            };

            var result = AWS4SignerTestee.TestCanonicalizeRequest(
                endpoint, "/", "GET", sortedHeaders,
                canonicalQueryString: string.Empty,
                precomputedBodyHash: null,
                pathResources: null,
                doubleEncode: true);

            Assert.IsTrue(result.EndsWith(sha));
        }

        // -----------------------------------------------------------------------
        // CanonicalizeQueryParameters
        // -----------------------------------------------------------------------

        [TestMethod]
        public void CanonicalizeQueryParameters_SortsAndEncodesParameters()
        {
            var parameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("zoo", "last"),
                new KeyValuePair<string, string>("alpha", "first"),
                new KeyValuePair<string, string>("mid", "val ue")
            };

            var result = AWS4SignerTestee.TestCanonicalizeQueryParameters(parameters);
            Assert.AreEqual("alpha=first&mid=val%20ue&zoo=last", result);
        }

        [TestMethod]
        public void CanonicalizeQueryParameters_NullCollection_ReturnsEmpty()
        {
            Assert.AreEqual(string.Empty, AWS4SignerTestee.TestCanonicalizeQueryParameters(null));
        }

        [TestMethod]
        public void CanonicalizeQueryParameters_EmptyCollection_ReturnsEmpty()
        {
            Assert.AreEqual(string.Empty,
                AWS4SignerTestee.TestCanonicalizeQueryParameters(new List<KeyValuePair<string, string>>()));
        }

        [TestMethod]
        public void CanonicalizeQueryParameters_NullValue_RenderedAsEmptyString()
        {
            var parameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("param", null)
            };
            var result = AWS4SignerTestee.TestCanonicalizeQueryParameters(parameters);
            Assert.AreEqual("param=", result);
        }

        private static readonly DateTime SigningTestDate = new DateTime(2024, 1, 15, 12, 30, 0, DateTimeKind.Utc);

        private static AWS4SigningResult Sign(string secret, DateTime signedAt)
            => AWS4Signer.ComputeSignature("AKIAEXAMPLE", secret, "us-east-1", signedAt, "s3", "host", "canonical-request");

        [TestMethod]
        public void ComputeSignature_CachedKey_MatchesComposeSigningKey()
        {
            Sign("secret-a", SigningTestDate);
            var cached = Sign("secret-a", SigningTestDate).GetSigningKey();

            var dateStamp = AWS4Signer.FormatDateTime(SigningTestDate, AWSSDKUtils.ISO8601BasicDateFormat);
            CollectionAssert.AreEqual(AWS4Signer.ComposeSigningKey("secret-a", "us-east-1", dateStamp, "s3"), cached);
        }

        [TestMethod]
        public void ComputeSignature_DifferentSecretSameScope_ReturnsDifferentSignature()
        {
            Assert.AreNotEqual(Sign("secret-a", SigningTestDate).Signature, Sign("secret-b", SigningTestDate).Signature);
        }

        [TestMethod]
        public void ComputeSignature_NextDaySameScope_UsesNewDateKey()
        {
            Sign("secret-a", SigningTestDate);
            var nextDay = SigningTestDate.AddDays(1);
            var cached = Sign("secret-a", nextDay).GetSigningKey();

            var dateStamp = AWS4Signer.FormatDateTime(nextDay, AWSSDKUtils.ISO8601BasicDateFormat);
            CollectionAssert.AreEqual(AWS4Signer.ComposeSigningKey("secret-a", "us-east-1", dateStamp, "s3"), cached);
        }

        [TestMethod]
        public void ComputeSignature_AfterCacheEviction_ReturnsSameSignature()
        {
            var before = Sign("secret-a", SigningTestDate).Signature;
            // More distinct scopes than the cache holds, so secret-a is evicted and re-derived.
            for (var i = 0; i < 250; i++)
                Sign("secret-" + i, SigningTestDate);

            Assert.AreEqual(before, Sign("secret-a", SigningTestDate).Signature);
        }

        [TestMethod]
        public void ComputeSignature_ConcurrentScopesAndDates_MatchIndependentHmac()
        {
            // Two regions on two UTC dates, so threads share, replace and alternate cached keys and their HMACs.
            var regions = new[] { "us-east-1", "eu-west-1" };
            var dates = new[] { SigningTestDate, SigningTestDate.AddDays(1) };
            var results = new string[2000];
            Parallel.For(0, results.Length, new ParallelOptions { MaxDegreeOfParallelism = 8 },
                i => results[i] = Sign("secret-a", regions[i % 2], dates[i / 2 % 2], "canonical-request").Signature);

            for (int i = 0; i < results.Length; i++)
                Assert.AreEqual(IndependentSignature("secret-a", regions[i % 2], dates[i / 2 % 2], "canonical-request"), results[i], "call " + i);
        }

        [TestMethod]
        public void ComputeSignature_WithMetrics_RecordsStringToSignAsStringBuilder()
        {
            var metrics = new RequestMetrics { IsEnabled = true };
            AWS4Signer.ComputeSignature("AKIAEXAMPLE", "secret-a", "us-east-1", SigningTestDate, "s3", "host", "canonical-request", metrics);

            var stringToSign = metrics.Properties[Metric.StringToSign].Single();
            Assert.IsInstanceOfType(stringToSign, typeof(StringBuilder));
            StringAssert.StartsWith(stringToSign.ToString(), "AWS4-HMAC-SHA256\n20240115T123000Z\n20240115/us-east-1/s3/aws4_request\n");
        }

        private static AWS4SigningResult Sign(string secret, string region, DateTime signedAt, string canonicalRequest)
            => AWS4Signer.ComputeSignature("AKIAEXAMPLE", secret, region, signedAt, "s3", "host", canonicalRequest);

        private static string IndependentSignature(string secret, string region, DateTime signedAt, string canonicalRequest)
        {
            var date = signedAt.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
            string stringToSign;
            using (var sha256 = SHA256.Create())
            {
                stringToSign = "AWS4-HMAC-SHA256\n" + signedAt.ToString("yyyyMMddTHHmmssZ", CultureInfo.InvariantCulture) + "\n" +
                    date + "/" + region + "/s3/aws4_request\n" + AWSSDKUtils.ToHex(sha256.ComputeHash(Encoding.UTF8.GetBytes(canonicalRequest)), true);
            }
            using (var hmac = new HMACSHA256(AWS4Signer.ComposeSigningKey(secret, region, date, "s3")))
                return AWSSDKUtils.ToHex(hmac.ComputeHash(Encoding.UTF8.GetBytes(stringToSign)), true);
        }

        // -----------------------------------------------------------------------
        // String hashing (stack / pooled buffer paths on .NET 8+)
        // -----------------------------------------------------------------------

        // Straddle the stack/pool threshold, and mix in multi-byte characters so the UTF-8 byte count
        // differs from the string length (including a surrogate pair).
        public static IEnumerable<object[]> HashInputs()
        {
            foreach (var length in new[] { 1, 100, 340, 341, 342, 1024, 1025, 5000 })
            {
                yield return new object[] { new string('a', length) };
            }

            foreach (var repeats in new[] { 3, 170, 171, 172, 400 })
            {
                yield return new object[] { string.Concat(Enumerable.Repeat("a\u00e9\u20ac\U0001F600", repeats)) };
            }
        }

        [TestMethod]
        [DynamicData(nameof(HashInputs))]
        public void ComputeHash_String_MatchesHashOfUtf8Bytes(string data)
        {
            using (var sha256 = SHA256.Create())
            {
                CollectionAssert.AreEqual(sha256.ComputeHash(Encoding.UTF8.GetBytes(data)), AWS4Signer.ComputeHash(data));
            }
        }

        [TestMethod]
        public void ComputeHash_String_EmptyMatchesEmptyBodyHash()
        {
            Assert.AreEqual(AWS4Signer.EmptyBodySha256, AWSSDKUtils.ToHex(AWS4Signer.ComputeHash(string.Empty), true));
        }

        [TestMethod]
        public void ComputeHash_String_NullThrows()
        {
            Assert.ThrowsExactly<ArgumentNullException>(() => AWS4Signer.ComputeHash((string)null));
        }

        [TestMethod]
        public void ComputeSignature_CanonicalRequestAboveStackLimit_MatchesIndependentHmac()
        {
            // Multi-byte header values push the canonical request well past the stack buffer limit.
            var canonicalRequest = "PUT\n/key\n\nx-amz-meta-a:" + string.Concat(Enumerable.Repeat("\u00e9\u20ac\U0001F600", 300)) + "\n\nhost;x-amz-meta-a\nUNSIGNED-PAYLOAD";
            Assert.AreEqual(
                IndependentSignature("secret-large", "us-east-1", SigningTestDate, canonicalRequest),
                Sign("secret-large", "us-east-1", SigningTestDate, canonicalRequest).Signature);
        }

        [TestMethod]
        public void ComputeSignature_MultiByteRegion_MatchesIndependentHmac()
        {
            Assert.AreEqual(
                IndependentSignature("secret-mb", "us-\u00e9\u20ac-1", SigningTestDate, "canonical-request"),
                Sign("secret-mb", "us-\u00e9\u20ac-1", SigningTestDate, "canonical-request").Signature);
        }

#if NET8_0_OR_GREATER
        [TestMethod]
        public void ComputeHash_String_LargeInput_DoesNotLeaveDataInPooledBuffer()
        {
            // The pooled buffer that held the encoded string must be zeroed before it is returned: canonical requests
            // can contain the session token header. Shared pool buffers are cached per thread, so the next rent of the
            // same size class gets back the buffer that was just used.
            const string marker = "x-amz-security-token:SECRET-SESSION-TOKEN";
            var data = marker + new string('a', 4000);
            AWS4Signer.ComputeHash(data);

            var buffer = System.Buffers.ArrayPool<byte>.Shared.Rent(data.Length);
            try
            {
                // The data is ASCII, so its UTF-8 length is its string length. Bytes beyond it were never ours.
                CollectionAssert.AreEqual(new byte[data.Length], buffer.AsSpan(0, data.Length).ToArray());
            }
            finally
            {
                System.Buffers.ArrayPool<byte>.Shared.Return(buffer);
            }
        }
#endif

        // -----------------------------------------------------------------------
        // Testee shim
        // -----------------------------------------------------------------------

        private class AWS4SignerTestee : AWS4Signer
        {
            public static string TestCanonicalizeHeaderNames(IEnumerable<KeyValuePair<string, string>> headers)
                => CanonicalizeHeaderNames(headers);

            public static string TestCanonicalizeHeaders(IEnumerable<KeyValuePair<string, string>> headers)
                => CanonicalizeHeaders(headers);

            public static string TestCanonicalizeRequest(
                Uri endpoint,
                string resourcePath,
                string httpMethod,
                IDictionary<string, string> sortedHeaders,
                string canonicalQueryString,
                string precomputedBodyHash,
                IDictionary<string, string> pathResources,
                bool doubleEncode)
                => CanonicalizeRequest(endpoint, resourcePath, httpMethod, sortedHeaders,
                    canonicalQueryString, precomputedBodyHash, pathResources, doubleEncode);

            public static string TestCanonicalizeQueryParameters(IEnumerable<KeyValuePair<string, string>> parameters)
                => CanonicalizeQueryParameters(parameters);
        }
    }
}
