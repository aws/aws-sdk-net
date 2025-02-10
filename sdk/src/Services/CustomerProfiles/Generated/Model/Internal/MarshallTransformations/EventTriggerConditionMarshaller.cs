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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CustomerProfiles.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CustomerProfiles.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EventTriggerCondition Marshaller
    /// </summary>
    public class EventTriggerConditionMarshaller : IRequestMarshaller<EventTriggerCondition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EventTriggerCondition requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEventTriggerDimensions())
            {
                context.Writer.WritePropertyName("EventTriggerDimensions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEventTriggerDimensionsListValue in requestObject.EventTriggerDimensions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EventTriggerDimensionMarshaller.Instance;
                    marshaller.Marshall(requestObjectEventTriggerDimensionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLogicalOperator())
            {
                context.Writer.WritePropertyName("LogicalOperator");
                context.Writer.WriteStringValue(requestObject.LogicalOperator);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EventTriggerConditionMarshaller Instance = new EventTriggerConditionMarshaller();

    }
}