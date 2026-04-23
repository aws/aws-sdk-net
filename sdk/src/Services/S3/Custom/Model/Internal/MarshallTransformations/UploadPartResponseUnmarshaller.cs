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
using System;
using System.Net;
using System.Collections.Generic;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Response Unmarshaller for UploadPart operation
    /// </summary>
    public class UploadPartResponseUnmarshaller : S3ReponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context) 
        {   
            UploadPartResponse response = new UploadPartResponse();
            
            UnmarshallResult(context,response);

            return response;
        }
        
        private static void UnmarshallResult(XmlUnmarshallerContext context,UploadPartResponse response)
        {

            IWebResponseData responseData = context.ResponseData;
            if (responseData.IsHeaderPresent("x-amz-server-side-encryption"))
                response.ServerSideEncryptionMethod = S3Transforms.ToString(responseData.GetHeaderValue("x-amz-server-side-encryption"));
            if (responseData.IsHeaderPresent("ETag"))
                response.ETag = S3Transforms.ToString(responseData.GetHeaderValue("ETag"));
            if (responseData.IsHeaderPresent(S3Constants.AmzHeaderRequestCharged))
                response.RequestCharged = RequestCharged.FindValue(responseData.GetHeaderValue(S3Constants.AmzHeaderRequestCharged));
            if (responseData.IsHeaderPresent(S3Constants.AmzHeaderBucketKeyEnabled))
                response.BucketKeyEnabled = S3Transforms.ToBool(responseData.GetHeaderValue(S3Constants.AmzHeaderBucketKeyEnabled));
            if (context.ResponseData.IsHeaderPresent("x-amz-checksum-crc32"))
                response.ChecksumCRC32 = S3Transforms.ToString(context.ResponseData.GetHeaderValue("x-amz-checksum-crc32"));
            if (context.ResponseData.IsHeaderPresent("x-amz-checksum-crc32c"))
                response.ChecksumCRC32C = S3Transforms.ToString(context.ResponseData.GetHeaderValue("x-amz-checksum-crc32c"));
            if (responseData.IsHeaderPresent("x-amz-checksum-crc64nvme"))
                response.ChecksumCRC64NVME = S3Transforms.ToString(context.ResponseData.GetHeaderValue("x-amz-checksum-crc64nvme"));
            if (context.ResponseData.IsHeaderPresent("x-amz-checksum-sha1"))
                response.ChecksumSHA1 = S3Transforms.ToString(context.ResponseData.GetHeaderValue("x-amz-checksum-sha1"));
            if (context.ResponseData.IsHeaderPresent("x-amz-checksum-sha256"))
                response.ChecksumSHA256 = S3Transforms.ToString(context.ResponseData.GetHeaderValue("x-amz-checksum-sha256"));
            if (context.ResponseData.IsHeaderPresent("x-amz-checksum-md5"))
                response.ChecksumMD5 = context.ResponseData.GetHeaderValue("x-amz-checksum-md5");
            if (context.ResponseData.IsHeaderPresent("x-amz-checksum-sha512"))
                response.ChecksumSHA512 = context.ResponseData.GetHeaderValue("x-amz-checksum-sha512");
            if (context.ResponseData.IsHeaderPresent("x-amz-checksum-xxhash128"))
                response.ChecksumXXHASH128 = context.ResponseData.GetHeaderValue("x-amz-checksum-xxhash128");
            if (context.ResponseData.IsHeaderPresent("x-amz-checksum-xxhash3"))
                response.ChecksumXXHASH3 = context.ResponseData.GetHeaderValue("x-amz-checksum-xxhash3");
            if (context.ResponseData.IsHeaderPresent("x-amz-checksum-xxhash64"))
                response.ChecksumXXHASH64 = context.ResponseData.GetHeaderValue("x-amz-checksum-xxhash64");
            return;
        }

        private static UploadPartResponseUnmarshaller _instance;

        /// <summary>
        /// Singleton for the unmarshaller
        /// </summary>
        public static UploadPartResponseUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UploadPartResponseUnmarshaller();
                }
                return _instance;
            }
        }
    
    }
}
    
