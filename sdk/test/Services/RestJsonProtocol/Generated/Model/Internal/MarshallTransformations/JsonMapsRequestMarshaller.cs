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
 * Do not modify this file. This file is generated from the rest-json-protocol-2019-12-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RestJsonProtocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#pragma warning disable CS0612,CS0618
namespace Amazon.RestJsonProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// JsonMaps Request Marshaller
    /// </summary>       
    public class JsonMapsRequestMarshaller : IMarshaller<IRequest, JsonMapsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((JsonMapsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(JsonMapsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RestJsonProtocol");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-16";
            request.HttpMethod = "POST";

            request.ResourcePath = "/JsonMaps";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDenseBooleanMap())
            {
                context.Writer.WritePropertyName("denseBooleanMap");
                context.Writer.WriteStartObject();
                foreach (var publicRequestDenseBooleanMapKvp in publicRequest.DenseBooleanMap)
                {
                    context.Writer.WritePropertyName(publicRequestDenseBooleanMapKvp.Key);
                    var publicRequestDenseBooleanMapValue = publicRequestDenseBooleanMapKvp.Value;

                        context.Writer.WriteBooleanValue(publicRequestDenseBooleanMapValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDenseNumberMap())
            {
                context.Writer.WritePropertyName("denseNumberMap");
                context.Writer.WriteStartObject();
                foreach (var publicRequestDenseNumberMapKvp in publicRequest.DenseNumberMap)
                {
                    context.Writer.WritePropertyName(publicRequestDenseNumberMapKvp.Key);
                    var publicRequestDenseNumberMapValue = publicRequestDenseNumberMapKvp.Value;

                        context.Writer.WriteNumberValue(publicRequestDenseNumberMapValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDenseSetMap())
            {
                context.Writer.WritePropertyName("denseSetMap");
                context.Writer.WriteStartObject();
                foreach (var publicRequestDenseSetMapKvp in publicRequest.DenseSetMap)
                {
                    context.Writer.WritePropertyName(publicRequestDenseSetMapKvp.Key);
                    var publicRequestDenseSetMapValue = publicRequestDenseSetMapKvp.Value;

                    context.Writer.WriteStartArray();
                    foreach(var publicRequestDenseSetMapValueListValue in publicRequestDenseSetMapValue)
                    {
                            context.Writer.WriteStringValue(publicRequestDenseSetMapValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDenseStringMap())
            {
                context.Writer.WritePropertyName("denseStringMap");
                context.Writer.WriteStartObject();
                foreach (var publicRequestDenseStringMapKvp in publicRequest.DenseStringMap)
                {
                    context.Writer.WritePropertyName(publicRequestDenseStringMapKvp.Key);
                    var publicRequestDenseStringMapValue = publicRequestDenseStringMapKvp.Value;

                        context.Writer.WriteStringValue(publicRequestDenseStringMapValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDenseStructMap())
            {
                context.Writer.WritePropertyName("denseStructMap");
                context.Writer.WriteStartObject();
                foreach (var publicRequestDenseStructMapKvp in publicRequest.DenseStructMap)
                {
                    context.Writer.WritePropertyName(publicRequestDenseStructMapKvp.Key);
                    var publicRequestDenseStructMapValue = publicRequestDenseStructMapKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = GreetingStructMarshaller.Instance;
                    marshaller.Marshall(publicRequestDenseStructMapValue, context);

                    context.Writer.WriteEndObject();
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
        private static JsonMapsRequestMarshaller _instance = new JsonMapsRequestMarshaller();        

        internal static JsonMapsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static JsonMapsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}