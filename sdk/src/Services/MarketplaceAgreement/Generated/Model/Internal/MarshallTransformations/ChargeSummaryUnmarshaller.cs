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
    /// Response Unmarshaller for ChargeSummary Object
    /// </summary>  
    public class ChargeSummaryUnmarshaller : ICborUnmarshaller<ChargeSummary, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ChargeSummary Unmarshall(CborUnmarshallerContext context)
        {
            ChargeSummary unmarshalledObject = new ChargeSummary();
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
                    case "currencyCode":
                        {
                            context.AddPathSegment("CurrencyCode");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.CurrencyCode = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "estimatedTaxes":
                        {
                            context.AddPathSegment("EstimatedTaxes");
                            var unmarshaller = EstimatedTaxesUnmarshaller.Instance;
                            unmarshalledObject.EstimatedTaxes = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "expectedCharges":
                        {
                            context.AddPathSegment("ExpectedCharges");
                            var unmarshaller = new CborListUnmarshaller<ExpectedCharge, ExpectedChargeUnmarshaller>(ExpectedChargeUnmarshaller.Instance);
                            unmarshalledObject.ExpectedCharges = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "invoicingEntity":
                        {
                            context.AddPathSegment("InvoicingEntity");
                            var unmarshaller = InvoicingEntityUnmarshaller.Instance;
                            unmarshalledObject.InvoicingEntity = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "itemizedCharges":
                        {
                            context.AddPathSegment("ItemizedCharges");
                            var unmarshaller = new CborListUnmarshaller<ItemizedCharge, ItemizedChargeUnmarshaller>(ItemizedChargeUnmarshaller.Instance);
                            unmarshalledObject.ItemizedCharges = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "newAgreementValue":
                        {
                            context.AddPathSegment("NewAgreementValue");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.NewAgreementValue = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "newAgreementValueAfterTax":
                        {
                            context.AddPathSegment("NewAgreementValueAfterTax");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.NewAgreementValueAfterTax = unmarshaller.Unmarshall(context);
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


        private static ChargeSummaryUnmarshaller _instance = new ChargeSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ChargeSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}