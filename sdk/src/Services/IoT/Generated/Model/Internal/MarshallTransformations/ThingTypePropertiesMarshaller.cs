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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ThingTypeProperties Marshaller
    /// </summary>
    public class ThingTypePropertiesMarshaller : IRequestMarshaller<ThingTypeProperties, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ThingTypeProperties requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetMqtt5Configuration())
            {
                context.Writer.WritePropertyName("mqtt5Configuration");
                context.Writer.WriteStartObject();

                var marshaller = Mqtt5ConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Mqtt5Configuration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSearchableAttributes())
            {
                context.Writer.WritePropertyName("searchableAttributes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSearchableAttributesListValue in requestObject.SearchableAttributes)
                {
                        context.Writer.WriteStringValue(requestObjectSearchableAttributesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetThingTypeDescription())
            {
                context.Writer.WritePropertyName("thingTypeDescription");
                context.Writer.WriteStringValue(requestObject.ThingTypeDescription);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ThingTypePropertiesMarshaller Instance = new ThingTypePropertiesMarshaller();

    }
}