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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Personalize.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Personalize.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EventParameters Marshaller
    /// </summary>
    public class EventParametersMarshaller : IRequestMarshaller<EventParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EventParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEventType())
            {
                context.Writer.WritePropertyName("eventType");
                context.Writer.WriteStringValue(requestObject.EventType);
            }

            if(requestObject.IsSetEventValueThreshold())
            {
                context.Writer.WritePropertyName("eventValueThreshold");
                if(StringUtils.IsSpecialDoubleValue(requestObject.EventValueThreshold.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.EventValueThreshold.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.EventValueThreshold.Value);
                }
            }

            if(requestObject.IsSetWeight())
            {
                context.Writer.WritePropertyName("weight");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Weight.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Weight.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Weight.Value);
                }
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EventParametersMarshaller Instance = new EventParametersMarshaller();

    }
}