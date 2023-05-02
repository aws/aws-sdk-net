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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkFirewall.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.NetworkFirewall.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FirewallPolicy Marshaller
    /// </summary>
    public class FirewallPolicyMarshaller : IRequestMarshaller<FirewallPolicy, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FirewallPolicy requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetStatefulDefaultActions())
            {
                context.Writer.WritePropertyName("StatefulDefaultActions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStatefulDefaultActionsListValue in requestObject.StatefulDefaultActions)
                {
                        context.Writer.Write(requestObjectStatefulDefaultActionsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStatefulEngineOptions())
            {
                context.Writer.WritePropertyName("StatefulEngineOptions");
                context.Writer.WriteObjectStart();

                var marshaller = StatefulEngineOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.StatefulEngineOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStatefulRuleGroupReferences())
            {
                context.Writer.WritePropertyName("StatefulRuleGroupReferences");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStatefulRuleGroupReferencesListValue in requestObject.StatefulRuleGroupReferences)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StatefulRuleGroupReferenceMarshaller.Instance;
                    marshaller.Marshall(requestObjectStatefulRuleGroupReferencesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStatelessCustomActions())
            {
                context.Writer.WritePropertyName("StatelessCustomActions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStatelessCustomActionsListValue in requestObject.StatelessCustomActions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CustomActionMarshaller.Instance;
                    marshaller.Marshall(requestObjectStatelessCustomActionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStatelessDefaultActions())
            {
                context.Writer.WritePropertyName("StatelessDefaultActions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStatelessDefaultActionsListValue in requestObject.StatelessDefaultActions)
                {
                        context.Writer.Write(requestObjectStatelessDefaultActionsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStatelessFragmentDefaultActions())
            {
                context.Writer.WritePropertyName("StatelessFragmentDefaultActions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStatelessFragmentDefaultActionsListValue in requestObject.StatelessFragmentDefaultActions)
                {
                        context.Writer.Write(requestObjectStatelessFragmentDefaultActionsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStatelessRuleGroupReferences())
            {
                context.Writer.WritePropertyName("StatelessRuleGroupReferences");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStatelessRuleGroupReferencesListValue in requestObject.StatelessRuleGroupReferences)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StatelessRuleGroupReferenceMarshaller.Instance;
                    marshaller.Marshall(requestObjectStatelessRuleGroupReferencesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTLSInspectionConfigurationArn())
            {
                context.Writer.WritePropertyName("TLSInspectionConfigurationArn");
                context.Writer.Write(requestObject.TLSInspectionConfigurationArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FirewallPolicyMarshaller Instance = new FirewallPolicyMarshaller();

    }
}