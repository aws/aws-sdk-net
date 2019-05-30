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
    /// Response Unmarshaller for DetectorState Object
    /// </summary>  
    public class DetectorStateUnmarshaller : IUnmarshaller<DetectorState, XmlUnmarshallerContext>, IUnmarshaller<DetectorState, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DetectorState IUnmarshaller<DetectorState, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DetectorState Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DetectorState unmarshalledObject = new DetectorState();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("stateName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StateName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timers", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Timer, TimerUnmarshaller>(TimerUnmarshaller.Instance);
                    unmarshalledObject.Timers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("variables", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Variable, VariableUnmarshaller>(VariableUnmarshaller.Instance);
                    unmarshalledObject.Variables = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DetectorStateUnmarshaller _instance = new DetectorStateUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DetectorStateUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}