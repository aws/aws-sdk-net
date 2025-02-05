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
    /// Response Unmarshaller for AwsEc2ClientVpnEndpointDetails Object
    /// </summary>  
    public class AwsEc2ClientVpnEndpointDetailsUnmarshaller : IJsonUnmarshaller<AwsEc2ClientVpnEndpointDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AwsEc2ClientVpnEndpointDetails Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AwsEc2ClientVpnEndpointDetails unmarshalledObject = new AwsEc2ClientVpnEndpointDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AuthenticationOptions", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEc2ClientVpnEndpointAuthenticationOptionsDetails, AwsEc2ClientVpnEndpointAuthenticationOptionsDetailsUnmarshaller>(AwsEc2ClientVpnEndpointAuthenticationOptionsDetailsUnmarshaller.Instance);
                    unmarshalledObject.AuthenticationOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ClientCidrBlock", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClientCidrBlock = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ClientConnectOptions", targetDepth))
                {
                    var unmarshaller = AwsEc2ClientVpnEndpointClientConnectOptionsDetailsUnmarshaller.Instance;
                    unmarshalledObject.ClientConnectOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ClientLoginBannerOptions", targetDepth))
                {
                    var unmarshaller = AwsEc2ClientVpnEndpointClientLoginBannerOptionsDetailsUnmarshaller.Instance;
                    unmarshalledObject.ClientLoginBannerOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ClientVpnEndpointId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClientVpnEndpointId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ConnectionLogOptions", targetDepth))
                {
                    var unmarshaller = AwsEc2ClientVpnEndpointConnectionLogOptionsDetailsUnmarshaller.Instance;
                    unmarshalledObject.ConnectionLogOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DnsServer", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.DnsServer = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SecurityGroupIdSet", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SecurityGroupIdSet = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SelfServicePortalUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SelfServicePortalUrl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ServerCertificateArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServerCertificateArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SessionTimeoutHours", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.SessionTimeoutHours = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SplitTunnel", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.SplitTunnel = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TransportProtocol", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TransportProtocol = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VpcId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VpcId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VpnPort", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.VpnPort = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AwsEc2ClientVpnEndpointDetailsUnmarshaller _instance = new AwsEc2ClientVpnEndpointDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsEc2ClientVpnEndpointDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}