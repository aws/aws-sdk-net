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

using Amazon.Route53Resolver.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.Route53Resolver.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FirewallRuleType Marshaller
    /// </summary>
    public partial class FirewallRuleTypeMarshaller : IRequestMarshaller<FirewallRuleType, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(FirewallRuleType requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetDnsThreatProtection())
            {
                context.Writer.WritePropertyName("DnsThreatProtection");
                context.Writer.WriteStartObject();

                var marshaller = DnsThreatProtectionRuleTypeConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.DnsThreatProtection, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetFirewallAdvancedContentCategory())
            {
                context.Writer.WritePropertyName("FirewallAdvancedContentCategory");
                context.Writer.WriteStartObject();

                var marshaller = FirewallAdvancedContentCategoryConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.FirewallAdvancedContentCategory, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetFirewallAdvancedThreatCategory())
            {
                context.Writer.WritePropertyName("FirewallAdvancedThreatCategory");
                context.Writer.WriteStartObject();

                var marshaller = FirewallAdvancedThreatCategoryConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.FirewallAdvancedThreatCategory, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetPartnerThreatProtection())
            {
                context.Writer.WritePropertyName("PartnerThreatProtection");
                context.Writer.WriteStartObject();

                var marshaller = PartnerThreatProtectionConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.PartnerThreatProtection, context);

                context.Writer.WriteEndObject();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static FirewallRuleTypeMarshaller Instance = new FirewallRuleTypeMarshaller();
    }
}
