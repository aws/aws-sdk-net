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
    /// Response Unmarshaller for AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv6AddressesDetails Object
    /// </summary>  
    public class AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv6AddressesDetailsUnmarshaller : IUnmarshaller<AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv6AddressesDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv6AddressesDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv6AddressesDetails IUnmarshaller<AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv6AddressesDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv6AddressesDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv6AddressesDetails unmarshalledObject = new AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv6AddressesDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Ipv6Address", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Ipv6Address = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv6AddressesDetailsUnmarshaller _instance = new AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv6AddressesDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv6AddressesDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}