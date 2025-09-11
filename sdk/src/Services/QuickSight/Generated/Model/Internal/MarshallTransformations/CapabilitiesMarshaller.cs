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
    /// Capabilities Marshaller
    /// </summary>
    public class CapabilitiesMarshaller : IRequestMarshaller<Capabilities, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Capabilities requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAddOrRunAnomalyDetectionForAnalyses())
            {
                context.Writer.WritePropertyName("AddOrRunAnomalyDetectionForAnalyses");
                context.Writer.WriteStringValue(requestObject.AddOrRunAnomalyDetectionForAnalyses);
            }

            if(requestObject.IsSetAnalysis())
            {
                context.Writer.WritePropertyName("Analysis");
                context.Writer.WriteStringValue(requestObject.Analysis);
            }

            if(requestObject.IsSetCreateAndUpdateDashboardEmailReports())
            {
                context.Writer.WritePropertyName("CreateAndUpdateDashboardEmailReports");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateDashboardEmailReports);
            }

            if(requestObject.IsSetCreateAndUpdateDatasets())
            {
                context.Writer.WritePropertyName("CreateAndUpdateDatasets");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateDatasets);
            }

            if(requestObject.IsSetCreateAndUpdateDataSources())
            {
                context.Writer.WritePropertyName("CreateAndUpdateDataSources");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateDataSources);
            }

            if(requestObject.IsSetCreateAndUpdateThemes())
            {
                context.Writer.WritePropertyName("CreateAndUpdateThemes");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateThemes);
            }

            if(requestObject.IsSetCreateAndUpdateThresholdAlerts())
            {
                context.Writer.WritePropertyName("CreateAndUpdateThresholdAlerts");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateThresholdAlerts);
            }

            if(requestObject.IsSetCreateSharedFolders())
            {
                context.Writer.WritePropertyName("CreateSharedFolders");
                context.Writer.WriteStringValue(requestObject.CreateSharedFolders);
            }

            if(requestObject.IsSetCreateSPICEDataset())
            {
                context.Writer.WritePropertyName("CreateSPICEDataset");
                context.Writer.WriteStringValue(requestObject.CreateSPICEDataset);
            }

            if(requestObject.IsSetDashboard())
            {
                context.Writer.WritePropertyName("Dashboard");
                context.Writer.WriteStringValue(requestObject.Dashboard);
            }

            if(requestObject.IsSetExportToCsv())
            {
                context.Writer.WritePropertyName("ExportToCsv");
                context.Writer.WriteStringValue(requestObject.ExportToCsv);
            }

            if(requestObject.IsSetExportToCsvInScheduledReports())
            {
                context.Writer.WritePropertyName("ExportToCsvInScheduledReports");
                context.Writer.WriteStringValue(requestObject.ExportToCsvInScheduledReports);
            }

            if(requestObject.IsSetExportToExcel())
            {
                context.Writer.WritePropertyName("ExportToExcel");
                context.Writer.WriteStringValue(requestObject.ExportToExcel);
            }

            if(requestObject.IsSetExportToExcelInScheduledReports())
            {
                context.Writer.WritePropertyName("ExportToExcelInScheduledReports");
                context.Writer.WriteStringValue(requestObject.ExportToExcelInScheduledReports);
            }

            if(requestObject.IsSetExportToPdf())
            {
                context.Writer.WritePropertyName("ExportToPdf");
                context.Writer.WriteStringValue(requestObject.ExportToPdf);
            }

            if(requestObject.IsSetExportToPdfInScheduledReports())
            {
                context.Writer.WritePropertyName("ExportToPdfInScheduledReports");
                context.Writer.WriteStringValue(requestObject.ExportToPdfInScheduledReports);
            }

            if(requestObject.IsSetIncludeContentInScheduledReportsEmail())
            {
                context.Writer.WritePropertyName("IncludeContentInScheduledReportsEmail");
                context.Writer.WriteStringValue(requestObject.IncludeContentInScheduledReportsEmail);
            }

            if(requestObject.IsSetPrintReports())
            {
                context.Writer.WritePropertyName("PrintReports");
                context.Writer.WriteStringValue(requestObject.PrintReports);
            }

            if(requestObject.IsSetRenameSharedFolders())
            {
                context.Writer.WritePropertyName("RenameSharedFolders");
                context.Writer.WriteStringValue(requestObject.RenameSharedFolders);
            }

            if(requestObject.IsSetShareAnalyses())
            {
                context.Writer.WritePropertyName("ShareAnalyses");
                context.Writer.WriteStringValue(requestObject.ShareAnalyses);
            }

            if(requestObject.IsSetShareDashboards())
            {
                context.Writer.WritePropertyName("ShareDashboards");
                context.Writer.WriteStringValue(requestObject.ShareDashboards);
            }

            if(requestObject.IsSetShareDatasets())
            {
                context.Writer.WritePropertyName("ShareDatasets");
                context.Writer.WriteStringValue(requestObject.ShareDatasets);
            }

            if(requestObject.IsSetShareDataSources())
            {
                context.Writer.WritePropertyName("ShareDataSources");
                context.Writer.WriteStringValue(requestObject.ShareDataSources);
            }

            if(requestObject.IsSetSubscribeDashboardEmailReports())
            {
                context.Writer.WritePropertyName("SubscribeDashboardEmailReports");
                context.Writer.WriteStringValue(requestObject.SubscribeDashboardEmailReports);
            }

            if(requestObject.IsSetViewAccountSPICECapacity())
            {
                context.Writer.WritePropertyName("ViewAccountSPICECapacity");
                context.Writer.WriteStringValue(requestObject.ViewAccountSPICECapacity);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CapabilitiesMarshaller Instance = new CapabilitiesMarshaller();

    }
}