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
    /// Response Unmarshaller for CompleteMultipartUpload operation
    /// </summary>  
    public partial class CompleteMultipartUploadResponseUnmarshaller : S3ReponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            CompleteMultipartUploadResponse response = new CompleteMultipartUploadResponse();
            UnmarshallResult(context,response);
            if (context.ResponseData.IsHeaderPresent("x-amz-server-side-encryption-bucket-key-enabled"))
                response.BucketKeyEnabled = bool.Parse(context.ResponseData.GetHeaderValue("x-amz-server-side-encryption-bucket-key-enabled"));
            ExpirationCustomUnmarshall(context, response);
            if (context.ResponseData.IsHeaderPresent("x-amz-request-charged"))
                response.RequestCharged = context.ResponseData.GetHeaderValue("x-amz-request-charged");
            if (context.ResponseData.IsHeaderPresent("x-amz-server-side-encryption-aws-kms-key-id"))
                response.ServerSideEncryptionKeyManagementServiceKeyId = context.ResponseData.GetHeaderValue("x-amz-server-side-encryption-aws-kms-key-id");
            if (context.ResponseData.IsHeaderPresent("x-amz-server-side-encryption"))
                response.ServerSideEncryptionMethod = context.ResponseData.GetHeaderValue("x-amz-server-side-encryption");
            if (context.ResponseData.IsHeaderPresent("x-amz-version-id"))
                response.VersionId = context.ResponseData.GetHeaderValue("x-amz-version-id");
            
            PostUnmarshallCustomization(context, response);
            return response;
        }        

        private static void UnmarshallResult(XmlUnmarshallerContext context, CompleteMultipartUploadResponse response)
        {
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
                   targetDepth += 1;
            if (context.IsEmptyResponse)
            {
                return;
            }
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Bucket", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.BucketName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ChecksumCRC32", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ChecksumCRC32 = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ChecksumCRC32C", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ChecksumCRC32C = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ChecksumCRC64NVME", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ChecksumCRC64NVME = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ChecksumSHA1", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ChecksumSHA1 = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ChecksumSHA256", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ChecksumSHA256 = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ChecksumType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ChecksumType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ETag", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ETag = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Key", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Key = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Location", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Location = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return;
                }
            }
            return;
        }

        partial void PostUnmarshallCustomization(XmlUnmarshallerContext context, CompleteMultipartUploadResponse response);

        private static CompleteMultipartUploadResponseUnmarshaller _instance = new CompleteMultipartUploadResponseUnmarshaller();        

        internal static CompleteMultipartUploadResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CompleteMultipartUploadResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}