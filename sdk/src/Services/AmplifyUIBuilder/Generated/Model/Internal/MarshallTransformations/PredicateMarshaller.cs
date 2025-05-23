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
    /// Predicate Marshaller
    /// </summary>
    public class PredicateMarshaller : IRequestMarshaller<Predicate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Predicate requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAnd())
            {
                context.Writer.WritePropertyName("and");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAndListValue in requestObject.And)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PredicateMarshaller.Instance;
                    marshaller.Marshall(requestObjectAndListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetField())
            {
                context.Writer.WritePropertyName("field");
                context.Writer.WriteStringValue(requestObject.Field);
            }

            if(requestObject.IsSetOperand())
            {
                context.Writer.WritePropertyName("operand");
                context.Writer.WriteStringValue(requestObject.Operand);
            }

            if(requestObject.IsSetOperandType())
            {
                context.Writer.WritePropertyName("operandType");
                context.Writer.WriteStringValue(requestObject.OperandType);
            }

            if(requestObject.IsSetOperator())
            {
                context.Writer.WritePropertyName("operator");
                context.Writer.WriteStringValue(requestObject.Operator);
            }

            if(requestObject.IsSetOr())
            {
                context.Writer.WritePropertyName("or");
                context.Writer.WriteStartArray();
                foreach(var requestObjectOrListValue in requestObject.Or)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PredicateMarshaller.Instance;
                    marshaller.Marshall(requestObjectOrListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PredicateMarshaller Instance = new PredicateMarshaller();

    }
}