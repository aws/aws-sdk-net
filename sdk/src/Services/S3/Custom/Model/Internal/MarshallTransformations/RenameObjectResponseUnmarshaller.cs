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
using System.IO;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Response Unmarshaller for RenameObject operation
    /// </summary>
    public class RenameObjectResponseUnmarshaller : S3ReponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            RenameObjectResponse response = new RenameObjectResponse();
            UnmarshallResult(context, response);
            return response;
        }

        private static void UnmarshallResult(XmlUnmarshallerContext context, RenameObjectResponse response)
        {
            // The rename operation returns an empty response body on success
            // All information is contained in the HTTP headers which are already processed by the base unmarshaller
            // No additional processing needed for this empty response
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
            if (context == null)
                throw new ArgumentNullException(nameof(context));
                
            var errorResponse = S3ErrorResponseUnmarshaller.Instance.Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new XmlUnmarshallerContext(streamCopy, false, null))
            {
                if (errorResponse.Code != null && errorResponse.Code.Equals("IdempotencyParameterMismatch", StringComparison.Ordinal))
                {
                    return IdempotencyParameterMismatchExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }

            return base.ConstructS3Exception(context, errorResponse, innerException, statusCode);
        }

        private static RenameObjectResponseUnmarshaller _instance;

        /// <summary>
        /// Singleton for the unmarshaller
        /// </summary>  
        public static RenameObjectResponseUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RenameObjectResponseUnmarshaller();
                }
                return _instance;
            }
        }
    }
}