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
 * Do not modify this file. This file is generated from the agent-registry-control-2025-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AgentRegistryControl.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AgentRegistryControl.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AgentCoreRuntimeSourceDetails Marshaller
    /// </summary>
    public class AgentCoreRuntimeSourceDetailsMarshaller : IRequestMarshaller<AgentCoreRuntimeSourceDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AgentCoreRuntimeSourceDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAuthorizerConfiguration())
            {
                context.Writer.WritePropertyName("authorizerConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AuthorizerConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.AuthorizerConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetProtocolConfiguration())
            {
                context.Writer.WritePropertyName("protocolConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AgentCoreRuntimeProtocolConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ProtocolConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetWorkloadIdentityDetails())
            {
                context.Writer.WritePropertyName("workloadIdentityDetails");
                context.Writer.WriteStartObject();

                var marshaller = WorkloadIdentityDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.WorkloadIdentityDetails, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AgentCoreRuntimeSourceDetailsMarshaller Instance = new AgentCoreRuntimeSourceDetailsMarshaller();

    }
}