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
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MetricTransformation Marshaller
    /// </summary>
    public class MetricTransformationMarshaller : IRequestMarshaller<MetricTransformation, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MetricTransformation requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetDefaultValue())
            {
                context.Writer.WriteTextString("defaultValue");
                context.Writer.WriteOptimizedNumber(requestObject.DefaultValue.Value);
            }
            if (requestObject.IsSetDimensions())
            {
                context.Writer.WriteTextString("dimensions");
                context.Writer.WriteStartMap(null);
                foreach (var requestObjectDimensionsKvp in requestObject.Dimensions)
                {
                    context.Writer.WriteTextString(requestObjectDimensionsKvp.Key);
                    var requestObjectDimensionsValue = requestObjectDimensionsKvp.Value;

                        context.Writer.WriteTextString(requestObjectDimensionsValue);
                }
                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetMetricName())
            {
                context.Writer.WriteTextString("metricName");
                context.Writer.WriteTextString(requestObject.MetricName);
            }
            if (requestObject.IsSetMetricNamespace())
            {
                context.Writer.WriteTextString("metricNamespace");
                context.Writer.WriteTextString(requestObject.MetricNamespace);
            }
            if (requestObject.IsSetMetricValue())
            {
                context.Writer.WriteTextString("metricValue");
                context.Writer.WriteTextString(requestObject.MetricValue);
            }
            if (requestObject.IsSetUnit())
            {
                context.Writer.WriteTextString("unit");
                context.Writer.WriteTextString(requestObject.Unit);
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MetricTransformationMarshaller Instance = new MetricTransformationMarshaller();

    }
}