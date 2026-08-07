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
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Credentials;
using Amazon.Runtime.Signing;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    /// <summary>
    /// End-to-end tests for <see cref="SigV4SigningHandler"/>. These install the handler on a real
    /// <see cref="HttpClient"/> and send requests to STS, proving that a request signed transparently by the
    /// handler is accepted by a real AWS service.
    ///
    /// STS <c>GetCallerIdentity</c> is used because it is callable by any valid identity and needs no
    /// provisioned resources. It accepts the request either as a GET (empty body) or a POST with the action
    /// in a form-encoded body, so the same operation exercises both the no-body and body-hashing paths.
    /// </summary>
    [Trait("Category", "SigV4Signer")]
    public class SigV4SigningHandlerIntegrationTests
    {
        private const string StsService = "sts";

        private static string Region => FallbackRegionFactory.GetRegionEndpoint()?.SystemName ?? "us-east-1";

        private static Uri StsEndpoint() => new Uri($"https://sts.{Region}.amazonaws.com/");

        private static HttpClient NewSignedClient()
        {
            var handler = new SigV4SigningHandler(
                DefaultAWSCredentialsIdentityResolver.GetCredentials(),
                RegionEndpoint.GetBySystemName(Region),
                StsService)
            {
                // A signing handler must not auto-follow redirects: a redirect is replayed below this handler
                // (unsigned for the new host) and would be rejected. STS won't redirect here, but this is the
                // correct production configuration and keeps the test faithful to documented guidance.
                InnerHandler = new HttpClientHandler { AllowAutoRedirect = false },
            };

            return new HttpClient(handler);
        }

        [Fact]
        [Trait("Category", "SigV4Signer")]
        public async Task Get_GetCallerIdentity_SucceedsAgainstSts()
        {
            using (var client = NewSignedClient())
            {
                var uri = new Uri(StsEndpoint(), "?Action=GetCallerIdentity&Version=2011-06-15");

                using (var response = await client.GetAsync(uri))
                {
                    var body = await response.Content.ReadAsStringAsync();
                    Assert.True(response.StatusCode == HttpStatusCode.OK, $"STS returned {(int)response.StatusCode}: {body}");
                    Assert.Contains("<Arn>", body);
                }
            }
        }

        [Fact]
        [Trait("Category", "SigV4Signer")]
        public async Task Post_WithBody_GetCallerIdentity_SucceedsAgainstSts()
        {
            // A form-encoded POST body proves the handler buffers and hashes the payload end-to-end: STS
            // recomputes the body hash and rejects the signature if it does not match what the handler signed.
            using (var client = NewSignedClient())
            {
                var content = new StringContent(
                    "Action=GetCallerIdentity&Version=2011-06-15",
                    Encoding.UTF8,
                    "application/x-www-form-urlencoded");

                using (var response = await client.PostAsync(StsEndpoint(), content))
                {
                    var body = await response.Content.ReadAsStringAsync();
                    Assert.True(response.StatusCode == HttpStatusCode.OK, $"STS returned {(int)response.StatusCode}: {body}");
                    Assert.Contains("<Arn>", body);
                }
            }
        }

        [Fact]
        [Trait("Category", "SigV4Signer")]
        public async Task Post_WithLargeBody_SucceedsAgainstSts()
        {
            // A body larger than the LOH threshold exercises the handler's streamed body hashing end to end:
            // the handler hashes the buffered content stream in chunks rather than a materialized byte[], and
            // STS recomputes the body hash and rejects the signature if the streamed hash is wrong. The extra
            // ignored form field pads the body past 85 KB while keeping GetCallerIdentity the requested action.
            using (var client = NewSignedClient())
            {
                var padding = new string('a', 200 * 1024);
                var content = new StringContent(
                    "Action=GetCallerIdentity&Version=2011-06-15&Padding=" + padding,
                    Encoding.UTF8,
                    "application/x-www-form-urlencoded");

                using (var response = await client.PostAsync(StsEndpoint(), content))
                {
                    var body = await response.Content.ReadAsStringAsync();
                    Assert.True(response.StatusCode == HttpStatusCode.OK, $"STS returned {(int)response.StatusCode}: {body}");
                    Assert.Contains("<Arn>", body);
                }
            }
        }

        [Fact]
        [Trait("Category", "SigV4Signer")]
        public async Task Post_WithSameHeaderOnRequestAndContent_SucceedsAgainstSts()
        {
            // A header set on both the request and the content goes on the wire as two lines (request value
            // first, then content value), which SigV4 canonicalizes as one comma-joined value in that order.
            // The handler must sign that same combined value. STS includes the header in SignedHeaders and
            // recomputes the signature over the value it received, so a wrong combination (or order) is
            // rejected with a 403 SignatureDoesNotMatch — making a 200 here proof the combination is correct
            // end-to-end.
            using (var client = NewSignedClient())
            {
                var content = new StringContent(
                    "Action=GetCallerIdentity&Version=2011-06-15",
                    Encoding.UTF8,
                    "application/x-www-form-urlencoded");
                content.Headers.TryAddWithoutValidation("x-custom", "content-value");

                var request = new HttpRequestMessage(HttpMethod.Post, StsEndpoint()) { Content = content };
                request.Headers.TryAddWithoutValidation("x-custom", "request-value");

                using (var response = await client.SendAsync(request))
                {
                    var body = await response.Content.ReadAsStringAsync();
                    Assert.True(response.StatusCode == HttpStatusCode.OK, $"STS returned {(int)response.StatusCode}: {body}");
                    Assert.Contains("<Arn>", body);
                }
            }
        }
    }
}
