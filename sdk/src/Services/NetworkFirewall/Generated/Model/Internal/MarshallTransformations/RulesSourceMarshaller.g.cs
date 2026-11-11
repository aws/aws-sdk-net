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
    /// RulesSource Marshaller
    /// </summary>
    public partial class RulesSourceMarshaller : IRequestMarshaller<RulesSource, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(RulesSource requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetRulesSourceList())
            {
                context.Writer.WriteTextString("RulesSourceList");
                context.Writer.WriteStartMap(null);

                var marshaller = RulesSourceListMarshaller.Instance;
                marshaller.Marshall(requestObject.RulesSourceList, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetRulesString())
            {
                context.Writer.WriteTextString("RulesString");
                context.Writer.WriteTextString(requestObject.RulesString);
            }

            if (requestObject.IsSetStatefulRules())
            {
                context.Writer.WriteTextString("StatefulRules");
                context.Writer.WriteStartArray(requestObject.StatefulRules.Count);
                foreach (var requestObjectStatefulRulesListValue in requestObject.StatefulRules)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = StatefulRuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectStatefulRulesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetStatelessRulesAndCustomActions())
            {
                context.Writer.WriteTextString("StatelessRulesAndCustomActions");
                context.Writer.WriteStartMap(null);

                var marshaller = StatelessRulesAndCustomActionsMarshaller.Instance;
                marshaller.Marshall(requestObject.StatelessRulesAndCustomActions, context);

                context.Writer.WriteEndMap();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static RulesSourceMarshaller Instance = new RulesSourceMarshaller();
    }
}
