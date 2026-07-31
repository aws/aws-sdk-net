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
    /// Response Unmarshaller for LinkedAccountCharge Object
    /// </summary>  
    public class LinkedAccountChargeUnmarshaller : IJsonUnmarshaller<LinkedAccountCharge, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public LinkedAccountCharge Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            LinkedAccountCharge unmarshalledObject = new LinkedAccountCharge();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("accountId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccountId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("accountType", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccountType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("billableSeconds", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.BillableSeconds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("linkedTimePeriods", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<EnterpriseSupportTimePeriod, EnterpriseSupportTimePeriodUnmarshaller>(EnterpriseSupportTimePeriodUnmarshaller.Instance);
                    unmarshalledObject.LinkedTimePeriods = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("payerAccountId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PayerAccountId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("proratedTotalSupportEligibleSpend", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProratedTotalSupportEligibleSpend = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("subscriptionTimePeriods", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<EnterpriseSupportTimePeriod, EnterpriseSupportTimePeriodUnmarshaller>(EnterpriseSupportTimePeriodUnmarshaller.Instance);
                    unmarshalledObject.SubscriptionTimePeriods = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("supportEligibleSpendByService", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<ServiceLevelAccountUsage, ServiceLevelAccountUsageUnmarshaller>(ServiceLevelAccountUsageUnmarshaller.Instance);
                    unmarshalledObject.SupportEligibleSpendByService = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("totalSeconds", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.TotalSeconds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("totalSupportEligibleReservedInstanceSpend", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TotalSupportEligibleReservedInstanceSpend = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("totalSupportEligibleSavingsPlanSpend", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TotalSupportEligibleSavingsPlanSpend = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("totalSupportEligibleSpend", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TotalSupportEligibleSpend = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static LinkedAccountChargeUnmarshaller _instance = new LinkedAccountChargeUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LinkedAccountChargeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}