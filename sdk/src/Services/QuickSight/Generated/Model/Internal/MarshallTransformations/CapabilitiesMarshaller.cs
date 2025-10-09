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
            if(requestObject.IsSetAction())
            {
                context.Writer.WritePropertyName("Action");
                context.Writer.Write(requestObject.Action);
            }

            if(requestObject.IsSetAddOrRunAnomalyDetectionForAnalyses())
            {
                context.Writer.WritePropertyName("AddOrRunAnomalyDetectionForAnalyses");
                context.Writer.Write(requestObject.AddOrRunAnomalyDetectionForAnalyses);
            }

            if(requestObject.IsSetAnalysis())
            {
                context.Writer.WritePropertyName("Analysis");
                context.Writer.Write(requestObject.Analysis);
            }

            if(requestObject.IsSetAutomate())
            {
                context.Writer.WritePropertyName("Automate");
                context.Writer.Write(requestObject.Automate);
            }

            if(requestObject.IsSetChatAgent())
            {
                context.Writer.WritePropertyName("ChatAgent");
                context.Writer.Write(requestObject.ChatAgent);
            }

            if(requestObject.IsSetCreateAndUpdateDashboardEmailReports())
            {
                context.Writer.WritePropertyName("CreateAndUpdateDashboardEmailReports");
                context.Writer.Write(requestObject.CreateAndUpdateDashboardEmailReports);
            }

            if(requestObject.IsSetCreateAndUpdateDatasets())
            {
                context.Writer.WritePropertyName("CreateAndUpdateDatasets");
                context.Writer.Write(requestObject.CreateAndUpdateDatasets);
            }

            if(requestObject.IsSetCreateAndUpdateDataSources())
            {
                context.Writer.WritePropertyName("CreateAndUpdateDataSources");
                context.Writer.Write(requestObject.CreateAndUpdateDataSources);
            }

            if(requestObject.IsSetCreateAndUpdateThemes())
            {
                context.Writer.WritePropertyName("CreateAndUpdateThemes");
                context.Writer.Write(requestObject.CreateAndUpdateThemes);
            }

            if(requestObject.IsSetCreateAndUpdateThresholdAlerts())
            {
                context.Writer.WritePropertyName("CreateAndUpdateThresholdAlerts");
                context.Writer.Write(requestObject.CreateAndUpdateThresholdAlerts);
            }

            if(requestObject.IsSetCreateChatAgents())
            {
                context.Writer.WritePropertyName("CreateChatAgents");
                context.Writer.Write(requestObject.CreateChatAgents);
            }

            if(requestObject.IsSetCreateSharedFolders())
            {
                context.Writer.WritePropertyName("CreateSharedFolders");
                context.Writer.Write(requestObject.CreateSharedFolders);
            }

            if(requestObject.IsSetCreateSPICEDataset())
            {
                context.Writer.WritePropertyName("CreateSPICEDataset");
                context.Writer.Write(requestObject.CreateSPICEDataset);
            }

            if(requestObject.IsSetDashboard())
            {
                context.Writer.WritePropertyName("Dashboard");
                context.Writer.Write(requestObject.Dashboard);
            }

            if(requestObject.IsSetExportToCsv())
            {
                context.Writer.WritePropertyName("ExportToCsv");
                context.Writer.Write(requestObject.ExportToCsv);
            }

            if(requestObject.IsSetExportToCsvInScheduledReports())
            {
                context.Writer.WritePropertyName("ExportToCsvInScheduledReports");
                context.Writer.Write(requestObject.ExportToCsvInScheduledReports);
            }

            if(requestObject.IsSetExportToExcel())
            {
                context.Writer.WritePropertyName("ExportToExcel");
                context.Writer.Write(requestObject.ExportToExcel);
            }

            if(requestObject.IsSetExportToExcelInScheduledReports())
            {
                context.Writer.WritePropertyName("ExportToExcelInScheduledReports");
                context.Writer.Write(requestObject.ExportToExcelInScheduledReports);
            }

            if(requestObject.IsSetExportToPdf())
            {
                context.Writer.WritePropertyName("ExportToPdf");
                context.Writer.Write(requestObject.ExportToPdf);
            }

            if(requestObject.IsSetExportToPdfInScheduledReports())
            {
                context.Writer.WritePropertyName("ExportToPdfInScheduledReports");
                context.Writer.Write(requestObject.ExportToPdfInScheduledReports);
            }

            if(requestObject.IsSetFlow())
            {
                context.Writer.WritePropertyName("Flow");
                context.Writer.Write(requestObject.Flow);
            }

            if(requestObject.IsSetIncludeContentInScheduledReportsEmail())
            {
                context.Writer.WritePropertyName("IncludeContentInScheduledReportsEmail");
                context.Writer.Write(requestObject.IncludeContentInScheduledReportsEmail);
            }

            if(requestObject.IsSetKnowledgeBase())
            {
                context.Writer.WritePropertyName("KnowledgeBase");
                context.Writer.Write(requestObject.KnowledgeBase);
            }

            if(requestObject.IsSetPerformFlowUiTask())
            {
                context.Writer.WritePropertyName("PerformFlowUiTask");
                context.Writer.Write(requestObject.PerformFlowUiTask);
            }

            if(requestObject.IsSetPrintReports())
            {
                context.Writer.WritePropertyName("PrintReports");
                context.Writer.Write(requestObject.PrintReports);
            }

            if(requestObject.IsSetPublishWithoutApproval())
            {
                context.Writer.WritePropertyName("PublishWithoutApproval");
                context.Writer.Write(requestObject.PublishWithoutApproval);
            }

            if(requestObject.IsSetRenameSharedFolders())
            {
                context.Writer.WritePropertyName("RenameSharedFolders");
                context.Writer.Write(requestObject.RenameSharedFolders);
            }

            if(requestObject.IsSetResearch())
            {
                context.Writer.WritePropertyName("Research");
                context.Writer.Write(requestObject.Research);
            }

            if(requestObject.IsSetShareAnalyses())
            {
                context.Writer.WritePropertyName("ShareAnalyses");
                context.Writer.Write(requestObject.ShareAnalyses);
            }

            if(requestObject.IsSetShareDashboards())
            {
                context.Writer.WritePropertyName("ShareDashboards");
                context.Writer.Write(requestObject.ShareDashboards);
            }

            if(requestObject.IsSetShareDatasets())
            {
                context.Writer.WritePropertyName("ShareDatasets");
                context.Writer.Write(requestObject.ShareDatasets);
            }

            if(requestObject.IsSetShareDataSources())
            {
                context.Writer.WritePropertyName("ShareDataSources");
                context.Writer.Write(requestObject.ShareDataSources);
            }

            if(requestObject.IsSetSpace())
            {
                context.Writer.WritePropertyName("Space");
                context.Writer.Write(requestObject.Space);
            }

            if(requestObject.IsSetSubscribeDashboardEmailReports())
            {
                context.Writer.WritePropertyName("SubscribeDashboardEmailReports");
                context.Writer.Write(requestObject.SubscribeDashboardEmailReports);
            }

            if(requestObject.IsSetUseAgentWebSearch())
            {
                context.Writer.WritePropertyName("UseAgentWebSearch");
                context.Writer.Write(requestObject.UseAgentWebSearch);
            }

            if(requestObject.IsSetUseBedrockModels())
            {
                context.Writer.WritePropertyName("UseBedrockModels");
                context.Writer.Write(requestObject.UseBedrockModels);
            }

            if(requestObject.IsSetViewAccountSPICECapacity())
            {
                context.Writer.WritePropertyName("ViewAccountSPICECapacity");
                context.Writer.Write(requestObject.ViewAccountSPICECapacity);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CapabilitiesMarshaller Instance = new CapabilitiesMarshaller();

    }
}