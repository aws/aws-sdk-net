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
    /// Response Unmarshaller for GetObjectMetadata operation
    /// </summary>  
    public partial class GetObjectMetadataResponseUnmarshaller : S3ReponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            GetObjectMetadataResponse response = new GetObjectMetadataResponse();
            if (context.ResponseData.IsHeaderPresent("accept-ranges"))
                response.AcceptRanges = context.ResponseData.GetHeaderValue("accept-ranges");
            if (context.ResponseData.IsHeaderPresent("x-amz-archive-status"))
                response.ArchiveStatus = context.ResponseData.GetHeaderValue("x-amz-archive-status");
            if (context.ResponseData.IsHeaderPresent("x-amz-server-side-encryption-bucket-key-enabled"))
                response.BucketKeyEnabled = bool.Parse(context.ResponseData.GetHeaderValue("x-amz-server-side-encryption-bucket-key-enabled"));
            if (context.ResponseData.IsHeaderPresent("Cache-Control"))
                response.CacheControl = context.ResponseData.GetHeaderValue("Cache-Control");
            if (context.ResponseData.IsHeaderPresent("x-amz-checksum-crc32"))
                response.ChecksumCRC32 = context.ResponseData.GetHeaderValue("x-amz-checksum-crc32");
            if (context.ResponseData.IsHeaderPresent("x-amz-checksum-crc32c"))
                response.ChecksumCRC32C = context.ResponseData.GetHeaderValue("x-amz-checksum-crc32c");
            if (context.ResponseData.IsHeaderPresent("x-amz-checksum-crc64nvme"))
                response.ChecksumCRC64NVME = context.ResponseData.GetHeaderValue("x-amz-checksum-crc64nvme");
            if (context.ResponseData.IsHeaderPresent("x-amz-checksum-sha1"))
                response.ChecksumSHA1 = context.ResponseData.GetHeaderValue("x-amz-checksum-sha1");
            if (context.ResponseData.IsHeaderPresent("x-amz-checksum-sha256"))
                response.ChecksumSHA256 = context.ResponseData.GetHeaderValue("x-amz-checksum-sha256");
            if (context.ResponseData.IsHeaderPresent("x-amz-checksum-type"))
                response.ChecksumType = context.ResponseData.GetHeaderValue("x-amz-checksum-type");
            if (context.ResponseData.IsHeaderPresent("Content-Disposition"))
                response.ContentDisposition = context.ResponseData.GetHeaderValue("Content-Disposition");
            if (context.ResponseData.IsHeaderPresent("Content-Encoding"))
                response.ContentEncoding = context.ResponseData.GetHeaderValue("Content-Encoding");
            if (context.ResponseData.IsHeaderPresent("Content-Language"))
                response.ContentLanguage = context.ResponseData.GetHeaderValue("Content-Language");
            if (context.ResponseData.IsHeaderPresent("Content-Length"))
                response.ContentLength = long.Parse(context.ResponseData.GetHeaderValue("Content-Length"), CultureInfo.InvariantCulture);
            if (context.ResponseData.IsHeaderPresent("Content-Range"))
                response.ContentRange = context.ResponseData.GetHeaderValue("Content-Range");
            if (context.ResponseData.IsHeaderPresent("Content-Type"))
                response.ContentType = context.ResponseData.GetHeaderValue("Content-Type");
            if (context.ResponseData.IsHeaderPresent("ETag"))
                response.ETag = context.ResponseData.GetHeaderValue("ETag");
            if (context.ResponseData.IsHeaderPresent("Last-Modified"))
                response.LastModified = DateTime.Parse(context.ResponseData.GetHeaderValue("Last-Modified"), CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal);
            if (context.ResponseData.IsHeaderPresent("x-amz-missing-meta"))
                response.MissingMeta = int.Parse(context.ResponseData.GetHeaderValue("x-amz-missing-meta"), CultureInfo.InvariantCulture);
            if (context.ResponseData.IsHeaderPresent("x-amz-object-lock-legal-hold"))
                response.ObjectLockLegalHoldStatus = context.ResponseData.GetHeaderValue("x-amz-object-lock-legal-hold");
            if (context.ResponseData.IsHeaderPresent("x-amz-object-lock-mode"))
                response.ObjectLockMode = context.ResponseData.GetHeaderValue("x-amz-object-lock-mode");
            if (context.ResponseData.IsHeaderPresent("x-amz-object-lock-retain-until-date"))
                response.ObjectLockRetainUntilDate = DateTime.Parse(context.ResponseData.GetHeaderValue("x-amz-object-lock-retain-until-date"), CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal);
            if (context.ResponseData.IsHeaderPresent("x-amz-mp-parts-count"))
                response.PartsCount = int.Parse(context.ResponseData.GetHeaderValue("x-amz-mp-parts-count"), CultureInfo.InvariantCulture);
            if (context.ResponseData.IsHeaderPresent("x-amz-replication-status"))
                response.ReplicationStatus = context.ResponseData.GetHeaderValue("x-amz-replication-status");
            if (context.ResponseData.IsHeaderPresent("x-amz-request-charged"))
                response.RequestCharged = context.ResponseData.GetHeaderValue("x-amz-request-charged");
            if (context.ResponseData.IsHeaderPresent("x-amz-server-side-encryption-customer-key-MD5"))
                response.ServerSideEncryptionCustomerProvidedKeyMD5 = context.ResponseData.GetHeaderValue("x-amz-server-side-encryption-customer-key-MD5");
            if (context.ResponseData.IsHeaderPresent("x-amz-server-side-encryption-aws-kms-key-id"))
                response.ServerSideEncryptionKeyManagementServiceKeyId = context.ResponseData.GetHeaderValue("x-amz-server-side-encryption-aws-kms-key-id");
            if (context.ResponseData.IsHeaderPresent("x-amz-storage-class"))
                response.StorageClass = context.ResponseData.GetHeaderValue("x-amz-storage-class");
            if (context.ResponseData.IsHeaderPresent("x-amz-tagging-count"))
                response.TagsCount = int.Parse(context.ResponseData.GetHeaderValue("x-amz-tagging-count"), CultureInfo.InvariantCulture);
            if (context.ResponseData.IsHeaderPresent("x-amz-version-id"))
                response.VersionId = context.ResponseData.GetHeaderValue("x-amz-version-id");
            if (context.ResponseData.IsHeaderPresent("x-amz-website-redirect-location"))
                response.WebsiteRedirectLocation = context.ResponseData.GetHeaderValue("x-amz-website-redirect-location");
            
            PostUnmarshallCustomization(context, response);
            return response;
        }        
  

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
                if (errorResponse.Code != null && errorResponse.Code.Equals("NoSuchKey"))
                {
                    return NoSuchKeyExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return base.ConstructS3Exception(context, errorResponse, innerException, statusCode);
        }

        partial void PostUnmarshallCustomization(XmlUnmarshallerContext context, GetObjectMetadataResponse response);

        private static GetObjectMetadataResponseUnmarshaller _instance = new GetObjectMetadataResponseUnmarshaller();        

        internal static GetObjectMetadataResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetObjectMetadataResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}