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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTFleetWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTFleetWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StructuredMessage Marshaller
    /// </summary>
    public class StructuredMessageMarshaller : IRequestMarshaller<StructuredMessage, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(StructuredMessage requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetPrimitiveMessageDefinition())
            {
                context.Writer.WritePropertyName("primitiveMessageDefinition");
                context.Writer.WriteStartObject();

                var marshaller = PrimitiveMessageDefinitionMarshaller.Instance;
                marshaller.Marshall(requestObject.PrimitiveMessageDefinition, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStructuredMessageDefinition())
            {
                context.Writer.WritePropertyName("structuredMessageDefinition");
                context.Writer.WriteStartArray();
                foreach(var requestObjectStructuredMessageDefinitionListValue in requestObject.StructuredMessageDefinition)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StructuredMessageFieldNameAndDataTypePairMarshaller.Instance;
                    marshaller.Marshall(requestObjectStructuredMessageDefinitionListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetStructuredMessageListDefinition())
            {
                context.Writer.WritePropertyName("structuredMessageListDefinition");
                context.Writer.WriteStartObject();

                var marshaller = StructuredMessageListDefinitionMarshaller.Instance;
                marshaller.Marshall(requestObject.StructuredMessageListDefinition, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static StructuredMessageMarshaller Instance = new StructuredMessageMarshaller();

    }
}