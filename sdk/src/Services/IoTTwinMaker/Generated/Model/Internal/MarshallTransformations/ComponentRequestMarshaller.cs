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
    /// ComponentRequest Marshaller
    /// </summary>
    public class ComponentRequestMarshaller : IRequestMarshaller<ComponentRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ComponentRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetComponentTypeId())
            {
                context.Writer.WritePropertyName("componentTypeId");
                context.Writer.WriteStringValue(requestObject.ComponentTypeId);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetProperties())
            {
                context.Writer.WritePropertyName("properties");
                context.Writer.WriteStartObject();
                foreach (var requestObjectPropertiesKvp in requestObject.Properties)
                {
                    context.Writer.WritePropertyName(requestObjectPropertiesKvp.Key);
                    var requestObjectPropertiesValue = requestObjectPropertiesKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = PropertyRequestMarshaller.Instance;
                    marshaller.Marshall(requestObjectPropertiesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPropertyGroups())
            {
                context.Writer.WritePropertyName("propertyGroups");
                context.Writer.WriteStartObject();
                foreach (var requestObjectPropertyGroupsKvp in requestObject.PropertyGroups)
                {
                    context.Writer.WritePropertyName(requestObjectPropertyGroupsKvp.Key);
                    var requestObjectPropertyGroupsValue = requestObjectPropertyGroupsKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = ComponentPropertyGroupRequestMarshaller.Instance;
                    marshaller.Marshall(requestObjectPropertyGroupsValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ComponentRequestMarshaller Instance = new ComponentRequestMarshaller();

    }
}