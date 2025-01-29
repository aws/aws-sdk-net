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
    /// TestInvokeMethod Request Marshaller
    /// </summary>       
    public class TestInvokeMethodRequestMarshaller : IMarshaller<IRequest, TestInvokeMethodRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((TestInvokeMethodRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(TestInvokeMethodRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.APIGateway");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-07-09";
            request.HttpMethod = "POST";

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
            if(publicRequest.IsSetBody())
            {
                context.Writer.WritePropertyName("body");
                context.Writer.WriteStringValue(publicRequest.Body);
            }

            if(publicRequest.IsSetClientCertificateId())
            {
                context.Writer.WritePropertyName("clientCertificateId");
                context.Writer.WriteStringValue(publicRequest.ClientCertificateId);
            }

            if(publicRequest.IsSetHeaders())
            {
                context.Writer.WritePropertyName("headers");
                context.Writer.WriteStartObject();
                foreach (var publicRequestHeadersKvp in publicRequest.Headers)
                {
                    context.Writer.WritePropertyName(publicRequestHeadersKvp.Key);
                    var publicRequestHeadersValue = publicRequestHeadersKvp.Value;

                        context.Writer.WriteStringValue(publicRequestHeadersValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMultiValueHeaders())
            {
                context.Writer.WritePropertyName("multiValueHeaders");
                context.Writer.WriteStartObject();
                foreach (var publicRequestMultiValueHeadersKvp in publicRequest.MultiValueHeaders)
                {
                    context.Writer.WritePropertyName(publicRequestMultiValueHeadersKvp.Key);
                    var publicRequestMultiValueHeadersValue = publicRequestMultiValueHeadersKvp.Value;

                    context.Writer.WriteStartArray();
                    foreach(var publicRequestMultiValueHeadersValueListValue in publicRequestMultiValueHeadersValue)
                    {
                            context.Writer.WriteStringValue(publicRequestMultiValueHeadersValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPathWithQueryString())
            {
                context.Writer.WritePropertyName("pathWithQueryString");
                context.Writer.WriteStringValue(publicRequest.PathWithQueryString);
            }

            if(publicRequest.IsSetStageVariables())
            {
                context.Writer.WritePropertyName("stageVariables");
                context.Writer.WriteStartObject();
                foreach (var publicRequestStageVariablesKvp in publicRequest.StageVariables)
                {
                    context.Writer.WritePropertyName(publicRequestStageVariablesKvp.Key);
                    var publicRequestStageVariablesValue = publicRequestStageVariablesKvp.Value;

                        context.Writer.WriteStringValue(publicRequestStageVariablesValue);
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
        private static TestInvokeMethodRequestMarshaller _instance = new TestInvokeMethodRequestMarshaller();        

        internal static TestInvokeMethodRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TestInvokeMethodRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}