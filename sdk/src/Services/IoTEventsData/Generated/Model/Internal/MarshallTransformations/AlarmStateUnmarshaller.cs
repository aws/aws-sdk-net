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
 * Do not modify this file. This file is generated from the iotevents-data-2018-10-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTEventsData.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTEventsData.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AlarmState Object
    /// </summary>  
    public class AlarmStateUnmarshaller : IUnmarshaller<AlarmState, XmlUnmarshallerContext>, IUnmarshaller<AlarmState, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AlarmState IUnmarshaller<AlarmState, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AlarmState Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AlarmState unmarshalledObject = new AlarmState();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("customerAction", targetDepth))
                {
                    var unmarshaller = CustomerActionUnmarshaller.Instance;
                    unmarshalledObject.CustomerAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ruleEvaluation", targetDepth))
                {
                    var unmarshaller = RuleEvaluationUnmarshaller.Instance;
                    unmarshalledObject.RuleEvaluation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("stateName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StateName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("systemEvent", targetDepth))
                {
                    var unmarshaller = SystemEventUnmarshaller.Instance;
                    unmarshalledObject.SystemEvent = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AlarmStateUnmarshaller _instance = new AlarmStateUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AlarmStateUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}