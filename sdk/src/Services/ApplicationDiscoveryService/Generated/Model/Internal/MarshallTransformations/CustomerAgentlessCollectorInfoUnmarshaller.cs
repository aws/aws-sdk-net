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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApplicationDiscoveryService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ApplicationDiscoveryService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CustomerAgentlessCollectorInfo Object
    /// </summary>  
    public class CustomerAgentlessCollectorInfoUnmarshaller : IUnmarshaller<CustomerAgentlessCollectorInfo, XmlUnmarshallerContext>, IUnmarshaller<CustomerAgentlessCollectorInfo, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CustomerAgentlessCollectorInfo IUnmarshaller<CustomerAgentlessCollectorInfo, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public CustomerAgentlessCollectorInfo Unmarshall(JsonUnmarshallerContext context)
        {
            CustomerAgentlessCollectorInfo unmarshalledObject = new CustomerAgentlessCollectorInfo();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("activeAgentlessCollectors", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ActiveAgentlessCollectors = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("denyListedAgentlessCollectors", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.DenyListedAgentlessCollectors = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("healthyAgentlessCollectors", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.HealthyAgentlessCollectors = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("shutdownAgentlessCollectors", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ShutdownAgentlessCollectors = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("totalAgentlessCollectors", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TotalAgentlessCollectors = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("unhealthyAgentlessCollectors", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.UnhealthyAgentlessCollectors = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("unknownAgentlessCollectors", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.UnknownAgentlessCollectors = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CustomerAgentlessCollectorInfoUnmarshaller _instance = new CustomerAgentlessCollectorInfoUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CustomerAgentlessCollectorInfoUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}