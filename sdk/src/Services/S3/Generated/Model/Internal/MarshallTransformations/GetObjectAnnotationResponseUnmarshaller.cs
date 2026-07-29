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

/*
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetObjectAnnotation operation
    /// </summary>  
    public partial class GetObjectAnnotationResponseUnmarshaller : S3ReponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            GetObjectAnnotationResponse response = new GetObjectAnnotationResponse();
            response.ResponseStream = context.Stream;
            if (context.ResponseData.IsHeaderPresent("x-amz-checksum-crc32"))
                response.ChecksumCRC32 = context.ResponseData.GetHeaderValue("x-amz-checksum-crc32");
            if (context.ResponseData.IsHeaderPresent("x-amz-checksum-crc32c"))
                response.ChecksumCRC32C = context.ResponseData.GetHeaderValue("x-amz-checksum-crc32c");
            if (context.ResponseData.IsHeaderPresent("x-amz-checksum-crc64nvme"))
                response.ChecksumCRC64NVME = context.ResponseData.GetHeaderValue("x-amz-checksum-crc64nvme");
            if (context.ResponseData.IsHeaderPresent("x-amz-checksum-md5"))
                response.ChecksumMD5 = context.ResponseData.GetHeaderValue("x-amz-checksum-md5");
            if (context.ResponseData.IsHeaderPresent("x-amz-checksum-sha1"))
                response.ChecksumSHA1 = context.ResponseData.GetHeaderValue("x-amz-checksum-sha1");
            if (context.ResponseData.IsHeaderPresent("x-amz-checksum-sha256"))
                response.ChecksumSHA256 = context.ResponseData.GetHeaderValue("x-amz-checksum-sha256");
            if (context.ResponseData.IsHeaderPresent("x-amz-checksum-sha512"))
                response.ChecksumSHA512 = context.ResponseData.GetHeaderValue("x-amz-checksum-sha512");
            if (context.ResponseData.IsHeaderPresent("x-amz-checksum-type"))
                response.ChecksumType = context.ResponseData.GetHeaderValue("x-amz-checksum-type");
            if (context.ResponseData.IsHeaderPresent("x-amz-checksum-xxhash128"))
                response.ChecksumXXHASH128 = context.ResponseData.GetHeaderValue("x-amz-checksum-xxhash128");
            if (context.ResponseData.IsHeaderPresent("x-amz-checksum-xxhash3"))
                response.ChecksumXXHASH3 = context.ResponseData.GetHeaderValue("x-amz-checksum-xxhash3");
            if (context.ResponseData.IsHeaderPresent("x-amz-checksum-xxhash64"))
                response.ChecksumXXHASH64 = context.ResponseData.GetHeaderValue("x-amz-checksum-xxhash64");
            if (context.ResponseData.IsHeaderPresent("Content-Length"))
                response.ContentLength = long.Parse(context.ResponseData.GetHeaderValue("Content-Length"), CultureInfo.InvariantCulture);
            if (context.ResponseData.IsHeaderPresent("ETag"))
                response.ETag = context.ResponseData.GetHeaderValue("ETag");
            if (context.ResponseData.IsHeaderPresent("Last-Modified"))
                response.LastModified = DateTime.Parse(context.ResponseData.GetHeaderValue("Last-Modified"), CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal);
            if (context.ResponseData.IsHeaderPresent("x-amz-object-version-id"))
                response.ObjectVersionId = context.ResponseData.GetHeaderValue("x-amz-object-version-id");
            if (context.ResponseData.IsHeaderPresent("x-amz-replication-status"))
                response.ReplicationStatus = context.ResponseData.GetHeaderValue("x-amz-replication-status");
            if (context.ResponseData.IsHeaderPresent("x-amz-request-charged"))
                response.RequestCharged = context.ResponseData.GetHeaderValue("x-amz-request-charged");
            if (context.ResponseData.IsHeaderPresent("x-amz-server-side-encryption"))
                response.ServerSideEncryption = context.ResponseData.GetHeaderValue("x-amz-server-side-encryption");
            
            PostUnmarshallCustomization(context, response);
            return response;
        }        
        /// <summary>
        /// Specifies that the response payload should be streamed
        /// </summary>
        public override bool HasStreamingProperty => true;
  

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            S3ErrorResponse errorResponse = S3ErrorResponseUnmarshaller.Instance.Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new XmlUnmarshallerContext(streamCopy, false, null))
            {
                if (errorResponse.Code != null && errorResponse.Code.Equals("NoSuchAnnotation"))
                {
                    return NoSuchAnnotationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("NoSuchBucket"))
                {
                    return NoSuchBucketExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("NoSuchKey"))
                {
                    return NoSuchKeyExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return base.ConstructS3Exception(context, errorResponse, innerException, statusCode);
        }

        partial void PostUnmarshallCustomization(XmlUnmarshallerContext context, GetObjectAnnotationResponse response);

        private static GetObjectAnnotationResponseUnmarshaller _instance = new GetObjectAnnotationResponseUnmarshaller();        

        internal static GetObjectAnnotationResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetObjectAnnotationResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}