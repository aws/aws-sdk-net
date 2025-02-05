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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsEc2LaunchTemplateDataNetworkInterfaceSetDetails Object
    /// </summary>  
    public class AwsEc2LaunchTemplateDataNetworkInterfaceSetDetailsUnmarshaller : IJsonUnmarshaller<AwsEc2LaunchTemplateDataNetworkInterfaceSetDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AwsEc2LaunchTemplateDataNetworkInterfaceSetDetails Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AwsEc2LaunchTemplateDataNetworkInterfaceSetDetails unmarshalledObject = new AwsEc2LaunchTemplateDataNetworkInterfaceSetDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AssociateCarrierIpAddress", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.AssociateCarrierIpAddress = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AssociatePublicIpAddress", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.AssociatePublicIpAddress = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DeleteOnTermination", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.DeleteOnTermination = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DeviceIndex", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.DeviceIndex = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Groups", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Groups = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InterfaceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InterfaceType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Ipv4PrefixCount", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Ipv4PrefixCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Ipv4Prefixes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv4PrefixesDetails, AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv4PrefixesDetailsUnmarshaller>(AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv4PrefixesDetailsUnmarshaller.Instance);
                    unmarshalledObject.Ipv4Prefixes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Ipv6AddressCount", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Ipv6AddressCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Ipv6Addresses", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv6AddressesDetails, AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv6AddressesDetailsUnmarshaller>(AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv6AddressesDetailsUnmarshaller.Instance);
                    unmarshalledObject.Ipv6Addresses = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Ipv6PrefixCount", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Ipv6PrefixCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Ipv6Prefixes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv6PrefixesDetails, AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv6PrefixesDetailsUnmarshaller>(AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv6PrefixesDetailsUnmarshaller.Instance);
                    unmarshalledObject.Ipv6Prefixes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NetworkCardIndex", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.NetworkCardIndex = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NetworkInterfaceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NetworkInterfaceId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PrivateIpAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PrivateIpAddress = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PrivateIpAddresses", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEc2LaunchTemplateDataNetworkInterfaceSetPrivateIpAddressesDetails, AwsEc2LaunchTemplateDataNetworkInterfaceSetPrivateIpAddressesDetailsUnmarshaller>(AwsEc2LaunchTemplateDataNetworkInterfaceSetPrivateIpAddressesDetailsUnmarshaller.Instance);
                    unmarshalledObject.PrivateIpAddresses = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SecondaryPrivateIpAddressCount", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.SecondaryPrivateIpAddressCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SubnetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SubnetId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AwsEc2LaunchTemplateDataNetworkInterfaceSetDetailsUnmarshaller _instance = new AwsEc2LaunchTemplateDataNetworkInterfaceSetDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsEc2LaunchTemplateDataNetworkInterfaceSetDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}