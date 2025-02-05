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
 * Do not modify this file. This file is generated from the networkflowmonitor-2023-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkFlowMonitor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.NetworkFlowMonitor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MonitorTopContributorsRow Object
    /// </summary>  
    public class MonitorTopContributorsRowUnmarshaller : IJsonUnmarshaller<MonitorTopContributorsRow, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public MonitorTopContributorsRow Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            MonitorTopContributorsRow unmarshalledObject = new MonitorTopContributorsRow();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("destinationCategory", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DestinationCategory = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dnatIp", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DnatIp = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("kubernetesMetadata", targetDepth))
                {
                    var unmarshaller = KubernetesMetadataUnmarshaller.Instance;
                    unmarshalledObject.KubernetesMetadata = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("localAz", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LocalAz = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("localInstanceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LocalInstanceArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("localInstanceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LocalInstanceId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("localIp", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LocalIp = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("localRegion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LocalRegion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("localSubnetArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LocalSubnetArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("localSubnetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LocalSubnetId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("localVpcArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LocalVpcArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("localVpcId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LocalVpcId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("remoteAz", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RemoteAz = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("remoteInstanceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RemoteInstanceArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("remoteInstanceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RemoteInstanceId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("remoteIp", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RemoteIp = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("remoteRegion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RemoteRegion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("remoteSubnetArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RemoteSubnetArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("remoteSubnetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RemoteSubnetId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("remoteVpcArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RemoteVpcArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("remoteVpcId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RemoteVpcId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("snatIp", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SnatIp = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("targetPort", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.TargetPort = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("traversedConstructs", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<TraversedComponent, TraversedComponentUnmarshaller>(TraversedComponentUnmarshaller.Instance);
                    unmarshalledObject.TraversedConstructs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("value", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.Value = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static MonitorTopContributorsRowUnmarshaller _instance = new MonitorTopContributorsRowUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MonitorTopContributorsRowUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}