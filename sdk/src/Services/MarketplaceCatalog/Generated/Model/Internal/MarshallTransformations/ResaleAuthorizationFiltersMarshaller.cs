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
#pragma warning disable CS0612,CS0618
namespace Amazon.MarketplaceCatalog.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ResaleAuthorizationFilters Marshaller
    /// </summary>
    public class ResaleAuthorizationFiltersMarshaller : IRequestMarshaller<ResaleAuthorizationFilters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ResaleAuthorizationFilters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAvailabilityEndDate())
            {
                context.Writer.WritePropertyName("AvailabilityEndDate");
                context.Writer.WriteStartObject();

                var marshaller = ResaleAuthorizationAvailabilityEndDateFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.AvailabilityEndDate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCreatedDate())
            {
                context.Writer.WritePropertyName("CreatedDate");
                context.Writer.WriteStartObject();

                var marshaller = ResaleAuthorizationCreatedDateFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.CreatedDate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEntityId())
            {
                context.Writer.WritePropertyName("EntityId");
                context.Writer.WriteStartObject();

                var marshaller = ResaleAuthorizationEntityIdFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.EntityId, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLastModifiedDate())
            {
                context.Writer.WritePropertyName("LastModifiedDate");
                context.Writer.WriteStartObject();

                var marshaller = ResaleAuthorizationLastModifiedDateFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.LastModifiedDate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetManufacturerAccountId())
            {
                context.Writer.WritePropertyName("ManufacturerAccountId");
                context.Writer.WriteStartObject();

                var marshaller = ResaleAuthorizationManufacturerAccountIdFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.ManufacturerAccountId, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetManufacturerLegalName())
            {
                context.Writer.WritePropertyName("ManufacturerLegalName");
                context.Writer.WriteStartObject();

                var marshaller = ResaleAuthorizationManufacturerLegalNameFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.ManufacturerLegalName, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStartObject();

                var marshaller = ResaleAuthorizationNameFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.Name, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOfferExtendedStatus())
            {
                context.Writer.WritePropertyName("OfferExtendedStatus");
                context.Writer.WriteStartObject();

                var marshaller = ResaleAuthorizationOfferExtendedStatusFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.OfferExtendedStatus, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetProductId())
            {
                context.Writer.WritePropertyName("ProductId");
                context.Writer.WriteStartObject();

                var marshaller = ResaleAuthorizationProductIdFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.ProductId, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetProductName())
            {
                context.Writer.WritePropertyName("ProductName");
                context.Writer.WriteStartObject();

                var marshaller = ResaleAuthorizationProductNameFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.ProductName, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetResellerAccountID())
            {
                context.Writer.WritePropertyName("ResellerAccountID");
                context.Writer.WriteStartObject();

                var marshaller = ResaleAuthorizationResellerAccountIDFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.ResellerAccountID, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetResellerLegalName())
            {
                context.Writer.WritePropertyName("ResellerLegalName");
                context.Writer.WriteStartObject();

                var marshaller = ResaleAuthorizationResellerLegalNameFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.ResellerLegalName, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.WriteStartObject();

                var marshaller = ResaleAuthorizationStatusFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.Status, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ResaleAuthorizationFiltersMarshaller Instance = new ResaleAuthorizationFiltersMarshaller();

    }
}