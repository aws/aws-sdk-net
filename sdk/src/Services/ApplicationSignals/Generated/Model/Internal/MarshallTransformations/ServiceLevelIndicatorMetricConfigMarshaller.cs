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
using ThirdParty.Json.LitJson;

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
                context.Writer.WriteObjectStart();

                var marshaller = DependencyConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.DependencyConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetKeyAttributes())
            {
                context.Writer.WritePropertyName("KeyAttributes");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectKeyAttributesKvp in requestObject.KeyAttributes)
                {
                    context.Writer.WritePropertyName(requestObjectKeyAttributesKvp.Key);
                    var requestObjectKeyAttributesValue = requestObjectKeyAttributesKvp.Value;

                        context.Writer.Write(requestObjectKeyAttributesValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMetricDataQueries())
            {
                context.Writer.WritePropertyName("MetricDataQueries");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectMetricDataQueriesListValue in requestObject.MetricDataQueries)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = MetricDataQueryMarshaller.Instance;
                    marshaller.Marshall(requestObjectMetricDataQueriesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetMetricName())
            {
                context.Writer.WritePropertyName("MetricName");
                context.Writer.Write(requestObject.MetricName);
            }

            if(requestObject.IsSetMetricType())
            {
                context.Writer.WritePropertyName("MetricType");
                context.Writer.Write(requestObject.MetricType);
            }

            if(requestObject.IsSetOperationName())
            {
                context.Writer.WritePropertyName("OperationName");
                context.Writer.Write(requestObject.OperationName);
            }

            if(requestObject.IsSetPeriodSeconds())
            {
                context.Writer.WritePropertyName("PeriodSeconds");
                context.Writer.Write(requestObject.PeriodSeconds);
            }

            if(requestObject.IsSetStatistic())
            {
                context.Writer.WritePropertyName("Statistic");
                context.Writer.Write(requestObject.Statistic);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ServiceLevelIndicatorMetricConfigMarshaller Instance = new ServiceLevelIndicatorMetricConfigMarshaller();

    }
}