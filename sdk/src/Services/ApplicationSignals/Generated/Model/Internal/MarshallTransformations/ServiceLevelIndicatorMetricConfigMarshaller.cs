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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApplicationSignals.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ApplicationSignals.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ServiceLevelIndicatorMetricConfig Marshaller
    /// </summary>
    public class ServiceLevelIndicatorMetricConfigMarshaller : IRequestMarshaller<ServiceLevelIndicatorMetricConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ServiceLevelIndicatorMetricConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDependencyConfig())
            {
                context.Writer.WritePropertyName("DependencyConfig");
                context.Writer.WriteStartObject();

                var marshaller = DependencyConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.DependencyConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetKeyAttributes())
            {
                context.Writer.WritePropertyName("KeyAttributes");
                context.Writer.WriteStartObject();
                foreach (var requestObjectKeyAttributesKvp in requestObject.KeyAttributes)
                {
                    context.Writer.WritePropertyName(requestObjectKeyAttributesKvp.Key);
                    var requestObjectKeyAttributesValue = requestObjectKeyAttributesKvp.Value;

                        context.Writer.WriteStringValue(requestObjectKeyAttributesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMetricDataQueries())
            {
                context.Writer.WritePropertyName("MetricDataQueries");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMetricDataQueriesListValue in requestObject.MetricDataQueries)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MetricDataQueryMarshaller.Instance;
                    marshaller.Marshall(requestObjectMetricDataQueriesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMetricName())
            {
                context.Writer.WritePropertyName("MetricName");
                context.Writer.WriteStringValue(requestObject.MetricName);
            }

            if(requestObject.IsSetMetricType())
            {
                context.Writer.WritePropertyName("MetricType");
                context.Writer.WriteStringValue(requestObject.MetricType);
            }

            if(requestObject.IsSetOperationName())
            {
                context.Writer.WritePropertyName("OperationName");
                context.Writer.WriteStringValue(requestObject.OperationName);
            }

            if(requestObject.IsSetPeriodSeconds())
            {
                context.Writer.WritePropertyName("PeriodSeconds");
                context.Writer.WriteNumberValue(requestObject.PeriodSeconds.Value);
            }

            if(requestObject.IsSetStatistic())
            {
                context.Writer.WritePropertyName("Statistic");
                context.Writer.WriteStringValue(requestObject.Statistic);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ServiceLevelIndicatorMetricConfigMarshaller Instance = new ServiceLevelIndicatorMetricConfigMarshaller();

    }
}