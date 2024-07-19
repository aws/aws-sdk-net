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

using Amazon;
using Amazon.Extensions.CrtIntegration;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using Aws.Crt.Auth;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Xunit;

namespace CrtIntegrationTests
{
    public class V4aSignerTests : IDisposable
    {
        private const string SigningTestAccessKeyId = "AKIDEXAMPLE";
        private const string SigningTestSecretAccessKey = "wJalrXUtnFEMI/K7MDENG+bPxRfiCYEXAMPLEKEY";
        private readonly ImmutableCredentials SigningTestCredentials = new ImmutableCredentials(SigningTestAccessKeyId, SigningTestSecretAccessKey, "");

        /* The public coordinates of the ecc key derived from the above credentials pair */
        private const string SigningTestEccPubX = "b6618f6a65740a99e650b33b6b4b5bd0d43b176d721a3edfea7e7d2d56d936b1";
        private const string SigningTestEccPubY = "865ed22a7eadc9c5cb9d2cbaca1b3699139fedc5043dc6661864218330c8e518";

        private const string SigningTestHost = "example.amazonaws.com";
        private const string SigningTestService = "service";
        private const string SigningTestRegion = "us-east-1";
        private static readonly DateTime SigningTestTimepoint = new DateTime(2015, 8, 30, 12, 36, 0, DateTimeKind.Utc);

        private const int Chunk1Size = 65536;
        private const int Chunk2Size = 1024;

        public V4aSignerTests()
        {
            // Override the SDK's AWSConfigs.utcNowSource to return a fixed time to test predictable signatures
            SetUtcNowSource(() => SigningTestTimepoint);
        }

        public void Dispose()
        {
            // Reset back to the SDK's usual GetUtcNow function
            SetUtcNowSource((Func<DateTime>)Delegate.CreateDelegate(typeof(Func<DateTime>),
                typeof(AWSConfigs).GetMethod("GetUtcNow", BindingFlags.Static | BindingFlags.NonPublic)));
        }

        static void SetUtcNowSource(Func<DateTime> source)
        {
            var field = typeof(AWSConfigs).GetField("utcNowSource", BindingFlags.Static | BindingFlags.NonPublic);
            field.SetValue(null, source);
        }

        internal static IClientConfig BuildSigningClientConfig(string service)
        {
            return new TestClientConfig
            {
                UseHttp = false,
                AuthenticationRegion = SigningTestRegion,
                AuthenticationServiceName = service
            };
        }

        internal AwsSigningConfig BuildDefaultSigningConfig(string service)
        {
            var config = new AwsSigningConfig
            {
                Algorithm = AwsSigningAlgorithm.SIGV4A,
                SignedBodyHeader = AwsSignedBodyHeaderType.X_AMZ_CONTENT_SHA256,

                SignatureType = AwsSignatureType.HTTP_REQUEST_VIA_HEADERS,
                Region = SigningTestRegion,
                Service = service,
                Timestamp = new DateTimeOffset(SigningTestTimepoint),
                Credentials = new Credentials(SigningTestAccessKeyId, SigningTestSecretAccessKey, "")
            };

            if (service == "s3")
            {
                config.UseDoubleUriEncode = false;
                config.ShouldNormalizeUriPath = false;
            }
            else
            {
                config.UseDoubleUriEncode = true;
                config.ShouldNormalizeUriPath = true;
            }

            return config;
        }

        #region HTTP signing with headers
        internal static IRequest BuildHeaderRequestToSign(string resourcePath, Dictionary<string,string> pathResources)
        {
            var mock = new Mock<IRequest>();

            mock.SetupAllProperties();

            var headers = new Dictionary<string, string>
            {
                { "Content-Length", "13" },
                { "Content-Type", "application/x-www-form-urlencoded" },
                { "amz-sdk-request", "attempt=1; max=5" },
                { "amz-sdk-invocation-id", "a7d0c828-1fc1-43e8-9f9e-367a7011fc84" },
                { "x-amzn-trace-id", "Root=1-63441c4a-abcdef012345678912345678" }
            };


            mock.SetupGet(x => x.Headers).Returns(headers);
            mock.SetupGet(x => x.PathResources).Returns(pathResources);

            IRequest request = mock.Object;
            request.HttpMethod = "POST";
            request.ResourcePath = resourcePath;
            request.Content = Encoding.ASCII.GetBytes("Param1=value1");
            request.Endpoint = new Uri("https://" + SigningTestHost + "/");

            return request;
        }

