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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lightsail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Lightsail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RelationalDatabaseParameter Marshaller
    /// </summary>
    public class RelationalDatabaseParameterMarshaller : IRequestMarshaller<RelationalDatabaseParameter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RelationalDatabaseParameter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAllowedValues())
            {
                context.Writer.WritePropertyName("allowedValues");
                context.Writer.WriteStringValue(requestObject.AllowedValues);
            }

            if(requestObject.IsSetApplyMethod())
            {
                context.Writer.WritePropertyName("applyMethod");
                context.Writer.WriteStringValue(requestObject.ApplyMethod);
            }

            if(requestObject.IsSetApplyType())
            {
                context.Writer.WritePropertyName("applyType");
                context.Writer.WriteStringValue(requestObject.ApplyType);
            }

            if(requestObject.IsSetDataType())
            {
                context.Writer.WritePropertyName("dataType");
                context.Writer.WriteStringValue(requestObject.DataType);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetIsModifiable())
            {
                context.Writer.WritePropertyName("isModifiable");
                context.Writer.WriteBooleanValue(requestObject.IsModifiable.Value);
            }

            if(requestObject.IsSetParameterName())
            {
                context.Writer.WritePropertyName("parameterName");
                context.Writer.WriteStringValue(requestObject.ParameterName);
            }

            if(requestObject.IsSetParameterValue())
            {
                context.Writer.WritePropertyName("parameterValue");
                context.Writer.WriteStringValue(requestObject.ParameterValue);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RelationalDatabaseParameterMarshaller Instance = new RelationalDatabaseParameterMarshaller();

    }
}