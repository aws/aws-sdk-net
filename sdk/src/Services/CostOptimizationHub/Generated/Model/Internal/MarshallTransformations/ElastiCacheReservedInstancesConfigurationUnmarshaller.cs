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
 * Do not modify this file. This file is generated from the cost-optimization-hub-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CostOptimizationHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.CostOptimizationHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ElastiCacheReservedInstancesConfiguration Object
    /// </summary>  
    public class ElastiCacheReservedInstancesConfigurationUnmarshaller : IJsonUnmarshaller<ElastiCacheReservedInstancesConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ElastiCacheReservedInstancesConfiguration Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ElastiCacheReservedInstancesConfiguration unmarshalledObject = new ElastiCacheReservedInstancesConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("accountScope", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccountScope = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("currentGeneration", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrentGeneration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("instanceFamily", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceFamily = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("instanceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("monthlyRecurringCost", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MonthlyRecurringCost = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("normalizedUnitsToPurchase", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NormalizedUnitsToPurchase = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("numberOfInstancesToPurchase", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NumberOfInstancesToPurchase = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("paymentOption", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PaymentOption = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("reservedInstancesRegion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReservedInstancesRegion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("service", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Service = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("sizeFlexEligible", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.SizeFlexEligible = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("term", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Term = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("upfrontCost", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UpfrontCost = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ElastiCacheReservedInstancesConfigurationUnmarshaller _instance = new ElastiCacheReservedInstancesConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ElastiCacheReservedInstancesConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}