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
    /// PivotTableOptions Marshaller
    /// </summary>
    public class PivotTableOptionsMarshaller : IRequestMarshaller<PivotTableOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PivotTableOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCellStyle())
            {
                context.Writer.WritePropertyName("CellStyle");
                context.Writer.WriteObjectStart();

                var marshaller = TableCellStyleMarshaller.Instance;
                marshaller.Marshall(requestObject.CellStyle, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCollapsedRowDimensionsVisibility())
            {
                context.Writer.WritePropertyName("CollapsedRowDimensionsVisibility");
                context.Writer.Write(requestObject.CollapsedRowDimensionsVisibility);
            }

            if(requestObject.IsSetColumnHeaderStyle())
            {
                context.Writer.WritePropertyName("ColumnHeaderStyle");
                context.Writer.WriteObjectStart();

                var marshaller = TableCellStyleMarshaller.Instance;
                marshaller.Marshall(requestObject.ColumnHeaderStyle, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetColumnNamesVisibility())
            {
                context.Writer.WritePropertyName("ColumnNamesVisibility");
                context.Writer.Write(requestObject.ColumnNamesVisibility);
            }

            if(requestObject.IsSetDefaultCellWidth())
            {
                context.Writer.WritePropertyName("DefaultCellWidth");
                context.Writer.Write(requestObject.DefaultCellWidth);
            }

            if(requestObject.IsSetMetricPlacement())
            {
                context.Writer.WritePropertyName("MetricPlacement");
                context.Writer.Write(requestObject.MetricPlacement);
            }

            if(requestObject.IsSetRowAlternateColorOptions())
            {
                context.Writer.WritePropertyName("RowAlternateColorOptions");
                context.Writer.WriteObjectStart();

                var marshaller = RowAlternateColorOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.RowAlternateColorOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRowFieldNamesStyle())
            {
                context.Writer.WritePropertyName("RowFieldNamesStyle");
                context.Writer.WriteObjectStart();

                var marshaller = TableCellStyleMarshaller.Instance;
                marshaller.Marshall(requestObject.RowFieldNamesStyle, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRowHeaderStyle())
            {
                context.Writer.WritePropertyName("RowHeaderStyle");
                context.Writer.WriteObjectStart();

                var marshaller = TableCellStyleMarshaller.Instance;
                marshaller.Marshall(requestObject.RowHeaderStyle, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRowsLabelOptions())
            {
                context.Writer.WritePropertyName("RowsLabelOptions");
                context.Writer.WriteObjectStart();

                var marshaller = PivotTableRowsLabelOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.RowsLabelOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRowsLayout())
            {
                context.Writer.WritePropertyName("RowsLayout");
                context.Writer.Write(requestObject.RowsLayout);
            }

            if(requestObject.IsSetSingleMetricVisibility())
            {
                context.Writer.WritePropertyName("SingleMetricVisibility");
                context.Writer.Write(requestObject.SingleMetricVisibility);
            }

            if(requestObject.IsSetToggleButtonsVisibility())
            {
                context.Writer.WritePropertyName("ToggleButtonsVisibility");
                context.Writer.Write(requestObject.ToggleButtonsVisibility);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PivotTableOptionsMarshaller Instance = new PivotTableOptionsMarshaller();

    }
}