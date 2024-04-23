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
 * Do not modify this file. This file is generated from the backup-gateway-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.BackupGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BackupGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GatewayDetails Object
    /// </summary>  
    public class GatewayDetailsUnmarshaller : IUnmarshaller<GatewayDetails, XmlUnmarshallerContext>, IUnmarshaller<GatewayDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        GatewayDetails IUnmarshaller<GatewayDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public GatewayDetails Unmarshall(JsonUnmarshallerContext context)
        {
            GatewayDetails unmarshalledObject = new GatewayDetails();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("GatewayArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GatewayArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GatewayDisplayName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GatewayDisplayName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GatewayType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GatewayType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HypervisorId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HypervisorId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastSeenTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastSeenTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaintenanceStartTime", targetDepth))
                {
                    var unmarshaller = MaintenanceStartTimeUnmarshaller.Instance;
                    unmarshalledObject.MaintenanceStartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NextUpdateAvailabilityTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.NextUpdateAvailabilityTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VpcEndpoint", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VpcEndpoint = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static GatewayDetailsUnmarshaller _instance = new GatewayDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GatewayDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618