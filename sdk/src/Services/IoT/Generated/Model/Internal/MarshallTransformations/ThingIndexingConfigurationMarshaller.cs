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
    /// ThingIndexingConfiguration Marshaller
    /// </summary>
    public class ThingIndexingConfigurationMarshaller : IRequestMarshaller<ThingIndexingConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ThingIndexingConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCustomFields())
            {
                context.Writer.WritePropertyName("customFields");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCustomFieldsListValue in requestObject.CustomFields)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FieldMarshaller.Instance;
                    marshaller.Marshall(requestObjectCustomFieldsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDeviceDefenderIndexingMode())
            {
                context.Writer.WritePropertyName("deviceDefenderIndexingMode");
                context.Writer.WriteStringValue(requestObject.DeviceDefenderIndexingMode);
            }

            if(requestObject.IsSetFilter())
            {
                context.Writer.WritePropertyName("filter");
                context.Writer.WriteStartObject();

                var marshaller = IndexingFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.Filter, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetManagedFields())
            {
                context.Writer.WritePropertyName("managedFields");
                context.Writer.WriteStartArray();
                foreach(var requestObjectManagedFieldsListValue in requestObject.ManagedFields)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FieldMarshaller.Instance;
                    marshaller.Marshall(requestObjectManagedFieldsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetNamedShadowIndexingMode())
            {
                context.Writer.WritePropertyName("namedShadowIndexingMode");
                context.Writer.WriteStringValue(requestObject.NamedShadowIndexingMode);
            }

            if(requestObject.IsSetThingConnectivityIndexingMode())
            {
                context.Writer.WritePropertyName("thingConnectivityIndexingMode");
                context.Writer.WriteStringValue(requestObject.ThingConnectivityIndexingMode);
            }

            if(requestObject.IsSetThingIndexingMode())
            {
                context.Writer.WritePropertyName("thingIndexingMode");
                context.Writer.WriteStringValue(requestObject.ThingIndexingMode);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ThingIndexingConfigurationMarshaller Instance = new ThingIndexingConfigurationMarshaller();

    }
}