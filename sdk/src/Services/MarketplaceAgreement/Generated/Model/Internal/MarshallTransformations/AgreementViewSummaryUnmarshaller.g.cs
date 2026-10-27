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
    /// Response Unmarshaller for AgreementViewSummary Object
    /// </summary>
    public partial class AgreementViewSummaryUnmarshaller : ICborUnmarshaller<AgreementViewSummary, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public AgreementViewSummary Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new AgreementViewSummary();
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
                    case "acceptanceTime":
                        context.AddPathSegment("AcceptanceTime");
                        unmarshalledObject.AcceptanceTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "acceptor":
                        context.AddPathSegment("Acceptor");
                        unmarshalledObject.Acceptor = AcceptorUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "agreementId":
                        context.AddPathSegment("AgreementId");
                        unmarshalledObject.AgreementId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "agreementType":
                        context.AddPathSegment("AgreementType");
                        unmarshalledObject.AgreementType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "endTime":
                        context.AddPathSegment("EndTime");
                        unmarshalledObject.EndTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "endTimeBehaviorReasonCode":
                        context.AddPathSegment("EndTimeBehaviorReasonCode");
                        unmarshalledObject.EndTimeBehaviorReasonCode = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "endTimeBehaviorType":
                        context.AddPathSegment("EndTimeBehaviorType");
                        unmarshalledObject.EndTimeBehaviorType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "entitlements":
                        context.AddPathSegment("Entitlements");
                        unmarshalledObject.Entitlements = new CborListUnmarshaller<Entitlement, EntitlementUnmarshaller>(EntitlementUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "initialAgreementId":
                        context.AddPathSegment("InitialAgreementId");
                        unmarshalledObject.InitialAgreementId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "lastUpdateTime":
                        context.AddPathSegment("LastUpdateTime");
                        unmarshalledObject.LastUpdateTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "proposalSummary":
                        context.AddPathSegment("ProposalSummary");
                        unmarshalledObject.ProposalSummary = ProposalSummaryUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "proposer":
                        context.AddPathSegment("Proposer");
                        unmarshalledObject.Proposer = ProposerUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "startTime":
                        context.AddPathSegment("StartTime");
                        unmarshalledObject.StartTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "status":
                        context.AddPathSegment("Status");
                        unmarshalledObject.Status = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static AgreementViewSummaryUnmarshaller _instance = new AgreementViewSummaryUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AgreementViewSummaryUnmarshaller Instance => _instance;
    }
}
