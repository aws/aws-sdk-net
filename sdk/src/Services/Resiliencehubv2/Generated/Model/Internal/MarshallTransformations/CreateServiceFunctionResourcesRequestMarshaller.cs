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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Resiliencehubv2.Model;
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
namespace Amazon.Resiliencehubv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateServiceFunctionResources Request Marshaller
    /// </summary>       
    public class CreateServiceFunctionResourcesRequestMarshaller : IMarshaller<IRequest, CreateServiceFunctionResourcesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateServiceFunctionResourcesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateServiceFunctionResourcesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Resiliencehubv2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2026-02-17";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v2/create-service-function-resources";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetResources())
            {
                context.Writer.WritePropertyName("resources");
                context.Writer.WriteStartArray();
                foreach(var publicRequestResourcesListValue in publicRequest.Resources)
                {
                        context.Writer.WriteStringValue(publicRequestResourcesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetServiceArn())
            {
                context.Writer.WritePropertyName("serviceArn");
                context.Writer.WriteStringValue(publicRequest.ServiceArn);
            }

            if(publicRequest.IsSetServiceFunctionId())
            {
                context.Writer.WritePropertyName("serviceFunctionId");
                context.Writer.WriteStringValue(publicRequest.ServiceFunctionId);
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
        private static CreateServiceFunctionResourcesRequestMarshaller _instance = new CreateServiceFunctionResourcesRequestMarshaller();        

        internal static CreateServiceFunctionResourcesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateServiceFunctionResourcesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}