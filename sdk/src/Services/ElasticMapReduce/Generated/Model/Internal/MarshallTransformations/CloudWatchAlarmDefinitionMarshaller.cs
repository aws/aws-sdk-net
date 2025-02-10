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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CloudWatchAlarmDefinition Marshaller
    /// </summary>
    public class CloudWatchAlarmDefinitionMarshaller : IRequestMarshaller<CloudWatchAlarmDefinition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CloudWatchAlarmDefinition requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetComparisonOperator())
            {
                context.Writer.WritePropertyName("ComparisonOperator");
                context.Writer.WriteStringValue(requestObject.ComparisonOperator);
            }

            if(requestObject.IsSetDimensions())
            {
                context.Writer.WritePropertyName("Dimensions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDimensionsListValue in requestObject.Dimensions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MetricDimensionMarshaller.Instance;
                    marshaller.Marshall(requestObjectDimensionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEvaluationPeriods())
            {
                context.Writer.WritePropertyName("EvaluationPeriods");
                context.Writer.WriteNumberValue(requestObject.EvaluationPeriods.Value);
            }

            if(requestObject.IsSetMetricName())
            {
                context.Writer.WritePropertyName("MetricName");
                context.Writer.WriteStringValue(requestObject.MetricName);
            }

            if(requestObject.IsSetNamespace())
            {
                context.Writer.WritePropertyName("Namespace");
                context.Writer.WriteStringValue(requestObject.Namespace);
            }

            if(requestObject.IsSetPeriod())
            {
                context.Writer.WritePropertyName("Period");
                context.Writer.WriteNumberValue(requestObject.Period.Value);
            }

            if(requestObject.IsSetStatistic())
            {
                context.Writer.WritePropertyName("Statistic");
                context.Writer.WriteStringValue(requestObject.Statistic);
            }

            if(requestObject.IsSetThreshold())
            {
                context.Writer.WritePropertyName("Threshold");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Threshold.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Threshold.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Threshold.Value);
                }
            }

            if(requestObject.IsSetUnit())
            {
                context.Writer.WritePropertyName("Unit");
                context.Writer.WriteStringValue(requestObject.Unit);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CloudWatchAlarmDefinitionMarshaller Instance = new CloudWatchAlarmDefinitionMarshaller();

    }
}