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
    /// FirewallRule Marshaller
    /// </summary>
    public partial class FirewallRuleMarshaller : IRequestMarshaller<FirewallRule, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(FirewallRule requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAcceptPriorHooks())
            {
                context.Writer.WritePropertyName("AcceptPriorHooks");
                context.Writer.WriteBooleanValue(requestObject.AcceptPriorHooks.Value);
            }

            if (requestObject.IsSetAction())
            {
                context.Writer.WritePropertyName("Action");
                context.Writer.WriteStringValue(requestObject.Action);
            }

            if (requestObject.IsSetActionScope())
            {
                context.Writer.WritePropertyName("ActionScope");
                context.Writer.WriteStringValue(requestObject.ActionScope);
            }

            if (requestObject.IsSetAlertEnabled())
            {
                context.Writer.WritePropertyName("AlertEnabled");
                context.Writer.WriteBooleanValue(requestObject.AlertEnabled.Value);
            }

            if (requestObject.IsSetBypassIPSEnabled())
            {
                context.Writer.WritePropertyName("BypassIPSEnabled");
                context.Writer.WriteBooleanValue(requestObject.BypassIPSEnabled.Value);
            }

            if (requestObject.IsSetDestIPs())
            {
                context.Writer.WritePropertyName("DestIPs");
                context.Writer.WriteStringValue(requestObject.DestIPs);
            }

            if (requestObject.IsSetDestPorts())
            {
                context.Writer.WritePropertyName("DestPorts");
                context.Writer.WriteStringValue(requestObject.DestPorts);
            }

            if (requestObject.IsSetHook())
            {
                context.Writer.WritePropertyName("Hook");
                context.Writer.WriteStringValue(requestObject.Hook);
            }

            if (requestObject.IsSetProtocol())
            {
                context.Writer.WritePropertyName("Protocol");
                context.Writer.WriteStringValue(requestObject.Protocol);
            }

            if (requestObject.IsSetRuleMetadata())
            {
                context.Writer.WritePropertyName("RuleMetadata");
                context.Writer.WriteStartObject();

                var marshaller = RuleMetadataMarshaller.Instance;
                marshaller.Marshall(requestObject.RuleMetadata, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetRuleOptions())
            {
                context.Writer.WritePropertyName("RuleOptions");
                context.Writer.WriteStartArray();
                foreach (var requestObjectRuleOptionsListValue in requestObject.RuleOptions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = RuleOptionMarshaller.Instance;
                    marshaller.Marshall(requestObjectRuleOptionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetSourceIPs())
            {
                context.Writer.WritePropertyName("SourceIPs");
                context.Writer.WriteStringValue(requestObject.SourceIPs);
            }

            if (requestObject.IsSetSourcePorts())
            {
                context.Writer.WritePropertyName("SourcePorts");
                context.Writer.WriteStringValue(requestObject.SourcePorts);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static FirewallRuleMarshaller Instance = new FirewallRuleMarshaller();
    }
}
