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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchLogs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MetricTransformation Marshaller
    /// </summary>
    public class MetricTransformationMarshaller : IRequestMarshaller<MetricTransformation, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MetricTransformation requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDefaultValue())
            {
                context.Writer.WritePropertyName("defaultValue");
                if(StringUtils.IsSpecialDoubleValue(requestObject.DefaultValue.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.DefaultValue.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.DefaultValue.Value);
                }
            }

            if(requestObject.IsSetDimensions())
            {
                context.Writer.WritePropertyName("dimensions");
                context.Writer.WriteStartObject();
                foreach (var requestObjectDimensionsKvp in requestObject.Dimensions)
                {
                    context.Writer.WritePropertyName(requestObjectDimensionsKvp.Key);
                    var requestObjectDimensionsValue = requestObjectDimensionsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectDimensionsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMetricName())
            {
                context.Writer.WritePropertyName("metricName");
                context.Writer.WriteStringValue(requestObject.MetricName);
            }

            if(requestObject.IsSetMetricNamespace())
            {
                context.Writer.WritePropertyName("metricNamespace");
                context.Writer.WriteStringValue(requestObject.MetricNamespace);
            }

            if(requestObject.IsSetMetricValue())
            {
                context.Writer.WritePropertyName("metricValue");
                context.Writer.WriteStringValue(requestObject.MetricValue);
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
        public readonly static MetricTransformationMarshaller Instance = new MetricTransformationMarshaller();

    }
}