        internal string GetExpectedCanonicalRequestForHeaderSigningTest(string canonicalizedResourePath)
        {
            return String.Join('\n',
                "POST",
                canonicalizedResourePath,
                "",
                "content-length:13",
                "content-type:application/x-www-form-urlencoded",
                "host:example.amazonaws.com",
                "x-amz-content-sha256:9095672bbd1f56dfc5b65f3e153adc8731a4a654192329106275f4c7b24d0b6e",
                "x-amz-date:20150830T123600Z",
                "x-amz-region-set:us-east-1",
                "",
                "content-length;content-type;host;x-amz-content-sha256;x-amz-date;x-amz-region-set",
                "9095672bbd1f56dfc5b65f3e153adc8731a4a654192329106275f4c7b24d0b6e");
        }

        [Theory]
        [InlineData(SigningTestService,"","" , "", "/")]
        [InlineData(SigningTestService, "{resource}","{resource}", "foo$*[]!()bar", "/foo%2524%252A%255B%255D%2521%2528%2529bar")]
        [InlineData(SigningTestService, "{resource}", "{resource}", "foo bar", "/foo%2520bar")]
        [InlineData(SigningTestService, "{resource+}", "{resource+}", "foo/bar", "/foo/bar")]
        [InlineData(SigningTestService, "{resource}", "{resource}", "foo%2Fbar", "/foo%25252Fbar")]
        [InlineData(SigningTestService, "{resource}", "{resource}", "foo\\bar", "/foo%255Cbar")]
        [InlineData(SigningTestService, "{resource}", "{resource}", "foo&bar", "/foo%2526bar")]
        [InlineData(SigningTestService, "{resource+}", "{resource+}", "my-object//example//photo.user", "/my-object/example/photo.user")] // should normalize
        [InlineData(SigningTestService, "my-object//example//photo.user", "", "", "/my-object/example/photo.user")] // should normalize
        //
        // Test S3 specifically since it has slightly different behavior due to UseDoubleUriEncode and ShouldNormalizeUriPath being false
        //
        [InlineData("s3", "", "", "", "/")]
        [InlineData("s3", "{resource}","{resource}","foo$*[]!()bar", "/foo%24%2A%5B%5D%21%28%29bar")]
        [InlineData("s3", "{resource}","{resource}" , "foo bar", "/foo%20bar")]
        [InlineData("s3", "{resource}", "{resource}", "foo%2Fbar", "/foo%252Fbar")]
        [InlineData("s3", "{resource+}", "{resource+}", "foo/bar", "/foo/bar")] // if greedy label is attached we don't encode the forward slash
        [InlineData("s3", "{resource}", "{resource}", "foo\\bar", "/foo%5Cbar")]
        [InlineData("s3", "{resource}", "{resource}", "foo&bar", "/foo%26bar")]
        [InlineData("s3", "{resource+}", "{resource+}", "my-object//example//photo.user", "/my-object//example//photo.user")] // should not normalize
        [InlineData("s3", "my-object//example//photo.user", "", "", "/my-object//example//photo.user")] // should not normalize
        public void SignRequestViaHeadersWithSigv4a(string service, string resourcePath,string key, string value, string canonicalizedResourcePath)
        {
            var signer = new CrtAWS4aSigner();

            Dictionary<string, string> pathResources = new Dictionary<string, string>()
            {
                {key, value  }
            };
            var request = BuildHeaderRequestToSign(resourcePath, pathResources);

            request.UseDoubleEncoding = service != "s3";

            var clientConfig = BuildSigningClientConfig(service);

            var result = signer.SignRequest(request, clientConfig, null, SigningTestCredentials);
            string signatureValue = result.Signature;

            var canonicalRequest = GetExpectedCanonicalRequestForHeaderSigningTest(canonicalizedResourcePath);

            var config = BuildDefaultSigningConfig(service);
            config.SignatureType = AwsSignatureType.CANONICAL_REQUEST_VIA_HEADERS;

            Assert.True(AwsSigner.VerifyV4aCanonicalSigning(canonicalRequest, config, signatureValue, SigningTestEccPubX, SigningTestEccPubY));
            Assert.DoesNotContain("amz-sdk-request", result.SignedHeaders);
            Assert.DoesNotContain("amz-sdk-invocation-id", result.SignedHeaders);
            Assert.DoesNotContain("x-amzn-trace-id", result.SignedHeaders);
        }
        #endregion

