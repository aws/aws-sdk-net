/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using Amazon.S3.Internal;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.S3.Util;
using Map = System.Collections.Generic.Dictionary<Amazon.S3.S3QueryParameter, string>;

namespace Amazon.S3
{
    public partial class AmazonS3Client : AmazonServiceClient, IAmazonS3
    {
        #region GetPreSignedURL

        /// <summary>
        /// Create a signed URL allowing access to a resource that would 
        /// usually require authentication.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When using query string authentication you create a query,
        /// specify an expiration time for the query, sign it with your
        /// signature, place the data in an HTTP request, and distribute
        /// the request to a user or embed the request in a web page.
        /// </para>
        /// <para>
        /// A PreSigned URL can be generated for GET, PUT, DELETE and HEAD
        /// operations on your bucketName, keys, and versions.
        /// </para>
        /// </remarks>
        /// <param name="request">The GetPreSignedUrlRequest that defines the
        /// parameters of the operation.</param>
        /// <returns>A string that is the signed http request.</returns>
        /// <exception cref="T:System.ArgumentException" />
        /// <exception cref="T:System.ArgumentNullException" />
        public string GetPreSignedURL(GetPreSignedUrlRequest request)
        {
            if (Credentials == null)
                throw new AmazonS3Exception("Credentials must be specified, cannot call method anonymously");

            if (request == null)
                throw new ArgumentNullException("request", "The PreSignedUrlRequest specified is null!");

            if (!request.IsSetExpires())
                throw new InvalidOperationException("The Expires specified is null!");

            var aws4Signing = AWSConfigs.S3Config.UseSignatureVersion4;
            var region = AWS4Signer.DetermineSigningRegion(Config, "s3", alternateEndpoint: null, request: null);
            if (aws4Signing && string.IsNullOrEmpty(region))
                throw new InvalidOperationException("To use AWS4 signing, a region must be specified in the client configuration using the AuthenticationRegion or Region properties, or be determinable from the service URL.");

            RegionEndpoint endpoint = RegionEndpoint.GetBySystemName(region);
            if (endpoint.GetEndpointForService("s3").SignatureVersionOverride == "4")
                aws4Signing = true;

            var immutableCredentials = Credentials.GetCredentials();
            var irequest = Marshall(request, immutableCredentials.AccessKey, immutableCredentials.Token, aws4Signing);

            irequest.Endpoint = EndpointResolver.DetermineEndpoint(this.Config, irequest);

            var context = new Amazon.Runtime.Internal.ExecutionContext(new Amazon.Runtime.Internal.RequestContext(true) { Request = irequest, ClientConfig = this.Config }, null);
            AmazonS3PostMarshallHandler handler = new AmazonS3PostMarshallHandler();
            handler.ProcessRequestHandlers(context);

            var metrics = new RequestMetrics();

            string authorization;
            if (aws4Signing)
            {
                var aws4Signer = new AWS4PreSignedUrlSigner();
                var signingResult = aws4Signer.SignRequest(irequest,
                                                           this.Config,
                                                           metrics,
                                                           immutableCredentials.AccessKey,
                                                           immutableCredentials.SecretKey);
                authorization = "&" + signingResult.ForQueryParameters;
            }
            else
            {
                this.Signer.Sign(irequest, this.Config, metrics, immutableCredentials.AccessKey, immutableCredentials.SecretKey);
                authorization = irequest.Headers[HeaderKeys.AuthorizationHeader];
                authorization = authorization.Substring(authorization.IndexOf(":", StringComparison.Ordinal) + 1);
                authorization = "&Signature=" + AmazonS3Util.UrlEncode(authorization, false);
            }

            Uri url = AmazonServiceClient.ComposeUrl(irequest);
            string result = url.AbsoluteUri + authorization;

            Protocol protocol = DetermineProtocol();
            if (request.Protocol != protocol)
            {
                switch (protocol)
                {
                    case Protocol.HTTP:
                        result = result.Replace("http://", "https://");
                        break;
                    case Protocol.HTTPS:
                        result = result.Replace("https://", "http://");
                        break;
                }
            }
            return result;
        }

