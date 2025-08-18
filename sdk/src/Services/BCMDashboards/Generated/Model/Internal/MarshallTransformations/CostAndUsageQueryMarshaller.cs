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
 * Do not modify this file. This file is generated from the bcm-dashboards-2025-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BCMDashboards.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BCMDashboards.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CostAndUsageQuery Marshaller
    /// </summary>
    public class CostAndUsageQueryMarshaller : IRequestMarshaller<CostAndUsageQuery, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CostAndUsageQuery requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFilter())
            {
                context.Writer.WritePropertyName("filter");
                context.Writer.WriteObjectStart();

                var marshaller = ExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.Filter, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetGranularity())
            {
                context.Writer.WritePropertyName("granularity");
                context.Writer.Write(requestObject.Granularity);
            }

            if(requestObject.IsSetGroupBy())
            {
                context.Writer.WritePropertyName("groupBy");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectGroupByListValue in requestObject.GroupBy)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = GroupDefinitionMarshaller.Instance;
                    marshaller.Marshall(requestObjectGroupByListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetMetrics())
            {
                context.Writer.WritePropertyName("metrics");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectMetricsListValue in requestObject.Metrics)
                {
                        context.Writer.Write(requestObjectMetricsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTimeRange())
            {
                context.Writer.WritePropertyName("timeRange");
                context.Writer.WriteObjectStart();

                var marshaller = DateTimeRangeMarshaller.Instance;
                marshaller.Marshall(requestObject.TimeRange, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CostAndUsageQueryMarshaller Instance = new CostAndUsageQueryMarshaller();

    }
}