        #region HTTP (pre)signing with query params
        internal static IRequest BuildQueryParamRequestToSign()
        {
            var mock = new Mock<IRequest>();

            mock.SetupAllProperties();

            var headers = new Dictionary<string, string>();
            mock.SetupGet(x => x.Headers).Returns(headers);

            var subResources = new Dictionary<string, string>
            {
                { "Param1", "value1"},
                { "Param2", "value2"}
            };
            mock.SetupGet(x => x.SubResources).Returns(subResources);

            var request = mock.Object;
            request.HttpMethod = "GET";
            request.ResourcePath = "/";
            request.Endpoint = new Uri("https://" + SigningTestHost + "/");

            return request;
        }

        internal string GetExpectedCanonicalRequestForQueryParamSigningTest()
        {
            return String.Join('\n',
                "GET",
                "/",
                "Param1=value1&Param2=value2&X-Amz-Algorithm=AWS4-ECDSA-P256-SHA256&X-Amz-Credential=AKIDEXAMPLE%2F20150830%2Fservice%2Faws4_request&X-Amz-Date=20150830T123600Z&X-Amz-Region-Set=us-east-1&X-Amz-SignedHeaders=host",
                "host:example.amazonaws.com",
                "",
                "host",
                "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855");
        }

        [Fact]
        public void SignRequestViaQueryParamsWithSigv4a()
        {
            var signer = new CrtAWS4aSigner();

            var request = BuildQueryParamRequestToSign();
            var clientConfig = BuildSigningClientConfig("service");

            var result = signer.Presign4a(request, clientConfig, null, SigningTestCredentials, "service", SigningTestRegion);
            var signatureValue = result.Signature;

            var canonicalRequest = GetExpectedCanonicalRequestForQueryParamSigningTest();

            var config = BuildDefaultSigningConfig("service");
            config.SignatureType = AwsSignatureType.CANONICAL_REQUEST_VIA_QUERY_PARAMS;

            Assert.True(AwsSigner.VerifyV4aCanonicalSigning(canonicalRequest, config, signatureValue, SigningTestEccPubX, SigningTestEccPubY));
        }
        #endregion

        #region Chunked Signing
        internal IRequest BuildMockChunkedRequest()
        {
            var mock = new Mock<IRequest>();
            mock.SetupAllProperties();

            var headers = new Dictionary<string, string>
            {
                { "x-amz-storage-class", "REDUCED_REDUNDANCY" },
                { "Content-Encoding", "aws-chunked" },
                { "Content-Length", (Chunk1Size + Chunk2Size).ToString() }  // The SDK will adjust this and set x-amz-decoded-content-length as needed prior to CRT
            };

            mock.SetupGet(x => x.Headers).Returns(headers);
            mock.Setup(x => x.TrailingHeaders).Returns(new Dictionary<string, string>());
            mock.SetupGet(x => x.SubResources).Returns(new Dictionary<string, string>());

            var request = mock.Object;
            request.HttpMethod = "PUT";
            request.ResourcePath = "/examplebucket/chunkObject.txt";
            request.Endpoint = new Uri("https://s3.amazonaws.com/");
            request.UseChunkEncoding = true;
            request.Content = null;

            return request;
        }

        private MemoryStream CreateChunkStream(int streamLength)
        {
            return new MemoryStream(
                Enumerable.Range(0, streamLength)
                .Select(x => Convert.ToByte('a'))
                .ToArray());
        }

