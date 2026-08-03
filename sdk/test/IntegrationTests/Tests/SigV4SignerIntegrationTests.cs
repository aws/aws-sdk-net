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
using Amazon.Util;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    /// <summary>
    /// End-to-end tests for the standalone SigV4 signer (<see cref="AWSSigV4Signer"/>). These sign real
    /// requests with the ambient credentials/region and send them to a real AWS service, proving the service
    /// accepts what the facade produces.
    ///
    /// STS <c>GetCallerIdentity</c> covers the non-S3 flow: it is callable by any valid identity, needs no
    /// provisioned resources, and exercises both header-signing and presigned-URL signing (the latter is the
    /// same mechanism behind the EKS token flow).
    ///
    /// The S3 tests cover object keys with characters that require percent-encoding (spaces, '+', '=',
    /// unicode): S3 signs the encoded request path verbatim, so a GET the facade signs must be accepted and
    /// return the object. Each S3 test creates and deletes its own bucket so the tests are self-contained.
    /// </summary>
    [Trait("Category", "SigV4Signer")]
    public class SigV4SignerIntegrationTests
    {
        private const string StsService = "sts";
        private const string S3Service = "s3";
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
                HttpMethod = HttpMethod.Get,
                RequestUri = GetCallerIdentityUri(),
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

        /// <summary>
        /// Demonstrates why callers must apply every entry in <see cref="AWSSigningResult.Headers"/> and not
        /// just the Authorization header. X-Amz-Date is part of the signed request (it is in the credential
        /// scope and the SignedHeaders list), so a request carrying only Authorization is rejected by STS,
        /// while the same request carrying the full set of headers succeeds. This is the failure mode that
        /// prompted removing a standalone AuthorizationHeader property from the result.
        /// </summary>
        [Fact]
        [Trait("Category", "SigV4Signer")]
        public async Task Sign_AuthorizationHeaderAlone_IsRejected_FullHeadersSucceed()
        {
            var signingRequest = new AWSSigningRequest
            {
                HttpMethod = HttpMethod.Get,
                RequestUri = GetCallerIdentityUri(),
            };

            var result = await AWSSigV4Signer.SignAsync(signingRequest, SigningParameters());

            // Sending ONLY the Authorization header (the tempting-but-wrong shortcut) omits X-Amz-Date, which
            // is covered by the signature, so STS must reject it.
            var authOnly = new HttpRequestMessage(HttpMethod.Get, GetCallerIdentityUri());
            authOnly.Headers.TryAddWithoutValidation(HeaderKeys.AuthorizationHeader, result.Headers[HeaderKeys.AuthorizationHeader]);
            using (var response = await HttpClient.SendAsync(authOnly))
            {
                Assert.False(response.StatusCode == HttpStatusCode.OK,
                    "STS unexpectedly accepted a request that carried only the Authorization header (missing X-Amz-Date).");
            }

            // Sending the full set of headers succeeds.
            var full = new HttpRequestMessage(HttpMethod.Get, GetCallerIdentityUri());
            foreach (var header in result.Headers)
                full.Headers.TryAddWithoutValidation(header.Key, header.Value);
            using (var response = await HttpClient.SendAsync(full))
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
                HttpMethod = HttpMethod.Get,
                RequestUri = GetCallerIdentityUri(),
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

        private static Uri GetCallerIdentityUriWithPlusInQuery() =>
            new Uri($"https://sts.{Region.SystemName}.amazonaws.com/" +
                    "?Action=GetCallerIdentity&Version=2011-06-15&q=a+b");

        /// <summary>
        /// Confirms STS accepts a signature over a query value containing a literal '+'. The facade form-decodes
        /// the '+' to a space (application/x-www-form-urlencoded), so the wire "?q=a+b" is signed with the
        /// canonical query "q=a%20b" — which is how STS (and the JS/Java/botocore signers) interpret it. Earlier
        /// the facade signed "q=a%2Bb" (RFC 3986, '+' kept literal), which STS rejected with
        /// SignatureDoesNotMatch; this test pins the corrected behavior against the live service.
        /// <para>
        /// SigV4 verification happens before request-parameter validation, so an unrecognized-parameter error
        /// still proves the signature was accepted. Only a signature rejection fails this test.
        /// </para>
        /// </summary>
        [Fact]
        [Trait("Category", "SigV4Signer")]
        public async Task Sign_QueryValueWithLiteralPlus_SignatureAcceptedBySts()
        {
            var uri = GetCallerIdentityUriWithPlusInQuery();

            var signingRequest = new AWSSigningRequest
            {
                HttpMethod = HttpMethod.Get,
                RequestUri = uri,
            };

            var result = await AWSSigV4Signer.SignAsync(signingRequest, SigningParameters());

            var message = new HttpRequestMessage(HttpMethod.Get, uri);
            foreach (var header in result.Headers)
                message.Headers.TryAddWithoutValidation(header.Key, header.Value);

            using (var response = await HttpClient.SendAsync(message))
            {
                var body = await response.Content.ReadAsStringAsync();
                Assert.False(body.Contains("SignatureDoesNotMatch"),
                    "STS rejected the signature for a query value containing a literal '+'. The facade must " +
                    "form-decode '+' to a space (sign \"q=a%20b\") to match how STS canonicalizes the query. " +
                    $"Response: {(int)response.StatusCode} {body}");
            }
        }

        // -----------------------------------------------------------------------
        // S3 — object keys with special characters
        //
        // The facade signs the encoded request path verbatim for S3, so a GET it signs (header or presigned)
        // for a key containing characters that require percent-encoding must be accepted by S3 and return the
        // object. A signer that double-encoded the path (e.g. a space as "%2520" instead of "%20") would get
        // SignatureDoesNotMatch or NoSuchKey.
        // -----------------------------------------------------------------------

        // Object keys that exercise the encoding: space, '+', '=', and unicode. An encoded slash is covered
        // separately below because it needs care in how the request URI is built.
        private const string SpecialCharKey = "hello world/a+b=c/café-☃.txt";

        private static AWSSigV4Parameters S3SigningParameters() => new AWSSigV4Parameters
        {
            Credentials = DefaultAWSCredentialsIdentityResolver.GetCredentials(),
            Region = Region,
            Service = S3Service,
        };

        [Fact]
        [Trait("Category", "SigV4Signer")]
        public async Task Sign_S3_ObjectWithSpecialCharKey_SucceedsAgainstS3()
        {
            await WithS3ObjectAsync(SpecialCharKey, async (uri, expectedBody) =>
            {
                var signingRequest = new AWSSigningRequest
                {
                    HttpMethod = HttpMethod.Get,
                    RequestUri = uri,
                };

                var result = await AWSSigV4Signer.SignAsync(signingRequest, S3SigningParameters());

                var message = new HttpRequestMessage(HttpMethod.Get, uri);
                foreach (var header in result.Headers)
                    message.Headers.TryAddWithoutValidation(header.Key, header.Value);

                using (var response = await HttpClient.SendAsync(message))
                {
                    var body = await response.Content.ReadAsStringAsync();
                    Assert.True(response.StatusCode == HttpStatusCode.OK, $"S3 returned {(int)response.StatusCode}: {body}");
                    Assert.Equal(expectedBody, body);
                }
            });
        }

        [Fact]
        [Trait("Category", "SigV4Signer")]
        public async Task Presign_S3_ObjectWithSpecialCharKey_SucceedsAgainstS3()
        {
            await WithS3ObjectAsync(SpecialCharKey, async (uri, expectedBody) =>
            {
                var signingRequest = new AWSSigningRequest
                {
                    HttpMethod = HttpMethod.Get,
                    RequestUri = uri,
                };

                var result = await AWSSigV4Signer.PresignAsync(signingRequest, S3SigningParameters(), TimeSpan.FromSeconds(60));

                using (var response = await HttpClient.GetAsync(result.Uri))
                {
                    var body = await response.Content.ReadAsStringAsync();
                    Assert.True(response.StatusCode == HttpStatusCode.OK, $"S3 returned {(int)response.StatusCode}: {body}");
                    Assert.Equal(expectedBody, body);
                }
            });
        }

        /// <summary>
        /// Pins how S3 canonicalizes an encoded slash ("%2F") in the wire path. The object key is literally
        /// "a/b"; a caller who percent-encodes the '/' addresses it as the wire path "/a%2Fb". S3 decodes
        /// "%2F" to '/' before recomputing the canonical path it signs (its own CanonicalRequest for this
        /// request is "/a/b"), so the facade must canonicalize the encoded slash the same way for the
        /// signature to validate.
        /// <para>
        /// A signer that signed "/a%2Fb" verbatim (zero encode passes, treating the encoded slash as a
        /// literal preserved within one segment) produces a canonical path S3 rejects with
        /// SignatureDoesNotMatch. This is the one case that distinguishes "sign the encoded wire path
        /// verbatim" from "canonicalize the wire path the way the service does" — every other special
        /// character (space, '+', '=', unicode) signs identically under both. Verified against live S3:
        /// this returns 200 only when the facade canonicalizes "%2F" like a real slash.
        /// </para>
        /// <para>
        /// Most meaningful on modern TFMs: net8 sends "%2F" on the wire verbatim (RawUrl "/a%2Fb"), so S3
        /// does the decoding. On net472 the client stack may itself decode "%2F" to '/' before sending, in
        /// which case S3 receives "/a/b" directly; the request still succeeds once the facade signs "/a/b".
        /// </para>
        /// </summary>
        [Fact]
        [Trait("Category", "SigV4Signer")]
        public async Task Sign_S3_EncodedSlashInKey_CanonicalizesLikeRealSlash()
        {
            await WithS3ObjectAsync("a/b", async (uri, expectedBody) =>
            {
                // uri addresses the object as the S3 client would ("/a/b"). Rebuild it with the slash
                // percent-encoded so this exercises the "%2F" wire form specifically.
                var encodedSlashUri = new Uri(uri.GetLeftPart(UriPartial.Authority) + "/a%2Fb");

                var signingRequest = new AWSSigningRequest
                {
                    HttpMethod = HttpMethod.Get,
                    RequestUri = encodedSlashUri,
                };

                var result = await AWSSigV4Signer.SignAsync(signingRequest, S3SigningParameters());

                var message = new HttpRequestMessage(HttpMethod.Get, encodedSlashUri);
                foreach (var header in result.Headers)
                    message.Headers.TryAddWithoutValidation(header.Key, header.Value);

                using (var response = await HttpClient.SendAsync(message))
                {
                    var body = await response.Content.ReadAsStringAsync();
                    Assert.True(response.StatusCode == HttpStatusCode.OK,
                        $"S3 rejected an encoded-slash wire path (/a%2Fb). S3 canonicalizes \"%2F\" to \"/\" " +
                        $"before signing (its canonical path is \"/a/b\"), so the facade must too rather than " +
                        $"signing the encoded slash verbatim. S3 returned {(int)response.StatusCode}: {body}");
                    Assert.Equal(expectedBody, body);
                }
            });
        }

        /// <summary>
        /// The presign counterpart of <see cref="Sign_S3_EncodedSlashInKey_CanonicalizesLikeRealSlash"/>. The
        /// presign path (query signing + URL assembly) is separate code from header signing, so it is exercised
        /// independently: a presigned URL the facade produces for the encoded-slash wire path ("/a%2Fb") must be
        /// accepted by S3 and return the object under key "a/b".
        /// </summary>
        [Fact]
        [Trait("Category", "SigV4Signer")]
        public async Task Presign_S3_EncodedSlashInKey_CanonicalizesLikeRealSlash()
        {
            await WithS3ObjectAsync("a/b", async (uri, expectedBody) =>
            {
                var encodedSlashUri = new Uri(uri.GetLeftPart(UriPartial.Authority) + "/a%2Fb");

                var signingRequest = new AWSSigningRequest
                {
                    HttpMethod = HttpMethod.Get,
                    RequestUri = encodedSlashUri,
                };

                var result = await AWSSigV4Signer.PresignAsync(signingRequest, S3SigningParameters(), TimeSpan.FromSeconds(60));

                using (var response = await HttpClient.GetAsync(result.Uri))
                {
                    var body = await response.Content.ReadAsStringAsync();
                    Assert.True(response.StatusCode == HttpStatusCode.OK,
                        $"S3 rejected a presigned URL for an encoded-slash wire path (/a%2Fb). The presign path " +
                        $"must canonicalize \"%2F\" to \"/\" (canonical \"/a/b\") like header signing does. " +
                        $"S3 returned {(int)response.StatusCode}: {body}");
                    Assert.Equal(expectedBody, body);
                }
            });
        }

        /// <summary>
        /// Creates a temporary S3 bucket with a single object under <paramref name="key"/>, invokes
        /// <paramref name="body"/> with the object's request URI (encoded the way the S3 client encodes the
        /// key) and the expected object content, then deletes the object and bucket. The request URI is
        /// derived from the S3 client's own presigned URL so the key is encoded exactly as S3 expects,
        /// isolating the facade's signing (not URI construction) as what is under test.
        /// </summary>
        private static async Task WithS3ObjectAsync(string key, Func<Uri, string, Task> body)
        {
            var bucket = "aws-net-sdk-sigv4-facade-" + Guid.NewGuid().ToString("N").Substring(0, 12);
            var content = "sigv4-facade-" + Guid.NewGuid().ToString("N");

            using (var s3 = new Amazon.S3.AmazonS3Client(Region))
            {
                await s3.PutBucketAsync(new Amazon.S3.Model.PutBucketRequest { BucketName = bucket });
                try
                {
                    await s3.PutObjectAsync(new Amazon.S3.Model.PutObjectRequest
                    {
                        BucketName = bucket,
                        Key = key,
                        ContentBody = content,
                    });

                    // Use the S3 client's own presigned URL to get the correctly-encoded object path, then
                    // strip the query so we start from a bare GET URL for the facade to sign.
                    var sdkPresigned = await s3.GetPreSignedURLAsync(new Amazon.S3.Model.GetPreSignedUrlRequest
                    {
                        BucketName = bucket,
                        Key = key,
                        Verb = Amazon.S3.HttpVerb.GET,
                        Expires = DateTime.UtcNow.AddMinutes(5),
                    });
                    var uri = new Uri(new Uri(sdkPresigned).GetLeftPart(UriPartial.Path));

                    await body(uri, content);
                }
                finally
                {
                    try { await Amazon.S3.Util.AmazonS3Util.DeleteS3BucketWithObjectsAsync(s3, bucket); }
                    catch { /* best-effort cleanup */ }
                }
            }
        }
    }
}
