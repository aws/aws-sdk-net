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
    /// PutMethod Request Marshaller
    /// </summary>       
    public class PutMethodRequestMarshaller : IMarshaller<IRequest, PutMethodRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutMethodRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutMethodRequest publicRequest)
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
            request.ResourcePath = "/restapis/{restapi_id}/resources/{resource_id}/methods/{http_method}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetApiKeyRequired())
            {
                context.Writer.WritePropertyName("apiKeyRequired");
                context.Writer.WriteBooleanValue(publicRequest.ApiKeyRequired.Value);
            }

            if(publicRequest.IsSetAuthorizationScopes())
            {
                context.Writer.WritePropertyName("authorizationScopes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAuthorizationScopesListValue in publicRequest.AuthorizationScopes)
                {
                        context.Writer.WriteStringValue(publicRequestAuthorizationScopesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetAuthorizationType())
            {
                context.Writer.WritePropertyName("authorizationType");
                context.Writer.WriteStringValue(publicRequest.AuthorizationType);
            }

            if(publicRequest.IsSetAuthorizerId())
            {
                context.Writer.WritePropertyName("authorizerId");
                context.Writer.WriteStringValue(publicRequest.AuthorizerId);
            }

            if(publicRequest.IsSetOperationName())
            {
                context.Writer.WritePropertyName("operationName");
                context.Writer.WriteStringValue(publicRequest.OperationName);
            }

            if(publicRequest.IsSetRequestModels())
            {
                context.Writer.WritePropertyName("requestModels");
                context.Writer.WriteStartObject();
                foreach (var publicRequestRequestModelsKvp in publicRequest.RequestModels)
                {
                    context.Writer.WritePropertyName(publicRequestRequestModelsKvp.Key);
                    var publicRequestRequestModelsValue = publicRequestRequestModelsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestRequestModelsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRequestParameters())
            {
                context.Writer.WritePropertyName("requestParameters");
                context.Writer.WriteStartObject();
                foreach (var publicRequestRequestParametersKvp in publicRequest.RequestParameters)
                {
                    context.Writer.WritePropertyName(publicRequestRequestParametersKvp.Key);
                    var publicRequestRequestParametersValue = publicRequestRequestParametersKvp.Value;

                        context.Writer.WriteBooleanValue(publicRequestRequestParametersValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRequestValidatorId())
            {
                context.Writer.WritePropertyName("requestValidatorId");
                context.Writer.WriteStringValue(publicRequest.RequestValidatorId);
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
        private static PutMethodRequestMarshaller _instance = new PutMethodRequestMarshaller();        

        internal static PutMethodRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutMethodRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}