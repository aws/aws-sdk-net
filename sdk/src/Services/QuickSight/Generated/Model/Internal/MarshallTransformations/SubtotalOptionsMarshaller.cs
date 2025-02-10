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
    /// SubtotalOptions Marshaller
    /// </summary>
    public class SubtotalOptionsMarshaller : IRequestMarshaller<SubtotalOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SubtotalOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCustomLabel())
            {
                context.Writer.WritePropertyName("CustomLabel");
                context.Writer.WriteStringValue(requestObject.CustomLabel);
            }

            if(requestObject.IsSetFieldLevel())
            {
                context.Writer.WritePropertyName("FieldLevel");
                context.Writer.WriteStringValue(requestObject.FieldLevel);
            }

            if(requestObject.IsSetFieldLevelOptions())
            {
                context.Writer.WritePropertyName("FieldLevelOptions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFieldLevelOptionsListValue in requestObject.FieldLevelOptions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PivotTableFieldSubtotalOptionsMarshaller.Instance;
                    marshaller.Marshall(requestObjectFieldLevelOptionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMetricHeaderCellStyle())
            {
                context.Writer.WritePropertyName("MetricHeaderCellStyle");
                context.Writer.WriteStartObject();

                var marshaller = TableCellStyleMarshaller.Instance;
                marshaller.Marshall(requestObject.MetricHeaderCellStyle, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStyleTargets())
            {
                context.Writer.WritePropertyName("StyleTargets");
                context.Writer.WriteStartArray();
                foreach(var requestObjectStyleTargetsListValue in requestObject.StyleTargets)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TableStyleTargetMarshaller.Instance;
                    marshaller.Marshall(requestObjectStyleTargetsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTotalCellStyle())
            {
                context.Writer.WritePropertyName("TotalCellStyle");
                context.Writer.WriteStartObject();

                var marshaller = TableCellStyleMarshaller.Instance;
                marshaller.Marshall(requestObject.TotalCellStyle, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTotalsVisibility())
            {
                context.Writer.WritePropertyName("TotalsVisibility");
                context.Writer.WriteStringValue(requestObject.TotalsVisibility);
            }

            if(requestObject.IsSetValueCellStyle())
            {
                context.Writer.WritePropertyName("ValueCellStyle");
                context.Writer.WriteStartObject();

                var marshaller = TableCellStyleMarshaller.Instance;
                marshaller.Marshall(requestObject.ValueCellStyle, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SubtotalOptionsMarshaller Instance = new SubtotalOptionsMarshaller();

    }
}