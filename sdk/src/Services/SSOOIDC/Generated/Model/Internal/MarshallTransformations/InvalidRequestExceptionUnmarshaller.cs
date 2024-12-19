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
 * Do not modify this file. This file is generated from the sso-oidc-2019-06-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SSOOIDC.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SSOOIDC.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InvalidRequestException Object
    /// </summary>  
    public class InvalidRequestExceptionUnmarshaller : IJsonErrorResponseUnmarshaller<InvalidRequestException, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns></returns>
        public InvalidRequestException Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            return this.Unmarshall(context, new Amazon.Runtime.Internal.ErrorResponse(), ref reader);
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="errorResponse"></param>
        /// <param name="reader"></param>
        /// <returns></returns>
        public InvalidRequestException Unmarshall(JsonUnmarshallerContext context, Amazon.Runtime.Internal.ErrorResponse errorResponse, ref StreamingUtf8JsonReader reader)
        {
            context.Read(ref reader);

            InvalidRequestException unmarshalledObject = new InvalidRequestException(errorResponse.Message, errorResponse.InnerException,
                errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("error", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Error = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("error_description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Error_description = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }

        private static InvalidRequestExceptionUnmarshaller _instance = new InvalidRequestExceptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InvalidRequestExceptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}