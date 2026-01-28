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
    /// Response Unmarshaller for Flow Object
    /// </summary>  
    public class FlowUnmarshaller : IUnmarshaller<Flow, XmlUnmarshallerContext>, IUnmarshaller<Flow, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Flow IUnmarshaller<Flow, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Flow Unmarshall(JsonUnmarshallerContext context)
        {
            Flow unmarshalledObject = new Flow();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("availabilityZone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AvailabilityZone = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("egressIp", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EgressIp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("encodingConfig", targetDepth))
                {
                    var unmarshaller = EncodingConfigUnmarshaller.Instance;
                    unmarshalledObject.EncodingConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("entitlements", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Entitlement, EntitlementUnmarshaller>(EntitlementUnmarshaller.Instance);
                    unmarshalledObject.Entitlements = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("flowArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FlowArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("flowSize", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FlowSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maintenance", targetDepth))
                {
                    var unmarshaller = MaintenanceUnmarshaller.Instance;
                    unmarshalledObject.Maintenance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mediaStreams", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MediaStream, MediaStreamUnmarshaller>(MediaStreamUnmarshaller.Instance);
                    unmarshalledObject.MediaStreams = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ndiConfig", targetDepth))
                {
                    var unmarshaller = NdiConfigUnmarshaller.Instance;
                    unmarshalledObject.NdiConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("outputs", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Output, OutputUnmarshaller>(OutputUnmarshaller.Instance);
                    unmarshalledObject.Outputs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("source", targetDepth))
                {
                    var unmarshaller = SourceUnmarshaller.Instance;
                    unmarshalledObject.Source = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceFailoverConfig", targetDepth))
                {
                    var unmarshaller = FailoverConfigUnmarshaller.Instance;
                    unmarshalledObject.SourceFailoverConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceMonitoringConfig", targetDepth))
                {
                    var unmarshaller = MonitoringConfigUnmarshaller.Instance;
                    unmarshalledObject.SourceMonitoringConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sources", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Source, SourceUnmarshaller>(SourceUnmarshaller.Instance);
                    unmarshalledObject.Sources = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vpcInterfaces", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<VpcInterface, VpcInterfaceUnmarshaller>(VpcInterfaceUnmarshaller.Instance);
                    unmarshalledObject.VpcInterfaces = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static FlowUnmarshaller _instance = new FlowUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FlowUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}