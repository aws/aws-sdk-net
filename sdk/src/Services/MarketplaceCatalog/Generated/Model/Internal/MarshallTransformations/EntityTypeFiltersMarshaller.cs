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
    /// EntityTypeFilters Marshaller
    /// </summary>
    public class EntityTypeFiltersMarshaller : IRequestMarshaller<EntityTypeFilters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EntityTypeFilters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAmiProductFilters())
            {
                context.Writer.WritePropertyName("AmiProductFilters");
                context.Writer.WriteStartObject();

                var marshaller = AmiProductFiltersMarshaller.Instance;
                marshaller.Marshall(requestObject.AmiProductFilters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetContainerProductFilters())
            {
                context.Writer.WritePropertyName("ContainerProductFilters");
                context.Writer.WriteStartObject();

                var marshaller = ContainerProductFiltersMarshaller.Instance;
                marshaller.Marshall(requestObject.ContainerProductFilters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDataProductFilters())
            {
                context.Writer.WritePropertyName("DataProductFilters");
                context.Writer.WriteStartObject();

                var marshaller = DataProductFiltersMarshaller.Instance;
                marshaller.Marshall(requestObject.DataProductFilters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMachineLearningProductFilters())
            {
                context.Writer.WritePropertyName("MachineLearningProductFilters");
                context.Writer.WriteStartObject();

                var marshaller = MachineLearningProductFiltersMarshaller.Instance;
                marshaller.Marshall(requestObject.MachineLearningProductFilters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOfferFilters())
            {
                context.Writer.WritePropertyName("OfferFilters");
                context.Writer.WriteStartObject();

                var marshaller = OfferFiltersMarshaller.Instance;
                marshaller.Marshall(requestObject.OfferFilters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetResaleAuthorizationFilters())
            {
                context.Writer.WritePropertyName("ResaleAuthorizationFilters");
                context.Writer.WriteStartObject();

                var marshaller = ResaleAuthorizationFiltersMarshaller.Instance;
                marshaller.Marshall(requestObject.ResaleAuthorizationFilters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSaaSProductFilters())
            {
                context.Writer.WritePropertyName("SaaSProductFilters");
                context.Writer.WriteStartObject();

                var marshaller = SaaSProductFiltersMarshaller.Instance;
                marshaller.Marshall(requestObject.SaaSProductFilters, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EntityTypeFiltersMarshaller Instance = new EntityTypeFiltersMarshaller();

    }
}