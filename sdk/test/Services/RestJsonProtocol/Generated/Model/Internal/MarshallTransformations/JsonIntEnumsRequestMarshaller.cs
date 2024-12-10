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
    /// JsonIntEnums Request Marshaller
    /// </summary>       
    public class JsonIntEnumsRequestMarshaller : IMarshaller<IRequest, JsonIntEnumsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((JsonIntEnumsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(JsonIntEnumsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RestJsonProtocol");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-16";
            request.HttpMethod = "PUT";

            request.ResourcePath = "/JsonIntEnums";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetIntegerEnum1())
            {
                context.Writer.WritePropertyName("integerEnum1");
                context.Writer.WriteNumberValue(publicRequest.IntegerEnum1.Value);
            }

            if(publicRequest.IsSetIntegerEnum2())
            {
                context.Writer.WritePropertyName("integerEnum2");
                context.Writer.WriteNumberValue(publicRequest.IntegerEnum2.Value);
            }

            if(publicRequest.IsSetIntegerEnum3())
            {
                context.Writer.WritePropertyName("integerEnum3");
                context.Writer.WriteNumberValue(publicRequest.IntegerEnum3.Value);
            }

            if(publicRequest.IsSetIntegerEnumList())
            {
                context.Writer.WritePropertyName("integerEnumList");
                context.Writer.WriteStartArray();
                foreach(var publicRequestIntegerEnumListListValue in publicRequest.IntegerEnumList)
                {
                        context.Writer.WriteNumberValue(publicRequestIntegerEnumListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetIntegerEnumMap())
            {
                context.Writer.WritePropertyName("integerEnumMap");
                context.Writer.WriteStartObject();
                foreach (var publicRequestIntegerEnumMapKvp in publicRequest.IntegerEnumMap)
                {
                    context.Writer.WritePropertyName(publicRequestIntegerEnumMapKvp.Key);
                    var publicRequestIntegerEnumMapValue = publicRequestIntegerEnumMapKvp.Value;

                        context.Writer.WriteNumberValue(publicRequestIntegerEnumMapValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetIntegerEnumSet())
            {
                context.Writer.WritePropertyName("integerEnumSet");
                context.Writer.WriteStartArray();
                foreach(var publicRequestIntegerEnumSetListValue in publicRequest.IntegerEnumSet)
                {
                        context.Writer.WriteNumberValue(publicRequestIntegerEnumSetListValue);
                }
                context.Writer.WriteEndArray();
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
        private static JsonIntEnumsRequestMarshaller _instance = new JsonIntEnumsRequestMarshaller();        

        internal static JsonIntEnumsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static JsonIntEnumsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}