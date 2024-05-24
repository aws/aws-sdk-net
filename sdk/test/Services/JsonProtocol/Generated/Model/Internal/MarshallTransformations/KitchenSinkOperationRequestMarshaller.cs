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
using ThirdParty.Json.LitJson;

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
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBlob())
                {
                    context.Writer.WritePropertyName("Blob");
                    context.Writer.Write(StringUtils.FromMemoryStream(publicRequest.Blob));
                }

                if(publicRequest.IsSetBoolean())
                {
                    context.Writer.WritePropertyName("Boolean");
                    context.Writer.Write(publicRequest.Boolean);
                }

                if(publicRequest.IsSetDouble())
                {
                    context.Writer.WritePropertyName("Double");
                    if(StringUtils.IsSpecialDoubleValue(publicRequest.Double))
                    {
                        context.Writer.Write(StringUtils.FromSpecialDoubleValue(publicRequest.Double));
                    }
                    else
                    {
                        context.Writer.Write(publicRequest.Double);
                    }
                }

                if(publicRequest.IsSetEmptyStruct())
                {
                    context.Writer.WritePropertyName("EmptyStruct");
                    context.Writer.WriteObjectStart();

                    var marshaller = EmptyStructMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EmptyStruct, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetFloat())
                {
                    context.Writer.WritePropertyName("Float");
                    if(StringUtils.IsSpecialFloatValue(publicRequest.Float))
                    {
                        context.Writer.Write(StringUtils.FromSpecialFloatValue(publicRequest.Float));
                    }
                    else
                    {
                        context.Writer.Write(publicRequest.Float);
                    }
                }

                if(publicRequest.IsSetHttpdateTimestamp())
                {
                    context.Writer.WritePropertyName("HttpdateTimestamp");
                    context.Writer.Write(StringUtils.FromDateTimeToRFC822(publicRequest.HttpdateTimestamp));
                }

                if(publicRequest.IsSetInteger())
                {
                    context.Writer.WritePropertyName("Integer");
                    context.Writer.Write(publicRequest.Integer);
                }

                if(publicRequest.IsSetIso8601Timestamp())
                {
                    context.Writer.WritePropertyName("Iso8601Timestamp");
                    context.Writer.Write(StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.Iso8601Timestamp));
                }

                if(publicRequest.IsSetJsonValue())
                {
                    context.Writer.WritePropertyName("JsonValue");
                    context.Writer.Write(publicRequest.JsonValue);
                }

                if(publicRequest.IsSetListOfLists())
                {
                    context.Writer.WritePropertyName("ListOfLists");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestListOfListsListValue in publicRequest.ListOfLists)
                    {
                        context.Writer.WriteArrayStart();
                        foreach(var publicRequestListOfListsListValueListValue in publicRequestListOfListsListValue)
                        {
                                context.Writer.Write(publicRequestListOfListsListValueListValue);
                        }
                        context.Writer.WriteArrayEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetListOfMapsOfStrings())
                {
                    context.Writer.WritePropertyName("ListOfMapsOfStrings");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestListOfMapsOfStringsListValue in publicRequest.ListOfMapsOfStrings)
                    {
                        context.Writer.WriteObjectStart();
                        foreach (var publicRequestListOfMapsOfStringsListValueKvp in publicRequestListOfMapsOfStringsListValue)
                        {
                            context.Writer.WritePropertyName(publicRequestListOfMapsOfStringsListValueKvp.Key);
                            var publicRequestListOfMapsOfStringsListValueValue = publicRequestListOfMapsOfStringsListValueKvp.Value;

                                context.Writer.Write(publicRequestListOfMapsOfStringsListValueValue);
                        }
                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetListOfStrings())
                {
                    context.Writer.WritePropertyName("ListOfStrings");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestListOfStringsListValue in publicRequest.ListOfStrings)
                    {
                            context.Writer.Write(publicRequestListOfStringsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetListOfStructs())
                {
                    context.Writer.WritePropertyName("ListOfStructs");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestListOfStructsListValue in publicRequest.ListOfStructs)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SimpleStructMarshaller.Instance;
                        marshaller.Marshall(publicRequestListOfStructsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetLong())
                {
                    context.Writer.WritePropertyName("Long");
                    context.Writer.Write(publicRequest.Long);
                }

                if(publicRequest.IsSetMapOfListsOfStrings())
                {
                    context.Writer.WritePropertyName("MapOfListsOfStrings");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestMapOfListsOfStringsKvp in publicRequest.MapOfListsOfStrings)
                    {
                        context.Writer.WritePropertyName(publicRequestMapOfListsOfStringsKvp.Key);
                        var publicRequestMapOfListsOfStringsValue = publicRequestMapOfListsOfStringsKvp.Value;

                        context.Writer.WriteArrayStart();
                        foreach(var publicRequestMapOfListsOfStringsValueListValue in publicRequestMapOfListsOfStringsValue)
                        {
                                context.Writer.Write(publicRequestMapOfListsOfStringsValueListValue);
                        }
                        context.Writer.WriteArrayEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMapOfMaps())
                {
                    context.Writer.WritePropertyName("MapOfMaps");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestMapOfMapsKvp in publicRequest.MapOfMaps)
                    {
                        context.Writer.WritePropertyName(publicRequestMapOfMapsKvp.Key);
                        var publicRequestMapOfMapsValue = publicRequestMapOfMapsKvp.Value;

                        context.Writer.WriteObjectStart();
                        foreach (var publicRequestMapOfMapsValueKvp in publicRequestMapOfMapsValue)
                        {
                            context.Writer.WritePropertyName(publicRequestMapOfMapsValueKvp.Key);
                            var publicRequestMapOfMapsValueValue = publicRequestMapOfMapsValueKvp.Value;

                                context.Writer.Write(publicRequestMapOfMapsValueValue);
                        }
                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMapOfStrings())
                {
                    context.Writer.WritePropertyName("MapOfStrings");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestMapOfStringsKvp in publicRequest.MapOfStrings)
                    {
                        context.Writer.WritePropertyName(publicRequestMapOfStringsKvp.Key);
                        var publicRequestMapOfStringsValue = publicRequestMapOfStringsKvp.Value;

                            context.Writer.Write(publicRequestMapOfStringsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMapOfStructs())
                {
                    context.Writer.WritePropertyName("MapOfStructs");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestMapOfStructsKvp in publicRequest.MapOfStructs)
                    {
                        context.Writer.WritePropertyName(publicRequestMapOfStructsKvp.Key);
                        var publicRequestMapOfStructsValue = publicRequestMapOfStructsKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = SimpleStructMarshaller.Instance;
                        marshaller.Marshall(publicRequestMapOfStructsValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRecursiveList())
                {
                    context.Writer.WritePropertyName("RecursiveList");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRecursiveListListValue in publicRequest.RecursiveList)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = KitchenSinkMarshaller.Instance;
                        marshaller.Marshall(publicRequestRecursiveListListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRecursiveMap())
                {
                    context.Writer.WritePropertyName("RecursiveMap");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestRecursiveMapKvp in publicRequest.RecursiveMap)
                    {
                        context.Writer.WritePropertyName(publicRequestRecursiveMapKvp.Key);
                        var publicRequestRecursiveMapValue = publicRequestRecursiveMapKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = KitchenSinkMarshaller.Instance;
                        marshaller.Marshall(publicRequestRecursiveMapValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRecursiveStruct())
                {
                    context.Writer.WritePropertyName("RecursiveStruct");
                    context.Writer.WriteObjectStart();

                    var marshaller = KitchenSinkMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RecursiveStruct, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSimpleStruct())
                {
                    context.Writer.WritePropertyName("SimpleStruct");
                    context.Writer.WriteObjectStart();

                    var marshaller = SimpleStructMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SimpleStruct, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetString())
                {
                    context.Writer.WritePropertyName("String");
                    context.Writer.Write(publicRequest.String);
                }

                if(publicRequest.IsSetStructWithJsonName())
                {
                    context.Writer.WritePropertyName("StructWithJsonName");
                    context.Writer.WriteObjectStart();

                    var marshaller = StructWithJsonNameMarshaller.Instance;
                    marshaller.Marshall(publicRequest.StructWithJsonName, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTimestamp())
                {
                    context.Writer.WritePropertyName("Timestamp");
                    context.Writer.Write(publicRequest.Timestamp);
                }

                if(publicRequest.IsSetUnixTimestamp())
                {
                    context.Writer.WritePropertyName("UnixTimestamp");
                    context.Writer.Write(publicRequest.UnixTimestamp);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


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