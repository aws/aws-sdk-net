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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MetricDatum Marshaller
    /// </summary>
    public class MetricDatumMarshaller : IRequestMarshaller<MetricDatum, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MetricDatum requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetCounts())
            {
                context.Writer.WriteTextString("Counts");
                context.Writer.WriteStartArray(requestObject.Counts.Count);
                foreach(var requestObjectCountsListValue in requestObject.Counts)
                {
                        context.Writer.WriteOptimizedNumber(requestObjectCountsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetDimensions())
            {
                context.Writer.WriteTextString("Dimensions");
                context.Writer.WriteStartArray(requestObject.Dimensions.Count);
                foreach(var requestObjectDimensionsListValue in requestObject.Dimensions)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = DimensionMarshaller.Instance;
                    marshaller.Marshall(requestObjectDimensionsListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetMetricName())
            {
                context.Writer.WriteTextString("MetricName");
                context.Writer.WriteTextString(requestObject.MetricName);
            }
            if (requestObject.IsSetStatisticValues())
            {
                context.Writer.WriteTextString("StatisticValues");
                context.Writer.WriteStartMap(null);

                var marshaller = StatisticSetMarshaller.Instance;
                marshaller.Marshall(requestObject.StatisticValues, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetStorageResolution())
            {
                context.Writer.WriteTextString("StorageResolution");
                context.Writer.WriteInt32(requestObject.StorageResolution.Value);
            }
            if (requestObject.IsSetTimestamp())
            {
                context.Writer.WriteTextString("Timestamp");
                context.Writer.WriteDateTime(requestObject.Timestamp.Value);
            }
            if (requestObject.IsSetUnit())
            {
                context.Writer.WriteTextString("Unit");
                context.Writer.WriteTextString(requestObject.Unit);
            }
            if (requestObject.IsSetValue())
            {
                context.Writer.WriteTextString("Value");
                context.Writer.WriteOptimizedNumber(requestObject.Value.Value);
            }
            if (requestObject.IsSetValues())
            {
                context.Writer.WriteTextString("Values");
                context.Writer.WriteStartArray(requestObject.Values.Count);
                foreach(var requestObjectValuesListValue in requestObject.Values)
                {
                        context.Writer.WriteOptimizedNumber(requestObjectValuesListValue);
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MetricDatumMarshaller Instance = new MetricDatumMarshaller();

    }
}