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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Budgets.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Budgets.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Budget Object
    /// </summary>  
    public class BudgetUnmarshaller : IUnmarshaller<Budget, XmlUnmarshallerContext>, IUnmarshaller<Budget, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Budget IUnmarshaller<Budget, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Budget Unmarshall(JsonUnmarshallerContext context)
        {
            Budget unmarshalledObject = new Budget();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AutoAdjustData", targetDepth))
                {
                    var unmarshaller = AutoAdjustDataUnmarshaller.Instance;
                    unmarshalledObject.AutoAdjustData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BillingViewArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BillingViewArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BudgetLimit", targetDepth))
                {
                    var unmarshaller = SpendUnmarshaller.Instance;
                    unmarshalledObject.BudgetLimit = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BudgetName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BudgetName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BudgetType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BudgetType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CalculatedSpend", targetDepth))
                {
                    var unmarshaller = CalculatedSpendUnmarshaller.Instance;
                    unmarshalledObject.CalculatedSpend = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CostFilters", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, List<string>, StringUnmarshaller, ListUnmarshaller<string, StringUnmarshaller>>(StringUnmarshaller.Instance, new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance));
                    unmarshalledObject.CostFilters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CostTypes", targetDepth))
                {
                    var unmarshaller = CostTypesUnmarshaller.Instance;
                    unmarshalledObject.CostTypes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FilterExpression", targetDepth))
                {
                    var unmarshaller = ExpressionUnmarshaller.Instance;
                    unmarshalledObject.FilterExpression = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HealthStatus", targetDepth))
                {
                    var unmarshaller = HealthStatusUnmarshaller.Instance;
                    unmarshalledObject.HealthStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastUpdatedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastUpdatedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Metrics", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Metrics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PlannedBudgetLimits", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, Spend, StringUnmarshaller, SpendUnmarshaller>(StringUnmarshaller.Instance, SpendUnmarshaller.Instance);
                    unmarshalledObject.PlannedBudgetLimits = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TimePeriod", targetDepth))
                {
                    var unmarshaller = TimePeriodUnmarshaller.Instance;
                    unmarshalledObject.TimePeriod = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TimeUnit", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimeUnit = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static BudgetUnmarshaller _instance = new BudgetUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BudgetUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}