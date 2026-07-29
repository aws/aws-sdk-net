using System;
using System.Collections.Generic;
using System.Linq;
using Amazon.Runtime.Internal.Auth;
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
