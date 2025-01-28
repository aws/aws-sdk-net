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
    /// MyUnion Marshaller
    /// </summary>
    public class MyUnionMarshaller : IRequestMarshaller<MyUnion, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MyUnion requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBlobValue())
            {
                context.Writer.WritePropertyName("blobValue");
                context.Writer.WriteStringValue(StringUtils.FromMemoryStream(requestObject.BlobValue));
            }

            if(requestObject.IsSetBooleanValue())
            {
                context.Writer.WritePropertyName("booleanValue");
                context.Writer.WriteBooleanValue(requestObject.BooleanValue.Value);
            }

            if(requestObject.IsSetEnumValue())
            {
                context.Writer.WritePropertyName("enumValue");
                context.Writer.WriteStringValue(requestObject.EnumValue);
            }

            if(requestObject.IsSetListValue())
            {
                context.Writer.WritePropertyName("listValue");
                context.Writer.WriteStartArray();
                foreach(var requestObjectListValueListValue in requestObject.ListValue)
                {
                        context.Writer.WriteStringValue(requestObjectListValueListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMapValue())
            {
                context.Writer.WritePropertyName("mapValue");
                context.Writer.WriteStartObject();
                foreach (var requestObjectMapValueKvp in requestObject.MapValue)
                {
                    context.Writer.WritePropertyName(requestObjectMapValueKvp.Key);
                    var requestObjectMapValueValue = requestObjectMapValueKvp.Value;

                        context.Writer.WriteStringValue(requestObjectMapValueValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNumberValue())
            {
                context.Writer.WritePropertyName("numberValue");
                context.Writer.WriteNumberValue(requestObject.NumberValue.Value);
            }

            if(requestObject.IsSetStringValue())
            {
                context.Writer.WritePropertyName("stringValue");
                context.Writer.WriteStringValue(requestObject.StringValue);
            }

            if(requestObject.IsSetStructureValue())
            {
                context.Writer.WritePropertyName("structureValue");
                context.Writer.WriteStartObject();

                var marshaller = GreetingStructMarshaller.Instance;
                marshaller.Marshall(requestObject.StructureValue, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTimestampValue())
            {
                context.Writer.WritePropertyName("timestampValue");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.TimestampValue.Value)));
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MyUnionMarshaller Instance = new MyUnionMarshaller();

    }
}