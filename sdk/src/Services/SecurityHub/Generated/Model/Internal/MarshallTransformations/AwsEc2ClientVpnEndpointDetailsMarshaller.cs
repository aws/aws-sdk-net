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
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsEc2ClientVpnEndpointDetails Marshaller
    /// </summary>
    public class AwsEc2ClientVpnEndpointDetailsMarshaller : IRequestMarshaller<AwsEc2ClientVpnEndpointDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEc2ClientVpnEndpointDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAuthenticationOptions())
            {
                context.Writer.WritePropertyName("AuthenticationOptions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAuthenticationOptionsListValue in requestObject.AuthenticationOptions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEc2ClientVpnEndpointAuthenticationOptionsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectAuthenticationOptionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetClientCidrBlock())
            {
                context.Writer.WritePropertyName("ClientCidrBlock");
                context.Writer.Write(requestObject.ClientCidrBlock);
            }

            if(requestObject.IsSetClientConnectOptions())
            {
                context.Writer.WritePropertyName("ClientConnectOptions");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2ClientVpnEndpointClientConnectOptionsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.ClientConnectOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetClientLoginBannerOptions())
            {
                context.Writer.WritePropertyName("ClientLoginBannerOptions");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2ClientVpnEndpointClientLoginBannerOptionsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.ClientLoginBannerOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetClientVpnEndpointId())
            {
                context.Writer.WritePropertyName("ClientVpnEndpointId");
                context.Writer.Write(requestObject.ClientVpnEndpointId);
            }

            if(requestObject.IsSetConnectionLogOptions())
            {
                context.Writer.WritePropertyName("ConnectionLogOptions");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2ClientVpnEndpointConnectionLogOptionsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.ConnectionLogOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetDnsServer())
            {
                context.Writer.WritePropertyName("DnsServer");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDnsServerListValue in requestObject.DnsServer)
                {
                        context.Writer.Write(requestObjectDnsServerListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSecurityGroupIdSet())
            {
                context.Writer.WritePropertyName("SecurityGroupIdSet");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSecurityGroupIdSetListValue in requestObject.SecurityGroupIdSet)
                {
                        context.Writer.Write(requestObjectSecurityGroupIdSetListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSelfServicePortalUrl())
            {
                context.Writer.WritePropertyName("SelfServicePortalUrl");
                context.Writer.Write(requestObject.SelfServicePortalUrl);
            }

            if(requestObject.IsSetServerCertificateArn())
            {
                context.Writer.WritePropertyName("ServerCertificateArn");
                context.Writer.Write(requestObject.ServerCertificateArn);
            }

            if(requestObject.IsSetSessionTimeoutHours())
            {
                context.Writer.WritePropertyName("SessionTimeoutHours");
                context.Writer.Write(requestObject.SessionTimeoutHours);
            }

            if(requestObject.IsSetSplitTunnel())
            {
                context.Writer.WritePropertyName("SplitTunnel");
                context.Writer.Write(requestObject.SplitTunnel);
            }

            if(requestObject.IsSetTransportProtocol())
            {
                context.Writer.WritePropertyName("TransportProtocol");
                context.Writer.Write(requestObject.TransportProtocol);
            }

            if(requestObject.IsSetVpcId())
            {
                context.Writer.WritePropertyName("VpcId");
                context.Writer.Write(requestObject.VpcId);
            }

            if(requestObject.IsSetVpnPort())
            {
                context.Writer.WritePropertyName("VpnPort");
                context.Writer.Write(requestObject.VpnPort);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEc2ClientVpnEndpointDetailsMarshaller Instance = new AwsEc2ClientVpnEndpointDetailsMarshaller();

    }
}