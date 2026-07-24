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
using System.Text;
using System.Text.Json;
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
    /// <summary>
    /// Known-answer coverage for <see cref="AWSSigV4Signer"/>. The signing scenarios are loaded from the shared
    /// fixture sigv4_test_cases.json (embedded resource). <see cref="Facade_MatchesKnownAnswerVector"/> asserts
    /// the facade reproduces each scenario's expectedSignature (header signing), and
    /// <see cref="Presign_MatchesKnownAnswerVector"/> asserts its expectedPresignSignature (query signing).
    /// The fixture values are corroborated by the real-SDK oracles in reference/ (JS @smithy primary, botocore
    /// secondary) and by the live-STS integration tests, so a systematic canonicalization / string-to-sign /
    /// signing-key defect cannot pass unnoticed.
    /// </summary>
    [TestClass]
    [TestCategory("Core")]
    [TestCategory("Signer")]
    public class AWSSigV4SignerParityTests
    {
        /// <summary>A logical signing scenario, loaded from the shared sigv4_test_cases.json fixture.</summary>
        public sealed class Scenario
        {
            public string Name;
            public string Method;
            public string Url;
            public Dictionary<string, string> Headers = new Dictionary<string, string>();
            public byte[] Content;
            public bool SignPayload = true;
            /// <summary>Optional session token; when set, signed as the x-amz-security-token header.</summary>
            public string SessionToken;
            /// <summary>Externally-computed expected header-signing signature (hex) from the shared fixture.</summary>
            public string ExpectedSignature;
            /// <summary>Externally-computed expected presign (query-signing) signature (hex); null if not presignable.</summary>
            public string ExpectedPresignSignature;
            public override string ToString() => Name;
        }

        // The credentials/region/service/time come from the same shared JSON fixture that the Python
        // reference oracle uses, so the two cannot drift.
        private static string AccessKey;
        private static string SecretKey;
        private static string Region;
        private static string Service;
        private static DateTime SignedAt;
        private static Scenario[] Scenarios;

        [ClassInitialize]
        public static void LoadSharedFixture(TestContext context)
        {
            var json = LoadFixtureJson();
            using (var doc = JsonDocument.Parse(json))
            {
                var creds = doc.RootElement.GetProperty("credentials");
                AccessKey = creds.GetProperty("accessKey").GetString();
                SecretKey = creds.GetProperty("secretKey").GetString();
                Region = creds.GetProperty("region").GetString();
                Service = creds.GetProperty("service").GetString();
                var amzDate = creds.GetProperty("amzDate").GetString();
                SignedAt = DateTime.ParseExact(amzDate, "yyyyMMdd'T'HHmmss'Z'", CultureInfo.InvariantCulture,
                    DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal);

                var list = new List<Scenario>();
                foreach (var c in doc.RootElement.GetProperty("cases").EnumerateArray())
                {
                    var scenario = new Scenario
                    {
                        Name = c.GetProperty("name").GetString(),
                        Method = c.GetProperty("method").GetString(),
                        Url = c.GetProperty("url").GetString(),
                        SignPayload = c.GetProperty("signPayload").GetBoolean(),
                        SessionToken = c.TryGetProperty("sessionToken", out var token) ? token.GetString() : null,
                        ExpectedSignature = c.GetProperty("expectedSignature").GetString(),
                        ExpectedPresignSignature = c.TryGetProperty("expectedPresignSignature", out var ps) ? ps.GetString() : null,
                    };
                    foreach (var h in c.GetProperty("headers").EnumerateObject())
                        scenario.Headers[h.Name] = h.Value.GetString();
                    var body = c.GetProperty("body");
                    if (body.ValueKind != JsonValueKind.Null)
                        scenario.Content = Encoding.UTF8.GetBytes(body.GetString());
                    list.Add(scenario);
                }
                Scenarios = list.ToArray();
            }
        }

        // Load the shared fixture from the test assembly's embedded resources. The manifest name is the
        // auto-generated one (namespace + folder path + file name, e.g.
        // "AWSSDK.UnitTests.NetStandard.Custom.Runtime.Signing.reference.sigv4_test_cases.json"), which varies
        // by assembly, so match on the file-name suffix rather than a fixed full name. The embed itself is
        // declared in generator/ServiceModels/_manifest.json (embeddedResources), since the NetStandard uber
        // test csproj is code-generated and a hand-added <EmbeddedResource> in the csproj is overwritten by the
        // generator in a full build. Throw a clear, self-diagnosing error listing what IS embedded if the
        // fixture is ever missing, rather than an opaque ArgumentNullException.
        private static string LoadFixtureJson()
        {
            const string fileName = "sigv4_test_cases.json";
            var assembly = typeof(AWSSigV4SignerParityTests).Assembly;

            var resourceName = assembly.GetManifestResourceNames()
                .FirstOrDefault(n => n.EndsWith(fileName, StringComparison.OrdinalIgnoreCase));

            if (resourceName == null)
            {
                var available = string.Join(", ", assembly.GetManifestResourceNames());
                throw new InvalidOperationException(
                    $"Embedded resource '{fileName}' was not found in {assembly.GetName().Name}. " +
                    $"Available resources: {available}");
            }

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            using (var reader = new StreamReader(stream))
                return reader.ReadToEnd();
        }

        public static IEnumerable<object[]> AllScenarios()
        {
            // DynamicData is evaluated before ClassInitialize, so load the fixture here too if needed.
            EnsureLoaded();
            return Scenarios.Select(s => new object[] { s.Name });
        }

        // Presign rejects a request body and a precomputed content hash, so the presign parity test runs over
        // the body-less, non-precomputed-hash scenarios (which still exercise paths, query params, ports,
        // unicode/reserved query values, session tokens, and unsigned payload for the query-signing flow).
        public static IEnumerable<object[]> PresignableScenarios()
        {
            EnsureLoaded();
            return Scenarios
                .Where(s => s.Content == null
                            && !s.Headers.Keys.Any(k => string.Equals(k, HeaderKeys.XAmzContentSha256Header, StringComparison.OrdinalIgnoreCase)))
                .Select(s => new object[] { s.Name });
        }

        private static void EnsureLoaded()
        {
            if (Scenarios == null)
                LoadSharedFixture(null);
        }

        private static Scenario Get(string name)
        {
            EnsureLoaded();
            return Scenarios.Single(s => s.Name == name);
        }

        [TestMethod]
        [DynamicData(nameof(AllScenarios))]
        public void Facade_MatchesKnownAnswerVector(string scenarioName)
        {
            var scenario = Get(scenarioName);
            var facade = SignWithFacade(scenario);
            var expected =
                "AWS4-HMAC-SHA256 " +
                $"Credential={AccessKey}/{SignedAt.ToString("yyyyMMdd", CultureInfo.InvariantCulture)}/{Region}/{Service}/aws4_request, " +
                $"SignedHeaders={ExpectedSignedHeaders(scenario)}, " +
                $"Signature={scenario.ExpectedSignature}";

            Assert.AreEqual(expected, facade,
                $"Facade output did not match the independent known-answer vector for scenario '{scenario.Name}'.");
        }

        [TestMethod]
        [DynamicData(nameof(PresignableScenarios))]
        public void Presign_MatchesKnownAnswerVector(string scenarioName)
        {
            // Presign is checked against expectedPresignSignature, a .NET-authored known-answer value that the
            // real-SDK oracles (JS @smithy primary, botocore secondary) independently corroborate. This is not
            // a hand-built internal-signer comparison: reimplementing the presign steps in the test and calling
            // the same AWS4PreSignedUrlSigner would be circular, so a shared bug could pass. The known-answer
            // value is the anchor a facade-only presign bug would fail against.
            var scenario = Get(scenarioName);
            Assert.IsNotNull(scenario.ExpectedPresignSignature,
                $"Scenario '{scenario.Name}' is missing expectedPresignSignature.");

            var facadeSig = PresignWithFacade(scenario);

            Assert.AreEqual(scenario.ExpectedPresignSignature, facadeSig,
                $"Facade presign signature did not match the independent known-answer vector for scenario '{scenario.Name}'.");
        }

        // --- helpers ---

        private const int PresignExpirySeconds = 900;

        private static string SignWithFacade(Scenario scenario)
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = scenario.Method,
                RequestUri = new Uri(scenario.Url),
                Headers = new Dictionary<string, string>(scenario.Headers),
                Content = scenario.Content,
            };
            var parameters = new AWSSigV4Parameters
            {
                Credentials = scenario.SessionToken != null
                    ? (AWSCredentials)new SessionAWSCredentials(AccessKey, SecretKey, scenario.SessionToken)
                    : new BasicAWSCredentials(AccessKey, SecretKey),
                Region = RegionEndpoint.GetBySystemName(Region),
                Service = Service,
                SignedAt = SignedAt,
                SignPayload = scenario.SignPayload,
            };
            return AWSSigV4Signer.Sign(request, parameters).Headers[HeaderKeys.AuthorizationHeader];
        }

        private static string PresignWithFacade(Scenario scenario)
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = scenario.Method,
                RequestUri = new Uri(scenario.Url),
                Headers = new Dictionary<string, string>(scenario.Headers),
            };
            var parameters = new AWSSigV4Parameters
            {
                Credentials = scenario.SessionToken != null
                    ? (AWSCredentials)new SessionAWSCredentials(AccessKey, SecretKey, scenario.SessionToken)
                    : new BasicAWSCredentials(AccessKey, SecretKey),
                Region = RegionEndpoint.GetBySystemName(Region),
                Service = Service,
                SignedAt = SignedAt,
                SignPayload = scenario.SignPayload,
            };
            var result = AWSSigV4Signer.Presign(request, parameters, TimeSpan.FromSeconds(PresignExpirySeconds));
            return ExtractQueryParam(result.Uri.Query, "X-Amz-Signature");
        }

        private static string ExtractQueryParam(string query, string key)
        {
            // Reuse the facade's own query parser (internal, via InternalsVisibleTo) rather than duplicating
            // the split/decode logic here — it preserves repeated keys and the flag-vs-empty distinction the
            // same way the signing path does.
            foreach (var pair in AWSSigV4Signer.ParseQueryParameters(query))
                if (string.Equals(pair.Key, key, StringComparison.OrdinalIgnoreCase))
                    return pair.Value;
            return null;
        }

        /// <summary>The sorted signed-header set the facade always produces, plus any extra caller headers.</summary>
        private static string ExpectedSignedHeaders(Scenario scenario)
        {
            var names = new HashSet<string>(StringComparer.Ordinal) { "host", "x-amz-content-sha256", "x-amz-date" };
            if (scenario.SessionToken != null)
                names.Add("x-amz-security-token");
            foreach (var key in scenario.Headers.Keys)
                names.Add(key.ToLowerInvariant());  // e.g. a caller-supplied x-amz-content-sha256 dedupes with the base set
            var sorted = names.ToList();
            sorted.Sort(StringComparer.Ordinal);
            return string.Join(";", sorted);
        }

    }
}
