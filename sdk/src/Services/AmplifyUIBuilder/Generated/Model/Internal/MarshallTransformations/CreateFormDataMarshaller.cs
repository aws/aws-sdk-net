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
    /// CreateFormData Marshaller
    /// </summary>
    public class CreateFormDataMarshaller : IRequestMarshaller<CreateFormData, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CreateFormData requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCta())
            {
                context.Writer.WritePropertyName("cta");
                context.Writer.WriteObjectStart();

                var marshaller = FormCTAMarshaller.Instance;
                marshaller.Marshall(requestObject.Cta, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDataType())
            {
                context.Writer.WritePropertyName("dataType");
                context.Writer.WriteObjectStart();

                var marshaller = FormDataTypeConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.DataType, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFields())
            {
                context.Writer.WritePropertyName("fields");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectFieldsKvp in requestObject.Fields)
                {
                    context.Writer.WritePropertyName(requestObjectFieldsKvp.Key);
                    var requestObjectFieldsValue = requestObjectFieldsKvp.Value;

                    context.Writer.WriteObjectStart();

                    var marshaller = FieldConfigMarshaller.Instance;
                    marshaller.Marshall(requestObjectFieldsValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFormActionType())
            {
                context.Writer.WritePropertyName("formActionType");
                context.Writer.Write(requestObject.FormActionType);
            }

            if(requestObject.IsSetLabelDecorator())
            {
                context.Writer.WritePropertyName("labelDecorator");
                context.Writer.Write(requestObject.LabelDecorator);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetSchemaVersion())
            {
                context.Writer.WritePropertyName("schemaVersion");
                context.Writer.Write(requestObject.SchemaVersion);
            }

            if(requestObject.IsSetSectionalElements())
            {
                context.Writer.WritePropertyName("sectionalElements");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectSectionalElementsKvp in requestObject.SectionalElements)
                {
                    context.Writer.WritePropertyName(requestObjectSectionalElementsKvp.Key);
                    var requestObjectSectionalElementsValue = requestObjectSectionalElementsKvp.Value;

                    context.Writer.WriteObjectStart();

                    var marshaller = SectionalElementMarshaller.Instance;
                    marshaller.Marshall(requestObjectSectionalElementsValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStyle())
            {
                context.Writer.WritePropertyName("style");
                context.Writer.WriteObjectStart();

                var marshaller = FormStyleMarshaller.Instance;
                marshaller.Marshall(requestObject.Style, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectTagsKvp in requestObject.Tags)
                {
                    context.Writer.WritePropertyName(requestObjectTagsKvp.Key);
                    var requestObjectTagsValue = requestObjectTagsKvp.Value;

                        context.Writer.Write(requestObjectTagsValue);
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CreateFormDataMarshaller Instance = new CreateFormDataMarshaller();

    }
}