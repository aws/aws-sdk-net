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
    /// KitchenSinkOperation Request Marshaller
    /// </summary>       
    public class KitchenSinkOperationRequestMarshaller : IMarshaller<IRequest, KitchenSinkOperationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((KitchenSinkOperationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(KitchenSinkOperationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.JsonProtocol");
            string target = "JsonProtocol.KitchenSinkOperation";
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
            if(publicRequest.IsSetBlob())
            {
                context.Writer.WritePropertyName("Blob");
                context.Writer.WriteStringValue(StringUtils.FromMemoryStream(publicRequest.Blob));
            }

            if(publicRequest.IsSetBoolean())
            {
                context.Writer.WritePropertyName("Boolean");
                context.Writer.WriteBooleanValue(publicRequest.Boolean.Value);
            }

            if(publicRequest.IsSetDouble())
            {
                context.Writer.WritePropertyName("Double");
                if(StringUtils.IsSpecialDoubleValue(publicRequest.Double.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(publicRequest.Double.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(publicRequest.Double.Value);
                }
            }

            if(publicRequest.IsSetEmptyStruct())
            {
                context.Writer.WritePropertyName("EmptyStruct");
                context.Writer.WriteStartObject();

                var marshaller = EmptyStructMarshaller.Instance;
                marshaller.Marshall(publicRequest.EmptyStruct, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetFloat())
            {
                context.Writer.WritePropertyName("Float");
                if(StringUtils.IsSpecialFloatValue(publicRequest.Float.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialFloatValue(publicRequest.Float.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(publicRequest.Float.Value);
                }
            }

            if(publicRequest.IsSetHttpdateTimestamp())
            {
                context.Writer.WritePropertyName("HttpdateTimestamp");
                context.Writer.WriteStringValue(StringUtils.FromDateTimeToRFC822(publicRequest.HttpdateTimestamp));
            }

            if(publicRequest.IsSetInteger())
            {
                context.Writer.WritePropertyName("Integer");
                context.Writer.WriteNumberValue(publicRequest.Integer.Value);
            }

            if(publicRequest.IsSetIso8601Timestamp())
            {
                context.Writer.WritePropertyName("Iso8601Timestamp");
                context.Writer.WriteStringValue(StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.Iso8601Timestamp));
            }

            if(publicRequest.IsSetJsonValue())
            {
                context.Writer.WritePropertyName("JsonValue");
                context.Writer.WriteStringValue(publicRequest.JsonValue);
            }

            if(publicRequest.IsSetListOfLists())
            {
                context.Writer.WritePropertyName("ListOfLists");
                context.Writer.WriteStartArray();
                foreach(var publicRequestListOfListsListValue in publicRequest.ListOfLists)
                {
                    context.Writer.WriteStartArray();
                    foreach(var publicRequestListOfListsListValueListValue in publicRequestListOfListsListValue)
                    {
                            context.Writer.WriteStringValue(publicRequestListOfListsListValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetListOfMapsOfStrings())
            {
                context.Writer.WritePropertyName("ListOfMapsOfStrings");
                context.Writer.WriteStartArray();
                foreach(var publicRequestListOfMapsOfStringsListValue in publicRequest.ListOfMapsOfStrings)
                {
                    context.Writer.WriteStartObject();
                    foreach (var publicRequestListOfMapsOfStringsListValueKvp in publicRequestListOfMapsOfStringsListValue)
                    {
                        context.Writer.WritePropertyName(publicRequestListOfMapsOfStringsListValueKvp.Key);
                        var publicRequestListOfMapsOfStringsListValueValue = publicRequestListOfMapsOfStringsListValueKvp.Value;

                            context.Writer.WriteStringValue(publicRequestListOfMapsOfStringsListValueValue);
                    }
                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetListOfStrings())
            {
                context.Writer.WritePropertyName("ListOfStrings");
                context.Writer.WriteStartArray();
                foreach(var publicRequestListOfStringsListValue in publicRequest.ListOfStrings)
                {
                        context.Writer.WriteStringValue(publicRequestListOfStringsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetListOfStructs())
            {
                context.Writer.WritePropertyName("ListOfStructs");
                context.Writer.WriteStartArray();
                foreach(var publicRequestListOfStructsListValue in publicRequest.ListOfStructs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SimpleStructMarshaller.Instance;
                    marshaller.Marshall(publicRequestListOfStructsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetLong())
            {
                context.Writer.WritePropertyName("Long");
                context.Writer.WriteNumberValue(publicRequest.Long.Value);
            }

            if(publicRequest.IsSetMapOfListsOfStrings())
            {
                context.Writer.WritePropertyName("MapOfListsOfStrings");
                context.Writer.WriteStartObject();
                foreach (var publicRequestMapOfListsOfStringsKvp in publicRequest.MapOfListsOfStrings)
                {
                    context.Writer.WritePropertyName(publicRequestMapOfListsOfStringsKvp.Key);
                    var publicRequestMapOfListsOfStringsValue = publicRequestMapOfListsOfStringsKvp.Value;

                    context.Writer.WriteStartArray();
                    foreach(var publicRequestMapOfListsOfStringsValueListValue in publicRequestMapOfListsOfStringsValue)
                    {
                            context.Writer.WriteStringValue(publicRequestMapOfListsOfStringsValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMapOfMaps())
            {
                context.Writer.WritePropertyName("MapOfMaps");
                context.Writer.WriteStartObject();
                foreach (var publicRequestMapOfMapsKvp in publicRequest.MapOfMaps)
                {
                    context.Writer.WritePropertyName(publicRequestMapOfMapsKvp.Key);
                    var publicRequestMapOfMapsValue = publicRequestMapOfMapsKvp.Value;

                    context.Writer.WriteStartObject();
                    foreach (var publicRequestMapOfMapsValueKvp in publicRequestMapOfMapsValue)
                    {
                        context.Writer.WritePropertyName(publicRequestMapOfMapsValueKvp.Key);
                        var publicRequestMapOfMapsValueValue = publicRequestMapOfMapsValueKvp.Value;

                            context.Writer.WriteStringValue(publicRequestMapOfMapsValueValue);
                    }
                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMapOfStrings())
            {
                context.Writer.WritePropertyName("MapOfStrings");
                context.Writer.WriteStartObject();
                foreach (var publicRequestMapOfStringsKvp in publicRequest.MapOfStrings)
                {
                    context.Writer.WritePropertyName(publicRequestMapOfStringsKvp.Key);
                    var publicRequestMapOfStringsValue = publicRequestMapOfStringsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestMapOfStringsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMapOfStructs())
            {
                context.Writer.WritePropertyName("MapOfStructs");
                context.Writer.WriteStartObject();
                foreach (var publicRequestMapOfStructsKvp in publicRequest.MapOfStructs)
                {
                    context.Writer.WritePropertyName(publicRequestMapOfStructsKvp.Key);
                    var publicRequestMapOfStructsValue = publicRequestMapOfStructsKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = SimpleStructMarshaller.Instance;
                    marshaller.Marshall(publicRequestMapOfStructsValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRecursiveList())
            {
                context.Writer.WritePropertyName("RecursiveList");
                context.Writer.WriteStartArray();
                foreach(var publicRequestRecursiveListListValue in publicRequest.RecursiveList)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = KitchenSinkMarshaller.Instance;
                    marshaller.Marshall(publicRequestRecursiveListListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetRecursiveMap())
            {
                context.Writer.WritePropertyName("RecursiveMap");
                context.Writer.WriteStartObject();
                foreach (var publicRequestRecursiveMapKvp in publicRequest.RecursiveMap)
                {
                    context.Writer.WritePropertyName(publicRequestRecursiveMapKvp.Key);
                    var publicRequestRecursiveMapValue = publicRequestRecursiveMapKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = KitchenSinkMarshaller.Instance;
                    marshaller.Marshall(publicRequestRecursiveMapValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRecursiveStruct())
            {
                context.Writer.WritePropertyName("RecursiveStruct");
                context.Writer.WriteStartObject();

                var marshaller = KitchenSinkMarshaller.Instance;
                marshaller.Marshall(publicRequest.RecursiveStruct, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSimpleStruct())
            {
                context.Writer.WritePropertyName("SimpleStruct");
                context.Writer.WriteStartObject();

                var marshaller = SimpleStructMarshaller.Instance;
                marshaller.Marshall(publicRequest.SimpleStruct, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetString())
            {
                context.Writer.WritePropertyName("String");
                context.Writer.WriteStringValue(publicRequest.String);
            }

            if(publicRequest.IsSetStructWithJsonName())
            {
                context.Writer.WritePropertyName("StructWithJsonName");
                context.Writer.WriteStartObject();

                var marshaller = StructWithJsonNameMarshaller.Instance;
                marshaller.Marshall(publicRequest.StructWithJsonName, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTimestamp())
            {
                context.Writer.WritePropertyName("Timestamp");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.Timestamp.Value)));
            }

            if(publicRequest.IsSetUnixTimestamp())
            {
                context.Writer.WritePropertyName("UnixTimestamp");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.UnixTimestamp.Value)));
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
        private static KitchenSinkOperationRequestMarshaller _instance = new KitchenSinkOperationRequestMarshaller();        

        internal static KitchenSinkOperationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static KitchenSinkOperationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}