        internal string GetExpectedCanonicalRequestForChunkedSigningTest()
        {
            return string.Join('\n',
                            "PUT",
                            "/examplebucket/chunkObject.txt",
                            "",
                            "content-encoding:aws-chunked",
                            "content-length:" + ChunkedUploadWrapperStream.ComputeChunkedContentLength(Chunk1Size + Chunk2Size, ChunkedUploadWrapperStream.V4A_SIGNATURE_LENGTH).ToString(),
                            "host:s3.amazonaws.com",
                            "x-amz-content-sha256:STREAMING-AWS4-ECDSA-P256-SHA256-PAYLOAD",
                            "x-amz-date:20150830T123600Z",
                            "x-amz-decoded-content-length:" + (Chunk1Size + Chunk2Size).ToString(),
                            "x-amz-region-set:us-east-1",
                            "x-amz-storage-class:REDUCED_REDUNDANCY",
                            "",
                            "content-encoding;content-length;host;x-amz-content-sha256;x-amz-date;x-amz-decoded-content-length;x-amz-region-set;x-amz-storage-class",
                            "STREAMING-AWS4-ECDSA-P256-SHA256-PAYLOAD");
        }

        internal string GetExpectedCanonicalRequestForChunkedTrailersSigningTest()
        {
            var trailingHeaders = new Dictionary<string, string>
            {
                { "x-amz-foo", "bar" }
            };

            return string.Join('\n',
                            "PUT",
                            "/examplebucket/chunkObject.txt",
                            "",
                            "content-encoding:aws-chunked",
                            "content-length:" + ChunkedUploadWrapperStream.ComputeChunkedContentLength(Chunk1Size + Chunk2Size,
                                                    ChunkedUploadWrapperStream.V4A_SIGNATURE_LENGTH, 
                                                    trailingHeaders, 
                                                    CoreChecksumAlgorithm.NONE).ToString(),
                            "host:s3.amazonaws.com",
                            "x-amz-content-sha256:STREAMING-AWS4-ECDSA-P256-SHA256-PAYLOAD-TRAILER",
                            "x-amz-date:20150830T123600Z",
                            "x-amz-decoded-content-length:" + (Chunk1Size + Chunk2Size).ToString(),
                            "x-amz-region-set:us-east-1",
                            "x-amz-storage-class:REDUCED_REDUNDANCY",
                            "x-amz-trailer:x-amz-foo",
                            "",
                            "content-encoding;content-length;host;x-amz-content-sha256;x-amz-date;x-amz-decoded-content-length;x-amz-region-set;x-amz-storage-class;x-amz-trailer",
                            "STREAMING-AWS4-ECDSA-P256-SHA256-PAYLOAD-TRAILER");
        }

        private string BuildV4aChunkedStringToSignHelper(AWS4aSigningResult headerResult, string previousSignature, int chunkSize)
        {
            return ChunkedUploadWrapperStream.BuildChunkedStringToSign(
                "AWS4-ECDSA-P256-SHA256-PAYLOAD",
                headerResult.ISO8601DateTime,
                headerResult.Scope,
                previousSignature.TrimEnd('*'),
                chunkSize,
                CreateChunkStream(chunkSize).ToArray());
        }

        private string BuildV4aTrailerChunkHelper(AWS4aSigningResult headerResult, string previousSignature, IDictionary<string, string> trailingHeaders)
        {
            return string.Join('\n',
                    "AWS4-ECDSA-P256-SHA256-TRAILER",
                    headerResult.ISO8601DateTime,
                    headerResult.Scope,
                    previousSignature.TrimEnd('*'),
                    AWSSDKUtils.ToHex(AWS4Signer.ComputeHash("x-amz-foo:bar\n"), true));
        }

