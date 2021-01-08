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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleSystemsManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for OpsItemLimitExceededException Object
    /// </summary>  
    public class OpsItemLimitExceededExceptionUnmarshaller : IErrorResponseUnmarshaller<OpsItemLimitExceededException, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public OpsItemLimitExceededException Unmarshall(JsonUnmarshallerContext context)
        {
            return this.Unmarshall(context, new ErrorResponse());
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="errorResponse"></param>
        /// <returns></returns>
        public OpsItemLimitExceededException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
        {
            context.Read();

            OpsItemLimitExceededException unmarshalledObject = new OpsItemLimitExceededException(errorResponse.Message, errorResponse.InnerException,
                errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Limit", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Limit = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LimitType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LimitType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceTypes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ResourceTypes = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }

        private static OpsItemLimitExceededExceptionUnmarshaller _instance = new OpsItemLimitExceededExceptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OpsItemLimitExceededExceptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}