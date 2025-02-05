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
    /// CreateRouteResponse Request Marshaller
    /// </summary>       
    public class CreateRouteResponseRequestMarshaller : IMarshaller<IRequest, CreateRouteResponseRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateRouteResponseRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateRouteResponseRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApiGatewayV2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-29";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetApiId())
                throw new AmazonApiGatewayV2Exception("Request object does not have required field ApiId set");
            request.AddPathResource("{apiId}", StringUtils.FromString(publicRequest.ApiId));
            if (!publicRequest.IsSetRouteId())
                throw new AmazonApiGatewayV2Exception("Request object does not have required field RouteId set");
            request.AddPathResource("{routeId}", StringUtils.FromString(publicRequest.RouteId));
            request.ResourcePath = "/v2/apis/{apiId}/routes/{routeId}/routeresponses";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetModelSelectionExpression())
            {
                context.Writer.WritePropertyName("modelSelectionExpression");
                context.Writer.WriteStringValue(publicRequest.ModelSelectionExpression);
            }

            if(publicRequest.IsSetResponseModels())
            {
                context.Writer.WritePropertyName("responseModels");
                context.Writer.WriteStartObject();
                foreach (var publicRequestResponseModelsKvp in publicRequest.ResponseModels)
                {
                    context.Writer.WritePropertyName(publicRequestResponseModelsKvp.Key);
                    var publicRequestResponseModelsValue = publicRequestResponseModelsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestResponseModelsValue);
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

                    var marshaller = ParameterConstraintsMarshaller.Instance;
                    marshaller.Marshall(publicRequestResponseParametersValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRouteResponseKey())
            {
                context.Writer.WritePropertyName("routeResponseKey");
                context.Writer.WriteStringValue(publicRequest.RouteResponseKey);
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
        private static CreateRouteResponseRequestMarshaller _instance = new CreateRouteResponseRequestMarshaller();        

        internal static CreateRouteResponseRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateRouteResponseRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}