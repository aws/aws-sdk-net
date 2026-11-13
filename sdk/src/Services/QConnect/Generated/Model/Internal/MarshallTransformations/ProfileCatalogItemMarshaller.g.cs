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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.QConnect.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.QConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ProfileCatalogItem Marshaller
    /// </summary>
    public partial class ProfileCatalogItemMarshaller : IRequestMarshaller<ProfileCatalogItem, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ProfileCatalogItem requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAdditionalInformation())
            {
                context.Writer.WritePropertyName("additionalInformation");
                context.Writer.WriteStringValue(requestObject.AdditionalInformation);
            }

            if (requestObject.IsSetAttributes())
            {
                context.Writer.WritePropertyName("attributes");
                context.Writer.WriteStartObject();
                foreach (var requestObjectAttributesKvp in requestObject.Attributes)
                {
                    context.Writer.WritePropertyName(requestObjectAttributesKvp.Key);
                    var requestObjectAttributesValue = requestObjectAttributesKvp.Value;
                    context.Writer.WriteStringValue(requestObjectAttributesValue);
                }
                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetCategory())
            {
                context.Writer.WritePropertyName("category");
                context.Writer.WriteStringValue(requestObject.Category);
            }

            if (requestObject.IsSetCode())
            {
                context.Writer.WritePropertyName("code");
                context.Writer.WriteStringValue(requestObject.Code);
            }

            if (requestObject.IsSetCreatedAt())
            {
                context.Writer.WritePropertyName("createdAt");
                context.Writer.WriteStringValue(requestObject.CreatedAt);
            }

            if (requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if (requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("id");
                context.Writer.WriteStringValue(requestObject.Id);
            }

            if (requestObject.IsSetImageLink())
            {
                context.Writer.WritePropertyName("imageLink");
                context.Writer.WriteStringValue(requestObject.ImageLink);
            }

            if (requestObject.IsSetLink())
            {
                context.Writer.WritePropertyName("link");
                context.Writer.WriteStringValue(requestObject.Link);
            }

            if (requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if (requestObject.IsSetPrice())
            {
                context.Writer.WritePropertyName("price");
                context.Writer.WriteStringValue(requestObject.Price);
            }

            if (requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

            if (requestObject.IsSetUpdatedAt())
            {
                context.Writer.WritePropertyName("updatedAt");
                context.Writer.WriteStringValue(requestObject.UpdatedAt);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ProfileCatalogItemMarshaller Instance = new ProfileCatalogItemMarshaller();
    }
}
