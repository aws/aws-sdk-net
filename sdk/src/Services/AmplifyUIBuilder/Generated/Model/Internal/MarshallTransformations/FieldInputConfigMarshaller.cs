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
            if(requestObject.IsSetDefaultChecked())
            {
                context.Writer.WritePropertyName("defaultChecked");
                context.Writer.Write(requestObject.DefaultChecked);
            }

            if(requestObject.IsSetDefaultCountryCode())
            {
                context.Writer.WritePropertyName("defaultCountryCode");
                context.Writer.Write(requestObject.DefaultCountryCode);
            }

            if(requestObject.IsSetDefaultValue())
            {
                context.Writer.WritePropertyName("defaultValue");
                context.Writer.Write(requestObject.DefaultValue);
            }

            if(requestObject.IsSetDescriptiveText())
            {
                context.Writer.WritePropertyName("descriptiveText");
                context.Writer.Write(requestObject.DescriptiveText);
            }

            if(requestObject.IsSetFileUploaderConfig())
            {
                context.Writer.WritePropertyName("fileUploaderConfig");
                context.Writer.WriteObjectStart();

                var marshaller = FileUploaderFieldConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.FileUploaderConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetIsArray())
            {
                context.Writer.WritePropertyName("isArray");
                context.Writer.Write(requestObject.IsArray);
            }

            if(requestObject.IsSetMaxValue())
            {
                context.Writer.WritePropertyName("maxValue");
                context.Writer.Write(requestObject.MaxValue);
            }

            if(requestObject.IsSetMinValue())
            {
                context.Writer.WritePropertyName("minValue");
                context.Writer.Write(requestObject.MinValue);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetPlaceholder())
            {
                context.Writer.WritePropertyName("placeholder");
                context.Writer.Write(requestObject.Placeholder);
            }

            if(requestObject.IsSetReadOnly())
            {
                context.Writer.WritePropertyName("readOnly");
                context.Writer.Write(requestObject.ReadOnly);
            }

            if(requestObject.IsSetRequired())
            {
                context.Writer.WritePropertyName("required");
                context.Writer.Write(requestObject.Required);
            }

            if(requestObject.IsSetStep())
            {
                context.Writer.WritePropertyName("step");
                context.Writer.Write(requestObject.Step);
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.Write(requestObject.Type);
            }

            if(requestObject.IsSetValue())
            {
                context.Writer.WritePropertyName("value");
                context.Writer.Write(requestObject.Value);
            }

            if(requestObject.IsSetValueMappings())
            {
                context.Writer.WritePropertyName("valueMappings");
                context.Writer.WriteObjectStart();

                var marshaller = ValueMappingsMarshaller.Instance;
                marshaller.Marshall(requestObject.ValueMappings, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FieldInputConfigMarshaller Instance = new FieldInputConfigMarshaller();

    }
}