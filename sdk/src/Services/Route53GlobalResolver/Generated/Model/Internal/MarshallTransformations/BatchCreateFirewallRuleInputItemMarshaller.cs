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
 * Do not modify this file. This file is generated from the route53globalresolver-2022-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53GlobalResolver.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Route53GlobalResolver.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchCreateFirewallRuleInputItem Marshaller
    /// </summary>
    public class BatchCreateFirewallRuleInputItemMarshaller : IRequestMarshaller<BatchCreateFirewallRuleInputItem, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BatchCreateFirewallRuleInputItem requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAction())
            {
                context.Writer.WritePropertyName("action");
                context.Writer.WriteStringValue(requestObject.Action);
            }

            if(requestObject.IsSetBlockOverrideDnsType())
            {
                context.Writer.WritePropertyName("blockOverrideDnsType");
                context.Writer.WriteStringValue(requestObject.BlockOverrideDnsType);
            }

            if(requestObject.IsSetBlockOverrideDomain())
            {
                context.Writer.WritePropertyName("blockOverrideDomain");
                context.Writer.WriteStringValue(requestObject.BlockOverrideDomain);
            }

            if(requestObject.IsSetBlockOverrideTtl())
            {
                context.Writer.WritePropertyName("blockOverrideTtl");
                context.Writer.WriteNumberValue(requestObject.BlockOverrideTtl.Value);
            }

            if(requestObject.IsSetBlockResponse())
            {
                context.Writer.WritePropertyName("blockResponse");
                context.Writer.WriteStringValue(requestObject.BlockResponse);
            }

            if(requestObject.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(requestObject.ClientToken);
            }

            if(requestObject.IsSetConfidenceThreshold())
            {
                context.Writer.WritePropertyName("confidenceThreshold");
                context.Writer.WriteStringValue(requestObject.ConfidenceThreshold);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetDnsAdvancedProtection())
            {
                context.Writer.WritePropertyName("dnsAdvancedProtection");
                context.Writer.WriteStringValue(requestObject.DnsAdvancedProtection);
            }

            if(requestObject.IsSetDnsViewId())
            {
                context.Writer.WritePropertyName("dnsViewId");
                context.Writer.WriteStringValue(requestObject.DnsViewId);
            }

            if(requestObject.IsSetFirewallDomainListId())
            {
                context.Writer.WritePropertyName("firewallDomainListId");
                context.Writer.WriteStringValue(requestObject.FirewallDomainListId);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetPriority())
            {
                context.Writer.WritePropertyName("priority");
                context.Writer.WriteNumberValue(requestObject.Priority.Value);
            }

            if(requestObject.IsSetQType())
            {
                context.Writer.WritePropertyName("qType");
                context.Writer.WriteStringValue(requestObject.QType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BatchCreateFirewallRuleInputItemMarshaller Instance = new BatchCreateFirewallRuleInputItemMarshaller();

    }
}