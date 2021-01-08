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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTEvents.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTEvents.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Action Object
    /// </summary>  
    public class ActionUnmarshaller : IUnmarshaller<Action, XmlUnmarshallerContext>, IUnmarshaller<Action, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Action IUnmarshaller<Action, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Action Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Action unmarshalledObject = new Action();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("clearTimer", targetDepth))
                {
                    var unmarshaller = ClearTimerActionUnmarshaller.Instance;
                    unmarshalledObject.ClearTimer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dynamoDB", targetDepth))
                {
                    var unmarshaller = DynamoDBActionUnmarshaller.Instance;
                    unmarshalledObject.DynamoDB = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dynamoDBv2", targetDepth))
                {
                    var unmarshaller = DynamoDBv2ActionUnmarshaller.Instance;
                    unmarshalledObject.DynamoDBv2 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("firehose", targetDepth))
                {
                    var unmarshaller = FirehoseActionUnmarshaller.Instance;
                    unmarshalledObject.Firehose = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("iotEvents", targetDepth))
                {
                    var unmarshaller = IotEventsActionUnmarshaller.Instance;
                    unmarshalledObject.IotEvents = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("iotSiteWise", targetDepth))
                {
                    var unmarshaller = IotSiteWiseActionUnmarshaller.Instance;
                    unmarshalledObject.IotSiteWise = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("iotTopicPublish", targetDepth))
                {
                    var unmarshaller = IotTopicPublishActionUnmarshaller.Instance;
                    unmarshalledObject.IotTopicPublish = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lambda", targetDepth))
                {
                    var unmarshaller = LambdaActionUnmarshaller.Instance;
                    unmarshalledObject.Lambda = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resetTimer", targetDepth))
                {
                    var unmarshaller = ResetTimerActionUnmarshaller.Instance;
                    unmarshalledObject.ResetTimer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("setTimer", targetDepth))
                {
                    var unmarshaller = SetTimerActionUnmarshaller.Instance;
                    unmarshalledObject.SetTimer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("setVariable", targetDepth))
                {
                    var unmarshaller = SetVariableActionUnmarshaller.Instance;
                    unmarshalledObject.SetVariable = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sns", targetDepth))
                {
                    var unmarshaller = SNSTopicPublishActionUnmarshaller.Instance;
                    unmarshalledObject.Sns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sqs", targetDepth))
                {
                    var unmarshaller = SqsActionUnmarshaller.Instance;
                    unmarshalledObject.Sqs = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ActionUnmarshaller _instance = new ActionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ActionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}