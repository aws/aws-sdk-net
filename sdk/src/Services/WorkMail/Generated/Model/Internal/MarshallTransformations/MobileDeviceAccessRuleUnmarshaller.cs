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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkMail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.WorkMail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MobileDeviceAccessRule Object
    /// </summary>  
    public class MobileDeviceAccessRuleUnmarshaller : IJsonUnmarshaller<MobileDeviceAccessRule, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public MobileDeviceAccessRule Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            MobileDeviceAccessRule unmarshalledObject = new MobileDeviceAccessRule();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("DateCreated", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.DateCreated = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DateModified", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.DateModified = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DeviceModels", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.DeviceModels = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DeviceOperatingSystems", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.DeviceOperatingSystems = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DeviceTypes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.DeviceTypes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DeviceUserAgents", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.DeviceUserAgents = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Effect", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Effect = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MobileDeviceAccessRuleId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MobileDeviceAccessRuleId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NotDeviceModels", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.NotDeviceModels = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NotDeviceOperatingSystems", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.NotDeviceOperatingSystems = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NotDeviceTypes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.NotDeviceTypes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NotDeviceUserAgents", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.NotDeviceUserAgents = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static MobileDeviceAccessRuleUnmarshaller _instance = new MobileDeviceAccessRuleUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MobileDeviceAccessRuleUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}