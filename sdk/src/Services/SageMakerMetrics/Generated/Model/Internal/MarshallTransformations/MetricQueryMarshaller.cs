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
 * Do not modify this file. This file is generated from the sagemaker-metrics-2022-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMakerMetrics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMakerMetrics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MetricQuery Marshaller
    /// </summary>
    public class MetricQueryMarshaller : IRequestMarshaller<MetricQuery, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MetricQuery requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEnd())
            {
                context.Writer.WritePropertyName("End");
                context.Writer.WriteNumberValue(requestObject.End.Value);
            }

            if(requestObject.IsSetMetricName())
            {
                context.Writer.WritePropertyName("MetricName");
                context.Writer.WriteStringValue(requestObject.MetricName);
            }

            if(requestObject.IsSetMetricStat())
            {
                context.Writer.WritePropertyName("MetricStat");
                context.Writer.WriteStringValue(requestObject.MetricStat);
            }

            if(requestObject.IsSetPeriod())
            {
                context.Writer.WritePropertyName("Period");
                context.Writer.WriteStringValue(requestObject.Period);
            }

            if(requestObject.IsSetResourceArn())
            {
                context.Writer.WritePropertyName("ResourceArn");
                context.Writer.WriteStringValue(requestObject.ResourceArn);
            }

            if(requestObject.IsSetStart())
            {
                context.Writer.WritePropertyName("Start");
                context.Writer.WriteNumberValue(requestObject.Start.Value);
            }

            if(requestObject.IsSetXAxisType())
            {
                context.Writer.WritePropertyName("XAxisType");
                context.Writer.WriteStringValue(requestObject.XAxisType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MetricQueryMarshaller Instance = new MetricQueryMarshaller();

    }
}