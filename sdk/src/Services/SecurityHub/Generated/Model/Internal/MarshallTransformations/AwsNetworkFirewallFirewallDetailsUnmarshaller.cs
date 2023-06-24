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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsNetworkFirewallFirewallDetails Object
    /// </summary>  
    public class AwsNetworkFirewallFirewallDetailsUnmarshaller : IUnmarshaller<AwsNetworkFirewallFirewallDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsNetworkFirewallFirewallDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsNetworkFirewallFirewallDetails IUnmarshaller<AwsNetworkFirewallFirewallDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsNetworkFirewallFirewallDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsNetworkFirewallFirewallDetails unmarshalledObject = new AwsNetworkFirewallFirewallDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DeleteProtection", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DeleteProtection = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FirewallArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FirewallArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FirewallId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FirewallId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FirewallName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FirewallName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FirewallPolicyArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FirewallPolicyArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FirewallPolicyChangeProtection", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.FirewallPolicyChangeProtection = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubnetChangeProtection", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.SubnetChangeProtection = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubnetMappings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsNetworkFirewallFirewallSubnetMappingsDetails, AwsNetworkFirewallFirewallSubnetMappingsDetailsUnmarshaller>(AwsNetworkFirewallFirewallSubnetMappingsDetailsUnmarshaller.Instance);
                    unmarshalledObject.SubnetMappings = unmarshaller.Unmarshall(context);
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


        private static AwsNetworkFirewallFirewallDetailsUnmarshaller _instance = new AwsNetworkFirewallFirewallDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsNetworkFirewallFirewallDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}