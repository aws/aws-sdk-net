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

            if(requestObject.IsSetAmazonBedrockARSAction())
            {
                context.Writer.WritePropertyName("AmazonBedrockARSAction");
                context.Writer.Write(requestObject.AmazonBedrockARSAction);
            }

            if(requestObject.IsSetAmazonBedrockFSAction())
            {
                context.Writer.WritePropertyName("AmazonBedrockFSAction");
                context.Writer.Write(requestObject.AmazonBedrockFSAction);
            }

            if(requestObject.IsSetAmazonBedrockKRSAction())
            {
                context.Writer.WritePropertyName("AmazonBedrockKRSAction");
                context.Writer.Write(requestObject.AmazonBedrockKRSAction);
            }

            if(requestObject.IsSetAmazonSThreeAction())
            {
                context.Writer.WritePropertyName("AmazonSThreeAction");
                context.Writer.Write(requestObject.AmazonSThreeAction);
            }

            if(requestObject.IsSetAnalysis())
            {
                context.Writer.WritePropertyName("Analysis");
                context.Writer.Write(requestObject.Analysis);
            }

            if(requestObject.IsSetAsanaAction())
            {
                context.Writer.WritePropertyName("AsanaAction");
                context.Writer.Write(requestObject.AsanaAction);
            }

            if(requestObject.IsSetAutomate())
            {
                context.Writer.WritePropertyName("Automate");
                context.Writer.Write(requestObject.Automate);
            }

            if(requestObject.IsSetBambooHRAction())
            {
                context.Writer.WritePropertyName("BambooHRAction");
                context.Writer.Write(requestObject.BambooHRAction);
            }

            if(requestObject.IsSetBoxAgentAction())
            {
                context.Writer.WritePropertyName("BoxAgentAction");
                context.Writer.Write(requestObject.BoxAgentAction);
            }

            if(requestObject.IsSetCanvaAgentAction())
            {
                context.Writer.WritePropertyName("CanvaAgentAction");
                context.Writer.Write(requestObject.CanvaAgentAction);
            }

            if(requestObject.IsSetChatAgent())
            {
                context.Writer.WritePropertyName("ChatAgent");
                context.Writer.Write(requestObject.ChatAgent);
            }

            if(requestObject.IsSetComprehendAction())
            {
                context.Writer.WritePropertyName("ComprehendAction");
                context.Writer.Write(requestObject.ComprehendAction);
            }

            if(requestObject.IsSetComprehendMedicalAction())
            {
                context.Writer.WritePropertyName("ComprehendMedicalAction");
                context.Writer.Write(requestObject.ComprehendMedicalAction);
            }

            if(requestObject.IsSetConfluenceAction())
            {
                context.Writer.WritePropertyName("ConfluenceAction");
                context.Writer.Write(requestObject.ConfluenceAction);
            }

            if(requestObject.IsSetCreateAndUpdateAmazonBedrockARSAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateAmazonBedrockARSAction");
                context.Writer.Write(requestObject.CreateAndUpdateAmazonBedrockARSAction);
            }

            if(requestObject.IsSetCreateAndUpdateAmazonBedrockFSAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateAmazonBedrockFSAction");
                context.Writer.Write(requestObject.CreateAndUpdateAmazonBedrockFSAction);
            }

            if(requestObject.IsSetCreateAndUpdateAmazonBedrockKRSAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateAmazonBedrockKRSAction");
                context.Writer.Write(requestObject.CreateAndUpdateAmazonBedrockKRSAction);
            }

            if(requestObject.IsSetCreateAndUpdateAmazonSThreeAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateAmazonSThreeAction");
                context.Writer.Write(requestObject.CreateAndUpdateAmazonSThreeAction);
            }

            if(requestObject.IsSetCreateAndUpdateAsanaAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateAsanaAction");
                context.Writer.Write(requestObject.CreateAndUpdateAsanaAction);
            }

            if(requestObject.IsSetCreateAndUpdateBambooHRAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateBambooHRAction");
                context.Writer.Write(requestObject.CreateAndUpdateBambooHRAction);
            }

            if(requestObject.IsSetCreateAndUpdateBoxAgentAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateBoxAgentAction");
                context.Writer.Write(requestObject.CreateAndUpdateBoxAgentAction);
            }

            if(requestObject.IsSetCreateAndUpdateCanvaAgentAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateCanvaAgentAction");
                context.Writer.Write(requestObject.CreateAndUpdateCanvaAgentAction);
            }

            if(requestObject.IsSetCreateAndUpdateComprehendAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateComprehendAction");
                context.Writer.Write(requestObject.CreateAndUpdateComprehendAction);
            }

            if(requestObject.IsSetCreateAndUpdateComprehendMedicalAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateComprehendMedicalAction");
                context.Writer.Write(requestObject.CreateAndUpdateComprehendMedicalAction);
            }

            if(requestObject.IsSetCreateAndUpdateConfluenceAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateConfluenceAction");
                context.Writer.Write(requestObject.CreateAndUpdateConfluenceAction);
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

            if(requestObject.IsSetCreateAndUpdateFactSetAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateFactSetAction");
                context.Writer.Write(requestObject.CreateAndUpdateFactSetAction);
            }

            if(requestObject.IsSetCreateAndUpdateGenericHTTPAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateGenericHTTPAction");
                context.Writer.Write(requestObject.CreateAndUpdateGenericHTTPAction);
            }

            if(requestObject.IsSetCreateAndUpdateGithubAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateGithubAction");
                context.Writer.Write(requestObject.CreateAndUpdateGithubAction);
            }

            if(requestObject.IsSetCreateAndUpdateGoogleCalendarAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateGoogleCalendarAction");
                context.Writer.Write(requestObject.CreateAndUpdateGoogleCalendarAction);
            }

            if(requestObject.IsSetCreateAndUpdateHubspotAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateHubspotAction");
                context.Writer.Write(requestObject.CreateAndUpdateHubspotAction);
            }

            if(requestObject.IsSetCreateAndUpdateHuggingFaceAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateHuggingFaceAction");
                context.Writer.Write(requestObject.CreateAndUpdateHuggingFaceAction);
            }

            if(requestObject.IsSetCreateAndUpdateIntercomAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateIntercomAction");
                context.Writer.Write(requestObject.CreateAndUpdateIntercomAction);
            }

            if(requestObject.IsSetCreateAndUpdateJiraAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateJiraAction");
                context.Writer.Write(requestObject.CreateAndUpdateJiraAction);
            }

            if(requestObject.IsSetCreateAndUpdateLinearAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateLinearAction");
                context.Writer.Write(requestObject.CreateAndUpdateLinearAction);
            }

            if(requestObject.IsSetCreateAndUpdateMCPAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateMCPAction");
                context.Writer.Write(requestObject.CreateAndUpdateMCPAction);
            }

            if(requestObject.IsSetCreateAndUpdateMondayAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateMondayAction");
                context.Writer.Write(requestObject.CreateAndUpdateMondayAction);
            }

            if(requestObject.IsSetCreateAndUpdateMSExchangeAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateMSExchangeAction");
                context.Writer.Write(requestObject.CreateAndUpdateMSExchangeAction);
            }

            if(requestObject.IsSetCreateAndUpdateMSTeamsAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateMSTeamsAction");
                context.Writer.Write(requestObject.CreateAndUpdateMSTeamsAction);
            }

            if(requestObject.IsSetCreateAndUpdateNewRelicAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateNewRelicAction");
                context.Writer.Write(requestObject.CreateAndUpdateNewRelicAction);
            }

            if(requestObject.IsSetCreateAndUpdateNotionAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateNotionAction");
                context.Writer.Write(requestObject.CreateAndUpdateNotionAction);
            }

            if(requestObject.IsSetCreateAndUpdateOneDriveAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateOneDriveAction");
                context.Writer.Write(requestObject.CreateAndUpdateOneDriveAction);
            }

            if(requestObject.IsSetCreateAndUpdateOpenAPIAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateOpenAPIAction");
                context.Writer.Write(requestObject.CreateAndUpdateOpenAPIAction);
            }

            if(requestObject.IsSetCreateAndUpdatePagerDutyAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdatePagerDutyAction");
                context.Writer.Write(requestObject.CreateAndUpdatePagerDutyAction);
            }

            if(requestObject.IsSetCreateAndUpdateSalesforceAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateSalesforceAction");
                context.Writer.Write(requestObject.CreateAndUpdateSalesforceAction);
            }

            if(requestObject.IsSetCreateAndUpdateSandPGlobalEnergyAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateSandPGlobalEnergyAction");
                context.Writer.Write(requestObject.CreateAndUpdateSandPGlobalEnergyAction);
            }

            if(requestObject.IsSetCreateAndUpdateSandPGMIAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateSandPGMIAction");
                context.Writer.Write(requestObject.CreateAndUpdateSandPGMIAction);
            }

            if(requestObject.IsSetCreateAndUpdateSAPBillOfMaterialAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateSAPBillOfMaterialAction");
                context.Writer.Write(requestObject.CreateAndUpdateSAPBillOfMaterialAction);
            }

            if(requestObject.IsSetCreateAndUpdateSAPBusinessPartnerAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateSAPBusinessPartnerAction");
                context.Writer.Write(requestObject.CreateAndUpdateSAPBusinessPartnerAction);
            }

            if(requestObject.IsSetCreateAndUpdateSAPMaterialStockAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateSAPMaterialStockAction");
                context.Writer.Write(requestObject.CreateAndUpdateSAPMaterialStockAction);
            }

            if(requestObject.IsSetCreateAndUpdateSAPPhysicalInventoryAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateSAPPhysicalInventoryAction");
                context.Writer.Write(requestObject.CreateAndUpdateSAPPhysicalInventoryAction);
            }

            if(requestObject.IsSetCreateAndUpdateSAPProductMasterDataAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateSAPProductMasterDataAction");
                context.Writer.Write(requestObject.CreateAndUpdateSAPProductMasterDataAction);
            }

            if(requestObject.IsSetCreateAndUpdateServiceNowAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateServiceNowAction");
                context.Writer.Write(requestObject.CreateAndUpdateServiceNowAction);
            }

            if(requestObject.IsSetCreateAndUpdateSharePointAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateSharePointAction");
                context.Writer.Write(requestObject.CreateAndUpdateSharePointAction);
            }

            if(requestObject.IsSetCreateAndUpdateSlackAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateSlackAction");
                context.Writer.Write(requestObject.CreateAndUpdateSlackAction);
            }

            if(requestObject.IsSetCreateAndUpdateSmartsheetAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateSmartsheetAction");
                context.Writer.Write(requestObject.CreateAndUpdateSmartsheetAction);
            }

            if(requestObject.IsSetCreateAndUpdateTextractAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateTextractAction");
                context.Writer.Write(requestObject.CreateAndUpdateTextractAction);
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

            if(requestObject.IsSetCreateAndUpdateZendeskAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateZendeskAction");
                context.Writer.Write(requestObject.CreateAndUpdateZendeskAction);
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

            if(requestObject.IsSetFactSetAction())
            {
                context.Writer.WritePropertyName("FactSetAction");
                context.Writer.Write(requestObject.FactSetAction);
            }

            if(requestObject.IsSetFlow())
            {
                context.Writer.WritePropertyName("Flow");
                context.Writer.Write(requestObject.Flow);
            }

            if(requestObject.IsSetGenericHTTPAction())
            {
                context.Writer.WritePropertyName("GenericHTTPAction");
                context.Writer.Write(requestObject.GenericHTTPAction);
            }

            if(requestObject.IsSetGithubAction())
            {
                context.Writer.WritePropertyName("GithubAction");
                context.Writer.Write(requestObject.GithubAction);
            }

            if(requestObject.IsSetGoogleCalendarAction())
            {
                context.Writer.WritePropertyName("GoogleCalendarAction");
                context.Writer.Write(requestObject.GoogleCalendarAction);
            }

            if(requestObject.IsSetHubspotAction())
            {
                context.Writer.WritePropertyName("HubspotAction");
                context.Writer.Write(requestObject.HubspotAction);
            }

            if(requestObject.IsSetHuggingFaceAction())
            {
                context.Writer.WritePropertyName("HuggingFaceAction");
                context.Writer.Write(requestObject.HuggingFaceAction);
            }

            if(requestObject.IsSetIncludeContentInScheduledReportsEmail())
            {
                context.Writer.WritePropertyName("IncludeContentInScheduledReportsEmail");
                context.Writer.Write(requestObject.IncludeContentInScheduledReportsEmail);
            }

            if(requestObject.IsSetIntercomAction())
            {
                context.Writer.WritePropertyName("IntercomAction");
                context.Writer.Write(requestObject.IntercomAction);
            }

            if(requestObject.IsSetJiraAction())
            {
                context.Writer.WritePropertyName("JiraAction");
                context.Writer.Write(requestObject.JiraAction);
            }

            if(requestObject.IsSetKnowledgeBase())
            {
                context.Writer.WritePropertyName("KnowledgeBase");
                context.Writer.Write(requestObject.KnowledgeBase);
            }

            if(requestObject.IsSetLinearAction())
            {
                context.Writer.WritePropertyName("LinearAction");
                context.Writer.Write(requestObject.LinearAction);
            }

            if(requestObject.IsSetMCPAction())
            {
                context.Writer.WritePropertyName("MCPAction");
                context.Writer.Write(requestObject.MCPAction);
            }

            if(requestObject.IsSetMondayAction())
            {
                context.Writer.WritePropertyName("MondayAction");
                context.Writer.Write(requestObject.MondayAction);
            }

            if(requestObject.IsSetMSExchangeAction())
            {
                context.Writer.WritePropertyName("MSExchangeAction");
                context.Writer.Write(requestObject.MSExchangeAction);
            }

            if(requestObject.IsSetMSTeamsAction())
            {
                context.Writer.WritePropertyName("MSTeamsAction");
                context.Writer.Write(requestObject.MSTeamsAction);
            }

            if(requestObject.IsSetNewRelicAction())
            {
                context.Writer.WritePropertyName("NewRelicAction");
                context.Writer.Write(requestObject.NewRelicAction);
            }

            if(requestObject.IsSetNotionAction())
            {
                context.Writer.WritePropertyName("NotionAction");
                context.Writer.Write(requestObject.NotionAction);
            }

            if(requestObject.IsSetOneDriveAction())
            {
                context.Writer.WritePropertyName("OneDriveAction");
                context.Writer.Write(requestObject.OneDriveAction);
            }

            if(requestObject.IsSetOpenAPIAction())
            {
                context.Writer.WritePropertyName("OpenAPIAction");
                context.Writer.Write(requestObject.OpenAPIAction);
            }

            if(requestObject.IsSetPagerDutyAction())
            {
                context.Writer.WritePropertyName("PagerDutyAction");
                context.Writer.Write(requestObject.PagerDutyAction);
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

            if(requestObject.IsSetSalesforceAction())
            {
                context.Writer.WritePropertyName("SalesforceAction");
                context.Writer.Write(requestObject.SalesforceAction);
            }

            if(requestObject.IsSetSandPGlobalEnergyAction())
            {
                context.Writer.WritePropertyName("SandPGlobalEnergyAction");
                context.Writer.Write(requestObject.SandPGlobalEnergyAction);
            }

            if(requestObject.IsSetSandPGMIAction())
            {
                context.Writer.WritePropertyName("SandPGMIAction");
                context.Writer.Write(requestObject.SandPGMIAction);
            }

            if(requestObject.IsSetSAPBillOfMaterialAction())
            {
                context.Writer.WritePropertyName("SAPBillOfMaterialAction");
                context.Writer.Write(requestObject.SAPBillOfMaterialAction);
            }

            if(requestObject.IsSetSAPBusinessPartnerAction())
            {
                context.Writer.WritePropertyName("SAPBusinessPartnerAction");
                context.Writer.Write(requestObject.SAPBusinessPartnerAction);
            }

            if(requestObject.IsSetSAPMaterialStockAction())
            {
                context.Writer.WritePropertyName("SAPMaterialStockAction");
                context.Writer.Write(requestObject.SAPMaterialStockAction);
            }

            if(requestObject.IsSetSAPPhysicalInventoryAction())
            {
                context.Writer.WritePropertyName("SAPPhysicalInventoryAction");
                context.Writer.Write(requestObject.SAPPhysicalInventoryAction);
            }

            if(requestObject.IsSetSAPProductMasterDataAction())
            {
                context.Writer.WritePropertyName("SAPProductMasterDataAction");
                context.Writer.Write(requestObject.SAPProductMasterDataAction);
            }

            if(requestObject.IsSetSelfUpgradeUserRole())
            {
                context.Writer.WritePropertyName("SelfUpgradeUserRole");
                context.Writer.Write(requestObject.SelfUpgradeUserRole);
            }

            if(requestObject.IsSetServiceNowAction())
            {
                context.Writer.WritePropertyName("ServiceNowAction");
                context.Writer.Write(requestObject.ServiceNowAction);
            }

            if(requestObject.IsSetShareAmazonBedrockARSAction())
            {
                context.Writer.WritePropertyName("ShareAmazonBedrockARSAction");
                context.Writer.Write(requestObject.ShareAmazonBedrockARSAction);
            }

            if(requestObject.IsSetShareAmazonBedrockFSAction())
            {
                context.Writer.WritePropertyName("ShareAmazonBedrockFSAction");
                context.Writer.Write(requestObject.ShareAmazonBedrockFSAction);
            }

            if(requestObject.IsSetShareAmazonBedrockKRSAction())
            {
                context.Writer.WritePropertyName("ShareAmazonBedrockKRSAction");
                context.Writer.Write(requestObject.ShareAmazonBedrockKRSAction);
            }

            if(requestObject.IsSetShareAmazonSThreeAction())
            {
                context.Writer.WritePropertyName("ShareAmazonSThreeAction");
                context.Writer.Write(requestObject.ShareAmazonSThreeAction);
            }

            if(requestObject.IsSetShareAnalyses())
            {
                context.Writer.WritePropertyName("ShareAnalyses");
                context.Writer.Write(requestObject.ShareAnalyses);
            }

            if(requestObject.IsSetShareAsanaAction())
            {
                context.Writer.WritePropertyName("ShareAsanaAction");
                context.Writer.Write(requestObject.ShareAsanaAction);
            }

            if(requestObject.IsSetShareBambooHRAction())
            {
                context.Writer.WritePropertyName("ShareBambooHRAction");
                context.Writer.Write(requestObject.ShareBambooHRAction);
            }

            if(requestObject.IsSetShareBoxAgentAction())
            {
                context.Writer.WritePropertyName("ShareBoxAgentAction");
                context.Writer.Write(requestObject.ShareBoxAgentAction);
            }

            if(requestObject.IsSetShareCanvaAgentAction())
            {
                context.Writer.WritePropertyName("ShareCanvaAgentAction");
                context.Writer.Write(requestObject.ShareCanvaAgentAction);
            }

            if(requestObject.IsSetShareComprehendAction())
            {
                context.Writer.WritePropertyName("ShareComprehendAction");
                context.Writer.Write(requestObject.ShareComprehendAction);
            }

            if(requestObject.IsSetShareComprehendMedicalAction())
            {
                context.Writer.WritePropertyName("ShareComprehendMedicalAction");
                context.Writer.Write(requestObject.ShareComprehendMedicalAction);
            }

            if(requestObject.IsSetShareConfluenceAction())
            {
                context.Writer.WritePropertyName("ShareConfluenceAction");
                context.Writer.Write(requestObject.ShareConfluenceAction);
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

            if(requestObject.IsSetShareFactSetAction())
            {
                context.Writer.WritePropertyName("ShareFactSetAction");
                context.Writer.Write(requestObject.ShareFactSetAction);
            }

            if(requestObject.IsSetShareGenericHTTPAction())
            {
                context.Writer.WritePropertyName("ShareGenericHTTPAction");
                context.Writer.Write(requestObject.ShareGenericHTTPAction);
            }

            if(requestObject.IsSetShareGithubAction())
            {
                context.Writer.WritePropertyName("ShareGithubAction");
                context.Writer.Write(requestObject.ShareGithubAction);
            }

            if(requestObject.IsSetShareGoogleCalendarAction())
            {
                context.Writer.WritePropertyName("ShareGoogleCalendarAction");
                context.Writer.Write(requestObject.ShareGoogleCalendarAction);
            }

            if(requestObject.IsSetShareHubspotAction())
            {
                context.Writer.WritePropertyName("ShareHubspotAction");
                context.Writer.Write(requestObject.ShareHubspotAction);
            }

            if(requestObject.IsSetShareHuggingFaceAction())
            {
                context.Writer.WritePropertyName("ShareHuggingFaceAction");
                context.Writer.Write(requestObject.ShareHuggingFaceAction);
            }

            if(requestObject.IsSetShareIntercomAction())
            {
                context.Writer.WritePropertyName("ShareIntercomAction");
                context.Writer.Write(requestObject.ShareIntercomAction);
            }

            if(requestObject.IsSetShareJiraAction())
            {
                context.Writer.WritePropertyName("ShareJiraAction");
                context.Writer.Write(requestObject.ShareJiraAction);
            }

            if(requestObject.IsSetShareLinearAction())
            {
                context.Writer.WritePropertyName("ShareLinearAction");
                context.Writer.Write(requestObject.ShareLinearAction);
            }

            if(requestObject.IsSetShareMCPAction())
            {
                context.Writer.WritePropertyName("ShareMCPAction");
                context.Writer.Write(requestObject.ShareMCPAction);
            }

            if(requestObject.IsSetShareMondayAction())
            {
                context.Writer.WritePropertyName("ShareMondayAction");
                context.Writer.Write(requestObject.ShareMondayAction);
            }

            if(requestObject.IsSetShareMSExchangeAction())
            {
                context.Writer.WritePropertyName("ShareMSExchangeAction");
                context.Writer.Write(requestObject.ShareMSExchangeAction);
            }

            if(requestObject.IsSetShareMSTeamsAction())
            {
                context.Writer.WritePropertyName("ShareMSTeamsAction");
                context.Writer.Write(requestObject.ShareMSTeamsAction);
            }

            if(requestObject.IsSetShareNewRelicAction())
            {
                context.Writer.WritePropertyName("ShareNewRelicAction");
                context.Writer.Write(requestObject.ShareNewRelicAction);
            }

            if(requestObject.IsSetShareNotionAction())
            {
                context.Writer.WritePropertyName("ShareNotionAction");
                context.Writer.Write(requestObject.ShareNotionAction);
            }

            if(requestObject.IsSetShareOneDriveAction())
            {
                context.Writer.WritePropertyName("ShareOneDriveAction");
                context.Writer.Write(requestObject.ShareOneDriveAction);
            }

            if(requestObject.IsSetShareOpenAPIAction())
            {
                context.Writer.WritePropertyName("ShareOpenAPIAction");
                context.Writer.Write(requestObject.ShareOpenAPIAction);
            }

            if(requestObject.IsSetSharePagerDutyAction())
            {
                context.Writer.WritePropertyName("SharePagerDutyAction");
                context.Writer.Write(requestObject.SharePagerDutyAction);
            }

            if(requestObject.IsSetSharePointAction())
            {
                context.Writer.WritePropertyName("SharePointAction");
                context.Writer.Write(requestObject.SharePointAction);
            }

            if(requestObject.IsSetShareSalesforceAction())
            {
                context.Writer.WritePropertyName("ShareSalesforceAction");
                context.Writer.Write(requestObject.ShareSalesforceAction);
            }

            if(requestObject.IsSetShareSandPGlobalEnergyAction())
            {
                context.Writer.WritePropertyName("ShareSandPGlobalEnergyAction");
                context.Writer.Write(requestObject.ShareSandPGlobalEnergyAction);
            }

            if(requestObject.IsSetShareSandPGMIAction())
            {
                context.Writer.WritePropertyName("ShareSandPGMIAction");
                context.Writer.Write(requestObject.ShareSandPGMIAction);
            }

            if(requestObject.IsSetShareSAPBillOfMaterialAction())
            {
                context.Writer.WritePropertyName("ShareSAPBillOfMaterialAction");
                context.Writer.Write(requestObject.ShareSAPBillOfMaterialAction);
            }

            if(requestObject.IsSetShareSAPBusinessPartnerAction())
            {
                context.Writer.WritePropertyName("ShareSAPBusinessPartnerAction");
                context.Writer.Write(requestObject.ShareSAPBusinessPartnerAction);
            }

            if(requestObject.IsSetShareSAPMaterialStockAction())
            {
                context.Writer.WritePropertyName("ShareSAPMaterialStockAction");
                context.Writer.Write(requestObject.ShareSAPMaterialStockAction);
            }

            if(requestObject.IsSetShareSAPPhysicalInventoryAction())
            {
                context.Writer.WritePropertyName("ShareSAPPhysicalInventoryAction");
                context.Writer.Write(requestObject.ShareSAPPhysicalInventoryAction);
            }

            if(requestObject.IsSetShareSAPProductMasterDataAction())
            {
                context.Writer.WritePropertyName("ShareSAPProductMasterDataAction");
                context.Writer.Write(requestObject.ShareSAPProductMasterDataAction);
            }

            if(requestObject.IsSetShareServiceNowAction())
            {
                context.Writer.WritePropertyName("ShareServiceNowAction");
                context.Writer.Write(requestObject.ShareServiceNowAction);
            }

            if(requestObject.IsSetShareSharePointAction())
            {
                context.Writer.WritePropertyName("ShareSharePointAction");
                context.Writer.Write(requestObject.ShareSharePointAction);
            }

            if(requestObject.IsSetShareSlackAction())
            {
                context.Writer.WritePropertyName("ShareSlackAction");
                context.Writer.Write(requestObject.ShareSlackAction);
            }

            if(requestObject.IsSetShareSmartsheetAction())
            {
                context.Writer.WritePropertyName("ShareSmartsheetAction");
                context.Writer.Write(requestObject.ShareSmartsheetAction);
            }

            if(requestObject.IsSetShareTextractAction())
            {
                context.Writer.WritePropertyName("ShareTextractAction");
                context.Writer.Write(requestObject.ShareTextractAction);
            }

            if(requestObject.IsSetShareZendeskAction())
            {
                context.Writer.WritePropertyName("ShareZendeskAction");
                context.Writer.Write(requestObject.ShareZendeskAction);
            }

            if(requestObject.IsSetSlackAction())
            {
                context.Writer.WritePropertyName("SlackAction");
                context.Writer.Write(requestObject.SlackAction);
            }

            if(requestObject.IsSetSmartsheetAction())
            {
                context.Writer.WritePropertyName("SmartsheetAction");
                context.Writer.Write(requestObject.SmartsheetAction);
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

            if(requestObject.IsSetTextractAction())
            {
                context.Writer.WritePropertyName("TextractAction");
                context.Writer.Write(requestObject.TextractAction);
            }

            if(requestObject.IsSetUseAgentWebSearch())
            {
                context.Writer.WritePropertyName("UseAgentWebSearch");
                context.Writer.Write(requestObject.UseAgentWebSearch);
            }

            if(requestObject.IsSetUseAmazonBedrockARSAction())
            {
                context.Writer.WritePropertyName("UseAmazonBedrockARSAction");
                context.Writer.Write(requestObject.UseAmazonBedrockARSAction);
            }

            if(requestObject.IsSetUseAmazonBedrockFSAction())
            {
                context.Writer.WritePropertyName("UseAmazonBedrockFSAction");
                context.Writer.Write(requestObject.UseAmazonBedrockFSAction);
            }

            if(requestObject.IsSetUseAmazonBedrockKRSAction())
            {
                context.Writer.WritePropertyName("UseAmazonBedrockKRSAction");
                context.Writer.Write(requestObject.UseAmazonBedrockKRSAction);
            }

            if(requestObject.IsSetUseAmazonSThreeAction())
            {
                context.Writer.WritePropertyName("UseAmazonSThreeAction");
                context.Writer.Write(requestObject.UseAmazonSThreeAction);
            }

            if(requestObject.IsSetUseAsanaAction())
            {
                context.Writer.WritePropertyName("UseAsanaAction");
                context.Writer.Write(requestObject.UseAsanaAction);
            }

            if(requestObject.IsSetUseBambooHRAction())
            {
                context.Writer.WritePropertyName("UseBambooHRAction");
                context.Writer.Write(requestObject.UseBambooHRAction);
            }

            if(requestObject.IsSetUseBedrockModels())
            {
                context.Writer.WritePropertyName("UseBedrockModels");
                context.Writer.Write(requestObject.UseBedrockModels);
            }

            if(requestObject.IsSetUseBoxAgentAction())
            {
                context.Writer.WritePropertyName("UseBoxAgentAction");
                context.Writer.Write(requestObject.UseBoxAgentAction);
            }

            if(requestObject.IsSetUseCanvaAgentAction())
            {
                context.Writer.WritePropertyName("UseCanvaAgentAction");
                context.Writer.Write(requestObject.UseCanvaAgentAction);
            }

            if(requestObject.IsSetUseComprehendAction())
            {
                context.Writer.WritePropertyName("UseComprehendAction");
                context.Writer.Write(requestObject.UseComprehendAction);
            }

            if(requestObject.IsSetUseComprehendMedicalAction())
            {
                context.Writer.WritePropertyName("UseComprehendMedicalAction");
                context.Writer.Write(requestObject.UseComprehendMedicalAction);
            }

            if(requestObject.IsSetUseConfluenceAction())
            {
                context.Writer.WritePropertyName("UseConfluenceAction");
                context.Writer.Write(requestObject.UseConfluenceAction);
            }

            if(requestObject.IsSetUseFactSetAction())
            {
                context.Writer.WritePropertyName("UseFactSetAction");
                context.Writer.Write(requestObject.UseFactSetAction);
            }

            if(requestObject.IsSetUseGenericHTTPAction())
            {
                context.Writer.WritePropertyName("UseGenericHTTPAction");
                context.Writer.Write(requestObject.UseGenericHTTPAction);
            }

            if(requestObject.IsSetUseGithubAction())
            {
                context.Writer.WritePropertyName("UseGithubAction");
                context.Writer.Write(requestObject.UseGithubAction);
            }

            if(requestObject.IsSetUseGoogleCalendarAction())
            {
                context.Writer.WritePropertyName("UseGoogleCalendarAction");
                context.Writer.Write(requestObject.UseGoogleCalendarAction);
            }

            if(requestObject.IsSetUseHubspotAction())
            {
                context.Writer.WritePropertyName("UseHubspotAction");
                context.Writer.Write(requestObject.UseHubspotAction);
            }

            if(requestObject.IsSetUseHuggingFaceAction())
            {
                context.Writer.WritePropertyName("UseHuggingFaceAction");
                context.Writer.Write(requestObject.UseHuggingFaceAction);
            }

            if(requestObject.IsSetUseIntercomAction())
            {
                context.Writer.WritePropertyName("UseIntercomAction");
                context.Writer.Write(requestObject.UseIntercomAction);
            }

            if(requestObject.IsSetUseJiraAction())
            {
                context.Writer.WritePropertyName("UseJiraAction");
                context.Writer.Write(requestObject.UseJiraAction);
            }

            if(requestObject.IsSetUseLinearAction())
            {
                context.Writer.WritePropertyName("UseLinearAction");
                context.Writer.Write(requestObject.UseLinearAction);
            }

            if(requestObject.IsSetUseMCPAction())
            {
                context.Writer.WritePropertyName("UseMCPAction");
                context.Writer.Write(requestObject.UseMCPAction);
            }

            if(requestObject.IsSetUseMondayAction())
            {
                context.Writer.WritePropertyName("UseMondayAction");
                context.Writer.Write(requestObject.UseMondayAction);
            }

            if(requestObject.IsSetUseMSExchangeAction())
            {
                context.Writer.WritePropertyName("UseMSExchangeAction");
                context.Writer.Write(requestObject.UseMSExchangeAction);
            }

            if(requestObject.IsSetUseMSTeamsAction())
            {
                context.Writer.WritePropertyName("UseMSTeamsAction");
                context.Writer.Write(requestObject.UseMSTeamsAction);
            }

            if(requestObject.IsSetUseNewRelicAction())
            {
                context.Writer.WritePropertyName("UseNewRelicAction");
                context.Writer.Write(requestObject.UseNewRelicAction);
            }

            if(requestObject.IsSetUseNotionAction())
            {
                context.Writer.WritePropertyName("UseNotionAction");
                context.Writer.Write(requestObject.UseNotionAction);
            }

            if(requestObject.IsSetUseOneDriveAction())
            {
                context.Writer.WritePropertyName("UseOneDriveAction");
                context.Writer.Write(requestObject.UseOneDriveAction);
            }

            if(requestObject.IsSetUseOpenAPIAction())
            {
                context.Writer.WritePropertyName("UseOpenAPIAction");
                context.Writer.Write(requestObject.UseOpenAPIAction);
            }

            if(requestObject.IsSetUsePagerDutyAction())
            {
                context.Writer.WritePropertyName("UsePagerDutyAction");
                context.Writer.Write(requestObject.UsePagerDutyAction);
            }

            if(requestObject.IsSetUseSalesforceAction())
            {
                context.Writer.WritePropertyName("UseSalesforceAction");
                context.Writer.Write(requestObject.UseSalesforceAction);
            }

            if(requestObject.IsSetUseSandPGlobalEnergyAction())
            {
                context.Writer.WritePropertyName("UseSandPGlobalEnergyAction");
                context.Writer.Write(requestObject.UseSandPGlobalEnergyAction);
            }

            if(requestObject.IsSetUseSandPGMIAction())
            {
                context.Writer.WritePropertyName("UseSandPGMIAction");
                context.Writer.Write(requestObject.UseSandPGMIAction);
            }

            if(requestObject.IsSetUseSAPBillOfMaterialAction())
            {
                context.Writer.WritePropertyName("UseSAPBillOfMaterialAction");
                context.Writer.Write(requestObject.UseSAPBillOfMaterialAction);
            }

            if(requestObject.IsSetUseSAPBusinessPartnerAction())
            {
                context.Writer.WritePropertyName("UseSAPBusinessPartnerAction");
                context.Writer.Write(requestObject.UseSAPBusinessPartnerAction);
            }

            if(requestObject.IsSetUseSAPMaterialStockAction())
            {
                context.Writer.WritePropertyName("UseSAPMaterialStockAction");
                context.Writer.Write(requestObject.UseSAPMaterialStockAction);
            }

            if(requestObject.IsSetUseSAPPhysicalInventoryAction())
            {
                context.Writer.WritePropertyName("UseSAPPhysicalInventoryAction");
                context.Writer.Write(requestObject.UseSAPPhysicalInventoryAction);
            }

            if(requestObject.IsSetUseSAPProductMasterDataAction())
            {
                context.Writer.WritePropertyName("UseSAPProductMasterDataAction");
                context.Writer.Write(requestObject.UseSAPProductMasterDataAction);
            }

            if(requestObject.IsSetUseServiceNowAction())
            {
                context.Writer.WritePropertyName("UseServiceNowAction");
                context.Writer.Write(requestObject.UseServiceNowAction);
            }

            if(requestObject.IsSetUseSharePointAction())
            {
                context.Writer.WritePropertyName("UseSharePointAction");
                context.Writer.Write(requestObject.UseSharePointAction);
            }

            if(requestObject.IsSetUseSlackAction())
            {
                context.Writer.WritePropertyName("UseSlackAction");
                context.Writer.Write(requestObject.UseSlackAction);
            }

            if(requestObject.IsSetUseSmartsheetAction())
            {
                context.Writer.WritePropertyName("UseSmartsheetAction");
                context.Writer.Write(requestObject.UseSmartsheetAction);
            }

            if(requestObject.IsSetUseTextractAction())
            {
                context.Writer.WritePropertyName("UseTextractAction");
                context.Writer.Write(requestObject.UseTextractAction);
            }

            if(requestObject.IsSetUseZendeskAction())
            {
                context.Writer.WritePropertyName("UseZendeskAction");
                context.Writer.Write(requestObject.UseZendeskAction);
            }

            if(requestObject.IsSetViewAccountSPICECapacity())
            {
                context.Writer.WritePropertyName("ViewAccountSPICECapacity");
                context.Writer.Write(requestObject.ViewAccountSPICECapacity);
            }

            if(requestObject.IsSetZendeskAction())
            {
                context.Writer.WritePropertyName("ZendeskAction");
                context.Writer.Write(requestObject.ZendeskAction);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CapabilitiesMarshaller Instance = new CapabilitiesMarshaller();

    }
}