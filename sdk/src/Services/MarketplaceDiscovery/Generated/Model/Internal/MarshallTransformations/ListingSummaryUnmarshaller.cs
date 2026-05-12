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
#pragma warning disable CS0612,CS0618
namespace Amazon.MarketplaceDiscovery.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ListingSummary Object
    /// </summary>  
    public class ListingSummaryUnmarshaller : IJsonUnmarshaller<ListingSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ListingSummary Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ListingSummary unmarshalledObject = new ListingSummary();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("associatedEntities", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ListingSummaryAssociatedEntity, ListingSummaryAssociatedEntityUnmarshaller>(ListingSummaryAssociatedEntityUnmarshaller.Instance);
                    unmarshalledObject.AssociatedEntities = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("badges", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ListingBadge, ListingBadgeUnmarshaller>(ListingBadgeUnmarshaller.Instance);
                    unmarshalledObject.Badges = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("catalog", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Catalog = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("categories", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Category, CategoryUnmarshaller>(CategoryUnmarshaller.Instance);
                    unmarshalledObject.Categories = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("fulfillmentOptionSummaries", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<FulfillmentOptionSummary, FulfillmentOptionSummaryUnmarshaller>(FulfillmentOptionSummaryUnmarshaller.Instance);
                    unmarshalledObject.FulfillmentOptionSummaries = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("listingId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ListingId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("listingName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ListingName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("logoThumbnailUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogoThumbnailUrl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("pricingModels", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<PricingModel, PricingModelUnmarshaller>(PricingModelUnmarshaller.Instance);
                    unmarshalledObject.PricingModels = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("pricingUnits", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<PricingUnit, PricingUnitUnmarshaller>(PricingUnitUnmarshaller.Instance);
                    unmarshalledObject.PricingUnits = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("publisher", targetDepth))
                {
                    var unmarshaller = SellerInformationUnmarshaller.Instance;
                    unmarshalledObject.Publisher = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("reviewSummary", targetDepth))
                {
                    var unmarshaller = ReviewSummaryUnmarshaller.Instance;
                    unmarshalledObject.ReviewSummary = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("shortDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShortDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ListingSummaryUnmarshaller _instance = new ListingSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListingSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}