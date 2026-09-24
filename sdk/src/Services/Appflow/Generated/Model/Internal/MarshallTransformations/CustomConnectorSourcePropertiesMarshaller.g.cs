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

using Amazon.Appflow.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.Appflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CustomConnectorSourceProperties Marshaller
    /// </summary>
    public partial class CustomConnectorSourcePropertiesMarshaller : IRequestMarshaller<CustomConnectorSourceProperties, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(CustomConnectorSourceProperties requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetCustomProperties())
            {
                context.Writer.WritePropertyName("customProperties");
                context.Writer.WriteStartObject();
                foreach (var requestObjectCustomPropertiesKvp in requestObject.CustomProperties)
                {
                    context.Writer.WritePropertyName(requestObjectCustomPropertiesKvp.Key);
                    var requestObjectCustomPropertiesValue = requestObjectCustomPropertiesKvp.Value;
                    context.Writer.WriteStringValue(requestObjectCustomPropertiesValue);
                }
                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetDataTransferApi())
            {
                context.Writer.WritePropertyName("dataTransferApi");
                context.Writer.WriteStartObject();

                var marshaller = DataTransferApiMarshaller.Instance;
                marshaller.Marshall(requestObject.DataTransferApi, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetEntityName())
            {
                context.Writer.WritePropertyName("entityName");
                context.Writer.WriteStringValue(requestObject.EntityName);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static CustomConnectorSourcePropertiesMarshaller Instance = new CustomConnectorSourcePropertiesMarshaller();
    }
}
