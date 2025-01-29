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
 * Do not modify this file. This file is generated from the internetmonitor-2021-06-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.InternetMonitor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.InternetMonitor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HealthEventsConfig Marshaller
    /// </summary>
    public class HealthEventsConfigMarshaller : IRequestMarshaller<HealthEventsConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HealthEventsConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAvailabilityLocalHealthEventsConfig())
            {
                context.Writer.WritePropertyName("AvailabilityLocalHealthEventsConfig");
                context.Writer.WriteStartObject();

                var marshaller = LocalHealthEventsConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.AvailabilityLocalHealthEventsConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAvailabilityScoreThreshold())
            {
                context.Writer.WritePropertyName("AvailabilityScoreThreshold");
                if(StringUtils.IsSpecialDoubleValue(requestObject.AvailabilityScoreThreshold.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.AvailabilityScoreThreshold.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.AvailabilityScoreThreshold.Value);
                }
            }

            if(requestObject.IsSetPerformanceLocalHealthEventsConfig())
            {
                context.Writer.WritePropertyName("PerformanceLocalHealthEventsConfig");
                context.Writer.WriteStartObject();

                var marshaller = LocalHealthEventsConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.PerformanceLocalHealthEventsConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPerformanceScoreThreshold())
            {
                context.Writer.WritePropertyName("PerformanceScoreThreshold");
                if(StringUtils.IsSpecialDoubleValue(requestObject.PerformanceScoreThreshold.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.PerformanceScoreThreshold.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.PerformanceScoreThreshold.Value);
                }
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static HealthEventsConfigMarshaller Instance = new HealthEventsConfigMarshaller();

    }
}