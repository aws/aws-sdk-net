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
using System.Net;
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
    /// Response Unmarshaller for Capabilities Object
    /// </summary>  
    public class CapabilitiesUnmarshaller : IUnmarshaller<Capabilities, XmlUnmarshallerContext>, IUnmarshaller<Capabilities, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Capabilities IUnmarshaller<Capabilities, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Capabilities Unmarshall(JsonUnmarshallerContext context)
        {
            Capabilities unmarshalledObject = new Capabilities();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Action", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Action = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AddOrRunAnomalyDetectionForAnalyses", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AddOrRunAnomalyDetectionForAnalyses = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AmazonBedrockARSAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AmazonBedrockARSAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AmazonBedrockFSAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AmazonBedrockFSAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AmazonBedrockKRSAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AmazonBedrockKRSAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AmazonSThreeAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AmazonSThreeAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Analysis", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Analysis = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AsanaAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AsanaAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Automate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Automate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BambooHRAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BambooHRAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BoxAgentAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BoxAgentAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CanvaAgentAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CanvaAgentAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ChatAgent", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ChatAgent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ComprehendAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ComprehendAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ComprehendMedicalAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ComprehendMedicalAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConfluenceAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConfluenceAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateAmazonBedrockARSAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateAmazonBedrockARSAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateAmazonBedrockFSAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateAmazonBedrockFSAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateAmazonBedrockKRSAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateAmazonBedrockKRSAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateAmazonSThreeAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateAmazonSThreeAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateAsanaAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateAsanaAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateBambooHRAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateBambooHRAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateBoxAgentAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateBoxAgentAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateCanvaAgentAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateCanvaAgentAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateComprehendAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateComprehendAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateComprehendMedicalAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateComprehendMedicalAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateConfluenceAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateConfluenceAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateDashboardEmailReports", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateDashboardEmailReports = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateDatasets", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateDatasets = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateDataSources", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateDataSources = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateFactSetAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateFactSetAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateGenericHTTPAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateGenericHTTPAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateGithubAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateGithubAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateGoogleCalendarAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateGoogleCalendarAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateHubspotAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateHubspotAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateHuggingFaceAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateHuggingFaceAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateIntercomAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateIntercomAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateJiraAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateJiraAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateLinearAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateLinearAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateMCPAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateMCPAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateMondayAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateMondayAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateMSExchangeAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateMSExchangeAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateMSTeamsAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateMSTeamsAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateNewRelicAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateNewRelicAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateNotionAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateNotionAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateOneDriveAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateOneDriveAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateOpenAPIAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateOpenAPIAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdatePagerDutyAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdatePagerDutyAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateSalesforceAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateSalesforceAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateSandPGlobalEnergyAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateSandPGlobalEnergyAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateSandPGMIAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateSandPGMIAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateSAPBillOfMaterialAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateSAPBillOfMaterialAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateSAPBusinessPartnerAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateSAPBusinessPartnerAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateSAPMaterialStockAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateSAPMaterialStockAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateSAPPhysicalInventoryAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateSAPPhysicalInventoryAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateSAPProductMasterDataAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateSAPProductMasterDataAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateServiceNowAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateServiceNowAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateSharePointAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateSharePointAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateSlackAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateSlackAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateSmartsheetAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateSmartsheetAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateTextractAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateTextractAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateThemes", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateThemes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateThresholdAlerts", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateThresholdAlerts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateAndUpdateZendeskAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAndUpdateZendeskAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateChatAgents", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateChatAgents = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateSharedFolders", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateSharedFolders = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateSPICEDataset", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateSPICEDataset = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Dashboard", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Dashboard = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExportToCsv", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExportToCsv = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExportToCsvInScheduledReports", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExportToCsvInScheduledReports = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExportToExcel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExportToExcel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExportToExcelInScheduledReports", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExportToExcelInScheduledReports = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExportToPdf", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExportToPdf = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExportToPdfInScheduledReports", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExportToPdfInScheduledReports = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FactSetAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FactSetAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Flow", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Flow = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GenericHTTPAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GenericHTTPAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GithubAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GithubAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GoogleCalendarAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GoogleCalendarAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HubspotAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HubspotAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HuggingFaceAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HuggingFaceAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IncludeContentInScheduledReportsEmail", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IncludeContentInScheduledReportsEmail = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IntercomAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IntercomAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JiraAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JiraAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KnowledgeBase", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KnowledgeBase = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LinearAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LinearAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MCPAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MCPAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MondayAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MondayAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MSExchangeAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MSExchangeAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MSTeamsAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MSTeamsAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NewRelicAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NewRelicAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NotionAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NotionAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OneDriveAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OneDriveAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OpenAPIAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OpenAPIAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PagerDutyAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PagerDutyAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PerformFlowUiTask", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PerformFlowUiTask = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PrintReports", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PrintReports = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PublishWithoutApproval", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PublishWithoutApproval = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RenameSharedFolders", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RenameSharedFolders = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Research", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Research = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SalesforceAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SalesforceAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SandPGlobalEnergyAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SandPGlobalEnergyAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SandPGMIAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SandPGMIAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SAPBillOfMaterialAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SAPBillOfMaterialAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SAPBusinessPartnerAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SAPBusinessPartnerAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SAPMaterialStockAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SAPMaterialStockAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SAPPhysicalInventoryAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SAPPhysicalInventoryAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SAPProductMasterDataAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SAPProductMasterDataAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SelfUpgradeUserRole", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SelfUpgradeUserRole = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceNowAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceNowAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareAmazonBedrockARSAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareAmazonBedrockARSAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareAmazonBedrockFSAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareAmazonBedrockFSAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareAmazonBedrockKRSAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareAmazonBedrockKRSAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareAmazonSThreeAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareAmazonSThreeAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareAnalyses", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareAnalyses = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareAsanaAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareAsanaAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareBambooHRAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareBambooHRAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareBoxAgentAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareBoxAgentAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareCanvaAgentAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareCanvaAgentAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareComprehendAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareComprehendAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareComprehendMedicalAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareComprehendMedicalAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareConfluenceAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareConfluenceAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareDashboards", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareDashboards = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareDatasets", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareDatasets = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareDataSources", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareDataSources = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareFactSetAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareFactSetAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareGenericHTTPAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareGenericHTTPAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareGithubAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareGithubAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareGoogleCalendarAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareGoogleCalendarAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareHubspotAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareHubspotAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareHuggingFaceAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareHuggingFaceAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareIntercomAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareIntercomAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareJiraAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareJiraAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareLinearAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareLinearAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareMCPAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareMCPAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareMondayAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareMondayAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareMSExchangeAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareMSExchangeAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareMSTeamsAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareMSTeamsAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareNewRelicAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareNewRelicAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareNotionAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareNotionAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareOneDriveAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareOneDriveAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareOpenAPIAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareOpenAPIAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SharePagerDutyAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SharePagerDutyAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SharePointAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SharePointAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareSalesforceAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareSalesforceAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareSandPGlobalEnergyAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareSandPGlobalEnergyAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareSandPGMIAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareSandPGMIAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareSAPBillOfMaterialAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareSAPBillOfMaterialAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareSAPBusinessPartnerAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareSAPBusinessPartnerAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareSAPMaterialStockAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareSAPMaterialStockAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareSAPPhysicalInventoryAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareSAPPhysicalInventoryAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareSAPProductMasterDataAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareSAPProductMasterDataAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareServiceNowAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareServiceNowAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareSharePointAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareSharePointAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareSlackAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareSlackAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareSmartsheetAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareSmartsheetAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareTextractAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareTextractAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareZendeskAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareZendeskAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SlackAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SlackAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SmartsheetAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SmartsheetAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Space", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Space = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubscribeDashboardEmailReports", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SubscribeDashboardEmailReports = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TextractAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TextractAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseAgentWebSearch", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseAgentWebSearch = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseAmazonBedrockARSAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseAmazonBedrockARSAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseAmazonBedrockFSAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseAmazonBedrockFSAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseAmazonBedrockKRSAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseAmazonBedrockKRSAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseAmazonSThreeAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseAmazonSThreeAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseAsanaAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseAsanaAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseBambooHRAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseBambooHRAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseBedrockModels", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseBedrockModels = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseBoxAgentAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseBoxAgentAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseCanvaAgentAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseCanvaAgentAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseComprehendAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseComprehendAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseComprehendMedicalAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseComprehendMedicalAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseConfluenceAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseConfluenceAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseFactSetAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseFactSetAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseGenericHTTPAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseGenericHTTPAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseGithubAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseGithubAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseGoogleCalendarAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseGoogleCalendarAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseHubspotAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseHubspotAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseHuggingFaceAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseHuggingFaceAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseIntercomAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseIntercomAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseJiraAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseJiraAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseLinearAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseLinearAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseMCPAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseMCPAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseMondayAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseMondayAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseMSExchangeAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseMSExchangeAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseMSTeamsAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseMSTeamsAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseNewRelicAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseNewRelicAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseNotionAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseNotionAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseOneDriveAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseOneDriveAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseOpenAPIAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseOpenAPIAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UsePagerDutyAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UsePagerDutyAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseSalesforceAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseSalesforceAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseSandPGlobalEnergyAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseSandPGlobalEnergyAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseSandPGMIAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseSandPGMIAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseSAPBillOfMaterialAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseSAPBillOfMaterialAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseSAPBusinessPartnerAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseSAPBusinessPartnerAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseSAPMaterialStockAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseSAPMaterialStockAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseSAPPhysicalInventoryAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseSAPPhysicalInventoryAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseSAPProductMasterDataAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseSAPProductMasterDataAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseServiceNowAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseServiceNowAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseSharePointAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseSharePointAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseSlackAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseSlackAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseSmartsheetAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseSmartsheetAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseTextractAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseTextractAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseZendeskAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseZendeskAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ViewAccountSPICECapacity", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ViewAccountSPICECapacity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ZendeskAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ZendeskAction = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CapabilitiesUnmarshaller _instance = new CapabilitiesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CapabilitiesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}