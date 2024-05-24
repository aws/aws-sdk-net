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
                context.Writer.Write(StringUtils.FromMemoryStream(requestObject.Blob));
            }

            if(requestObject.IsSetBoolean())
            {
                context.Writer.WritePropertyName("Boolean");
                context.Writer.Write(requestObject.Boolean);
            }

            if(requestObject.IsSetDouble())
            {
                context.Writer.WritePropertyName("Double");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Double))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.Double));
                }
                else
                {
                    context.Writer.Write(requestObject.Double);
                }
            }

            if(requestObject.IsSetEmptyStruct())
            {
                context.Writer.WritePropertyName("EmptyStruct");
                context.Writer.WriteObjectStart();

                var marshaller = EmptyStructMarshaller.Instance;
                marshaller.Marshall(requestObject.EmptyStruct, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFloat())
            {
                context.Writer.WritePropertyName("Float");
                if(StringUtils.IsSpecialFloatValue(requestObject.Float))
                {
                    context.Writer.Write(StringUtils.FromSpecialFloatValue(requestObject.Float));
                }
                else
                {
                    context.Writer.Write(requestObject.Float);
                }
            }

            if(requestObject.IsSetHttpdateTimestamp())
            {
                context.Writer.WritePropertyName("HttpdateTimestamp");
                context.Writer.Write(StringUtils.FromDateTimeToRFC822(requestObject.HttpdateTimestamp));
            }

            if(requestObject.IsSetInteger())
            {
                context.Writer.WritePropertyName("Integer");
                context.Writer.Write(requestObject.Integer);
            }

            if(requestObject.IsSetIso8601Timestamp())
            {
                context.Writer.WritePropertyName("Iso8601Timestamp");
                context.Writer.Write(StringUtils.FromDateTimeToISO8601WithOptionalMs(requestObject.Iso8601Timestamp));
            }

            if(requestObject.IsSetJsonValue())
            {
                context.Writer.WritePropertyName("JsonValue");
                context.Writer.Write(requestObject.JsonValue);
            }

            if(requestObject.IsSetListOfLists())
            {
                context.Writer.WritePropertyName("ListOfLists");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectListOfListsListValue in requestObject.ListOfLists)
                {
                    context.Writer.WriteArrayStart();
                    foreach(var requestObjectListOfListsListValueListValue in requestObjectListOfListsListValue)
                    {
                            context.Writer.Write(requestObjectListOfListsListValueListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetListOfMapsOfStrings())
            {
                context.Writer.WritePropertyName("ListOfMapsOfStrings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectListOfMapsOfStringsListValue in requestObject.ListOfMapsOfStrings)
                {
                    context.Writer.WriteObjectStart();
                    foreach (var requestObjectListOfMapsOfStringsListValueKvp in requestObjectListOfMapsOfStringsListValue)
                    {
                        context.Writer.WritePropertyName(requestObjectListOfMapsOfStringsListValueKvp.Key);
                        var requestObjectListOfMapsOfStringsListValueValue = requestObjectListOfMapsOfStringsListValueKvp.Value;

                            context.Writer.Write(requestObjectListOfMapsOfStringsListValueValue);
                    }
                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetListOfStrings())
            {
                context.Writer.WritePropertyName("ListOfStrings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectListOfStringsListValue in requestObject.ListOfStrings)
                {
                        context.Writer.Write(requestObjectListOfStringsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetListOfStructs())
            {
                context.Writer.WritePropertyName("ListOfStructs");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectListOfStructsListValue in requestObject.ListOfStructs)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = SimpleStructMarshaller.Instance;
                    marshaller.Marshall(requestObjectListOfStructsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLong())
            {
                context.Writer.WritePropertyName("Long");
                context.Writer.Write(requestObject.Long);
            }

            if(requestObject.IsSetMapOfListsOfStrings())
            {
                context.Writer.WritePropertyName("MapOfListsOfStrings");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectMapOfListsOfStringsKvp in requestObject.MapOfListsOfStrings)
                {
                    context.Writer.WritePropertyName(requestObjectMapOfListsOfStringsKvp.Key);
                    var requestObjectMapOfListsOfStringsValue = requestObjectMapOfListsOfStringsKvp.Value;

                    context.Writer.WriteArrayStart();
                    foreach(var requestObjectMapOfListsOfStringsValueListValue in requestObjectMapOfListsOfStringsValue)
                    {
                            context.Writer.Write(requestObjectMapOfListsOfStringsValueListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMapOfMaps())
            {
                context.Writer.WritePropertyName("MapOfMaps");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectMapOfMapsKvp in requestObject.MapOfMaps)
                {
                    context.Writer.WritePropertyName(requestObjectMapOfMapsKvp.Key);
                    var requestObjectMapOfMapsValue = requestObjectMapOfMapsKvp.Value;

                    context.Writer.WriteObjectStart();
                    foreach (var requestObjectMapOfMapsValueKvp in requestObjectMapOfMapsValue)
                    {
                        context.Writer.WritePropertyName(requestObjectMapOfMapsValueKvp.Key);
                        var requestObjectMapOfMapsValueValue = requestObjectMapOfMapsValueKvp.Value;

                            context.Writer.Write(requestObjectMapOfMapsValueValue);
                    }
                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMapOfStrings())
            {
                context.Writer.WritePropertyName("MapOfStrings");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectMapOfStringsKvp in requestObject.MapOfStrings)
                {
                    context.Writer.WritePropertyName(requestObjectMapOfStringsKvp.Key);
                    var requestObjectMapOfStringsValue = requestObjectMapOfStringsKvp.Value;

                        context.Writer.Write(requestObjectMapOfStringsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMapOfStructs())
            {
                context.Writer.WritePropertyName("MapOfStructs");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectMapOfStructsKvp in requestObject.MapOfStructs)
                {
                    context.Writer.WritePropertyName(requestObjectMapOfStructsKvp.Key);
                    var requestObjectMapOfStructsValue = requestObjectMapOfStructsKvp.Value;

                    context.Writer.WriteObjectStart();

                    var marshaller = SimpleStructMarshaller.Instance;
                    marshaller.Marshall(requestObjectMapOfStructsValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRecursiveList())
            {
                context.Writer.WritePropertyName("RecursiveList");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRecursiveListListValue in requestObject.RecursiveList)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = KitchenSinkMarshaller.Instance;
                    marshaller.Marshall(requestObjectRecursiveListListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRecursiveMap())
            {
                context.Writer.WritePropertyName("RecursiveMap");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectRecursiveMapKvp in requestObject.RecursiveMap)
                {
                    context.Writer.WritePropertyName(requestObjectRecursiveMapKvp.Key);
                    var requestObjectRecursiveMapValue = requestObjectRecursiveMapKvp.Value;

                    context.Writer.WriteObjectStart();

                    var marshaller = KitchenSinkMarshaller.Instance;
                    marshaller.Marshall(requestObjectRecursiveMapValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRecursiveStruct())
            {
                context.Writer.WritePropertyName("RecursiveStruct");
                context.Writer.WriteObjectStart();

                var marshaller = KitchenSinkMarshaller.Instance;
                marshaller.Marshall(requestObject.RecursiveStruct, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSimpleStruct())
            {
                context.Writer.WritePropertyName("SimpleStruct");
                context.Writer.WriteObjectStart();

                var marshaller = SimpleStructMarshaller.Instance;
                marshaller.Marshall(requestObject.SimpleStruct, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetString())
            {
                context.Writer.WritePropertyName("String");
                context.Writer.Write(requestObject.String);
            }

            if(requestObject.IsSetStructWithJsonName())
            {
                context.Writer.WritePropertyName("StructWithJsonName");
                context.Writer.WriteObjectStart();

                var marshaller = StructWithJsonNameMarshaller.Instance;
                marshaller.Marshall(requestObject.StructWithJsonName, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTimestamp())
            {
                context.Writer.WritePropertyName("Timestamp");
                context.Writer.Write(requestObject.Timestamp);
            }

            if(requestObject.IsSetUnixTimestamp())
            {
                context.Writer.WritePropertyName("UnixTimestamp");
                context.Writer.Write(requestObject.UnixTimestamp);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static KitchenSinkMarshaller Instance = new KitchenSinkMarshaller();

    }
}