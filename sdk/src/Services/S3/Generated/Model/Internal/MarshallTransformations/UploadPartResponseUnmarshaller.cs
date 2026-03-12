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
    /// Response Unmarshaller for UploadPart operation
    /// </summary>  
    public partial class UploadPartResponseUnmarshaller : S3ReponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            UploadPartResponse response = new UploadPartResponse();
            if (context.ResponseData.IsHeaderPresent("x-amz-server-side-encryption-bucket-key-enabled"))
                response.BucketKeyEnabled = bool.Parse(context.ResponseData.GetHeaderValue("x-amz-server-side-encryption-bucket-key-enabled"));
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
            if (context.ResponseData.IsHeaderPresent("ETag"))
                response.ETag = context.ResponseData.GetHeaderValue("ETag");
            if (context.ResponseData.IsHeaderPresent("x-amz-request-charged"))
                response.RequestCharged = context.ResponseData.GetHeaderValue("x-amz-request-charged");
            if (context.ResponseData.IsHeaderPresent("x-amz-server-side-encryption"))
                response.ServerSideEncryptionMethod = context.ResponseData.GetHeaderValue("x-amz-server-side-encryption");
            if (context.ResponseData.IsHeaderPresent("x-amz-server-side-encryption-customer-algorithm"))
                response.SSECustomerAlgorithm = context.ResponseData.GetHeaderValue("x-amz-server-side-encryption-customer-algorithm");
            if (context.ResponseData.IsHeaderPresent("x-amz-server-side-encryption-customer-key-MD5"))
                response.SSECustomerKeyMD5 = context.ResponseData.GetHeaderValue("x-amz-server-side-encryption-customer-key-MD5");
            if (context.ResponseData.IsHeaderPresent("x-amz-server-side-encryption-aws-kms-key-id"))
                response.SSEKMSKeyId = context.ResponseData.GetHeaderValue("x-amz-server-side-encryption-aws-kms-key-id");
            
            PostUnmarshallCustomization(context, response);
            return response;
        }        

        partial void PostUnmarshallCustomization(XmlUnmarshallerContext context, UploadPartResponse response);

        private static UploadPartResponseUnmarshaller _instance = new UploadPartResponseUnmarshaller();        

        internal static UploadPartResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UploadPartResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}