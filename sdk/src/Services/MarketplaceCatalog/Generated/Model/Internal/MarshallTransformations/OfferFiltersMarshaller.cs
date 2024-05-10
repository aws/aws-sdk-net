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
 * Do not modify this file. This file is generated from the marketplace-catalog-2018-09-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MarketplaceCatalog.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MarketplaceCatalog.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OfferFilters Marshaller
    /// </summary>
    public class OfferFiltersMarshaller : IRequestMarshaller<OfferFilters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OfferFilters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAvailabilityEndDate())
            {
                context.Writer.WritePropertyName("AvailabilityEndDate");
                context.Writer.WriteObjectStart();

                var marshaller = OfferAvailabilityEndDateFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.AvailabilityEndDate, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetBuyerAccounts())
            {
                context.Writer.WritePropertyName("BuyerAccounts");
                context.Writer.WriteObjectStart();

                var marshaller = OfferBuyerAccountsFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.BuyerAccounts, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEntityId())
            {
                context.Writer.WritePropertyName("EntityId");
                context.Writer.WriteObjectStart();

                var marshaller = OfferEntityIdFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.EntityId, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLastModifiedDate())
            {
                context.Writer.WritePropertyName("LastModifiedDate");
                context.Writer.WriteObjectStart();

                var marshaller = OfferLastModifiedDateFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.LastModifiedDate, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteObjectStart();

                var marshaller = OfferNameFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.Name, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetProductId())
            {
                context.Writer.WritePropertyName("ProductId");
                context.Writer.WriteObjectStart();

                var marshaller = OfferProductIdFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.ProductId, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetReleaseDate())
            {
                context.Writer.WritePropertyName("ReleaseDate");
                context.Writer.WriteObjectStart();

                var marshaller = OfferReleaseDateFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.ReleaseDate, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetResaleAuthorizationId())
            {
                context.Writer.WritePropertyName("ResaleAuthorizationId");
                context.Writer.WriteObjectStart();

                var marshaller = OfferResaleAuthorizationIdFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.ResaleAuthorizationId, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetState())
            {
                context.Writer.WritePropertyName("State");
                context.Writer.WriteObjectStart();

                var marshaller = OfferStateFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.State, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTargeting())
            {
                context.Writer.WritePropertyName("Targeting");
                context.Writer.WriteObjectStart();

                var marshaller = OfferTargetingFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.Targeting, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OfferFiltersMarshaller Instance = new OfferFiltersMarshaller();

    }
}