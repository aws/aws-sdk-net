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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTFleetWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTFleetWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ObdSignal Object
    /// </summary>  
    public class ObdSignalUnmarshaller : IUnmarshaller<ObdSignal, XmlUnmarshallerContext>, IUnmarshaller<ObdSignal, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ObdSignal IUnmarshaller<ObdSignal, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ObdSignal Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ObdSignal unmarshalledObject = new ObdSignal();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("bitMaskLength", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.BitMaskLength = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("bitRightShift", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.BitRightShift = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("byteLength", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ByteLength = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("offset", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.Offset = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pid", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Pid = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pidResponseLength", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.PidResponseLength = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scaling", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.Scaling = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("serviceMode", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ServiceMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("startByte", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.StartByte = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ObdSignalUnmarshaller _instance = new ObdSignalUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ObdSignalUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}