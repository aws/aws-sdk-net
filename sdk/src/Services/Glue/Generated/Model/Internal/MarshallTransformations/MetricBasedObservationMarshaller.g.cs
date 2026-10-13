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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.Glue.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MetricBasedObservation Marshaller
    /// </summary>
    public partial class MetricBasedObservationMarshaller : IRequestMarshaller<MetricBasedObservation, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(MetricBasedObservation requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetMetricName())
            {
                context.Writer.WritePropertyName("MetricName");
                context.Writer.WriteStringValue(requestObject.MetricName);
            }

            if (requestObject.IsSetMetricValues())
            {
                context.Writer.WritePropertyName("MetricValues");
                context.Writer.WriteStartObject();

                var marshaller = DataQualityMetricValuesMarshaller.Instance;
                marshaller.Marshall(requestObject.MetricValues, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetNewRules())
            {
                context.Writer.WritePropertyName("NewRules");
                context.Writer.WriteStartArray();
                foreach (var requestObjectNewRulesListValue in requestObject.NewRules)
                {
                    context.Writer.WriteStringValue(requestObjectNewRulesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetStatisticId())
            {
                context.Writer.WritePropertyName("StatisticId");
                context.Writer.WriteStringValue(requestObject.StatisticId);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static MetricBasedObservationMarshaller Instance = new MetricBasedObservationMarshaller();
    }
}
