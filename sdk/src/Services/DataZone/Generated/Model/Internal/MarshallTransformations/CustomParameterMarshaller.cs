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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CustomParameter Marshaller
    /// </summary>
    public class CustomParameterMarshaller : IRequestMarshaller<CustomParameter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CustomParameter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDefaultValue())
            {
                context.Writer.WritePropertyName("defaultValue");
                context.Writer.WriteStringValue(requestObject.DefaultValue);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetFieldType())
            {
                context.Writer.WritePropertyName("fieldType");
                context.Writer.WriteStringValue(requestObject.FieldType);
            }

            if(requestObject.IsSetIsEditable())
            {
                context.Writer.WritePropertyName("isEditable");
                context.Writer.WriteBooleanValue(requestObject.IsEditable.Value);
            }

            if(requestObject.IsSetIsOptional())
            {
                context.Writer.WritePropertyName("isOptional");
                context.Writer.WriteBooleanValue(requestObject.IsOptional.Value);
            }

            if(requestObject.IsSetIsUpdateSupported())
            {
                context.Writer.WritePropertyName("isUpdateSupported");
                context.Writer.WriteBooleanValue(requestObject.IsUpdateSupported.Value);
            }

            if(requestObject.IsSetKeyName())
            {
                context.Writer.WritePropertyName("keyName");
                context.Writer.WriteStringValue(requestObject.KeyName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CustomParameterMarshaller Instance = new CustomParameterMarshaller();

    }
}