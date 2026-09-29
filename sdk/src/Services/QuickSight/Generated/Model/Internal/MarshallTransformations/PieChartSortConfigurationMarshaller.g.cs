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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.QuickSight.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PieChartSortConfiguration Marshaller
    /// </summary>
    public partial class PieChartSortConfigurationMarshaller : IRequestMarshaller<PieChartSortConfiguration, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(PieChartSortConfiguration requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetCategoryItemsLimit())
            {
                context.Writer.WritePropertyName("CategoryItemsLimit");
                context.Writer.WriteStartObject();

                var marshaller = ItemsLimitConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.CategoryItemsLimit, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetCategorySort())
            {
                context.Writer.WritePropertyName("CategorySort");
                context.Writer.WriteStartArray();
                foreach (var requestObjectCategorySortListValue in requestObject.CategorySort)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FieldSortOptionsMarshaller.Instance;
                    marshaller.Marshall(requestObjectCategorySortListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetSmallMultiplesLimitConfiguration())
            {
                context.Writer.WritePropertyName("SmallMultiplesLimitConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ItemsLimitConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SmallMultiplesLimitConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetSmallMultiplesSort())
            {
                context.Writer.WritePropertyName("SmallMultiplesSort");
                context.Writer.WriteStartArray();
                foreach (var requestObjectSmallMultiplesSortListValue in requestObject.SmallMultiplesSort)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FieldSortOptionsMarshaller.Instance;
                    marshaller.Marshall(requestObjectSmallMultiplesSortListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static PieChartSortConfigurationMarshaller Instance = new PieChartSortConfigurationMarshaller();
    }
}
