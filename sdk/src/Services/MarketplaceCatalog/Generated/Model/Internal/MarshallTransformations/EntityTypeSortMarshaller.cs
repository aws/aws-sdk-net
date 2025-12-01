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
    /// EntityTypeSort Marshaller
    /// </summary>
    public class EntityTypeSortMarshaller : IRequestMarshaller<EntityTypeSort, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EntityTypeSort requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAmiProductSort())
            {
                context.Writer.WritePropertyName("AmiProductSort");
                context.Writer.WriteObjectStart();

                var marshaller = AmiProductSortMarshaller.Instance;
                marshaller.Marshall(requestObject.AmiProductSort, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetContainerProductSort())
            {
                context.Writer.WritePropertyName("ContainerProductSort");
                context.Writer.WriteObjectStart();

                var marshaller = ContainerProductSortMarshaller.Instance;
                marshaller.Marshall(requestObject.ContainerProductSort, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDataProductSort())
            {
                context.Writer.WritePropertyName("DataProductSort");
                context.Writer.WriteObjectStart();

                var marshaller = DataProductSortMarshaller.Instance;
                marshaller.Marshall(requestObject.DataProductSort, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMachineLearningProductSort())
            {
                context.Writer.WritePropertyName("MachineLearningProductSort");
                context.Writer.WriteObjectStart();

                var marshaller = MachineLearningProductSortMarshaller.Instance;
                marshaller.Marshall(requestObject.MachineLearningProductSort, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOfferSetSort())
            {
                context.Writer.WritePropertyName("OfferSetSort");
                context.Writer.WriteObjectStart();

                var marshaller = OfferSetSortMarshaller.Instance;
                marshaller.Marshall(requestObject.OfferSetSort, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOfferSort())
            {
                context.Writer.WritePropertyName("OfferSort");
                context.Writer.WriteObjectStart();

                var marshaller = OfferSortMarshaller.Instance;
                marshaller.Marshall(requestObject.OfferSort, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetResaleAuthorizationSort())
            {
                context.Writer.WritePropertyName("ResaleAuthorizationSort");
                context.Writer.WriteObjectStart();

                var marshaller = ResaleAuthorizationSortMarshaller.Instance;
                marshaller.Marshall(requestObject.ResaleAuthorizationSort, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSaaSProductSort())
            {
                context.Writer.WritePropertyName("SaaSProductSort");
                context.Writer.WriteObjectStart();

                var marshaller = SaaSProductSortMarshaller.Instance;
                marshaller.Marshall(requestObject.SaaSProductSort, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EntityTypeSortMarshaller Instance = new EntityTypeSortMarshaller();

    }
}