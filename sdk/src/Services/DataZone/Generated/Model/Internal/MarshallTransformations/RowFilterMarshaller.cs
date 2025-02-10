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
    /// RowFilter Marshaller
    /// </summary>
    public class RowFilterMarshaller : IRequestMarshaller<RowFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RowFilter requestObject, JsonMarshallerContext context)
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

                    var marshaller = RowFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectAndListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetExpression())
            {
                context.Writer.WritePropertyName("expression");
                context.Writer.WriteStartObject();

                var marshaller = RowFilterExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.Expression, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOr())
            {
                context.Writer.WritePropertyName("or");
                context.Writer.WriteStartArray();
                foreach(var requestObjectOrListValue in requestObject.Or)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = RowFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectOrListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RowFilterMarshaller Instance = new RowFilterMarshaller();

    }
}