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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Deadline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Deadline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SearchFilterExpression Marshaller
    /// </summary>
    public class SearchFilterExpressionMarshaller : IRequestMarshaller<SearchFilterExpression, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SearchFilterExpression requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDateTimeFilter())
            {
                context.Writer.WritePropertyName("dateTimeFilter");
                context.Writer.WriteObjectStart();

                var marshaller = DateTimeFilterExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.DateTimeFilter, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetGroupFilter())
            {
                context.Writer.WritePropertyName("groupFilter");
                context.Writer.WriteObjectStart();

                var marshaller = SearchGroupedFilterExpressionsMarshaller.Instance;
                marshaller.Marshall(requestObject.GroupFilter, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetParameterFilter())
            {
                context.Writer.WritePropertyName("parameterFilter");
                context.Writer.WriteObjectStart();

                var marshaller = ParameterFilterExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.ParameterFilter, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSearchTermFilter())
            {
                context.Writer.WritePropertyName("searchTermFilter");
                context.Writer.WriteObjectStart();

                var marshaller = SearchTermFilterExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.SearchTermFilter, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStringFilter())
            {
                context.Writer.WritePropertyName("stringFilter");
                context.Writer.WriteObjectStart();

                var marshaller = StringFilterExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.StringFilter, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SearchFilterExpressionMarshaller Instance = new SearchFilterExpressionMarshaller();

    }
}