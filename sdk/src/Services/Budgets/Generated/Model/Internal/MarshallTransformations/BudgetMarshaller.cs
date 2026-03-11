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
 * Do not modify this file. This file is generated from the budgets-2016-10-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Budgets.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Budgets.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Budget Marshaller
    /// </summary>
    public class BudgetMarshaller : IRequestMarshaller<Budget, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Budget requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAutoAdjustData())
            {
                context.Writer.WritePropertyName("AutoAdjustData");
                context.Writer.WriteStartObject();

                var marshaller = AutoAdjustDataMarshaller.Instance;
                marshaller.Marshall(requestObject.AutoAdjustData, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBillingViewArn())
            {
                context.Writer.WritePropertyName("BillingViewArn");
                context.Writer.WriteStringValue(requestObject.BillingViewArn);
            }

            if(requestObject.IsSetBudgetLimit())
            {
                context.Writer.WritePropertyName("BudgetLimit");
                context.Writer.WriteStartObject();

                var marshaller = SpendMarshaller.Instance;
                marshaller.Marshall(requestObject.BudgetLimit, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBudgetName())
            {
                context.Writer.WritePropertyName("BudgetName");
                context.Writer.WriteStringValue(requestObject.BudgetName);
            }

            if(requestObject.IsSetBudgetType())
            {
                context.Writer.WritePropertyName("BudgetType");
                context.Writer.WriteStringValue(requestObject.BudgetType);
            }

            if(requestObject.IsSetCalculatedSpend())
            {
                context.Writer.WritePropertyName("CalculatedSpend");
                context.Writer.WriteStartObject();

                var marshaller = CalculatedSpendMarshaller.Instance;
                marshaller.Marshall(requestObject.CalculatedSpend, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCostFilters())
            {
                context.Writer.WritePropertyName("CostFilters");
                context.Writer.WriteStartObject();
                foreach (var requestObjectCostFiltersKvp in requestObject.CostFilters)
                {
                    context.Writer.WritePropertyName(requestObjectCostFiltersKvp.Key);
                    var requestObjectCostFiltersValue = requestObjectCostFiltersKvp.Value;

                    context.Writer.WriteStartArray();
                    foreach(var requestObjectCostFiltersValueListValue in requestObjectCostFiltersValue)
                    {
                            context.Writer.WriteStringValue(requestObjectCostFiltersValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCostTypes())
            {
                context.Writer.WritePropertyName("CostTypes");
                context.Writer.WriteStartObject();

                var marshaller = CostTypesMarshaller.Instance;
                marshaller.Marshall(requestObject.CostTypes, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFilterExpression())
            {
                context.Writer.WritePropertyName("FilterExpression");
                context.Writer.WriteStartObject();

                var marshaller = ExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.FilterExpression, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetHealthStatus())
            {
                context.Writer.WritePropertyName("HealthStatus");
                context.Writer.WriteStartObject();

                var marshaller = HealthStatusMarshaller.Instance;
                marshaller.Marshall(requestObject.HealthStatus, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLastUpdatedTime())
            {
                context.Writer.WritePropertyName("LastUpdatedTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.LastUpdatedTime.Value)));
            }

            if(requestObject.IsSetMetrics())
            {
                context.Writer.WritePropertyName("Metrics");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMetricsListValue in requestObject.Metrics)
                {
                        context.Writer.WriteStringValue(requestObjectMetricsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPlannedBudgetLimits())
            {
                context.Writer.WritePropertyName("PlannedBudgetLimits");
                context.Writer.WriteStartObject();
                foreach (var requestObjectPlannedBudgetLimitsKvp in requestObject.PlannedBudgetLimits)
                {
                    context.Writer.WritePropertyName(requestObjectPlannedBudgetLimitsKvp.Key);
                    var requestObjectPlannedBudgetLimitsValue = requestObjectPlannedBudgetLimitsKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = SpendMarshaller.Instance;
                    marshaller.Marshall(requestObjectPlannedBudgetLimitsValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTimePeriod())
            {
                context.Writer.WritePropertyName("TimePeriod");
                context.Writer.WriteStartObject();

                var marshaller = TimePeriodMarshaller.Instance;
                marshaller.Marshall(requestObject.TimePeriod, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTimeUnit())
            {
                context.Writer.WritePropertyName("TimeUnit");
                context.Writer.WriteStringValue(requestObject.TimeUnit);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BudgetMarshaller Instance = new BudgetMarshaller();

    }
}