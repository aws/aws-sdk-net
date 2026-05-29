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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53Resolver.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Route53Resolver.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateFirewallRuleEntry Marshaller
    /// </summary>
    public class CreateFirewallRuleEntryMarshaller : IRequestMarshaller<CreateFirewallRuleEntry, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CreateFirewallRuleEntry requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAction())
            {
                context.Writer.WritePropertyName("Action");
                context.Writer.WriteStringValue(requestObject.Action);
            }

            if(requestObject.IsSetBlockOverrideDnsType())
            {
                context.Writer.WritePropertyName("BlockOverrideDnsType");
                context.Writer.WriteStringValue(requestObject.BlockOverrideDnsType);
            }

            if(requestObject.IsSetBlockOverrideDomain())
            {
                context.Writer.WritePropertyName("BlockOverrideDomain");
                context.Writer.WriteStringValue(requestObject.BlockOverrideDomain);
            }

            if(requestObject.IsSetBlockOverrideTtl())
            {
                context.Writer.WritePropertyName("BlockOverrideTtl");
                context.Writer.WriteNumberValue(requestObject.BlockOverrideTtl.Value);
            }

            if(requestObject.IsSetBlockResponse())
            {
                context.Writer.WritePropertyName("BlockResponse");
                context.Writer.WriteStringValue(requestObject.BlockResponse);
            }

            if(requestObject.IsSetConfidenceThreshold())
            {
                context.Writer.WritePropertyName("ConfidenceThreshold");
                context.Writer.WriteStringValue(requestObject.ConfidenceThreshold);
            }

            if(requestObject.IsSetCreatorRequestId())
            {
                context.Writer.WritePropertyName("CreatorRequestId");
                context.Writer.WriteStringValue(requestObject.CreatorRequestId);
            }

            if(requestObject.IsSetDnsThreatProtection())
            {
                context.Writer.WritePropertyName("DnsThreatProtection");
                context.Writer.WriteStringValue(requestObject.DnsThreatProtection);
            }

            if(requestObject.IsSetFirewallDomainListId())
            {
                context.Writer.WritePropertyName("FirewallDomainListId");
                context.Writer.WriteStringValue(requestObject.FirewallDomainListId);
            }

            if(requestObject.IsSetFirewallDomainRedirectionAction())
            {
                context.Writer.WritePropertyName("FirewallDomainRedirectionAction");
                context.Writer.WriteStringValue(requestObject.FirewallDomainRedirectionAction);
            }

            if(requestObject.IsSetFirewallRuleGroupId())
            {
                context.Writer.WritePropertyName("FirewallRuleGroupId");
                context.Writer.WriteStringValue(requestObject.FirewallRuleGroupId);
            }

            if(requestObject.IsSetFirewallRuleType())
            {
                context.Writer.WritePropertyName("FirewallRuleType");
                context.Writer.WriteStartObject();

                var marshaller = FirewallRuleTypeMarshaller.Instance;
                marshaller.Marshall(requestObject.FirewallRuleType, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetPriority())
            {
                context.Writer.WritePropertyName("Priority");
                context.Writer.WriteNumberValue(requestObject.Priority.Value);
            }

            if(requestObject.IsSetQtype())
            {
                context.Writer.WritePropertyName("Qtype");
                context.Writer.WriteStringValue(requestObject.Qtype);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CreateFirewallRuleEntryMarshaller Instance = new CreateFirewallRuleEntryMarshaller();

    }
}