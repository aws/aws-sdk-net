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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TransformConfigParameter Marshaller
    /// </summary>
    public class TransformConfigParameterMarshaller : IRequestMarshaller<TransformConfigParameter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TransformConfigParameter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetIsOptional())
            {
                context.Writer.WritePropertyName("IsOptional");
                context.Writer.WriteBooleanValue(requestObject.IsOptional.Value);
            }

            if(requestObject.IsSetListType())
            {
                context.Writer.WritePropertyName("ListType");
                context.Writer.WriteStringValue(requestObject.ListType);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

            if(requestObject.IsSetValidationMessage())
            {
                context.Writer.WritePropertyName("ValidationMessage");
                context.Writer.WriteStringValue(requestObject.ValidationMessage);
            }

            if(requestObject.IsSetValidationRule())
            {
                context.Writer.WritePropertyName("ValidationRule");
                context.Writer.WriteStringValue(requestObject.ValidationRule);
            }

            if(requestObject.IsSetValue())
            {
                context.Writer.WritePropertyName("Value");
                context.Writer.WriteStartArray();
                foreach(var requestObjectValueListValue in requestObject.Value)
                {
                        context.Writer.WriteStringValue(requestObjectValueListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TransformConfigParameterMarshaller Instance = new TransformConfigParameterMarshaller();

    }
}