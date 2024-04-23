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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTFleetWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Attribute Marshaller
    /// </summary>
    public class AttributeMarshaller : IRequestMarshaller<Attribute, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Attribute requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAllowedValues())
            {
                context.Writer.WritePropertyName("allowedValues");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAllowedValuesListValue in requestObject.AllowedValues)
                {
                        context.Writer.Write(requestObjectAllowedValuesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetAssignedValue())
            {
                context.Writer.WritePropertyName("assignedValue");
                context.Writer.Write(requestObject.AssignedValue);
            }

            if(requestObject.IsSetComment())
            {
                context.Writer.WritePropertyName("comment");
                context.Writer.Write(requestObject.Comment);
            }

            if(requestObject.IsSetDataType())
            {
                context.Writer.WritePropertyName("dataType");
                context.Writer.Write(requestObject.DataType);
            }

            if(requestObject.IsSetDefaultValue())
            {
                context.Writer.WritePropertyName("defaultValue");
                context.Writer.Write(requestObject.DefaultValue);
            }

            if(requestObject.IsSetDeprecationMessage())
            {
                context.Writer.WritePropertyName("deprecationMessage");
                context.Writer.Write(requestObject.DeprecationMessage);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetFullyQualifiedName())
            {
                context.Writer.WritePropertyName("fullyQualifiedName");
                context.Writer.Write(requestObject.FullyQualifiedName);
            }

            if(requestObject.IsSetMax())
            {
                context.Writer.WritePropertyName("max");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Max))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.Max));
                }
                else
                {
                    context.Writer.Write(requestObject.Max);
                }
            }

            if(requestObject.IsSetMin())
            {
                context.Writer.WritePropertyName("min");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Min))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.Min));
                }
                else
                {
                    context.Writer.Write(requestObject.Min);
                }
            }

            if(requestObject.IsSetUnit())
            {
                context.Writer.WritePropertyName("unit");
                context.Writer.Write(requestObject.Unit);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AttributeMarshaller Instance = new AttributeMarshaller();

    }
}
#pragma warning restore CS0612,CS0618