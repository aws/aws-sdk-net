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
 * Do not modify this file. This file is generated from the json-rpc-10-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.JSONRPC10.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.JSONRPC10.Model.Internal.MarshallTransformations
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
                context.Writer.Write(StringUtils.FromMemoryStream(requestObject.BlobValue));
            }

            if(requestObject.IsSetBooleanValue())
            {
                context.Writer.WritePropertyName("booleanValue");
                context.Writer.Write(requestObject.BooleanValue);
            }

            if(requestObject.IsSetEnumValue())
            {
                context.Writer.WritePropertyName("enumValue");
                context.Writer.Write(requestObject.EnumValue);
            }

            if(requestObject.IsSetIntEnumValue())
            {
                context.Writer.WritePropertyName("intEnumValue");
                context.Writer.Write(requestObject.IntEnumValue);
            }

            if(requestObject.IsSetListValue())
            {
                context.Writer.WritePropertyName("listValue");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectListValueListValue in requestObject.ListValue)
                {
                        context.Writer.Write(requestObjectListValueListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetMapValue())
            {
                context.Writer.WritePropertyName("mapValue");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectMapValueKvp in requestObject.MapValue)
                {
                    context.Writer.WritePropertyName(requestObjectMapValueKvp.Key);
                    var requestObjectMapValueValue = requestObjectMapValueKvp.Value;

                        context.Writer.Write(requestObjectMapValueValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetNumberValue())
            {
                context.Writer.WritePropertyName("numberValue");
                context.Writer.Write(requestObject.NumberValue);
            }

            if(requestObject.IsSetStringValue())
            {
                context.Writer.WritePropertyName("stringValue");
                context.Writer.Write(requestObject.StringValue);
            }

            if(requestObject.IsSetStructureValue())
            {
                context.Writer.WritePropertyName("structureValue");
                context.Writer.WriteObjectStart();

                var marshaller = GreetingStructMarshaller.Instance;
                marshaller.Marshall(requestObject.StructureValue, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTimestampValue())
            {
                context.Writer.WritePropertyName("timestampValue");
                context.Writer.Write(requestObject.TimestampValue);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MyUnionMarshaller Instance = new MyUnionMarshaller();

    }
}