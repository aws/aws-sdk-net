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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.VPCLattice.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.VPCLattice.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for HealthCheckConfig Object
    /// </summary>  
    public class HealthCheckConfigUnmarshaller : IUnmarshaller<HealthCheckConfig, XmlUnmarshallerContext>, IUnmarshaller<HealthCheckConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        HealthCheckConfig IUnmarshaller<HealthCheckConfig, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public HealthCheckConfig Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            HealthCheckConfig unmarshalledObject = new HealthCheckConfig();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("enabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Enabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("healthCheckIntervalSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.HealthCheckIntervalSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("healthCheckTimeoutSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.HealthCheckTimeoutSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("healthyThresholdCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.HealthyThresholdCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("matcher", targetDepth))
                {
                    var unmarshaller = MatcherUnmarshaller.Instance;
                    unmarshalledObject.Matcher = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("path", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Path = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("port", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Port = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("protocol", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Protocol = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("protocolVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProtocolVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("unhealthyThresholdCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.UnhealthyThresholdCount = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static HealthCheckConfigUnmarshaller _instance = new HealthCheckConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static HealthCheckConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}