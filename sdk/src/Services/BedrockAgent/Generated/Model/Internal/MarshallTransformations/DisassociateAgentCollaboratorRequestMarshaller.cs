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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgent.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DisassociateAgentCollaborator Request Marshaller
    /// </summary>       
    public class DisassociateAgentCollaboratorRequestMarshaller : IMarshaller<IRequest, DisassociateAgentCollaboratorRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DisassociateAgentCollaboratorRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DisassociateAgentCollaboratorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgent");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-06-05";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetAgentId())
                throw new AmazonBedrockAgentException("Request object does not have required field AgentId set");
            request.AddPathResource("{agentId}", StringUtils.FromString(publicRequest.AgentId));
            if (!publicRequest.IsSetAgentVersion())
                throw new AmazonBedrockAgentException("Request object does not have required field AgentVersion set");
            request.AddPathResource("{agentVersion}", StringUtils.FromString(publicRequest.AgentVersion));
            if (!publicRequest.IsSetCollaboratorId())
                throw new AmazonBedrockAgentException("Request object does not have required field CollaboratorId set");
            request.AddPathResource("{collaboratorId}", StringUtils.FromString(publicRequest.CollaboratorId));
            request.ResourcePath = "/agents/{agentId}/agentversions/{agentVersion}/agentcollaborators/{collaboratorId}/";

            return request;
        }
        private static DisassociateAgentCollaboratorRequestMarshaller _instance = new DisassociateAgentCollaboratorRequestMarshaller();        

        internal static DisassociateAgentCollaboratorRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DisassociateAgentCollaboratorRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}