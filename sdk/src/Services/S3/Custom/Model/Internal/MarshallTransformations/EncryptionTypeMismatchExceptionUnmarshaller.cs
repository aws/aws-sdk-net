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

using Amazon.Runtime.Internal.Transform;
using Amazon.Util;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EncryptionTypeMismatchException operation
    /// </summary>  
    public class EncryptionTypeMismatchExceptionUnmarshaller : IXmlErrorResponseUnmarshaller<EncryptionTypeMismatchException, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public EncryptionTypeMismatchException Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="errorResponse"></param>
        /// <returns></returns>
        public EncryptionTypeMismatchException Unmarshall(XmlUnmarshallerContext context, Amazon.Runtime.Internal.ErrorResponse errorResponse)
        {
            string id2 = null, amzCfId = null;
            var s3ErrorResponse = errorResponse as S3ErrorResponse;
            if (s3ErrorResponse != null)
            {
                id2 = s3ErrorResponse.Id2;
                amzCfId = s3ErrorResponse.AmzCfId;
            }

            EncryptionTypeMismatchException response = new EncryptionTypeMismatchException(errorResponse.Message, errorResponse.InnerException,
                errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode, id2, amzCfId);

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                }
            }
            return response;
        }

        private static EncryptionTypeMismatchExceptionUnmarshaller _instance = new EncryptionTypeMismatchExceptionUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EncryptionTypeMismatchExceptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}