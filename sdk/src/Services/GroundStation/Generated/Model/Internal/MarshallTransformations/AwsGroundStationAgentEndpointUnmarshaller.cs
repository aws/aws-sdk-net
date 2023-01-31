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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GroundStation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GroundStation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsGroundStationAgentEndpoint Object
    /// </summary>  
    public class AwsGroundStationAgentEndpointUnmarshaller : IUnmarshaller<AwsGroundStationAgentEndpoint, XmlUnmarshallerContext>, IUnmarshaller<AwsGroundStationAgentEndpoint, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsGroundStationAgentEndpoint IUnmarshaller<AwsGroundStationAgentEndpoint, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsGroundStationAgentEndpoint Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsGroundStationAgentEndpoint unmarshalledObject = new AwsGroundStationAgentEndpoint();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("agentStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AgentStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("auditResults", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AuditResults = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("egressAddress", targetDepth))
                {
                    var unmarshaller = ConnectionDetailsUnmarshaller.Instance;
                    unmarshalledObject.EgressAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ingressAddress", targetDepth))
                {
                    var unmarshaller = RangedConnectionDetailsUnmarshaller.Instance;
                    unmarshalledObject.IngressAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsGroundStationAgentEndpointUnmarshaller _instance = new AwsGroundStationAgentEndpointUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsGroundStationAgentEndpointUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}