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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GroundStation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GroundStation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsGroundStationAgentEndpoint Marshaller
    /// </summary>
    public class AwsGroundStationAgentEndpointMarshaller : IRequestMarshaller<AwsGroundStationAgentEndpoint, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsGroundStationAgentEndpoint requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAgentStatus())
            {
                context.Writer.WritePropertyName("agentStatus");
                context.Writer.Write(requestObject.AgentStatus);
            }

            if(requestObject.IsSetAuditResults())
            {
                context.Writer.WritePropertyName("auditResults");
                context.Writer.Write(requestObject.AuditResults);
            }

            if(requestObject.IsSetEgressAddress())
            {
                context.Writer.WritePropertyName("egressAddress");
                context.Writer.WriteObjectStart();

                var marshaller = ConnectionDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.EgressAddress, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetIngressAddress())
            {
                context.Writer.WritePropertyName("ingressAddress");
                context.Writer.WriteObjectStart();

                var marshaller = RangedConnectionDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.IngressAddress, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.Write(requestObject.Name);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsGroundStationAgentEndpointMarshaller Instance = new AwsGroundStationAgentEndpointMarshaller();

    }
}