        /// <summary>
        /// Marshalls the parameters for a presigned url for a preferred signing protocol.
        /// </summary>
        /// <param name="getPreSignedUrlRequest"></param>
        /// <param name="accessKey"></param>
        /// <param name="token"></param>
        /// <param name="aws4Signing">
        /// True if AWS4 signing will be used; if the expiry period in the request exceeds the
        /// maximum allowed for AWS4 (one week), an ArgumentException is thrown.
        /// </param>
        /// <returns></returns>
        private static IRequest Marshall(GetPreSignedUrlRequest getPreSignedUrlRequest, 
                                         string accessKey, 
                                         string token, 
                                         bool aws4Signing)
        {
            IRequest request = new DefaultRequest(getPreSignedUrlRequest, "AmazonS3");

            request.HttpMethod = getPreSignedUrlRequest.Verb.ToString();

            var headers = getPreSignedUrlRequest.Headers;
            foreach (var key in headers.Keys)
                request.Headers[key] = headers[key];

            AmazonS3Util.SetMetadataHeaders(request, getPreSignedUrlRequest.Metadata);

            if (!string.IsNullOrEmpty(token))
                request.Headers[HeaderKeys.XAmzSecurityTokenHeader] = token;

            if (getPreSignedUrlRequest.ServerSideEncryptionMethod != null && getPreSignedUrlRequest.ServerSideEncryptionMethod != ServerSideEncryptionMethod.None)
                request.Headers.Add(HeaderKeys.XAmzServerSideEncryptionHeader, S3Transforms.ToStringValue(getPreSignedUrlRequest.ServerSideEncryptionMethod));
            if (getPreSignedUrlRequest.IsSetServerSideEncryptionCustomerMethod())
                request.Headers.Add(HeaderKeys.XAmzSSECustomerAlgorithmHeader, getPreSignedUrlRequest.ServerSideEncryptionCustomerMethod);
            if (getPreSignedUrlRequest.IsSetServerSideEncryptionKeyManagementServiceKeyId())
                request.Headers.Add(HeaderKeys.XAmzServerSideEncryptionAwsKmsKeyIdHeader, getPreSignedUrlRequest.ServerSideEncryptionKeyManagementServiceKeyId);

            var queryParameters = request.Parameters;

            var uriResourcePath = new StringBuilder("/");
            if (!string.IsNullOrEmpty(getPreSignedUrlRequest.BucketName))
                uriResourcePath.Append(S3Transforms.ToStringValue(getPreSignedUrlRequest.BucketName));
            if (!string.IsNullOrEmpty(getPreSignedUrlRequest.Key))
            {
                if (uriResourcePath.Length > 1)
                    uriResourcePath.Append("/");
                uriResourcePath.Append(S3Transforms.ToStringValue(getPreSignedUrlRequest.Key));
            }

            var baselineTime = aws4Signing ? AWSSDKUtils.CorrectedUtcNow : new DateTime(1970, 1, 1);
            var expires = Convert.ToInt64((getPreSignedUrlRequest.Expires.ToUniversalTime() - baselineTime).TotalSeconds);

            if (aws4Signing && expires > AWS4PreSignedUrlSigner.MaxAWS4PreSignedUrlExpiry)
            {
                var msg = string.Format(CultureInfo.InvariantCulture, "The maximum expiry period for a presigned url using AWS4 signing is {0} seconds",
                                        AWS4PreSignedUrlSigner.MaxAWS4PreSignedUrlExpiry);
                throw new ArgumentException(msg);
            }

            queryParameters.Add(aws4Signing ? "X-Amz-Expires" : "Expires", expires.ToString(CultureInfo.InvariantCulture));

            if (!string.IsNullOrEmpty(token))
                queryParameters.Add("x-amz-security-token", token);
            if (!aws4Signing)
                queryParameters.Add("AWSAccessKeyId", accessKey);
            if (getPreSignedUrlRequest.IsSetVersionId())
                request.AddSubResource("versionId", S3Transforms.ToStringValue(getPreSignedUrlRequest.VersionId));

            var responseHeaderOverrides = getPreSignedUrlRequest.ResponseHeaderOverrides;
            if (!string.IsNullOrEmpty(responseHeaderOverrides.CacheControl))
                queryParameters.Add("response-cache-control", responseHeaderOverrides.CacheControl);
            if (!string.IsNullOrEmpty(responseHeaderOverrides.ContentType))
                queryParameters.Add("response-content-type", responseHeaderOverrides.ContentType);
            if (!string.IsNullOrEmpty(responseHeaderOverrides.ContentLanguage))
                queryParameters.Add("response-content-language", responseHeaderOverrides.ContentLanguage);
            if (!string.IsNullOrEmpty(responseHeaderOverrides.Expires))
                queryParameters.Add("response-expires", responseHeaderOverrides.Expires);
            if (!string.IsNullOrEmpty(responseHeaderOverrides.ContentDisposition))
                queryParameters.Add("response-content-disposition", responseHeaderOverrides.ContentDisposition);
            if (!string.IsNullOrEmpty(responseHeaderOverrides.ContentEncoding))
                queryParameters.Add("response-content-encoding", responseHeaderOverrides.ContentEncoding);

            request.ResourcePath = uriResourcePath.ToString();
            request.UseQueryString = true;

            return request;
        }

