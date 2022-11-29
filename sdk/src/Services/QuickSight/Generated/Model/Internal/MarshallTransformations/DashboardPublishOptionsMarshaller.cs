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
            if(requestObject.IsSetAdHocFilteringOption())
            {
                context.Writer.WritePropertyName("AdHocFilteringOption");
                context.Writer.WriteObjectStart();

                var marshaller = AdHocFilteringOptionMarshaller.Instance;
                marshaller.Marshall(requestObject.AdHocFilteringOption, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetExportToCSVOption())
            {
                context.Writer.WritePropertyName("ExportToCSVOption");
                context.Writer.WriteObjectStart();

                var marshaller = ExportToCSVOptionMarshaller.Instance;
                marshaller.Marshall(requestObject.ExportToCSVOption, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSheetControlsOption())
            {
                context.Writer.WritePropertyName("SheetControlsOption");
                context.Writer.WriteObjectStart();

                var marshaller = SheetControlsOptionMarshaller.Instance;
                marshaller.Marshall(requestObject.SheetControlsOption, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVisualPublishOptions())
            {
                context.Writer.WritePropertyName("VisualPublishOptions");
                context.Writer.WriteObjectStart();

                var marshaller = DashboardVisualPublishOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.VisualPublishOptions, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DashboardPublishOptionsMarshaller Instance = new DashboardPublishOptionsMarshaller();

    }
}