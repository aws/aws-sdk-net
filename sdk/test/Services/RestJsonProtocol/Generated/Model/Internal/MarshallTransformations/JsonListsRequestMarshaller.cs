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
    /// JsonLists Request Marshaller
    /// </summary>       
    public class JsonListsRequestMarshaller : IMarshaller<IRequest, JsonListsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((JsonListsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(JsonListsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RestJsonProtocol");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-16";
            request.HttpMethod = "PUT";

            request.ResourcePath = "/JsonLists";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetBooleanList())
            {
                context.Writer.WritePropertyName("booleanList");
                context.Writer.WriteStartArray();
                foreach(var publicRequestBooleanListListValue in publicRequest.BooleanList)
                {
                        context.Writer.WriteBooleanValue(publicRequestBooleanListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetEnumList())
            {
                context.Writer.WritePropertyName("enumList");
                context.Writer.WriteStartArray();
                foreach(var publicRequestEnumListListValue in publicRequest.EnumList)
                {
                        context.Writer.WriteStringValue(publicRequestEnumListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetIntegerList())
            {
                context.Writer.WritePropertyName("integerList");
                context.Writer.WriteStartArray();
                foreach(var publicRequestIntegerListListValue in publicRequest.IntegerList)
                {
                        context.Writer.WriteNumberValue(publicRequestIntegerListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetIntEnumList())
            {
                context.Writer.WritePropertyName("intEnumList");
                context.Writer.WriteStartArray();
                foreach(var publicRequestIntEnumListListValue in publicRequest.IntEnumList)
                {
                        context.Writer.WriteNumberValue(publicRequestIntEnumListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetNestedStringList())
            {
                context.Writer.WritePropertyName("nestedStringList");
                context.Writer.WriteStartArray();
                foreach(var publicRequestNestedStringListListValue in publicRequest.NestedStringList)
                {
                    context.Writer.WriteStartArray();
                    foreach(var publicRequestNestedStringListListValueListValue in publicRequestNestedStringListListValue)
                    {
                            context.Writer.WriteStringValue(publicRequestNestedStringListListValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetStringList())
            {
                context.Writer.WritePropertyName("stringList");
                context.Writer.WriteStartArray();
                foreach(var publicRequestStringListListValue in publicRequest.StringList)
                {
                        context.Writer.WriteStringValue(publicRequestStringListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetStringSet())
            {
                context.Writer.WritePropertyName("stringSet");
                context.Writer.WriteStartArray();
                foreach(var publicRequestStringSetListValue in publicRequest.StringSet)
                {
                        context.Writer.WriteStringValue(publicRequestStringSetListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetStructureList())
            {
                context.Writer.WritePropertyName("myStructureList");
                context.Writer.WriteStartArray();
                foreach(var publicRequestStructureListListValue in publicRequest.StructureList)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StructureListMemberMarshaller.Instance;
                    marshaller.Marshall(publicRequestStructureListListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTimestampList())
            {
                context.Writer.WritePropertyName("timestampList");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTimestampListListValue in publicRequest.TimestampList)
                {
                        context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequestTimestampListListValue)));
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
        private static JsonListsRequestMarshaller _instance = new JsonListsRequestMarshaller();        

        internal static JsonListsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static JsonListsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}