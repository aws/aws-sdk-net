/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Inspector.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Inspector.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AssessmentRunNotification Object
    /// </summary>  
    public class AssessmentRunNotificationUnmarshaller : IUnmarshaller<AssessmentRunNotification, XmlUnmarshallerContext>, IUnmarshaller<AssessmentRunNotification, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AssessmentRunNotification IUnmarshaller<AssessmentRunNotification, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AssessmentRunNotification Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AssessmentRunNotification unmarshalledObject = new AssessmentRunNotification();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("date", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.Date = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("error", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Error = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("event", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Event = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("message", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Message = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("snsPublishStatusCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SnsPublishStatusCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("snsTopicArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SnsTopicArn = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AssessmentRunNotificationUnmarshaller _instance = new AssessmentRunNotificationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AssessmentRunNotificationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}