/*******************************************************************************
 *  Copyright 2008-2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */

using Amazon.Runtime.Internal;
using Amazon.S3.Model;
using Amazon.Util;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace Amazon.S3.Util
{
    /// <summary>
    /// Provides utilities used by the Amazon S3 client implementation.
    /// These utilities might be useful to consumers of the Amazon S3
    /// library.
    /// </summary>
    public static partial class AmazonS3Util
    {
        /// <summary>
        /// Determines whether an S3 bucket exists or not.
        /// This is done by:
        /// 1. Creating a PreSigned Url for the bucket. To work with Signature V4 only regions, as
        /// well as Signature V4-optional regions, we keep the expiry to within the maximum for V4 
        /// (which is one week).
        /// 2. Making a HEAD request to the Url
        /// </summary>
        /// <param name="bucketName">The name of the bucket to check.</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        /// <returns></returns>
        public static bool DoesS3BucketExist(IAmazonS3 s3Client, string bucketName)
        {
            if (s3Client == null)
            {
                throw new ArgumentNullException("s3Client", "The s3Client cannot be null!");
            }

            if (String.IsNullOrEmpty(bucketName))
            {
                throw new ArgumentNullException("bucketName", "The bucketName cannot be null or the empty string!");
            }

            var config = s3Client.Config;
            var request = new GetPreSignedUrlRequest
            {
                BucketName = bucketName, 
                Expires = config.CorrectedUtcNow.ToLocalTime().AddDays(1), 
                Verb = HttpVerb.HEAD, 
                Protocol = Protocol.HTTP
            };

            var url = s3Client.GetPreSignedURL(request);
            var uri = new Uri(url);
            
            var response = AmazonS3HttpUtil.GetHead(s3Client, config, url, HeaderKeys.XAmzBucketRegion);
            if (response.StatusCode == null)
            {
                // there was a problem with the request and we weren't able
                // conclusively determine if the bucket exists
                return false;
            }
            else
            {
                AmazonS3Uri s3Uri;
                var mismatchDetected = AmazonS3Uri.TryParseAmazonS3Uri(uri, out s3Uri) &&
                            BucketRegionDetector.GetCorrectRegion(s3Uri, response.StatusCode.Value, response.HeaderValue) != null;
                var statusCodeAcceptable = response.StatusCode != HttpStatusCode.NotFound && response.StatusCode != HttpStatusCode.BadRequest;
                return statusCodeAcceptable || mismatchDetected;
            }
        }

        ///// <summary>
        ///// Sets the storage class for the S3 Object to the value
        ///// specified.
        ///// </summary>
        ///// <param name="s3Object">The S3 Object whose storage class needs changing</param>
        ///// <param name="sClass">The new Storage Class for the object</param>
        ///// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        ///// <seealso cref="T:Amazon.S3.S3StorageClass"/>
        //public static void SetObjectStorageClass(S3Object s3Object, S3StorageClass sClass, IAmazonS3 s3Client)
        //{
        //    SetObjectStorageClass(s3Object.BucketName, s3Object.Key, sClass, s3Client);
        //}

        /// <summary>
        /// Sets the storage class for the S3 Object to the value
        /// specified.
        /// </summary>
        /// <param name="bucketName">The name of the bucket in which the key is stored</param>
        /// <param name="key">The key of the S3 Object whose storage class needs changing</param>
        /// <param name="sClass">The new Storage Class for the object</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        /// <seealso cref="T:Amazon.S3.S3StorageClass"/>
        public static void SetObjectStorageClass(IAmazonS3 s3Client, string bucketName, string key, S3StorageClass sClass)
        {
            SetObjectStorageClass(s3Client, bucketName, key, null, sClass);
        }

        /// <summary>
        /// Sets the storage class for the S3 Object's Version to the value
        /// specified.
        /// </summary>
        /// <param name="bucketName">The name of the bucket in which the key is stored</param>
        /// <param name="key">The key of the S3 Object whose storage class needs changing</param>
        /// <param name="version">The version of the S3 Object whose storage class needs changing</param>
        /// <param name="sClass">The new Storage Class for the object</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        /// <seealso cref="T:Amazon.S3.S3StorageClass"/>
        public static void SetObjectStorageClass(IAmazonS3 s3Client, string bucketName, string key, string version, S3StorageClass sClass)
        {
            CopyObjectRequest copyRequest;
            PutACLRequest putACLRequest;

            SetupForObjectModification(s3Client, bucketName, key, version, out copyRequest, out putACLRequest);

            copyRequest.StorageClass = sClass;
            CopyObjectResponse copyResponse = s3Client.CopyObject(copyRequest);

            if (!string.IsNullOrEmpty(copyResponse.SourceVersionId))
                putACLRequest.VersionId = copyResponse.SourceVersionId;

            s3Client.PutACL(putACLRequest);
        }

        ///// <summary>
        ///// Sets the server side encryption method for the S3 Object to the value
        ///// specified.
        ///// </summary>
        ///// <param name="s3Object">The S3 Object</param>
        ///// <param name="method">The server side encryption method</param>
        ///// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        //public static void SetServerSideEncryption(S3Object s3Object, ServerSideEncryptionMethod method, IAmazonS3 s3Client)
        //{
        //    SetServerSideEncryption(s3Object.BucketName, s3Object.Key, method, s3Client);
        //}

        /// <summary>
        /// Sets the server side encryption method for the S3 Object to the value
        /// specified.
        /// </summary>
        /// <param name="bucketName">The name of the bucket in which the key is stored</param>
        /// <param name="key">The key of the S3 Object</param>
        /// <param name="method">The server side encryption method</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        public static void SetServerSideEncryption(IAmazonS3 s3Client, string bucketName, string key, ServerSideEncryptionMethod method)
        {
            SetServerSideEncryption(s3Client, bucketName, key, null, method);
        }

        ///// <summary>
        ///// Sets the server side encryption method for the S3 Object Version to the value
        ///// specified.
        ///// </summary>
        ///// <param name="s3ObjectVer">The S3 Object Version</param>
        ///// <param name="method">The server side encryption method</param>
        ///// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        //public static void SetServerSideEncryption(S3ObjectVersion s3ObjectVer, ServerSideEncryptionMethod method, IAmazonS3 s3Client)
        //{
        //    SetServerSideEncryption(s3ObjectVer.BucketName, s3ObjectVer.Key, s3ObjectVer.VersionId, method, s3Client);
        //}

        /// <summary>
        /// Sets the server side encryption method for the S3 Object's Version to the value
        /// specified.
        /// </summary>
        /// <param name="bucketName">The name of the bucket in which the key is stored</param>
        /// <param name="key">The key of the S3 Object</param>
        /// <param name="version">The version of the S3 Object</param>
        /// <param name="method">The server side encryption method</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        public static void SetServerSideEncryption(IAmazonS3 s3Client, string bucketName, string key, string version, ServerSideEncryptionMethod method)
        {
            CopyObjectRequest copyRequest;
            PutACLRequest putACLRequest;

            SetupForObjectModification(s3Client, bucketName, key, version, out copyRequest, out putACLRequest);

            copyRequest.ServerSideEncryptionMethod = method;
            CopyObjectResponse copyResponse = s3Client.CopyObject(copyRequest);

            if (!string.IsNullOrEmpty(copyResponse.SourceVersionId))
                putACLRequest.VersionId = copyResponse.SourceVersionId;

            s3Client.PutACL(putACLRequest);
        }

        ///// <summary>
        ///// Sets the redirect location for the S3 Object's when being accessed through the S3 website endpoint.
        ///// </summary>
        ///// <param name="s3Object">The S3 Object</param>
        ///// <param name="websiteRedirectLocation">The redirect location</param>
        ///// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        //public static void SetWebsiteRedirectLocation(S3Object s3Object, string websiteRedirectLocation, IAmazonS3 s3Client)
        //{
        //    SetWebsiteRedirectLocation(s3Object.BucketName, s3Object.Key, websiteRedirectLocation, s3Client);
        //}

        /// <summary>
        /// Sets the redirect location for the S3 Object's when being accessed through the S3 website endpoint.
        /// </summary>
        /// <param name="bucketName">The name of the bucket in which the key is stored</param>
        /// <param name="key">The key of the S3 Object</param>
        /// <param name="websiteRedirectLocation">The redirect location</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        public static void SetWebsiteRedirectLocation(IAmazonS3 s3Client, string bucketName, string key, string websiteRedirectLocation)
        {
            CopyObjectRequest copyRequest;
            PutACLRequest putACLRequest;

            SetupForObjectModification(s3Client, bucketName, key, null, out copyRequest, out putACLRequest);

            copyRequest.WebsiteRedirectLocation = websiteRedirectLocation;
            CopyObjectResponse copyResponse = s3Client.CopyObject(copyRequest);

            if (!string.IsNullOrEmpty(copyResponse.SourceVersionId))
                putACLRequest.VersionId = copyResponse.SourceVersionId;

            s3Client.PutACL(putACLRequest);
        }

        /// <summary>
        /// Sets up the request needed to make an exact copy of the object leaving the parent method
        /// the ability to change just the attribute being requested to change.
        /// </summary>
        /// <param name="bucketName"></param>
        /// <param name="key"></param>
        /// <param name="version"></param>
        /// <param name="s3Client"></param>
        /// <param name="copyRequest"></param>
        /// <param name="putACLRequest"></param>
        static void SetupForObjectModification(IAmazonS3 s3Client, string bucketName, string key, string version, 
            out CopyObjectRequest copyRequest, out PutACLRequest putACLRequest)
        {
            // Get the existing ACL of the object
            GetACLRequest getACLRequest = new GetACLRequest();
            getACLRequest.BucketName = bucketName;
            getACLRequest.Key = key;
            if (version != null)
                getACLRequest.VersionId = version;
            GetACLResponse getACLResponse = s3Client.GetACL(getACLRequest);


            // Set the object's original ACL back onto it because a COPY
            // operation resets the ACL on the destination object.
            putACLRequest = new PutACLRequest();
            putACLRequest.BucketName = bucketName;
            putACLRequest.Key = key;
            putACLRequest.AccessControlList = getACLResponse.AccessControlList;


            ListObjectsResponse listObjectResponse = s3Client.ListObjects(new ListObjectsRequest
            {
                BucketName = bucketName,
                Prefix = key,
                MaxKeys = 1
            });

            if (listObjectResponse.S3Objects.Count != 1)
            {
                throw new InvalidOperationException("No object exists with this bucket name and key.");
            }

            GetObjectMetadataRequest getMetaRequest = new GetObjectMetadataRequest()
            {
                BucketName = bucketName,
                Key = key
            };
            GetObjectMetadataResponse getMetaResponse = s3Client.GetObjectMetadata(getMetaRequest);

            // Set the storage class on the object
            copyRequest = new CopyObjectRequest();
            copyRequest.SourceBucket = copyRequest.DestinationBucket = bucketName;
            copyRequest.SourceKey = copyRequest.DestinationKey = key;
            copyRequest.StorageClass = listObjectResponse.S3Objects[0].StorageClass == "STANDARD" ? S3StorageClass.Standard : S3StorageClass.ReducedRedundancy;
            if (version != null)
                copyRequest.SourceVersionId = version;

            copyRequest.WebsiteRedirectLocation = getMetaResponse.WebsiteRedirectLocation;
            copyRequest.ServerSideEncryptionMethod = getMetaResponse.ServerSideEncryptionMethod;
        }

        /// <summary>
        /// Converts the string representing a storage class that would come back from a ListObjects request
        /// to the S3StorageClass enumeration.
        /// </summary>
        /// <param name="value">Amazon S3 string values for storage class</param>
        /// <returns>The converted S3StorageClass enumeration</returns>
        public static S3StorageClass ConvertToS3StorageClass(string value)
        {
            switch (value)
            {
                case "REDUCED_REDUNDANCY":
                    return S3StorageClass.ReducedRedundancy;
                case "GLACIER":
                    return S3StorageClass.Glacier;
                default:
                    return S3StorageClass.Standard;
            }
        }

        /// <summary>
        /// Upload data to Amazon S3 using HTTP POST.
        /// </summary>
        /// <remarks>
        /// For more information, <see href="http://docs.aws.amazon.com/AmazonS3/latest/dev/UsingHTTPPOST.html"/>
        /// </remarks>
        /// <param name="request">Request object which describes the data to POST</param>
        /// <exception cref="S3PostUploadException">Thrown if the service returns an error</exception>
        public static S3PostUploadResponse PostUpload(S3PostUploadRequest request)
        {
            string url;
            string subdomain = request.Region.Equals(RegionEndpoint.USEast1) ? "s3" : "s3-" + request.Region.SystemName;

            if (request.Bucket.IndexOf('.') > -1)
                url = string.Format(CultureInfo.InvariantCulture, "https://{0}.amazonaws.com/{1}/", subdomain, request.Bucket);
            else
                url = string.Format(CultureInfo.InvariantCulture, "https://{0}.{1}.amazonaws.com", request.Bucket, subdomain);
            Uri uri = new Uri(url);

            HttpWebRequest webRequest = WebRequest.Create(uri) as HttpWebRequest;
            
            var boundary = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Replace('=', 'z');

            webRequest.ContentType = string.Format(CultureInfo.InvariantCulture, "multipart/form-data; boundary={0}", boundary);
            webRequest.Method = "POST";

            using (var reqStream = webRequest.GetRequestStream())
            {
                request.WriteFormData(boundary, reqStream);

                byte[] boundaryBytes = Encoding.UTF8.GetBytes(string.Format(CultureInfo.InvariantCulture, "--{0}\r\nContent-Disposition: form-data; name=\"file\"\r\n\r\n", boundary));

                reqStream.Write(boundaryBytes, 0, boundaryBytes.Length);

                using (var inputStream = null == request.Path ? request.InputStream : File.OpenRead(request.Path))
                {
                    byte[] buf = new byte[1024];
                    int bytesRead;
                    while ((bytesRead = inputStream.Read(buf, 0, 1024)) > 0)
                    {
                        reqStream.Write(buf, 0, bytesRead);
                    }
                }

                byte[] endBoundaryBytes = Encoding.UTF8.GetBytes(string.Format(CultureInfo.InvariantCulture, "\r\n--{0}--", boundary));

                reqStream.Write(endBoundaryBytes, 0, endBoundaryBytes.Length);
            }

            HttpWebResponse response = null;
            try
            {
                response = webRequest.GetResponse() as HttpWebResponse;
                return S3PostUploadResponse.FromWebResponse(response);
            }
            catch (WebException ex)
            {
                throw S3PostUploadException.FromResponse((HttpWebResponse)ex.Response);
            }
            finally
            {
                if (response != null)
                {
                    response.Close();
                }
            }
        }
    }
}
