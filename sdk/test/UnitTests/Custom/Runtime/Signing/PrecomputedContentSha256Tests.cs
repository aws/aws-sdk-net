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
using System.Text;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests.Signing
{
    [TestClass]
    [TestCategory("Core")]
    [TestCategory("Signer")]
    public class PrecomputedContentSha256Tests
    {
        private const string AccessKey = "AKIDEXAMPLE";
        private const string SecretKey = "wJalrXUtnFEMI/K7MDENG+bPxRfiCYEXAMPLEKEY";
        private const string Region = "us-east-1";
        private const string Service = "service";

        // -----------------------------------------------------------------------
        // IRequest.PrecomputedContentSha256 is honored by SetRequestBodyHash ahead of the body read,
        // so a caller can sign a precomputed body hash without the signer reading the body. Routed
        // through a request field so the shared resign/scrub path is left untouched.
        // -----------------------------------------------------------------------

        [TestMethod]
        public void SetRequestBodyHash_WithPrecomputedHash_UsesItVerbatim()
        {
            // A precomputed hash must be used verbatim as x-amz-content-sha256, even when a body is present
            // that would otherwise be read and hashed.
            var precomputed = new string('a', 64);
            var config = new MockClientConfig { AuthenticationRegion = Region };
            var request = BuildInternalRequest();
            request.Content = Encoding.UTF8.GetBytes("some body the signer must not read");
            request.PrecomputedContentSha256 = precomputed;

            new AWS4Signer().SignRequest(request, config, new RequestMetrics(), AccessKey, SecretKey);

            Assert.AreEqual(precomputed, request.Headers[HeaderKeys.XAmzContentSha256Header]);
        }

        [TestMethod]
        public void SetRequestBodyHash_WithPrecomputedHash_SurvivesStaleHeaderScrub()
        {
            // The precomputed value is honored ahead of the body read, so it must survive the
            // InitializeHeaders/CleanHeaders scrub that clears a stale x-amz-content-sha256 before signing.
            var precomputed = new string('b', 64);
            var config = new MockClientConfig { AuthenticationRegion = Region };
            var request = BuildInternalRequest();
            // Inject a stale header value as though from a prior signing pass.
            request.Headers[HeaderKeys.XAmzContentSha256Header] = new string('c', 64);
            request.PrecomputedContentSha256 = precomputed;

            new AWS4Signer().SignRequest(request, config, new RequestMetrics(), AccessKey, SecretKey);

            Assert.AreEqual(precomputed, request.Headers[HeaderKeys.XAmzContentSha256Header]);
        }

        [TestMethod]
        public void SetRequestBodyHash_WithoutPrecomputedHash_StillScrubsStaleContentHash()
        {
            // Guards that the standard signer path (no PrecomputedContentSha256 set) is unaffected: it must
            // still recompute x-amz-content-sha256 rather than trusting a stale header value.
            var config = new MockClientConfig { AuthenticationRegion = Region };
            var request = BuildInternalRequest();
            // Inject a stale hash as though from a prior signing pass; leave PrecomputedContentSha256 unset.
            request.Headers[HeaderKeys.XAmzContentSha256Header] = new string('d', 64);

            new AWS4Signer().SignRequest(request, config, new RequestMetrics(), AccessKey, SecretKey);

            // Empty body → the signer should have replaced the stale value with the empty-body SHA.
            Assert.AreEqual(AWS4Signer.EmptyBodySha256, request.Headers[HeaderKeys.XAmzContentSha256Header]);
        }

        private static IRequest BuildInternalRequest()
        {
            return new DefaultRequest(new StubRequest(), Service)
            {
                HttpMethod = "GET",
                Endpoint = new Uri("https://example.amazonaws.com"),
                ResourcePath = "/",
                OverrideSigningServiceName = Service,
                AuthenticationRegion = Region,
            };
        }

        private class StubRequest : AmazonWebServiceRequest { }
    }
}
