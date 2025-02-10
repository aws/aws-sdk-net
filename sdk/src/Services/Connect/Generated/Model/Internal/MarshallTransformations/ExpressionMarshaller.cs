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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Expression Marshaller
    /// </summary>
    public class ExpressionMarshaller : IRequestMarshaller<Expression, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Expression requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAndExpression())
            {
                context.Writer.WritePropertyName("AndExpression");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAndExpressionListValue in requestObject.AndExpression)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ExpressionMarshaller.Instance;
                    marshaller.Marshall(requestObjectAndExpressionListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetAttributeCondition())
            {
                context.Writer.WritePropertyName("AttributeCondition");
                context.Writer.WriteStartObject();

                var marshaller = AttributeConditionMarshaller.Instance;
                marshaller.Marshall(requestObject.AttributeCondition, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNotAttributeCondition())
            {
                context.Writer.WritePropertyName("NotAttributeCondition");
                context.Writer.WriteStartObject();

                var marshaller = AttributeConditionMarshaller.Instance;
                marshaller.Marshall(requestObject.NotAttributeCondition, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOrExpression())
            {
                context.Writer.WritePropertyName("OrExpression");
                context.Writer.WriteStartArray();
                foreach(var requestObjectOrExpressionListValue in requestObject.OrExpression)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ExpressionMarshaller.Instance;
                    marshaller.Marshall(requestObjectOrExpressionListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ExpressionMarshaller Instance = new ExpressionMarshaller();

    }
}