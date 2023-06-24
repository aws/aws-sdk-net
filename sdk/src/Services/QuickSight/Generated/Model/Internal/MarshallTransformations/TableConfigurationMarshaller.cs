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
    /// TableConfiguration Marshaller
    /// </summary>
    public class TableConfigurationMarshaller : IRequestMarshaller<TableConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TableConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetFieldOptions())
            {
                context.Writer.WritePropertyName("FieldOptions");
                context.Writer.WriteObjectStart();

                var marshaller = TableFieldOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.FieldOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFieldWells())
            {
                context.Writer.WritePropertyName("FieldWells");
                context.Writer.WriteObjectStart();

                var marshaller = TableFieldWellsMarshaller.Instance;
                marshaller.Marshall(requestObject.FieldWells, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPaginatedReportOptions())
            {
                context.Writer.WritePropertyName("PaginatedReportOptions");
                context.Writer.WriteObjectStart();

                var marshaller = TablePaginatedReportOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.PaginatedReportOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSortConfiguration())
            {
                context.Writer.WritePropertyName("SortConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = TableSortConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SortConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTableInlineVisualizations())
            {
                context.Writer.WritePropertyName("TableInlineVisualizations");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTableInlineVisualizationsListValue in requestObject.TableInlineVisualizations)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = TableInlineVisualizationMarshaller.Instance;
                    marshaller.Marshall(requestObjectTableInlineVisualizationsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTableOptions())
            {
                context.Writer.WritePropertyName("TableOptions");
                context.Writer.WriteObjectStart();

                var marshaller = TableOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.TableOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTotalOptions())
            {
                context.Writer.WritePropertyName("TotalOptions");
                context.Writer.WriteObjectStart();

                var marshaller = TotalOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.TotalOptions, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TableConfigurationMarshaller Instance = new TableConfigurationMarshaller();

    }
}