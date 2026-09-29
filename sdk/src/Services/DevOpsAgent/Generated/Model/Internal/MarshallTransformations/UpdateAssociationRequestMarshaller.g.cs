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

using Amazon.DevOpsAgent.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.DevOpsAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAssociation Request Marshaller
    /// </summary>
    public partial class UpdateAssociationRequestMarshaller : IMarshaller<IRequest, UpdateAssociationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAssociationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateAssociationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DevOpsAgent");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2026-01-01";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetAgentSpaceId())
            {
                throw new AmazonDevOpsAgentException("Request object does not have required field AgentSpaceId set");
            }
            request.AddPathResource("{agentSpaceId}", StringUtils.FromString(publicRequest.AgentSpaceId));

            if (!publicRequest.IsSetAssociationId())
            {
                throw new AmazonDevOpsAgentException("Request object does not have required field AssociationId set");
            }
            request.AddPathResource("{associationId}", StringUtils.FromString(publicRequest.AssociationId));

            request.ResourcePath = "/v1/agentspaces/{agentSpaceId}/associations/{associationId}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetCapabilities())
            {
                context.Writer.WritePropertyName("capabilities");
                context.Writer.WriteStartObject();
                foreach (var publicRequestCapabilitiesKvp in publicRequest.Capabilities)
                {
                    context.Writer.WritePropertyName(publicRequestCapabilitiesKvp.Key);
                    var publicRequestCapabilitiesValue = publicRequestCapabilitiesKvp.Value;
                    context.Writer.WriteStartObject();

                    var marshaller = CapabilityConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestCapabilitiesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetConfiguration())
            {
                context.Writer.WritePropertyName("configuration");
                context.Writer.WriteStartObject();

                var marshaller = ServiceConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.Configuration, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            request.HostPrefix = $"cp.";

            return request;
        }

        private static readonly UpdateAssociationRequestMarshaller _instance = new();

        internal static UpdateAssociationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateAssociationRequestMarshaller Instance => _instance;
    }
}
