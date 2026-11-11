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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.NetworkFirewall.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.NetworkFirewall.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FirewallPolicyV2 Marshaller
    /// </summary>
    public partial class FirewallPolicyV2Marshaller : IRequestMarshaller<FirewallPolicyV2, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(FirewallPolicyV2 requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetFirewallDefaultAction())
            {
                context.Writer.WritePropertyName("FirewallDefaultAction");
                context.Writer.WriteStringValue(requestObject.FirewallDefaultAction);
            }

            if (requestObject.IsSetFirewallRuleGroupEntries())
            {
                context.Writer.WritePropertyName("FirewallRuleGroupEntries");
                context.Writer.WriteStartArray();
                foreach (var requestObjectFirewallRuleGroupEntriesListValue in requestObject.FirewallRuleGroupEntries)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FirewallRuleGroupEntryMarshaller.Instance;
                    marshaller.Marshall(requestObjectFirewallRuleGroupEntriesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetIpsRuleGroupEntries())
            {
                context.Writer.WritePropertyName("IpsRuleGroupEntries");
                context.Writer.WriteStartArray();
                foreach (var requestObjectIpsRuleGroupEntriesListValue in requestObject.IpsRuleGroupEntries)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = IpsRuleGroupEntryMarshaller.Instance;
                    marshaller.Marshall(requestObjectIpsRuleGroupEntriesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetPolicyMode())
            {
                context.Writer.WritePropertyName("PolicyMode");
                context.Writer.WriteStringValue(requestObject.PolicyMode);
            }

            if (requestObject.IsSetPolicyVariables())
            {
                context.Writer.WritePropertyName("PolicyVariables");
                context.Writer.WriteStartObject();

                var marshaller = PolicyVariablesMarshaller.Instance;
                marshaller.Marshall(requestObject.PolicyVariables, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetRoute53ResolvedIPValidation())
            {
                context.Writer.WritePropertyName("Route53ResolvedIPValidation");
                context.Writer.WriteStartObject();

                var marshaller = Route53ResolvedIPValidationMarshaller.Instance;
                marshaller.Marshall(requestObject.Route53ResolvedIPValidation, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetStatefulEngineOptions())
            {
                context.Writer.WritePropertyName("StatefulEngineOptions");
                context.Writer.WriteStartObject();

                var marshaller = StatefulEngineOptionsV2Marshaller.Instance;
                marshaller.Marshall(requestObject.StatefulEngineOptions, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetTLSInspectionConfigurationArn())
            {
                context.Writer.WritePropertyName("TLSInspectionConfigurationArn");
                context.Writer.WriteStringValue(requestObject.TLSInspectionConfigurationArn);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static FirewallPolicyV2Marshaller Instance = new FirewallPolicyV2Marshaller();
    }
}
