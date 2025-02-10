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
    /// Response Unmarshaller for AwsEc2NetworkInterfaceDetails Object
    /// </summary>  
    public class AwsEc2NetworkInterfaceDetailsUnmarshaller : IJsonUnmarshaller<AwsEc2NetworkInterfaceDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AwsEc2NetworkInterfaceDetails Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AwsEc2NetworkInterfaceDetails unmarshalledObject = new AwsEc2NetworkInterfaceDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Attachment", targetDepth))
                {
                    var unmarshaller = AwsEc2NetworkInterfaceAttachmentUnmarshaller.Instance;
                    unmarshalledObject.Attachment = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("IpV6Addresses", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEc2NetworkInterfaceIpV6AddressDetail, AwsEc2NetworkInterfaceIpV6AddressDetailUnmarshaller>(AwsEc2NetworkInterfaceIpV6AddressDetailUnmarshaller.Instance);
                    unmarshalledObject.IpV6Addresses = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NetworkInterfaceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NetworkInterfaceId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PrivateIpAddresses", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEc2NetworkInterfacePrivateIpAddressDetail, AwsEc2NetworkInterfacePrivateIpAddressDetailUnmarshaller>(AwsEc2NetworkInterfacePrivateIpAddressDetailUnmarshaller.Instance);
                    unmarshalledObject.PrivateIpAddresses = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PublicDnsName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PublicDnsName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PublicIp", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PublicIp = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SecurityGroups", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEc2NetworkInterfaceSecurityGroup, AwsEc2NetworkInterfaceSecurityGroupUnmarshaller>(AwsEc2NetworkInterfaceSecurityGroupUnmarshaller.Instance);
                    unmarshalledObject.SecurityGroups = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SourceDestCheck", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.SourceDestCheck = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AwsEc2NetworkInterfaceDetailsUnmarshaller _instance = new AwsEc2NetworkInterfaceDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsEc2NetworkInterfaceDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}