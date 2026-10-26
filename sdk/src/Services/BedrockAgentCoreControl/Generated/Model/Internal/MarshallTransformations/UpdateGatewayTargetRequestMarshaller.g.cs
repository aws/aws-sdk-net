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

using Amazon.BedrockAgentCoreControl.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.BedrockAgentCoreControl.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateGatewayTarget Request Marshaller
    /// </summary>
    public partial class UpdateGatewayTargetRequestMarshaller : IMarshaller<IRequest, UpdateGatewayTargetRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateGatewayTargetRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateGatewayTargetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentCoreControl");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-06-05";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetGatewayIdentifier())
            {
                throw new AmazonBedrockAgentCoreControlException("Request object does not have required field GatewayIdentifier set");
            }
            request.AddPathResource("{gatewayIdentifier}", StringUtils.FromString(publicRequest.GatewayIdentifier));

            if (!publicRequest.IsSetTargetId())
            {
                throw new AmazonBedrockAgentCoreControlException("Request object does not have required field TargetId set");
            }
            request.AddPathResource("{targetId}", StringUtils.FromString(publicRequest.TargetId));

            request.ResourcePath = "/gateways/{gatewayIdentifier}/targets/{targetId}/";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetCertificateConfigurations())
            {
                context.Writer.WritePropertyName("certificateConfigurations");
                context.Writer.WriteStartArray();
                foreach (var publicRequestCertificateConfigurationsListValue in publicRequest.CertificateConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CertificateConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestCertificateConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetCredentialProviderConfigurations())
            {
                context.Writer.WritePropertyName("credentialProviderConfigurations");
                context.Writer.WriteStartArray();
                foreach (var publicRequestCredentialProviderConfigurationsListValue in publicRequest.CredentialProviderConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CredentialProviderConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestCredentialProviderConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }
            if (publicRequest.IsSetMetadataConfiguration())
            {
                context.Writer.WritePropertyName("metadataConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = MetadataConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.MetadataConfiguration, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }
            if (publicRequest.IsSetPrivateEndpoint())
            {
                context.Writer.WritePropertyName("privateEndpoint");
                context.Writer.WriteStartObject();

                var marshaller = PrivateEndpointMarshaller.Instance;
                marshaller.Marshall(publicRequest.PrivateEndpoint, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetTargetConfiguration())
            {
                context.Writer.WritePropertyName("targetConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = TargetConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.TargetConfiguration, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateGatewayTargetRequestMarshaller _instance = new();

        internal static UpdateGatewayTargetRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateGatewayTargetRequestMarshaller Instance => _instance;
    }
}
