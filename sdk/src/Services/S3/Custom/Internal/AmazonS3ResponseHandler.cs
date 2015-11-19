/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Linq;
using System.Text;
using Amazon.Runtime;
using Amazon.S3.Model;
using System.IO;
using Amazon.S3.Util;
using Amazon.Util;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal;

#pragma warning disable 1591

namespace Amazon.S3.Internal
{
    public class AmazonS3ResponseHandler : PipelineHandler
    {
        /// <summary>
        /// Calls the post invoke logic after calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        public override void InvokeSync(IExecutionContext executionContext)
        {
            base.InvokeSync(executionContext);
            PostInvoke(executionContext);
        }
#if AWS_ASYNC_API

        /// <summary>
        /// Calls the and post invoke logic after calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <typeparam name="T">The response type for the current request.</typeparam>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public override async System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            var response = await base.InvokeAsync<T>(executionContext).ConfigureAwait(false);
            PostInvoke(executionContext);
            return response;
        }

#elif AWS_APM_API

        /// <summary>
        /// Calls the PostInvoke methods after calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        protected override void InvokeAsyncCallback(IAsyncExecutionContext executionContext)
        {
            // Process the response if an exception hasn't occured
            if (executionContext.ResponseContext.AsyncResult.Exception == null)
            {
                PostInvoke(ExecutionContext.CreateFromAsyncContext(executionContext));
            }
            base.InvokeAsyncCallback(executionContext);
        }
#endif

        protected virtual void PostInvoke(IExecutionContext executionContext)
        {
            ProcessResponseHandlers(executionContext);
        }

        private static void ProcessResponseHandlers(IExecutionContext executionContext)
        {
            AmazonWebServiceResponse response = executionContext.ResponseContext.Response;
            IRequest request = executionContext.RequestContext.Request;
            IWebResponseData webResponseData = executionContext.ResponseContext.HttpResponse;
            bool isSse = HasSSEHeaders(webResponseData);

            var getObjectResponse = response as GetObjectResponse;
            if (getObjectResponse != null)
            {
                GetObjectRequest getObjectRequest = request.OriginalRequest as GetObjectRequest;
                getObjectResponse.BucketName = getObjectRequest.BucketName;
                getObjectResponse.Key = getObjectRequest.Key;

                // If ETag is present and is an MD5 hash (not a multi-part upload ETag), and no byte range is specified,
                // wrap the response stream in an MD5Stream.
                // If there is a customer encryption algorithm the etag is not an MD5.
                if (!string.IsNullOrEmpty(getObjectResponse.ETag)
                    && !getObjectResponse.ETag.Contains("-")
                    && !isSse
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
                    if (putObjectResponse != null && !isSse)
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
                    if (uploadPartResponse != null && !isSse)
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

            AmazonS3Client.CleanupRequest(request);
        }

        private static bool HasSSEHeaders(IWebResponseData webResponseData)
        {
            bool usesCustomerAlgorithm = !string.IsNullOrEmpty(webResponseData.GetHeaderValue(HeaderKeys.XAmzSSECustomerAlgorithmHeader));
            bool usesKmsKeyId = !string.IsNullOrEmpty(webResponseData.GetHeaderValue(HeaderKeys.XAmzServerSideEncryptionAwsKmsKeyIdHeader));
            return usesCustomerAlgorithm || usesKmsKeyId;
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
