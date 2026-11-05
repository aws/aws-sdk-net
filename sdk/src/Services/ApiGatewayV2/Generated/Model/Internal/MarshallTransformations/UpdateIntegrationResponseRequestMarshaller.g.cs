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

using Amazon.ApiGatewayV2.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.ApiGatewayV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateIntegrationResponse Request Marshaller
    /// </summary>
    public partial class UpdateIntegrationResponseRequestMarshaller : IMarshaller<IRequest, UpdateIntegrationResponseRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateIntegrationResponseRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateIntegrationResponseRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApiGatewayV2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-29";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetApiId())
            {
                throw new AmazonApiGatewayV2Exception("Request object does not have required field ApiId set");
            }
            request.AddPathResource("{ApiId}", StringUtils.FromString(publicRequest.ApiId));

            if (!publicRequest.IsSetIntegrationId())
            {
                throw new AmazonApiGatewayV2Exception("Request object does not have required field IntegrationId set");
            }
            request.AddPathResource("{IntegrationId}", StringUtils.FromString(publicRequest.IntegrationId));

            if (!publicRequest.IsSetIntegrationResponseId())
            {
                throw new AmazonApiGatewayV2Exception("Request object does not have required field IntegrationResponseId set");
            }
            request.AddPathResource("{IntegrationResponseId}", StringUtils.FromString(publicRequest.IntegrationResponseId));

            request.ResourcePath = "/v2/apis/{ApiId}/integrations/{IntegrationId}/integrationresponses/{IntegrationResponseId}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetContentHandlingStrategy())
            {
                context.Writer.WritePropertyName("contentHandlingStrategy");
                context.Writer.WriteStringValue(publicRequest.ContentHandlingStrategy);
            }
            if (publicRequest.IsSetIntegrationResponseKey())
            {
                context.Writer.WritePropertyName("integrationResponseKey");
                context.Writer.WriteStringValue(publicRequest.IntegrationResponseKey);
            }
            if (publicRequest.IsSetResponseParameters())
            {
                context.Writer.WritePropertyName("responseParameters");
                context.Writer.WriteStartObject();
                foreach (var publicRequestResponseParametersKvp in publicRequest.ResponseParameters)
                {
                    context.Writer.WritePropertyName(publicRequestResponseParametersKvp.Key);
                    var publicRequestResponseParametersValue = publicRequestResponseParametersKvp.Value;
                    context.Writer.WriteStringValue(publicRequestResponseParametersValue);
                }
                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetResponseTemplates())
            {
                context.Writer.WritePropertyName("responseTemplates");
                context.Writer.WriteStartObject();
                foreach (var publicRequestResponseTemplatesKvp in publicRequest.ResponseTemplates)
                {
                    context.Writer.WritePropertyName(publicRequestResponseTemplatesKvp.Key);
                    var publicRequestResponseTemplatesValue = publicRequestResponseTemplatesKvp.Value;
                    context.Writer.WriteStringValue(publicRequestResponseTemplatesValue);
                }
                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetTemplateSelectionExpression())
            {
                context.Writer.WritePropertyName("templateSelectionExpression");
                context.Writer.WriteStringValue(publicRequest.TemplateSelectionExpression);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateIntegrationResponseRequestMarshaller _instance = new();

        internal static UpdateIntegrationResponseRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateIntegrationResponseRequestMarshaller Instance => _instance;
    }
}
