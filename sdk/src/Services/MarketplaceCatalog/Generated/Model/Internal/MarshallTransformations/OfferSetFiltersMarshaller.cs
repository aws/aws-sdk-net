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
    /// OfferSetFilters Marshaller
    /// </summary>
    public class OfferSetFiltersMarshaller : IRequestMarshaller<OfferSetFilters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OfferSetFilters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAssociatedOfferIds())
            {
                context.Writer.WritePropertyName("AssociatedOfferIds");
                context.Writer.WriteObjectStart();

                var marshaller = OfferSetAssociatedOfferIdsFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.AssociatedOfferIds, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEntityId())
            {
                context.Writer.WritePropertyName("EntityId");
                context.Writer.WriteObjectStart();

                var marshaller = OfferSetEntityIdFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.EntityId, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLastModifiedDate())
            {
                context.Writer.WritePropertyName("LastModifiedDate");
                context.Writer.WriteObjectStart();

                var marshaller = OfferSetLastModifiedDateFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.LastModifiedDate, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteObjectStart();

                var marshaller = OfferSetNameFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.Name, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetReleaseDate())
            {
                context.Writer.WritePropertyName("ReleaseDate");
                context.Writer.WriteObjectStart();

                var marshaller = OfferSetReleaseDateFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.ReleaseDate, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSolutionId())
            {
                context.Writer.WritePropertyName("SolutionId");
                context.Writer.WriteObjectStart();

                var marshaller = OfferSetSolutionIdFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.SolutionId, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetState())
            {
                context.Writer.WritePropertyName("State");
                context.Writer.WriteObjectStart();

                var marshaller = OfferSetStateFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.State, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OfferSetFiltersMarshaller Instance = new OfferSetFiltersMarshaller();

    }
}