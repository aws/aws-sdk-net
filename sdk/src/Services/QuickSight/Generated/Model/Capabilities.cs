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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A set of actions that correspond to Amazon Quick Sight permissions.
    /// </summary>
    public partial class Capabilities
    {
        private CapabilityState _action;
        private CapabilityState _addOrRunAnomalyDetectionForAnalyses;
        private CapabilityState _amazonBedrockARSAction;
        private CapabilityState _amazonBedrockFSAction;
        private CapabilityState _amazonBedrockKRSAction;
        private CapabilityState _amazonSThreeAction;
        private CapabilityState _analysis;
        private CapabilityState _asanaAction;
        private CapabilityState _automate;
        private CapabilityState _bambooHRAction;
        private CapabilityState _boxAgentAction;
        private CapabilityState _canvaAgentAction;
        private CapabilityState _chatAgent;
        private CapabilityState _comprehendAction;
        private CapabilityState _comprehendMedicalAction;
        private CapabilityState _confluenceAction;
        private CapabilityState _createAndUpdateAmazonBedrockARSAction;
        private CapabilityState _createAndUpdateAmazonBedrockFSAction;
        private CapabilityState _createAndUpdateAmazonBedrockKRSAction;
        private CapabilityState _createAndUpdateAmazonSThreeAction;
        private CapabilityState _createAndUpdateAsanaAction;
        private CapabilityState _createAndUpdateBambooHRAction;
        private CapabilityState _createAndUpdateBoxAgentAction;
        private CapabilityState _createAndUpdateCanvaAgentAction;
        private CapabilityState _createAndUpdateComprehendAction;
        private CapabilityState _createAndUpdateComprehendMedicalAction;
        private CapabilityState _createAndUpdateConfluenceAction;
        private CapabilityState _createAndUpdateDashboardEmailReports;
        private CapabilityState _createAndUpdateDatasets;
        private CapabilityState _createAndUpdateDataSources;
        private CapabilityState _createAndUpdateFactSetAction;
        private CapabilityState _createAndUpdateGenericHTTPAction;
        private CapabilityState _createAndUpdateGithubAction;
        private CapabilityState _createAndUpdateGoogleCalendarAction;
        private CapabilityState _createAndUpdateHubspotAction;
        private CapabilityState _createAndUpdateHuggingFaceAction;
        private CapabilityState _createAndUpdateIntercomAction;
        private CapabilityState _createAndUpdateJiraAction;
        private CapabilityState _createAndUpdateLinearAction;
        private CapabilityState _createAndUpdateMCPAction;
        private CapabilityState _createAndUpdateMondayAction;
        private CapabilityState _createAndUpdateMSExchangeAction;
        private CapabilityState _createAndUpdateMSTeamsAction;
        private CapabilityState _createAndUpdateNewRelicAction;
        private CapabilityState _createAndUpdateNotionAction;
        private CapabilityState _createAndUpdateOneDriveAction;
        private CapabilityState _createAndUpdateOpenAPIAction;
        private CapabilityState _createAndUpdatePagerDutyAction;
        private CapabilityState _createAndUpdateSalesforceAction;
        private CapabilityState _createAndUpdateSandPGlobalEnergyAction;
        private CapabilityState _createAndUpdateSandPGMIAction;
        private CapabilityState _createAndUpdateSAPBillOfMaterialAction;
        private CapabilityState _createAndUpdateSAPBusinessPartnerAction;
        private CapabilityState _createAndUpdateSAPMaterialStockAction;
        private CapabilityState _createAndUpdateSAPPhysicalInventoryAction;
        private CapabilityState _createAndUpdateSAPProductMasterDataAction;
        private CapabilityState _createAndUpdateServiceNowAction;
        private CapabilityState _createAndUpdateSharePointAction;
        private CapabilityState _createAndUpdateSlackAction;
        private CapabilityState _createAndUpdateSmartsheetAction;
        private CapabilityState _createAndUpdateTextractAction;
        private CapabilityState _createAndUpdateThemes;
        private CapabilityState _createAndUpdateThresholdAlerts;
        private CapabilityState _createAndUpdateZendeskAction;
        private CapabilityState _createChatAgents;
        private CapabilityState _createSharedFolders;
        private CapabilityState _createSPICEDataset;
        private CapabilityState _dashboard;
        private CapabilityState _exportToCsv;
        private CapabilityState _exportToCsvInScheduledReports;
        private CapabilityState _exportToExcel;
        private CapabilityState _exportToExcelInScheduledReports;
        private CapabilityState _exportToPdf;
        private CapabilityState _exportToPdfInScheduledReports;
        private CapabilityState _factSetAction;
        private CapabilityState _flow;
        private CapabilityState _genericHTTPAction;
        private CapabilityState _githubAction;
        private CapabilityState _googleCalendarAction;
        private CapabilityState _hubspotAction;
        private CapabilityState _huggingFaceAction;
        private CapabilityState _includeContentInScheduledReportsEmail;
        private CapabilityState _intercomAction;
        private CapabilityState _jiraAction;
        private CapabilityState _knowledgeBase;
        private CapabilityState _linearAction;
        private CapabilityState _mcpAction;
        private CapabilityState _mondayAction;
        private CapabilityState _msExchangeAction;
        private CapabilityState _msTeamsAction;
        private CapabilityState _newRelicAction;
        private CapabilityState _notionAction;
        private CapabilityState _oneDriveAction;
        private CapabilityState _openAPIAction;
        private CapabilityState _pagerDutyAction;
        private CapabilityState _performFlowUiTask;
        private CapabilityState _printReports;
        private CapabilityState _publishWithoutApproval;
        private CapabilityState _renameSharedFolders;
        private CapabilityState _research;
        private CapabilityState _salesforceAction;
        private CapabilityState _sandPGlobalEnergyAction;
        private CapabilityState _sandPGMIAction;
        private CapabilityState _sapBillOfMaterialAction;
        private CapabilityState _sapBusinessPartnerAction;
        private CapabilityState _sapMaterialStockAction;
        private CapabilityState _sapPhysicalInventoryAction;
        private CapabilityState _sapProductMasterDataAction;
        private CapabilityState _selfUpgradeUserRole;
        private CapabilityState _serviceNowAction;
        private CapabilityState _shareAmazonBedrockARSAction;
        private CapabilityState _shareAmazonBedrockFSAction;
        private CapabilityState _shareAmazonBedrockKRSAction;
        private CapabilityState _shareAmazonSThreeAction;
        private CapabilityState _shareAnalyses;
        private CapabilityState _shareAsanaAction;
        private CapabilityState _shareBambooHRAction;
        private CapabilityState _shareBoxAgentAction;
        private CapabilityState _shareCanvaAgentAction;
        private CapabilityState _shareComprehendAction;
        private CapabilityState _shareComprehendMedicalAction;
        private CapabilityState _shareConfluenceAction;
        private CapabilityState _shareDashboards;
        private CapabilityState _shareDatasets;
        private CapabilityState _shareDataSources;
        private CapabilityState _shareFactSetAction;
        private CapabilityState _shareGenericHTTPAction;
        private CapabilityState _shareGithubAction;
        private CapabilityState _shareGoogleCalendarAction;
        private CapabilityState _shareHubspotAction;
        private CapabilityState _shareHuggingFaceAction;
        private CapabilityState _shareIntercomAction;
        private CapabilityState _shareJiraAction;
        private CapabilityState _shareLinearAction;
        private CapabilityState _shareMCPAction;
        private CapabilityState _shareMondayAction;
        private CapabilityState _shareMSExchangeAction;
        private CapabilityState _shareMSTeamsAction;
        private CapabilityState _shareNewRelicAction;
        private CapabilityState _shareNotionAction;
        private CapabilityState _shareOneDriveAction;
        private CapabilityState _shareOpenAPIAction;
        private CapabilityState _sharePagerDutyAction;
        private CapabilityState _sharePointAction;
        private CapabilityState _shareSalesforceAction;
        private CapabilityState _shareSandPGlobalEnergyAction;
        private CapabilityState _shareSandPGMIAction;
        private CapabilityState _shareSAPBillOfMaterialAction;
        private CapabilityState _shareSAPBusinessPartnerAction;
        private CapabilityState _shareSAPMaterialStockAction;
        private CapabilityState _shareSAPPhysicalInventoryAction;
        private CapabilityState _shareSAPProductMasterDataAction;
        private CapabilityState _shareServiceNowAction;
        private CapabilityState _shareSharePointAction;
        private CapabilityState _shareSlackAction;
        private CapabilityState _shareSmartsheetAction;
        private CapabilityState _shareTextractAction;
        private CapabilityState _shareZendeskAction;
        private CapabilityState _slackAction;
        private CapabilityState _smartsheetAction;
        private CapabilityState _space;
        private CapabilityState _subscribeDashboardEmailReports;
        private CapabilityState _textractAction;
        private CapabilityState _useAgentWebSearch;
        private CapabilityState _useAmazonBedrockARSAction;
        private CapabilityState _useAmazonBedrockFSAction;
        private CapabilityState _useAmazonBedrockKRSAction;
        private CapabilityState _useAmazonSThreeAction;
        private CapabilityState _useAsanaAction;
        private CapabilityState _useBambooHRAction;
        private CapabilityState _useBedrockModels;
        private CapabilityState _useBoxAgentAction;
        private CapabilityState _useCanvaAgentAction;
        private CapabilityState _useComprehendAction;
        private CapabilityState _useComprehendMedicalAction;
        private CapabilityState _useConfluenceAction;
        private CapabilityState _useFactSetAction;
        private CapabilityState _useGenericHTTPAction;
        private CapabilityState _useGithubAction;
        private CapabilityState _useGoogleCalendarAction;
        private CapabilityState _useHubspotAction;
        private CapabilityState _useHuggingFaceAction;
        private CapabilityState _useIntercomAction;
        private CapabilityState _useJiraAction;
        private CapabilityState _useLinearAction;
        private CapabilityState _useMCPAction;
        private CapabilityState _useMondayAction;
        private CapabilityState _useMSExchangeAction;
        private CapabilityState _useMSTeamsAction;
        private CapabilityState _useNewRelicAction;
        private CapabilityState _useNotionAction;
        private CapabilityState _useOneDriveAction;
        private CapabilityState _useOpenAPIAction;
        private CapabilityState _usePagerDutyAction;
        private CapabilityState _useSalesforceAction;
        private CapabilityState _useSandPGlobalEnergyAction;
        private CapabilityState _useSandPGMIAction;
        private CapabilityState _useSAPBillOfMaterialAction;
        private CapabilityState _useSAPBusinessPartnerAction;
        private CapabilityState _useSAPMaterialStockAction;
        private CapabilityState _useSAPPhysicalInventoryAction;
        private CapabilityState _useSAPProductMasterDataAction;
        private CapabilityState _useServiceNowAction;
        private CapabilityState _useSharePointAction;
        private CapabilityState _useSlackAction;
        private CapabilityState _useSmartsheetAction;
        private CapabilityState _useTextractAction;
        private CapabilityState _useZendeskAction;
        private CapabilityState _viewAccountSPICECapacity;
        private CapabilityState _zendeskAction;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The ability to perform actions in external services through Action connectors. Actions
        /// allow users to interact with third-party systems.
        /// </para>
        /// </summary>
        public CapabilityState Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property AddOrRunAnomalyDetectionForAnalyses. 
        /// <para>
        /// The ability to add or run anomaly detection.
        /// </para>
        /// </summary>
        public CapabilityState AddOrRunAnomalyDetectionForAnalyses
        {
            get { return this._addOrRunAnomalyDetectionForAnalyses; }
            set { this._addOrRunAnomalyDetectionForAnalyses = value; }
        }

        // Check to see if AddOrRunAnomalyDetectionForAnalyses property is set
        internal bool IsSetAddOrRunAnomalyDetectionForAnalyses()
        {
            return this._addOrRunAnomalyDetectionForAnalyses != null;
        }

        /// <summary>
        /// Gets and sets the property AmazonBedrockARSAction. 
        /// <para>
        /// The ability to perform actions using Bedrock Agent connectors.
        /// </para>
        /// </summary>
        public CapabilityState AmazonBedrockARSAction
        {
            get { return this._amazonBedrockARSAction; }
            set { this._amazonBedrockARSAction = value; }
        }

        // Check to see if AmazonBedrockARSAction property is set
        internal bool IsSetAmazonBedrockARSAction()
        {
            return this._amazonBedrockARSAction != null;
        }

        /// <summary>
        /// Gets and sets the property AmazonBedrockFSAction. 
        /// <para>
        /// The ability to perform actions using Bedrock Runtime connectors.
        /// </para>
        /// </summary>
        public CapabilityState AmazonBedrockFSAction
        {
            get { return this._amazonBedrockFSAction; }
            set { this._amazonBedrockFSAction = value; }
        }

        // Check to see if AmazonBedrockFSAction property is set
        internal bool IsSetAmazonBedrockFSAction()
        {
            return this._amazonBedrockFSAction != null;
        }

        /// <summary>
        /// Gets and sets the property AmazonBedrockKRSAction. 
        /// <para>
        /// The ability to perform actions using Bedrock Data Automation Runtime connectors.
        /// </para>
        /// </summary>
        public CapabilityState AmazonBedrockKRSAction
        {
            get { return this._amazonBedrockKRSAction; }
            set { this._amazonBedrockKRSAction = value; }
        }

        // Check to see if AmazonBedrockKRSAction property is set
        internal bool IsSetAmazonBedrockKRSAction()
        {
            return this._amazonBedrockKRSAction != null;
        }

        /// <summary>
        /// Gets and sets the property AmazonSThreeAction. 
        /// <para>
        /// The ability to perform actions using Amazon S3 connectors.
        /// </para>
        /// </summary>
        public CapabilityState AmazonSThreeAction
        {
            get { return this._amazonSThreeAction; }
            set { this._amazonSThreeAction = value; }
        }

        // Check to see if AmazonSThreeAction property is set
        internal bool IsSetAmazonSThreeAction()
        {
            return this._amazonSThreeAction != null;
        }

        /// <summary>
        /// Gets and sets the property Analysis. 
        /// <para>
        /// The ability to perform analysis-related actions.
        /// </para>
        /// </summary>
        public CapabilityState Analysis
        {
            get { return this._analysis; }
            set { this._analysis = value; }
        }

        // Check to see if Analysis property is set
        internal bool IsSetAnalysis()
        {
            return this._analysis != null;
        }

        /// <summary>
        /// Gets and sets the property AsanaAction. 
        /// <para>
        /// The ability to perform actions using Asana connectors.
        /// </para>
        /// </summary>
        public CapabilityState AsanaAction
        {
            get { return this._asanaAction; }
            set { this._asanaAction = value; }
        }

        // Check to see if AsanaAction property is set
        internal bool IsSetAsanaAction()
        {
            return this._asanaAction != null;
        }

        /// <summary>
        /// Gets and sets the property Automate. 
        /// <para>
        /// The ability to perform automate-related actions.
        /// </para>
        /// </summary>
        public CapabilityState Automate
        {
            get { return this._automate; }
            set { this._automate = value; }
        }

        // Check to see if Automate property is set
        internal bool IsSetAutomate()
        {
            return this._automate != null;
        }

        /// <summary>
        /// Gets and sets the property BambooHRAction. 
        /// <para>
        /// The ability to perform actions using BambooHR connectors.
        /// </para>
        /// </summary>
        public CapabilityState BambooHRAction
        {
            get { return this._bambooHRAction; }
            set { this._bambooHRAction = value; }
        }

        // Check to see if BambooHRAction property is set
        internal bool IsSetBambooHRAction()
        {
            return this._bambooHRAction != null;
        }

        /// <summary>
        /// Gets and sets the property BoxAgentAction. 
        /// <para>
        /// The ability to perform actions using Box Agent connectors.
        /// </para>
        /// </summary>
        public CapabilityState BoxAgentAction
        {
            get { return this._boxAgentAction; }
            set { this._boxAgentAction = value; }
        }

        // Check to see if BoxAgentAction property is set
        internal bool IsSetBoxAgentAction()
        {
            return this._boxAgentAction != null;
        }

        /// <summary>
        /// Gets and sets the property CanvaAgentAction. 
        /// <para>
        /// The ability to perform actions using Canva Agent connectors.
        /// </para>
        /// </summary>
        public CapabilityState CanvaAgentAction
        {
            get { return this._canvaAgentAction; }
            set { this._canvaAgentAction = value; }
        }

        // Check to see if CanvaAgentAction property is set
        internal bool IsSetCanvaAgentAction()
        {
            return this._canvaAgentAction != null;
        }

        /// <summary>
        /// Gets and sets the property ChatAgent. 
        /// <para>
        /// The ability to perform chat-related actions.
        /// </para>
        /// </summary>
        public CapabilityState ChatAgent
        {
            get { return this._chatAgent; }
            set { this._chatAgent = value; }
        }

        // Check to see if ChatAgent property is set
        internal bool IsSetChatAgent()
        {
            return this._chatAgent != null;
        }

        /// <summary>
        /// Gets and sets the property ComprehendAction. 
        /// <para>
        /// The ability to perform actions using Comprehend connectors.
        /// </para>
        /// </summary>
        public CapabilityState ComprehendAction
        {
            get { return this._comprehendAction; }
            set { this._comprehendAction = value; }
        }

        // Check to see if ComprehendAction property is set
        internal bool IsSetComprehendAction()
        {
            return this._comprehendAction != null;
        }

        /// <summary>
        /// Gets and sets the property ComprehendMedicalAction. 
        /// <para>
        /// The ability to perform actions using Comprehend Medical connectors.
        /// </para>
        /// </summary>
        public CapabilityState ComprehendMedicalAction
        {
            get { return this._comprehendMedicalAction; }
            set { this._comprehendMedicalAction = value; }
        }

        // Check to see if ComprehendMedicalAction property is set
        internal bool IsSetComprehendMedicalAction()
        {
            return this._comprehendMedicalAction != null;
        }

        /// <summary>
        /// Gets and sets the property ConfluenceAction. 
        /// <para>
        /// The ability to perform actions using Atlassian Confluence Cloud connectors.
        /// </para>
        /// </summary>
        public CapabilityState ConfluenceAction
        {
            get { return this._confluenceAction; }
            set { this._confluenceAction = value; }
        }

        // Check to see if ConfluenceAction property is set
        internal bool IsSetConfluenceAction()
        {
            return this._confluenceAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateAmazonBedrockARSAction. 
        /// <para>
        /// The ability to create and update Bedrock Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateAmazonBedrockARSAction
        {
            get { return this._createAndUpdateAmazonBedrockARSAction; }
            set { this._createAndUpdateAmazonBedrockARSAction = value; }
        }

        // Check to see if CreateAndUpdateAmazonBedrockARSAction property is set
        internal bool IsSetCreateAndUpdateAmazonBedrockARSAction()
        {
            return this._createAndUpdateAmazonBedrockARSAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateAmazonBedrockFSAction. 
        /// <para>
        /// The ability to create and update Bedrock Runtime actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateAmazonBedrockFSAction
        {
            get { return this._createAndUpdateAmazonBedrockFSAction; }
            set { this._createAndUpdateAmazonBedrockFSAction = value; }
        }

        // Check to see if CreateAndUpdateAmazonBedrockFSAction property is set
        internal bool IsSetCreateAndUpdateAmazonBedrockFSAction()
        {
            return this._createAndUpdateAmazonBedrockFSAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateAmazonBedrockKRSAction. 
        /// <para>
        /// The ability to create and update Bedrock Data Automation Runtime actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateAmazonBedrockKRSAction
        {
            get { return this._createAndUpdateAmazonBedrockKRSAction; }
            set { this._createAndUpdateAmazonBedrockKRSAction = value; }
        }

        // Check to see if CreateAndUpdateAmazonBedrockKRSAction property is set
        internal bool IsSetCreateAndUpdateAmazonBedrockKRSAction()
        {
            return this._createAndUpdateAmazonBedrockKRSAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateAmazonSThreeAction. 
        /// <para>
        /// The ability to create and update Amazon S3 actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateAmazonSThreeAction
        {
            get { return this._createAndUpdateAmazonSThreeAction; }
            set { this._createAndUpdateAmazonSThreeAction = value; }
        }

        // Check to see if CreateAndUpdateAmazonSThreeAction property is set
        internal bool IsSetCreateAndUpdateAmazonSThreeAction()
        {
            return this._createAndUpdateAmazonSThreeAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateAsanaAction. 
        /// <para>
        /// The ability to create and update Asana actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateAsanaAction
        {
            get { return this._createAndUpdateAsanaAction; }
            set { this._createAndUpdateAsanaAction = value; }
        }

        // Check to see if CreateAndUpdateAsanaAction property is set
        internal bool IsSetCreateAndUpdateAsanaAction()
        {
            return this._createAndUpdateAsanaAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateBambooHRAction. 
        /// <para>
        /// The ability to create and update BambooHR actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateBambooHRAction
        {
            get { return this._createAndUpdateBambooHRAction; }
            set { this._createAndUpdateBambooHRAction = value; }
        }

        // Check to see if CreateAndUpdateBambooHRAction property is set
        internal bool IsSetCreateAndUpdateBambooHRAction()
        {
            return this._createAndUpdateBambooHRAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateBoxAgentAction. 
        /// <para>
        /// The ability to create and update Box Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateBoxAgentAction
        {
            get { return this._createAndUpdateBoxAgentAction; }
            set { this._createAndUpdateBoxAgentAction = value; }
        }

        // Check to see if CreateAndUpdateBoxAgentAction property is set
        internal bool IsSetCreateAndUpdateBoxAgentAction()
        {
            return this._createAndUpdateBoxAgentAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateCanvaAgentAction. 
        /// <para>
        /// The ability to create and update Canva Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateCanvaAgentAction
        {
            get { return this._createAndUpdateCanvaAgentAction; }
            set { this._createAndUpdateCanvaAgentAction = value; }
        }

        // Check to see if CreateAndUpdateCanvaAgentAction property is set
        internal bool IsSetCreateAndUpdateCanvaAgentAction()
        {
            return this._createAndUpdateCanvaAgentAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateComprehendAction. 
        /// <para>
        /// The ability to create and update Comprehend actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateComprehendAction
        {
            get { return this._createAndUpdateComprehendAction; }
            set { this._createAndUpdateComprehendAction = value; }
        }

        // Check to see if CreateAndUpdateComprehendAction property is set
        internal bool IsSetCreateAndUpdateComprehendAction()
        {
            return this._createAndUpdateComprehendAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateComprehendMedicalAction. 
        /// <para>
        /// The ability to create and update Comprehend Medical actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateComprehendMedicalAction
        {
            get { return this._createAndUpdateComprehendMedicalAction; }
            set { this._createAndUpdateComprehendMedicalAction = value; }
        }

        // Check to see if CreateAndUpdateComprehendMedicalAction property is set
        internal bool IsSetCreateAndUpdateComprehendMedicalAction()
        {
            return this._createAndUpdateComprehendMedicalAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateConfluenceAction. 
        /// <para>
        /// The ability to create and update Atlassian Confluence Cloud actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateConfluenceAction
        {
            get { return this._createAndUpdateConfluenceAction; }
            set { this._createAndUpdateConfluenceAction = value; }
        }

        // Check to see if CreateAndUpdateConfluenceAction property is set
        internal bool IsSetCreateAndUpdateConfluenceAction()
        {
            return this._createAndUpdateConfluenceAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateDashboardEmailReports. 
        /// <para>
        /// The ability to create and update email reports.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateDashboardEmailReports
        {
            get { return this._createAndUpdateDashboardEmailReports; }
            set { this._createAndUpdateDashboardEmailReports = value; }
        }

        // Check to see if CreateAndUpdateDashboardEmailReports property is set
        internal bool IsSetCreateAndUpdateDashboardEmailReports()
        {
            return this._createAndUpdateDashboardEmailReports != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateDatasets. 
        /// <para>
        /// The ability to create and update datasets.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateDatasets
        {
            get { return this._createAndUpdateDatasets; }
            set { this._createAndUpdateDatasets = value; }
        }

        // Check to see if CreateAndUpdateDatasets property is set
        internal bool IsSetCreateAndUpdateDatasets()
        {
            return this._createAndUpdateDatasets != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateDataSources. 
        /// <para>
        /// The ability to create and update data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateDataSources
        {
            get { return this._createAndUpdateDataSources; }
            set { this._createAndUpdateDataSources = value; }
        }

        // Check to see if CreateAndUpdateDataSources property is set
        internal bool IsSetCreateAndUpdateDataSources()
        {
            return this._createAndUpdateDataSources != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateFactSetAction. 
        /// <para>
        /// The ability to create and update FactSet actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateFactSetAction
        {
            get { return this._createAndUpdateFactSetAction; }
            set { this._createAndUpdateFactSetAction = value; }
        }

        // Check to see if CreateAndUpdateFactSetAction property is set
        internal bool IsSetCreateAndUpdateFactSetAction()
        {
            return this._createAndUpdateFactSetAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateGenericHTTPAction. 
        /// <para>
        /// The ability to create and update REST API connection actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateGenericHTTPAction
        {
            get { return this._createAndUpdateGenericHTTPAction; }
            set { this._createAndUpdateGenericHTTPAction = value; }
        }

        // Check to see if CreateAndUpdateGenericHTTPAction property is set
        internal bool IsSetCreateAndUpdateGenericHTTPAction()
        {
            return this._createAndUpdateGenericHTTPAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateGithubAction. 
        /// <para>
        /// The ability to create and update GitHub actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateGithubAction
        {
            get { return this._createAndUpdateGithubAction; }
            set { this._createAndUpdateGithubAction = value; }
        }

        // Check to see if CreateAndUpdateGithubAction property is set
        internal bool IsSetCreateAndUpdateGithubAction()
        {
            return this._createAndUpdateGithubAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateGoogleCalendarAction. 
        /// <para>
        /// The ability to create and update Google Calendar actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateGoogleCalendarAction
        {
            get { return this._createAndUpdateGoogleCalendarAction; }
            set { this._createAndUpdateGoogleCalendarAction = value; }
        }

        // Check to see if CreateAndUpdateGoogleCalendarAction property is set
        internal bool IsSetCreateAndUpdateGoogleCalendarAction()
        {
            return this._createAndUpdateGoogleCalendarAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateHubspotAction. 
        /// <para>
        /// The ability to create and update Hubspot actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateHubspotAction
        {
            get { return this._createAndUpdateHubspotAction; }
            set { this._createAndUpdateHubspotAction = value; }
        }

        // Check to see if CreateAndUpdateHubspotAction property is set
        internal bool IsSetCreateAndUpdateHubspotAction()
        {
            return this._createAndUpdateHubspotAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateHuggingFaceAction. 
        /// <para>
        /// The ability to create and update HuggingFace actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateHuggingFaceAction
        {
            get { return this._createAndUpdateHuggingFaceAction; }
            set { this._createAndUpdateHuggingFaceAction = value; }
        }

        // Check to see if CreateAndUpdateHuggingFaceAction property is set
        internal bool IsSetCreateAndUpdateHuggingFaceAction()
        {
            return this._createAndUpdateHuggingFaceAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateIntercomAction. 
        /// <para>
        /// The ability to create and update Intercom actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateIntercomAction
        {
            get { return this._createAndUpdateIntercomAction; }
            set { this._createAndUpdateIntercomAction = value; }
        }

        // Check to see if CreateAndUpdateIntercomAction property is set
        internal bool IsSetCreateAndUpdateIntercomAction()
        {
            return this._createAndUpdateIntercomAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateJiraAction. 
        /// <para>
        /// The ability to create and update Jira actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateJiraAction
        {
            get { return this._createAndUpdateJiraAction; }
            set { this._createAndUpdateJiraAction = value; }
        }

        // Check to see if CreateAndUpdateJiraAction property is set
        internal bool IsSetCreateAndUpdateJiraAction()
        {
            return this._createAndUpdateJiraAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateLinearAction. 
        /// <para>
        /// The ability to create and update Linear actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateLinearAction
        {
            get { return this._createAndUpdateLinearAction; }
            set { this._createAndUpdateLinearAction = value; }
        }

        // Check to see if CreateAndUpdateLinearAction property is set
        internal bool IsSetCreateAndUpdateLinearAction()
        {
            return this._createAndUpdateLinearAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateMCPAction. 
        /// <para>
        /// The ability to create and update Model Context Protocol actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateMCPAction
        {
            get { return this._createAndUpdateMCPAction; }
            set { this._createAndUpdateMCPAction = value; }
        }

        // Check to see if CreateAndUpdateMCPAction property is set
        internal bool IsSetCreateAndUpdateMCPAction()
        {
            return this._createAndUpdateMCPAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateMondayAction. 
        /// <para>
        /// The ability to create and update Monday actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateMondayAction
        {
            get { return this._createAndUpdateMondayAction; }
            set { this._createAndUpdateMondayAction = value; }
        }

        // Check to see if CreateAndUpdateMondayAction property is set
        internal bool IsSetCreateAndUpdateMondayAction()
        {
            return this._createAndUpdateMondayAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateMSExchangeAction. 
        /// <para>
        /// The ability to create and update Microsoft Outlook actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateMSExchangeAction
        {
            get { return this._createAndUpdateMSExchangeAction; }
            set { this._createAndUpdateMSExchangeAction = value; }
        }

        // Check to see if CreateAndUpdateMSExchangeAction property is set
        internal bool IsSetCreateAndUpdateMSExchangeAction()
        {
            return this._createAndUpdateMSExchangeAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateMSTeamsAction. 
        /// <para>
        /// The ability to create and update Microsoft Teams actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateMSTeamsAction
        {
            get { return this._createAndUpdateMSTeamsAction; }
            set { this._createAndUpdateMSTeamsAction = value; }
        }

        // Check to see if CreateAndUpdateMSTeamsAction property is set
        internal bool IsSetCreateAndUpdateMSTeamsAction()
        {
            return this._createAndUpdateMSTeamsAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateNewRelicAction. 
        /// <para>
        /// The ability to create and update New Relic actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateNewRelicAction
        {
            get { return this._createAndUpdateNewRelicAction; }
            set { this._createAndUpdateNewRelicAction = value; }
        }

        // Check to see if CreateAndUpdateNewRelicAction property is set
        internal bool IsSetCreateAndUpdateNewRelicAction()
        {
            return this._createAndUpdateNewRelicAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateNotionAction. 
        /// <para>
        /// The ability to create and update Notion actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateNotionAction
        {
            get { return this._createAndUpdateNotionAction; }
            set { this._createAndUpdateNotionAction = value; }
        }

        // Check to see if CreateAndUpdateNotionAction property is set
        internal bool IsSetCreateAndUpdateNotionAction()
        {
            return this._createAndUpdateNotionAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateOneDriveAction. 
        /// <para>
        /// The ability to create and update Microsoft OneDrive actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateOneDriveAction
        {
            get { return this._createAndUpdateOneDriveAction; }
            set { this._createAndUpdateOneDriveAction = value; }
        }

        // Check to see if CreateAndUpdateOneDriveAction property is set
        internal bool IsSetCreateAndUpdateOneDriveAction()
        {
            return this._createAndUpdateOneDriveAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateOpenAPIAction. 
        /// <para>
        /// The ability to create and update OpenAPI Specification actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateOpenAPIAction
        {
            get { return this._createAndUpdateOpenAPIAction; }
            set { this._createAndUpdateOpenAPIAction = value; }
        }

        // Check to see if CreateAndUpdateOpenAPIAction property is set
        internal bool IsSetCreateAndUpdateOpenAPIAction()
        {
            return this._createAndUpdateOpenAPIAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdatePagerDutyAction. 
        /// <para>
        /// The ability to create and update PagerDuty Advance actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdatePagerDutyAction
        {
            get { return this._createAndUpdatePagerDutyAction; }
            set { this._createAndUpdatePagerDutyAction = value; }
        }

        // Check to see if CreateAndUpdatePagerDutyAction property is set
        internal bool IsSetCreateAndUpdatePagerDutyAction()
        {
            return this._createAndUpdatePagerDutyAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateSalesforceAction. 
        /// <para>
        /// The ability to create and update Salesforce actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateSalesforceAction
        {
            get { return this._createAndUpdateSalesforceAction; }
            set { this._createAndUpdateSalesforceAction = value; }
        }

        // Check to see if CreateAndUpdateSalesforceAction property is set
        internal bool IsSetCreateAndUpdateSalesforceAction()
        {
            return this._createAndUpdateSalesforceAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateSandPGlobalEnergyAction. 
        /// <para>
        /// The ability to create and update S&amp;P Global Energy actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateSandPGlobalEnergyAction
        {
            get { return this._createAndUpdateSandPGlobalEnergyAction; }
            set { this._createAndUpdateSandPGlobalEnergyAction = value; }
        }

        // Check to see if CreateAndUpdateSandPGlobalEnergyAction property is set
        internal bool IsSetCreateAndUpdateSandPGlobalEnergyAction()
        {
            return this._createAndUpdateSandPGlobalEnergyAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateSandPGMIAction. 
        /// <para>
        /// The ability to create and update S&amp;P Global Market Intelligence actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateSandPGMIAction
        {
            get { return this._createAndUpdateSandPGMIAction; }
            set { this._createAndUpdateSandPGMIAction = value; }
        }

        // Check to see if CreateAndUpdateSandPGMIAction property is set
        internal bool IsSetCreateAndUpdateSandPGMIAction()
        {
            return this._createAndUpdateSandPGMIAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateSAPBillOfMaterialAction. 
        /// <para>
        /// The ability to create and update SAP Bill of Materials actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateSAPBillOfMaterialAction
        {
            get { return this._createAndUpdateSAPBillOfMaterialAction; }
            set { this._createAndUpdateSAPBillOfMaterialAction = value; }
        }

        // Check to see if CreateAndUpdateSAPBillOfMaterialAction property is set
        internal bool IsSetCreateAndUpdateSAPBillOfMaterialAction()
        {
            return this._createAndUpdateSAPBillOfMaterialAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateSAPBusinessPartnerAction. 
        /// <para>
        /// The ability to create and update SAP Business Partner actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateSAPBusinessPartnerAction
        {
            get { return this._createAndUpdateSAPBusinessPartnerAction; }
            set { this._createAndUpdateSAPBusinessPartnerAction = value; }
        }

        // Check to see if CreateAndUpdateSAPBusinessPartnerAction property is set
        internal bool IsSetCreateAndUpdateSAPBusinessPartnerAction()
        {
            return this._createAndUpdateSAPBusinessPartnerAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateSAPMaterialStockAction. 
        /// <para>
        /// The ability to create and update SAP Material Stock actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateSAPMaterialStockAction
        {
            get { return this._createAndUpdateSAPMaterialStockAction; }
            set { this._createAndUpdateSAPMaterialStockAction = value; }
        }

        // Check to see if CreateAndUpdateSAPMaterialStockAction property is set
        internal bool IsSetCreateAndUpdateSAPMaterialStockAction()
        {
            return this._createAndUpdateSAPMaterialStockAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateSAPPhysicalInventoryAction. 
        /// <para>
        /// The ability to create and update SAP Physical Inventory actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateSAPPhysicalInventoryAction
        {
            get { return this._createAndUpdateSAPPhysicalInventoryAction; }
            set { this._createAndUpdateSAPPhysicalInventoryAction = value; }
        }

        // Check to see if CreateAndUpdateSAPPhysicalInventoryAction property is set
        internal bool IsSetCreateAndUpdateSAPPhysicalInventoryAction()
        {
            return this._createAndUpdateSAPPhysicalInventoryAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateSAPProductMasterDataAction. 
        /// <para>
        /// The ability to create and update SAP Product Master actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateSAPProductMasterDataAction
        {
            get { return this._createAndUpdateSAPProductMasterDataAction; }
            set { this._createAndUpdateSAPProductMasterDataAction = value; }
        }

        // Check to see if CreateAndUpdateSAPProductMasterDataAction property is set
        internal bool IsSetCreateAndUpdateSAPProductMasterDataAction()
        {
            return this._createAndUpdateSAPProductMasterDataAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateServiceNowAction. 
        /// <para>
        /// The ability to create and update ServiceNow actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateServiceNowAction
        {
            get { return this._createAndUpdateServiceNowAction; }
            set { this._createAndUpdateServiceNowAction = value; }
        }

        // Check to see if CreateAndUpdateServiceNowAction property is set
        internal bool IsSetCreateAndUpdateServiceNowAction()
        {
            return this._createAndUpdateServiceNowAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateSharePointAction. 
        /// <para>
        /// The ability to create and update Microsoft SharePoint Online actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateSharePointAction
        {
            get { return this._createAndUpdateSharePointAction; }
            set { this._createAndUpdateSharePointAction = value; }
        }

        // Check to see if CreateAndUpdateSharePointAction property is set
        internal bool IsSetCreateAndUpdateSharePointAction()
        {
            return this._createAndUpdateSharePointAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateSlackAction. 
        /// <para>
        /// The ability to create and update Slack actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateSlackAction
        {
            get { return this._createAndUpdateSlackAction; }
            set { this._createAndUpdateSlackAction = value; }
        }

        // Check to see if CreateAndUpdateSlackAction property is set
        internal bool IsSetCreateAndUpdateSlackAction()
        {
            return this._createAndUpdateSlackAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateSmartsheetAction. 
        /// <para>
        /// The ability to create and update Smartsheet actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateSmartsheetAction
        {
            get { return this._createAndUpdateSmartsheetAction; }
            set { this._createAndUpdateSmartsheetAction = value; }
        }

        // Check to see if CreateAndUpdateSmartsheetAction property is set
        internal bool IsSetCreateAndUpdateSmartsheetAction()
        {
            return this._createAndUpdateSmartsheetAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateTextractAction. 
        /// <para>
        /// The ability to create and update Textract actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateTextractAction
        {
            get { return this._createAndUpdateTextractAction; }
            set { this._createAndUpdateTextractAction = value; }
        }

        // Check to see if CreateAndUpdateTextractAction property is set
        internal bool IsSetCreateAndUpdateTextractAction()
        {
            return this._createAndUpdateTextractAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateThemes. 
        /// <para>
        /// The ability to export to Create and Update themes.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateThemes
        {
            get { return this._createAndUpdateThemes; }
            set { this._createAndUpdateThemes = value; }
        }

        // Check to see if CreateAndUpdateThemes property is set
        internal bool IsSetCreateAndUpdateThemes()
        {
            return this._createAndUpdateThemes != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateThresholdAlerts. 
        /// <para>
        /// The ability to create and update threshold alerts.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateThresholdAlerts
        {
            get { return this._createAndUpdateThresholdAlerts; }
            set { this._createAndUpdateThresholdAlerts = value; }
        }

        // Check to see if CreateAndUpdateThresholdAlerts property is set
        internal bool IsSetCreateAndUpdateThresholdAlerts()
        {
            return this._createAndUpdateThresholdAlerts != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateZendeskAction. 
        /// <para>
        /// The ability to create and update Zendesk actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateZendeskAction
        {
            get { return this._createAndUpdateZendeskAction; }
            set { this._createAndUpdateZendeskAction = value; }
        }

        // Check to see if CreateAndUpdateZendeskAction property is set
        internal bool IsSetCreateAndUpdateZendeskAction()
        {
            return this._createAndUpdateZendeskAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateChatAgents. 
        /// <para>
        /// The ability to create chat agents.
        /// </para>
        /// </summary>
        public CapabilityState CreateChatAgents
        {
            get { return this._createChatAgents; }
            set { this._createChatAgents = value; }
        }

        // Check to see if CreateChatAgents property is set
        internal bool IsSetCreateChatAgents()
        {
            return this._createChatAgents != null;
        }

        /// <summary>
        /// Gets and sets the property CreateSharedFolders. 
        /// <para>
        /// The ability to create shared folders.
        /// </para>
        /// </summary>
        public CapabilityState CreateSharedFolders
        {
            get { return this._createSharedFolders; }
            set { this._createSharedFolders = value; }
        }

        // Check to see if CreateSharedFolders property is set
        internal bool IsSetCreateSharedFolders()
        {
            return this._createSharedFolders != null;
        }

        /// <summary>
        /// Gets and sets the property CreateSPICEDataset. 
        /// <para>
        /// The ability to create a SPICE dataset.
        /// </para>
        /// </summary>
        public CapabilityState CreateSPICEDataset
        {
            get { return this._createSPICEDataset; }
            set { this._createSPICEDataset = value; }
        }

        // Check to see if CreateSPICEDataset property is set
        internal bool IsSetCreateSPICEDataset()
        {
            return this._createSPICEDataset != null;
        }

        /// <summary>
        /// Gets and sets the property Dashboard. 
        /// <para>
        /// The ability to perform dashboard-related actions.
        /// </para>
        /// </summary>
        public CapabilityState Dashboard
        {
            get { return this._dashboard; }
            set { this._dashboard = value; }
        }

        // Check to see if Dashboard property is set
        internal bool IsSetDashboard()
        {
            return this._dashboard != null;
        }

        /// <summary>
        /// Gets and sets the property ExportToCsv. 
        /// <para>
        /// The ability to export to CSV files from the UI.
        /// </para>
        /// </summary>
        public CapabilityState ExportToCsv
        {
            get { return this._exportToCsv; }
            set { this._exportToCsv = value; }
        }

        // Check to see if ExportToCsv property is set
        internal bool IsSetExportToCsv()
        {
            return this._exportToCsv != null;
        }

        /// <summary>
        /// Gets and sets the property ExportToCsvInScheduledReports. 
        /// <para>
        /// The ability to export to CSV files in scheduled email reports.
        /// </para>
        /// </summary>
        public CapabilityState ExportToCsvInScheduledReports
        {
            get { return this._exportToCsvInScheduledReports; }
            set { this._exportToCsvInScheduledReports = value; }
        }

        // Check to see if ExportToCsvInScheduledReports property is set
        internal bool IsSetExportToCsvInScheduledReports()
        {
            return this._exportToCsvInScheduledReports != null;
        }

        /// <summary>
        /// Gets and sets the property ExportToExcel. 
        /// <para>
        /// The ability to export to Excel files from the UI.
        /// </para>
        /// </summary>
        public CapabilityState ExportToExcel
        {
            get { return this._exportToExcel; }
            set { this._exportToExcel = value; }
        }

        // Check to see if ExportToExcel property is set
        internal bool IsSetExportToExcel()
        {
            return this._exportToExcel != null;
        }

        /// <summary>
        /// Gets and sets the property ExportToExcelInScheduledReports. 
        /// <para>
        /// The ability to export to Excel files in scheduled email reports.
        /// </para>
        /// </summary>
        public CapabilityState ExportToExcelInScheduledReports
        {
            get { return this._exportToExcelInScheduledReports; }
            set { this._exportToExcelInScheduledReports = value; }
        }

        // Check to see if ExportToExcelInScheduledReports property is set
        internal bool IsSetExportToExcelInScheduledReports()
        {
            return this._exportToExcelInScheduledReports != null;
        }

        /// <summary>
        /// Gets and sets the property ExportToPdf. 
        /// <para>
        /// The ability to export to PDF files from the UI.
        /// </para>
        /// </summary>
        public CapabilityState ExportToPdf
        {
            get { return this._exportToPdf; }
            set { this._exportToPdf = value; }
        }

        // Check to see if ExportToPdf property is set
        internal bool IsSetExportToPdf()
        {
            return this._exportToPdf != null;
        }

        /// <summary>
        /// Gets and sets the property ExportToPdfInScheduledReports. 
        /// <para>
        /// The ability to export to PDF files in scheduled email reports.
        /// </para>
        /// </summary>
        public CapabilityState ExportToPdfInScheduledReports
        {
            get { return this._exportToPdfInScheduledReports; }
            set { this._exportToPdfInScheduledReports = value; }
        }

        // Check to see if ExportToPdfInScheduledReports property is set
        internal bool IsSetExportToPdfInScheduledReports()
        {
            return this._exportToPdfInScheduledReports != null;
        }

        /// <summary>
        /// Gets and sets the property FactSetAction. 
        /// <para>
        /// The ability to perform actions using FactSet connectors.
        /// </para>
        /// </summary>
        public CapabilityState FactSetAction
        {
            get { return this._factSetAction; }
            set { this._factSetAction = value; }
        }

        // Check to see if FactSetAction property is set
        internal bool IsSetFactSetAction()
        {
            return this._factSetAction != null;
        }

        /// <summary>
        /// Gets and sets the property Flow. 
        /// <para>
        /// The ability to perform flow-related actions.
        /// </para>
        /// </summary>
        public CapabilityState Flow
        {
            get { return this._flow; }
            set { this._flow = value; }
        }

        // Check to see if Flow property is set
        internal bool IsSetFlow()
        {
            return this._flow != null;
        }

        /// <summary>
        /// Gets and sets the property GenericHTTPAction. 
        /// <para>
        /// The ability to perform actions using REST API connection connectors.
        /// </para>
        /// </summary>
        public CapabilityState GenericHTTPAction
        {
            get { return this._genericHTTPAction; }
            set { this._genericHTTPAction = value; }
        }

        // Check to see if GenericHTTPAction property is set
        internal bool IsSetGenericHTTPAction()
        {
            return this._genericHTTPAction != null;
        }

        /// <summary>
        /// Gets and sets the property GithubAction. 
        /// <para>
        /// The ability to perform actions using GitHub connectors.
        /// </para>
        /// </summary>
        public CapabilityState GithubAction
        {
            get { return this._githubAction; }
            set { this._githubAction = value; }
        }

        // Check to see if GithubAction property is set
        internal bool IsSetGithubAction()
        {
            return this._githubAction != null;
        }

        /// <summary>
        /// Gets and sets the property GoogleCalendarAction. 
        /// <para>
        /// The ability to perform actions using Google Calendar connectors.
        /// </para>
        /// </summary>
        public CapabilityState GoogleCalendarAction
        {
            get { return this._googleCalendarAction; }
            set { this._googleCalendarAction = value; }
        }

        // Check to see if GoogleCalendarAction property is set
        internal bool IsSetGoogleCalendarAction()
        {
            return this._googleCalendarAction != null;
        }

        /// <summary>
        /// Gets and sets the property HubspotAction. 
        /// <para>
        /// The ability to perform actions using Hubspot connectors.
        /// </para>
        /// </summary>
        public CapabilityState HubspotAction
        {
            get { return this._hubspotAction; }
            set { this._hubspotAction = value; }
        }

        // Check to see if HubspotAction property is set
        internal bool IsSetHubspotAction()
        {
            return this._hubspotAction != null;
        }

        /// <summary>
        /// Gets and sets the property HuggingFaceAction. 
        /// <para>
        /// The ability to perform actions using HuggingFace connectors.
        /// </para>
        /// </summary>
        public CapabilityState HuggingFaceAction
        {
            get { return this._huggingFaceAction; }
            set { this._huggingFaceAction = value; }
        }

        // Check to see if HuggingFaceAction property is set
        internal bool IsSetHuggingFaceAction()
        {
            return this._huggingFaceAction != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeContentInScheduledReportsEmail. 
        /// <para>
        /// The ability to include content in scheduled email reports.
        /// </para>
        /// </summary>
        public CapabilityState IncludeContentInScheduledReportsEmail
        {
            get { return this._includeContentInScheduledReportsEmail; }
            set { this._includeContentInScheduledReportsEmail = value; }
        }

        // Check to see if IncludeContentInScheduledReportsEmail property is set
        internal bool IsSetIncludeContentInScheduledReportsEmail()
        {
            return this._includeContentInScheduledReportsEmail != null;
        }

        /// <summary>
        /// Gets and sets the property IntercomAction. 
        /// <para>
        /// The ability to perform actions using Intercom connectors.
        /// </para>
        /// </summary>
        public CapabilityState IntercomAction
        {
            get { return this._intercomAction; }
            set { this._intercomAction = value; }
        }

        // Check to see if IntercomAction property is set
        internal bool IsSetIntercomAction()
        {
            return this._intercomAction != null;
        }

        /// <summary>
        /// Gets and sets the property JiraAction. 
        /// <para>
        /// The ability to perform actions using Jira connectors.
        /// </para>
        /// </summary>
        public CapabilityState JiraAction
        {
            get { return this._jiraAction; }
            set { this._jiraAction = value; }
        }

        // Check to see if JiraAction property is set
        internal bool IsSetJiraAction()
        {
            return this._jiraAction != null;
        }

        /// <summary>
        /// Gets and sets the property KnowledgeBase. 
        /// <para>
        /// The ability to use knowledge bases to specify content from external applications.
        /// </para>
        /// </summary>
        public CapabilityState KnowledgeBase
        {
            get { return this._knowledgeBase; }
            set { this._knowledgeBase = value; }
        }

        // Check to see if KnowledgeBase property is set
        internal bool IsSetKnowledgeBase()
        {
            return this._knowledgeBase != null;
        }

        /// <summary>
        /// Gets and sets the property LinearAction. 
        /// <para>
        /// The ability to perform actions using Linear connectors.
        /// </para>
        /// </summary>
        public CapabilityState LinearAction
        {
            get { return this._linearAction; }
            set { this._linearAction = value; }
        }

        // Check to see if LinearAction property is set
        internal bool IsSetLinearAction()
        {
            return this._linearAction != null;
        }

        /// <summary>
        /// Gets and sets the property MCPAction. 
        /// <para>
        /// The ability to perform actions using Model Context Protocol connectors.
        /// </para>
        /// </summary>
        public CapabilityState MCPAction
        {
            get { return this._mcpAction; }
            set { this._mcpAction = value; }
        }

        // Check to see if MCPAction property is set
        internal bool IsSetMCPAction()
        {
            return this._mcpAction != null;
        }

        /// <summary>
        /// Gets and sets the property MondayAction. 
        /// <para>
        /// The ability to perform actions using Monday connectors.
        /// </para>
        /// </summary>
        public CapabilityState MondayAction
        {
            get { return this._mondayAction; }
            set { this._mondayAction = value; }
        }

        // Check to see if MondayAction property is set
        internal bool IsSetMondayAction()
        {
            return this._mondayAction != null;
        }

        /// <summary>
        /// Gets and sets the property MSExchangeAction. 
        /// <para>
        /// The ability to perform actions using Microsoft Outlook connectors.
        /// </para>
        /// </summary>
        public CapabilityState MSExchangeAction
        {
            get { return this._msExchangeAction; }
            set { this._msExchangeAction = value; }
        }

        // Check to see if MSExchangeAction property is set
        internal bool IsSetMSExchangeAction()
        {
            return this._msExchangeAction != null;
        }

        /// <summary>
        /// Gets and sets the property MSTeamsAction. 
        /// <para>
        /// The ability to perform actions using Microsoft Teams connectors.
        /// </para>
        /// </summary>
        public CapabilityState MSTeamsAction
        {
            get { return this._msTeamsAction; }
            set { this._msTeamsAction = value; }
        }

        // Check to see if MSTeamsAction property is set
        internal bool IsSetMSTeamsAction()
        {
            return this._msTeamsAction != null;
        }

        /// <summary>
        /// Gets and sets the property NewRelicAction. 
        /// <para>
        /// The ability to perform actions using New Relic connectors.
        /// </para>
        /// </summary>
        public CapabilityState NewRelicAction
        {
            get { return this._newRelicAction; }
            set { this._newRelicAction = value; }
        }

        // Check to see if NewRelicAction property is set
        internal bool IsSetNewRelicAction()
        {
            return this._newRelicAction != null;
        }

        /// <summary>
        /// Gets and sets the property NotionAction. 
        /// <para>
        /// The ability to perform actions using Notion connectors.
        /// </para>
        /// </summary>
        public CapabilityState NotionAction
        {
            get { return this._notionAction; }
            set { this._notionAction = value; }
        }

        // Check to see if NotionAction property is set
        internal bool IsSetNotionAction()
        {
            return this._notionAction != null;
        }

        /// <summary>
        /// Gets and sets the property OneDriveAction. 
        /// <para>
        /// The ability to perform actions using Microsoft OneDrive connectors.
        /// </para>
        /// </summary>
        public CapabilityState OneDriveAction
        {
            get { return this._oneDriveAction; }
            set { this._oneDriveAction = value; }
        }

        // Check to see if OneDriveAction property is set
        internal bool IsSetOneDriveAction()
        {
            return this._oneDriveAction != null;
        }

        /// <summary>
        /// Gets and sets the property OpenAPIAction. 
        /// <para>
        /// The ability to perform actions using OpenAPI Specification connectors.
        /// </para>
        /// </summary>
        public CapabilityState OpenAPIAction
        {
            get { return this._openAPIAction; }
            set { this._openAPIAction = value; }
        }

        // Check to see if OpenAPIAction property is set
        internal bool IsSetOpenAPIAction()
        {
            return this._openAPIAction != null;
        }

        /// <summary>
        /// Gets and sets the property PagerDutyAction. 
        /// <para>
        /// The ability to perform actions using PagerDuty Advance connectors.
        /// </para>
        /// </summary>
        public CapabilityState PagerDutyAction
        {
            get { return this._pagerDutyAction; }
            set { this._pagerDutyAction = value; }
        }

        // Check to see if PagerDutyAction property is set
        internal bool IsSetPagerDutyAction()
        {
            return this._pagerDutyAction != null;
        }

        /// <summary>
        /// Gets and sets the property PerformFlowUiTask. 
        /// <para>
        /// The ability to use UI Agent step to perform tasks on public websites.
        /// </para>
        /// </summary>
        public CapabilityState PerformFlowUiTask
        {
            get { return this._performFlowUiTask; }
            set { this._performFlowUiTask = value; }
        }

        // Check to see if PerformFlowUiTask property is set
        internal bool IsSetPerformFlowUiTask()
        {
            return this._performFlowUiTask != null;
        }

        /// <summary>
        /// Gets and sets the property PrintReports. 
        /// <para>
        /// The ability to print reports.
        /// </para>
        /// </summary>
        public CapabilityState PrintReports
        {
            get { return this._printReports; }
            set { this._printReports = value; }
        }

        // Check to see if PrintReports property is set
        internal bool IsSetPrintReports()
        {
            return this._printReports != null;
        }

        /// <summary>
        /// Gets and sets the property PublishWithoutApproval. 
        /// <para>
        /// The ability to enable approvals for flow share.
        /// </para>
        /// </summary>
        public CapabilityState PublishWithoutApproval
        {
            get { return this._publishWithoutApproval; }
            set { this._publishWithoutApproval = value; }
        }

        // Check to see if PublishWithoutApproval property is set
        internal bool IsSetPublishWithoutApproval()
        {
            return this._publishWithoutApproval != null;
        }

        /// <summary>
        /// Gets and sets the property RenameSharedFolders. 
        /// <para>
        /// The ability to rename shared folders.
        /// </para>
        /// </summary>
        public CapabilityState RenameSharedFolders
        {
            get { return this._renameSharedFolders; }
            set { this._renameSharedFolders = value; }
        }

        // Check to see if RenameSharedFolders property is set
        internal bool IsSetRenameSharedFolders()
        {
            return this._renameSharedFolders != null;
        }

        /// <summary>
        /// Gets and sets the property Research. 
        /// <para>
        /// The ability to perform research-related actions.
        /// </para>
        /// </summary>
        public CapabilityState Research
        {
            get { return this._research; }
            set { this._research = value; }
        }

        // Check to see if Research property is set
        internal bool IsSetResearch()
        {
            return this._research != null;
        }

        /// <summary>
        /// Gets and sets the property SalesforceAction. 
        /// <para>
        /// The ability to perform actions using Salesforce connectors.
        /// </para>
        /// </summary>
        public CapabilityState SalesforceAction
        {
            get { return this._salesforceAction; }
            set { this._salesforceAction = value; }
        }

        // Check to see if SalesforceAction property is set
        internal bool IsSetSalesforceAction()
        {
            return this._salesforceAction != null;
        }

        /// <summary>
        /// Gets and sets the property SandPGlobalEnergyAction. 
        /// <para>
        /// The ability to perform actions using S&amp;P Global Energy connectors.
        /// </para>
        /// </summary>
        public CapabilityState SandPGlobalEnergyAction
        {
            get { return this._sandPGlobalEnergyAction; }
            set { this._sandPGlobalEnergyAction = value; }
        }

        // Check to see if SandPGlobalEnergyAction property is set
        internal bool IsSetSandPGlobalEnergyAction()
        {
            return this._sandPGlobalEnergyAction != null;
        }

        /// <summary>
        /// Gets and sets the property SandPGMIAction. 
        /// <para>
        /// The ability to perform actions using S&amp;P Global Market Intelligence connectors.
        /// </para>
        /// </summary>
        public CapabilityState SandPGMIAction
        {
            get { return this._sandPGMIAction; }
            set { this._sandPGMIAction = value; }
        }

        // Check to see if SandPGMIAction property is set
        internal bool IsSetSandPGMIAction()
        {
            return this._sandPGMIAction != null;
        }

        /// <summary>
        /// Gets and sets the property SAPBillOfMaterialAction. 
        /// <para>
        /// The ability to perform actions using SAP Bill of Materials connectors.
        /// </para>
        /// </summary>
        public CapabilityState SAPBillOfMaterialAction
        {
            get { return this._sapBillOfMaterialAction; }
            set { this._sapBillOfMaterialAction = value; }
        }

        // Check to see if SAPBillOfMaterialAction property is set
        internal bool IsSetSAPBillOfMaterialAction()
        {
            return this._sapBillOfMaterialAction != null;
        }

        /// <summary>
        /// Gets and sets the property SAPBusinessPartnerAction. 
        /// <para>
        /// The ability to perform actions using SAP Business Partner connectors.
        /// </para>
        /// </summary>
        public CapabilityState SAPBusinessPartnerAction
        {
            get { return this._sapBusinessPartnerAction; }
            set { this._sapBusinessPartnerAction = value; }
        }

        // Check to see if SAPBusinessPartnerAction property is set
        internal bool IsSetSAPBusinessPartnerAction()
        {
            return this._sapBusinessPartnerAction != null;
        }

        /// <summary>
        /// Gets and sets the property SAPMaterialStockAction. 
        /// <para>
        /// The ability to perform actions using SAP Material Stock connectors.
        /// </para>
        /// </summary>
        public CapabilityState SAPMaterialStockAction
        {
            get { return this._sapMaterialStockAction; }
            set { this._sapMaterialStockAction = value; }
        }

        // Check to see if SAPMaterialStockAction property is set
        internal bool IsSetSAPMaterialStockAction()
        {
            return this._sapMaterialStockAction != null;
        }

        /// <summary>
        /// Gets and sets the property SAPPhysicalInventoryAction. 
        /// <para>
        /// The ability to perform actions using SAP Physical Inventory connectors.
        /// </para>
        /// </summary>
        public CapabilityState SAPPhysicalInventoryAction
        {
            get { return this._sapPhysicalInventoryAction; }
            set { this._sapPhysicalInventoryAction = value; }
        }

        // Check to see if SAPPhysicalInventoryAction property is set
        internal bool IsSetSAPPhysicalInventoryAction()
        {
            return this._sapPhysicalInventoryAction != null;
        }

        /// <summary>
        /// Gets and sets the property SAPProductMasterDataAction. 
        /// <para>
        /// The ability to perform actions using SAP Product Master connectors.
        /// </para>
        /// </summary>
        public CapabilityState SAPProductMasterDataAction
        {
            get { return this._sapProductMasterDataAction; }
            set { this._sapProductMasterDataAction = value; }
        }

        // Check to see if SAPProductMasterDataAction property is set
        internal bool IsSetSAPProductMasterDataAction()
        {
            return this._sapProductMasterDataAction != null;
        }

        /// <summary>
        /// Gets and sets the property SelfUpgradeUserRole. 
        /// <para>
        /// The ability to enable users to upgrade their user role.
        /// </para>
        /// </summary>
        public CapabilityState SelfUpgradeUserRole
        {
            get { return this._selfUpgradeUserRole; }
            set { this._selfUpgradeUserRole = value; }
        }

        // Check to see if SelfUpgradeUserRole property is set
        internal bool IsSetSelfUpgradeUserRole()
        {
            return this._selfUpgradeUserRole != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceNowAction. 
        /// <para>
        /// The ability to perform actions using ServiceNow connectors.
        /// </para>
        /// </summary>
        public CapabilityState ServiceNowAction
        {
            get { return this._serviceNowAction; }
            set { this._serviceNowAction = value; }
        }

        // Check to see if ServiceNowAction property is set
        internal bool IsSetServiceNowAction()
        {
            return this._serviceNowAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareAmazonBedrockARSAction. 
        /// <para>
        /// The ability to share Bedrock Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareAmazonBedrockARSAction
        {
            get { return this._shareAmazonBedrockARSAction; }
            set { this._shareAmazonBedrockARSAction = value; }
        }

        // Check to see if ShareAmazonBedrockARSAction property is set
        internal bool IsSetShareAmazonBedrockARSAction()
        {
            return this._shareAmazonBedrockARSAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareAmazonBedrockFSAction. 
        /// <para>
        /// The ability to share Bedrock Runtime actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareAmazonBedrockFSAction
        {
            get { return this._shareAmazonBedrockFSAction; }
            set { this._shareAmazonBedrockFSAction = value; }
        }

        // Check to see if ShareAmazonBedrockFSAction property is set
        internal bool IsSetShareAmazonBedrockFSAction()
        {
            return this._shareAmazonBedrockFSAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareAmazonBedrockKRSAction. 
        /// <para>
        /// The ability to share Bedrock Data Automation Runtime actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareAmazonBedrockKRSAction
        {
            get { return this._shareAmazonBedrockKRSAction; }
            set { this._shareAmazonBedrockKRSAction = value; }
        }

        // Check to see if ShareAmazonBedrockKRSAction property is set
        internal bool IsSetShareAmazonBedrockKRSAction()
        {
            return this._shareAmazonBedrockKRSAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareAmazonSThreeAction. 
        /// <para>
        /// The ability to share Amazon S3 actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareAmazonSThreeAction
        {
            get { return this._shareAmazonSThreeAction; }
            set { this._shareAmazonSThreeAction = value; }
        }

        // Check to see if ShareAmazonSThreeAction property is set
        internal bool IsSetShareAmazonSThreeAction()
        {
            return this._shareAmazonSThreeAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareAnalyses. 
        /// <para>
        /// The ability to share analyses.
        /// </para>
        /// </summary>
        public CapabilityState ShareAnalyses
        {
            get { return this._shareAnalyses; }
            set { this._shareAnalyses = value; }
        }

        // Check to see if ShareAnalyses property is set
        internal bool IsSetShareAnalyses()
        {
            return this._shareAnalyses != null;
        }

        /// <summary>
        /// Gets and sets the property ShareAsanaAction. 
        /// <para>
        /// The ability to share Asana actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareAsanaAction
        {
            get { return this._shareAsanaAction; }
            set { this._shareAsanaAction = value; }
        }

        // Check to see if ShareAsanaAction property is set
        internal bool IsSetShareAsanaAction()
        {
            return this._shareAsanaAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareBambooHRAction. 
        /// <para>
        /// The ability to share BambooHR actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareBambooHRAction
        {
            get { return this._shareBambooHRAction; }
            set { this._shareBambooHRAction = value; }
        }

        // Check to see if ShareBambooHRAction property is set
        internal bool IsSetShareBambooHRAction()
        {
            return this._shareBambooHRAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareBoxAgentAction. 
        /// <para>
        /// The ability to share Box Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareBoxAgentAction
        {
            get { return this._shareBoxAgentAction; }
            set { this._shareBoxAgentAction = value; }
        }

        // Check to see if ShareBoxAgentAction property is set
        internal bool IsSetShareBoxAgentAction()
        {
            return this._shareBoxAgentAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareCanvaAgentAction. 
        /// <para>
        /// The ability to share Canva Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareCanvaAgentAction
        {
            get { return this._shareCanvaAgentAction; }
            set { this._shareCanvaAgentAction = value; }
        }

        // Check to see if ShareCanvaAgentAction property is set
        internal bool IsSetShareCanvaAgentAction()
        {
            return this._shareCanvaAgentAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareComprehendAction. 
        /// <para>
        /// The ability to share Comprehend actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareComprehendAction
        {
            get { return this._shareComprehendAction; }
            set { this._shareComprehendAction = value; }
        }

        // Check to see if ShareComprehendAction property is set
        internal bool IsSetShareComprehendAction()
        {
            return this._shareComprehendAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareComprehendMedicalAction. 
        /// <para>
        /// The ability to share Comprehend Medical actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareComprehendMedicalAction
        {
            get { return this._shareComprehendMedicalAction; }
            set { this._shareComprehendMedicalAction = value; }
        }

        // Check to see if ShareComprehendMedicalAction property is set
        internal bool IsSetShareComprehendMedicalAction()
        {
            return this._shareComprehendMedicalAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareConfluenceAction. 
        /// <para>
        /// The ability to share Atlassian Confluence Cloud actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareConfluenceAction
        {
            get { return this._shareConfluenceAction; }
            set { this._shareConfluenceAction = value; }
        }

        // Check to see if ShareConfluenceAction property is set
        internal bool IsSetShareConfluenceAction()
        {
            return this._shareConfluenceAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareDashboards. 
        /// <para>
        /// The ability to share dashboards.
        /// </para>
        /// </summary>
        public CapabilityState ShareDashboards
        {
            get { return this._shareDashboards; }
            set { this._shareDashboards = value; }
        }

        // Check to see if ShareDashboards property is set
        internal bool IsSetShareDashboards()
        {
            return this._shareDashboards != null;
        }

        /// <summary>
        /// Gets and sets the property ShareDatasets. 
        /// <para>
        /// The ability to share datasets.
        /// </para>
        /// </summary>
        public CapabilityState ShareDatasets
        {
            get { return this._shareDatasets; }
            set { this._shareDatasets = value; }
        }

        // Check to see if ShareDatasets property is set
        internal bool IsSetShareDatasets()
        {
            return this._shareDatasets != null;
        }

        /// <summary>
        /// Gets and sets the property ShareDataSources. 
        /// <para>
        /// The ability to share data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareDataSources
        {
            get { return this._shareDataSources; }
            set { this._shareDataSources = value; }
        }

        // Check to see if ShareDataSources property is set
        internal bool IsSetShareDataSources()
        {
            return this._shareDataSources != null;
        }

        /// <summary>
        /// Gets and sets the property ShareFactSetAction. 
        /// <para>
        /// The ability to share FactSet actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareFactSetAction
        {
            get { return this._shareFactSetAction; }
            set { this._shareFactSetAction = value; }
        }

        // Check to see if ShareFactSetAction property is set
        internal bool IsSetShareFactSetAction()
        {
            return this._shareFactSetAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareGenericHTTPAction. 
        /// <para>
        /// The ability to share REST API connection actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareGenericHTTPAction
        {
            get { return this._shareGenericHTTPAction; }
            set { this._shareGenericHTTPAction = value; }
        }

        // Check to see if ShareGenericHTTPAction property is set
        internal bool IsSetShareGenericHTTPAction()
        {
            return this._shareGenericHTTPAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareGithubAction. 
        /// <para>
        /// The ability to share GitHub actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareGithubAction
        {
            get { return this._shareGithubAction; }
            set { this._shareGithubAction = value; }
        }

        // Check to see if ShareGithubAction property is set
        internal bool IsSetShareGithubAction()
        {
            return this._shareGithubAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareGoogleCalendarAction. 
        /// <para>
        /// The ability to share Google Calendar actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareGoogleCalendarAction
        {
            get { return this._shareGoogleCalendarAction; }
            set { this._shareGoogleCalendarAction = value; }
        }

        // Check to see if ShareGoogleCalendarAction property is set
        internal bool IsSetShareGoogleCalendarAction()
        {
            return this._shareGoogleCalendarAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareHubspotAction. 
        /// <para>
        /// The ability to share Hubspot actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareHubspotAction
        {
            get { return this._shareHubspotAction; }
            set { this._shareHubspotAction = value; }
        }

        // Check to see if ShareHubspotAction property is set
        internal bool IsSetShareHubspotAction()
        {
            return this._shareHubspotAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareHuggingFaceAction. 
        /// <para>
        /// The ability to share HuggingFace actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareHuggingFaceAction
        {
            get { return this._shareHuggingFaceAction; }
            set { this._shareHuggingFaceAction = value; }
        }

        // Check to see if ShareHuggingFaceAction property is set
        internal bool IsSetShareHuggingFaceAction()
        {
            return this._shareHuggingFaceAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareIntercomAction. 
        /// <para>
        /// The ability to share Intercom actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareIntercomAction
        {
            get { return this._shareIntercomAction; }
            set { this._shareIntercomAction = value; }
        }

        // Check to see if ShareIntercomAction property is set
        internal bool IsSetShareIntercomAction()
        {
            return this._shareIntercomAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareJiraAction. 
        /// <para>
        /// The ability to share Jira actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareJiraAction
        {
            get { return this._shareJiraAction; }
            set { this._shareJiraAction = value; }
        }

        // Check to see if ShareJiraAction property is set
        internal bool IsSetShareJiraAction()
        {
            return this._shareJiraAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareLinearAction. 
        /// <para>
        /// The ability to share Linear actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareLinearAction
        {
            get { return this._shareLinearAction; }
            set { this._shareLinearAction = value; }
        }

        // Check to see if ShareLinearAction property is set
        internal bool IsSetShareLinearAction()
        {
            return this._shareLinearAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareMCPAction. 
        /// <para>
        /// The ability to share Model Context Protocol actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareMCPAction
        {
            get { return this._shareMCPAction; }
            set { this._shareMCPAction = value; }
        }

        // Check to see if ShareMCPAction property is set
        internal bool IsSetShareMCPAction()
        {
            return this._shareMCPAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareMondayAction. 
        /// <para>
        /// The ability to share Monday actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareMondayAction
        {
            get { return this._shareMondayAction; }
            set { this._shareMondayAction = value; }
        }

        // Check to see if ShareMondayAction property is set
        internal bool IsSetShareMondayAction()
        {
            return this._shareMondayAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareMSExchangeAction. 
        /// <para>
        /// The ability to share Microsoft Outlook actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareMSExchangeAction
        {
            get { return this._shareMSExchangeAction; }
            set { this._shareMSExchangeAction = value; }
        }

        // Check to see if ShareMSExchangeAction property is set
        internal bool IsSetShareMSExchangeAction()
        {
            return this._shareMSExchangeAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareMSTeamsAction. 
        /// <para>
        /// The ability to share Microsoft Teams actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareMSTeamsAction
        {
            get { return this._shareMSTeamsAction; }
            set { this._shareMSTeamsAction = value; }
        }

        // Check to see if ShareMSTeamsAction property is set
        internal bool IsSetShareMSTeamsAction()
        {
            return this._shareMSTeamsAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareNewRelicAction. 
        /// <para>
        /// The ability to share New Relic actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareNewRelicAction
        {
            get { return this._shareNewRelicAction; }
            set { this._shareNewRelicAction = value; }
        }

        // Check to see if ShareNewRelicAction property is set
        internal bool IsSetShareNewRelicAction()
        {
            return this._shareNewRelicAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareNotionAction. 
        /// <para>
        /// The ability to share Notion actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareNotionAction
        {
            get { return this._shareNotionAction; }
            set { this._shareNotionAction = value; }
        }

        // Check to see if ShareNotionAction property is set
        internal bool IsSetShareNotionAction()
        {
            return this._shareNotionAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareOneDriveAction. 
        /// <para>
        /// The ability to share Microsoft OneDrive actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareOneDriveAction
        {
            get { return this._shareOneDriveAction; }
            set { this._shareOneDriveAction = value; }
        }

        // Check to see if ShareOneDriveAction property is set
        internal bool IsSetShareOneDriveAction()
        {
            return this._shareOneDriveAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareOpenAPIAction. 
        /// <para>
        /// The ability to share OpenAPI Specification actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareOpenAPIAction
        {
            get { return this._shareOpenAPIAction; }
            set { this._shareOpenAPIAction = value; }
        }

        // Check to see if ShareOpenAPIAction property is set
        internal bool IsSetShareOpenAPIAction()
        {
            return this._shareOpenAPIAction != null;
        }

        /// <summary>
        /// Gets and sets the property SharePagerDutyAction. 
        /// <para>
        /// The ability to share PagerDuty Advance actions.
        /// </para>
        /// </summary>
        public CapabilityState SharePagerDutyAction
        {
            get { return this._sharePagerDutyAction; }
            set { this._sharePagerDutyAction = value; }
        }

        // Check to see if SharePagerDutyAction property is set
        internal bool IsSetSharePagerDutyAction()
        {
            return this._sharePagerDutyAction != null;
        }

        /// <summary>
        /// Gets and sets the property SharePointAction. 
        /// <para>
        /// The ability to perform actions using Microsoft SharePoint Online connectors.
        /// </para>
        /// </summary>
        public CapabilityState SharePointAction
        {
            get { return this._sharePointAction; }
            set { this._sharePointAction = value; }
        }

        // Check to see if SharePointAction property is set
        internal bool IsSetSharePointAction()
        {
            return this._sharePointAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareSalesforceAction. 
        /// <para>
        /// The ability to share Salesforce actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareSalesforceAction
        {
            get { return this._shareSalesforceAction; }
            set { this._shareSalesforceAction = value; }
        }

        // Check to see if ShareSalesforceAction property is set
        internal bool IsSetShareSalesforceAction()
        {
            return this._shareSalesforceAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareSandPGlobalEnergyAction. 
        /// <para>
        /// The ability to share S&amp;P Global Energy actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareSandPGlobalEnergyAction
        {
            get { return this._shareSandPGlobalEnergyAction; }
            set { this._shareSandPGlobalEnergyAction = value; }
        }

        // Check to see if ShareSandPGlobalEnergyAction property is set
        internal bool IsSetShareSandPGlobalEnergyAction()
        {
            return this._shareSandPGlobalEnergyAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareSandPGMIAction. 
        /// <para>
        /// The ability to share S&amp;P Global Market Intelligence actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareSandPGMIAction
        {
            get { return this._shareSandPGMIAction; }
            set { this._shareSandPGMIAction = value; }
        }

        // Check to see if ShareSandPGMIAction property is set
        internal bool IsSetShareSandPGMIAction()
        {
            return this._shareSandPGMIAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareSAPBillOfMaterialAction. 
        /// <para>
        /// The ability to share SAP Bill of Materials actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareSAPBillOfMaterialAction
        {
            get { return this._shareSAPBillOfMaterialAction; }
            set { this._shareSAPBillOfMaterialAction = value; }
        }

        // Check to see if ShareSAPBillOfMaterialAction property is set
        internal bool IsSetShareSAPBillOfMaterialAction()
        {
            return this._shareSAPBillOfMaterialAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareSAPBusinessPartnerAction. 
        /// <para>
        /// The ability to share SAP Business Partner actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareSAPBusinessPartnerAction
        {
            get { return this._shareSAPBusinessPartnerAction; }
            set { this._shareSAPBusinessPartnerAction = value; }
        }

        // Check to see if ShareSAPBusinessPartnerAction property is set
        internal bool IsSetShareSAPBusinessPartnerAction()
        {
            return this._shareSAPBusinessPartnerAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareSAPMaterialStockAction. 
        /// <para>
        /// The ability to share SAP Material Stock actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareSAPMaterialStockAction
        {
            get { return this._shareSAPMaterialStockAction; }
            set { this._shareSAPMaterialStockAction = value; }
        }

        // Check to see if ShareSAPMaterialStockAction property is set
        internal bool IsSetShareSAPMaterialStockAction()
        {
            return this._shareSAPMaterialStockAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareSAPPhysicalInventoryAction. 
        /// <para>
        /// The ability to share SAP Physical Inventory actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareSAPPhysicalInventoryAction
        {
            get { return this._shareSAPPhysicalInventoryAction; }
            set { this._shareSAPPhysicalInventoryAction = value; }
        }

        // Check to see if ShareSAPPhysicalInventoryAction property is set
        internal bool IsSetShareSAPPhysicalInventoryAction()
        {
            return this._shareSAPPhysicalInventoryAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareSAPProductMasterDataAction. 
        /// <para>
        /// The ability to share SAP Product Master actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareSAPProductMasterDataAction
        {
            get { return this._shareSAPProductMasterDataAction; }
            set { this._shareSAPProductMasterDataAction = value; }
        }

        // Check to see if ShareSAPProductMasterDataAction property is set
        internal bool IsSetShareSAPProductMasterDataAction()
        {
            return this._shareSAPProductMasterDataAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareServiceNowAction. 
        /// <para>
        /// The ability to share ServiceNow actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareServiceNowAction
        {
            get { return this._shareServiceNowAction; }
            set { this._shareServiceNowAction = value; }
        }

        // Check to see if ShareServiceNowAction property is set
        internal bool IsSetShareServiceNowAction()
        {
            return this._shareServiceNowAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareSharePointAction. 
        /// <para>
        /// The ability to share Microsoft SharePoint Online actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareSharePointAction
        {
            get { return this._shareSharePointAction; }
            set { this._shareSharePointAction = value; }
        }

        // Check to see if ShareSharePointAction property is set
        internal bool IsSetShareSharePointAction()
        {
            return this._shareSharePointAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareSlackAction. 
        /// <para>
        /// The ability to share Slack actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareSlackAction
        {
            get { return this._shareSlackAction; }
            set { this._shareSlackAction = value; }
        }

        // Check to see if ShareSlackAction property is set
        internal bool IsSetShareSlackAction()
        {
            return this._shareSlackAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareSmartsheetAction. 
        /// <para>
        /// The ability to share Smartsheet actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareSmartsheetAction
        {
            get { return this._shareSmartsheetAction; }
            set { this._shareSmartsheetAction = value; }
        }

        // Check to see if ShareSmartsheetAction property is set
        internal bool IsSetShareSmartsheetAction()
        {
            return this._shareSmartsheetAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareTextractAction. 
        /// <para>
        /// The ability to share Textract actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareTextractAction
        {
            get { return this._shareTextractAction; }
            set { this._shareTextractAction = value; }
        }

        // Check to see if ShareTextractAction property is set
        internal bool IsSetShareTextractAction()
        {
            return this._shareTextractAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareZendeskAction. 
        /// <para>
        /// The ability to share Zendesk actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareZendeskAction
        {
            get { return this._shareZendeskAction; }
            set { this._shareZendeskAction = value; }
        }

        // Check to see if ShareZendeskAction property is set
        internal bool IsSetShareZendeskAction()
        {
            return this._shareZendeskAction != null;
        }

        /// <summary>
        /// Gets and sets the property SlackAction. 
        /// <para>
        /// The ability to perform actions using Slack connectors.
        /// </para>
        /// </summary>
        public CapabilityState SlackAction
        {
            get { return this._slackAction; }
            set { this._slackAction = value; }
        }

        // Check to see if SlackAction property is set
        internal bool IsSetSlackAction()
        {
            return this._slackAction != null;
        }

        /// <summary>
        /// Gets and sets the property SmartsheetAction. 
        /// <para>
        /// The ability to perform actions using Smartsheet connectors.
        /// </para>
        /// </summary>
        public CapabilityState SmartsheetAction
        {
            get { return this._smartsheetAction; }
            set { this._smartsheetAction = value; }
        }

        // Check to see if SmartsheetAction property is set
        internal bool IsSetSmartsheetAction()
        {
            return this._smartsheetAction != null;
        }

        /// <summary>
        /// Gets and sets the property Space. 
        /// <para>
        /// The ability to perform space-related actions.
        /// </para>
        /// </summary>
        public CapabilityState Space
        {
            get { return this._space; }
            set { this._space = value; }
        }

        // Check to see if Space property is set
        internal bool IsSetSpace()
        {
            return this._space != null;
        }

        /// <summary>
        /// Gets and sets the property SubscribeDashboardEmailReports. 
        /// <para>
        /// The ability to subscribe to email reports.
        /// </para>
        /// </summary>
        public CapabilityState SubscribeDashboardEmailReports
        {
            get { return this._subscribeDashboardEmailReports; }
            set { this._subscribeDashboardEmailReports = value; }
        }

        // Check to see if SubscribeDashboardEmailReports property is set
        internal bool IsSetSubscribeDashboardEmailReports()
        {
            return this._subscribeDashboardEmailReports != null;
        }

        /// <summary>
        /// Gets and sets the property TextractAction. 
        /// <para>
        /// The ability to perform actions using Textract connectors.
        /// </para>
        /// </summary>
        public CapabilityState TextractAction
        {
            get { return this._textractAction; }
            set { this._textractAction = value; }
        }

        // Check to see if TextractAction property is set
        internal bool IsSetTextractAction()
        {
            return this._textractAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseAgentWebSearch. 
        /// <para>
        /// The ability to use internet to enhance results in Chat Agents, Flows, and Quick Research.
        /// Web search queries will be processed securely in an Amazon Web Services region <c>us-east-1</c>.
        /// </para>
        /// </summary>
        public CapabilityState UseAgentWebSearch
        {
            get { return this._useAgentWebSearch; }
            set { this._useAgentWebSearch = value; }
        }

        // Check to see if UseAgentWebSearch property is set
        internal bool IsSetUseAgentWebSearch()
        {
            return this._useAgentWebSearch != null;
        }

        /// <summary>
        /// Gets and sets the property UseAmazonBedrockARSAction. 
        /// <para>
        /// The ability to use Bedrock Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState UseAmazonBedrockARSAction
        {
            get { return this._useAmazonBedrockARSAction; }
            set { this._useAmazonBedrockARSAction = value; }
        }

        // Check to see if UseAmazonBedrockARSAction property is set
        internal bool IsSetUseAmazonBedrockARSAction()
        {
            return this._useAmazonBedrockARSAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseAmazonBedrockFSAction. 
        /// <para>
        /// The ability to use Bedrock Runtime actions.
        /// </para>
        /// </summary>
        public CapabilityState UseAmazonBedrockFSAction
        {
            get { return this._useAmazonBedrockFSAction; }
            set { this._useAmazonBedrockFSAction = value; }
        }

        // Check to see if UseAmazonBedrockFSAction property is set
        internal bool IsSetUseAmazonBedrockFSAction()
        {
            return this._useAmazonBedrockFSAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseAmazonBedrockKRSAction. 
        /// <para>
        /// The ability to use Bedrock Data Automation Runtime actions.
        /// </para>
        /// </summary>
        public CapabilityState UseAmazonBedrockKRSAction
        {
            get { return this._useAmazonBedrockKRSAction; }
            set { this._useAmazonBedrockKRSAction = value; }
        }

        // Check to see if UseAmazonBedrockKRSAction property is set
        internal bool IsSetUseAmazonBedrockKRSAction()
        {
            return this._useAmazonBedrockKRSAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseAmazonSThreeAction. 
        /// <para>
        /// The ability to use Amazon S3 actions.
        /// </para>
        /// </summary>
        public CapabilityState UseAmazonSThreeAction
        {
            get { return this._useAmazonSThreeAction; }
            set { this._useAmazonSThreeAction = value; }
        }

        // Check to see if UseAmazonSThreeAction property is set
        internal bool IsSetUseAmazonSThreeAction()
        {
            return this._useAmazonSThreeAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseAsanaAction. 
        /// <para>
        /// The ability to use Asana actions.
        /// </para>
        /// </summary>
        public CapabilityState UseAsanaAction
        {
            get { return this._useAsanaAction; }
            set { this._useAsanaAction = value; }
        }

        // Check to see if UseAsanaAction property is set
        internal bool IsSetUseAsanaAction()
        {
            return this._useAsanaAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseBambooHRAction. 
        /// <para>
        /// The ability to use BambooHR actions.
        /// </para>
        /// </summary>
        public CapabilityState UseBambooHRAction
        {
            get { return this._useBambooHRAction; }
            set { this._useBambooHRAction = value; }
        }

        // Check to see if UseBambooHRAction property is set
        internal bool IsSetUseBambooHRAction()
        {
            return this._useBambooHRAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseBedrockModels. 
        /// <para>
        /// The ability to use Bedrock models for general knowledge step in flows.
        /// </para>
        /// </summary>
        public CapabilityState UseBedrockModels
        {
            get { return this._useBedrockModels; }
            set { this._useBedrockModels = value; }
        }

        // Check to see if UseBedrockModels property is set
        internal bool IsSetUseBedrockModels()
        {
            return this._useBedrockModels != null;
        }

        /// <summary>
        /// Gets and sets the property UseBoxAgentAction. 
        /// <para>
        /// The ability to use Box Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState UseBoxAgentAction
        {
            get { return this._useBoxAgentAction; }
            set { this._useBoxAgentAction = value; }
        }

        // Check to see if UseBoxAgentAction property is set
        internal bool IsSetUseBoxAgentAction()
        {
            return this._useBoxAgentAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseCanvaAgentAction. 
        /// <para>
        /// The ability to use Canva Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState UseCanvaAgentAction
        {
            get { return this._useCanvaAgentAction; }
            set { this._useCanvaAgentAction = value; }
        }

        // Check to see if UseCanvaAgentAction property is set
        internal bool IsSetUseCanvaAgentAction()
        {
            return this._useCanvaAgentAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseComprehendAction. 
        /// <para>
        /// The ability to use Comprehend actions.
        /// </para>
        /// </summary>
        public CapabilityState UseComprehendAction
        {
            get { return this._useComprehendAction; }
            set { this._useComprehendAction = value; }
        }

        // Check to see if UseComprehendAction property is set
        internal bool IsSetUseComprehendAction()
        {
            return this._useComprehendAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseComprehendMedicalAction. 
        /// <para>
        /// The ability to use Comprehend Medical actions.
        /// </para>
        /// </summary>
        public CapabilityState UseComprehendMedicalAction
        {
            get { return this._useComprehendMedicalAction; }
            set { this._useComprehendMedicalAction = value; }
        }

        // Check to see if UseComprehendMedicalAction property is set
        internal bool IsSetUseComprehendMedicalAction()
        {
            return this._useComprehendMedicalAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseConfluenceAction. 
        /// <para>
        /// The ability to use Atlassian Confluence Cloud actions.
        /// </para>
        /// </summary>
        public CapabilityState UseConfluenceAction
        {
            get { return this._useConfluenceAction; }
            set { this._useConfluenceAction = value; }
        }

        // Check to see if UseConfluenceAction property is set
        internal bool IsSetUseConfluenceAction()
        {
            return this._useConfluenceAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseFactSetAction. 
        /// <para>
        /// The ability to use FactSet actions.
        /// </para>
        /// </summary>
        public CapabilityState UseFactSetAction
        {
            get { return this._useFactSetAction; }
            set { this._useFactSetAction = value; }
        }

        // Check to see if UseFactSetAction property is set
        internal bool IsSetUseFactSetAction()
        {
            return this._useFactSetAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseGenericHTTPAction. 
        /// <para>
        /// The ability to use REST API connection actions.
        /// </para>
        /// </summary>
        public CapabilityState UseGenericHTTPAction
        {
            get { return this._useGenericHTTPAction; }
            set { this._useGenericHTTPAction = value; }
        }

        // Check to see if UseGenericHTTPAction property is set
        internal bool IsSetUseGenericHTTPAction()
        {
            return this._useGenericHTTPAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseGithubAction. 
        /// <para>
        /// The ability to use GitHub actions.
        /// </para>
        /// </summary>
        public CapabilityState UseGithubAction
        {
            get { return this._useGithubAction; }
            set { this._useGithubAction = value; }
        }

        // Check to see if UseGithubAction property is set
        internal bool IsSetUseGithubAction()
        {
            return this._useGithubAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseGoogleCalendarAction. 
        /// <para>
        /// The ability to use Google Calendar actions.
        /// </para>
        /// </summary>
        public CapabilityState UseGoogleCalendarAction
        {
            get { return this._useGoogleCalendarAction; }
            set { this._useGoogleCalendarAction = value; }
        }

        // Check to see if UseGoogleCalendarAction property is set
        internal bool IsSetUseGoogleCalendarAction()
        {
            return this._useGoogleCalendarAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseHubspotAction. 
        /// <para>
        /// The ability to use Hubspot actions.
        /// </para>
        /// </summary>
        public CapabilityState UseHubspotAction
        {
            get { return this._useHubspotAction; }
            set { this._useHubspotAction = value; }
        }

        // Check to see if UseHubspotAction property is set
        internal bool IsSetUseHubspotAction()
        {
            return this._useHubspotAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseHuggingFaceAction. 
        /// <para>
        /// The ability to use HuggingFace actions.
        /// </para>
        /// </summary>
        public CapabilityState UseHuggingFaceAction
        {
            get { return this._useHuggingFaceAction; }
            set { this._useHuggingFaceAction = value; }
        }

        // Check to see if UseHuggingFaceAction property is set
        internal bool IsSetUseHuggingFaceAction()
        {
            return this._useHuggingFaceAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseIntercomAction. 
        /// <para>
        /// The ability to use Intercom actions.
        /// </para>
        /// </summary>
        public CapabilityState UseIntercomAction
        {
            get { return this._useIntercomAction; }
            set { this._useIntercomAction = value; }
        }

        // Check to see if UseIntercomAction property is set
        internal bool IsSetUseIntercomAction()
        {
            return this._useIntercomAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseJiraAction. 
        /// <para>
        /// The ability to use Jira actions.
        /// </para>
        /// </summary>
        public CapabilityState UseJiraAction
        {
            get { return this._useJiraAction; }
            set { this._useJiraAction = value; }
        }

        // Check to see if UseJiraAction property is set
        internal bool IsSetUseJiraAction()
        {
            return this._useJiraAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseLinearAction. 
        /// <para>
        /// The ability to use Linear actions.
        /// </para>
        /// </summary>
        public CapabilityState UseLinearAction
        {
            get { return this._useLinearAction; }
            set { this._useLinearAction = value; }
        }

        // Check to see if UseLinearAction property is set
        internal bool IsSetUseLinearAction()
        {
            return this._useLinearAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseMCPAction. 
        /// <para>
        /// The ability to use Model Context Protocol actions.
        /// </para>
        /// </summary>
        public CapabilityState UseMCPAction
        {
            get { return this._useMCPAction; }
            set { this._useMCPAction = value; }
        }

        // Check to see if UseMCPAction property is set
        internal bool IsSetUseMCPAction()
        {
            return this._useMCPAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseMondayAction. 
        /// <para>
        /// The ability to use Monday actions.
        /// </para>
        /// </summary>
        public CapabilityState UseMondayAction
        {
            get { return this._useMondayAction; }
            set { this._useMondayAction = value; }
        }

        // Check to see if UseMondayAction property is set
        internal bool IsSetUseMondayAction()
        {
            return this._useMondayAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseMSExchangeAction. 
        /// <para>
        /// The ability to use Microsoft Outlook actions.
        /// </para>
        /// </summary>
        public CapabilityState UseMSExchangeAction
        {
            get { return this._useMSExchangeAction; }
            set { this._useMSExchangeAction = value; }
        }

        // Check to see if UseMSExchangeAction property is set
        internal bool IsSetUseMSExchangeAction()
        {
            return this._useMSExchangeAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseMSTeamsAction. 
        /// <para>
        /// The ability to use Microsoft Teams actions.
        /// </para>
        /// </summary>
        public CapabilityState UseMSTeamsAction
        {
            get { return this._useMSTeamsAction; }
            set { this._useMSTeamsAction = value; }
        }

        // Check to see if UseMSTeamsAction property is set
        internal bool IsSetUseMSTeamsAction()
        {
            return this._useMSTeamsAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseNewRelicAction. 
        /// <para>
        /// The ability to use New Relic actions.
        /// </para>
        /// </summary>
        public CapabilityState UseNewRelicAction
        {
            get { return this._useNewRelicAction; }
            set { this._useNewRelicAction = value; }
        }

        // Check to see if UseNewRelicAction property is set
        internal bool IsSetUseNewRelicAction()
        {
            return this._useNewRelicAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseNotionAction. 
        /// <para>
        /// The ability to use Notion actions.
        /// </para>
        /// </summary>
        public CapabilityState UseNotionAction
        {
            get { return this._useNotionAction; }
            set { this._useNotionAction = value; }
        }

        // Check to see if UseNotionAction property is set
        internal bool IsSetUseNotionAction()
        {
            return this._useNotionAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseOneDriveAction. 
        /// <para>
        /// The ability to use Microsoft OneDrive actions.
        /// </para>
        /// </summary>
        public CapabilityState UseOneDriveAction
        {
            get { return this._useOneDriveAction; }
            set { this._useOneDriveAction = value; }
        }

        // Check to see if UseOneDriveAction property is set
        internal bool IsSetUseOneDriveAction()
        {
            return this._useOneDriveAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseOpenAPIAction. 
        /// <para>
        /// The ability to use OpenAPI Specification actions.
        /// </para>
        /// </summary>
        public CapabilityState UseOpenAPIAction
        {
            get { return this._useOpenAPIAction; }
            set { this._useOpenAPIAction = value; }
        }

        // Check to see if UseOpenAPIAction property is set
        internal bool IsSetUseOpenAPIAction()
        {
            return this._useOpenAPIAction != null;
        }

        /// <summary>
        /// Gets and sets the property UsePagerDutyAction. 
        /// <para>
        /// The ability to use PagerDuty Advance actions.
        /// </para>
        /// </summary>
        public CapabilityState UsePagerDutyAction
        {
            get { return this._usePagerDutyAction; }
            set { this._usePagerDutyAction = value; }
        }

        // Check to see if UsePagerDutyAction property is set
        internal bool IsSetUsePagerDutyAction()
        {
            return this._usePagerDutyAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseSalesforceAction. 
        /// <para>
        /// The ability to use Salesforce actions.
        /// </para>
        /// </summary>
        public CapabilityState UseSalesforceAction
        {
            get { return this._useSalesforceAction; }
            set { this._useSalesforceAction = value; }
        }

        // Check to see if UseSalesforceAction property is set
        internal bool IsSetUseSalesforceAction()
        {
            return this._useSalesforceAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseSandPGlobalEnergyAction. 
        /// <para>
        /// The ability to use S&amp;P Global Energy actions.
        /// </para>
        /// </summary>
        public CapabilityState UseSandPGlobalEnergyAction
        {
            get { return this._useSandPGlobalEnergyAction; }
            set { this._useSandPGlobalEnergyAction = value; }
        }

        // Check to see if UseSandPGlobalEnergyAction property is set
        internal bool IsSetUseSandPGlobalEnergyAction()
        {
            return this._useSandPGlobalEnergyAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseSandPGMIAction. 
        /// <para>
        /// The ability to use S&amp;P Global Market Intelligence actions.
        /// </para>
        /// </summary>
        public CapabilityState UseSandPGMIAction
        {
            get { return this._useSandPGMIAction; }
            set { this._useSandPGMIAction = value; }
        }

        // Check to see if UseSandPGMIAction property is set
        internal bool IsSetUseSandPGMIAction()
        {
            return this._useSandPGMIAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseSAPBillOfMaterialAction. 
        /// <para>
        /// The ability to use SAP Bill of Materials actions.
        /// </para>
        /// </summary>
        public CapabilityState UseSAPBillOfMaterialAction
        {
            get { return this._useSAPBillOfMaterialAction; }
            set { this._useSAPBillOfMaterialAction = value; }
        }

        // Check to see if UseSAPBillOfMaterialAction property is set
        internal bool IsSetUseSAPBillOfMaterialAction()
        {
            return this._useSAPBillOfMaterialAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseSAPBusinessPartnerAction. 
        /// <para>
        /// The ability to use SAP Business Partner actions.
        /// </para>
        /// </summary>
        public CapabilityState UseSAPBusinessPartnerAction
        {
            get { return this._useSAPBusinessPartnerAction; }
            set { this._useSAPBusinessPartnerAction = value; }
        }

        // Check to see if UseSAPBusinessPartnerAction property is set
        internal bool IsSetUseSAPBusinessPartnerAction()
        {
            return this._useSAPBusinessPartnerAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseSAPMaterialStockAction. 
        /// <para>
        /// The ability to use SAP Material Stock actions.
        /// </para>
        /// </summary>
        public CapabilityState UseSAPMaterialStockAction
        {
            get { return this._useSAPMaterialStockAction; }
            set { this._useSAPMaterialStockAction = value; }
        }

        // Check to see if UseSAPMaterialStockAction property is set
        internal bool IsSetUseSAPMaterialStockAction()
        {
            return this._useSAPMaterialStockAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseSAPPhysicalInventoryAction. 
        /// <para>
        /// The ability to use SAP Physical Inventory actions.
        /// </para>
        /// </summary>
        public CapabilityState UseSAPPhysicalInventoryAction
        {
            get { return this._useSAPPhysicalInventoryAction; }
            set { this._useSAPPhysicalInventoryAction = value; }
        }

        // Check to see if UseSAPPhysicalInventoryAction property is set
        internal bool IsSetUseSAPPhysicalInventoryAction()
        {
            return this._useSAPPhysicalInventoryAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseSAPProductMasterDataAction. 
        /// <para>
        /// The ability to use SAP Product Master actions.
        /// </para>
        /// </summary>
        public CapabilityState UseSAPProductMasterDataAction
        {
            get { return this._useSAPProductMasterDataAction; }
            set { this._useSAPProductMasterDataAction = value; }
        }

        // Check to see if UseSAPProductMasterDataAction property is set
        internal bool IsSetUseSAPProductMasterDataAction()
        {
            return this._useSAPProductMasterDataAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseServiceNowAction. 
        /// <para>
        /// The ability to use ServiceNow actions.
        /// </para>
        /// </summary>
        public CapabilityState UseServiceNowAction
        {
            get { return this._useServiceNowAction; }
            set { this._useServiceNowAction = value; }
        }

        // Check to see if UseServiceNowAction property is set
        internal bool IsSetUseServiceNowAction()
        {
            return this._useServiceNowAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseSharePointAction. 
        /// <para>
        /// The ability to use Microsoft SharePoint Online actions.
        /// </para>
        /// </summary>
        public CapabilityState UseSharePointAction
        {
            get { return this._useSharePointAction; }
            set { this._useSharePointAction = value; }
        }

        // Check to see if UseSharePointAction property is set
        internal bool IsSetUseSharePointAction()
        {
            return this._useSharePointAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseSlackAction. 
        /// <para>
        /// The ability to use Slack actions.
        /// </para>
        /// </summary>
        public CapabilityState UseSlackAction
        {
            get { return this._useSlackAction; }
            set { this._useSlackAction = value; }
        }

        // Check to see if UseSlackAction property is set
        internal bool IsSetUseSlackAction()
        {
            return this._useSlackAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseSmartsheetAction. 
        /// <para>
        /// The ability to use Smartsheet actions.
        /// </para>
        /// </summary>
        public CapabilityState UseSmartsheetAction
        {
            get { return this._useSmartsheetAction; }
            set { this._useSmartsheetAction = value; }
        }

        // Check to see if UseSmartsheetAction property is set
        internal bool IsSetUseSmartsheetAction()
        {
            return this._useSmartsheetAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseTextractAction. 
        /// <para>
        /// The ability to use Textract actions.
        /// </para>
        /// </summary>
        public CapabilityState UseTextractAction
        {
            get { return this._useTextractAction; }
            set { this._useTextractAction = value; }
        }

        // Check to see if UseTextractAction property is set
        internal bool IsSetUseTextractAction()
        {
            return this._useTextractAction != null;
        }

        /// <summary>
        /// Gets and sets the property UseZendeskAction. 
        /// <para>
        /// The ability to use Zendesk actions.
        /// </para>
        /// </summary>
        public CapabilityState UseZendeskAction
        {
            get { return this._useZendeskAction; }
            set { this._useZendeskAction = value; }
        }

        // Check to see if UseZendeskAction property is set
        internal bool IsSetUseZendeskAction()
        {
            return this._useZendeskAction != null;
        }

        /// <summary>
        /// Gets and sets the property ViewAccountSPICECapacity. 
        /// <para>
        /// The ability to view account SPICE capacity.
        /// </para>
        /// </summary>
        public CapabilityState ViewAccountSPICECapacity
        {
            get { return this._viewAccountSPICECapacity; }
            set { this._viewAccountSPICECapacity = value; }
        }

        // Check to see if ViewAccountSPICECapacity property is set
        internal bool IsSetViewAccountSPICECapacity()
        {
            return this._viewAccountSPICECapacity != null;
        }

        /// <summary>
        /// Gets and sets the property ZendeskAction. 
        /// <para>
        /// The ability to perform actions using Zendesk connectors.
        /// </para>
        /// </summary>
        public CapabilityState ZendeskAction
        {
            get { return this._zendeskAction; }
            set { this._zendeskAction = value; }
        }

        // Check to see if ZendeskAction property is set
        internal bool IsSetZendeskAction()
        {
            return this._zendeskAction != null;
        }

    }
}