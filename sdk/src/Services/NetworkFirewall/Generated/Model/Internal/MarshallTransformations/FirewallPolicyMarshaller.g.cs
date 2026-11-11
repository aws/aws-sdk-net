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
    /// FirewallPolicy Marshaller
    /// </summary>
    public partial class FirewallPolicyMarshaller : IRequestMarshaller<FirewallPolicy, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(FirewallPolicy requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetEnableTLSSessionHolding())
            {
                context.Writer.WriteTextString("EnableTLSSessionHolding");
                context.Writer.WriteBoolean(requestObject.EnableTLSSessionHolding.Value);
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

            if (requestObject.IsSetStatefulDefaultActions())
            {
                context.Writer.WriteTextString("StatefulDefaultActions");
                context.Writer.WriteStartArray(requestObject.StatefulDefaultActions.Count);
                foreach (var requestObjectStatefulDefaultActionsListValue in requestObject.StatefulDefaultActions)
                {
                    context.Writer.WriteTextString(requestObjectStatefulDefaultActionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetStatefulEngineOptions())
            {
                context.Writer.WriteTextString("StatefulEngineOptions");
                context.Writer.WriteStartMap(null);

                var marshaller = StatefulEngineOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.StatefulEngineOptions, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetStatefulRuleGroupReferences())
            {
                context.Writer.WriteTextString("StatefulRuleGroupReferences");
                context.Writer.WriteStartArray(requestObject.StatefulRuleGroupReferences.Count);
                foreach (var requestObjectStatefulRuleGroupReferencesListValue in requestObject.StatefulRuleGroupReferences)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = StatefulRuleGroupReferenceMarshaller.Instance;
                    marshaller.Marshall(requestObjectStatefulRuleGroupReferencesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetStatelessCustomActions())
            {
                context.Writer.WriteTextString("StatelessCustomActions");
                context.Writer.WriteStartArray(requestObject.StatelessCustomActions.Count);
                foreach (var requestObjectStatelessCustomActionsListValue in requestObject.StatelessCustomActions)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = CustomActionMarshaller.Instance;
                    marshaller.Marshall(requestObjectStatelessCustomActionsListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetStatelessDefaultActions())
            {
                context.Writer.WriteTextString("StatelessDefaultActions");
                context.Writer.WriteStartArray(requestObject.StatelessDefaultActions.Count);
                foreach (var requestObjectStatelessDefaultActionsListValue in requestObject.StatelessDefaultActions)
                {
                    context.Writer.WriteTextString(requestObjectStatelessDefaultActionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetStatelessFragmentDefaultActions())
            {
                context.Writer.WriteTextString("StatelessFragmentDefaultActions");
                context.Writer.WriteStartArray(requestObject.StatelessFragmentDefaultActions.Count);
                foreach (var requestObjectStatelessFragmentDefaultActionsListValue in requestObject.StatelessFragmentDefaultActions)
                {
                    context.Writer.WriteTextString(requestObjectStatelessFragmentDefaultActionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetStatelessRuleGroupReferences())
            {
                context.Writer.WriteTextString("StatelessRuleGroupReferences");
                context.Writer.WriteStartArray(requestObject.StatelessRuleGroupReferences.Count);
                foreach (var requestObjectStatelessRuleGroupReferencesListValue in requestObject.StatelessRuleGroupReferences)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = StatelessRuleGroupReferenceMarshaller.Instance;
                    marshaller.Marshall(requestObjectStatelessRuleGroupReferencesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
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
        public readonly static FirewallPolicyMarshaller Instance = new FirewallPolicyMarshaller();
    }
}
