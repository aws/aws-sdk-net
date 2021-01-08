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
    /// RuleVariables Marshaller
    /// </summary>       
    public class RuleVariablesMarshaller : IRequestMarshaller<RuleVariables, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RuleVariables requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetIPSets())
            {
                context.Writer.WritePropertyName("IPSets");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectIPSetsKvp in requestObject.IPSets)
                {
                    context.Writer.WritePropertyName(requestObjectIPSetsKvp.Key);
                    var requestObjectIPSetsValue = requestObjectIPSetsKvp.Value;

                    context.Writer.WriteObjectStart();

                    var marshaller = IPSetMarshaller.Instance;
                    marshaller.Marshall(requestObjectIPSetsValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPortSets())
            {
                context.Writer.WritePropertyName("PortSets");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectPortSetsKvp in requestObject.PortSets)
                {
                    context.Writer.WritePropertyName(requestObjectPortSetsKvp.Key);
                    var requestObjectPortSetsValue = requestObjectPortSetsKvp.Value;

                    context.Writer.WriteObjectStart();

                    var marshaller = PortSetMarshaller.Instance;
                    marshaller.Marshall(requestObjectPortSetsValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static RuleVariablesMarshaller Instance = new RuleVariablesMarshaller();

    }
}