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
    /// RulesSource Marshaller
    /// </summary>
    public class RulesSourceMarshaller : IRequestMarshaller<RulesSource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RulesSource requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetRulesSourceList())
            {
                context.Writer.WritePropertyName("RulesSourceList");
                context.Writer.WriteStartObject();

                var marshaller = RulesSourceListMarshaller.Instance;
                marshaller.Marshall(requestObject.RulesSourceList, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRulesString())
            {
                context.Writer.WritePropertyName("RulesString");
                context.Writer.WriteStringValue(requestObject.RulesString);
            }

            if(requestObject.IsSetStatefulRules())
            {
                context.Writer.WritePropertyName("StatefulRules");
                context.Writer.WriteStartArray();
                foreach(var requestObjectStatefulRulesListValue in requestObject.StatefulRules)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StatefulRuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectStatefulRulesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetStatelessRulesAndCustomActions())
            {
                context.Writer.WritePropertyName("StatelessRulesAndCustomActions");
                context.Writer.WriteStartObject();

                var marshaller = StatelessRulesAndCustomActionsMarshaller.Instance;
                marshaller.Marshall(requestObject.StatelessRulesAndCustomActions, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RulesSourceMarshaller Instance = new RulesSourceMarshaller();

    }
}