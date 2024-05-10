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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MarketplaceAgreement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MarketplaceAgreement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AcceptedTerm Object
    /// </summary>  
    public class AcceptedTermUnmarshaller : IUnmarshaller<AcceptedTerm, XmlUnmarshallerContext>, IUnmarshaller<AcceptedTerm, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AcceptedTerm IUnmarshaller<AcceptedTerm, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AcceptedTerm Unmarshall(JsonUnmarshallerContext context)
        {
            AcceptedTerm unmarshalledObject = new AcceptedTerm();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("byolPricingTerm", targetDepth))
                {
                    var unmarshaller = ByolPricingTermUnmarshaller.Instance;
                    unmarshalledObject.ByolPricingTerm = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("configurableUpfrontPricingTerm", targetDepth))
                {
                    var unmarshaller = ConfigurableUpfrontPricingTermUnmarshaller.Instance;
                    unmarshalledObject.ConfigurableUpfrontPricingTerm = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fixedUpfrontPricingTerm", targetDepth))
                {
                    var unmarshaller = FixedUpfrontPricingTermUnmarshaller.Instance;
                    unmarshalledObject.FixedUpfrontPricingTerm = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("freeTrialPricingTerm", targetDepth))
                {
                    var unmarshaller = FreeTrialPricingTermUnmarshaller.Instance;
                    unmarshalledObject.FreeTrialPricingTerm = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("legalTerm", targetDepth))
                {
                    var unmarshaller = LegalTermUnmarshaller.Instance;
                    unmarshalledObject.LegalTerm = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("paymentScheduleTerm", targetDepth))
                {
                    var unmarshaller = PaymentScheduleTermUnmarshaller.Instance;
                    unmarshalledObject.PaymentScheduleTerm = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("recurringPaymentTerm", targetDepth))
                {
                    var unmarshaller = RecurringPaymentTermUnmarshaller.Instance;
                    unmarshalledObject.RecurringPaymentTerm = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("renewalTerm", targetDepth))
                {
                    var unmarshaller = RenewalTermUnmarshaller.Instance;
                    unmarshalledObject.RenewalTerm = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("supportTerm", targetDepth))
                {
                    var unmarshaller = SupportTermUnmarshaller.Instance;
                    unmarshalledObject.SupportTerm = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("usageBasedPricingTerm", targetDepth))
                {
                    var unmarshaller = UsageBasedPricingTermUnmarshaller.Instance;
                    unmarshalledObject.UsageBasedPricingTerm = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("validityTerm", targetDepth))
                {
                    var unmarshaller = ValidityTermUnmarshaller.Instance;
                    unmarshalledObject.ValidityTerm = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AcceptedTermUnmarshaller _instance = new AcceptedTermUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AcceptedTermUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}