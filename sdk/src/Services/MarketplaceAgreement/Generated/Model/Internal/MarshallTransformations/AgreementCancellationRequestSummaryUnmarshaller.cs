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
    /// Response Unmarshaller for AgreementCancellationRequestSummary Object
    /// </summary>  
    public class AgreementCancellationRequestSummaryUnmarshaller : ICborUnmarshaller<AgreementCancellationRequestSummary, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AgreementCancellationRequestSummary Unmarshall(CborUnmarshallerContext context)
        {
            AgreementCancellationRequestSummary unmarshalledObject = new AgreementCancellationRequestSummary();
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
                    case "agreementCancellationRequestId":
                        {
                            context.AddPathSegment("AgreementCancellationRequestId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AgreementCancellationRequestId = unmarshaller.Unmarshall(context);
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
                    case "catalog":
                        {
                            context.AddPathSegment("Catalog");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Catalog = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "createdAt":
                        {
                            context.AddPathSegment("CreatedAt");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "reasonCode":
                        {
                            context.AddPathSegment("ReasonCode");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ReasonCode = unmarshaller.Unmarshall(context);
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
                    case "updatedAt":
                        {
                            context.AddPathSegment("UpdatedAt");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.UpdatedAt = unmarshaller.Unmarshall(context);
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


        private static AgreementCancellationRequestSummaryUnmarshaller _instance = new AgreementCancellationRequestSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AgreementCancellationRequestSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}