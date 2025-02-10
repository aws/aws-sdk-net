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
#pragma warning disable CS0612,CS0618
namespace Amazon.Deadline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SearchSortExpression Marshaller
    /// </summary>
    public class SearchSortExpressionMarshaller : IRequestMarshaller<SearchSortExpression, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SearchSortExpression requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFieldSort())
            {
                context.Writer.WritePropertyName("fieldSort");
                context.Writer.WriteStartObject();

                var marshaller = FieldSortExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.FieldSort, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetParameterSort())
            {
                context.Writer.WritePropertyName("parameterSort");
                context.Writer.WriteStartObject();

                var marshaller = ParameterSortExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.ParameterSort, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetUserJobsFirst())
            {
                context.Writer.WritePropertyName("userJobsFirst");
                context.Writer.WriteStartObject();

                var marshaller = UserJobsFirstMarshaller.Instance;
                marshaller.Marshall(requestObject.UserJobsFirst, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SearchSortExpressionMarshaller Instance = new SearchSortExpressionMarshaller();

    }
}