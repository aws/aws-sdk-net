﻿/*
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
using System.Net;
using System.Text;

#if AWS_ASYNC_API
using System.Threading.Tasks;
#endif

using Amazon.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.SharedInterfaces;
using Amazon.Util;
using Amazon.S3.Internal;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.S3.Util;
using Amazon.Util.Internal;
using Amazon.S3.Internal.S3Express;
using System.Collections;
using Amazon.Runtime.Endpoints;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.Design;
using System.Threading;

namespace Amazon.S3
{
    public partial class AmazonS3Client : AmazonServiceClient, IAmazonS3
    {
        /// <summary>
        /// Specialize the initialize of the client.
        /// </summary>
        protected override void Initialize()
        {
            var clientConfig = this.Config as AmazonS3Config;
            if (clientConfig != null)
            {
                clientConfig.ResignRetries = true;

                if (clientConfig.S3ExpressCredentialProvider == null)
                    clientConfig.S3ExpressCredentialProvider = new DefaultS3ExpressCredentialProvider(this);
            }
            base.Initialize();
        }

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
        /// <param name="useSigV2Fallback">determines if signing will fall back to SigV2 if the
        /// signing region is us-east-1</param>
        /// <returns>A string that is the signed http request.</returns>
        /// <exception cref="T:System.ArgumentException" />
        /// <exception cref="T:System.ArgumentNullException" />
        internal string GetPreSignedURLInternal(GetPreSignedUrlRequest request, bool useSigV2Fallback = true)
        {
            if (DefaultAWSCredentials == null)
                throw new AmazonS3Exception("Credentials must be specified, cannot call method anonymously");

            if (request == null)
                throw new ArgumentNullException("request", "The PreSignedUrlRequest specified is null!");

            if (!request.IsSetExpires())
                throw new InvalidOperationException("The Expires specified is null!");
            Arn arn = null;
            var signatureVersionToUse = DetermineSignatureVersionToUse(request, ref arn, useSigV2Fallback);
            var immutableCredentials = DefaultAWSCredentials.GetCredentials();
            var irequest = Marshall(this.Config, request, immutableCredentials.AccessKey, immutableCredentials.Token, signatureVersionToUse);

            var context = new Amazon.Runtime.Internal.ExecutionContext(new Amazon.Runtime.Internal.RequestContext(true, new NullSigner()) { Request = irequest, ClientConfig = this.Config }, null);
            
            new AmazonS3EndpointResolver().ProcessRequestHandlers(context);
            var expressConfig = this.Config as AmazonS3Config;
            if (context.RequestContext.Request.IsDirectoryBucket() && !expressConfig.DisableS3ExpressSessionAuth)
            {
                ConvertToS3Express(immutableCredentials, context, ref signatureVersionToUse, expressConfig);
                var s3ExpressCredentials = expressConfig.S3ExpressCredentialProvider.ResolveSessionCredentials(request.BucketName);

                // Only use SessionCredentials if it was resolved correctly.
                // Otherwise skip overriding ImmutableCredentials and use the regular credentials.
                if (s3ExpressCredentials != null) 
                {
                    irequest.Parameters.Add(HeaderKeys.XAmzS3ExpressSessionTokenQueryParam, s3ExpressCredentials.SessionToken);
                    immutableCredentials = new ImmutableCredentials(s3ExpressCredentials.AccessKeyId, s3ExpressCredentials.SecretAccessKey, null);
                } 
            }
            var metrics = new RequestMetrics();
            var signingResult = ReturnSigningResult(signatureVersionToUse, irequest, Config, metrics, immutableCredentials, arn);
            return signingResult.Result;
        }


#if AWS_ASYNC_API
        /// <summary>
        /// Asynchronously create a signed URL allowing access to a resource that would 
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
        /// <param name="useSigV2Fallback">determines if signing will fall back to SigV2 if the
        /// signing region is us-east-1</param>
        /// <returns>A string that is the signed http request.</returns>
        /// <exception cref="T:System.ArgumentException" />
        /// <exception cref="T:System.ArgumentNullException" />
        [SuppressMessage("AWSSDKRules", "CR1004")]
        internal async Task<string> GetPreSignedURLInternalAsync(GetPreSignedUrlRequest request, bool useSigV2Fallback = true)
        {
            if (DefaultAWSCredentials == null)
                throw new AmazonS3Exception("Credentials must be specified, cannot call method anonymously");

            if (request == null)
                throw new ArgumentNullException("request", "The PreSignedUrlRequest specified is null!");

            if (!request.IsSetExpires())
                throw new InvalidOperationException("The Expires specified is null!");
            Arn arn = null;
            var signatureVersionToUse = DetermineSignatureVersionToUse(request, ref arn, useSigV2Fallback);
            var immutableCredentials = await DefaultAWSCredentials.GetCredentialsAsync().ConfigureAwait(false);
            var irequest = Marshall(this.Config, request, immutableCredentials.AccessKey, immutableCredentials.Token, signatureVersionToUse);


            var context = new Amazon.Runtime.Internal.ExecutionContext(new Amazon.Runtime.Internal.RequestContext(true, new NullSigner()) { Request = irequest, ClientConfig = this.Config }, null);
            new AmazonS3EndpointResolver().ProcessRequestHandlers(context);
            var expressConfig = this.Config as AmazonS3Config;
            if (context.RequestContext.Request.IsDirectoryBucket() && !expressConfig.DisableS3ExpressSessionAuth)
            {
                ConvertToS3Express(immutableCredentials, context, ref signatureVersionToUse, expressConfig);
                var s3ExpressCredentials = await expressConfig.S3ExpressCredentialProvider.ResolveSessionCredentialsAsync(request.BucketName).ConfigureAwait(false);

                irequest.Parameters.Add(HeaderKeys.XAmzS3ExpressSessionTokenQueryParam, s3ExpressCredentials.SessionToken);
                immutableCredentials = new ImmutableCredentials(s3ExpressCredentials.AccessKeyId, s3ExpressCredentials.SecretAccessKey, null);
            }
            var metrics = new RequestMetrics();
            var signingResult = ReturnSigningResult(signatureVersionToUse, irequest, Config, metrics, immutableCredentials, arn);
            return signingResult.Result;
        }
#endif
        /// <summary>
        /// Marshalls the parameters for a presigned url for a preferred signing protocol.
        /// </summary>
        /// <param name="config">service client configuration</param>
        /// <param name="getPreSignedUrlRequest"></param>
        /// <param name="accessKey"></param>
        /// <param name="token"></param>
        /// <param name="signatureVersion">Signature version to use.
        /// If AWS4 signing will be used and if the expiry period in the request exceeds the
        /// maximum allowed for AWS4 (one week), an ArgumentException is thrown.
        /// </param>
        /// <returns>Internal request</returns>
        private static IRequest Marshall(IClientConfig config, 
                                         GetPreSignedUrlRequest getPreSignedUrlRequest,
                                         string accessKey,
                                         string token,
                                         SignatureVersion signatureVersion)
        {
            IRequest request = new DefaultRequest(getPreSignedUrlRequest, "AmazonS3");
            request.HttpMethod = getPreSignedUrlRequest.Verb.ToString();

            var headers = getPreSignedUrlRequest.Headers;
            foreach (var key in headers.Keys)
                request.Headers[key] = headers[key];

            AmazonS3Util.SetMetadataHeaders(request, getPreSignedUrlRequest.Metadata);

            if (getPreSignedUrlRequest.ServerSideEncryptionMethod != null && getPreSignedUrlRequest.ServerSideEncryptionMethod != ServerSideEncryptionMethod.None)
                request.Headers.Add(HeaderKeys.XAmzServerSideEncryptionHeader, S3Transforms.ToStringValue(getPreSignedUrlRequest.ServerSideEncryptionMethod));
            if (getPreSignedUrlRequest.IsSetServerSideEncryptionCustomerMethod())
                request.Headers.Add(HeaderKeys.XAmzSSECustomerAlgorithmHeader, getPreSignedUrlRequest.ServerSideEncryptionCustomerMethod);
            if (getPreSignedUrlRequest.IsSetServerSideEncryptionKeyManagementServiceKeyId())
                request.Headers.Add(HeaderKeys.XAmzServerSideEncryptionAwsKmsKeyIdHeader, getPreSignedUrlRequest.ServerSideEncryptionKeyManagementServiceKeyId);

            if (getPreSignedUrlRequest.IsSetRequestPayer() && getPreSignedUrlRequest.RequestPayer == RequestPayer.Requester)
                request.Parameters.Add("x-amz-request-payer", RequestPayer.Requester.Value);

            var queryParameters = request.Parameters;

            var uriResourcePath = new StringBuilder("");
            if (!string.IsNullOrEmpty(getPreSignedUrlRequest.Key))
            {
                uriResourcePath.Append("/{Key+}");
                request.AddPathResource("{Key+}", S3Transforms.ToStringValue(getPreSignedUrlRequest.Key));
            }

            var expires = GetSecondsUntilExpiration(config, getPreSignedUrlRequest, signatureVersion);

            if ((signatureVersion == SignatureVersion.SigV4 || signatureVersion == SignatureVersion.SigV4a)
                    && expires > AWS4PreSignedUrlSigner.MaxAWS4PreSignedUrlExpiry)
            {
                var msg = string.Format(CultureInfo.InvariantCulture, "The maximum expiry period for a presigned url using AWS4 signing is {0} seconds",
                                        AWS4PreSignedUrlSigner.MaxAWS4PreSignedUrlExpiry);
                throw new ArgumentException(msg);
            }

            if (signatureVersion == SignatureVersion.SigV2)
            {
                queryParameters.Add("Expires", expires.ToString(CultureInfo.InvariantCulture));
                queryParameters.Add("AWSAccessKeyId", accessKey);
                if (!string.IsNullOrEmpty(token))
                    queryParameters.Add("x-amz-security-token", token);
            }
            else // SigV4 or SigV4a
            {
                queryParameters.Add(HeaderKeys.XAmzExpires, expires.ToString(CultureInfo.InvariantCulture));
                if (!string.IsNullOrEmpty(token))
                    queryParameters.Add("X-Amz-Security-Token", token);
            }

            if (getPreSignedUrlRequest.IsSetVersionId())
                request.AddSubResource("versionId", S3Transforms.ToStringValue(getPreSignedUrlRequest.VersionId));
            if (getPreSignedUrlRequest.IsSetUploadId())
                request.AddSubResource("uploadId", S3Transforms.ToStringValue(getPreSignedUrlRequest.UploadId));
            if (getPreSignedUrlRequest.IsSetPartNumber())
                request.AddSubResource("partNumber", S3Transforms.ToStringValue(getPreSignedUrlRequest.PartNumber.Value));

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

            // Add custom parameters to be included and signed
            foreach (string k in getPreSignedUrlRequest.Parameters.Keys)
                queryParameters.Add(k, getPreSignedUrlRequest.Parameters[k]);

            request.ResourcePath = uriResourcePath.ToString();
            request.UseQueryString = true;

            return request;
        }
        #region helper methods


        [SuppressMessage("AWSSDKRules", "CR1004")]
        private SignatureVersion DetermineSignatureVersionToUse(GetPreSignedUrlRequest request, ref Arn arn, bool useSigV2Fallback)
        {
            var signatureVersionToUse = AWSConfigsS3.UseSignatureVersion4 ? SignatureVersion.SigV4 : SignatureVersion.SigV2;

            string accessPoint;
            if (Arn.TryParse(request.BucketName, out arn) &&
                (arn.TryParseAccessPoint(out accessPoint) || arn.IsOutpostArn()))
            {
                signatureVersionToUse = SignatureVersion.SigV4;

                if (arn.IsMRAPArn())
                {
                    signatureVersionToUse = SignatureVersion.SigV4a;
                }
            }
            else
            {
                var region = AWS4Signer.DetermineSigningRegion(Config, "s3", alternateEndpoint: null, request: null);
                if (signatureVersionToUse == SignatureVersion.SigV4 && string.IsNullOrEmpty(region))
                    throw new InvalidOperationException("To use AWS4 signing, a region must be specified in the client configuration using the AuthenticationRegion or Region properties, or be determinable from the service URL.");

#pragma warning disable CS0612,CS0618
                RegionEndpoint endpoint = RegionEndpoint.GetBySystemName(region);
                var s3SignatureVersionOverride = endpoint.GetEndpointForService("s3", Config.ToGetEndpointForServiceOptions()).SignatureVersionOverride;
                if (s3SignatureVersionOverride == "4" || s3SignatureVersionOverride == null)
                {
                    signatureVersionToUse = SignatureVersion.SigV4;
                }
#pragma warning restore CS0612,CS0618

                var fallbackToSigV2 = useSigV2Fallback && !AWSConfigsS3.UseSigV4SetExplicitly;
                if (endpoint?.SystemName == RegionEndpoint.USEast1.SystemName && fallbackToSigV2)
                {
                    signatureVersionToUse = SignatureVersion.SigV2;
                }

                // If the expiration is longer than SigV4 will allow then automatically use SigV2 instead.
                // But only if the region we're signing for allows SigV2.
                if (signatureVersionToUse == SignatureVersion.SigV4)
                {
                    var secondsUntilExpiration = GetSecondsUntilExpiration(this.Config, request, signatureVersionToUse);

                    if (secondsUntilExpiration > AWS4PreSignedUrlSigner.MaxAWS4PreSignedUrlExpiry &&
                        s3SignatureVersionOverride == "2")
                    {
                        signatureVersionToUse = SignatureVersion.SigV2;
                    }
                }
            }
            return signatureVersionToUse;
        }

        //Since this method will always be called in the context of a directory (S3Express) bucket, we must force SiV4 if the expiration date is under 7 days.
        private static void ConvertToS3Express(ImmutableCredentials immutableCredentials, Amazon.Runtime.Internal.ExecutionContext context, ref SignatureVersion signatureVersion, AmazonS3Config config)
        {
            var irequest = context.RequestContext.Request;
            var request = irequest.OriginalRequest as GetPreSignedUrlRequest;
            //we pass in SigV4 because we want to see what the seconds until Expiration was when signature version was SigV4, since it doesn't matter for SigV2.
            var secondsUntilExpiration = GetSecondsUntilExpiration(config, request, SignatureVersion.SigV4);

            //If DetermineSignatureVersionToUse forced SigV2 due to a long expiration, we need to throw an exception because S3Express needs to use SigV4
            if (signatureVersion == SignatureVersion.SigV2 && secondsUntilExpiration > AWS4PreSignedUrlSigner.MaxAWS4PreSignedUrlExpiry)
            {
                throw new AmazonS3Exception("S3 Express only works with SIGV4 which does not allow expiration greater than 7 days. Please create a presignedUrl that" +
                    "is shorter than 7 days.");
            }
            //us-east-1 holds no special value as the regional endpoint for S3Express. If we're in a S3Express request,
            //and the user did not explicitly set UseSignatureVersion4 to false, then convert back to sigV4
            if (signatureVersion == SignatureVersion.SigV2 && !AWSConfigsS3.UseSignatureVersion4)
            {
                irequest.Parameters.Remove("Expires");
                irequest.Parameters.Remove("AWSAccessKeyId");
                var expires = GetSecondsUntilExpiration(config, irequest.OriginalRequest as GetPreSignedUrlRequest, SignatureVersion.SigV4);
                irequest.Parameters.Add(HeaderKeys.XAmzExpires, expires.ToString(CultureInfo.InvariantCulture));
                if (!String.IsNullOrEmpty(immutableCredentials.Token))
                    irequest.Parameters.Remove(HeaderKeys.XAmzSecurityTokenHeader);
            }
            
            //for SigV4 x-amz-security-token casing is different and since we will replace this header with the S3Express Session Token we must remove it.
            if (!String.IsNullOrEmpty(immutableCredentials.Token) && signatureVersion == SignatureVersion.SigV4)
            {
                irequest.Parameters.Remove("X-Amz-Security-Token");
            }
            signatureVersion = SignatureVersion.SigV4;
        }

        private static SigningResult ReturnSigningResult(SignatureVersion signatureVersionToUse, IRequest iRequest,IClientConfig config, RequestMetrics metrics, ImmutableCredentials immutableCredentials, Arn arn)
        {
            SigningResult signingResult = new SigningResult();
            switch (signatureVersionToUse)
            {
                case SignatureVersion.SigV4a:
                    var aws4aSigner = new AWS4aSignerCRTWrapper();

                    var signingResult4a = aws4aSigner.Presign4a(iRequest,
                                                            config,
                                                            metrics,
                                                            immutableCredentials,
                                                            "s3",
                                                            arn.IsMRAPArn() ? "*" : "");
                    signingResult.Result = signingResult4a.PresignedUri;
                    break;
                case SignatureVersion.SigV4:
                    var aws4Signer = new AWS4PreSignedUrlSigner();
                    var signingResult4 = aws4Signer.SignRequest(iRequest,
                                                           config,
                                                           metrics,
                                                           immutableCredentials.AccessKey,
                                                           immutableCredentials.SecretKey);
                    signingResult.Authorization = "&" + signingResult4.ForQueryParameters;
                    signingResult.Result = ComposeUrl(iRequest).AbsoluteUri + signingResult.Authorization;
                    break;
                default: // SigV2
                    Amazon.S3.Internal.S3Signer.SignRequest(iRequest, metrics, immutableCredentials.AccessKey, immutableCredentials.SecretKey);
                    signingResult.Authorization = iRequest.Headers[HeaderKeys.AuthorizationHeader];
                    signingResult.Authorization = signingResult.Authorization.Substring(signingResult.Authorization.IndexOf(":", StringComparison.Ordinal) + 1);
                    signingResult.Authorization = "&Signature=" + AmazonS3Util.UrlEncode(signingResult.Authorization, false);
                    signingResult.Result = ComposeUrl(iRequest).AbsoluteUri + signingResult.Authorization;
                    break;
            }

            var parameters = new ServiceOperationEndpointParameters(iRequest.OriginalRequest);
            var endpoint = config.DetermineServiceOperationEndpoint(parameters);
            string serviceUrl = endpoint.URL;

            Protocol protocol = serviceUrl.StartsWith("https", StringComparison.OrdinalIgnoreCase) ? Protocol.HTTPS : Protocol.HTTP;
            var request = iRequest.OriginalRequest as GetPreSignedUrlRequest;
            if (request.Protocol != protocol)
            {
                switch (protocol)
                {
                    case Protocol.HTTP:
                        signingResult.Result = signingResult.Result.Replace("http://", "https://");
                        break;
                    case Protocol.HTTPS:
                        signingResult.Result = signingResult.Result.Replace("https://", "http://");
                        break;
                }
            }
            return signingResult;
        }
        private class SigningResult
        {
            public string Authorization { get; set; }
            public string Result { get; set; }
        }
        private static long GetSecondsUntilExpiration(IClientConfig config, GetPreSignedUrlRequest request, SignatureVersion signatureVersion)
        {
            DateTime baselineTime;
            if (signatureVersion == SignatureVersion.SigV2)
            {
                baselineTime = new DateTime(1970, 1, 1);
            }
            else // SigV4 or SigV4a
            {
                var parameters = new ServiceOperationEndpointParameters(request);
                var endpoint = config.DetermineServiceOperationEndpoint(parameters);
                baselineTime = CorrectClockSkew.GetCorrectedUtcNowForEndpoint(endpoint.URL);
            }
            return Convert.ToInt64((request.Expires.GetValueOrDefault().ToUniversalTime() - baselineTime).TotalSeconds);
        }
        internal static void CleanupRequest(AmazonWebServiceRequest request)
        {
            var putObjectRequest = request as PutObjectRequest;
            if (putObjectRequest != null)
            {
                if (putObjectRequest.InputStream != null
                    && (!string.IsNullOrEmpty(putObjectRequest.FilePath) || putObjectRequest.AutoCloseStream))
                {
                    putObjectRequest.InputStream.Dispose();
                }

                // Set the input stream to null since it was created during the request to represent the filepath or content body
                if (!string.IsNullOrEmpty(putObjectRequest.FilePath) || !string.IsNullOrEmpty(putObjectRequest.ContentBody))
                {
                    putObjectRequest.InputStream = null;
                }
            }

            var uploadPartRequest = request as UploadPartRequest;
            if (uploadPartRequest != null)
            {
                // FilePath was set, so we created the underlying stream, so we must close it
                if (uploadPartRequest.IsSetFilePath() && uploadPartRequest.InputStream != null)
                {
                    uploadPartRequest.InputStream.Dispose();
                }

                if (uploadPartRequest.IsSetFilePath())
                    uploadPartRequest.InputStream = null;
            }
        }
        #endregion
        internal void ConfigureProxy(HttpWebRequest httpRequest)
        {
#if BCL
            if (!string.IsNullOrEmpty(Config.ProxyHost) && Config.ProxyPort != -1)
            {
                WebProxy proxy = new WebProxy(Config.ProxyHost, Config.ProxyPort);
                httpRequest.Proxy = proxy;
            }
#elif NETSTANDARD
            httpRequest.Proxy = Config.GetWebProxy();
#endif
            if (httpRequest.Proxy != null && Config.ProxyCredentials != null)
            {
                httpRequest.Proxy.Credentials = Config.ProxyCredentials;
            }
            if (httpRequest.Proxy == null && !NoProxyFilter.Instance.Match(httpRequest.RequestUri))
            {
                if (httpRequest.RequestUri.Scheme == Uri.UriSchemeHttp)
                {
                    httpRequest.Proxy = Config.GetHttpProxy();
                }
                else if (httpRequest.RequestUri.Scheme == Uri.UriSchemeHttps)
                {
                    httpRequest.Proxy = Config.GetHttpsProxy();
                }
            }
        }


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
            return GetPreSignedURLInternal(request);
        }
#if AWS_ASYNC_API
        /// <summary>
        /// Asynchronously create a signed URL allowing access to a resource that would 
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
        public async Task<string> GetPreSignedURLAsync(GetPreSignedUrlRequest request)
        {
            return await GetPreSignedURLInternalAsync(request).ConfigureAwait(false);
            
        }

#endif
#endregion

        #region ICoreAmazonS3 Implementation

        string ICoreAmazonS3.GeneratePreSignedURL(string bucketName, string objectKey, DateTime expiration, IDictionary<string, object> additionalProperties)
        {
            var request = new GetPreSignedUrlRequest
            {
                BucketName = bucketName,
                Key = objectKey,
                Expires = expiration
            };
            InternalSDKUtils.ApplyValues(request, additionalProperties);


            return this.GetPreSignedURL(request);
        }

        #endregion
        #region  GetACL
        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// This implementation of the <c>GET</c> action uses the <c>acl</c> subresource to return
        /// the access control list (ACL) of a bucket. To use <c>GET</c> to return the ACL of
        /// the bucket, you must have the <c>READ_ACP</c> access to the bucket. If <c>READ_ACP</c>
        /// permission is granted to the anonymous user, you can return the ACL of the bucket
        /// without using an authorization header.
        /// </para>
        ///  
        /// <para>
        /// When you use this API operation with an access point, provide the alias of the access
        /// point in place of the bucket name.
        /// </para>
        ///  
        /// <para>
        /// When you use this API operation with an Object Lambda access point, provide the alias
        /// of the Object Lambda access point in place of the bucket name. If the Object Lambda
        /// access point alias in a request is not valid, the error code <c>InvalidAccessPointAliasError</c>
        /// is returned. For more information about <c>InvalidAccessPointAliasError</c>, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#ErrorCodeList">List
        /// of Error Codes</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If your bucket uses the bucket owner enforced setting for S3 Object Ownership, requests
        /// to read ACLs are still supported and return the <c>bucket-owner-full-control</c> ACL
        /// with the owner being the account that created the bucket. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/about-object-ownership.html">
        /// Controlling object ownership and disabling ACLs</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The following operations are related to <c>GetBucketAcl</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListObjects.html">ListObjects</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">Specifies the S3 bucket whose ACL is being requested. When you use this API operation with an access point, provide the alias of the access point in place of the bucket name. When you use this API operation with an Object Lambda access point, provide the alias of the Object Lambda access point in place of the bucket name. If the Object Lambda access point alias in a request is not valid, the error code <c>InvalidAccessPointAliasError</c> is returned. For more information about <c>InvalidAccessPointAliasError</c>, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#ErrorCodeList">List of Error Codes</a>.</param>
        /// 
        /// <returns>The response from the GetACL service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetBucketAcl">REST API Reference for GetACL Operation</seealso>
        [Obsolete("GetACL combines both GetBucketAcl and GetObjectAcl and is deprecated. Please use the separated GetObjectAcl and GetBucketAcl operations.")]
        public virtual GetACLResponse GetACL(string bucketName)
        {
            var request = new GetACLRequest();
            request.BucketName = bucketName;
            return GetACL(request);
        }

        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// This implementation of the <c>GET</c> action uses the <c>acl</c> subresource to return
        /// the access control list (ACL) of a bucket. To use <c>GET</c> to return the ACL of
        /// the bucket, you must have the <c>READ_ACP</c> access to the bucket. If <c>READ_ACP</c>
        /// permission is granted to the anonymous user, you can return the ACL of the bucket
        /// without using an authorization header.
        /// </para>
        ///  
        /// <para>
        /// When you use this API operation with an access point, provide the alias of the access
        /// point in place of the bucket name.
        /// </para>
        ///  
        /// <para>
        /// When you use this API operation with an Object Lambda access point, provide the alias
        /// of the Object Lambda access point in place of the bucket name. If the Object Lambda
        /// access point alias in a request is not valid, the error code <c>InvalidAccessPointAliasError</c>
        /// is returned. For more information about <c>InvalidAccessPointAliasError</c>, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#ErrorCodeList">List
        /// of Error Codes</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If your bucket uses the bucket owner enforced setting for S3 Object Ownership, requests
        /// to read ACLs are still supported and return the <c>bucket-owner-full-control</c> ACL
        /// with the owner being the account that created the bucket. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/about-object-ownership.html">
        /// Controlling object ownership and disabling ACLs</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The following operations are related to <c>GetBucketAcl</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListObjects.html">ListObjects</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetACL service method.</param>
        /// 
        /// <returns>The response from the GetACL service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetBucketAcl">REST API Reference for GetACL Operation</seealso>
        [Obsolete("GetACL combines both GetBucketAcl and GetObjectAcl and is deprecated. Please use the separated GetObjectAcl and GetBucketAcl operations.")]
        public virtual GetACLResponse GetACL(GetACLRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetACLResponseUnmarshaller.Instance;

            return Invoke<GetACLResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// This implementation of the <c>GET</c> action uses the <c>acl</c> subresource to return
        /// the access control list (ACL) of a bucket. To use <c>GET</c> to return the ACL of
        /// the bucket, you must have the <c>READ_ACP</c> access to the bucket. If <c>READ_ACP</c>
        /// permission is granted to the anonymous user, you can return the ACL of the bucket
        /// without using an authorization header.
        /// </para>
        ///  
        /// <para>
        /// When you use this API operation with an access point, provide the alias of the access
        /// point in place of the bucket name.
        /// </para>
        ///  
        /// <para>
        /// When you use this API operation with an Object Lambda access point, provide the alias
        /// of the Object Lambda access point in place of the bucket name. If the Object Lambda
        /// access point alias in a request is not valid, the error code <c>InvalidAccessPointAliasError</c>
        /// is returned. For more information about <c>InvalidAccessPointAliasError</c>, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#ErrorCodeList">List
        /// of Error Codes</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If your bucket uses the bucket owner enforced setting for S3 Object Ownership, requests
        /// to read ACLs are still supported and return the <c>bucket-owner-full-control</c> ACL
        /// with the owner being the account that created the bucket. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/about-object-ownership.html">
        /// Controlling object ownership and disabling ACLs</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The following operations are related to <c>GetBucketAcl</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListObjects.html">ListObjects</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">Specifies the S3 bucket whose ACL is being requested. When you use this API operation with an access point, provide the alias of the access point in place of the bucket name. When you use this API operation with an Object Lambda access point, provide the alias of the Object Lambda access point in place of the bucket name. If the Object Lambda access point alias in a request is not valid, the error code <c>InvalidAccessPointAliasError</c> is returned. For more information about <c>InvalidAccessPointAliasError</c>, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#ErrorCodeList">List of Error Codes</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetACL service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetBucketAcl">REST API Reference for GetACL Operation</seealso>
        [Obsolete("GetACL combines both GetBucketAcl and GetObjectAcl and is deprecated. Please use the separated GetObjectAcl and GetBucketAcl operations.")]
        public virtual Task<GetACLResponse> GetACLAsync(string bucketName, CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetACLRequest();
            request.BucketName = bucketName;
            return GetACLAsync(request, cancellationToken);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// This implementation of the <c>GET</c> action uses the <c>acl</c> subresource to return
        /// the access control list (ACL) of a bucket. To use <c>GET</c> to return the ACL of
        /// the bucket, you must have the <c>READ_ACP</c> access to the bucket. If <c>READ_ACP</c>
        /// permission is granted to the anonymous user, you can return the ACL of the bucket
        /// without using an authorization header.
        /// </para>
        ///  
        /// <para>
        /// When you use this API operation with an access point, provide the alias of the access
        /// point in place of the bucket name.
        /// </para>
        ///  
        /// <para>
        /// When you use this API operation with an Object Lambda access point, provide the alias
        /// of the Object Lambda access point in place of the bucket name. If the Object Lambda
        /// access point alias in a request is not valid, the error code <c>InvalidAccessPointAliasError</c>
        /// is returned. For more information about <c>InvalidAccessPointAliasError</c>, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#ErrorCodeList">List
        /// of Error Codes</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If your bucket uses the bucket owner enforced setting for S3 Object Ownership, requests
        /// to read ACLs are still supported and return the <c>bucket-owner-full-control</c> ACL
        /// with the owner being the account that created the bucket. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/about-object-ownership.html">
        /// Controlling object ownership and disabling ACLs</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The following operations are related to <c>GetBucketAcl</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListObjects.html">ListObjects</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetACL service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetBucketAcl">REST API Reference for GetACL Operation</seealso>
        [Obsolete("GetACL combines both GetBucketAcl and GetObjectAcl and is deprecated. Please use the separated GetObjectAcl and GetBucketAcl operations.")]
        public virtual Task<GetACLResponse> GetACLAsync(GetACLRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetACLResponseUnmarshaller.Instance;

            return InvokeAsync<GetACLResponse>(request, options, cancellationToken);
        }

        #endregion
        #region  PutACL


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Sets the permissions on an existing bucket using access control lists (ACL). For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3_ACLs_UsingACLs.html">Using
        /// ACLs</a>. To set the ACL of a bucket, you must have the <c>WRITE_ACP</c> permission.
        /// </para>
        ///  
        /// <para>
        /// You can use one of the following two ways to set a bucket's permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify the ACL in the request body
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify permissions using request headers
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// You cannot specify access permission using both the body and the request headers.
        /// </para>
        ///  </note> 
        /// <para>
        /// Depending on your application needs, you may choose to set the ACL on a bucket using
        /// either the request body or the headers. For example, if you have an existing application
        /// that updates a bucket ACL using the request body, then you can continue to use that
        /// approach.
        /// </para>
        ///  <important> 
        /// <para>
        /// If your bucket uses the bucket owner enforced setting for S3 Object Ownership, ACLs
        /// are disabled and no longer affect permissions. You must use policies to grant access
        /// to your bucket and the objects in it. Requests to set ACLs or update ACLs fail and
        /// return the <c>AccessControlListNotSupported</c> error code. Requests to read ACLs
        /// are still supported. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/about-object-ownership.html">Controlling
        /// object ownership</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </important> <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You can set access permissions by using one of the following methods:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify a canned ACL with the <c>x-amz-acl</c> request header. Amazon S3 supports
        /// a set of predefined ACLs, known as <i>canned ACLs</i>. Each canned ACL has a predefined
        /// set of grantees and permissions. Specify the canned ACL name as the value of <c>x-amz-acl</c>.
        /// If you use this header, you cannot use other access control-specific headers in your
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#CannedACL">Canned
        /// ACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify access permissions explicitly with the <c>x-amz-grant-read</c>, <c>x-amz-grant-read-acp</c>,
        /// <c>x-amz-grant-write-acp</c>, and <c>x-amz-grant-full-control</c> headers. When using
        /// these headers, you specify explicit access permissions and grantees (Amazon Web Services
        /// accounts or Amazon S3 groups) who will receive the permission. If you use these ACL-specific
        /// headers, you cannot use the <c>x-amz-acl</c> header to set a canned ACL. These parameters
        /// map to the set of permissions that Amazon S3 supports in an ACL. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html">Access
        /// Control List (ACL) Overview</a>.
        /// </para>
        ///  
        /// <para>
        /// You specify each grantee as a type=value pair, where the type is one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>id</c> – if the value specified is the canonical user ID of an Amazon Web Services
        /// account
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>uri</c> – if you are granting permissions to a predefined group
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>emailAddress</c> – if the value specified is the email address of an Amazon Web
        /// Services account
        /// </para>
        ///  <note> 
        /// <para>
        /// Using email addresses to specify a grantee is only supported in the following Amazon
        /// Web Services Regions: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// US East (N. Virginia)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// US West (N. California)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  US West (Oregon)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Asia Pacific (Singapore)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asia Pacific (Sydney)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asia Pacific (Tokyo)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Europe (Ireland)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// South America (São Paulo)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For a list of all the Amazon S3 supported Regions and endpoints, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#s3_region">Regions
        /// and Endpoints</a> in the Amazon Web Services General Reference.
        /// </para>
        ///  </note> </li> </ul> 
        /// <para>
        /// For example, the following <c>x-amz-grant-write</c> header grants create, overwrite,
        /// and delete objects permission to LogDelivery group predefined by Amazon S3 and two
        /// Amazon Web Services accounts identified by their email addresses.
        /// </para>
        ///  
        /// <para>
        ///  <c>x-amz-grant-write: uri="http://acs.amazonaws.com/groups/s3/LogDelivery", id="111122223333",
        /// id="555566667777" </c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can use either a canned ACL or specify access permissions explicitly. You cannot
        /// do both.
        /// </para>
        ///  </dd> <dt>Grantee Values</dt> <dd> 
        /// <para>
        /// You can specify the person (grantee) to whom you're assigning access rights (using
        /// request elements) in the following ways:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// By the person's ID:
        /// </para>
        ///  
        /// <para>
        ///  <c>&lt;Grantee xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:type="CanonicalUser"&gt;&lt;ID&gt;&lt;&gt;ID&lt;&gt;&lt;/ID&gt;&lt;DisplayName&gt;&lt;&gt;GranteesEmail&lt;&gt;&lt;/DisplayName&gt;
        /// &lt;/Grantee&gt;</c> 
        /// </para>
        ///  
        /// <para>
        /// DisplayName is optional and ignored in the request
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// By URI:
        /// </para>
        ///  
        /// <para>
        ///  <c>&lt;Grantee xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:type="Group"&gt;&lt;URI&gt;&lt;&gt;http://acs.amazonaws.com/groups/global/AuthenticatedUsers&lt;&gt;&lt;/URI&gt;&lt;/Grantee&gt;</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// By Email address:
        /// </para>
        ///  
        /// <para>
        ///  <c>&lt;Grantee xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:type="AmazonCustomerByEmail"&gt;&lt;EmailAddress&gt;&lt;&gt;Grantees@email.com&lt;&gt;&lt;/EmailAddress&gt;&amp;&lt;/Grantee&gt;</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The grantee is resolved to the CanonicalUser and, in a response to a GET Object acl
        /// request, appears as the CanonicalUser. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Using email addresses to specify a grantee is only supported in the following Amazon
        /// Web Services Regions: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// US East (N. Virginia)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// US West (N. California)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  US West (Oregon)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Asia Pacific (Singapore)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asia Pacific (Sydney)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asia Pacific (Tokyo)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Europe (Ireland)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// South America (São Paulo)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For a list of all the Amazon S3 supported Regions and endpoints, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#s3_region">Regions
        /// and Endpoints</a> in the Amazon Web Services General Reference.
        /// </para>
        ///  </note> </li> </ul> </dd> </dl> 
        /// <para>
        /// The following operations are related to <c>PutBucketAcl</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateBucket.html">CreateBucket</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucket.html">DeleteBucket</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObjectAcl.html">GetObjectAcl</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutACL service method.</param>
        /// 
        /// <returns>The response from the PutACL service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/PutBucketAcl">REST API Reference for PutACL Operation</seealso>
        [Obsolete("PutACL combines both PutBucketAcl and PutObjectAcl and is deprecated. Please use the separated PutObjectAcl and PutBucketAcl operations.")]
        public virtual PutACLResponse PutACL(PutACLRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutACLResponseUnmarshaller.Instance;

            return Invoke<PutACLResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Sets the permissions on an existing bucket using access control lists (ACL). For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3_ACLs_UsingACLs.html">Using
        /// ACLs</a>. To set the ACL of a bucket, you must have the <c>WRITE_ACP</c> permission.
        /// </para>
        ///  
        /// <para>
        /// You can use one of the following two ways to set a bucket's permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify the ACL in the request body
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify permissions using request headers
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// You cannot specify access permission using both the body and the request headers.
        /// </para>
        ///  </note> 
        /// <para>
        /// Depending on your application needs, you may choose to set the ACL on a bucket using
        /// either the request body or the headers. For example, if you have an existing application
        /// that updates a bucket ACL using the request body, then you can continue to use that
        /// approach.
        /// </para>
        ///  <important> 
        /// <para>
        /// If your bucket uses the bucket owner enforced setting for S3 Object Ownership, ACLs
        /// are disabled and no longer affect permissions. You must use policies to grant access
        /// to your bucket and the objects in it. Requests to set ACLs or update ACLs fail and
        /// return the <c>AccessControlListNotSupported</c> error code. Requests to read ACLs
        /// are still supported. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/about-object-ownership.html">Controlling
        /// object ownership</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </important> <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You can set access permissions by using one of the following methods:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify a canned ACL with the <c>x-amz-acl</c> request header. Amazon S3 supports
        /// a set of predefined ACLs, known as <i>canned ACLs</i>. Each canned ACL has a predefined
        /// set of grantees and permissions. Specify the canned ACL name as the value of <c>x-amz-acl</c>.
        /// If you use this header, you cannot use other access control-specific headers in your
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#CannedACL">Canned
        /// ACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify access permissions explicitly with the <c>x-amz-grant-read</c>, <c>x-amz-grant-read-acp</c>,
        /// <c>x-amz-grant-write-acp</c>, and <c>x-amz-grant-full-control</c> headers. When using
        /// these headers, you specify explicit access permissions and grantees (Amazon Web Services
        /// accounts or Amazon S3 groups) who will receive the permission. If you use these ACL-specific
        /// headers, you cannot use the <c>x-amz-acl</c> header to set a canned ACL. These parameters
        /// map to the set of permissions that Amazon S3 supports in an ACL. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html">Access
        /// Control List (ACL) Overview</a>.
        /// </para>
        ///  
        /// <para>
        /// You specify each grantee as a type=value pair, where the type is one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>id</c> – if the value specified is the canonical user ID of an Amazon Web Services
        /// account
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>uri</c> – if you are granting permissions to a predefined group
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>emailAddress</c> – if the value specified is the email address of an Amazon Web
        /// Services account
        /// </para>
        ///  <note> 
        /// <para>
        /// Using email addresses to specify a grantee is only supported in the following Amazon
        /// Web Services Regions: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// US East (N. Virginia)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// US West (N. California)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  US West (Oregon)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Asia Pacific (Singapore)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asia Pacific (Sydney)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asia Pacific (Tokyo)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Europe (Ireland)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// South America (São Paulo)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For a list of all the Amazon S3 supported Regions and endpoints, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#s3_region">Regions
        /// and Endpoints</a> in the Amazon Web Services General Reference.
        /// </para>
        ///  </note> </li> </ul> 
        /// <para>
        /// For example, the following <c>x-amz-grant-write</c> header grants create, overwrite,
        /// and delete objects permission to LogDelivery group predefined by Amazon S3 and two
        /// Amazon Web Services accounts identified by their email addresses.
        /// </para>
        ///  
        /// <para>
        ///  <c>x-amz-grant-write: uri="http://acs.amazonaws.com/groups/s3/LogDelivery", id="111122223333",
        /// id="555566667777" </c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can use either a canned ACL or specify access permissions explicitly. You cannot
        /// do both.
        /// </para>
        ///  </dd> <dt>Grantee Values</dt> <dd> 
        /// <para>
        /// You can specify the person (grantee) to whom you're assigning access rights (using
        /// request elements) in the following ways:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// By the person's ID:
        /// </para>
        ///  
        /// <para>
        ///  <c>&lt;Grantee xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:type="CanonicalUser"&gt;&lt;ID&gt;&lt;&gt;ID&lt;&gt;&lt;/ID&gt;&lt;DisplayName&gt;&lt;&gt;GranteesEmail&lt;&gt;&lt;/DisplayName&gt;
        /// &lt;/Grantee&gt;</c> 
        /// </para>
        ///  
        /// <para>
        /// DisplayName is optional and ignored in the request
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// By URI:
        /// </para>
        ///  
        /// <para>
        ///  <c>&lt;Grantee xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:type="Group"&gt;&lt;URI&gt;&lt;&gt;http://acs.amazonaws.com/groups/global/AuthenticatedUsers&lt;&gt;&lt;/URI&gt;&lt;/Grantee&gt;</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// By Email address:
        /// </para>
        ///  
        /// <para>
        ///  <c>&lt;Grantee xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:type="AmazonCustomerByEmail"&gt;&lt;EmailAddress&gt;&lt;&gt;Grantees@email.com&lt;&gt;&lt;/EmailAddress&gt;&amp;&lt;/Grantee&gt;</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The grantee is resolved to the CanonicalUser and, in a response to a GET Object acl
        /// request, appears as the CanonicalUser. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Using email addresses to specify a grantee is only supported in the following Amazon
        /// Web Services Regions: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// US East (N. Virginia)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// US West (N. California)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  US West (Oregon)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Asia Pacific (Singapore)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asia Pacific (Sydney)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asia Pacific (Tokyo)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Europe (Ireland)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// South America (São Paulo)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For a list of all the Amazon S3 supported Regions and endpoints, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#s3_region">Regions
        /// and Endpoints</a> in the Amazon Web Services General Reference.
        /// </para>
        ///  </note> </li> </ul> </dd> </dl> 
        /// <para>
        /// The following operations are related to <c>PutBucketAcl</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateBucket.html">CreateBucket</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucket.html">DeleteBucket</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObjectAcl.html">GetObjectAcl</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutACL service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/PutBucketAcl">REST API Reference for PutACL Operation</seealso>
        [Obsolete("PutACL combines both PutBucketAcl and PutObjectAcl and is deprecated. Please use the separated PutObjectAcl and PutBucketAcl operations.")]
        public virtual Task<PutACLResponse> PutACLAsync(PutACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutACLResponseUnmarshaller.Instance;

            return InvokeAsync<PutACLResponse>(request, options, cancellationToken);
        }

        #endregion
    }

}
