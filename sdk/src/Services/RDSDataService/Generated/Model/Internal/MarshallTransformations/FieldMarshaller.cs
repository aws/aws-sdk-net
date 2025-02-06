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
 * Do not modify this file. This file is generated from the rds-data-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDSDataService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.RDSDataService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Field Marshaller
    /// </summary>
    public class FieldMarshaller : IRequestMarshaller<Field, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Field requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetArrayValue())
            {
                context.Writer.WritePropertyName("arrayValue");
                context.Writer.WriteStartObject();

                var marshaller = ArrayValueMarshaller.Instance;
                marshaller.Marshall(requestObject.ArrayValue, context);

                context.Writer.WriteEndObject();
            }

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

            if(requestObject.IsSetDoubleValue())
            {
                context.Writer.WritePropertyName("doubleValue");
                if(StringUtils.IsSpecialDoubleValue(requestObject.DoubleValue.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.DoubleValue.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.DoubleValue.Value);
                }
            }

            if(requestObject.IsSetIsNull())
            {
                context.Writer.WritePropertyName("isNull");
                context.Writer.WriteBooleanValue(requestObject.IsNull.Value);
            }

            if(requestObject.IsSetLongValue())
            {
                context.Writer.WritePropertyName("longValue");
                context.Writer.WriteNumberValue(requestObject.LongValue.Value);
            }

            if(requestObject.IsSetStringValue())
            {
                context.Writer.WritePropertyName("stringValue");
                context.Writer.WriteStringValue(requestObject.StringValue);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FieldMarshaller Instance = new FieldMarshaller();

    }
}