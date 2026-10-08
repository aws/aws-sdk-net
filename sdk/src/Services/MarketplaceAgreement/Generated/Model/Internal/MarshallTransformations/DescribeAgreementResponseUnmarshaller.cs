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
using Amazon.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.MarketplaceAgreement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeAgreement operation
    /// </summary>  
    public class DescribeAgreementResponseUnmarshaller : CborResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(CborUnmarshallerContext context)
        {
            DescribeAgreementResponse response = new DescribeAgreementResponse();
            var reader = context.Reader;
            context.AddPathSegment("DescribeAgreement");
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
                            response.AcceptanceTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "acceptor":
                        {
                            context.AddPathSegment("Acceptor");
                            var unmarshaller = AcceptorUnmarshaller.Instance;
                            response.Acceptor = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "agreementId":
                        {
                            context.AddPathSegment("AgreementId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            response.AgreementId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "agreementType":
                        {
                            context.AddPathSegment("AgreementType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            response.AgreementType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "endTime":
                        {
                            context.AddPathSegment("EndTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            response.EndTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "endTimeBehavior":
                        {
                            context.AddPathSegment("EndTimeBehavior");
                            var unmarshaller = EndTimeBehaviorUnmarshaller.Instance;
                            response.EndTimeBehavior = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "estimatedCharges":
                        {
                            context.AddPathSegment("EstimatedCharges");
                            var unmarshaller = EstimatedChargesUnmarshaller.Instance;
                            response.EstimatedCharges = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "initialAgreementId":
                        {
                            context.AddPathSegment("InitialAgreementId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            response.InitialAgreementId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "proposalSummary":
                        {
                            context.AddPathSegment("ProposalSummary");
                            var unmarshaller = ProposalSummaryUnmarshaller.Instance;
                            response.ProposalSummary = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "proposer":
                        {
                            context.AddPathSegment("Proposer");
                            var unmarshaller = ProposerUnmarshaller.Instance;
                            response.Proposer = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "startTime":
                        {
                            context.AddPathSegment("StartTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            response.StartTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "status":
                        {
                            context.AddPathSegment("Status");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            response.Status = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            context.PopPathSegment();

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(CborUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var errorResponse = CborErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new CborUnmarshallerContext(streamCopy, false, context.ResponseData))
            {
                if (errorResponse.Code != null && errorResponse.Code.Equals("AccessDeniedException"))
                {
                    return AccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                {
                    return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                {
                    return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonMarketplaceAgreementException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeAgreementResponseUnmarshaller _instance = new DescribeAgreementResponseUnmarshaller();        

        internal static DescribeAgreementResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeAgreementResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}