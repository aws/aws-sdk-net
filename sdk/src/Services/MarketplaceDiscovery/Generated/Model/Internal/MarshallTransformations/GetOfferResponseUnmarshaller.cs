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
 * Do not modify this file. This file is generated from the marketplace-discovery-2026-02-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MarketplaceDiscovery.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MarketplaceDiscovery.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetOffer operation
    /// </summary>  
    public class GetOfferResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetOfferResponse response = new GetOfferResponse();
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("agreementProposalId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AgreementProposalId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("associatedEntities", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<OfferAssociatedEntity, OfferAssociatedEntityUnmarshaller>(OfferAssociatedEntityUnmarshaller.Instance);
                    response.AssociatedEntities = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("availableFromTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.AvailableFromTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("badges", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<PurchaseOptionBadge, PurchaseOptionBadgeUnmarshaller>(PurchaseOptionBadgeUnmarshaller.Instance);
                    response.Badges = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("catalog", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Catalog = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("expirationTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.ExpirationTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("offerId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.OfferId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("offerName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.OfferName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("pricingModel", targetDepth))
                {
                    var unmarshaller = PricingModelUnmarshaller.Instance;
                    response.PricingModel = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("replacementAgreementId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ReplacementAgreementId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("sellerOfRecord", targetDepth))
                {
                    var unmarshaller = SellerInformationUnmarshaller.Instance;
                    response.SellerOfRecord = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))
            {
                StreamingUtf8JsonReader readerCopy = new StreamingUtf8JsonReader(streamCopy);
                if (errorResponse.Code != null && errorResponse.Code.Equals("AccessDeniedException"))
                {
                    return AccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                {
                    return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                {
                    return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
            }
            return new AmazonMarketplaceDiscoveryException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetOfferResponseUnmarshaller _instance = new GetOfferResponseUnmarshaller();        

        internal static GetOfferResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetOfferResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}