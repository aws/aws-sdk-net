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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CostOptimizationHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DynamoDbReservedCapacityConfiguration Object
    /// </summary>  
    public class DynamoDbReservedCapacityConfigurationUnmarshaller : IUnmarshaller<DynamoDbReservedCapacityConfiguration, XmlUnmarshallerContext>, IUnmarshaller<DynamoDbReservedCapacityConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DynamoDbReservedCapacityConfiguration IUnmarshaller<DynamoDbReservedCapacityConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public DynamoDbReservedCapacityConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            DynamoDbReservedCapacityConfiguration unmarshalledObject = new DynamoDbReservedCapacityConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("accountScope", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccountScope = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("capacityUnits", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CapacityUnits = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("monthlyRecurringCost", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MonthlyRecurringCost = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("numberOfCapacityUnitsToPurchase", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NumberOfCapacityUnitsToPurchase = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("paymentOption", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PaymentOption = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("reservedInstancesRegion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReservedInstancesRegion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("service", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Service = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("term", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Term = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("upfrontCost", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UpfrontCost = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DynamoDbReservedCapacityConfigurationUnmarshaller _instance = new DynamoDbReservedCapacityConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DynamoDbReservedCapacityConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}