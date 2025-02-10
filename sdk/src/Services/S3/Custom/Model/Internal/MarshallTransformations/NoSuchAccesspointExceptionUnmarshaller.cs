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

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for NoSuchAccesspointException operation
    /// </summary>  
    public class NoSuchAccesspointExceptionUnmarshaller : IXmlErrorResponseUnmarshaller<NoSuchAccesspointException, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public NoSuchAccesspointException Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="errorResponse"></param>
        /// <returns></returns>
        public NoSuchAccesspointException Unmarshall(XmlUnmarshallerContext context, Amazon.Runtime.Internal.ErrorResponse errorResponse)
        {
            NoSuchAccesspointException response = new NoSuchAccesspointException(errorResponse.Message, errorResponse.InnerException,
                errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                }
            }
            return response;
        }

        private static NoSuchAccesspointExceptionUnmarshaller _instance = new NoSuchAccesspointExceptionUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NoSuchAccesspointExceptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}