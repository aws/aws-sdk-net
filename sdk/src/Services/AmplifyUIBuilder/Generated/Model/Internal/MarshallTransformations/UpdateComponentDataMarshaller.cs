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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetBindingProperties())
            {
                context.Writer.WritePropertyName("bindingProperties");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectBindingPropertiesKvp in requestObject.BindingProperties)
                {
                    context.Writer.WritePropertyName(requestObjectBindingPropertiesKvp.Key);
                    var requestObjectBindingPropertiesValue = requestObjectBindingPropertiesKvp.Value;

                    context.Writer.WriteObjectStart();

                    var marshaller = ComponentBindingPropertiesValueMarshaller.Instance;
                    marshaller.Marshall(requestObjectBindingPropertiesValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetChildren())
            {
                context.Writer.WritePropertyName("children");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectChildrenListValue in requestObject.Children)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ComponentChildMarshaller.Instance;
                    marshaller.Marshall(requestObjectChildrenListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCollectionProperties())
            {
                context.Writer.WritePropertyName("collectionProperties");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectCollectionPropertiesKvp in requestObject.CollectionProperties)
                {
                    context.Writer.WritePropertyName(requestObjectCollectionPropertiesKvp.Key);
                    var requestObjectCollectionPropertiesValue = requestObjectCollectionPropertiesKvp.Value;

                    context.Writer.WriteObjectStart();

                    var marshaller = ComponentDataConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectCollectionPropertiesValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetComponentType())
            {
                context.Writer.WritePropertyName("componentType");
                context.Writer.Write(requestObject.ComponentType);
            }

            if(requestObject.IsSetEvents())
            {
                context.Writer.WritePropertyName("events");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectEventsKvp in requestObject.Events)
                {
                    context.Writer.WritePropertyName(requestObjectEventsKvp.Key);
                    var requestObjectEventsValue = requestObjectEventsKvp.Value;

                    context.Writer.WriteObjectStart();

                    var marshaller = ComponentEventMarshaller.Instance;
                    marshaller.Marshall(requestObjectEventsValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("id");
                context.Writer.Write(requestObject.Id);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetOverrides())
            {
                context.Writer.WritePropertyName("overrides");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectOverridesKvp in requestObject.Overrides)
                {
                    context.Writer.WritePropertyName(requestObjectOverridesKvp.Key);
                    var requestObjectOverridesValue = requestObjectOverridesKvp.Value;

                    context.Writer.WriteObjectStart();
                    foreach (var requestObjectOverridesValueKvp in requestObjectOverridesValue)
                    {
                        context.Writer.WritePropertyName(requestObjectOverridesValueKvp.Key);
                        var requestObjectOverridesValueValue = requestObjectOverridesValueKvp.Value;

                            context.Writer.Write(requestObjectOverridesValueValue);
                    }
                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetProperties())
            {
                context.Writer.WritePropertyName("properties");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectPropertiesKvp in requestObject.Properties)
                {
                    context.Writer.WritePropertyName(requestObjectPropertiesKvp.Key);
                    var requestObjectPropertiesValue = requestObjectPropertiesKvp.Value;

                    context.Writer.WriteObjectStart();

                    var marshaller = ComponentPropertyMarshaller.Instance;
                    marshaller.Marshall(requestObjectPropertiesValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSchemaVersion())
            {
                context.Writer.WritePropertyName("schemaVersion");
                context.Writer.Write(requestObject.SchemaVersion);
            }

            if(requestObject.IsSetSourceId())
            {
                context.Writer.WritePropertyName("sourceId");
                context.Writer.Write(requestObject.SourceId);
            }

            if(requestObject.IsSetVariants())
            {
                context.Writer.WritePropertyName("variants");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectVariantsListValue in requestObject.Variants)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ComponentVariantMarshaller.Instance;
                    marshaller.Marshall(requestObjectVariantsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UpdateComponentDataMarshaller Instance = new UpdateComponentDataMarshaller();

    }
}