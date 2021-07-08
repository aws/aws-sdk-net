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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.FMS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.FMS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for NetworkFirewallMissingExpectedRoutesViolation Object
    /// </summary>  
    public class NetworkFirewallMissingExpectedRoutesViolationUnmarshaller : IUnmarshaller<NetworkFirewallMissingExpectedRoutesViolation, XmlUnmarshallerContext>, IUnmarshaller<NetworkFirewallMissingExpectedRoutesViolation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        NetworkFirewallMissingExpectedRoutesViolation IUnmarshaller<NetworkFirewallMissingExpectedRoutesViolation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public NetworkFirewallMissingExpectedRoutesViolation Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            NetworkFirewallMissingExpectedRoutesViolation unmarshalledObject = new NetworkFirewallMissingExpectedRoutesViolation();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ExpectedRoutes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ExpectedRoute, ExpectedRouteUnmarshaller>(ExpectedRouteUnmarshaller.Instance);
                    unmarshalledObject.ExpectedRoutes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ViolationTarget", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ViolationTarget = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VpcId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VpcId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static NetworkFirewallMissingExpectedRoutesViolationUnmarshaller _instance = new NetworkFirewallMissingExpectedRoutesViolationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NetworkFirewallMissingExpectedRoutesViolationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}