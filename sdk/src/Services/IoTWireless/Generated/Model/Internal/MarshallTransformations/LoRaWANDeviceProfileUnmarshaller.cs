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
    /// Response Unmarshaller for LoRaWANDeviceProfile Object
    /// </summary>  
    public class LoRaWANDeviceProfileUnmarshaller : IUnmarshaller<LoRaWANDeviceProfile, XmlUnmarshallerContext>, IUnmarshaller<LoRaWANDeviceProfile, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        LoRaWANDeviceProfile IUnmarshaller<LoRaWANDeviceProfile, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public LoRaWANDeviceProfile Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            LoRaWANDeviceProfile unmarshalledObject = new LoRaWANDeviceProfile();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ClassBTimeout", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ClassBTimeout = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ClassCTimeout", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ClassCTimeout = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FactoryPresetFreqsList", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.FactoryPresetFreqsList = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MacVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MacVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxDutyCycle", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxDutyCycle = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxEirp", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxEirp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PingSlotDr", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.PingSlotDr = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PingSlotFreq", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.PingSlotFreq = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PingSlotPeriod", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.PingSlotPeriod = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RegParamsRevision", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RegParamsRevision = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RfRegion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RfRegion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RxDataRate2", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.RxDataRate2 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RxDelay1", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.RxDelay1 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RxDrOffset1", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.RxDrOffset1 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RxFreq2", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.RxFreq2 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Supports32BitFCnt", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Supports32BitFCnt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SupportsClassB", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.SupportsClassB = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SupportsClassC", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.SupportsClassC = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SupportsJoin", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.SupportsJoin = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static LoRaWANDeviceProfileUnmarshaller _instance = new LoRaWANDeviceProfileUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LoRaWANDeviceProfileUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}