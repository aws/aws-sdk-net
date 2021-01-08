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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Behavior Marshaller
    /// </summary>       
    public class BehaviorMarshaller : IRequestMarshaller<Behavior, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Behavior requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCriteria())
            {
                context.Writer.WritePropertyName("criteria");
                context.Writer.WriteObjectStart();

                var marshaller = BehaviorCriteriaMarshaller.Instance;
                marshaller.Marshall(requestObject.Criteria, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMetric())
            {
                context.Writer.WritePropertyName("metric");
                context.Writer.Write(requestObject.Metric);
            }

            if(requestObject.IsSetMetricDimension())
            {
                context.Writer.WritePropertyName("metricDimension");
                context.Writer.WriteObjectStart();

                var marshaller = MetricDimensionMarshaller.Instance;
                marshaller.Marshall(requestObject.MetricDimension, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetSuppressAlerts())
            {
                context.Writer.WritePropertyName("suppressAlerts");
                context.Writer.Write(requestObject.SuppressAlerts);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static BehaviorMarshaller Instance = new BehaviorMarshaller();

    }
}