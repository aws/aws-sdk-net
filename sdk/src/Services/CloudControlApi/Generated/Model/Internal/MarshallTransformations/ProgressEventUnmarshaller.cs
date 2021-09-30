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
 * Do not modify this file. This file is generated from the cloudcontrol-2021-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudControlApi.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CloudControlApi.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ProgressEvent Object
    /// </summary>  
    public class ProgressEventUnmarshaller : IUnmarshaller<ProgressEvent, XmlUnmarshallerContext>, IUnmarshaller<ProgressEvent, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ProgressEvent IUnmarshaller<ProgressEvent, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ProgressEvent Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ProgressEvent unmarshalledObject = new ProgressEvent();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ErrorCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ErrorCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EventTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.EventTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Identifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Identifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Operation", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Operation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OperationStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OperationStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RequestToken", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RequestToken = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceModel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResourceModel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RetryAfter", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.RetryAfter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StatusMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StatusMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TypeName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TypeName = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ProgressEventUnmarshaller _instance = new ProgressEventUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ProgressEventUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}