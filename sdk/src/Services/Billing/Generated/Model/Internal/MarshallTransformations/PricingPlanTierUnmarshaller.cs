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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Billing.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Billing.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PricingPlanTier Object
    /// </summary>  
    public class PricingPlanTierUnmarshaller : IJsonUnmarshaller<PricingPlanTier, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public PricingPlanTier Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            PricingPlanTier unmarshalledObject = new PricingPlanTier();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("additionalPercentageOfAggregateCharges", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AdditionalPercentageOfAggregateCharges = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("aggregateChargesAdjustment", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AggregateChargesAdjustment = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("baseCharge", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BaseCharge = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("increment", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Increment = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("incremental", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.Incremental = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("incrementCharge", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IncrementCharge = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("tierMaximum", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TierMaximum = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("tierMinimum", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TierMinimum = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static PricingPlanTierUnmarshaller _instance = new PricingPlanTierUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PricingPlanTierUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}