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
using System.Globalization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using Amazon.S3.Util;
using Amazon.S3.Model;

#pragma warning disable 1591

namespace Amazon.S3.Internal
{
    public class AmazonS3PostMarshallHandler : PipelineHandler
    {
        /// <summary>
        /// Calls pre invoke logic before calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        public override void InvokeSync(IExecutionContext executionContext)
        {
            PreInvoke(executionContext);
            base.InvokeSync(executionContext);
        }

#if AWS_ASYNC_API
        /// <summary>
        /// Calls pre invoke logic before calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <typeparam name="T">The response type for the current request.</typeparam>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public override System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            PreInvoke(executionContext);
            return base.InvokeAsync<T>(executionContext);
        }
#endif

        protected virtual void PreInvoke(IExecutionContext executionContext)
        {
            ProcessPreRequestHandlers(executionContext);
        }

        private static void ProcessPreRequestHandlers(IExecutionContext executionContext)
        {
            var originalRequest = executionContext.RequestContext.OriginalRequest;
            if (SetStreamChecksum(originalRequest, executionContext.RequestContext.Request))
                return;


            var checksumData = executionContext.RequestContext.Request.ChecksumData;
            var isRequestDefaultsToMD5 = checksumData != null && (checksumData.IsMD5Checksum || checksumData.FallbackToMD5.GetValueOrDefault());
            var userSelectedChecksumAlgorithm = checksumData != null && checksumData.SelectedChecksum != null;

            // Set default checksumAlgorithm to CRC32 for directory buckets when request is using MD5 by default and no checksum were selected by the user
            if (executionContext.RequestContext.Request.IsDirectoryBucket() && isRequestDefaultsToMD5 && !userSelectedChecksumAlgorithm)
            {
                // The following requests shouldn't use checksum for directory buckets
                if (executionContext.RequestContext.OriginalRequest is InitiateMultipartUploadRequest ||
                    executionContext.RequestContext.OriginalRequest is CompleteMultipartUploadRequest)
                    executionContext.RequestContext.Request.ChecksumData.SelectedChecksum = null;
                else
                    executionContext.RequestContext.Request.ChecksumData.SelectedChecksum = ChecksumAlgorithm.CRC32;

                executionContext.RequestContext.Request.ChecksumData.IsMD5Checksum = false;
                executionContext.RequestContext.Request.ChecksumData.FallbackToMD5 = false;
            }
        }
        /// <summary>
        /// Sets the checksum data for streams, chunked encoding, wrap the input stream, and calculate content length.
        /// </summary>
        /// <returns>True if the request has a stream that and it was handled, otherwise false</returns>

