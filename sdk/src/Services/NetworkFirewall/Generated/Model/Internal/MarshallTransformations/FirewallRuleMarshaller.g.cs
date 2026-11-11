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
    /// FirewallRule Marshaller
    /// </summary>
    public partial class FirewallRuleMarshaller : IRequestMarshaller<FirewallRule, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(FirewallRule requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAcceptPriorHooks())
            {
                context.Writer.WriteTextString("AcceptPriorHooks");
                context.Writer.WriteBoolean(requestObject.AcceptPriorHooks.Value);
            }

            if (requestObject.IsSetAction())
            {
                context.Writer.WriteTextString("Action");
                context.Writer.WriteTextString(requestObject.Action);
            }

            if (requestObject.IsSetActionScope())
            {
                context.Writer.WriteTextString("ActionScope");
                context.Writer.WriteTextString(requestObject.ActionScope);
            }

            if (requestObject.IsSetAlertEnabled())
            {
                context.Writer.WriteTextString("AlertEnabled");
                context.Writer.WriteBoolean(requestObject.AlertEnabled.Value);
            }

            if (requestObject.IsSetBypassIPSEnabled())
            {
                context.Writer.WriteTextString("BypassIPSEnabled");
                context.Writer.WriteBoolean(requestObject.BypassIPSEnabled.Value);
            }

            if (requestObject.IsSetDestIPs())
            {
                context.Writer.WriteTextString("DestIPs");
                context.Writer.WriteTextString(requestObject.DestIPs);
            }

            if (requestObject.IsSetDestPorts())
            {
                context.Writer.WriteTextString("DestPorts");
                context.Writer.WriteTextString(requestObject.DestPorts);
            }

            if (requestObject.IsSetHook())
            {
                context.Writer.WriteTextString("Hook");
                context.Writer.WriteTextString(requestObject.Hook);
            }

            if (requestObject.IsSetProtocol())
            {
                context.Writer.WriteTextString("Protocol");
                context.Writer.WriteTextString(requestObject.Protocol);
            }

            if (requestObject.IsSetRuleMetadata())
            {
                context.Writer.WriteTextString("RuleMetadata");
                context.Writer.WriteStartMap(null);

                var marshaller = RuleMetadataMarshaller.Instance;
                marshaller.Marshall(requestObject.RuleMetadata, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetRuleOptions())
            {
                context.Writer.WriteTextString("RuleOptions");
                context.Writer.WriteStartArray(requestObject.RuleOptions.Count);
                foreach (var requestObjectRuleOptionsListValue in requestObject.RuleOptions)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = RuleOptionMarshaller.Instance;
                    marshaller.Marshall(requestObjectRuleOptionsListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetSourceIPs())
            {
                context.Writer.WriteTextString("SourceIPs");
                context.Writer.WriteTextString(requestObject.SourceIPs);
            }

            if (requestObject.IsSetSourcePorts())
            {
                context.Writer.WriteTextString("SourcePorts");
                context.Writer.WriteTextString(requestObject.SourcePorts);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static FirewallRuleMarshaller Instance = new FirewallRuleMarshaller();
    }
}
