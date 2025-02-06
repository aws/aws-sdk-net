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
    /// PutMethodResponse Request Marshaller
    /// </summary>       
    public class PutMethodResponseRequestMarshaller : IMarshaller<IRequest, PutMethodResponseRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutMethodResponseRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutMethodResponseRequest publicRequest)
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
            request.ResourcePath = "/restapis/{restapi_id}/resources/{resource_id}/methods/{http_method}/responses/{status_code}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
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

                        context.Writer.WriteBooleanValue(publicRequestResponseParametersValue);
                }
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
        private static PutMethodResponseRequestMarshaller _instance = new PutMethodResponseRequestMarshaller();        

        internal static PutMethodResponseRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutMethodResponseRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}