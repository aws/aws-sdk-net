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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTSiteWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Variant Marshaller
    /// </summary>
    public class VariantMarshaller : IRequestMarshaller<Variant, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Variant requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
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

            if(requestObject.IsSetIntegerValue())
            {
                context.Writer.WritePropertyName("integerValue");
                context.Writer.WriteNumberValue(requestObject.IntegerValue.Value);
            }

            if(requestObject.IsSetNullValue())
            {
                context.Writer.WritePropertyName("nullValue");
                context.Writer.WriteStartObject();

                var marshaller = PropertyValueNullValueMarshaller.Instance;
                marshaller.Marshall(requestObject.NullValue, context);

                context.Writer.WriteEndObject();
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
        public readonly static VariantMarshaller Instance = new VariantMarshaller();

    }
}