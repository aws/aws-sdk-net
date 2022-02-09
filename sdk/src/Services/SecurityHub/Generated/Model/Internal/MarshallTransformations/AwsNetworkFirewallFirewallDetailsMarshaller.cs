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

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsNetworkFirewallFirewallDetails Marshaller
    /// </summary>
    public class AwsNetworkFirewallFirewallDetailsMarshaller : IRequestMarshaller<AwsNetworkFirewallFirewallDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsNetworkFirewallFirewallDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDeleteProtection())
            {
                context.Writer.WritePropertyName("DeleteProtection");
                context.Writer.Write(requestObject.DeleteProtection);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetFirewallArn())
            {
                context.Writer.WritePropertyName("FirewallArn");
                context.Writer.Write(requestObject.FirewallArn);
            }

            if(requestObject.IsSetFirewallId())
            {
                context.Writer.WritePropertyName("FirewallId");
                context.Writer.Write(requestObject.FirewallId);
            }

            if(requestObject.IsSetFirewallName())
            {
                context.Writer.WritePropertyName("FirewallName");
                context.Writer.Write(requestObject.FirewallName);
            }

            if(requestObject.IsSetFirewallPolicyArn())
            {
                context.Writer.WritePropertyName("FirewallPolicyArn");
                context.Writer.Write(requestObject.FirewallPolicyArn);
            }

            if(requestObject.IsSetFirewallPolicyChangeProtection())
            {
                context.Writer.WritePropertyName("FirewallPolicyChangeProtection");
                context.Writer.Write(requestObject.FirewallPolicyChangeProtection);
            }

            if(requestObject.IsSetSubnetChangeProtection())
            {
                context.Writer.WritePropertyName("SubnetChangeProtection");
                context.Writer.Write(requestObject.SubnetChangeProtection);
            }

            if(requestObject.IsSetSubnetMappings())
            {
                context.Writer.WritePropertyName("SubnetMappings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSubnetMappingsListValue in requestObject.SubnetMappings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsNetworkFirewallFirewallSubnetMappingsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectSubnetMappingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetVpcId())
            {
                context.Writer.WritePropertyName("VpcId");
                context.Writer.Write(requestObject.VpcId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsNetworkFirewallFirewallDetailsMarshaller Instance = new AwsNetworkFirewallFirewallDetailsMarshaller();

    }
}