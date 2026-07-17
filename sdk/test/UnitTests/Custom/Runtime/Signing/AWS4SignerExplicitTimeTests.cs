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
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests.Signing
{
    [TestClass]
    [TestCategory("Core")]
    [TestCategory("Signer")]
    public class AWS4SignerExplicitTimeTests
    {
        private const string AccessKey = "AKIDEXAMPLE";
        private const string SecretKey = "wJalrXUtnFEMI/K7MDENG+bPxRfiCYEXAMPLEKEY";
        private const string Region = "us-east-1";
        private const string Service = "service";

        // -----------------------------------------------------------------------
        // Time-accepting overloads: the parameterless-time overloads must delegate to the
        // time-accepting ones with the previously-computed default, so existing callers are unchanged.
        // -----------------------------------------------------------------------

        [TestMethod]
        public void SignRequest_DefaultTime_MatchesExplicitTimeWithSameInstant()
        {
            // The original 5-arg SignRequest computed its signing time via
            // CorrectClockSkew.GetCorrectedUtcNowForEndpoint and used it. The refactor moved the logic into a
            // 6-arg time-accepting overload and made the 5-arg delegate with that same computed default.
            //
            // We can't independently recompute the default instant and expect a match, since the default
            // overload computes its own corrected-now that would differ from ours by the wall-clock elapsed
            // between the two calls. Instead we capture the exact instant the default path actually used
            // (surfaced on the result as DateTime), then re-sign with the explicit overload using that same
            // instant and compare a time-sensitive output. A broken delegation (wrong default, double header
            // init, dropped reassignment) would make ForAuthorizationHeader diverge here.
            var config = new MockClientConfig { AuthenticationRegion = Region };

            var defaultResult = new AWS4Signer().SignRequest(
                BuildInternalRequest(), config, new RequestMetrics(), AccessKey, SecretKey);
            var explicitResult = new AWS4Signer().SignRequest(
                BuildInternalRequest(), config, new RequestMetrics(), AccessKey, SecretKey, defaultResult.DateTime);

            // ForAuthorizationHeader folds in the full signature (down to the second via the credential scope
            // date and x-amz-date), so it only matches if both paths signed at the identical instant.
            Assert.AreEqual(explicitResult.ForAuthorizationHeader, defaultResult.ForAuthorizationHeader);
        }

        [TestMethod]
        public void SignRequest_ExplicitTime_IsDeterministic()
        {
            // A fixed signing instant must produce a fixed signature: signing the same request twice with the
            // same explicit time yields identical authorization output.
            var config = new MockClientConfig { AuthenticationRegion = Region };
            var signedAt = new DateTime(2015, 8, 30, 12, 36, 0, DateTimeKind.Utc);

            var first = new AWS4Signer().SignRequest(
                BuildInternalRequest(), config, new RequestMetrics(), AccessKey, SecretKey, signedAt);
            var second = new AWS4Signer().SignRequest(
                BuildInternalRequest(), config, new RequestMetrics(), AccessKey, SecretKey, signedAt);

            Assert.AreEqual(first.ForAuthorizationHeader, second.ForAuthorizationHeader);
            // The scope carries the signing date; a fixed instant pins it.
            StringAssert.Contains(first.Scope, "20150830");
        }

        [TestMethod]
        public void PresignRequest_ExplicitTime_IsDeterministic()
        {
            // The presigner's time-accepting overload must likewise pin the signature to the supplied instant.
            var config = new MockClientConfig { AuthenticationRegion = Region };
            var signedAt = new DateTime(2015, 8, 30, 12, 36, 0, DateTimeKind.Utc);

            var first = AWS4PreSignedUrlSigner.SignRequest(
                BuildInternalRequest(), config, new RequestMetrics(), AccessKey, SecretKey, Service, Region, signedAt);
            var second = AWS4PreSignedUrlSigner.SignRequest(
                BuildInternalRequest(), config, new RequestMetrics(), AccessKey, SecretKey, Service, Region, signedAt);

            Assert.AreEqual(first.ForQueryParameters, second.ForQueryParameters);
            StringAssert.Contains(first.Scope, "20150830");
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
