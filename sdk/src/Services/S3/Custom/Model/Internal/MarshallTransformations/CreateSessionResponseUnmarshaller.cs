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
using System.IO;
using System.Net;

using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CreateSession operation
    /// </summary>  
    public class CreateSessionResponseUnmarshaller : S3ReponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            CreateSessionResponse response = new CreateSessionResponse();
            UnmarshallResult(context, response);

            return response;
        }

        private static void UnmarshallResult(XmlUnmarshallerContext context, CreateSessionResponse response)
        {
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument)
                targetDepth += 1;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Credentials", targetDepth))
                    {
                        var unmarshaller = SessionCredentialsUnmarshaller.Instance;
                        response.Credentials = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return;
                }
            }

            IWebResponseData responseData = context.ResponseData;
            if (responseData.IsHeaderPresent("x-amz-server-side-encryption"))
            {
                response.ServerSideEncryption = S3Transforms.ToString(responseData.GetHeaderValue("x-amz-server-side-encryption"));
            }
            if (responseData.IsHeaderPresent("x-amz-server-side-encryption-aws-kms-key-id"))
            {
                response.SSEKMSKeyId = S3Transforms.ToString(responseData.GetHeaderValue("x-amz-server-side-encryption-aws-kms-key-id"));
            }
            if (responseData.IsHeaderPresent("x-amz-server-side-encryption-context"))
            {
                response.SSEKMSEncryptionContext = S3Transforms.ToString(responseData.GetHeaderValue("x-amz-server-side-encryption-context"));
            }
            if (responseData.IsHeaderPresent("x-amz-server-side-encryption-bucket-key-enabled"))
            {
                response.BucketKeyEnabled = S3Transforms.ToBool(responseData.GetHeaderValue("x-amz-server-side-encryption-bucket-key-enabled"));
            }

            return;
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
            var errorResponse = S3ErrorResponseUnmarshaller.Instance.Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new XmlUnmarshallerContext(streamCopy, false, null))
            {
                if (errorResponse.Code != null && errorResponse.Code.Equals("NoSuchBucket"))
                {
                    return NoSuchBucketExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }

            return base.ConstructS3Exception(context, errorResponse, innerException, statusCode);
        }

        private static CreateSessionResponseUnmarshaller _instance = new CreateSessionResponseUnmarshaller();

        internal static CreateSessionResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateSessionResponseUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CreateSessionResponseUnmarshaller();
                }
                return _instance;
            }
        }

    }
}