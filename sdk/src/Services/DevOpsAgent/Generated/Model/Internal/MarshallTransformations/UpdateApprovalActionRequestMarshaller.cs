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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DevOpsAgent.Model;
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
namespace Amazon.DevOpsAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateApprovalAction Request Marshaller
    /// </summary>       
    public class UpdateApprovalActionRequestMarshaller : IMarshaller<IRequest, UpdateApprovalActionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateApprovalActionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateApprovalActionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DevOpsAgent");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2026-01-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAgentSpaceId())
                throw new AmazonDevOpsAgentException("Request object does not have required field AgentSpaceId set");
            request.AddPathResource("{agentSpaceId}", StringUtils.FromString(publicRequest.AgentSpaceId));
            if (!publicRequest.IsSetApprovalId())
                throw new AmazonDevOpsAgentException("Request object does not have required field ApprovalId set");
            request.AddPathResource("{approvalId}", StringUtils.FromString(publicRequest.ApprovalId));
            request.ResourcePath = "/agents/agent-space/{agentSpaceId}/approvals/{approvalId}/update-action";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAction())
            {
                context.Writer.WritePropertyName("action");
                context.Writer.WriteStringValue(publicRequest.Action);
            }

            if(publicRequest.IsSetFinalPattern())
            {
                context.Writer.WritePropertyName("finalPattern");
                context.Writer.WriteStartObject();

                var marshaller = ApprovalPatternMarshaller.Instance;
                marshaller.Marshall(publicRequest.FinalPattern, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetReason())
            {
                context.Writer.WritePropertyName("reason");
                context.Writer.WriteStringValue(publicRequest.Reason);
            }

            if(publicRequest.IsSetSingleUse())
            {
                context.Writer.WritePropertyName("singleUse");
                context.Writer.WriteBooleanValue(publicRequest.SingleUse.Value);
            }

            if(publicRequest.IsSetTtlSeconds())
            {
                context.Writer.WritePropertyName("ttlSeconds");
                context.Writer.WriteNumberValue(publicRequest.TtlSeconds.Value);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            

            
            request.HostPrefix = $"dp.";

            return request;
        }
        private static UpdateApprovalActionRequestMarshaller _instance = new UpdateApprovalActionRequestMarshaller();        

        internal static UpdateApprovalActionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateApprovalActionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}