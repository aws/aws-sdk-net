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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetBudgetLimit())
            {
                context.Writer.WritePropertyName("BudgetLimit");
                context.Writer.WriteObjectStart();

                var marshaller = SpendMarshaller.Instance;
                marshaller.Marshall(requestObject.BudgetLimit, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetBudgetName())
            {
                context.Writer.WritePropertyName("BudgetName");
                context.Writer.Write(requestObject.BudgetName);
            }

            if(requestObject.IsSetBudgetType())
            {
                context.Writer.WritePropertyName("BudgetType");
                context.Writer.Write(requestObject.BudgetType);
            }

            if(requestObject.IsSetCalculatedSpend())
            {
                context.Writer.WritePropertyName("CalculatedSpend");
                context.Writer.WriteObjectStart();

                var marshaller = CalculatedSpendMarshaller.Instance;
                marshaller.Marshall(requestObject.CalculatedSpend, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCostFilters())
            {
                context.Writer.WritePropertyName("CostFilters");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectCostFiltersKvp in requestObject.CostFilters)
                {
                    context.Writer.WritePropertyName(requestObjectCostFiltersKvp.Key);
                    var requestObjectCostFiltersValue = requestObjectCostFiltersKvp.Value;

                    context.Writer.WriteArrayStart();
                    foreach(var requestObjectCostFiltersValueListValue in requestObjectCostFiltersValue)
                    {
                            context.Writer.Write(requestObjectCostFiltersValueListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCostTypes())
            {
                context.Writer.WritePropertyName("CostTypes");
                context.Writer.WriteObjectStart();

                var marshaller = CostTypesMarshaller.Instance;
                marshaller.Marshall(requestObject.CostTypes, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLastUpdatedTime())
            {
                context.Writer.WritePropertyName("LastUpdatedTime");
                context.Writer.Write(requestObject.LastUpdatedTime);
            }

            if(requestObject.IsSetPlannedBudgetLimits())
            {
                context.Writer.WritePropertyName("PlannedBudgetLimits");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectPlannedBudgetLimitsKvp in requestObject.PlannedBudgetLimits)
                {
                    context.Writer.WritePropertyName(requestObjectPlannedBudgetLimitsKvp.Key);
                    var requestObjectPlannedBudgetLimitsValue = requestObjectPlannedBudgetLimitsKvp.Value;

                    context.Writer.WriteObjectStart();

                    var marshaller = SpendMarshaller.Instance;
                    marshaller.Marshall(requestObjectPlannedBudgetLimitsValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTimePeriod())
            {
                context.Writer.WritePropertyName("TimePeriod");
                context.Writer.WriteObjectStart();

                var marshaller = TimePeriodMarshaller.Instance;
                marshaller.Marshall(requestObject.TimePeriod, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTimeUnit())
            {
                context.Writer.WritePropertyName("TimeUnit");
                context.Writer.Write(requestObject.TimeUnit);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static BudgetMarshaller Instance = new BudgetMarshaller();

    }
}