/*
 * Copyright 2010-2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.SharedInterfaces;
using Amazon.S3.Internal;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.S3.Util;
using Amazon.Util;
using Amazon.Util.Internal;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;

namespace Amazon.S3
{
    public partial class AmazonS3Client : AmazonServiceClient, IAmazonS3
    {
        internal void ConfigureProxy(HttpWebRequest httpRequest)
        {
#if BCL||NETSTANDARD
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
#endif
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

#if AWS_APM_API

        IAsyncResult ICoreAmazonS3.BeginDelete(string bucketName, string objectKey, IDictionary<string, object> additionalProperties, AsyncCallback callback, object state)
        {
            var request = new DeleteObjectRequest
            {
                BucketName = bucketName,
                Key = objectKey
            };
            InternalSDKUtils.ApplyValues(request, additionalProperties);

            return this.BeginDeleteObject(request, callback, state);
        }

        void ICoreAmazonS3.EndDelete(IAsyncResult result)
        {
            this.EndDeleteObject(result);
        }

        IAsyncResult ICoreAmazonS3.BeginUploadObjectFromStream(string bucketName, string objectKey, Stream stream, IDictionary<string, object> additionalProperties, AsyncCallback callback, object state)
        {
            var transfer = new Amazon.S3.Transfer.TransferUtility(this);
            var request = new Amazon.S3.Transfer.TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = objectKey,
                InputStream = stream
            };
            InternalSDKUtils.ApplyValues(request, additionalProperties);

            return transfer.BeginUpload(request, callback, state);
        }

        void ICoreAmazonS3.EndUploadObjectFromStream(IAsyncResult result)
        {
            var transfer = new Amazon.S3.Transfer.TransferUtility(this);
            transfer.EndUpload(result);
        }

        IAsyncResult ICoreAmazonS3.BeginUploadObjectFromFilePath(string bucketName, string objectKey, string filepath, IDictionary<string, object> additionalProperties, AsyncCallback callback, object state)
        {
            var transfer = new Amazon.S3.Transfer.TransferUtility(this);
            var request = new Amazon.S3.Transfer.TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = objectKey,
                FilePath = filepath
            };
            InternalSDKUtils.ApplyValues(request, additionalProperties);

            return transfer.BeginUpload(request, callback, state);
        }

        void ICoreAmazonS3.EndUploadObjectFromFilePath(IAsyncResult result)
        {
            var transfer = new Amazon.S3.Transfer.TransferUtility(this);
            transfer.EndUpload(result);
        }

        IAsyncResult ICoreAmazonS3.BeginDownloadToFilePath(string bucketName, string objectKey, string filepath, IDictionary<string, object> additionalProperties, AsyncCallback callback, object state)
        {
            var transfer = new Amazon.S3.Transfer.TransferUtility(this);

            var request = new Amazon.S3.Transfer.TransferUtilityDownloadRequest
            {
                BucketName = bucketName,
                Key = objectKey,
                FilePath = filepath
            };
            InternalSDKUtils.ApplyValues(request, additionalProperties);

            return transfer.BeginDownload(request, callback, state);
        }

        void ICoreAmazonS3.EndDownloadToFilePath(IAsyncResult result)
        {
            var transfer = new Amazon.S3.Transfer.TransferUtility(this);
            transfer.EndDownload(result);
        }

        IAsyncResult ICoreAmazonS3.BeginGetObjectStream(string bucketName, string objectKey, IDictionary<string, object> additionalProperties, AsyncCallback callback, object state)
        {
            var request = new GetObjectRequest()
            {
                BucketName = bucketName,
                Key = objectKey
            };
            InternalSDKUtils.ApplyValues(request, additionalProperties);

            return this.BeginGetObject(request, callback, state);
        }

        Stream ICoreAmazonS3.EndGetObjectStream(IAsyncResult result)
        {
            return this.EndGetObject(result).ResponseStream;
        }
#endif
#endregion
    }
}

