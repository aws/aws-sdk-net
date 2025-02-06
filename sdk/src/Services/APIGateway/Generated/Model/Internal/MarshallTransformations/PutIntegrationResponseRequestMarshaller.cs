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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.APIGateway.Model;
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
namespace Amazon.APIGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutIntegrationResponse Request Marshaller
    /// </summary>       
    public class PutIntegrationResponseRequestMarshaller : IMarshaller<IRequest, PutIntegrationResponseRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutIntegrationResponseRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutIntegrationResponseRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.APIGateway");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-07-09";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetHttpMethod())
                throw new AmazonAPIGatewayException("Request object does not have required field HttpMethod set");
            request.AddPathResource("{http_method}", StringUtils.FromString(publicRequest.HttpMethod));
            if (!publicRequest.IsSetResourceId())
                throw new AmazonAPIGatewayException("Request object does not have required field ResourceId set");
            request.AddPathResource("{resource_id}", StringUtils.FromString(publicRequest.ResourceId));
            if (!publicRequest.IsSetRestApiId())
                throw new AmazonAPIGatewayException("Request object does not have required field RestApiId set");
            request.AddPathResource("{restapi_id}", StringUtils.FromString(publicRequest.RestApiId));
            if (!publicRequest.IsSetStatusCode())
                throw new AmazonAPIGatewayException("Request object does not have required field StatusCode set");
            request.AddPathResource("{status_code}", StringUtils.FromString(publicRequest.StatusCode));
            request.ResourcePath = "/restapis/{restapi_id}/resources/{resource_id}/methods/{http_method}/integration/responses/{status_code}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetContentHandling())
            {
                context.Writer.WritePropertyName("contentHandling");
                context.Writer.WriteStringValue(publicRequest.ContentHandling);
            }

            if(publicRequest.IsSetResponseParameters())
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

            if(publicRequest.IsSetResponseTemplates())
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

            if(publicRequest.IsSetSelectionPattern())
            {
                context.Writer.WritePropertyName("selectionPattern");
                context.Writer.WriteStringValue(publicRequest.SelectionPattern);
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
        private static PutIntegrationResponseRequestMarshaller _instance = new PutIntegrationResponseRequestMarshaller();        

        internal static PutIntegrationResponseRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutIntegrationResponseRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}