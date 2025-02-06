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
#pragma warning disable CS0612,CS0618
namespace Amazon.NetworkFirewall.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RuleGroup Marshaller
    /// </summary>
    public class RuleGroupMarshaller : IRequestMarshaller<RuleGroup, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RuleGroup requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetReferenceSets())
            {
                context.Writer.WritePropertyName("ReferenceSets");
                context.Writer.WriteStartObject();

                var marshaller = ReferenceSetsMarshaller.Instance;
                marshaller.Marshall(requestObject.ReferenceSets, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRulesSource())
            {
                context.Writer.WritePropertyName("RulesSource");
                context.Writer.WriteStartObject();

                var marshaller = RulesSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.RulesSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRuleVariables())
            {
                context.Writer.WritePropertyName("RuleVariables");
                context.Writer.WriteStartObject();

                var marshaller = RuleVariablesMarshaller.Instance;
                marshaller.Marshall(requestObject.RuleVariables, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStatefulRuleOptions())
            {
                context.Writer.WritePropertyName("StatefulRuleOptions");
                context.Writer.WriteStartObject();

                var marshaller = StatefulRuleOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.StatefulRuleOptions, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RuleGroupMarshaller Instance = new RuleGroupMarshaller();

    }
}