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
using ThirdParty.Json.LitJson;

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Filter Marshaller
    /// </summary>
    public class FilterMarshaller : IRequestMarshaller<Filter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Filter requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCategoryFilter())
            {
                context.Writer.WritePropertyName("CategoryFilter");
                context.Writer.WriteObjectStart();

                var marshaller = CategoryFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.CategoryFilter, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetNumericEqualityFilter())
            {
                context.Writer.WritePropertyName("NumericEqualityFilter");
                context.Writer.WriteObjectStart();

                var marshaller = NumericEqualityFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.NumericEqualityFilter, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetNumericRangeFilter())
            {
                context.Writer.WritePropertyName("NumericRangeFilter");
                context.Writer.WriteObjectStart();

                var marshaller = NumericRangeFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.NumericRangeFilter, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRelativeDatesFilter())
            {
                context.Writer.WritePropertyName("RelativeDatesFilter");
                context.Writer.WriteObjectStart();

                var marshaller = RelativeDatesFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.RelativeDatesFilter, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTimeEqualityFilter())
            {
                context.Writer.WritePropertyName("TimeEqualityFilter");
                context.Writer.WriteObjectStart();

                var marshaller = TimeEqualityFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.TimeEqualityFilter, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTimeRangeFilter())
            {
                context.Writer.WritePropertyName("TimeRangeFilter");
                context.Writer.WriteObjectStart();

                var marshaller = TimeRangeFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.TimeRangeFilter, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTopBottomFilter())
            {
                context.Writer.WritePropertyName("TopBottomFilter");
                context.Writer.WriteObjectStart();

                var marshaller = TopBottomFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.TopBottomFilter, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FilterMarshaller Instance = new FilterMarshaller();

    }
}