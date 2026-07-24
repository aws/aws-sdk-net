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
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Credentials;
using Amazon.Runtime.Signing;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    /// <summary>
    /// End-to-end tests for the standalone SigV4 signer (<see cref="AWSSigV4Signer"/>). These sign real
    /// requests with the ambient credentials/region and send them to STS, proving that a real AWS service
    /// accepts what the facade produces.
    ///
    /// STS <c>GetCallerIdentity</c> is used because it is callable by any valid identity, needs no
    /// provisioned resources, and exercises both the header-signing and presigned-URL flows (the latter is
    /// the same mechanism behind the EKS token flow).
    /// </summary>
    [Trait("Category", "SigV4Signer")]
    [Collection("Serial")]
    public class SigV4SignerIntegrationTests
    {
        private const string StsService = "sts";
        private static readonly HttpClient HttpClient = new HttpClient();

        private static RegionEndpoint Region => FallbackRegionFactory.GetRegionEndpoint() ?? RegionEndpoint.USEast1;

        private static Uri GetCallerIdentityUri() =>
            new Uri($"https://sts.{Region.SystemName}.amazonaws.com/?Action=GetCallerIdentity&Version=2011-06-15");

        private static AWSSigV4Parameters SigningParameters() => new AWSSigV4Parameters
        {
            Credentials = DefaultAWSCredentialsIdentityResolver.GetCredentials(),
            Region = Region,
            Service = StsService,
        };

        [Fact]
        [Trait("Category", "SigV4Signer")]
        public async Task Sign_GetCallerIdentity_SucceedsAgainstSts()
        {
            var signingRequest = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = GetCallerIdentityUri(),
                Headers = new Dictionary<string, string>(),
            };

            var result = await AWSSigV4Signer.SignAsync(signingRequest, SigningParameters());

            var message = new HttpRequestMessage(HttpMethod.Get, GetCallerIdentityUri());
            foreach (var header in result.Headers)
                message.Headers.TryAddWithoutValidation(header.Key, header.Value);

            using (var response = await HttpClient.SendAsync(message))
            {
                var body = await response.Content.ReadAsStringAsync();
                Assert.True(response.StatusCode == HttpStatusCode.OK, $"STS returned {(int)response.StatusCode}: {body}");
                Assert.Contains("<Arn>", body);
            }
        }

        [Fact]
        [Trait("Category", "SigV4Signer")]
        public async Task Presign_GetCallerIdentity_SucceedsAgainstSts()
        {
            var signingRequest = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = GetCallerIdentityUri(),
                Headers = new Dictionary<string, string>(),
            };

            var result = await AWSSigV4Signer.PresignAsync(signingRequest, SigningParameters(), TimeSpan.FromSeconds(60));

            // The presigned URL carries all auth in the query string, so it is fetched with no extra headers.
            using (var response = await HttpClient.GetAsync(result.Uri))
            {
                var body = await response.Content.ReadAsStringAsync();
                Assert.True(response.StatusCode == HttpStatusCode.OK, $"STS returned {(int)response.StatusCode}: {body}");
                Assert.Contains("<Arn>", body);
            }
        }
    }
}
