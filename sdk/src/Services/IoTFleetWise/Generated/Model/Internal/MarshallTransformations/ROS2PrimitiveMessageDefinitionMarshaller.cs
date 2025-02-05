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
    /// ROS2PrimitiveMessageDefinition Marshaller
    /// </summary>
    public class ROS2PrimitiveMessageDefinitionMarshaller : IRequestMarshaller<ROS2PrimitiveMessageDefinition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ROS2PrimitiveMessageDefinition requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetOffset())
            {
                context.Writer.WritePropertyName("offset");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Offset.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Offset.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Offset.Value);
                }
            }

            if(requestObject.IsSetPrimitiveType())
            {
                context.Writer.WritePropertyName("primitiveType");
                context.Writer.WriteStringValue(requestObject.PrimitiveType);
            }

            if(requestObject.IsSetScaling())
            {
                context.Writer.WritePropertyName("scaling");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Scaling.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Scaling.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Scaling.Value);
                }
            }

            if(requestObject.IsSetUpperBound())
            {
                context.Writer.WritePropertyName("upperBound");
                context.Writer.WriteNumberValue(requestObject.UpperBound.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ROS2PrimitiveMessageDefinitionMarshaller Instance = new ROS2PrimitiveMessageDefinitionMarshaller();

    }
}