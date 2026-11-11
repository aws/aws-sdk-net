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
    /// CreateProxyRulesByRequestPhase Marshaller
    /// </summary>
    public partial class CreateProxyRulesByRequestPhaseMarshaller : IRequestMarshaller<CreateProxyRulesByRequestPhase, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(CreateProxyRulesByRequestPhase requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetPostRESPONSE())
            {
                context.Writer.WriteTextString("PostRESPONSE");
                context.Writer.WriteStartArray(requestObject.PostRESPONSE.Count);
                foreach (var requestObjectPostRESPONSEListValue in requestObject.PostRESPONSE)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = CreateProxyRuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectPostRESPONSEListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetPreDNS())
            {
                context.Writer.WriteTextString("PreDNS");
                context.Writer.WriteStartArray(requestObject.PreDNS.Count);
                foreach (var requestObjectPreDNSListValue in requestObject.PreDNS)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = CreateProxyRuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectPreDNSListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetPreREQUEST())
            {
                context.Writer.WriteTextString("PreREQUEST");
                context.Writer.WriteStartArray(requestObject.PreREQUEST.Count);
                foreach (var requestObjectPreREQUESTListValue in requestObject.PreREQUEST)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = CreateProxyRuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectPreREQUESTListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static CreateProxyRulesByRequestPhaseMarshaller Instance = new CreateProxyRulesByRequestPhaseMarshaller();
    }
}
