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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pinpoint.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Activity Object
    /// </summary>  
    public class ActivityUnmarshaller : IUnmarshaller<Activity, XmlUnmarshallerContext>, IUnmarshaller<Activity, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Activity IUnmarshaller<Activity, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Activity Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Activity unmarshalledObject = new Activity();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ConditionalSplit", targetDepth))
                {
                    var unmarshaller = ConditionalSplitActivityUnmarshaller.Instance;
                    unmarshalledObject.ConditionalSplit = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CUSTOM", targetDepth))
                {
                    var unmarshaller = CustomMessageActivityUnmarshaller.Instance;
                    unmarshalledObject.CUSTOM = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EMAIL", targetDepth))
                {
                    var unmarshaller = EmailMessageActivityUnmarshaller.Instance;
                    unmarshalledObject.EMAIL = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Holdout", targetDepth))
                {
                    var unmarshaller = HoldoutActivityUnmarshaller.Instance;
                    unmarshalledObject.Holdout = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MultiCondition", targetDepth))
                {
                    var unmarshaller = MultiConditionalSplitActivityUnmarshaller.Instance;
                    unmarshalledObject.MultiCondition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PUSH", targetDepth))
                {
                    var unmarshaller = PushMessageActivityUnmarshaller.Instance;
                    unmarshalledObject.PUSH = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RandomSplit", targetDepth))
                {
                    var unmarshaller = RandomSplitActivityUnmarshaller.Instance;
                    unmarshalledObject.RandomSplit = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SMS", targetDepth))
                {
                    var unmarshaller = SMSMessageActivityUnmarshaller.Instance;
                    unmarshalledObject.SMS = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Wait", targetDepth))
                {
                    var unmarshaller = WaitActivityUnmarshaller.Instance;
                    unmarshalledObject.Wait = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ActivityUnmarshaller _instance = new ActivityUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ActivityUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}