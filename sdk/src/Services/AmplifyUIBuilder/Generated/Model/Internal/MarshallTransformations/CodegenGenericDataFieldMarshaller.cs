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
    /// CodegenGenericDataField Marshaller
    /// </summary>
    public class CodegenGenericDataFieldMarshaller : IRequestMarshaller<CodegenGenericDataField, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CodegenGenericDataField requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDataType())
            {
                context.Writer.WritePropertyName("dataType");
                context.Writer.WriteStringValue(requestObject.DataType);
            }

            if(requestObject.IsSetDataTypeValue())
            {
                context.Writer.WritePropertyName("dataTypeValue");
                context.Writer.WriteStringValue(requestObject.DataTypeValue);
            }

            if(requestObject.IsSetIsArray())
            {
                context.Writer.WritePropertyName("isArray");
                context.Writer.WriteBooleanValue(requestObject.IsArray.Value);
            }

            if(requestObject.IsSetReadOnly())
            {
                context.Writer.WritePropertyName("readOnly");
                context.Writer.WriteBooleanValue(requestObject.ReadOnly.Value);
            }

            if(requestObject.IsSetRelationship())
            {
                context.Writer.WritePropertyName("relationship");
                context.Writer.WriteStartObject();

                var marshaller = CodegenGenericDataRelationshipTypeMarshaller.Instance;
                marshaller.Marshall(requestObject.Relationship, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRequired())
            {
                context.Writer.WritePropertyName("required");
                context.Writer.WriteBooleanValue(requestObject.Required.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CodegenGenericDataFieldMarshaller Instance = new CodegenGenericDataFieldMarshaller();

    }
}