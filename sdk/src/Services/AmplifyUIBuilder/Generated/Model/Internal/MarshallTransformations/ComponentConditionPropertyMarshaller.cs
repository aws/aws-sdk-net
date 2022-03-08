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
    /// ComponentConditionProperty Marshaller
    /// </summary>
    public class ComponentConditionPropertyMarshaller : IRequestMarshaller<ComponentConditionProperty, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ComponentConditionProperty requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetElse())
            {
                context.Writer.WritePropertyName("else");
                context.Writer.WriteObjectStart();

                var marshaller = ComponentPropertyMarshaller.Instance;
                marshaller.Marshall(requestObject.Else, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetField())
            {
                context.Writer.WritePropertyName("field");
                context.Writer.Write(requestObject.Field);
            }

            if(requestObject.IsSetOperand())
            {
                context.Writer.WritePropertyName("operand");
                context.Writer.Write(requestObject.Operand);
            }

            if(requestObject.IsSetOperandType())
            {
                context.Writer.WritePropertyName("operandType");
                context.Writer.Write(requestObject.OperandType);
            }

            if(requestObject.IsSetOperator())
            {
                context.Writer.WritePropertyName("operator");
                context.Writer.Write(requestObject.Operator);
            }

            if(requestObject.IsSetProperty())
            {
                context.Writer.WritePropertyName("property");
                context.Writer.Write(requestObject.Property);
            }

            if(requestObject.IsSetThen())
            {
                context.Writer.WritePropertyName("then");
                context.Writer.WriteObjectStart();

                var marshaller = ComponentPropertyMarshaller.Instance;
                marshaller.Marshall(requestObject.Then, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ComponentConditionPropertyMarshaller Instance = new ComponentConditionPropertyMarshaller();

    }
}