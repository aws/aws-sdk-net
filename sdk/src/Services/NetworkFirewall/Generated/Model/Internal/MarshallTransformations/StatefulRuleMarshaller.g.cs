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
    /// StatefulRule Marshaller
    /// </summary>
    public partial class StatefulRuleMarshaller : IRequestMarshaller<StatefulRule, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(StatefulRule requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAction())
            {
                context.Writer.WriteTextString("Action");
                context.Writer.WriteTextString(requestObject.Action);
            }

            if (requestObject.IsSetHeader())
            {
                context.Writer.WriteTextString("Header");
                context.Writer.WriteStartMap(null);

                var marshaller = HeaderMarshaller.Instance;
                marshaller.Marshall(requestObject.Header, context);

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
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static StatefulRuleMarshaller Instance = new StatefulRuleMarshaller();
    }
}
