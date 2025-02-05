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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Deadline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Deadline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FleetAmountCapability Marshaller
    /// </summary>
    public class FleetAmountCapabilityMarshaller : IRequestMarshaller<FleetAmountCapability, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FleetAmountCapability requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetMax())
            {
                context.Writer.WritePropertyName("max");
                if(StringUtils.IsSpecialFloatValue(requestObject.Max.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialFloatValue(requestObject.Max.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Max.Value);
                }
            }

            if(requestObject.IsSetMin())
            {
                context.Writer.WritePropertyName("min");
                if(StringUtils.IsSpecialFloatValue(requestObject.Min.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialFloatValue(requestObject.Min.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Min.Value);
                }
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FleetAmountCapabilityMarshaller Instance = new FleetAmountCapabilityMarshaller();

    }
}