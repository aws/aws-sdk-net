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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DeviceFarm.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.DeviceFarm.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Device Object
    /// </summary>  
    public class DeviceUnmarshaller : IJsonUnmarshaller<Device, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Device Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Device unmarshalledObject = new Device();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("arn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("availability", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Availability = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("carrier", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Carrier = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("cpu", targetDepth, ref reader))
                {
                    var unmarshaller = CPUUnmarshaller.Instance;
                    unmarshalledObject.Cpu = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("fleetName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FleetName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("fleetType", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FleetType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("formFactor", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FormFactor = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("heapSize", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.HeapSize = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("image", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Image = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("instances", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<DeviceInstance, DeviceInstanceUnmarshaller>(DeviceInstanceUnmarshaller.Instance);
                    unmarshalledObject.Instances = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("manufacturer", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Manufacturer = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("memory", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.Memory = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("model", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Model = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("modelId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ModelId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("name", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("os", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Os = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("platform", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Platform = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("radio", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Radio = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("remoteAccessEnabled", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.RemoteAccessEnabled = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("remoteDebugEnabled", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.RemoteDebugEnabled = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("resolution", targetDepth, ref reader))
                {
                    var unmarshaller = ResolutionUnmarshaller.Instance;
                    unmarshalledObject.Resolution = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DeviceUnmarshaller _instance = new DeviceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeviceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}