        private static bool SetStreamChecksum(AmazonWebServiceRequest originalRequest, IRequest request)
        {
            var putObjectRequest = originalRequest as PutObjectRequest;
            if (putObjectRequest != null)
            {
                SetStreamChecksum(putObjectRequest, request);
                return true;
            }

            var uploadPartRequest = originalRequest as UploadPartRequest;
            if (uploadPartRequest != null)
            {
                SetStreamChecksum(uploadPartRequest, request);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Sets the checksum data for streams, chunked encoding, wrap the input stream, and calculate content length.
        /// </summary>
        /// <returns>True if the request has a stream that and it was handled, otherwise false</returns>
        private static void SetStreamChecksum(UploadPartRequest uploadPartRequest, IRequest request)
        {
            if (uploadPartRequest.InputStream != null)
            {
                // Wrap input stream in partial wrapper (to upload only part of the stream)
                var partialStream = new PartialWrapperStream(uploadPartRequest.InputStream, uploadPartRequest.PartSize);
                if (partialStream.Length > 0 && !(uploadPartRequest.DisablePayloadSigning ?? false))
                    request.UseChunkEncoding = uploadPartRequest.UseChunkEncoding;
                if (!request.Headers.ContainsKey(HeaderKeys.ContentLengthHeader))
                    request.Headers.Add(HeaderKeys.ContentLengthHeader, partialStream.Length.ToString(CultureInfo.InvariantCulture));

                request.DisablePayloadSigning = uploadPartRequest.DisablePayloadSigning;

                // Calculate Content-MD5 if not already set
                if (!uploadPartRequest.IsSetMD5Digest() && uploadPartRequest.CalculateContentMD5Header && !request.IsDirectoryBucket())
                {
                    string md5 = AmazonS3Util.GenerateMD5ChecksumForStream(partialStream);
                    if (!string.IsNullOrEmpty(md5))
                    {
                        request.Headers[HeaderKeys.ContentMD5Header] = md5;
                    }
                }


                var defaultChecksumValidationDisabled = uploadPartRequest.DisableDefaultChecksumValidation ?? AWSConfigsS3.DisableDefaultChecksumValidation;

                if (!defaultChecksumValidationDisabled
                    && !request.IsDirectoryBucket()) // No checksum should be used for directory buckets
                {
                    // Wrap input stream in MD5Stream; after this we can no longer seek or position the stream
                    var hashStream = new MD5Stream(partialStream, null, partialStream.Length);
                    uploadPartRequest.InputStream = hashStream;
                }
                else
                {
                    uploadPartRequest.InputStream = partialStream;
                }
            }

            request.ContentStream = uploadPartRequest.InputStream;
            ChecksumUtils.SetChecksumData(request, uploadPartRequest.ChecksumAlgorithm, fallbackToMD5: false);
        }

        /// <summary>
        /// Sets the checksum data for streams, chunked encoding, wrap the input stream, and calculate content length.
        /// </summary>
        /// <returns>True if the request has a stream that and it was handled, otherwise false</returns>
        private static void SetStreamChecksum(PutObjectRequest putObjectRequest, IRequest request)
        {
            ChecksumUtils.SetChecksumData(request, putObjectRequest.ChecksumAlgorithm, fallbackToMD5: false);

            if (putObjectRequest.InputStream != null)
            {
                // Wrap the stream in a stream that has a length
                var streamWithLength = GetStreamWithLength(putObjectRequest.InputStream, putObjectRequest.Headers.ContentLength);
                if (streamWithLength.Length > 0 && !(putObjectRequest.DisablePayloadSigning ?? false))
                    request.UseChunkEncoding = putObjectRequest.UseChunkEncoding;
                var length = streamWithLength.Length - streamWithLength.Position;
                if (!request.Headers.ContainsKey(HeaderKeys.ContentLengthHeader))
                    request.Headers.Add(HeaderKeys.ContentLengthHeader, length.ToString(CultureInfo.InvariantCulture));

                request.DisablePayloadSigning = putObjectRequest.DisablePayloadSigning;

                // Calculate Content-MD5 if not already set
                if (!putObjectRequest.IsSetMD5Digest() && putObjectRequest.CalculateContentMD5Header && !request.IsDirectoryBucket())
                {
                    string md5 = AmazonS3Util.GenerateMD5ChecksumForStream(putObjectRequest.InputStream);

                    if (!string.IsNullOrEmpty(md5))
                    {
                        request.Headers[HeaderKeys.ContentMD5Header] = md5;
                    }
                }

              
                var defaultChecksumValidationDisabled = putObjectRequest.DisableDefaultChecksumValidation ?? AWSConfigsS3.DisableDefaultChecksumValidation;

                if (!defaultChecksumValidationDisabled
                    && !request.IsDirectoryBucket())
                {
                    // Wrap input stream in MD5Stream
                    var hashStream = new MD5Stream(streamWithLength, null, length);
                    putObjectRequest.InputStream = hashStream;
                }
                else if (request.IsDirectoryBucket() && request.ChecksumData.SelectedChecksum == null
                    && !defaultChecksumValidationDisabled)
                {
                    // If using S3 express AND the user didn't specify their own checksum algorithm,
                    // we want to default to CRC32 to preserve the existing durability 
                    // validation we do for plain S3 via the MD5Stream handling above
                    request.ChecksumData.SelectedChecksum = ChecksumAlgorithm.CRC32;
                }
                else
                {
                    putObjectRequest.InputStream = streamWithLength;
                }
            }

            request.ContentStream = putObjectRequest.InputStream;
        }


        /// <summary>
        /// Returns a stream that has a length.
        /// If the stream supports seeking, returns stream.
        /// Otherwise, uses hintLength to create a read-only, non-seekable stream of given length
        /// </summary>
        private static Stream GetStreamWithLength(Stream baseStream, long hintLength)
        {
            Stream result = baseStream;
            bool shouldWrapStream = false;
            long length = -1;
            try
            {
                length = baseStream.Length - baseStream.Position;
            }
            catch (NotSupportedException)
            {
                shouldWrapStream = true;
                length = hintLength;
            }
            if (length < 0)
                throw new AmazonS3Exception("Could not determine content length");

            // Wrap input stream if base stream doesn't have a length property
            if (shouldWrapStream)
                result = new PartialReadOnlyWrapperStream(baseStream, length);

            return result;
        }
    }
}
