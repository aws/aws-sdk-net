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
    /// Route53ResolvedIPValidation Marshaller
    /// </summary>
    public partial class Route53ResolvedIPValidationMarshaller : IRequestMarshaller<Route53ResolvedIPValidation, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(Route53ResolvedIPValidation requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAction())
            {
                context.Writer.WriteTextString("Action");
                context.Writer.WriteTextString(requestObject.Action);
            }

            if (requestObject.IsSetBypassDestinationValidationIPRanges())
            {
                context.Writer.WriteTextString("BypassDestinationValidationIPRanges");
                context.Writer.WriteStartArray(requestObject.BypassDestinationValidationIPRanges.Count);
                foreach (var requestObjectBypassDestinationValidationIPRangesListValue in requestObject.BypassDestinationValidationIPRanges)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = AddressMarshaller.Instance;
                    marshaller.Marshall(requestObjectBypassDestinationValidationIPRangesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetDNSExpiryExceptionPolicy())
            {
                context.Writer.WriteTextString("DNSExpiryExceptionPolicy");
                context.Writer.WriteTextString(requestObject.DNSExpiryExceptionPolicy);
            }

            if (requestObject.IsSetDNSFirewallRuleGroupId())
            {
                context.Writer.WriteTextString("DNSFirewallRuleGroupId");
                context.Writer.WriteTextString(requestObject.DNSFirewallRuleGroupId);
            }

            if (requestObject.IsSetSourceIPRanges())
            {
                context.Writer.WriteTextString("SourceIPRanges");
                context.Writer.WriteStartArray(requestObject.SourceIPRanges.Count);
                foreach (var requestObjectSourceIPRangesListValue in requestObject.SourceIPRanges)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = AddressMarshaller.Instance;
                    marshaller.Marshall(requestObjectSourceIPRangesListValue, context);

                    context.Writer.WriteEndMap();
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
