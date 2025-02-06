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
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTTwinMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CompositeComponentUpdateRequest Marshaller
    /// </summary>
    public class CompositeComponentUpdateRequestMarshaller : IRequestMarshaller<CompositeComponentUpdateRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CompositeComponentUpdateRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetPropertyGroupUpdates())
            {
                context.Writer.WritePropertyName("propertyGroupUpdates");
                context.Writer.WriteStartObject();
                foreach (var requestObjectPropertyGroupUpdatesKvp in requestObject.PropertyGroupUpdates)
                {
                    context.Writer.WritePropertyName(requestObjectPropertyGroupUpdatesKvp.Key);
                    var requestObjectPropertyGroupUpdatesValue = requestObjectPropertyGroupUpdatesKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = ComponentPropertyGroupRequestMarshaller.Instance;
                    marshaller.Marshall(requestObjectPropertyGroupUpdatesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPropertyUpdates())
            {
                context.Writer.WritePropertyName("propertyUpdates");
                context.Writer.WriteStartObject();
                foreach (var requestObjectPropertyUpdatesKvp in requestObject.PropertyUpdates)
                {
                    context.Writer.WritePropertyName(requestObjectPropertyUpdatesKvp.Key);
                    var requestObjectPropertyUpdatesValue = requestObjectPropertyUpdatesKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = PropertyRequestMarshaller.Instance;
                    marshaller.Marshall(requestObjectPropertyUpdatesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetUpdateType())
            {
                context.Writer.WritePropertyName("updateType");
                context.Writer.WriteStringValue(requestObject.UpdateType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CompositeComponentUpdateRequestMarshaller Instance = new CompositeComponentUpdateRequestMarshaller();

    }
}