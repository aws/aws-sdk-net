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

using Amazon.MarketplaceCatalog.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.MarketplaceCatalog.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Change Marshaller
    /// </summary>
    public partial class ChangeMarshaller : IRequestMarshaller<Change, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(Change requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetChangeName())
            {
                context.Writer.WritePropertyName("ChangeName");
                context.Writer.WriteStringValue(requestObject.ChangeName);
            }

            if (requestObject.IsSetChangeType())
            {
                context.Writer.WritePropertyName("ChangeType");
                context.Writer.WriteStringValue(requestObject.ChangeType);
            }

            if (requestObject.IsSetDetails())
            {
                context.Writer.WritePropertyName("Details");
                context.Writer.WriteStringValue(requestObject.Details);
            }

            if (requestObject.IsSetDetailsDocument())
            {
                context.Writer.WritePropertyName("DetailsDocument");
                Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(context.Writer, requestObject.DetailsDocument);
            }

            if (requestObject.IsSetEntity())
            {
                context.Writer.WritePropertyName("Entity");
                context.Writer.WriteStartObject();

                var marshaller = EntityMarshaller.Instance;
                marshaller.Marshall(requestObject.Entity, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetEntityTags())
            {
                context.Writer.WritePropertyName("EntityTags");
                context.Writer.WriteStartArray();
                foreach (var requestObjectEntityTagsListValue in requestObject.EntityTags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(requestObjectEntityTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ChangeMarshaller Instance = new ChangeMarshaller();
    }
}
