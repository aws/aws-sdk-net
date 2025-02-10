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
    /// FieldInputConfig Marshaller
    /// </summary>
    public class FieldInputConfigMarshaller : IRequestMarshaller<FieldInputConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FieldInputConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDefaultChecked())
            {
                context.Writer.WritePropertyName("defaultChecked");
                context.Writer.WriteBooleanValue(requestObject.DefaultChecked.Value);
            }

            if(requestObject.IsSetDefaultCountryCode())
            {
                context.Writer.WritePropertyName("defaultCountryCode");
                context.Writer.WriteStringValue(requestObject.DefaultCountryCode);
            }

            if(requestObject.IsSetDefaultValue())
            {
                context.Writer.WritePropertyName("defaultValue");
                context.Writer.WriteStringValue(requestObject.DefaultValue);
            }

            if(requestObject.IsSetDescriptiveText())
            {
                context.Writer.WritePropertyName("descriptiveText");
                context.Writer.WriteStringValue(requestObject.DescriptiveText);
            }

            if(requestObject.IsSetFileUploaderConfig())
            {
                context.Writer.WritePropertyName("fileUploaderConfig");
                context.Writer.WriteStartObject();

                var marshaller = FileUploaderFieldConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.FileUploaderConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIsArray())
            {
                context.Writer.WritePropertyName("isArray");
                context.Writer.WriteBooleanValue(requestObject.IsArray.Value);
            }

            if(requestObject.IsSetMaxValue())
            {
                context.Writer.WritePropertyName("maxValue");
                if(StringUtils.IsSpecialFloatValue(requestObject.MaxValue.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialFloatValue(requestObject.MaxValue.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.MaxValue.Value);
                }
            }

            if(requestObject.IsSetMinValue())
            {
                context.Writer.WritePropertyName("minValue");
                if(StringUtils.IsSpecialFloatValue(requestObject.MinValue.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialFloatValue(requestObject.MinValue.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.MinValue.Value);
                }
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetPlaceholder())
            {
                context.Writer.WritePropertyName("placeholder");
                context.Writer.WriteStringValue(requestObject.Placeholder);
            }

            if(requestObject.IsSetReadOnly())
            {
                context.Writer.WritePropertyName("readOnly");
                context.Writer.WriteBooleanValue(requestObject.ReadOnly.Value);
            }

            if(requestObject.IsSetRequired())
            {
                context.Writer.WritePropertyName("required");
                context.Writer.WriteBooleanValue(requestObject.Required.Value);
            }

            if(requestObject.IsSetStep())
            {
                context.Writer.WritePropertyName("step");
                if(StringUtils.IsSpecialFloatValue(requestObject.Step.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialFloatValue(requestObject.Step.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Step.Value);
                }
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

            if(requestObject.IsSetValue())
            {
                context.Writer.WritePropertyName("value");
                context.Writer.WriteStringValue(requestObject.Value);
            }

            if(requestObject.IsSetValueMappings())
            {
                context.Writer.WritePropertyName("valueMappings");
                context.Writer.WriteStartObject();

                var marshaller = ValueMappingsMarshaller.Instance;
                marshaller.Marshall(requestObject.ValueMappings, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FieldInputConfigMarshaller Instance = new FieldInputConfigMarshaller();

    }
}