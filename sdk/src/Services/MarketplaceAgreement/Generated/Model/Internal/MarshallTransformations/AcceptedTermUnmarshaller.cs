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
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.MarketplaceAgreement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AcceptedTerm Object
    /// </summary>  
    public class AcceptedTermUnmarshaller : ICborUnmarshaller<AcceptedTerm, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AcceptedTerm Unmarshall(CborUnmarshallerContext context)
        {
            AcceptedTerm unmarshalledObject = new AcceptedTerm();
            if (context.IsEmptyResponse)
                return null;
            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "byolPricingTerm":
                        {
                            context.AddPathSegment("ByolPricingTerm");
                            var unmarshaller = ByolPricingTermUnmarshaller.Instance;
                            unmarshalledObject.ByolPricingTerm = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "configurableUpfrontPricingTerm":
                        {
                            context.AddPathSegment("ConfigurableUpfrontPricingTerm");
                            var unmarshaller = ConfigurableUpfrontPricingTermUnmarshaller.Instance;
                            unmarshalledObject.ConfigurableUpfrontPricingTerm = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "fixedUpfrontPricingTerm":
                        {
                            context.AddPathSegment("FixedUpfrontPricingTerm");
                            var unmarshaller = FixedUpfrontPricingTermUnmarshaller.Instance;
                            unmarshalledObject.FixedUpfrontPricingTerm = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "freeTrialPricingTerm":
                        {
                            context.AddPathSegment("FreeTrialPricingTerm");
                            var unmarshaller = FreeTrialPricingTermUnmarshaller.Instance;
                            unmarshalledObject.FreeTrialPricingTerm = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "legalTerm":
                        {
                            context.AddPathSegment("LegalTerm");
                            var unmarshaller = LegalTermUnmarshaller.Instance;
                            unmarshalledObject.LegalTerm = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "netPaymentTerm":
                        {
                            context.AddPathSegment("NetPaymentTerm");
                            var unmarshaller = NetPaymentTermUnmarshaller.Instance;
                            unmarshalledObject.NetPaymentTerm = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "paymentScheduleTerm":
                        {
                            context.AddPathSegment("PaymentScheduleTerm");
                            var unmarshaller = PaymentScheduleTermUnmarshaller.Instance;
                            unmarshalledObject.PaymentScheduleTerm = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "recurringPaymentTerm":
                        {
                            context.AddPathSegment("RecurringPaymentTerm");
                            var unmarshaller = RecurringPaymentTermUnmarshaller.Instance;
                            unmarshalledObject.RecurringPaymentTerm = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "renewalTerm":
                        {
                            context.AddPathSegment("RenewalTerm");
                            var unmarshaller = RenewalTermUnmarshaller.Instance;
                            unmarshalledObject.RenewalTerm = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "supportTerm":
                        {
                            context.AddPathSegment("SupportTerm");
                            var unmarshaller = SupportTermUnmarshaller.Instance;
                            unmarshalledObject.SupportTerm = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "usageBasedPricingTerm":
                        {
                            context.AddPathSegment("UsageBasedPricingTerm");
                            var unmarshaller = UsageBasedPricingTermUnmarshaller.Instance;
                            unmarshalledObject.UsageBasedPricingTerm = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "validityTerm":
                        {
                            context.AddPathSegment("ValidityTerm");
                            var unmarshaller = ValidityTermUnmarshaller.Instance;
                            unmarshalledObject.ValidityTerm = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "variablePaymentTerm":
                        {
                            context.AddPathSegment("VariablePaymentTerm");
                            var unmarshaller = VariablePaymentTermUnmarshaller.Instance;
                            unmarshalledObject.VariablePaymentTerm = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
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