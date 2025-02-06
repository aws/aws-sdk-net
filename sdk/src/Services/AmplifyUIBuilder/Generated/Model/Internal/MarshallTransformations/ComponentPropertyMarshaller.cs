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
    /// ComponentProperty Marshaller
    /// </summary>
    public class ComponentPropertyMarshaller : IRequestMarshaller<ComponentProperty, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ComponentProperty requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBindingProperties())
            {
                context.Writer.WritePropertyName("bindingProperties");
                context.Writer.WriteStartObject();

                var marshaller = ComponentPropertyBindingPropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.BindingProperties, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBindings())
            {
                context.Writer.WritePropertyName("bindings");
                context.Writer.WriteStartObject();
                foreach (var requestObjectBindingsKvp in requestObject.Bindings)
                {
                    context.Writer.WritePropertyName(requestObjectBindingsKvp.Key);
                    var requestObjectBindingsValue = requestObjectBindingsKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = FormBindingElementMarshaller.Instance;
                    marshaller.Marshall(requestObjectBindingsValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCollectionBindingProperties())
            {
                context.Writer.WritePropertyName("collectionBindingProperties");
                context.Writer.WriteStartObject();

                var marshaller = ComponentPropertyBindingPropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.CollectionBindingProperties, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetComponentName())
            {
                context.Writer.WritePropertyName("componentName");
                context.Writer.WriteStringValue(requestObject.ComponentName);
            }

            if(requestObject.IsSetConcat())
            {
                context.Writer.WritePropertyName("concat");
                context.Writer.WriteStartArray();
                foreach(var requestObjectConcatListValue in requestObject.Concat)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ComponentPropertyMarshaller.Instance;
                    marshaller.Marshall(requestObjectConcatListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCondition())
            {
                context.Writer.WritePropertyName("condition");
                context.Writer.WriteStartObject();

                var marshaller = ComponentConditionPropertyMarshaller.Instance;
                marshaller.Marshall(requestObject.Condition, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetConfigured())
            {
                context.Writer.WritePropertyName("configured");
                context.Writer.WriteBooleanValue(requestObject.Configured.Value);
            }

            if(requestObject.IsSetDefaultValue())
            {
                context.Writer.WritePropertyName("defaultValue");
                context.Writer.WriteStringValue(requestObject.DefaultValue);
            }

            if(requestObject.IsSetEvent())
            {
                context.Writer.WritePropertyName("event");
                context.Writer.WriteStringValue(requestObject.Event);
            }

            if(requestObject.IsSetImportedValue())
            {
                context.Writer.WritePropertyName("importedValue");
                context.Writer.WriteStringValue(requestObject.ImportedValue);
            }

            if(requestObject.IsSetModel())
            {
                context.Writer.WritePropertyName("model");
                context.Writer.WriteStringValue(requestObject.Model);
            }

            if(requestObject.IsSetProperty())
            {
                context.Writer.WritePropertyName("property");
                context.Writer.WriteStringValue(requestObject.Property);
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

            if(requestObject.IsSetUserAttribute())
            {
                context.Writer.WritePropertyName("userAttribute");
                context.Writer.WriteStringValue(requestObject.UserAttribute);
            }

            if(requestObject.IsSetValue())
            {
                context.Writer.WritePropertyName("value");
                context.Writer.WriteStringValue(requestObject.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ComponentPropertyMarshaller Instance = new ComponentPropertyMarshaller();

    }
}