        /// <summary>
        ///  Tests that the SigV4a signature is valid for each chunk of a request,
        ///  by comparing against the signature of a handwritten canonical chunk.
        /// </summary>
        [Fact]
        public void TestChunkedRequest()
        {
            var signer = new CrtAWS4aSigner();

            var request = BuildMockChunkedRequest();
            var clientConfig = BuildSigningClientConfig(SigningTestService);

            var headerResult = signer.SignRequest(request, clientConfig, null, SigningTestCredentials);

            var config = BuildDefaultSigningConfig(SigningTestService);
            config.SignatureType = AwsSignatureType.CANONICAL_REQUEST_VIA_HEADERS;
            config.SignedBodyValue = AWS4Signer.V4aStreamingBodySha256;

            Assert.True(AwsSigner.VerifyV4aCanonicalSigning(GetExpectedCanonicalRequestForChunkedSigningTest(), 
                                                            config, headerResult.Signature, SigningTestEccPubX, SigningTestEccPubY));

            var chunk1Result = signer.SignChunk(CreateChunkStream(Chunk1Size), headerResult.Signature, headerResult);
            Assert.True(AwsSigner.VerifyV4aSignature(BuildV4aChunkedStringToSignHelper(headerResult, headerResult.Signature, Chunk1Size), 
                                                     Encoding.ASCII.GetBytes(chunk1Result), SigningTestEccPubX, SigningTestEccPubY));

            var chunk2Result = signer.SignChunk(CreateChunkStream(Chunk2Size), chunk1Result, headerResult);
            Assert.True(AwsSigner.VerifyV4aSignature(BuildV4aChunkedStringToSignHelper(headerResult, chunk1Result, Chunk2Size), 
                                                     Encoding.ASCII.GetBytes(chunk2Result), SigningTestEccPubX, SigningTestEccPubY));

            var chunk3Result = signer.SignChunk(null, chunk2Result, headerResult);
            Assert.True(AwsSigner.VerifyV4aSignature(BuildV4aChunkedStringToSignHelper(headerResult, chunk2Result, 0), 
                                                     Encoding.ASCII.GetBytes(chunk3Result), SigningTestEccPubX, SigningTestEccPubY));
        }

        /// <summary>
        ///  Tests that the SigV4a signature is valid for each chunk of a request with 
        ///  trailing headers, by comparing against the signature of a handwritten
        ///  canonical chunk.
        /// </summary>
        [Fact]
        public void TestChunkedRequestWithTrailingHeaders()
        {
            var signer = new CrtAWS4aSigner();

            var request = BuildMockChunkedRequest();
            request.TrailingHeaders.Add("x-amz-foo", "bar");

            var clientConfig = BuildSigningClientConfig(SigningTestService);

            var headerResult = signer.SignRequest(request, clientConfig, null, SigningTestCredentials);

            var config = BuildDefaultSigningConfig(SigningTestService);

            config.SignatureType = AwsSignatureType.CANONICAL_REQUEST_VIA_HEADERS;
            config.SignedBodyValue = AWS4Signer.V4aStreamingBodySha256WithTrailer;

            Assert.True(AwsSigner.VerifyV4aCanonicalSigning(GetExpectedCanonicalRequestForChunkedTrailersSigningTest(),
                                                            config, headerResult.Signature, SigningTestEccPubX, SigningTestEccPubY));

            var chunk1Result = signer.SignChunk(CreateChunkStream(Chunk1Size), headerResult.Signature, headerResult);
            Assert.True(AwsSigner.VerifyV4aSignature(BuildV4aChunkedStringToSignHelper(headerResult, headerResult.Signature, Chunk1Size),
                                                     Encoding.ASCII.GetBytes(chunk1Result), SigningTestEccPubX, SigningTestEccPubY));

            var chunk2Result = signer.SignChunk(CreateChunkStream(Chunk2Size), chunk1Result, headerResult);
            Assert.True(AwsSigner.VerifyV4aSignature(BuildV4aChunkedStringToSignHelper(headerResult, chunk1Result, Chunk2Size),
                                                     Encoding.ASCII.GetBytes(chunk2Result), SigningTestEccPubX, SigningTestEccPubY));

            var chunk3Result = signer.SignChunk(null, chunk2Result, headerResult);
            Assert.True(AwsSigner.VerifyV4aSignature(BuildV4aChunkedStringToSignHelper(headerResult, chunk2Result, 0),
                                                     Encoding.ASCII.GetBytes(chunk3Result), SigningTestEccPubX, SigningTestEccPubY));

            var trailerChunkResult = signer.SignTrailingHeaderChunk(request.TrailingHeaders, chunk3Result, headerResult);
            Assert.True(AwsSigner.VerifyV4aSignature(BuildV4aTrailerChunkHelper(headerResult, chunk3Result, request.TrailingHeaders), 
                                                     Encoding.ASCII.GetBytes(trailerChunkResult), SigningTestEccPubX, SigningTestEccPubY));
        }
        #endregion
    }
}
