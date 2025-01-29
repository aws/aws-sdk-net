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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AmplifyUIBuilder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AmplifyUIBuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateComponentData Marshaller
    /// </summary>
    public class UpdateComponentDataMarshaller : IRequestMarshaller<UpdateComponentData, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpdateComponentData requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBindingProperties())
            {
                context.Writer.WritePropertyName("bindingProperties");
                context.Writer.WriteStartObject();
                foreach (var requestObjectBindingPropertiesKvp in requestObject.BindingProperties)
                {
                    context.Writer.WritePropertyName(requestObjectBindingPropertiesKvp.Key);
                    var requestObjectBindingPropertiesValue = requestObjectBindingPropertiesKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = ComponentBindingPropertiesValueMarshaller.Instance;
                    marshaller.Marshall(requestObjectBindingPropertiesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetChildren())
            {
                context.Writer.WritePropertyName("children");
                context.Writer.WriteStartArray();
                foreach(var requestObjectChildrenListValue in requestObject.Children)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ComponentChildMarshaller.Instance;
                    marshaller.Marshall(requestObjectChildrenListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCollectionProperties())
            {
                context.Writer.WritePropertyName("collectionProperties");
                context.Writer.WriteStartObject();
                foreach (var requestObjectCollectionPropertiesKvp in requestObject.CollectionProperties)
                {
                    context.Writer.WritePropertyName(requestObjectCollectionPropertiesKvp.Key);
                    var requestObjectCollectionPropertiesValue = requestObjectCollectionPropertiesKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = ComponentDataConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectCollectionPropertiesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetComponentType())
            {
                context.Writer.WritePropertyName("componentType");
                context.Writer.WriteStringValue(requestObject.ComponentType);
            }

            if(requestObject.IsSetEvents())
            {
                context.Writer.WritePropertyName("events");
                context.Writer.WriteStartObject();
                foreach (var requestObjectEventsKvp in requestObject.Events)
                {
                    context.Writer.WritePropertyName(requestObjectEventsKvp.Key);
                    var requestObjectEventsValue = requestObjectEventsKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = ComponentEventMarshaller.Instance;
                    marshaller.Marshall(requestObjectEventsValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("id");
                context.Writer.WriteStringValue(requestObject.Id);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetOverrides())
            {
                context.Writer.WritePropertyName("overrides");
                context.Writer.WriteStartObject();
                foreach (var requestObjectOverridesKvp in requestObject.Overrides)
                {
                    context.Writer.WritePropertyName(requestObjectOverridesKvp.Key);
                    var requestObjectOverridesValue = requestObjectOverridesKvp.Value;

                    context.Writer.WriteStartObject();
                    foreach (var requestObjectOverridesValueKvp in requestObjectOverridesValue)
                    {
                        context.Writer.WritePropertyName(requestObjectOverridesValueKvp.Key);
                        var requestObjectOverridesValueValue = requestObjectOverridesValueKvp.Value;

                            context.Writer.WriteStringValue(requestObjectOverridesValueValue);
                    }
                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
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

                    var marshaller = ComponentPropertyMarshaller.Instance;
                    marshaller.Marshall(requestObjectPropertiesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSchemaVersion())
            {
                context.Writer.WritePropertyName("schemaVersion");
                context.Writer.WriteStringValue(requestObject.SchemaVersion);
            }

            if(requestObject.IsSetSourceId())
            {
                context.Writer.WritePropertyName("sourceId");
                context.Writer.WriteStringValue(requestObject.SourceId);
            }

            if(requestObject.IsSetVariants())
            {
                context.Writer.WritePropertyName("variants");
                context.Writer.WriteStartArray();
                foreach(var requestObjectVariantsListValue in requestObject.Variants)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ComponentVariantMarshaller.Instance;
                    marshaller.Marshall(requestObjectVariantsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UpdateComponentDataMarshaller Instance = new UpdateComponentDataMarshaller();

    }
}