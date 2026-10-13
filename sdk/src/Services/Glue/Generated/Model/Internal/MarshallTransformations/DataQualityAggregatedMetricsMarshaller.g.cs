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
    /// DataQualityAggregatedMetrics Marshaller
    /// </summary>
    public partial class DataQualityAggregatedMetricsMarshaller : IRequestMarshaller<DataQualityAggregatedMetrics, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(DataQualityAggregatedMetrics requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetTotalRowsFailed())
            {
                context.Writer.WritePropertyName("TotalRowsFailed");
                if (StringUtils.IsSpecialDoubleValue(requestObject.TotalRowsFailed.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.TotalRowsFailed.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.TotalRowsFailed.Value);
                }
            }

            if (requestObject.IsSetTotalRowsPassed())
            {
                context.Writer.WritePropertyName("TotalRowsPassed");
                if (StringUtils.IsSpecialDoubleValue(requestObject.TotalRowsPassed.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.TotalRowsPassed.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.TotalRowsPassed.Value);
                }
            }

            if (requestObject.IsSetTotalRowsProcessed())
            {
                context.Writer.WritePropertyName("TotalRowsProcessed");
                if (StringUtils.IsSpecialDoubleValue(requestObject.TotalRowsProcessed.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.TotalRowsProcessed.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.TotalRowsProcessed.Value);
                }
            }

            if (requestObject.IsSetTotalRulesFailed())
            {
                context.Writer.WritePropertyName("TotalRulesFailed");
                if (StringUtils.IsSpecialDoubleValue(requestObject.TotalRulesFailed.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.TotalRulesFailed.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.TotalRulesFailed.Value);
                }
            }

            if (requestObject.IsSetTotalRulesPassed())
            {
                context.Writer.WritePropertyName("TotalRulesPassed");
                if (StringUtils.IsSpecialDoubleValue(requestObject.TotalRulesPassed.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.TotalRulesPassed.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.TotalRulesPassed.Value);
                }
            }

            if (requestObject.IsSetTotalRulesProcessed())
            {
                context.Writer.WritePropertyName("TotalRulesProcessed");
                if (StringUtils.IsSpecialDoubleValue(requestObject.TotalRulesProcessed.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.TotalRulesProcessed.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.TotalRulesProcessed.Value);
                }
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static DataQualityAggregatedMetricsMarshaller Instance = new DataQualityAggregatedMetricsMarshaller();
    }
}
