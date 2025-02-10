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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudDirectory.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudDirectory.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TypedAttributeValue Marshaller
    /// </summary>
    public class TypedAttributeValueMarshaller : IRequestMarshaller<TypedAttributeValue, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TypedAttributeValue requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBinaryValue())
            {
                context.Writer.WritePropertyName("BinaryValue");
                context.Writer.WriteStringValue(StringUtils.FromMemoryStream(requestObject.BinaryValue));
            }

            if(requestObject.IsSetBooleanValue())
            {
                context.Writer.WritePropertyName("BooleanValue");
                context.Writer.WriteBooleanValue(requestObject.BooleanValue.Value);
            }

            if(requestObject.IsSetDatetimeValue())
            {
                context.Writer.WritePropertyName("DatetimeValue");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.DatetimeValue.Value)));
            }

            if(requestObject.IsSetNumberValue())
            {
                context.Writer.WritePropertyName("NumberValue");
                context.Writer.WriteStringValue(requestObject.NumberValue);
            }

            if(requestObject.IsSetStringValue())
            {
                context.Writer.WritePropertyName("StringValue");
                context.Writer.WriteStringValue(requestObject.StringValue);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TypedAttributeValueMarshaller Instance = new TypedAttributeValueMarshaller();

    }
}