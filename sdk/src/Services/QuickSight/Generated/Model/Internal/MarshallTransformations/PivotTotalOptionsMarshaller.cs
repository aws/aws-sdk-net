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

#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PivotTotalOptions Marshaller
    /// </summary>
    public class PivotTotalOptionsMarshaller : IRequestMarshaller<PivotTotalOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PivotTotalOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCustomLabel())
            {
                context.Writer.WritePropertyName("CustomLabel");
                context.Writer.Write(requestObject.CustomLabel);
            }

            if(requestObject.IsSetMetricHeaderCellStyle())
            {
                context.Writer.WritePropertyName("MetricHeaderCellStyle");
                context.Writer.WriteObjectStart();

                var marshaller = TableCellStyleMarshaller.Instance;
                marshaller.Marshall(requestObject.MetricHeaderCellStyle, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPlacement())
            {
                context.Writer.WritePropertyName("Placement");
                context.Writer.Write(requestObject.Placement);
            }

            if(requestObject.IsSetScrollStatus())
            {
                context.Writer.WritePropertyName("ScrollStatus");
                context.Writer.Write(requestObject.ScrollStatus);
            }

            if(requestObject.IsSetTotalAggregationOptions())
            {
                context.Writer.WritePropertyName("TotalAggregationOptions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTotalAggregationOptionsListValue in requestObject.TotalAggregationOptions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = TotalAggregationOptionMarshaller.Instance;
                    marshaller.Marshall(requestObjectTotalAggregationOptionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTotalCellStyle())
            {
                context.Writer.WritePropertyName("TotalCellStyle");
                context.Writer.WriteObjectStart();

                var marshaller = TableCellStyleMarshaller.Instance;
                marshaller.Marshall(requestObject.TotalCellStyle, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTotalsVisibility())
            {
                context.Writer.WritePropertyName("TotalsVisibility");
                context.Writer.Write(requestObject.TotalsVisibility);
            }

            if(requestObject.IsSetValueCellStyle())
            {
                context.Writer.WritePropertyName("ValueCellStyle");
                context.Writer.WriteObjectStart();

                var marshaller = TableCellStyleMarshaller.Instance;
                marshaller.Marshall(requestObject.ValueCellStyle, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PivotTotalOptionsMarshaller Instance = new PivotTotalOptionsMarshaller();

    }
}