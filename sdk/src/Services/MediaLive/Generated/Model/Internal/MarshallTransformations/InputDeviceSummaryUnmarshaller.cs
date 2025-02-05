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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InputDeviceSummary Object
    /// </summary>  
    public class InputDeviceSummaryUnmarshaller : IJsonUnmarshaller<InputDeviceSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public InputDeviceSummary Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            InputDeviceSummary unmarshalledObject = new InputDeviceSummary();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("availabilityZone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AvailabilityZone = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("connectionState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConnectionState = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("deviceSettingsSyncState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeviceSettingsSyncState = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("deviceUpdateStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeviceUpdateStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("hdDeviceSettings", targetDepth))
                {
                    var unmarshaller = InputDeviceHdSettingsUnmarshaller.Instance;
                    unmarshalledObject.HdDeviceSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("macAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MacAddress = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("medialiveInputArns", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.MedialiveInputArns = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("networkSettings", targetDepth))
                {
                    var unmarshaller = InputDeviceNetworkSettingsUnmarshaller.Instance;
                    unmarshalledObject.NetworkSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("outputType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OutputType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("serialNumber", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SerialNumber = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("uhdDeviceSettings", targetDepth))
                {
                    var unmarshaller = InputDeviceUhdSettingsUnmarshaller.Instance;
                    unmarshalledObject.UhdDeviceSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static InputDeviceSummaryUnmarshaller _instance = new InputDeviceSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InputDeviceSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}