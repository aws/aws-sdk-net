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
 * Do not modify this file. This file is generated from the bcm-pricing-calculator-2024-06-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.BCMPricingCalculator.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.BCMPricingCalculator.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for WorkloadEstimateUsageItem Object
    /// </summary>  
    public class WorkloadEstimateUsageItemUnmarshaller : IJsonUnmarshaller<WorkloadEstimateUsageItem, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public WorkloadEstimateUsageItem Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            WorkloadEstimateUsageItem unmarshalledObject = new WorkloadEstimateUsageItem();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("cost", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.Cost = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("currency", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Currency = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("group", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Group = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("historicalUsage", targetDepth))
                {
                    var unmarshaller = HistoricalUsageEntityUnmarshaller.Instance;
                    unmarshalledObject.HistoricalUsage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("location", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Location = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("operation", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Operation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("quantity", targetDepth))
                {
                    var unmarshaller = WorkloadEstimateUsageQuantityUnmarshaller.Instance;
                    unmarshalledObject.Quantity = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("serviceCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceCode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("usageAccountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UsageAccountId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("usageType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UsageType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static WorkloadEstimateUsageItemUnmarshaller _instance = new WorkloadEstimateUsageItemUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static WorkloadEstimateUsageItemUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}