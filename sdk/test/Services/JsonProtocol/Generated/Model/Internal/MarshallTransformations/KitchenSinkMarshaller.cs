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
#pragma warning disable CS0612,CS0618
namespace Amazon.JsonProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// KitchenSink Marshaller
    /// </summary>
    public class KitchenSinkMarshaller : IRequestMarshaller<KitchenSink, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(KitchenSink requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBlob())
            {
                context.Writer.WritePropertyName("Blob");
                context.Writer.WriteStringValue(StringUtils.FromMemoryStream(requestObject.Blob));
            }

            if(requestObject.IsSetBoolean())
            {
                context.Writer.WritePropertyName("Boolean");
                context.Writer.WriteBooleanValue(requestObject.Boolean.Value);
            }

            if(requestObject.IsSetDouble())
            {
                context.Writer.WritePropertyName("Double");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Double.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Double.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Double.Value);
                }
            }

            if(requestObject.IsSetEmptyStruct())
            {
                context.Writer.WritePropertyName("EmptyStruct");
                context.Writer.WriteStartObject();

                var marshaller = EmptyStructMarshaller.Instance;
                marshaller.Marshall(requestObject.EmptyStruct, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFloat())
            {
                context.Writer.WritePropertyName("Float");
                if(StringUtils.IsSpecialFloatValue(requestObject.Float.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialFloatValue(requestObject.Float.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Float.Value);
                }
            }

            if(requestObject.IsSetHttpdateTimestamp())
            {
                context.Writer.WritePropertyName("HttpdateTimestamp");
                context.Writer.WriteStringValue(StringUtils.FromDateTimeToRFC822(requestObject.HttpdateTimestamp));
            }

            if(requestObject.IsSetInteger())
            {
                context.Writer.WritePropertyName("Integer");
                context.Writer.WriteNumberValue(requestObject.Integer.Value);
            }

            if(requestObject.IsSetIso8601Timestamp())
            {
                context.Writer.WritePropertyName("Iso8601Timestamp");
                context.Writer.WriteStringValue(StringUtils.FromDateTimeToISO8601WithOptionalMs(requestObject.Iso8601Timestamp));
            }

            if(requestObject.IsSetJsonValue())
            {
                context.Writer.WritePropertyName("JsonValue");
                context.Writer.WriteStringValue(requestObject.JsonValue);
            }

            if(requestObject.IsSetListOfLists())
            {
                context.Writer.WritePropertyName("ListOfLists");
                context.Writer.WriteStartArray();
                foreach(var requestObjectListOfListsListValue in requestObject.ListOfLists)
                {
                    context.Writer.WriteStartArray();
                    foreach(var requestObjectListOfListsListValueListValue in requestObjectListOfListsListValue)
                    {
                            context.Writer.WriteStringValue(requestObjectListOfListsListValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetListOfMapsOfStrings())
            {
                context.Writer.WritePropertyName("ListOfMapsOfStrings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectListOfMapsOfStringsListValue in requestObject.ListOfMapsOfStrings)
                {
                    context.Writer.WriteStartObject();
                    foreach (var requestObjectListOfMapsOfStringsListValueKvp in requestObjectListOfMapsOfStringsListValue)
                    {
                        context.Writer.WritePropertyName(requestObjectListOfMapsOfStringsListValueKvp.Key);
                        var requestObjectListOfMapsOfStringsListValueValue = requestObjectListOfMapsOfStringsListValueKvp.Value;

                            context.Writer.WriteStringValue(requestObjectListOfMapsOfStringsListValueValue);
                    }
                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetListOfStrings())
            {
                context.Writer.WritePropertyName("ListOfStrings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectListOfStringsListValue in requestObject.ListOfStrings)
                {
                        context.Writer.WriteStringValue(requestObjectListOfStringsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetListOfStructs())
            {
                context.Writer.WritePropertyName("ListOfStructs");
                context.Writer.WriteStartArray();
                foreach(var requestObjectListOfStructsListValue in requestObject.ListOfStructs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SimpleStructMarshaller.Instance;
                    marshaller.Marshall(requestObjectListOfStructsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLong())
            {
                context.Writer.WritePropertyName("Long");
                context.Writer.WriteNumberValue(requestObject.Long.Value);
            }

            if(requestObject.IsSetMapOfListsOfStrings())
            {
                context.Writer.WritePropertyName("MapOfListsOfStrings");
                context.Writer.WriteStartObject();
                foreach (var requestObjectMapOfListsOfStringsKvp in requestObject.MapOfListsOfStrings)
                {
                    context.Writer.WritePropertyName(requestObjectMapOfListsOfStringsKvp.Key);
                    var requestObjectMapOfListsOfStringsValue = requestObjectMapOfListsOfStringsKvp.Value;

                    context.Writer.WriteStartArray();
                    foreach(var requestObjectMapOfListsOfStringsValueListValue in requestObjectMapOfListsOfStringsValue)
                    {
                            context.Writer.WriteStringValue(requestObjectMapOfListsOfStringsValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMapOfMaps())
            {
                context.Writer.WritePropertyName("MapOfMaps");
                context.Writer.WriteStartObject();
                foreach (var requestObjectMapOfMapsKvp in requestObject.MapOfMaps)
                {
                    context.Writer.WritePropertyName(requestObjectMapOfMapsKvp.Key);
                    var requestObjectMapOfMapsValue = requestObjectMapOfMapsKvp.Value;

                    context.Writer.WriteStartObject();
                    foreach (var requestObjectMapOfMapsValueKvp in requestObjectMapOfMapsValue)
                    {
                        context.Writer.WritePropertyName(requestObjectMapOfMapsValueKvp.Key);
                        var requestObjectMapOfMapsValueValue = requestObjectMapOfMapsValueKvp.Value;

                            context.Writer.WriteStringValue(requestObjectMapOfMapsValueValue);
                    }
                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMapOfStrings())
            {
                context.Writer.WritePropertyName("MapOfStrings");
                context.Writer.WriteStartObject();
                foreach (var requestObjectMapOfStringsKvp in requestObject.MapOfStrings)
                {
                    context.Writer.WritePropertyName(requestObjectMapOfStringsKvp.Key);
                    var requestObjectMapOfStringsValue = requestObjectMapOfStringsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectMapOfStringsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMapOfStructs())
            {
                context.Writer.WritePropertyName("MapOfStructs");
                context.Writer.WriteStartObject();
                foreach (var requestObjectMapOfStructsKvp in requestObject.MapOfStructs)
                {
                    context.Writer.WritePropertyName(requestObjectMapOfStructsKvp.Key);
                    var requestObjectMapOfStructsValue = requestObjectMapOfStructsKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = SimpleStructMarshaller.Instance;
                    marshaller.Marshall(requestObjectMapOfStructsValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRecursiveList())
            {
                context.Writer.WritePropertyName("RecursiveList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRecursiveListListValue in requestObject.RecursiveList)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = KitchenSinkMarshaller.Instance;
                    marshaller.Marshall(requestObjectRecursiveListListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRecursiveMap())
            {
                context.Writer.WritePropertyName("RecursiveMap");
                context.Writer.WriteStartObject();
                foreach (var requestObjectRecursiveMapKvp in requestObject.RecursiveMap)
                {
                    context.Writer.WritePropertyName(requestObjectRecursiveMapKvp.Key);
                    var requestObjectRecursiveMapValue = requestObjectRecursiveMapKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = KitchenSinkMarshaller.Instance;
                    marshaller.Marshall(requestObjectRecursiveMapValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRecursiveStruct())
            {
                context.Writer.WritePropertyName("RecursiveStruct");
                context.Writer.WriteStartObject();

                var marshaller = KitchenSinkMarshaller.Instance;
                marshaller.Marshall(requestObject.RecursiveStruct, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSimpleStruct())
            {
                context.Writer.WritePropertyName("SimpleStruct");
                context.Writer.WriteStartObject();

                var marshaller = SimpleStructMarshaller.Instance;
                marshaller.Marshall(requestObject.SimpleStruct, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetString())
            {
                context.Writer.WritePropertyName("String");
                context.Writer.WriteStringValue(requestObject.String);
            }

            if(requestObject.IsSetStructWithJsonName())
            {
                context.Writer.WritePropertyName("StructWithJsonName");
                context.Writer.WriteStartObject();

                var marshaller = StructWithJsonNameMarshaller.Instance;
                marshaller.Marshall(requestObject.StructWithJsonName, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTimestamp())
            {
                context.Writer.WritePropertyName("Timestamp");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.Timestamp.Value)));
            }

            if(requestObject.IsSetUnixTimestamp())
            {
                context.Writer.WritePropertyName("UnixTimestamp");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.UnixTimestamp.Value)));
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static KitchenSinkMarshaller Instance = new KitchenSinkMarshaller();

    }
}