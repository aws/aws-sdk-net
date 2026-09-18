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

using Amazon.WellArchitected.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.WellArchitected.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAgentGoal Request Marshaller
    /// </summary>
    public partial class CreateAgentGoalRequestMarshaller : IMarshaller<IRequest, CreateAgentGoalRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAgentGoalRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateAgentGoalRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WellArchitected");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-03-31";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetProfileArn())
            {
                throw new AmazonWellArchitectedException("Request object does not have required field ProfileArn set");
            }
            request.AddPathResource("{profileArn}", StringUtils.FromString(publicRequest.ProfileArn));

            request.ResourcePath = "/api/v1/agent-profiles/{profileArn}/goals";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }
            else
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if (publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }
            if (publicRequest.IsSetPillars())
            {
                context.Writer.WritePropertyName("pillars");
                context.Writer.WriteStartArray();
                foreach (var publicRequestPillarsListValue in publicRequest.Pillars)
                {
                    context.Writer.WriteStringValue(publicRequestPillarsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetTitle())
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

        private static readonly CreateAgentGoalRequestMarshaller _instance = new();

        internal static CreateAgentGoalRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateAgentGoalRequestMarshaller Instance => _instance;
    }
}
