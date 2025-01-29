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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.QConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// QuickResponseSearchExpression Marshaller
    /// </summary>
    public class QuickResponseSearchExpressionMarshaller : IRequestMarshaller<QuickResponseSearchExpression, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(QuickResponseSearchExpression requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFilters())
            {
                context.Writer.WritePropertyName("filters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFiltersListValue in requestObject.Filters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = QuickResponseFilterFieldMarshaller.Instance;
                    marshaller.Marshall(requestObjectFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetOrderOnField())
            {
                context.Writer.WritePropertyName("orderOnField");
                context.Writer.WriteStartObject();

                var marshaller = QuickResponseOrderFieldMarshaller.Instance;
                marshaller.Marshall(requestObject.OrderOnField, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetQueries())
            {
                context.Writer.WritePropertyName("queries");
                context.Writer.WriteStartArray();
                foreach(var requestObjectQueriesListValue in requestObject.Queries)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = QuickResponseQueryFieldMarshaller.Instance;
                    marshaller.Marshall(requestObjectQueriesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static QuickResponseSearchExpressionMarshaller Instance = new QuickResponseSearchExpressionMarshaller();

    }
}