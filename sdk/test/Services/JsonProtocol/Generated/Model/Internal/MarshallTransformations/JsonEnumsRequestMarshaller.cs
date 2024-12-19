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
 * Do not modify this file. This file is generated from the json-protocol-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.JsonProtocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#pragma warning disable CS0612,CS0618
namespace Amazon.JsonProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// JsonEnums Request Marshaller
    /// </summary>       
    public class JsonEnumsRequestMarshaller : IMarshaller<IRequest, JsonEnumsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((JsonEnumsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(JsonEnumsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.JsonProtocol");
            string target = "JsonProtocol.JsonEnums";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-01-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetFooEnum1())
            {
                context.Writer.WritePropertyName("fooEnum1");
                context.Writer.WriteStringValue(publicRequest.FooEnum1);
            }

            if(publicRequest.IsSetFooEnum2())
            {
                context.Writer.WritePropertyName("fooEnum2");
                context.Writer.WriteStringValue(publicRequest.FooEnum2);
            }

            if(publicRequest.IsSetFooEnum3())
            {
                context.Writer.WritePropertyName("fooEnum3");
                context.Writer.WriteStringValue(publicRequest.FooEnum3);
            }

            if(publicRequest.IsSetFooEnumList())
            {
                context.Writer.WritePropertyName("fooEnumList");
                context.Writer.WriteStartArray();
                foreach(var publicRequestFooEnumListListValue in publicRequest.FooEnumList)
                {
                        context.Writer.WriteStringValue(publicRequestFooEnumListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetFooEnumMap())
            {
                context.Writer.WritePropertyName("fooEnumMap");
                context.Writer.WriteStartObject();
                foreach (var publicRequestFooEnumMapKvp in publicRequest.FooEnumMap)
                {
                    context.Writer.WritePropertyName(publicRequestFooEnumMapKvp.Key);
                    var publicRequestFooEnumMapValue = publicRequestFooEnumMapKvp.Value;

                        context.Writer.WriteStringValue(publicRequestFooEnumMapValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetFooEnumSet())
            {
                context.Writer.WritePropertyName("fooEnumSet");
                context.Writer.WriteStartArray();
                foreach(var publicRequestFooEnumSetListValue in publicRequest.FooEnumSet)
                {
                        context.Writer.WriteStringValue(publicRequestFooEnumSetListValue);
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
        private static JsonEnumsRequestMarshaller _instance = new JsonEnumsRequestMarshaller();        

        internal static JsonEnumsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static JsonEnumsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}