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
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.NetworkFirewall.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FirewallPolicyV2 Marshaller
    /// </summary>
    public partial class FirewallPolicyV2Marshaller : IRequestMarshaller<FirewallPolicyV2, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(FirewallPolicyV2 requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetFirewallDefaultAction())
            {
                context.Writer.WriteTextString("FirewallDefaultAction");
                context.Writer.WriteTextString(requestObject.FirewallDefaultAction);
            }

            if (requestObject.IsSetFirewallRuleGroupEntries())
            {
                context.Writer.WriteTextString("FirewallRuleGroupEntries");
                context.Writer.WriteStartArray(requestObject.FirewallRuleGroupEntries.Count);
                foreach (var requestObjectFirewallRuleGroupEntriesListValue in requestObject.FirewallRuleGroupEntries)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = FirewallRuleGroupEntryMarshaller.Instance;
                    marshaller.Marshall(requestObjectFirewallRuleGroupEntriesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetIpsRuleGroupEntries())
            {
                context.Writer.WriteTextString("IpsRuleGroupEntries");
                context.Writer.WriteStartArray(requestObject.IpsRuleGroupEntries.Count);
                foreach (var requestObjectIpsRuleGroupEntriesListValue in requestObject.IpsRuleGroupEntries)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = IpsRuleGroupEntryMarshaller.Instance;
                    marshaller.Marshall(requestObjectIpsRuleGroupEntriesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetPolicyMode())
            {
                context.Writer.WriteTextString("PolicyMode");
                context.Writer.WriteTextString(requestObject.PolicyMode);
            }

            if (requestObject.IsSetPolicyVariables())
            {
                context.Writer.WriteTextString("PolicyVariables");
                context.Writer.WriteStartMap(null);

                var marshaller = PolicyVariablesMarshaller.Instance;
                marshaller.Marshall(requestObject.PolicyVariables, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetRoute53ResolvedIPValidation())
            {
                context.Writer.WriteTextString("Route53ResolvedIPValidation");
                context.Writer.WriteStartMap(null);

                var marshaller = Route53ResolvedIPValidationMarshaller.Instance;
                marshaller.Marshall(requestObject.Route53ResolvedIPValidation, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetStatefulEngineOptions())
            {
                context.Writer.WriteTextString("StatefulEngineOptions");
                context.Writer.WriteStartMap(null);

                var marshaller = StatefulEngineOptionsV2Marshaller.Instance;
                marshaller.Marshall(requestObject.StatefulEngineOptions, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetTLSInspectionConfigurationArn())
            {
                context.Writer.WriteTextString("TLSInspectionConfigurationArn");
                context.Writer.WriteTextString(requestObject.TLSInspectionConfigurationArn);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static FirewallPolicyV2Marshaller Instance = new FirewallPolicyV2Marshaller();
    }
}
