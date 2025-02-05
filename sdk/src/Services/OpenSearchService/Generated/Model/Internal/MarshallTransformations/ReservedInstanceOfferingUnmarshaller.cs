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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpenSearchService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.OpenSearchService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ReservedInstanceOffering Object
    /// </summary>  
    public class ReservedInstanceOfferingUnmarshaller : IJsonUnmarshaller<ReservedInstanceOffering, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ReservedInstanceOffering Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ReservedInstanceOffering unmarshalledObject = new ReservedInstanceOffering();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("CurrencyCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrencyCode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Duration", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Duration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FixedPrice", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.FixedPrice = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InstanceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PaymentOption", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PaymentOption = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RecurringCharges", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<RecurringCharge, RecurringChargeUnmarshaller>(RecurringChargeUnmarshaller.Instance);
                    unmarshalledObject.RecurringCharges = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ReservedInstanceOfferingId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReservedInstanceOfferingId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("UsagePrice", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.UsagePrice = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ReservedInstanceOfferingUnmarshaller _instance = new ReservedInstanceOfferingUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReservedInstanceOfferingUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}