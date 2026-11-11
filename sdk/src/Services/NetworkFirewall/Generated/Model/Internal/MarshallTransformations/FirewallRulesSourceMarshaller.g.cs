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
    /// FirewallRulesSource Marshaller
    /// </summary>
    public partial class FirewallRulesSourceMarshaller : IRequestMarshaller<FirewallRulesSource, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(FirewallRulesSource requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetFirewallRules())
            {
                context.Writer.WritePropertyName("FirewallRules");
                context.Writer.WriteStartArray();
                foreach (var requestObjectFirewallRulesListValue in requestObject.FirewallRules)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FirewallRuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectFirewallRulesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetRulesSourceList())
            {
                context.Writer.WritePropertyName("RulesSourceList");
                context.Writer.WriteStartObject();

                var marshaller = RulesSourceListMarshaller.Instance;
                marshaller.Marshall(requestObject.RulesSourceList, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetRulesString())
            {
                context.Writer.WritePropertyName("RulesString");
                context.Writer.WriteStringValue(requestObject.RulesString);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static FirewallRulesSourceMarshaller Instance = new FirewallRulesSourceMarshaller();
    }
}
