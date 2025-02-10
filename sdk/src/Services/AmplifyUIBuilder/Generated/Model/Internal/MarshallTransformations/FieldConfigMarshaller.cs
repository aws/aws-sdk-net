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
    /// FieldConfig Marshaller
    /// </summary>
    public class FieldConfigMarshaller : IRequestMarshaller<FieldConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FieldConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetExcluded())
            {
                context.Writer.WritePropertyName("excluded");
                context.Writer.WriteBooleanValue(requestObject.Excluded.Value);
            }

            if(requestObject.IsSetInputType())
            {
                context.Writer.WritePropertyName("inputType");
                context.Writer.WriteStartObject();

                var marshaller = FieldInputConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.InputType, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLabel())
            {
                context.Writer.WritePropertyName("label");
                context.Writer.WriteStringValue(requestObject.Label);
            }

            if(requestObject.IsSetPosition())
            {
                context.Writer.WritePropertyName("position");
                context.Writer.WriteStartObject();

                var marshaller = FieldPositionMarshaller.Instance;
                marshaller.Marshall(requestObject.Position, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetValidations())
            {
                context.Writer.WritePropertyName("validations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectValidationsListValue in requestObject.Validations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FieldValidationConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectValidationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FieldConfigMarshaller Instance = new FieldConfigMarshaller();

    }
}