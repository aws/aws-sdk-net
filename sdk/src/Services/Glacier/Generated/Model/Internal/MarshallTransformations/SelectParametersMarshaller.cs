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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glacier.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Glacier.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SelectParameters Marshaller
    /// </summary>
    public class SelectParametersMarshaller : IRequestMarshaller<SelectParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SelectParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetExpression())
            {
                context.Writer.WritePropertyName("Expression");
                context.Writer.WriteStringValue(requestObject.Expression);
            }

            if(requestObject.IsSetExpressionType())
            {
                context.Writer.WritePropertyName("ExpressionType");
                context.Writer.WriteStringValue(requestObject.ExpressionType);
            }

            if(requestObject.IsSetInputSerialization())
            {
                context.Writer.WritePropertyName("InputSerialization");
                context.Writer.WriteStartObject();

                var marshaller = InputSerializationMarshaller.Instance;
                marshaller.Marshall(requestObject.InputSerialization, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOutputSerialization())
            {
                context.Writer.WritePropertyName("OutputSerialization");
                context.Writer.WriteStartObject();

                var marshaller = OutputSerializationMarshaller.Instance;
                marshaller.Marshall(requestObject.OutputSerialization, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SelectParametersMarshaller Instance = new SelectParametersMarshaller();

    }
}