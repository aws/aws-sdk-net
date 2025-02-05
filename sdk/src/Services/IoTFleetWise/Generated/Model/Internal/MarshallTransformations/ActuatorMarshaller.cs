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
    /// Actuator Marshaller
    /// </summary>
    public class ActuatorMarshaller : IRequestMarshaller<Actuator, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Actuator requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAllowedValues())
            {
                context.Writer.WritePropertyName("allowedValues");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAllowedValuesListValue in requestObject.AllowedValues)
                {
                        context.Writer.WriteStringValue(requestObjectAllowedValuesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetAssignedValue())
            {
                context.Writer.WritePropertyName("assignedValue");
                context.Writer.WriteStringValue(requestObject.AssignedValue);
            }

            if(requestObject.IsSetComment())
            {
                context.Writer.WritePropertyName("comment");
                context.Writer.WriteStringValue(requestObject.Comment);
            }

            if(requestObject.IsSetDataType())
            {
                context.Writer.WritePropertyName("dataType");
                context.Writer.WriteStringValue(requestObject.DataType);
            }

            if(requestObject.IsSetDeprecationMessage())
            {
                context.Writer.WritePropertyName("deprecationMessage");
                context.Writer.WriteStringValue(requestObject.DeprecationMessage);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetFullyQualifiedName())
            {
                context.Writer.WritePropertyName("fullyQualifiedName");
                context.Writer.WriteStringValue(requestObject.FullyQualifiedName);
            }

            if(requestObject.IsSetMax())
            {
                context.Writer.WritePropertyName("max");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Max.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Max.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Max.Value);
                }
            }

            if(requestObject.IsSetMin())
            {
                context.Writer.WritePropertyName("min");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Min.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Min.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Min.Value);
                }
            }

            if(requestObject.IsSetStructFullyQualifiedName())
            {
                context.Writer.WritePropertyName("structFullyQualifiedName");
                context.Writer.WriteStringValue(requestObject.StructFullyQualifiedName);
            }

            if(requestObject.IsSetUnit())
            {
                context.Writer.WritePropertyName("unit");
                context.Writer.WriteStringValue(requestObject.Unit);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ActuatorMarshaller Instance = new ActuatorMarshaller();

    }
}