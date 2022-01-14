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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTTwinMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTTwinMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EntityPropertyReference Marshaller
    /// </summary>
    public class EntityPropertyReferenceMarshaller : IRequestMarshaller<EntityPropertyReference, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EntityPropertyReference requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetComponentName())
            {
                context.Writer.WritePropertyName("componentName");
                context.Writer.Write(requestObject.ComponentName);
            }

            if(requestObject.IsSetEntityId())
            {
                context.Writer.WritePropertyName("entityId");
                context.Writer.Write(requestObject.EntityId);
            }

            if(requestObject.IsSetExternalIdProperty())
            {
                context.Writer.WritePropertyName("externalIdProperty");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectExternalIdPropertyKvp in requestObject.ExternalIdProperty)
                {
                    context.Writer.WritePropertyName(requestObjectExternalIdPropertyKvp.Key);
                    var requestObjectExternalIdPropertyValue = requestObjectExternalIdPropertyKvp.Value;

                        context.Writer.Write(requestObjectExternalIdPropertyValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPropertyName())
            {
                context.Writer.WritePropertyName("propertyName");
                context.Writer.Write(requestObject.PropertyName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EntityPropertyReferenceMarshaller Instance = new EntityPropertyReferenceMarshaller();

    }
}