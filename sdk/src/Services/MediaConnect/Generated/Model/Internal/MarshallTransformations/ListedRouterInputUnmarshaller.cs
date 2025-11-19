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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ListedRouterInput Object
    /// </summary>  
    public class ListedRouterInputUnmarshaller : IUnmarshaller<ListedRouterInput, XmlUnmarshallerContext>, IUnmarshaller<ListedRouterInput, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ListedRouterInput IUnmarshaller<ListedRouterInput, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ListedRouterInput Unmarshall(JsonUnmarshallerContext context)
        {
            ListedRouterInput unmarshalledObject = new ListedRouterInput();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("availabilityZone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AvailabilityZone = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inputType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InputType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maintenanceSchedule", targetDepth))
                {
                    var unmarshaller = MaintenanceScheduleUnmarshaller.Instance;
                    unmarshalledObject.MaintenanceSchedule = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maintenanceScheduleType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MaintenanceScheduleType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maximumBitrate", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.MaximumBitrate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("messageCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MessageCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("networkInterfaceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NetworkInterfaceArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("regionName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RegionName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("routedOutputs", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.RoutedOutputs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("routingScope", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoutingScope = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("state", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.State = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("updatedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.UpdatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ListedRouterInputUnmarshaller _instance = new ListedRouterInputUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListedRouterInputUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}