        #endregion    

        private Protocol DetermineProtocol()
        {
            string serviceUrl = Config.DetermineServiceURL();
            Protocol protocol = serviceUrl.StartsWith("https", StringComparison.OrdinalIgnoreCase) ? Protocol.HTTPS : Protocol.HTTP;
            return protocol;
        }

        internal void ConfigureProxy(HttpWebRequest httpRequest)
        {
#if BCL
            if (!string.IsNullOrEmpty(Config.ProxyHost) && Config.ProxyPort != -1)
            {
                WebProxy proxy = new WebProxy(Config.ProxyHost, Config.ProxyPort);
                httpRequest.Proxy = proxy;
            }

            if (httpRequest.Proxy != null && Config.ProxyCredentials != null)
            {
                httpRequest.Proxy.Credentials = Config.ProxyCredentials;
            }
#endif
        }

        //protected override void ProcessExceptionHandlers(Exception exception, IRequest request)
        //{
        //    base.ProcessExceptionHandlers(exception, request);

        //    CleanupRequest(request);
        //}

        internal static void CleanupRequest(IRequest request)
        {
            var putObjectRequest = request.OriginalRequest as PutObjectRequest;
            if (putObjectRequest != null)
            {
                if (putObjectRequest.InputStream != null
                    && (!string.IsNullOrEmpty(putObjectRequest.FilePath) || putObjectRequest.AutoCloseStream))
                {
                    putObjectRequest.InputStream.Dispose();
                }

                // Set the input stream to null since it was created during the request to represent the filepath or content body
                if (!string.IsNullOrEmpty(putObjectRequest.FilePath) || !string.IsNullOrEmpty(putObjectRequest.ContentBody)
#if WIN_RT || WINDOWS_PHONE
                    || putObjectRequest.StorageFile != null
#endif
)
                {
                    putObjectRequest.InputStream = null;
                }
            }

            var uploadPartRequest = request.OriginalRequest as UploadPartRequest;
            if (uploadPartRequest != null)
            {
                // FilePath was set, so we created the underlying stream, so we must close it
                if (uploadPartRequest.IsSetFilePath() && uploadPartRequest.InputStream != null)
                {
                    uploadPartRequest.InputStream.Dispose();
                }

                if (uploadPartRequest.IsSetFilePath()
#if WIN_RT || WINDOWS_PHONE
                    || uploadPartRequest.StorageFile != null
#endif
)
                    uploadPartRequest.InputStream = null;
            }
        }
    }
}

