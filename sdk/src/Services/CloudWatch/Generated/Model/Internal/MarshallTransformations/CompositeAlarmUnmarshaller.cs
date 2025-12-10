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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CompositeAlarm Object
    /// </summary>  
    public class CompositeAlarmUnmarshaller : IUnmarshaller<CompositeAlarm, XmlUnmarshallerContext>, IUnmarshaller<CompositeAlarm, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CompositeAlarm IUnmarshaller<CompositeAlarm, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public CompositeAlarm Unmarshall(JsonUnmarshallerContext context)
        {
            CompositeAlarm unmarshalledObject = new CompositeAlarm();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ActionsEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ActionsEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ActionsSuppressedBy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ActionsSuppressedBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ActionsSuppressedReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ActionsSuppressedReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ActionsSuppressor", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ActionsSuppressor = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ActionsSuppressorExtensionPeriod", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ActionsSuppressorExtensionPeriod = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ActionsSuppressorWaitPeriod", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ActionsSuppressorWaitPeriod = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AlarmActions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AlarmActions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AlarmArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AlarmArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AlarmConfigurationUpdatedTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.AlarmConfigurationUpdatedTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AlarmDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AlarmDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AlarmName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AlarmName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AlarmRule", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AlarmRule = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InsufficientDataActions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.InsufficientDataActions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OKActions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.OKActions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StateReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StateReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StateReasonData", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StateReasonData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StateTransitionedTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.StateTransitionedTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StateUpdatedTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.StateUpdatedTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StateValue", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StateValue = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CompositeAlarmUnmarshaller _instance = new CompositeAlarmUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CompositeAlarmUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}