/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GuardDuty.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GuardDuty.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for NetworkInterface Object
    /// </summary>  
    public class NetworkInterfaceUnmarshaller : IUnmarshaller<NetworkInterface, XmlUnmarshallerContext>, IUnmarshaller<NetworkInterface, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        NetworkInterface IUnmarshaller<NetworkInterface, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public NetworkInterface Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            NetworkInterface unmarshalledObject = new NetworkInterface();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ipv6Addresses", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Ipv6Addresses = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("networkInterfaceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NetworkInterfaceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("privateDnsName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PrivateDnsName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("privateIpAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PrivateIpAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("privateIpAddresses", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PrivateIpAddressDetails, PrivateIpAddressDetailsUnmarshaller>(PrivateIpAddressDetailsUnmarshaller.Instance);
                    unmarshalledObject.PrivateIpAddresses = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("publicDnsName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PublicDnsName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("publicIp", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PublicIp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("securityGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<SecurityGroup, SecurityGroupUnmarshaller>(SecurityGroupUnmarshaller.Instance);
                    unmarshalledObject.SecurityGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("subnetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SubnetId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vpcId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VpcId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static NetworkInterfaceUnmarshaller _instance = new NetworkInterfaceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NetworkInterfaceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}