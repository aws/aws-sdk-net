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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTWireless.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTWireless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for FPorts Object
    /// </summary>  
    public class FPortsUnmarshaller : IUnmarshaller<FPorts, XmlUnmarshallerContext>, IUnmarshaller<FPorts, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        FPorts IUnmarshaller<FPorts, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public FPorts Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            FPorts unmarshalledObject = new FPorts();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Applications", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ApplicationConfig, ApplicationConfigUnmarshaller>(ApplicationConfigUnmarshaller.Instance);
                    unmarshalledObject.Applications = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ClockSync", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ClockSync = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Fuota", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Fuota = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Multicast", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Multicast = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Positioning", targetDepth))
                {
                    var unmarshaller = PositioningUnmarshaller.Instance;
                    unmarshalledObject.Positioning = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static FPortsUnmarshaller _instance = new FPortsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FPortsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}