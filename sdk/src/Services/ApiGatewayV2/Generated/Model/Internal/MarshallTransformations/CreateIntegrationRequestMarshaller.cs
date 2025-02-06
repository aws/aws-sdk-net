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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApiGatewayV2.Model;
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
namespace Amazon.ApiGatewayV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateIntegration Request Marshaller
    /// </summary>       
    public class CreateIntegrationRequestMarshaller : IMarshaller<IRequest, CreateIntegrationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateIntegrationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateIntegrationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApiGatewayV2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-29";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetApiId())
                throw new AmazonApiGatewayV2Exception("Request object does not have required field ApiId set");
            request.AddPathResource("{apiId}", StringUtils.FromString(publicRequest.ApiId));
            request.ResourcePath = "/v2/apis/{apiId}/integrations";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetConnectionId())
            {
                context.Writer.WritePropertyName("connectionId");
                context.Writer.WriteStringValue(publicRequest.ConnectionId);
            }

            if(publicRequest.IsSetConnectionType())
            {
                context.Writer.WritePropertyName("connectionType");
                context.Writer.WriteStringValue(publicRequest.ConnectionType);
            }

            if(publicRequest.IsSetContentHandlingStrategy())
            {
                context.Writer.WritePropertyName("contentHandlingStrategy");
                context.Writer.WriteStringValue(publicRequest.ContentHandlingStrategy);
            }

            if(publicRequest.IsSetCredentialsArn())
            {
                context.Writer.WritePropertyName("credentialsArn");
                context.Writer.WriteStringValue(publicRequest.CredentialsArn);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetIntegrationMethod())
            {
                context.Writer.WritePropertyName("integrationMethod");
                context.Writer.WriteStringValue(publicRequest.IntegrationMethod);
            }

            if(publicRequest.IsSetIntegrationSubtype())
            {
                context.Writer.WritePropertyName("integrationSubtype");
                context.Writer.WriteStringValue(publicRequest.IntegrationSubtype);
            }

            if(publicRequest.IsSetIntegrationType())
            {
                context.Writer.WritePropertyName("integrationType");
                context.Writer.WriteStringValue(publicRequest.IntegrationType);
            }

            if(publicRequest.IsSetIntegrationUri())
            {
                context.Writer.WritePropertyName("integrationUri");
                context.Writer.WriteStringValue(publicRequest.IntegrationUri);
            }

            if(publicRequest.IsSetPassthroughBehavior())
            {
                context.Writer.WritePropertyName("passthroughBehavior");
                context.Writer.WriteStringValue(publicRequest.PassthroughBehavior);
            }

            if(publicRequest.IsSetPayloadFormatVersion())
            {
                context.Writer.WritePropertyName("payloadFormatVersion");
                context.Writer.WriteStringValue(publicRequest.PayloadFormatVersion);
            }

            if(publicRequest.IsSetRequestParameters())
            {
                context.Writer.WritePropertyName("requestParameters");
                context.Writer.WriteStartObject();
                foreach (var publicRequestRequestParametersKvp in publicRequest.RequestParameters)
                {
                    context.Writer.WritePropertyName(publicRequestRequestParametersKvp.Key);
                    var publicRequestRequestParametersValue = publicRequestRequestParametersKvp.Value;

                        context.Writer.WriteStringValue(publicRequestRequestParametersValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRequestTemplates())
            {
                context.Writer.WritePropertyName("requestTemplates");
                context.Writer.WriteStartObject();
                foreach (var publicRequestRequestTemplatesKvp in publicRequest.RequestTemplates)
                {
                    context.Writer.WritePropertyName(publicRequestRequestTemplatesKvp.Key);
                    var publicRequestRequestTemplatesValue = publicRequestRequestTemplatesKvp.Value;

                        context.Writer.WriteStringValue(publicRequestRequestTemplatesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetResponseParameters())
            {
                context.Writer.WritePropertyName("responseParameters");
                context.Writer.WriteStartObject();
                foreach (var publicRequestResponseParametersKvp in publicRequest.ResponseParameters)
                {
                    context.Writer.WritePropertyName(publicRequestResponseParametersKvp.Key);
                    var publicRequestResponseParametersValue = publicRequestResponseParametersKvp.Value;

                    context.Writer.WriteStartObject();
                    foreach (var publicRequestResponseParametersValueKvp in publicRequestResponseParametersValue)
                    {
                        context.Writer.WritePropertyName(publicRequestResponseParametersValueKvp.Key);
                        var publicRequestResponseParametersValueValue = publicRequestResponseParametersValueKvp.Value;

                            context.Writer.WriteStringValue(publicRequestResponseParametersValueValue);
                    }
                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTemplateSelectionExpression())
            {
                context.Writer.WritePropertyName("templateSelectionExpression");
                context.Writer.WriteStringValue(publicRequest.TemplateSelectionExpression);
            }

            if(publicRequest.IsSetTimeoutInMillis())
            {
                context.Writer.WritePropertyName("timeoutInMillis");
                context.Writer.WriteNumberValue(publicRequest.TimeoutInMillis.Value);
            }

            if(publicRequest.IsSetTlsConfig())
            {
                context.Writer.WritePropertyName("tlsConfig");
                context.Writer.WriteStartObject();

                var marshaller = TlsConfigInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.TlsConfig, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateIntegrationRequestMarshaller _instance = new CreateIntegrationRequestMarshaller();        

        internal static CreateIntegrationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateIntegrationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}