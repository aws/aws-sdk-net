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
#pragma warning disable CS0612,CS0618
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
            if(requestObject == null)
                return;
            if(requestObject.IsSetDeleteProtection())
            {
                context.Writer.WritePropertyName("DeleteProtection");
                context.Writer.WriteBooleanValue(requestObject.DeleteProtection.Value);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetFirewallArn())
            {
                context.Writer.WritePropertyName("FirewallArn");
                context.Writer.WriteStringValue(requestObject.FirewallArn);
            }

            if(requestObject.IsSetFirewallId())
            {
                context.Writer.WritePropertyName("FirewallId");
                context.Writer.WriteStringValue(requestObject.FirewallId);
            }

            if(requestObject.IsSetFirewallName())
            {
                context.Writer.WritePropertyName("FirewallName");
                context.Writer.WriteStringValue(requestObject.FirewallName);
            }

            if(requestObject.IsSetFirewallPolicyArn())
            {
                context.Writer.WritePropertyName("FirewallPolicyArn");
                context.Writer.WriteStringValue(requestObject.FirewallPolicyArn);
            }

            if(requestObject.IsSetFirewallPolicyChangeProtection())
            {
                context.Writer.WritePropertyName("FirewallPolicyChangeProtection");
                context.Writer.WriteBooleanValue(requestObject.FirewallPolicyChangeProtection.Value);
            }

            if(requestObject.IsSetSubnetChangeProtection())
            {
                context.Writer.WritePropertyName("SubnetChangeProtection");
                context.Writer.WriteBooleanValue(requestObject.SubnetChangeProtection.Value);
            }

            if(requestObject.IsSetSubnetMappings())
            {
                context.Writer.WritePropertyName("SubnetMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSubnetMappingsListValue in requestObject.SubnetMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsNetworkFirewallFirewallSubnetMappingsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectSubnetMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetVpcId())
            {
                context.Writer.WritePropertyName("VpcId");
                context.Writer.WriteStringValue(requestObject.VpcId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsNetworkFirewallFirewallDetailsMarshaller Instance = new AwsNetworkFirewallFirewallDetailsMarshaller();

    }
}