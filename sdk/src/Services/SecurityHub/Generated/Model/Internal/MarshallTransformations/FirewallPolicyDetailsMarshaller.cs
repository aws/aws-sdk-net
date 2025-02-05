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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FirewallPolicyDetails Marshaller
    /// </summary>
    public class FirewallPolicyDetailsMarshaller : IRequestMarshaller<FirewallPolicyDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FirewallPolicyDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetStatefulRuleGroupReferences())
            {
                context.Writer.WritePropertyName("StatefulRuleGroupReferences");
                context.Writer.WriteStartArray();
                foreach(var requestObjectStatefulRuleGroupReferencesListValue in requestObject.StatefulRuleGroupReferences)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FirewallPolicyStatefulRuleGroupReferencesDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectStatefulRuleGroupReferencesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetStatelessCustomActions())
            {
                context.Writer.WritePropertyName("StatelessCustomActions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectStatelessCustomActionsListValue in requestObject.StatelessCustomActions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FirewallPolicyStatelessCustomActionsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectStatelessCustomActionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetStatelessDefaultActions())
            {
                context.Writer.WritePropertyName("StatelessDefaultActions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectStatelessDefaultActionsListValue in requestObject.StatelessDefaultActions)
                {
                        context.Writer.WriteStringValue(requestObjectStatelessDefaultActionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetStatelessFragmentDefaultActions())
            {
                context.Writer.WritePropertyName("StatelessFragmentDefaultActions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectStatelessFragmentDefaultActionsListValue in requestObject.StatelessFragmentDefaultActions)
                {
                        context.Writer.WriteStringValue(requestObjectStatelessFragmentDefaultActionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetStatelessRuleGroupReferences())
            {
                context.Writer.WritePropertyName("StatelessRuleGroupReferences");
                context.Writer.WriteStartArray();
                foreach(var requestObjectStatelessRuleGroupReferencesListValue in requestObject.StatelessRuleGroupReferences)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FirewallPolicyStatelessRuleGroupReferencesDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectStatelessRuleGroupReferencesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FirewallPolicyDetailsMarshaller Instance = new FirewallPolicyDetailsMarshaller();

    }
}