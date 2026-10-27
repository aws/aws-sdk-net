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

using Amazon.MarketplaceAgreement.Model;
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
    public partial class AcceptedTermUnmarshaller : ICborUnmarshaller<AcceptedTerm, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public AcceptedTerm Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new AcceptedTerm();
            if (context.IsEmptyResponse) return null;

            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "byolPricingTerm":
                        context.AddPathSegment("ByolPricingTerm");
                        unmarshalledObject.ByolPricingTerm = ByolPricingTermUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "configurableUpfrontPricingTerm":
                        context.AddPathSegment("ConfigurableUpfrontPricingTerm");
                        unmarshalledObject.ConfigurableUpfrontPricingTerm = ConfigurableUpfrontPricingTermUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "fixedUpfrontPricingTerm":
                        context.AddPathSegment("FixedUpfrontPricingTerm");
                        unmarshalledObject.FixedUpfrontPricingTerm = FixedUpfrontPricingTermUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "freeTrialPricingTerm":
                        context.AddPathSegment("FreeTrialPricingTerm");
                        unmarshalledObject.FreeTrialPricingTerm = FreeTrialPricingTermUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "legalTerm":
                        context.AddPathSegment("LegalTerm");
                        unmarshalledObject.LegalTerm = LegalTermUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "netPaymentTerm":
                        context.AddPathSegment("NetPaymentTerm");
                        unmarshalledObject.NetPaymentTerm = NetPaymentTermUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "paymentScheduleTerm":
                        context.AddPathSegment("PaymentScheduleTerm");
                        unmarshalledObject.PaymentScheduleTerm = PaymentScheduleTermUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "recurringPaymentTerm":
                        context.AddPathSegment("RecurringPaymentTerm");
                        unmarshalledObject.RecurringPaymentTerm = RecurringPaymentTermUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "renewalTerm":
                        context.AddPathSegment("RenewalTerm");
                        unmarshalledObject.RenewalTerm = RenewalTermUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "supportTerm":
                        context.AddPathSegment("SupportTerm");
                        unmarshalledObject.SupportTerm = SupportTermUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "usageBasedPricingTerm":
                        context.AddPathSegment("UsageBasedPricingTerm");
                        unmarshalledObject.UsageBasedPricingTerm = UsageBasedPricingTermUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "validityTerm":
                        context.AddPathSegment("ValidityTerm");
                        unmarshalledObject.ValidityTerm = ValidityTermUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "variablePaymentTerm":
                        context.AddPathSegment("VariablePaymentTerm");
                        unmarshalledObject.VariablePaymentTerm = VariablePaymentTermUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

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
        public static AcceptedTermUnmarshaller Instance => _instance;
    }
}
