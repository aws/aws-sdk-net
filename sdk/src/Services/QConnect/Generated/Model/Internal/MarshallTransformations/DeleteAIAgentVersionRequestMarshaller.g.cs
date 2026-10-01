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
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.QConnect.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.QConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteAIAgentVersion Request Marshaller
    /// </summary>
    public partial class DeleteAIAgentVersionRequestMarshaller : IMarshaller<IRequest, DeleteAIAgentVersionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteAIAgentVersionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeleteAIAgentVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QConnect");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-10-19";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetAiAgentId())
            {
                throw new AmazonQConnectException("Request object does not have required field AiAgentId set");
            }
            request.AddPathResource("{aiAgentId}", StringUtils.FromString(publicRequest.AiAgentId));

            if (!publicRequest.IsSetAssistantId())
            {
                throw new AmazonQConnectException("Request object does not have required field AssistantId set");
            }
            request.AddPathResource("{assistantId}", StringUtils.FromString(publicRequest.AssistantId));

            if (!publicRequest.IsSetVersionNumber())
            {
                throw new AmazonQConnectException("Request object does not have required field VersionNumber set");
            }
            request.AddPathResource("{versionNumber}", StringUtils.FromLong(publicRequest.VersionNumber.Value));

            request.ResourcePath = "/assistants/{assistantId}/aiagents/{aiAgentId}/versions/{versionNumber}";

            return request;
        }

        private static readonly DeleteAIAgentVersionRequestMarshaller _instance = new();

        internal static DeleteAIAgentVersionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteAIAgentVersionRequestMarshaller Instance => _instance;
    }
}
