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
            if(requestObject.IsSetAction())
            {
                context.Writer.WritePropertyName("Action");
                context.Writer.WriteStringValue(requestObject.Action);
            }

            if(requestObject.IsSetAddOrRunAnomalyDetectionForAnalyses())
            {
                context.Writer.WritePropertyName("AddOrRunAnomalyDetectionForAnalyses");
                context.Writer.WriteStringValue(requestObject.AddOrRunAnomalyDetectionForAnalyses);
            }

            if(requestObject.IsSetAmazonBedrockARSAction())
            {
                context.Writer.WritePropertyName("AmazonBedrockARSAction");
                context.Writer.WriteStringValue(requestObject.AmazonBedrockARSAction);
            }

            if(requestObject.IsSetAmazonBedrockFSAction())
            {
                context.Writer.WritePropertyName("AmazonBedrockFSAction");
                context.Writer.WriteStringValue(requestObject.AmazonBedrockFSAction);
            }

            if(requestObject.IsSetAmazonBedrockKRSAction())
            {
                context.Writer.WritePropertyName("AmazonBedrockKRSAction");
                context.Writer.WriteStringValue(requestObject.AmazonBedrockKRSAction);
            }

            if(requestObject.IsSetAmazonSThreeAction())
            {
                context.Writer.WritePropertyName("AmazonSThreeAction");
                context.Writer.WriteStringValue(requestObject.AmazonSThreeAction);
            }

            if(requestObject.IsSetAnalysis())
            {
                context.Writer.WritePropertyName("Analysis");
                context.Writer.WriteStringValue(requestObject.Analysis);
            }

            if(requestObject.IsSetAsanaAction())
            {
                context.Writer.WritePropertyName("AsanaAction");
                context.Writer.WriteStringValue(requestObject.AsanaAction);
            }

            if(requestObject.IsSetAutomate())
            {
                context.Writer.WritePropertyName("Automate");
                context.Writer.WriteStringValue(requestObject.Automate);
            }

            if(requestObject.IsSetBambooHRAction())
            {
                context.Writer.WritePropertyName("BambooHRAction");
                context.Writer.WriteStringValue(requestObject.BambooHRAction);
            }

            if(requestObject.IsSetBoxAgentAction())
            {
                context.Writer.WritePropertyName("BoxAgentAction");
                context.Writer.WriteStringValue(requestObject.BoxAgentAction);
            }

            if(requestObject.IsSetCanvaAgentAction())
            {
                context.Writer.WritePropertyName("CanvaAgentAction");
                context.Writer.WriteStringValue(requestObject.CanvaAgentAction);
            }

            if(requestObject.IsSetChatAgent())
            {
                context.Writer.WritePropertyName("ChatAgent");
                context.Writer.WriteStringValue(requestObject.ChatAgent);
            }

            if(requestObject.IsSetComprehendAction())
            {
                context.Writer.WritePropertyName("ComprehendAction");
                context.Writer.WriteStringValue(requestObject.ComprehendAction);
            }

            if(requestObject.IsSetComprehendMedicalAction())
            {
                context.Writer.WritePropertyName("ComprehendMedicalAction");
                context.Writer.WriteStringValue(requestObject.ComprehendMedicalAction);
            }

            if(requestObject.IsSetConfluenceAction())
            {
                context.Writer.WritePropertyName("ConfluenceAction");
                context.Writer.WriteStringValue(requestObject.ConfluenceAction);
            }

            if(requestObject.IsSetCreateAndUpdateAmazonBedrockARSAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateAmazonBedrockARSAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateAmazonBedrockARSAction);
            }

            if(requestObject.IsSetCreateAndUpdateAmazonBedrockFSAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateAmazonBedrockFSAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateAmazonBedrockFSAction);
            }

            if(requestObject.IsSetCreateAndUpdateAmazonBedrockKRSAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateAmazonBedrockKRSAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateAmazonBedrockKRSAction);
            }

            if(requestObject.IsSetCreateAndUpdateAmazonSThreeAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateAmazonSThreeAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateAmazonSThreeAction);
            }

            if(requestObject.IsSetCreateAndUpdateAsanaAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateAsanaAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateAsanaAction);
            }

            if(requestObject.IsSetCreateAndUpdateBambooHRAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateBambooHRAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateBambooHRAction);
            }

            if(requestObject.IsSetCreateAndUpdateBoxAgentAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateBoxAgentAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateBoxAgentAction);
            }

            if(requestObject.IsSetCreateAndUpdateCanvaAgentAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateCanvaAgentAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateCanvaAgentAction);
            }

            if(requestObject.IsSetCreateAndUpdateComprehendAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateComprehendAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateComprehendAction);
            }

            if(requestObject.IsSetCreateAndUpdateComprehendMedicalAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateComprehendMedicalAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateComprehendMedicalAction);
            }

            if(requestObject.IsSetCreateAndUpdateConfluenceAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateConfluenceAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateConfluenceAction);
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

            if(requestObject.IsSetCreateAndUpdateFactSetAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateFactSetAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateFactSetAction);
            }

            if(requestObject.IsSetCreateAndUpdateGenericHTTPAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateGenericHTTPAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateGenericHTTPAction);
            }

            if(requestObject.IsSetCreateAndUpdateGithubAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateGithubAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateGithubAction);
            }

            if(requestObject.IsSetCreateAndUpdateGoogleCalendarAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateGoogleCalendarAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateGoogleCalendarAction);
            }

            if(requestObject.IsSetCreateAndUpdateHubspotAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateHubspotAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateHubspotAction);
            }

            if(requestObject.IsSetCreateAndUpdateHuggingFaceAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateHuggingFaceAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateHuggingFaceAction);
            }

            if(requestObject.IsSetCreateAndUpdateIntercomAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateIntercomAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateIntercomAction);
            }

            if(requestObject.IsSetCreateAndUpdateJiraAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateJiraAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateJiraAction);
            }

            if(requestObject.IsSetCreateAndUpdateLinearAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateLinearAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateLinearAction);
            }

            if(requestObject.IsSetCreateAndUpdateMCPAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateMCPAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateMCPAction);
            }

            if(requestObject.IsSetCreateAndUpdateMondayAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateMondayAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateMondayAction);
            }

            if(requestObject.IsSetCreateAndUpdateMSExchangeAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateMSExchangeAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateMSExchangeAction);
            }

            if(requestObject.IsSetCreateAndUpdateMSTeamsAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateMSTeamsAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateMSTeamsAction);
            }

            if(requestObject.IsSetCreateAndUpdateNewRelicAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateNewRelicAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateNewRelicAction);
            }

            if(requestObject.IsSetCreateAndUpdateNotionAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateNotionAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateNotionAction);
            }

            if(requestObject.IsSetCreateAndUpdateOneDriveAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateOneDriveAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateOneDriveAction);
            }

            if(requestObject.IsSetCreateAndUpdateOpenAPIAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateOpenAPIAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateOpenAPIAction);
            }

            if(requestObject.IsSetCreateAndUpdatePagerDutyAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdatePagerDutyAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdatePagerDutyAction);
            }

            if(requestObject.IsSetCreateAndUpdateSalesforceAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateSalesforceAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateSalesforceAction);
            }

            if(requestObject.IsSetCreateAndUpdateSandPGlobalEnergyAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateSandPGlobalEnergyAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateSandPGlobalEnergyAction);
            }

            if(requestObject.IsSetCreateAndUpdateSandPGMIAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateSandPGMIAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateSandPGMIAction);
            }

            if(requestObject.IsSetCreateAndUpdateSAPBillOfMaterialAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateSAPBillOfMaterialAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateSAPBillOfMaterialAction);
            }

            if(requestObject.IsSetCreateAndUpdateSAPBusinessPartnerAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateSAPBusinessPartnerAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateSAPBusinessPartnerAction);
            }

            if(requestObject.IsSetCreateAndUpdateSAPMaterialStockAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateSAPMaterialStockAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateSAPMaterialStockAction);
            }

            if(requestObject.IsSetCreateAndUpdateSAPPhysicalInventoryAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateSAPPhysicalInventoryAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateSAPPhysicalInventoryAction);
            }

            if(requestObject.IsSetCreateAndUpdateSAPProductMasterDataAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateSAPProductMasterDataAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateSAPProductMasterDataAction);
            }

            if(requestObject.IsSetCreateAndUpdateServiceNowAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateServiceNowAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateServiceNowAction);
            }

            if(requestObject.IsSetCreateAndUpdateSharePointAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateSharePointAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateSharePointAction);
            }

            if(requestObject.IsSetCreateAndUpdateSlackAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateSlackAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateSlackAction);
            }

            if(requestObject.IsSetCreateAndUpdateSmartsheetAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateSmartsheetAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateSmartsheetAction);
            }

            if(requestObject.IsSetCreateAndUpdateTextractAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateTextractAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateTextractAction);
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

            if(requestObject.IsSetCreateAndUpdateZendeskAction())
            {
                context.Writer.WritePropertyName("CreateAndUpdateZendeskAction");
                context.Writer.WriteStringValue(requestObject.CreateAndUpdateZendeskAction);
            }

            if(requestObject.IsSetCreateChatAgents())
            {
                context.Writer.WritePropertyName("CreateChatAgents");
                context.Writer.WriteStringValue(requestObject.CreateChatAgents);
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

            if(requestObject.IsSetFactSetAction())
            {
                context.Writer.WritePropertyName("FactSetAction");
                context.Writer.WriteStringValue(requestObject.FactSetAction);
            }

            if(requestObject.IsSetFlow())
            {
                context.Writer.WritePropertyName("Flow");
                context.Writer.WriteStringValue(requestObject.Flow);
            }

            if(requestObject.IsSetGenericHTTPAction())
            {
                context.Writer.WritePropertyName("GenericHTTPAction");
                context.Writer.WriteStringValue(requestObject.GenericHTTPAction);
            }

            if(requestObject.IsSetGithubAction())
            {
                context.Writer.WritePropertyName("GithubAction");
                context.Writer.WriteStringValue(requestObject.GithubAction);
            }

            if(requestObject.IsSetGoogleCalendarAction())
            {
                context.Writer.WritePropertyName("GoogleCalendarAction");
                context.Writer.WriteStringValue(requestObject.GoogleCalendarAction);
            }

            if(requestObject.IsSetHubspotAction())
            {
                context.Writer.WritePropertyName("HubspotAction");
                context.Writer.WriteStringValue(requestObject.HubspotAction);
            }

            if(requestObject.IsSetHuggingFaceAction())
            {
                context.Writer.WritePropertyName("HuggingFaceAction");
                context.Writer.WriteStringValue(requestObject.HuggingFaceAction);
            }

            if(requestObject.IsSetIncludeContentInScheduledReportsEmail())
            {
                context.Writer.WritePropertyName("IncludeContentInScheduledReportsEmail");
                context.Writer.WriteStringValue(requestObject.IncludeContentInScheduledReportsEmail);
            }

            if(requestObject.IsSetIntercomAction())
            {
                context.Writer.WritePropertyName("IntercomAction");
                context.Writer.WriteStringValue(requestObject.IntercomAction);
            }

            if(requestObject.IsSetJiraAction())
            {
                context.Writer.WritePropertyName("JiraAction");
                context.Writer.WriteStringValue(requestObject.JiraAction);
            }

            if(requestObject.IsSetKnowledgeBase())
            {
                context.Writer.WritePropertyName("KnowledgeBase");
                context.Writer.WriteStringValue(requestObject.KnowledgeBase);
            }

            if(requestObject.IsSetLinearAction())
            {
                context.Writer.WritePropertyName("LinearAction");
                context.Writer.WriteStringValue(requestObject.LinearAction);
            }

            if(requestObject.IsSetMCPAction())
            {
                context.Writer.WritePropertyName("MCPAction");
                context.Writer.WriteStringValue(requestObject.MCPAction);
            }

            if(requestObject.IsSetMondayAction())
            {
                context.Writer.WritePropertyName("MondayAction");
                context.Writer.WriteStringValue(requestObject.MondayAction);
            }

            if(requestObject.IsSetMSExchangeAction())
            {
                context.Writer.WritePropertyName("MSExchangeAction");
                context.Writer.WriteStringValue(requestObject.MSExchangeAction);
            }

            if(requestObject.IsSetMSTeamsAction())
            {
                context.Writer.WritePropertyName("MSTeamsAction");
                context.Writer.WriteStringValue(requestObject.MSTeamsAction);
            }

            if(requestObject.IsSetNewRelicAction())
            {
                context.Writer.WritePropertyName("NewRelicAction");
                context.Writer.WriteStringValue(requestObject.NewRelicAction);
            }

            if(requestObject.IsSetNotionAction())
            {
                context.Writer.WritePropertyName("NotionAction");
                context.Writer.WriteStringValue(requestObject.NotionAction);
            }

            if(requestObject.IsSetOneDriveAction())
            {
                context.Writer.WritePropertyName("OneDriveAction");
                context.Writer.WriteStringValue(requestObject.OneDriveAction);
            }

            if(requestObject.IsSetOpenAPIAction())
            {
                context.Writer.WritePropertyName("OpenAPIAction");
                context.Writer.WriteStringValue(requestObject.OpenAPIAction);
            }

            if(requestObject.IsSetPagerDutyAction())
            {
                context.Writer.WritePropertyName("PagerDutyAction");
                context.Writer.WriteStringValue(requestObject.PagerDutyAction);
            }

            if(requestObject.IsSetPerformFlowUiTask())
            {
                context.Writer.WritePropertyName("PerformFlowUiTask");
                context.Writer.WriteStringValue(requestObject.PerformFlowUiTask);
            }

            if(requestObject.IsSetPrintReports())
            {
                context.Writer.WritePropertyName("PrintReports");
                context.Writer.WriteStringValue(requestObject.PrintReports);
            }

            if(requestObject.IsSetPublishWithoutApproval())
            {
                context.Writer.WritePropertyName("PublishWithoutApproval");
                context.Writer.WriteStringValue(requestObject.PublishWithoutApproval);
            }

            if(requestObject.IsSetRenameSharedFolders())
            {
                context.Writer.WritePropertyName("RenameSharedFolders");
                context.Writer.WriteStringValue(requestObject.RenameSharedFolders);
            }

            if(requestObject.IsSetResearch())
            {
                context.Writer.WritePropertyName("Research");
                context.Writer.WriteStringValue(requestObject.Research);
            }

            if(requestObject.IsSetSalesforceAction())
            {
                context.Writer.WritePropertyName("SalesforceAction");
                context.Writer.WriteStringValue(requestObject.SalesforceAction);
            }

            if(requestObject.IsSetSandPGlobalEnergyAction())
            {
                context.Writer.WritePropertyName("SandPGlobalEnergyAction");
                context.Writer.WriteStringValue(requestObject.SandPGlobalEnergyAction);
            }

            if(requestObject.IsSetSandPGMIAction())
            {
                context.Writer.WritePropertyName("SandPGMIAction");
                context.Writer.WriteStringValue(requestObject.SandPGMIAction);
            }

            if(requestObject.IsSetSAPBillOfMaterialAction())
            {
                context.Writer.WritePropertyName("SAPBillOfMaterialAction");
                context.Writer.WriteStringValue(requestObject.SAPBillOfMaterialAction);
            }

            if(requestObject.IsSetSAPBusinessPartnerAction())
            {
                context.Writer.WritePropertyName("SAPBusinessPartnerAction");
                context.Writer.WriteStringValue(requestObject.SAPBusinessPartnerAction);
            }

            if(requestObject.IsSetSAPMaterialStockAction())
            {
                context.Writer.WritePropertyName("SAPMaterialStockAction");
                context.Writer.WriteStringValue(requestObject.SAPMaterialStockAction);
            }

            if(requestObject.IsSetSAPPhysicalInventoryAction())
            {
                context.Writer.WritePropertyName("SAPPhysicalInventoryAction");
                context.Writer.WriteStringValue(requestObject.SAPPhysicalInventoryAction);
            }

            if(requestObject.IsSetSAPProductMasterDataAction())
            {
                context.Writer.WritePropertyName("SAPProductMasterDataAction");
                context.Writer.WriteStringValue(requestObject.SAPProductMasterDataAction);
            }

            if(requestObject.IsSetSelfUpgradeUserRole())
            {
                context.Writer.WritePropertyName("SelfUpgradeUserRole");
                context.Writer.WriteStringValue(requestObject.SelfUpgradeUserRole);
            }

            if(requestObject.IsSetServiceNowAction())
            {
                context.Writer.WritePropertyName("ServiceNowAction");
                context.Writer.WriteStringValue(requestObject.ServiceNowAction);
            }

            if(requestObject.IsSetShareAmazonBedrockARSAction())
            {
                context.Writer.WritePropertyName("ShareAmazonBedrockARSAction");
                context.Writer.WriteStringValue(requestObject.ShareAmazonBedrockARSAction);
            }

            if(requestObject.IsSetShareAmazonBedrockFSAction())
            {
                context.Writer.WritePropertyName("ShareAmazonBedrockFSAction");
                context.Writer.WriteStringValue(requestObject.ShareAmazonBedrockFSAction);
            }

            if(requestObject.IsSetShareAmazonBedrockKRSAction())
            {
                context.Writer.WritePropertyName("ShareAmazonBedrockKRSAction");
                context.Writer.WriteStringValue(requestObject.ShareAmazonBedrockKRSAction);
            }

            if(requestObject.IsSetShareAmazonSThreeAction())
            {
                context.Writer.WritePropertyName("ShareAmazonSThreeAction");
                context.Writer.WriteStringValue(requestObject.ShareAmazonSThreeAction);
            }

            if(requestObject.IsSetShareAnalyses())
            {
                context.Writer.WritePropertyName("ShareAnalyses");
                context.Writer.WriteStringValue(requestObject.ShareAnalyses);
            }

            if(requestObject.IsSetShareAsanaAction())
            {
                context.Writer.WritePropertyName("ShareAsanaAction");
                context.Writer.WriteStringValue(requestObject.ShareAsanaAction);
            }

            if(requestObject.IsSetShareBambooHRAction())
            {
                context.Writer.WritePropertyName("ShareBambooHRAction");
                context.Writer.WriteStringValue(requestObject.ShareBambooHRAction);
            }

            if(requestObject.IsSetShareBoxAgentAction())
            {
                context.Writer.WritePropertyName("ShareBoxAgentAction");
                context.Writer.WriteStringValue(requestObject.ShareBoxAgentAction);
            }

            if(requestObject.IsSetShareCanvaAgentAction())
            {
                context.Writer.WritePropertyName("ShareCanvaAgentAction");
                context.Writer.WriteStringValue(requestObject.ShareCanvaAgentAction);
            }

            if(requestObject.IsSetShareComprehendAction())
            {
                context.Writer.WritePropertyName("ShareComprehendAction");
                context.Writer.WriteStringValue(requestObject.ShareComprehendAction);
            }

            if(requestObject.IsSetShareComprehendMedicalAction())
            {
                context.Writer.WritePropertyName("ShareComprehendMedicalAction");
                context.Writer.WriteStringValue(requestObject.ShareComprehendMedicalAction);
            }

            if(requestObject.IsSetShareConfluenceAction())
            {
                context.Writer.WritePropertyName("ShareConfluenceAction");
                context.Writer.WriteStringValue(requestObject.ShareConfluenceAction);
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

            if(requestObject.IsSetShareFactSetAction())
            {
                context.Writer.WritePropertyName("ShareFactSetAction");
                context.Writer.WriteStringValue(requestObject.ShareFactSetAction);
            }

            if(requestObject.IsSetShareGenericHTTPAction())
            {
                context.Writer.WritePropertyName("ShareGenericHTTPAction");
                context.Writer.WriteStringValue(requestObject.ShareGenericHTTPAction);
            }

            if(requestObject.IsSetShareGithubAction())
            {
                context.Writer.WritePropertyName("ShareGithubAction");
                context.Writer.WriteStringValue(requestObject.ShareGithubAction);
            }

            if(requestObject.IsSetShareGoogleCalendarAction())
            {
                context.Writer.WritePropertyName("ShareGoogleCalendarAction");
                context.Writer.WriteStringValue(requestObject.ShareGoogleCalendarAction);
            }

            if(requestObject.IsSetShareHubspotAction())
            {
                context.Writer.WritePropertyName("ShareHubspotAction");
                context.Writer.WriteStringValue(requestObject.ShareHubspotAction);
            }

            if(requestObject.IsSetShareHuggingFaceAction())
            {
                context.Writer.WritePropertyName("ShareHuggingFaceAction");
                context.Writer.WriteStringValue(requestObject.ShareHuggingFaceAction);
            }

            if(requestObject.IsSetShareIntercomAction())
            {
                context.Writer.WritePropertyName("ShareIntercomAction");
                context.Writer.WriteStringValue(requestObject.ShareIntercomAction);
            }

            if(requestObject.IsSetShareJiraAction())
            {
                context.Writer.WritePropertyName("ShareJiraAction");
                context.Writer.WriteStringValue(requestObject.ShareJiraAction);
            }

            if(requestObject.IsSetShareLinearAction())
            {
                context.Writer.WritePropertyName("ShareLinearAction");
                context.Writer.WriteStringValue(requestObject.ShareLinearAction);
            }

            if(requestObject.IsSetShareMCPAction())
            {
                context.Writer.WritePropertyName("ShareMCPAction");
                context.Writer.WriteStringValue(requestObject.ShareMCPAction);
            }

            if(requestObject.IsSetShareMondayAction())
            {
                context.Writer.WritePropertyName("ShareMondayAction");
                context.Writer.WriteStringValue(requestObject.ShareMondayAction);
            }

            if(requestObject.IsSetShareMSExchangeAction())
            {
                context.Writer.WritePropertyName("ShareMSExchangeAction");
                context.Writer.WriteStringValue(requestObject.ShareMSExchangeAction);
            }

            if(requestObject.IsSetShareMSTeamsAction())
            {
                context.Writer.WritePropertyName("ShareMSTeamsAction");
                context.Writer.WriteStringValue(requestObject.ShareMSTeamsAction);
            }

            if(requestObject.IsSetShareNewRelicAction())
            {
                context.Writer.WritePropertyName("ShareNewRelicAction");
                context.Writer.WriteStringValue(requestObject.ShareNewRelicAction);
            }

            if(requestObject.IsSetShareNotionAction())
            {
                context.Writer.WritePropertyName("ShareNotionAction");
                context.Writer.WriteStringValue(requestObject.ShareNotionAction);
            }

            if(requestObject.IsSetShareOneDriveAction())
            {
                context.Writer.WritePropertyName("ShareOneDriveAction");
                context.Writer.WriteStringValue(requestObject.ShareOneDriveAction);
            }

            if(requestObject.IsSetShareOpenAPIAction())
            {
                context.Writer.WritePropertyName("ShareOpenAPIAction");
                context.Writer.WriteStringValue(requestObject.ShareOpenAPIAction);
            }

            if(requestObject.IsSetSharePagerDutyAction())
            {
                context.Writer.WritePropertyName("SharePagerDutyAction");
                context.Writer.WriteStringValue(requestObject.SharePagerDutyAction);
            }

            if(requestObject.IsSetSharePointAction())
            {
                context.Writer.WritePropertyName("SharePointAction");
                context.Writer.WriteStringValue(requestObject.SharePointAction);
            }

            if(requestObject.IsSetShareSalesforceAction())
            {
                context.Writer.WritePropertyName("ShareSalesforceAction");
                context.Writer.WriteStringValue(requestObject.ShareSalesforceAction);
            }

            if(requestObject.IsSetShareSandPGlobalEnergyAction())
            {
                context.Writer.WritePropertyName("ShareSandPGlobalEnergyAction");
                context.Writer.WriteStringValue(requestObject.ShareSandPGlobalEnergyAction);
            }

            if(requestObject.IsSetShareSandPGMIAction())
            {
                context.Writer.WritePropertyName("ShareSandPGMIAction");
                context.Writer.WriteStringValue(requestObject.ShareSandPGMIAction);
            }

            if(requestObject.IsSetShareSAPBillOfMaterialAction())
            {
                context.Writer.WritePropertyName("ShareSAPBillOfMaterialAction");
                context.Writer.WriteStringValue(requestObject.ShareSAPBillOfMaterialAction);
            }

            if(requestObject.IsSetShareSAPBusinessPartnerAction())
            {
                context.Writer.WritePropertyName("ShareSAPBusinessPartnerAction");
                context.Writer.WriteStringValue(requestObject.ShareSAPBusinessPartnerAction);
            }

            if(requestObject.IsSetShareSAPMaterialStockAction())
            {
                context.Writer.WritePropertyName("ShareSAPMaterialStockAction");
                context.Writer.WriteStringValue(requestObject.ShareSAPMaterialStockAction);
            }

            if(requestObject.IsSetShareSAPPhysicalInventoryAction())
            {
                context.Writer.WritePropertyName("ShareSAPPhysicalInventoryAction");
                context.Writer.WriteStringValue(requestObject.ShareSAPPhysicalInventoryAction);
            }

            if(requestObject.IsSetShareSAPProductMasterDataAction())
            {
                context.Writer.WritePropertyName("ShareSAPProductMasterDataAction");
                context.Writer.WriteStringValue(requestObject.ShareSAPProductMasterDataAction);
            }

            if(requestObject.IsSetShareServiceNowAction())
            {
                context.Writer.WritePropertyName("ShareServiceNowAction");
                context.Writer.WriteStringValue(requestObject.ShareServiceNowAction);
            }

            if(requestObject.IsSetShareSharePointAction())
            {
                context.Writer.WritePropertyName("ShareSharePointAction");
                context.Writer.WriteStringValue(requestObject.ShareSharePointAction);
            }

            if(requestObject.IsSetShareSlackAction())
            {
                context.Writer.WritePropertyName("ShareSlackAction");
                context.Writer.WriteStringValue(requestObject.ShareSlackAction);
            }

            if(requestObject.IsSetShareSmartsheetAction())
            {
                context.Writer.WritePropertyName("ShareSmartsheetAction");
                context.Writer.WriteStringValue(requestObject.ShareSmartsheetAction);
            }

            if(requestObject.IsSetShareTextractAction())
            {
                context.Writer.WritePropertyName("ShareTextractAction");
                context.Writer.WriteStringValue(requestObject.ShareTextractAction);
            }

            if(requestObject.IsSetShareZendeskAction())
            {
                context.Writer.WritePropertyName("ShareZendeskAction");
                context.Writer.WriteStringValue(requestObject.ShareZendeskAction);
            }

            if(requestObject.IsSetSlackAction())
            {
                context.Writer.WritePropertyName("SlackAction");
                context.Writer.WriteStringValue(requestObject.SlackAction);
            }

            if(requestObject.IsSetSmartsheetAction())
            {
                context.Writer.WritePropertyName("SmartsheetAction");
                context.Writer.WriteStringValue(requestObject.SmartsheetAction);
            }

            if(requestObject.IsSetSpace())
            {
                context.Writer.WritePropertyName("Space");
                context.Writer.WriteStringValue(requestObject.Space);
            }

            if(requestObject.IsSetSubscribeDashboardEmailReports())
            {
                context.Writer.WritePropertyName("SubscribeDashboardEmailReports");
                context.Writer.WriteStringValue(requestObject.SubscribeDashboardEmailReports);
            }

            if(requestObject.IsSetTextractAction())
            {
                context.Writer.WritePropertyName("TextractAction");
                context.Writer.WriteStringValue(requestObject.TextractAction);
            }

            if(requestObject.IsSetUseAgentWebSearch())
            {
                context.Writer.WritePropertyName("UseAgentWebSearch");
                context.Writer.WriteStringValue(requestObject.UseAgentWebSearch);
            }

            if(requestObject.IsSetUseAmazonBedrockARSAction())
            {
                context.Writer.WritePropertyName("UseAmazonBedrockARSAction");
                context.Writer.WriteStringValue(requestObject.UseAmazonBedrockARSAction);
            }

            if(requestObject.IsSetUseAmazonBedrockFSAction())
            {
                context.Writer.WritePropertyName("UseAmazonBedrockFSAction");
                context.Writer.WriteStringValue(requestObject.UseAmazonBedrockFSAction);
            }

            if(requestObject.IsSetUseAmazonBedrockKRSAction())
            {
                context.Writer.WritePropertyName("UseAmazonBedrockKRSAction");
                context.Writer.WriteStringValue(requestObject.UseAmazonBedrockKRSAction);
            }

            if(requestObject.IsSetUseAmazonSThreeAction())
            {
                context.Writer.WritePropertyName("UseAmazonSThreeAction");
                context.Writer.WriteStringValue(requestObject.UseAmazonSThreeAction);
            }

            if(requestObject.IsSetUseAsanaAction())
            {
                context.Writer.WritePropertyName("UseAsanaAction");
                context.Writer.WriteStringValue(requestObject.UseAsanaAction);
            }

            if(requestObject.IsSetUseBambooHRAction())
            {
                context.Writer.WritePropertyName("UseBambooHRAction");
                context.Writer.WriteStringValue(requestObject.UseBambooHRAction);
            }

            if(requestObject.IsSetUseBedrockModels())
            {
                context.Writer.WritePropertyName("UseBedrockModels");
                context.Writer.WriteStringValue(requestObject.UseBedrockModels);
            }

            if(requestObject.IsSetUseBoxAgentAction())
            {
                context.Writer.WritePropertyName("UseBoxAgentAction");
                context.Writer.WriteStringValue(requestObject.UseBoxAgentAction);
            }

            if(requestObject.IsSetUseCanvaAgentAction())
            {
                context.Writer.WritePropertyName("UseCanvaAgentAction");
                context.Writer.WriteStringValue(requestObject.UseCanvaAgentAction);
            }

            if(requestObject.IsSetUseComprehendAction())
            {
                context.Writer.WritePropertyName("UseComprehendAction");
                context.Writer.WriteStringValue(requestObject.UseComprehendAction);
            }

            if(requestObject.IsSetUseComprehendMedicalAction())
            {
                context.Writer.WritePropertyName("UseComprehendMedicalAction");
                context.Writer.WriteStringValue(requestObject.UseComprehendMedicalAction);
            }

            if(requestObject.IsSetUseConfluenceAction())
            {
                context.Writer.WritePropertyName("UseConfluenceAction");
                context.Writer.WriteStringValue(requestObject.UseConfluenceAction);
            }

            if(requestObject.IsSetUseFactSetAction())
            {
                context.Writer.WritePropertyName("UseFactSetAction");
                context.Writer.WriteStringValue(requestObject.UseFactSetAction);
            }

            if(requestObject.IsSetUseGenericHTTPAction())
            {
                context.Writer.WritePropertyName("UseGenericHTTPAction");
                context.Writer.WriteStringValue(requestObject.UseGenericHTTPAction);
            }

            if(requestObject.IsSetUseGithubAction())
            {
                context.Writer.WritePropertyName("UseGithubAction");
                context.Writer.WriteStringValue(requestObject.UseGithubAction);
            }

            if(requestObject.IsSetUseGoogleCalendarAction())
            {
                context.Writer.WritePropertyName("UseGoogleCalendarAction");
                context.Writer.WriteStringValue(requestObject.UseGoogleCalendarAction);
            }

            if(requestObject.IsSetUseHubspotAction())
            {
                context.Writer.WritePropertyName("UseHubspotAction");
                context.Writer.WriteStringValue(requestObject.UseHubspotAction);
            }

            if(requestObject.IsSetUseHuggingFaceAction())
            {
                context.Writer.WritePropertyName("UseHuggingFaceAction");
                context.Writer.WriteStringValue(requestObject.UseHuggingFaceAction);
            }

            if(requestObject.IsSetUseIntercomAction())
            {
                context.Writer.WritePropertyName("UseIntercomAction");
                context.Writer.WriteStringValue(requestObject.UseIntercomAction);
            }

            if(requestObject.IsSetUseJiraAction())
            {
                context.Writer.WritePropertyName("UseJiraAction");
                context.Writer.WriteStringValue(requestObject.UseJiraAction);
            }

            if(requestObject.IsSetUseLinearAction())
            {
                context.Writer.WritePropertyName("UseLinearAction");
                context.Writer.WriteStringValue(requestObject.UseLinearAction);
            }

            if(requestObject.IsSetUseMCPAction())
            {
                context.Writer.WritePropertyName("UseMCPAction");
                context.Writer.WriteStringValue(requestObject.UseMCPAction);
            }

            if(requestObject.IsSetUseMondayAction())
            {
                context.Writer.WritePropertyName("UseMondayAction");
                context.Writer.WriteStringValue(requestObject.UseMondayAction);
            }

            if(requestObject.IsSetUseMSExchangeAction())
            {
                context.Writer.WritePropertyName("UseMSExchangeAction");
                context.Writer.WriteStringValue(requestObject.UseMSExchangeAction);
            }

            if(requestObject.IsSetUseMSTeamsAction())
            {
                context.Writer.WritePropertyName("UseMSTeamsAction");
                context.Writer.WriteStringValue(requestObject.UseMSTeamsAction);
            }

            if(requestObject.IsSetUseNewRelicAction())
            {
                context.Writer.WritePropertyName("UseNewRelicAction");
                context.Writer.WriteStringValue(requestObject.UseNewRelicAction);
            }

            if(requestObject.IsSetUseNotionAction())
            {
                context.Writer.WritePropertyName("UseNotionAction");
                context.Writer.WriteStringValue(requestObject.UseNotionAction);
            }

            if(requestObject.IsSetUseOneDriveAction())
            {
                context.Writer.WritePropertyName("UseOneDriveAction");
                context.Writer.WriteStringValue(requestObject.UseOneDriveAction);
            }

            if(requestObject.IsSetUseOpenAPIAction())
            {
                context.Writer.WritePropertyName("UseOpenAPIAction");
                context.Writer.WriteStringValue(requestObject.UseOpenAPIAction);
            }

            if(requestObject.IsSetUsePagerDutyAction())
            {
                context.Writer.WritePropertyName("UsePagerDutyAction");
                context.Writer.WriteStringValue(requestObject.UsePagerDutyAction);
            }

            if(requestObject.IsSetUseSalesforceAction())
            {
                context.Writer.WritePropertyName("UseSalesforceAction");
                context.Writer.WriteStringValue(requestObject.UseSalesforceAction);
            }

            if(requestObject.IsSetUseSandPGlobalEnergyAction())
            {
                context.Writer.WritePropertyName("UseSandPGlobalEnergyAction");
                context.Writer.WriteStringValue(requestObject.UseSandPGlobalEnergyAction);
            }

            if(requestObject.IsSetUseSandPGMIAction())
            {
                context.Writer.WritePropertyName("UseSandPGMIAction");
                context.Writer.WriteStringValue(requestObject.UseSandPGMIAction);
            }

            if(requestObject.IsSetUseSAPBillOfMaterialAction())
            {
                context.Writer.WritePropertyName("UseSAPBillOfMaterialAction");
                context.Writer.WriteStringValue(requestObject.UseSAPBillOfMaterialAction);
            }

            if(requestObject.IsSetUseSAPBusinessPartnerAction())
            {
                context.Writer.WritePropertyName("UseSAPBusinessPartnerAction");
                context.Writer.WriteStringValue(requestObject.UseSAPBusinessPartnerAction);
            }

            if(requestObject.IsSetUseSAPMaterialStockAction())
            {
                context.Writer.WritePropertyName("UseSAPMaterialStockAction");
                context.Writer.WriteStringValue(requestObject.UseSAPMaterialStockAction);
            }

            if(requestObject.IsSetUseSAPPhysicalInventoryAction())
            {
                context.Writer.WritePropertyName("UseSAPPhysicalInventoryAction");
                context.Writer.WriteStringValue(requestObject.UseSAPPhysicalInventoryAction);
            }

            if(requestObject.IsSetUseSAPProductMasterDataAction())
            {
                context.Writer.WritePropertyName("UseSAPProductMasterDataAction");
                context.Writer.WriteStringValue(requestObject.UseSAPProductMasterDataAction);
            }

            if(requestObject.IsSetUseServiceNowAction())
            {
                context.Writer.WritePropertyName("UseServiceNowAction");
                context.Writer.WriteStringValue(requestObject.UseServiceNowAction);
            }

            if(requestObject.IsSetUseSharePointAction())
            {
                context.Writer.WritePropertyName("UseSharePointAction");
                context.Writer.WriteStringValue(requestObject.UseSharePointAction);
            }

            if(requestObject.IsSetUseSlackAction())
            {
                context.Writer.WritePropertyName("UseSlackAction");
                context.Writer.WriteStringValue(requestObject.UseSlackAction);
            }

            if(requestObject.IsSetUseSmartsheetAction())
            {
                context.Writer.WritePropertyName("UseSmartsheetAction");
                context.Writer.WriteStringValue(requestObject.UseSmartsheetAction);
            }

            if(requestObject.IsSetUseTextractAction())
            {
                context.Writer.WritePropertyName("UseTextractAction");
                context.Writer.WriteStringValue(requestObject.UseTextractAction);
            }

            if(requestObject.IsSetUseZendeskAction())
            {
                context.Writer.WritePropertyName("UseZendeskAction");
                context.Writer.WriteStringValue(requestObject.UseZendeskAction);
            }

            if(requestObject.IsSetViewAccountSPICECapacity())
            {
                context.Writer.WritePropertyName("ViewAccountSPICECapacity");
                context.Writer.WriteStringValue(requestObject.ViewAccountSPICECapacity);
            }

            if(requestObject.IsSetZendeskAction())
            {
                context.Writer.WritePropertyName("ZendeskAction");
                context.Writer.WriteStringValue(requestObject.ZendeskAction);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CapabilitiesMarshaller Instance = new CapabilitiesMarshaller();

    }
}