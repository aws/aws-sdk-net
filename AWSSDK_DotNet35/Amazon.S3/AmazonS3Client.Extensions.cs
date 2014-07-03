﻿/*
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
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.S3.Util;
using Amazon.Util;
using Map = System.Collections.Generic.Dictionary<Amazon.S3.S3QueryParameter, string>;
using System.Globalization;

#if BCL45 || WIN_RT || WINDOWS_PHONE
using System.Threading.Tasks;
#endif

namespace Amazon.S3
{
    public partial class AmazonS3Client : AmazonWebServiceClient, IAmazonS3
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
            var region = AWS4Signer.DetermineSigningRegion(Config, "s3");
            if (aws4Signing && string.IsNullOrEmpty(region))
                throw new InvalidOperationException("To use AWS4 signing, a region must be specified in the client configuration using the AuthenticationRegion or Region properties, or be determinable from the service URL.");

            if (region.Equals(RegionEndpoint.CNNorth1.SystemName, StringComparison.OrdinalIgnoreCase))
                aws4Signing = true;

            var immutableCredentials = Credentials.GetCredentials();
            var irequest = Marshall(request, immutableCredentials.AccessKey, immutableCredentials.Token, aws4Signing);

            irequest.Endpoint = DetermineEndpoint(irequest);
            ProcessRequestHandlers(irequest);
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
                signer.SignRequest(irequest, metrics, immutableCredentials.AccessKey, immutableCredentials.SecretKey);
                authorization = irequest.Headers[S3QueryParameter.Authorization.ToString()];
                authorization = authorization.Substring(authorization.IndexOf(":", StringComparison.Ordinal) + 1);
                authorization = "&Signature=" + AmazonS3Util.UrlEncode(authorization, false);
            }

            Uri url = ComposeUrl(irequest, irequest.Endpoint);
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
                request.Headers[S3Constants.AmzSecurityTokenHeader] = token;

            if (getPreSignedUrlRequest.ServerSideEncryptionMethod != null && getPreSignedUrlRequest.ServerSideEncryptionMethod != ServerSideEncryptionMethod.None)
                request.Headers.Add("x-amz-server-side-encryption", S3Transforms.ToStringValue(getPreSignedUrlRequest.ServerSideEncryptionMethod));

            if (getPreSignedUrlRequest.IsSetServerSideEncryptionCustomerMethod())
                request.Headers.Add("x-amz-server-side-encryption-customer-algorithm", getPreSignedUrlRequest.ServerSideEncryptionCustomerMethod);
            if (getPreSignedUrlRequest.IsSetServerSideEncryptionCustomerProvidedKey())
                request.Headers.Add("x-amz-server-side-encryption-customer-key", getPreSignedUrlRequest.ServerSideEncryptionCustomerProvidedKey);
            if (getPreSignedUrlRequest.IsSetServerSideEncryptionCustomerMethod())
                request.Headers.Add("x-amz-server-side-encryption-customer-key-MD5", getPreSignedUrlRequest.ServerSideEncryptionCustomerProvidedKeyMD5);


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

            var baselineTime = aws4Signing ? DateTime.UtcNow : new DateTime(1970, 1, 1);
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
                queryParameters.Add("versionId", S3Transforms.ToStringValue(getPreSignedUrlRequest.VersionId));

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

            var path = uriResourcePath.ToString();
            request.CanonicalResource = S3Transforms.GetCanonicalResource(path, queryParameters, S3Constants.GetObjectExtraSubResources);
            request.ResourcePath = S3Transforms.FormatResourcePath(path, queryParameters);
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

        protected override void ProcessResponseHandlers(AmazonWebServiceResponse response, IRequest request, IWebResponseData webResponseData)
        {
            base.ProcessResponseHandlers(response, request, webResponseData);

            var getObjectResponse = response as GetObjectResponse;
            if (getObjectResponse != null)
            {
                GetObjectRequest getObjectRequest = request.OriginalRequest as GetObjectRequest;
                getObjectResponse.BucketName = getObjectRequest.BucketName;
                getObjectResponse.Key = getObjectRequest.Key;

                // If ETag is present and is an MD5 hash (not a multi-part upload ETag), and no byte range is specified,
                // wrap the response stream in an MD5Stream.
                // If there is a customer encryption algorithm the etag is not and MD5.
                if (!string.IsNullOrEmpty(getObjectResponse.ETag)
                    && !getObjectResponse.ETag.Contains("-")
                    && string.IsNullOrEmpty(webResponseData.GetHeaderValue("x-amz-server-side-encryption-customer-algorithm"))
                    && getObjectRequest.ByteRange == null)
                {
                    string etag = getObjectResponse.ETag.Trim(etagTrimChars);
                    byte[] expectedHash = AWSSDKUtils.HexStringToBytes(etag);
                    HashStream hashStream = new MD5Stream(getObjectResponse.ResponseStream, expectedHash, getObjectResponse.ContentLength);
                    getObjectResponse.ResponseStream = hashStream;
                }
            }

            var deleteObjectsResponse = response as DeleteObjectsResponse;
            if (deleteObjectsResponse != null)
            {
                if (deleteObjectsResponse.DeleteErrors != null && deleteObjectsResponse.DeleteErrors.Count > 0)
                {
                    throw new DeleteObjectsException(deleteObjectsResponse as DeleteObjectsResponse);
                }
            }

            var putObjectResponse = response as PutObjectResponse;
            var putObjectRequest = request.OriginalRequest as PutObjectRequest;
            if (putObjectRequest != null)
            {
                // If InputStream was a HashStream, compare calculated hash to returned etag
                HashStream hashStream = putObjectRequest.InputStream as HashStream;
                if (hashStream != null)
                {
                    if (putObjectResponse != null && string.IsNullOrEmpty(webResponseData.GetHeaderValue("x-amz-server-side-encryption-customer-algorithm")))
                    {
                        // Stream may not have been closed, so force calculation of hash
                        hashStream.CalculateHash();
                        CompareHashes(putObjectResponse.ETag, hashStream.CalculatedHash);
                    }

                    // Set InputStream to its original value
                    putObjectRequest.InputStream = hashStream.GetNonWrapperBaseStream();
                }
            }

            var listObjectsResponse = response as ListObjectsResponse;
            if (listObjectsResponse != null)
            {
                if (listObjectsResponse.IsTruncated &&
                    string.IsNullOrEmpty(listObjectsResponse.NextMarker) &&
                    listObjectsResponse.S3Objects.Count > 0)
                {
                    listObjectsResponse.NextMarker = listObjectsResponse.S3Objects.Last().Key;
                }
            }

            var uploadPartRequest = request.OriginalRequest as UploadPartRequest;
            var uploadPartResponse = response as UploadPartResponse;
            if (uploadPartRequest != null)
            {
                if (uploadPartResponse != null)
                    uploadPartResponse.PartNumber = uploadPartRequest.PartNumber;

                // If InputStream was a HashStream, compare calculated hash to returned etag
                HashStream hashStream = uploadPartRequest.InputStream as HashStream;
                if (hashStream != null)
                {
                    if (uploadPartResponse != null && string.IsNullOrEmpty(webResponseData.GetHeaderValue("x-amz-server-side-encryption-customer-algorithm")))
                    {
                        // Stream may not have been closed, so force calculation of hash
                        hashStream.CalculateHash();
                        CompareHashes(uploadPartResponse.ETag, hashStream.CalculatedHash);
                    }

                    // Set InputStream to its original value
                    uploadPartRequest.InputStream = hashStream.GetNonWrapperBaseStream();
                }
            }

            var copyPartResponse = response as CopyPartResponse;
            if (copyPartResponse != null)
            {
                copyPartResponse.PartNumber = ((CopyPartRequest)request.OriginalRequest).PartNumber;
            }

            CleanupRequest(request);
        }

        protected override void ProcessExceptionHandlers(Exception exception, IRequest request)
        {
            base.ProcessExceptionHandlers(exception, request);

            CleanupRequest(request);
        }

        private static void CleanupRequest(IRequest request)
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

        protected override void ProcessPreRequestHandlers(AmazonWebServiceRequest request)
        {
            base.ProcessPreRequestHandlers(request);

            var putObjectRequest = request as PutObjectRequest;
            if (putObjectRequest != null)
            {
                if (putObjectRequest.InputStream != null && !string.IsNullOrEmpty(putObjectRequest.FilePath))
                    throw new ArgumentException("Please specify one of either an InputStream or a FilePath to be PUT as an S3 object.");
                if (!string.IsNullOrEmpty(putObjectRequest.ContentBody) && !string.IsNullOrEmpty(putObjectRequest.FilePath))
                    throw new ArgumentException("Please specify one of either a FilePath or the ContentBody to be PUT as an S3 object.");
                if (putObjectRequest.InputStream != null && !string.IsNullOrEmpty(putObjectRequest.ContentBody))
                    throw new ArgumentException("Please specify one of either an InputStream or the ContentBody to be PUT as an S3 object.");

                if (!putObjectRequest.Headers.IsSetContentType())
                {
                    // Get the extension of the file from the path.
                    // Try the key as well.
                    string ext = null;
                    if(!string.IsNullOrEmpty(putObjectRequest.FilePath))
                        ext = Path.GetExtension(putObjectRequest.FilePath);
#if WIN_RT || WINDOWS_PHONE
                    if(putObjectRequest.StorageFile != null)
                        ext = Path.GetExtension(putObjectRequest.StorageFile.Path);
#endif
                    if (String.IsNullOrEmpty(ext) && putObjectRequest.IsSetKey())
                    {
                        ext = Path.GetExtension(putObjectRequest.Key);
                    }
                    // Use the extension to get the mime-type
                    if (!String.IsNullOrEmpty(ext))
                    {
                        putObjectRequest.Headers.ContentType = AmazonS3Util.MimeTypeFromExtension(ext);
                    }
                }

                if (putObjectRequest.InputStream != null)
                {
                    if (putObjectRequest.AutoResetStreamPosition && putObjectRequest.InputStream.CanSeek)
                    {
                        putObjectRequest.InputStream.Seek(0, SeekOrigin.Begin);
                    }
                }

                if (!string.IsNullOrEmpty(putObjectRequest.FilePath))
                {
                    putObjectRequest.SetupForFilePath();
                }
#if WIN_RT || WINDOWS_PHONE
                else if(putObjectRequest.StorageFile != null)
                {
                    putObjectRequest.InputStream = Task.Run(() =>
                        putObjectRequest.StorageFile.OpenAsync(Windows.Storage.FileAccessMode.Read).AsTask())
                        .Result.AsStreamForRead();
                    if (string.IsNullOrEmpty(putObjectRequest.Key))
                    {
                        putObjectRequest.Key = Path.GetFileName(putObjectRequest.StorageFile.Name);
                    }
                }
#endif
                else if (null == putObjectRequest.InputStream)
                {
                    if (string.IsNullOrEmpty(putObjectRequest.Headers.ContentType))
                        putObjectRequest.Headers.ContentType = "text/plain";
               
                    var payload = Encoding.UTF8.GetBytes(putObjectRequest.ContentBody ?? "");
                    //putObjectRequest.Headers[AWS4Signer.XAmzContentSha256] 
                    //        = AWSSDKUtils.ToHex(AWS4Signer.ComputeHash(payload), true);
                    putObjectRequest.InputStream = new MemoryStream(payload);
                }
            }

            var putBucketRequest = request as PutBucketRequest;
            if (putBucketRequest != null)
            {
                // UseClientRegion only applies if neither BucketRegionName and BucketRegion are set.
                if (putBucketRequest.UseClientRegion &&
                    !(putBucketRequest.IsSetBucketRegionName() || putBucketRequest.IsSetBucketRegion()))
                {
                    var regionCode = Amazon.Util.AWSSDKUtils.DetermineRegion(this.Config.DetermineServiceURL());
                    if (regionCode == S3Constants.REGION_US_EAST_1)
                        regionCode = null;
                    else if (regionCode == S3Constants.REGION_EU_WEST_1)
                        regionCode = "EU";

                    putBucketRequest.BucketRegion = regionCode;
                }
            }

            var deleteBucketRequest = request as DeleteBucketRequest;
            if (deleteBucketRequest != null)
            {
                if (deleteBucketRequest.UseClientRegion && !deleteBucketRequest.IsSetBucketRegion())
                {
                    var regionCode = Amazon.Util.AWSSDKUtils.DetermineRegion(this.Config.DetermineServiceURL());
                    if (regionCode == S3Constants.REGION_US_EAST_1)
                        regionCode = null;
                    //else if (regionCode == S3Constants.REGION_EU_WEST_1)
                    //    regionCode = "EU";

                    if (regionCode != null)
                        deleteBucketRequest.BucketRegion = regionCode;
                }
            }

            var uploadPartRequest = request as UploadPartRequest;
            if (uploadPartRequest != null)
            {
                if (uploadPartRequest.InputStream != null && !string.IsNullOrEmpty(uploadPartRequest.FilePath))
                    throw new ArgumentException("Please specify one of either a InputStream or a FilePath to be PUT as an S3 object.");

                if (uploadPartRequest.IsSetFilePath())
                {
                    uploadPartRequest.SetupForFilePath();
                }
#if WIN_RT || WINDOWS_PHONE
                else if(uploadPartRequest.StorageFile != null)
                {
                    uploadPartRequest.InputStream = Task.Run(() =>
                        uploadPartRequest.StorageFile.OpenAsync(Windows.Storage.FileAccessMode.Read).AsTask())
                        .Result.AsStreamForRead();
                    uploadPartRequest.InputStream.Position = uploadPartRequest.FilePosition;
                }
#endif
            }

            var initMultipartRequest = request as InitiateMultipartUploadRequest;
            if (initMultipartRequest != null)
            {
                if (!initMultipartRequest.Headers.IsSetContentType())
                {
                    // Get the extension of the object key.
                    string ext = Path.GetExtension(initMultipartRequest.Key);

                    // Use the extension to get the mime-type
                    if (!String.IsNullOrEmpty(ext))
                    {
                        initMultipartRequest.Headers.ContentType = AmazonS3Util.MimeTypeFromExtension(ext);
                    }
                }
            }
        }

        protected override void ProcessRequestHandlers(IRequest request)
        {
            base.ProcessRequestHandlers(request);

            var s3config = Config as AmazonS3Config;

            // Only modify endpoint and path if path style is not forced
            if (!s3config.ForcePathStyle)
            {
                var bucketName = GetBucketName(request.ResourcePath);

                // If there is a bucketName specified and it is DNS-compatbile,
                // push bucketName from path to host
                if (!string.IsNullOrEmpty(bucketName) && IsDnsCompatibleBucketName(bucketName))
                {
                    UriBuilder ub = new UriBuilder(DetermineEndpoint(request));

                    // If using HTTPS, bucketName cannot contain a period
                    if (string.Equals(ub.Scheme, "http", StringComparison.OrdinalIgnoreCase)
                        || bucketName.IndexOf('.') < 0)
                    {
                        // Add bucket to host
                        ub.Host = string.Concat(bucketName, ".", ub.Host);
                        request.Endpoint = ub.Uri;

                        // Remove bucket from resource path
                        string resourcePath = request.ResourcePath;
                        string canonicalBucketName = string.Concat("/", bucketName);
                        if (resourcePath.IndexOf(canonicalBucketName, StringComparison.Ordinal) == 0)
                            resourcePath = resourcePath.Substring(canonicalBucketName.Length);
                        request.ResourcePath = resourcePath;

                        // Update canonical resource
                        string canonicalResource = request.CanonicalResource;
                        string newCanonicalBucketName = canonicalBucketName + "/";
                        if (canonicalResource.IndexOf(canonicalBucketName, StringComparison.Ordinal) == 0
                            && canonicalResource.IndexOf(newCanonicalBucketName, StringComparison.Ordinal) < 0)
                            canonicalResource = string.Concat(newCanonicalBucketName, canonicalResource.Substring(canonicalBucketName.Length));
                        request.CanonicalResource = canonicalResource;
                    }
                }
            }
        }

        private static char[] separators = new char[] { '/', '?' };
        // Gets the bucket name from resource path
        internal static string GetBucketName(string resourcePath)
        {
            resourcePath = resourcePath.Trim().Trim(separators);
            var parts = resourcePath.Split(separators, 2);
            var bucketName = parts[0];
            return bucketName;
        }

#if BCL
        private static Regex bucketValidationRegex = new Regex(@"^[A-Za-z0-9._\-]+$", RegexOptions.Compiled);
#else
        private static Regex bucketValidationRegex = new Regex(@"^[A-Za-z0-9._\-]+$");
#endif
        // Returns true if the bucket name is valid
        private static bool IsValidBucketName(string bucketName)
        {
            // Check if bucket is null/empty string
            if (string.IsNullOrEmpty(bucketName))
                return false;
            
            // Check if the bucket name is between 3 and 255 characters
            if (bucketName.Length < 3 || bucketName.Length > 255)
                return false;
            
            // Check if the bucket contains a newline character
            if (bucketName.IndexOf('\n') >= 0)
                return false;

            // Check if bucket only contains:
            //  uppercase letters, lowercase letters, numbers
            //  periods (.), underscores (_), dashes (-)
            if (!bucketValidationRegex.IsMatch(bucketName))
                return false;

            return true;
        }

#if BCL
        private static Regex dnsValidationRegex1 = new Regex(@"^[a-z0-9][a-z0-9.-]+[a-z0-9]$", RegexOptions.Compiled);
        private static Regex dnsValidationRegex2 = new Regex("(\\d+\\.){3}\\d+", RegexOptions.Compiled);
#else
        private static Regex dnsValidationRegex1 = new Regex(@"^[a-z0-9][a-z0-9.-]+[a-z0-9]$");
        private static Regex dnsValidationRegex2 = new Regex("(\\d+\\.){3}\\d+");
#endif
        private static string[] invalidPatterns = new string[] { "..", "-.", ".-" };
        // Returns true if the given bucket name is DNS compatible
        // DNS compatible bucket names may be accessed like:
        //     http://dns.compat.bucket.name.s3.amazonaws.com/
        // Whereas non-dns compatible bucket names must place the bucket name in the url path, like:
        //     http://s3.amazonaws.com/dns_incompat_bucket_name/
        private static bool IsDnsCompatibleBucketName(string bucketName)
        {
            // Check basic validation
            if (!IsValidBucketName(bucketName))
                return false;

            // Bucket names should between 3 and 63 characters
            if (bucketName.Length > 63)
                return false;

            // Bucket names must only contain lowercase letters, numbers, dots, and dashes
            // and must start and end with a lowercase letter or a number
            if (!dnsValidationRegex1.IsMatch(bucketName))
                return false;

            // Bucket names should not be formatted like an IP address (e.g., 192.168.5.4)
            if (dnsValidationRegex2.IsMatch(bucketName))
                return false;

            // Bucket names cannot contain two adjacent periods or dashes next to periods
            if (StringContainsAny(bucketName, invalidPatterns, StringComparison.Ordinal))
                return false;

            return true;
        }

        // Returns true if string toCheck contains any of strings in values
        private static bool StringContainsAny(string toCheck, string[] values, StringComparison stringComparison)
        {
            foreach (var value in values)
            {
                if (toCheck.IndexOf(value, stringComparison) >= 0)
                    return true;
            }
            return false;
        }

        private static char[] etagTrimChars = new char[] { '\"' };
        // Compares ETag from S3 to calculated hash
        // If ETag is empty or is for a multi-part upload, no comparison is made
        // If ETag doesn't match the hash, an exception is thrown
        private static void CompareHashes(string etag, byte[] hash)
        {
            if (string.IsNullOrEmpty(etag))
                return;

            // if etag contains '-' character, the file was a multi-upload and we can't
            // compare the etag to the hash value
            if (etag.Contains("-"))
                return;

            etag = etag.Trim(etagTrimChars);

            string hexHash = AWSSDKUtils.BytesToHexString(hash);
            if (!string.Equals(etag, hexHash, StringComparison.OrdinalIgnoreCase))
                throw new AmazonClientException("Expected hash not equal to calculated hash");
        }
    }
}

