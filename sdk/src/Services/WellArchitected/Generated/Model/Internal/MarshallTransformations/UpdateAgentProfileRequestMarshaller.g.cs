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
    /// UpdateAgentProfile Request Marshaller
    /// </summary>
    public partial class UpdateAgentProfileRequestMarshaller : IMarshaller<IRequest, UpdateAgentProfileRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAgentProfileRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateAgentProfileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WellArchitected");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-03-31";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetProfileArn())
            {
                throw new AmazonWellArchitectedException("Request object does not have required field ProfileArn set");
            }
            request.AddPathResource("{profileArn}", StringUtils.FromString(publicRequest.ProfileArn));

            request.ResourcePath = "/api/v1/agent-profiles/{profileArn}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetAggregationConfiguration())
            {
                context.Writer.WritePropertyName("aggregationConfiguration");
                context.Writer.WriteStartArray();
                foreach (var publicRequestAggregationConfigurationListValue in publicRequest.AggregationConfiguration)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AggregationConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestAggregationConfigurationListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetBusinessOverview())
            {
                context.Writer.WritePropertyName("businessOverview");
                context.Writer.WriteStringValue(publicRequest.BusinessOverview);
            }
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
            if (publicRequest.IsSetDeletionProtection())
            {
                context.Writer.WritePropertyName("deletionProtection");
                context.Writer.WriteBooleanValue(publicRequest.DeletionProtection.Value);
            }
            if (publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }
            if (publicRequest.IsSetDisplayName())
            {
                context.Writer.WritePropertyName("displayName");
                context.Writer.WriteStringValue(publicRequest.DisplayName);
            }
            if (publicRequest.IsSetExecutionRoleArn())
            {
                context.Writer.WritePropertyName("executionRoleArn");
                context.Writer.WriteStringValue(publicRequest.ExecutionRoleArn);
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

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateAgentProfileRequestMarshaller _instance = new();

        internal static UpdateAgentProfileRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateAgentProfileRequestMarshaller Instance => _instance;
    }
}
