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

using Amazon.Lightsail.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.Lightsail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DomainEntry Marshaller
    /// </summary>
    public partial class DomainEntryMarshaller : IRequestMarshaller<DomainEntry, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(DomainEntry requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("id");
                context.Writer.WriteStringValue(requestObject.Id);
            }

            if (requestObject.IsSetIsAlias())
            {
                context.Writer.WritePropertyName("isAlias");
                context.Writer.WriteBooleanValue(requestObject.IsAlias.Value);
            }

            if (requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if (requestObject.IsSetOptions())
            {
                context.Writer.WritePropertyName("options");
                context.Writer.WriteStartObject();
                foreach (var requestObjectOptionsKvp in requestObject.Options)
                {
                    context.Writer.WritePropertyName(requestObjectOptionsKvp.Key);
                    var requestObjectOptionsValue = requestObjectOptionsKvp.Value;
                    context.Writer.WriteStringValue(requestObjectOptionsValue);
                }
                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetTarget())
            {
                context.Writer.WritePropertyName("target");
                context.Writer.WriteStringValue(requestObject.Target);
            }

            if (requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.WriteStringValue(requestObject.Type);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static DomainEntryMarshaller Instance = new DomainEntryMarshaller();
    }
}
