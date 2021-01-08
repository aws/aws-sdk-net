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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.StepFunctions.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.StepFunctions.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ActivityScheduledEventDetails Object
    /// </summary>  
    public class ActivityScheduledEventDetailsUnmarshaller : IUnmarshaller<ActivityScheduledEventDetails, XmlUnmarshallerContext>, IUnmarshaller<ActivityScheduledEventDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ActivityScheduledEventDetails IUnmarshaller<ActivityScheduledEventDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ActivityScheduledEventDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ActivityScheduledEventDetails unmarshalledObject = new ActivityScheduledEventDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("heartbeatInSeconds", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.HeartbeatInSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("input", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Input = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inputDetails", targetDepth))
                {
                    var unmarshaller = HistoryEventExecutionDataDetailsUnmarshaller.Instance;
                    unmarshalledObject.InputDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resource", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Resource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timeoutInSeconds", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.TimeoutInSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ActivityScheduledEventDetailsUnmarshaller _instance = new ActivityScheduledEventDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ActivityScheduledEventDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}