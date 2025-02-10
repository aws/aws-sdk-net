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
    /// ThingGroupIndexingConfiguration Marshaller
    /// </summary>
    public class ThingGroupIndexingConfigurationMarshaller : IRequestMarshaller<ThingGroupIndexingConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ThingGroupIndexingConfiguration requestObject, JsonMarshallerContext context)
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

            if(requestObject.IsSetThingGroupIndexingMode())
            {
                context.Writer.WritePropertyName("thingGroupIndexingMode");
                context.Writer.WriteStringValue(requestObject.ThingGroupIndexingMode);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ThingGroupIndexingConfigurationMarshaller Instance = new ThingGroupIndexingConfigurationMarshaller();

    }
}