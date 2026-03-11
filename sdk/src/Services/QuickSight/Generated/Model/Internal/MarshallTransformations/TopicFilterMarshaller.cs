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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TopicFilter Marshaller
    /// </summary>
    public class TopicFilterMarshaller : IRequestMarshaller<TopicFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TopicFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCategoryFilter())
            {
                context.Writer.WritePropertyName("CategoryFilter");
                context.Writer.WriteStartObject();

                var marshaller = TopicCategoryFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.CategoryFilter, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDateRangeFilter())
            {
                context.Writer.WritePropertyName("DateRangeFilter");
                context.Writer.WriteStartObject();

                var marshaller = TopicDateRangeFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.DateRangeFilter, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFilterClass())
            {
                context.Writer.WritePropertyName("FilterClass");
                context.Writer.WriteStringValue(requestObject.FilterClass);
            }

            if(requestObject.IsSetFilterDescription())
            {
                context.Writer.WritePropertyName("FilterDescription");
                context.Writer.WriteStringValue(requestObject.FilterDescription);
            }

            if(requestObject.IsSetFilterName())
            {
                context.Writer.WritePropertyName("FilterName");
                context.Writer.WriteStringValue(requestObject.FilterName);
            }

            if(requestObject.IsSetFilterSynonyms())
            {
                context.Writer.WritePropertyName("FilterSynonyms");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFilterSynonymsListValue in requestObject.FilterSynonyms)
                {
                        context.Writer.WriteStringValue(requestObjectFilterSynonymsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFilterType())
            {
                context.Writer.WritePropertyName("FilterType");
                context.Writer.WriteStringValue(requestObject.FilterType);
            }

            if(requestObject.IsSetNullFilter())
            {
                context.Writer.WritePropertyName("NullFilter");
                context.Writer.WriteStartObject();

                var marshaller = TopicNullFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.NullFilter, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNumericEqualityFilter())
            {
                context.Writer.WritePropertyName("NumericEqualityFilter");
                context.Writer.WriteStartObject();

                var marshaller = TopicNumericEqualityFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.NumericEqualityFilter, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNumericRangeFilter())
            {
                context.Writer.WritePropertyName("NumericRangeFilter");
                context.Writer.WriteStartObject();

                var marshaller = TopicNumericRangeFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.NumericRangeFilter, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOperandFieldName())
            {
                context.Writer.WritePropertyName("OperandFieldName");
                context.Writer.WriteStringValue(requestObject.OperandFieldName);
            }

            if(requestObject.IsSetRelativeDateFilter())
            {
                context.Writer.WritePropertyName("RelativeDateFilter");
                context.Writer.WriteStartObject();

                var marshaller = TopicRelativeDateFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.RelativeDateFilter, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TopicFilterMarshaller Instance = new TopicFilterMarshaller();

    }
}