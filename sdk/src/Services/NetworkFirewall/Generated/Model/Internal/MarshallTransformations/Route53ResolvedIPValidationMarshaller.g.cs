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
    /// Route53ResolvedIPValidation Marshaller
    /// </summary>
    public partial class Route53ResolvedIPValidationMarshaller : IRequestMarshaller<Route53ResolvedIPValidation, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(Route53ResolvedIPValidation requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAction())
            {
                context.Writer.WritePropertyName("Action");
                context.Writer.WriteStringValue(requestObject.Action);
            }

            if (requestObject.IsSetBypassDestinationValidationIPRanges())
            {
                context.Writer.WritePropertyName("BypassDestinationValidationIPRanges");
                context.Writer.WriteStartArray();
                foreach (var requestObjectBypassDestinationValidationIPRangesListValue in requestObject.BypassDestinationValidationIPRanges)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AddressMarshaller.Instance;
                    marshaller.Marshall(requestObjectBypassDestinationValidationIPRangesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetDNSExpiryExceptionPolicy())
            {
                context.Writer.WritePropertyName("DNSExpiryExceptionPolicy");
                context.Writer.WriteStringValue(requestObject.DNSExpiryExceptionPolicy);
            }

            if (requestObject.IsSetDNSFirewallRuleGroupId())
            {
                context.Writer.WritePropertyName("DNSFirewallRuleGroupId");
                context.Writer.WriteStringValue(requestObject.DNSFirewallRuleGroupId);
            }

            if (requestObject.IsSetSourceIPRanges())
            {
                context.Writer.WritePropertyName("SourceIPRanges");
                context.Writer.WriteStartArray();
                foreach (var requestObjectSourceIPRangesListValue in requestObject.SourceIPRanges)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AddressMarshaller.Instance;
                    marshaller.Marshall(requestObjectSourceIPRangesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static Route53ResolvedIPValidationMarshaller Instance = new Route53ResolvedIPValidationMarshaller();
    }
}
