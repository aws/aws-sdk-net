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
    /// ProxyRulesByRequestPhase Marshaller
    /// </summary>
    public class ProxyRulesByRequestPhaseMarshaller : IRequestMarshaller<ProxyRulesByRequestPhase, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ProxyRulesByRequestPhase requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetPostRESPONSE())
            {
                context.Writer.WritePropertyName("PostRESPONSE");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPostRESPONSEListValue in requestObject.PostRESPONSE)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ProxyRuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectPostRESPONSEListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPreDNS())
            {
                context.Writer.WritePropertyName("PreDNS");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPreDNSListValue in requestObject.PreDNS)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ProxyRuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectPreDNSListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPreREQUEST())
            {
                context.Writer.WritePropertyName("PreREQUEST");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPreREQUESTListValue in requestObject.PreREQUEST)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ProxyRuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectPreREQUESTListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ProxyRulesByRequestPhaseMarshaller Instance = new ProxyRulesByRequestPhaseMarshaller();

    }
}