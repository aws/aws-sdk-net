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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityAgent.Model;
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
namespace Amazon.SecurityAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateThreat Request Marshaller
    /// </summary>       
    public class CreateThreatRequestMarshaller : IMarshaller<IRequest, CreateThreatRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateThreatRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateThreatRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SecurityAgent");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-09-06";
            request.HttpMethod = "POST";

            request.ResourcePath = "/CreateThreat";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAgentSpaceId())
            {
                context.Writer.WritePropertyName("agentSpaceId");
                context.Writer.WriteStringValue(publicRequest.AgentSpaceId);
            }

            if(publicRequest.IsSetAnchor())
            {
                context.Writer.WritePropertyName("anchor");
                context.Writer.WriteStartObject();

                var marshaller = ThreatAnchorShapeMarshaller.Instance;
                marshaller.Marshall(publicRequest.Anchor, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetComments())
            {
                context.Writer.WritePropertyName("comments");
                context.Writer.WriteStringValue(publicRequest.Comments);
            }

            if(publicRequest.IsSetEvidence())
            {
                context.Writer.WritePropertyName("evidence");
                context.Writer.WriteStartArray();
                foreach(var publicRequestEvidenceListValue in publicRequest.Evidence)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ThreatEvidenceShapeMarshaller.Instance;
                    marshaller.Marshall(publicRequestEvidenceListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetImpactedAssets())
            {
                context.Writer.WritePropertyName("impactedAssets");
                context.Writer.WriteStartArray();
                foreach(var publicRequestImpactedAssetsListValue in publicRequest.ImpactedAssets)
                {
                        context.Writer.WriteStringValue(publicRequestImpactedAssetsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetImpactedGoal())
            {
                context.Writer.WritePropertyName("impactedGoal");
                context.Writer.WriteStartArray();
                foreach(var publicRequestImpactedGoalListValue in publicRequest.ImpactedGoal)
                {
                        context.Writer.WriteStringValue(publicRequestImpactedGoalListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetPrerequisites())
            {
                context.Writer.WritePropertyName("prerequisites");
                context.Writer.WriteStringValue(publicRequest.Prerequisites);
            }

            if(publicRequest.IsSetRecommendation())
            {
                context.Writer.WritePropertyName("recommendation");
                context.Writer.WriteStringValue(publicRequest.Recommendation);
            }

            if(publicRequest.IsSetSeverity())
            {
                context.Writer.WritePropertyName("severity");
                context.Writer.WriteStringValue(publicRequest.Severity);
            }

            if(publicRequest.IsSetStatement())
            {
                context.Writer.WritePropertyName("statement");
                context.Writer.WriteStringValue(publicRequest.Statement);
            }

            if(publicRequest.IsSetStride())
            {
                context.Writer.WritePropertyName("stride");
                context.Writer.WriteStartArray();
                foreach(var publicRequestStrideListValue in publicRequest.Stride)
                {
                        context.Writer.WriteStringValue(publicRequestStrideListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetThreatAction())
            {
                context.Writer.WritePropertyName("threatAction");
                context.Writer.WriteStringValue(publicRequest.ThreatAction);
            }

            if(publicRequest.IsSetThreatImpact())
            {
                context.Writer.WritePropertyName("threatImpact");
                context.Writer.WriteStringValue(publicRequest.ThreatImpact);
            }

            if(publicRequest.IsSetThreatJobId())
            {
                context.Writer.WritePropertyName("threatJobId");
                context.Writer.WriteStringValue(publicRequest.ThreatJobId);
            }

            if(publicRequest.IsSetThreatSource())
            {
                context.Writer.WritePropertyName("threatSource");
                context.Writer.WriteStringValue(publicRequest.ThreatSource);
            }

            if(publicRequest.IsSetTitle())
            {
                context.Writer.WritePropertyName("title");
                context.Writer.WriteStringValue(publicRequest.Title);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateThreatRequestMarshaller _instance = new CreateThreatRequestMarshaller();        

        internal static CreateThreatRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateThreatRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}