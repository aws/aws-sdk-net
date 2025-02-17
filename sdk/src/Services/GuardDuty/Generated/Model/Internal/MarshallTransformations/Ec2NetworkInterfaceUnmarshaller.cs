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

#pragma warning disable CS0612,CS0618
namespace Amazon.GuardDuty.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Ec2NetworkInterface Object
    /// </summary>  
    public class Ec2NetworkInterfaceUnmarshaller : IUnmarshaller<Ec2NetworkInterface, XmlUnmarshallerContext>, IUnmarshaller<Ec2NetworkInterface, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Ec2NetworkInterface IUnmarshaller<Ec2NetworkInterface, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Ec2NetworkInterface Unmarshall(JsonUnmarshallerContext context)
        {
            Ec2NetworkInterface unmarshalledObject = new Ec2NetworkInterface();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ipv6Addresses", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Ipv6Addresses = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("privateIpAddresses", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PrivateIpAddressDetails, PrivateIpAddressDetailsUnmarshaller>(PrivateIpAddressDetailsUnmarshaller.Instance);
                    unmarshalledObject.PrivateIpAddresses = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("subNetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SubNetId = unmarshaller.Unmarshall(context);
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


        private static Ec2NetworkInterfaceUnmarshaller _instance = new Ec2NetworkInterfaceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static Ec2NetworkInterfaceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}