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

using Amazon.Billing.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.Billing.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for OutcomeBasedInvestment Object
    /// </summary>
    public partial class OutcomeBasedInvestmentUnmarshaller : IJsonUnmarshaller<OutcomeBasedInvestment, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public OutcomeBasedInvestment Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new OutcomeBasedInvestment();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("attestationWindow", targetDepth, ref reader))
                {
                    var unmarshaller = IntervalUnmarshaller.Instance;
                    unmarshalledObject.AttestationWindow = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("disbursedValue", targetDepth, ref reader))
                {
                    var unmarshaller = AmountUnmarshaller.Instance;
                    unmarshalledObject.DisbursedValue = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("investmentId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InvestmentId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("investmentMultipliers", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<InvestmentMultiplier, InvestmentMultiplierUnmarshaller>(InvestmentMultiplierUnmarshaller.Instance);
                    unmarshalledObject.InvestmentMultipliers = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("investmentRestrictions", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<InvestmentRestriction, InvestmentRestrictionUnmarshaller>(InvestmentRestrictionUnmarshaller.Instance);
                    unmarshalledObject.InvestmentRestrictions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("outcomeDescription", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OutcomeDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static OutcomeBasedInvestmentUnmarshaller _instance = new OutcomeBasedInvestmentUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static OutcomeBasedInvestmentUnmarshaller Instance => _instance;
    }
}
