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
    /// Response Unmarshaller for State Object
    /// </summary>  
    public class StateUnmarshaller : IUnmarshaller<State, XmlUnmarshallerContext>, IUnmarshaller<State, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        State IUnmarshaller<State, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public State Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            State unmarshalledObject = new State();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("onEnter", targetDepth))
                {
                    var unmarshaller = OnEnterLifecycleUnmarshaller.Instance;
                    unmarshalledObject.OnEnter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("onExit", targetDepth))
                {
                    var unmarshaller = OnExitLifecycleUnmarshaller.Instance;
                    unmarshalledObject.OnExit = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("onInput", targetDepth))
                {
                    var unmarshaller = OnInputLifecycleUnmarshaller.Instance;
                    unmarshalledObject.OnInput = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("stateName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StateName = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static StateUnmarshaller _instance = new StateUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StateUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}