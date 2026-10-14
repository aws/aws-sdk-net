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
    /// Response Unmarshaller for AgreementViewSummary Object
    /// </summary>  
    public class AgreementViewSummaryUnmarshaller : ICborUnmarshaller<AgreementViewSummary, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AgreementViewSummary Unmarshall(CborUnmarshallerContext context)
        {
            AgreementViewSummary unmarshalledObject = new AgreementViewSummary();
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
                    case "acceptanceTime":
                        {
                            context.AddPathSegment("AcceptanceTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.AcceptanceTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "acceptor":
                        {
                            context.AddPathSegment("Acceptor");
                            var unmarshaller = AcceptorUnmarshaller.Instance;
                            unmarshalledObject.Acceptor = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "agreementId":
                        {
                            context.AddPathSegment("AgreementId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AgreementId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "agreementType":
                        {
                            context.AddPathSegment("AgreementType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AgreementType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "endTime":
                        {
                            context.AddPathSegment("EndTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.EndTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "endTimeBehaviorReasonCode":
                        {
                            context.AddPathSegment("EndTimeBehaviorReasonCode");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.EndTimeBehaviorReasonCode = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "endTimeBehaviorType":
                        {
                            context.AddPathSegment("EndTimeBehaviorType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.EndTimeBehaviorType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "entitlements":
                        {
                            context.AddPathSegment("Entitlements");
                            var unmarshaller = new CborListUnmarshaller<Entitlement, EntitlementUnmarshaller>(EntitlementUnmarshaller.Instance);
                            unmarshalledObject.Entitlements = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "initialAgreementId":
                        {
                            context.AddPathSegment("InitialAgreementId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.InitialAgreementId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "lastUpdateTime":
                        {
                            context.AddPathSegment("LastUpdateTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.LastUpdateTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "proposalSummary":
                        {
                            context.AddPathSegment("ProposalSummary");
                            var unmarshaller = ProposalSummaryUnmarshaller.Instance;
                            unmarshalledObject.ProposalSummary = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "proposer":
                        {
                            context.AddPathSegment("Proposer");
                            var unmarshaller = ProposerUnmarshaller.Instance;
                            unmarshalledObject.Proposer = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "startTime":
                        {
                            context.AddPathSegment("StartTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.StartTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "status":
                        {
                            context.AddPathSegment("Status");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Status = unmarshaller.Unmarshall(context);
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


        private static AgreementViewSummaryUnmarshaller _instance = new AgreementViewSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AgreementViewSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}