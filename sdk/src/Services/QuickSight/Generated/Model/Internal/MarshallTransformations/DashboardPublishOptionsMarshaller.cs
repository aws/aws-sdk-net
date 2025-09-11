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
    /// DashboardPublishOptions Marshaller
    /// </summary>
    public class DashboardPublishOptionsMarshaller : IRequestMarshaller<DashboardPublishOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DashboardPublishOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdHocFilteringOption())
            {
                context.Writer.WritePropertyName("AdHocFilteringOption");
                context.Writer.WriteStartObject();

                var marshaller = AdHocFilteringOptionMarshaller.Instance;
                marshaller.Marshall(requestObject.AdHocFilteringOption, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDataPointDrillUpDownOption())
            {
                context.Writer.WritePropertyName("DataPointDrillUpDownOption");
                context.Writer.WriteStartObject();

                var marshaller = DataPointDrillUpDownOptionMarshaller.Instance;
                marshaller.Marshall(requestObject.DataPointDrillUpDownOption, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDataPointMenuLabelOption())
            {
                context.Writer.WritePropertyName("DataPointMenuLabelOption");
                context.Writer.WriteStartObject();

                var marshaller = DataPointMenuLabelOptionMarshaller.Instance;
                marshaller.Marshall(requestObject.DataPointMenuLabelOption, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDataPointTooltipOption())
            {
                context.Writer.WritePropertyName("DataPointTooltipOption");
                context.Writer.WriteStartObject();

                var marshaller = DataPointTooltipOptionMarshaller.Instance;
                marshaller.Marshall(requestObject.DataPointTooltipOption, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDataQAEnabledOption())
            {
                context.Writer.WritePropertyName("DataQAEnabledOption");
                context.Writer.WriteStartObject();

                var marshaller = DataQAEnabledOptionMarshaller.Instance;
                marshaller.Marshall(requestObject.DataQAEnabledOption, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDataStoriesSharingOption())
            {
                context.Writer.WritePropertyName("DataStoriesSharingOption");
                context.Writer.WriteStartObject();

                var marshaller = DataStoriesSharingOptionMarshaller.Instance;
                marshaller.Marshall(requestObject.DataStoriesSharingOption, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetExecutiveSummaryOption())
            {
                context.Writer.WritePropertyName("ExecutiveSummaryOption");
                context.Writer.WriteStartObject();

                var marshaller = ExecutiveSummaryOptionMarshaller.Instance;
                marshaller.Marshall(requestObject.ExecutiveSummaryOption, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetExportToCSVOption())
            {
                context.Writer.WritePropertyName("ExportToCSVOption");
                context.Writer.WriteStartObject();

                var marshaller = ExportToCSVOptionMarshaller.Instance;
                marshaller.Marshall(requestObject.ExportToCSVOption, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetExportWithHiddenFieldsOption())
            {
                context.Writer.WritePropertyName("ExportWithHiddenFieldsOption");
                context.Writer.WriteStartObject();

                var marshaller = ExportWithHiddenFieldsOptionMarshaller.Instance;
                marshaller.Marshall(requestObject.ExportWithHiddenFieldsOption, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSheetControlsOption())
            {
                context.Writer.WritePropertyName("SheetControlsOption");
                context.Writer.WriteStartObject();

                var marshaller = SheetControlsOptionMarshaller.Instance;
                marshaller.Marshall(requestObject.SheetControlsOption, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSheetLayoutElementMaximizationOption())
            {
                context.Writer.WritePropertyName("SheetLayoutElementMaximizationOption");
                context.Writer.WriteStartObject();

                var marshaller = SheetLayoutElementMaximizationOptionMarshaller.Instance;
                marshaller.Marshall(requestObject.SheetLayoutElementMaximizationOption, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVisualAxisSortOption())
            {
                context.Writer.WritePropertyName("VisualAxisSortOption");
                context.Writer.WriteStartObject();

                var marshaller = VisualAxisSortOptionMarshaller.Instance;
                marshaller.Marshall(requestObject.VisualAxisSortOption, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVisualMenuOption())
            {
                context.Writer.WritePropertyName("VisualMenuOption");
                context.Writer.WriteStartObject();

                var marshaller = VisualMenuOptionMarshaller.Instance;
                marshaller.Marshall(requestObject.VisualMenuOption, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVisualPublishOptions())
            {
                context.Writer.WritePropertyName("VisualPublishOptions");
                context.Writer.WriteStartObject();

                var marshaller = DashboardVisualPublishOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.VisualPublishOptions, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DashboardPublishOptionsMarshaller Instance = new DashboardPublishOptionsMarshaller();

    }
}