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
using System.Linq;
using System.Text;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.Signing;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests.Signing
{
    /// <summary>
    /// Parity + known-answer coverage for <see cref="AWSSigV4Signer"/>. A single table of signing scenarios
    /// is exercised two ways:
    ///
    /// 1. <see cref="Facade_MatchesInternalSigner"/> signs each scenario through BOTH the public facade and a
    ///    hand-built <see cref="DefaultRequest"/> + internal <see cref="AWS4Signer"/>, asserting the resulting
    ///    Authorization header is identical. This guards against the facade's request-building drifting from
    ///    the internal signer for any input class (query params, bodies, extra headers, unsigned payload, …).
    ///
    /// 2. <see cref="Facade_MatchesKnownAnswerVector"/> asserts each scenario that has an
    ///    externally-computed expected signature matches it. Those signatures were produced by an independent
    ///    reference implementation of SigV4 (not this codebase), so they catch a systematic canonicalization /
    ///    string-to-sign / signing-key defect that a pure facade-vs-internal parity check could not (both
    ///    sides would share the bug).
    /// </summary>
    [TestClass]
    [TestCategory("Core")]
    [TestCategory("Signer")]
    public class AWSSigV4SignerParityTests
    {
        private const string AccessKey = "AKIDEXAMPLE";
        private const string SecretKey = "wJalrXUtnFEMI/K7MDENG+bPxRfiCYEXAMPLEKEY";
        private const string Region = "us-east-1";
        private const string Service = "service";
        private const string Host = "example.amazonaws.com";
        private static readonly DateTime SignedAt = new DateTime(2015, 8, 30, 12, 36, 0, DateTimeKind.Utc);

        /// <summary>A logical signing scenario, expressed independently of any signer.</summary>
        public sealed class Scenario
        {
            public string Name;
            public string Method = "GET";
            public string Url;
            public Dictionary<string, string> Headers = new Dictionary<string, string>();
            public byte[] Content;
            public bool SignPayload = true;
            /// <summary>Externally-computed expected signature (hex), or null if only parity is checked.</summary>
            public string ExpectedSignature;
            public override string ToString() => Name;
        }

        private static readonly Scenario[] Scenarios =
        {
            new Scenario
            {
                Name = "empty-get",
                Url = $"https://{Host}/",
                ExpectedSignature = "726c5c4879a6b4ccbbd3b24edbd6b8826d34f87450fbbf4e85546fc7ba9c1642",
            },
            new Scenario
            {
                Name = "single-query-param",
                Url = $"https://{Host}/?Param1=value1",
                ExpectedSignature = "2287c0f96af21b7ccf3ee4a2905bcbb2d6f9a94c68d0849f3d1715ef003f2a05",
            },
            new Scenario
            {
                Name = "two-query-params",
                Url = $"https://{Host}/?a=1&b=2",
                ExpectedSignature = "34170682e7af01d97548b14ac02777298b87ffc0370241c0d027326a2dd082b7",
            },
            new Scenario
            {
                Name = "duplicate-query-key",
                Url = $"https://{Host}/?x=1&x=2",
                ExpectedSignature = "5c50be118c209562a76a20a14a4223c06aa5459ba3d84a33432321cfd388fa51",
            },
            new Scenario
            {
                Name = "valueless-query-flag",
                Url = $"https://{Host}/?acl",
                ExpectedSignature = "6615a3c3b4d979bfec21cce1fd1c97bf2b5bd8cabb4bcb2f448c2d2657823d9e",
            },
            new Scenario
            {
                Name = "post-with-body",
                Method = "POST",
                Url = $"https://{Host}/",
                Content = Encoding.UTF8.GetBytes("hello world"),
                ExpectedSignature = "a46b49879a7216c01acb5bc869be959e2eea307d67b7b39b9335eceb368d8681",
            },
            new Scenario
            {
                Name = "unsigned-payload",
                Url = $"https://{Host}/",
                SignPayload = false,
                ExpectedSignature = "9b02fb7b5d0076fa47a0adda28c71e74ba4588334bc0139b8cd6bb87f16afe16",
            },
            new Scenario
            {
                Name = "extra-signed-header",
                Url = $"https://{Host}/",
                Headers = new Dictionary<string, string> { ["x-k8s-aws-id"] = "my-cluster" },
                ExpectedSignature = "39b2e37f474f20f9d00667e5a68e2cb9fd5c9af381dd983fc8a677df6f610b01",
            },
        };

        public static IEnumerable<object[]> AllScenarios =>
            Scenarios.Select(s => new object[] { s });

        public static IEnumerable<object[]> VectorScenarios =>
            Scenarios.Where(s => s.ExpectedSignature != null).Select(s => new object[] { s });

        [TestMethod]
        [DynamicData(nameof(AllScenarios))]
        public void Facade_MatchesInternalSigner(Scenario scenario)
        {
            var facade = SignWithFacade(scenario);
            var internalHeader = SignWithInternalSigner(scenario);

            Assert.AreEqual(internalHeader, facade,
                $"Facade and internal signer diverged for scenario '{scenario.Name}'.");
        }

        [TestMethod]
        [DynamicData(nameof(VectorScenarios))]
        public void Facade_MatchesKnownAnswerVector(Scenario scenario)
        {
            var facade = SignWithFacade(scenario);
            var expected =
                "AWS4-HMAC-SHA256 " +
                $"Credential={AccessKey}/20150830/{Region}/{Service}/aws4_request, " +
                $"SignedHeaders={ExpectedSignedHeaders(scenario)}, " +
                $"Signature={scenario.ExpectedSignature}";

            Assert.AreEqual(expected, facade,
                $"Facade output did not match the independent known-answer vector for scenario '{scenario.Name}'.");
        }

        // --- helpers ---

        private static string SignWithFacade(Scenario scenario)
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = scenario.Method,
                RequestUri = new Uri(scenario.Url),
                Headers = new Dictionary<string, string>(scenario.Headers),
                Content = scenario.Content,
            };
            var parameters = new AWSSigningParameters
            {
                Credentials = new BasicAWSCredentials(AccessKey, SecretKey),
                Region = Region,
                Service = Service,
                SignedAt = SignedAt,
                SignPayload = scenario.SignPayload,
            };
            return AWSSigV4Signer.Sign(request, parameters).AuthorizationHeader;
        }

        private static string SignWithInternalSigner(Scenario scenario)
        {
            var uri = new Uri(scenario.Url);
            var internalRequest = new DefaultRequest(new ParityStubRequest(), Service)
            {
                HttpMethod = scenario.Method,
                Endpoint = new Uri(uri.GetLeftPart(UriPartial.Authority)),
                ResourcePath = uri.AbsolutePath,
                OverrideSigningServiceName = Service,
                AuthenticationRegion = Region,
                DisablePayloadSigning = !scenario.SignPayload,
                UseDoubleEncoding = false,
                Content = scenario.Content,
            };

            foreach (var header in scenario.Headers)
                internalRequest.Headers[header.Key] = header.Value;

            if (!string.IsNullOrEmpty(uri.Query))
            {
                internalRequest.UseQueryString = true;
                foreach (var pair in ParseQuery(uri.Query))
                    AddParam(internalRequest.ParameterCollection, pair.Key, pair.Value);
            }

            var config = new MockClientConfig { AuthenticationRegion = Region };
            return new AWS4Signer()
                .SignRequest(internalRequest, config, new RequestMetrics(), AccessKey, SecretKey, SignedAt)
                .ForAuthorizationHeader;
        }

        /// <summary>The sorted signed-header set the facade always produces, plus any extra caller headers.</summary>
        private static string ExpectedSignedHeaders(Scenario scenario)
        {
            var names = new List<string> { "host", "x-amz-content-sha256", "x-amz-date" };
            foreach (var key in scenario.Headers.Keys)
                names.Add(key.ToLowerInvariant());
            names.Sort(StringComparer.Ordinal);
            return string.Join(";", names);
        }

        private static IEnumerable<KeyValuePair<string, string>> ParseQuery(string query)
        {
            var start = query.IndexOf('?');
            var qs = start >= 0 ? query.Substring(start + 1) : query;
            foreach (var token in qs.Split('&'))
            {
                if (token.Length == 0) continue;
                var eq = token.IndexOf('=');
                if (eq < 0)
                    yield return new KeyValuePair<string, string>(Uri.UnescapeDataString(token), null);
                else
                    yield return new KeyValuePair<string, string>(
                        Uri.UnescapeDataString(token.Substring(0, eq)),
                        Uri.UnescapeDataString(token.Substring(eq + 1)));
            }
        }

        private static void AddParam(ParameterCollection parameters, string key, string value)
        {
            var normalized = value ?? string.Empty;
            if (!parameters.TryGetValue(key, out var existing))
                parameters.Add(key, normalized);
            else if (existing is StringListParameterValue list)
                list.Value.Add(normalized);
            else if (existing is StringParameterValue single)
                parameters[key] = new StringListParameterValue(new List<string> { single.Value, normalized });
        }

        private sealed class ParityStubRequest : AmazonWebServiceRequest { }
    }
}
