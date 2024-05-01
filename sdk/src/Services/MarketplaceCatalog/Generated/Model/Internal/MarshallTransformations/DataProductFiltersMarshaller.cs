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
    /// DataProductFilters Marshaller
    /// </summary>
    public class DataProductFiltersMarshaller : IRequestMarshaller<DataProductFilters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DataProductFilters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEntityId())
            {
                context.Writer.WritePropertyName("EntityId");
                context.Writer.WriteObjectStart();

                var marshaller = DataProductEntityIdFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.EntityId, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLastModifiedDate())
            {
                context.Writer.WritePropertyName("LastModifiedDate");
                context.Writer.WriteObjectStart();

                var marshaller = DataProductLastModifiedDateFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.LastModifiedDate, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetProductTitle())
            {
                context.Writer.WritePropertyName("ProductTitle");
                context.Writer.WriteObjectStart();

                var marshaller = DataProductTitleFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.ProductTitle, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVisibility())
            {
                context.Writer.WritePropertyName("Visibility");
                context.Writer.WriteObjectStart();

                var marshaller = DataProductVisibilityFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.Visibility, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DataProductFiltersMarshaller Instance = new DataProductFiltersMarshaller();

    }
}