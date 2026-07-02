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
 * Do not modify this file. This file is generated from the restjsondataplane-1999-12-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RestJsonDataPlane.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.RestJsonDataPlane.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CopyObject operation
    /// </summary>  
    public class CopyObjectResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            CopyObjectResponse response = new CopyObjectResponse();
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("ChecksumCRC32", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ChecksumCRC32 = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ChecksumCRC32C", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ChecksumCRC32C = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ChecksumCRC64NVME", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ChecksumCRC64NVME = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ChecksumSHA1", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ChecksumSHA1 = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ChecksumSHA256", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ChecksumSHA256 = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ChecksumType", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ChecksumType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ETag", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ETag = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LastModified", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.LastModified = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            if (context.ResponseData.IsHeaderPresent("x-amz-server-side-encryption-bucket-key-enabled"))
                response.BucketKeyEnabled = bool.Parse(context.ResponseData.GetHeaderValue("x-amz-server-side-encryption-bucket-key-enabled"));
            if (context.ResponseData.IsHeaderPresent("x-amz-copy-source-version-id"))
                response.CopySourceVersionId = context.ResponseData.GetHeaderValue("x-amz-copy-source-version-id");
            if (context.ResponseData.IsHeaderPresent("x-amz-expiration"))
                response.Expiration = context.ResponseData.GetHeaderValue("x-amz-expiration");
            if (context.ResponseData.IsHeaderPresent("x-amz-request-charged"))
                response.RequestCharged = context.ResponseData.GetHeaderValue("x-amz-request-charged");
            if (context.ResponseData.IsHeaderPresent("x-amz-server-side-encryption"))
                response.ServerSideEncryption = context.ResponseData.GetHeaderValue("x-amz-server-side-encryption");
            if (context.ResponseData.IsHeaderPresent("x-amz-server-side-encryption-customer-algorithm"))
                response.SSECustomerAlgorithm = context.ResponseData.GetHeaderValue("x-amz-server-side-encryption-customer-algorithm");
            if (context.ResponseData.IsHeaderPresent("x-amz-server-side-encryption-customer-key-MD5"))
                response.SSECustomerKeyMD5 = context.ResponseData.GetHeaderValue("x-amz-server-side-encryption-customer-key-MD5");
            if (context.ResponseData.IsHeaderPresent("x-amz-server-side-encryption-context"))
                response.SSEKMSEncryptionContext = context.ResponseData.GetHeaderValue("x-amz-server-side-encryption-context");
            if (context.ResponseData.IsHeaderPresent("x-amz-server-side-encryption-aws-kms-key-id"))
                response.SSEKMSKeyId = context.ResponseData.GetHeaderValue("x-amz-server-side-encryption-aws-kms-key-id");
            if (context.ResponseData.IsHeaderPresent("x-amz-version-id"))
                response.VersionId = context.ResponseData.GetHeaderValue("x-amz-version-id");

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))
            {
                StreamingUtf8JsonReader readerCopy = new StreamingUtf8JsonReader(streamCopy, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
            }
            return new AmazonRestJsonDataPlaneException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static CopyObjectResponseUnmarshaller _instance = new CopyObjectResponseUnmarshaller();        

        internal static CopyObjectResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CopyObjectResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}