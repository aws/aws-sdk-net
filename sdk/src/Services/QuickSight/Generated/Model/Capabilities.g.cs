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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AccessAppsNativeDataStore. 
        /// <para>
        /// The ability to access the native data store for new and existing apps.
        /// </para>
        /// </summary>
        public CapabilityState AccessAppsNativeDataStore { get; set; }

        /// <summary>
        /// Checks to see if the AccessAppsNativeDataStore property is set.
        /// </summary>
        internal bool IsSetAccessAppsNativeDataStore() => this.AccessAppsNativeDataStore != null;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The ability to perform actions in external services through Action connectors. Actions
        /// allow users to interact with third-party systems.
        /// </para>
        /// </summary>
        public CapabilityState Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property AddOrRunAnomalyDetectionForAnalyses. 
        /// <para>
        /// The ability to add or run anomaly detection.
        /// </para>
        /// </summary>
        public CapabilityState AddOrRunAnomalyDetectionForAnalyses { get; set; }

        /// <summary>
        /// Checks to see if the AddOrRunAnomalyDetectionForAnalyses property is set.
        /// </summary>
        internal bool IsSetAddOrRunAnomalyDetectionForAnalyses() => this.AddOrRunAnomalyDetectionForAnalyses != null;

        /// <summary>
        /// Gets and sets the property AdobeAction. 
        /// <para>
        /// The ability to perform actions using Adobe Marketing Agent connectors.
        /// </para>
        /// </summary>
        public CapabilityState AdobeAction { get; set; }

        /// <summary>
        /// Checks to see if the AdobeAction property is set.
        /// </summary>
        internal bool IsSetAdobeAction() => this.AdobeAction != null;

        /// <summary>
        /// Gets and sets the property AdobeAnalyticsDataSource. 
        /// <para>
        /// The ability to create, update, and share Adobe Analytics data sources.
        /// </para>
        /// </summary>
        public CapabilityState AdobeAnalyticsDataSource { get; set; }

        /// <summary>
        /// Checks to see if the AdobeAnalyticsDataSource property is set.
        /// </summary>
        internal bool IsSetAdobeAnalyticsDataSource() => this.AdobeAnalyticsDataSource != null;

        /// <summary>
        /// Gets and sets the property AirtableAction. 
        /// <para>
        /// The ability to perform actions using Airtable connectors.
        /// </para>
        /// </summary>
        public CapabilityState AirtableAction { get; set; }

        /// <summary>
        /// Checks to see if the AirtableAction property is set.
        /// </summary>
        internal bool IsSetAirtableAction() => this.AirtableAction != null;

        /// <summary>
        /// Gets and sets the property AmazonBedrockARSAction. 
        /// <para>
        /// The ability to perform actions using Bedrock Agent connectors.
        /// </para>
        /// </summary>
        public CapabilityState AmazonBedrockARSAction { get; set; }

        /// <summary>
        /// Checks to see if the AmazonBedrockARSAction property is set.
        /// </summary>
        internal bool IsSetAmazonBedrockARSAction() => this.AmazonBedrockARSAction != null;

        /// <summary>
        /// Gets and sets the property AmazonBedrockFSAction. 
        /// <para>
        /// The ability to perform actions using Bedrock Runtime connectors.
        /// </para>
        /// </summary>
        public CapabilityState AmazonBedrockFSAction { get; set; }

        /// <summary>
        /// Checks to see if the AmazonBedrockFSAction property is set.
        /// </summary>
        internal bool IsSetAmazonBedrockFSAction() => this.AmazonBedrockFSAction != null;

        /// <summary>
        /// Gets and sets the property AmazonBedrockKRSAction. 
        /// <para>
        /// The ability to perform actions using Bedrock Data Automation Runtime connectors.
        /// </para>
        /// </summary>
        public CapabilityState AmazonBedrockKRSAction { get; set; }

        /// <summary>
        /// Checks to see if the AmazonBedrockKRSAction property is set.
        /// </summary>
        internal bool IsSetAmazonBedrockKRSAction() => this.AmazonBedrockKRSAction != null;

        /// <summary>
        /// Gets and sets the property AmazonSThreeAction. 
        /// <para>
        /// The ability to perform actions using Amazon S3 connectors.
        /// </para>
        /// </summary>
        public CapabilityState AmazonSThreeAction { get; set; }

        /// <summary>
        /// Checks to see if the AmazonSThreeAction property is set.
        /// </summary>
        internal bool IsSetAmazonSThreeAction() => this.AmazonSThreeAction != null;

        /// <summary>
        /// Gets and sets the property Analysis. 
        /// <para>
        /// The ability to perform analysis-related actions.
        /// </para>
        /// </summary>
        public CapabilityState Analysis { get; set; }

        /// <summary>
        /// Checks to see if the Analysis property is set.
        /// </summary>
        internal bool IsSetAnalysis() => this.Analysis != null;

        /// <summary>
        /// Gets and sets the property ApproveFlowShareRequests. 
        /// <para>
        /// The ability to review and approve sharing requests of Flows.
        /// </para>
        /// </summary>
        public CapabilityState ApproveFlowShareRequests { get; set; }

        /// <summary>
        /// Checks to see if the ApproveFlowShareRequests property is set.
        /// </summary>
        internal bool IsSetApproveFlowShareRequests() => this.ApproveFlowShareRequests != null;

        /// <summary>
        /// Gets and sets the property Apps. 
        /// <para>
        /// The ability to perform apps-related actions.
        /// </para>
        /// </summary>
        public CapabilityState Apps { get; set; }

        /// <summary>
        /// Checks to see if the Apps property is set.
        /// </summary>
        internal bool IsSetApps() => this.Apps != null;

        /// <summary>
        /// Gets and sets the property AsanaAction. 
        /// <para>
        /// The ability to perform actions using Asana connectors.
        /// </para>
        /// </summary>
        public CapabilityState AsanaAction { get; set; }

        /// <summary>
        /// Checks to see if the AsanaAction property is set.
        /// </summary>
        internal bool IsSetAsanaAction() => this.AsanaAction != null;

        /// <summary>
        /// Gets and sets the property AthenaDataSource. 
        /// <para>
        /// The ability to create, update, and share Amazon Athena data sources.
        /// </para>
        /// </summary>
        public CapabilityState AthenaDataSource { get; set; }

        /// <summary>
        /// Checks to see if the AthenaDataSource property is set.
        /// </summary>
        internal bool IsSetAthenaDataSource() => this.AthenaDataSource != null;

        /// <summary>
        /// Gets and sets the property AuroraDataSource. 
        /// <para>
        /// The ability to create, update, and share Amazon Aurora data sources.
        /// </para>
        /// </summary>
        public CapabilityState AuroraDataSource { get; set; }

        /// <summary>
        /// Checks to see if the AuroraDataSource property is set.
        /// </summary>
        internal bool IsSetAuroraDataSource() => this.AuroraDataSource != null;

        /// <summary>
        /// Gets and sets the property Automate. 
        /// <para>
        /// The ability to perform automate-related actions.
        /// </para>
        /// </summary>
        public CapabilityState Automate { get; set; }

        /// <summary>
        /// Checks to see if the Automate property is set.
        /// </summary>
        internal bool IsSetAutomate() => this.Automate != null;

        /// <summary>
        /// Gets and sets the property BambooHRAction. 
        /// <para>
        /// The ability to perform actions using BambooHR connectors.
        /// </para>
        /// </summary>
        public CapabilityState BambooHRAction { get; set; }

        /// <summary>
        /// Checks to see if the BambooHRAction property is set.
        /// </summary>
        internal bool IsSetBambooHRAction() => this.BambooHRAction != null;

        /// <summary>
        /// Gets and sets the property BedrockManagedKnowledgeBase.
        /// </summary>
        public CapabilityState BedrockManagedKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the BedrockManagedKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetBedrockManagedKnowledgeBase() => this.BedrockManagedKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property BeeAction. 
        /// <para>
        /// The ability to perform actions using Bee connectors.
        /// </para>
        /// </summary>
        public CapabilityState BeeAction { get; set; }

        /// <summary>
        /// Checks to see if the BeeAction property is set.
        /// </summary>
        internal bool IsSetBeeAction() => this.BeeAction != null;

        /// <summary>
        /// Gets and sets the property BoxAgentAction. 
        /// <para>
        /// The ability to perform actions using Box Agent connectors.
        /// </para>
        /// </summary>
        public CapabilityState BoxAgentAction { get; set; }

        /// <summary>
        /// Checks to see if the BoxAgentAction property is set.
        /// </summary>
        internal bool IsSetBoxAgentAction() => this.BoxAgentAction != null;

        /// <summary>
        /// Gets and sets the property BoxKnowledgeBase.
        /// </summary>
        public CapabilityState BoxKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the BoxKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetBoxKnowledgeBase() => this.BoxKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property BuildCalculatedFieldWithQ. 
        /// <para>
        /// The ability to Build Calculation with AI
        /// </para>
        /// </summary>
        public CapabilityState BuildCalculatedFieldWithQ { get; set; }

        /// <summary>
        /// Checks to see if the BuildCalculatedFieldWithQ property is set.
        /// </summary>
        internal bool IsSetBuildCalculatedFieldWithQ() => this.BuildCalculatedFieldWithQ != null;

        /// <summary>
        /// Gets and sets the property CanvaAgentAction. 
        /// <para>
        /// The ability to perform actions using Canva Agent connectors.
        /// </para>
        /// </summary>
        public CapabilityState CanvaAgentAction { get; set; }

        /// <summary>
        /// Checks to see if the CanvaAgentAction property is set.
        /// </summary>
        internal bool IsSetCanvaAgentAction() => this.CanvaAgentAction != null;

        /// <summary>
        /// Gets and sets the property ChatAgent. 
        /// <para>
        /// The ability to perform chat-related actions.
        /// </para>
        /// </summary>
        public CapabilityState ChatAgent { get; set; }

        /// <summary>
        /// Checks to see if the ChatAgent property is set.
        /// </summary>
        internal bool IsSetChatAgent() => this.ChatAgent != null;

        /// <summary>
        /// Gets and sets the property CiscoWebexMeetingsAction. 
        /// <para>
        /// The ability to perform actions using Cisco Webex Meetings connectors.
        /// </para>
        /// </summary>
        public CapabilityState CiscoWebexMeetingsAction { get; set; }

        /// <summary>
        /// Checks to see if the CiscoWebexMeetingsAction property is set.
        /// </summary>
        internal bool IsSetCiscoWebexMeetingsAction() => this.CiscoWebexMeetingsAction != null;

        /// <summary>
        /// Gets and sets the property CiscoWebexVidcastAction. 
        /// <para>
        /// The ability to perform actions using Cisco Webex Video Messaging Agent connectors.
        /// </para>
        /// </summary>
        public CapabilityState CiscoWebexVidcastAction { get; set; }

        /// <summary>
        /// Checks to see if the CiscoWebexVidcastAction property is set.
        /// </summary>
        internal bool IsSetCiscoWebexVidcastAction() => this.CiscoWebexVidcastAction != null;

        /// <summary>
        /// Gets and sets the property ComprehendAction. 
        /// <para>
        /// The ability to perform actions using Comprehend connectors.
        /// </para>
        /// </summary>
        public CapabilityState ComprehendAction { get; set; }

        /// <summary>
        /// Checks to see if the ComprehendAction property is set.
        /// </summary>
        internal bool IsSetComprehendAction() => this.ComprehendAction != null;

        /// <summary>
        /// Gets and sets the property ComprehendMedicalAction. 
        /// <para>
        /// The ability to perform actions using Comprehend Medical connectors.
        /// </para>
        /// </summary>
        public CapabilityState ComprehendMedicalAction { get; set; }

        /// <summary>
        /// Checks to see if the ComprehendMedicalAction property is set.
        /// </summary>
        internal bool IsSetComprehendMedicalAction() => this.ComprehendMedicalAction != null;

        /// <summary>
        /// Gets and sets the property ConfluenceAction. 
        /// <para>
        /// The ability to perform actions using Atlassian Confluence Cloud connectors.
        /// </para>
        /// </summary>
        public CapabilityState ConfluenceAction { get; set; }

        /// <summary>
        /// Checks to see if the ConfluenceAction property is set.
        /// </summary>
        internal bool IsSetConfluenceAction() => this.ConfluenceAction != null;

        /// <summary>
        /// Gets and sets the property ConfluenceKnowledgeBase.
        /// </summary>
        public CapabilityState ConfluenceKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the ConfluenceKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetConfluenceKnowledgeBase() => this.ConfluenceKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property CreateAdobeAnalyticsDataSource. 
        /// <para>
        /// The ability to create Adobe Analytics data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateAdobeAnalyticsDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateAdobeAnalyticsDataSource property is set.
        /// </summary>
        internal bool IsSetCreateAdobeAnalyticsDataSource() => this.CreateAdobeAnalyticsDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateAdobeAction. 
        /// <para>
        /// The ability to create and update Adobe Marketing Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateAdobeAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateAdobeAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateAdobeAction() => this.CreateAndUpdateAdobeAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateAirtableAction. 
        /// <para>
        /// The ability to create and update Airtable actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateAirtableAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateAirtableAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateAirtableAction() => this.CreateAndUpdateAirtableAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateAmazonBedrockARSAction. 
        /// <para>
        /// The ability to create and update Bedrock Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateAmazonBedrockARSAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateAmazonBedrockARSAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateAmazonBedrockARSAction() => this.CreateAndUpdateAmazonBedrockARSAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateAmazonBedrockFSAction. 
        /// <para>
        /// The ability to create and update Bedrock Runtime actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateAmazonBedrockFSAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateAmazonBedrockFSAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateAmazonBedrockFSAction() => this.CreateAndUpdateAmazonBedrockFSAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateAmazonBedrockKRSAction. 
        /// <para>
        /// The ability to create and update Bedrock Data Automation Runtime actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateAmazonBedrockKRSAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateAmazonBedrockKRSAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateAmazonBedrockKRSAction() => this.CreateAndUpdateAmazonBedrockKRSAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateAmazonSThreeAction. 
        /// <para>
        /// The ability to create and update Amazon S3 actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateAmazonSThreeAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateAmazonSThreeAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateAmazonSThreeAction() => this.CreateAndUpdateAmazonSThreeAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateApps. 
        /// <para>
        /// The ability to create or update apps.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateApps { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateApps property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateApps() => this.CreateAndUpdateApps != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateAsanaAction. 
        /// <para>
        /// The ability to create and update Asana actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateAsanaAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateAsanaAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateAsanaAction() => this.CreateAndUpdateAsanaAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateBambooHRAction. 
        /// <para>
        /// The ability to create and update BambooHR actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateBambooHRAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateBambooHRAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateBambooHRAction() => this.CreateAndUpdateBambooHRAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateBedrockManagedKnowledgeBase.
        /// </summary>
        public CapabilityState CreateAndUpdateBedrockManagedKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateBedrockManagedKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateBedrockManagedKnowledgeBase() => this.CreateAndUpdateBedrockManagedKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateBeeAction. 
        /// <para>
        /// The ability to create and update Bee actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateBeeAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateBeeAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateBeeAction() => this.CreateAndUpdateBeeAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateBoxAgentAction. 
        /// <para>
        /// The ability to create and update Box Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateBoxAgentAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateBoxAgentAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateBoxAgentAction() => this.CreateAndUpdateBoxAgentAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateBoxKnowledgeBase.
        /// </summary>
        public CapabilityState CreateAndUpdateBoxKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateBoxKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateBoxKnowledgeBase() => this.CreateAndUpdateBoxKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateCanvaAgentAction. 
        /// <para>
        /// The ability to create and update Canva Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateCanvaAgentAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateCanvaAgentAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateCanvaAgentAction() => this.CreateAndUpdateCanvaAgentAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateCiscoWebexMeetingsAction. 
        /// <para>
        /// The ability to create and update Cisco Webex Meetings actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateCiscoWebexMeetingsAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateCiscoWebexMeetingsAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateCiscoWebexMeetingsAction() => this.CreateAndUpdateCiscoWebexMeetingsAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateCiscoWebexVidcastAction. 
        /// <para>
        /// The ability to create and update Cisco Webex Video Messaging Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateCiscoWebexVidcastAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateCiscoWebexVidcastAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateCiscoWebexVidcastAction() => this.CreateAndUpdateCiscoWebexVidcastAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateComprehendAction. 
        /// <para>
        /// The ability to create and update Comprehend actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateComprehendAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateComprehendAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateComprehendAction() => this.CreateAndUpdateComprehendAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateComprehendMedicalAction. 
        /// <para>
        /// The ability to create and update Comprehend Medical actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateComprehendMedicalAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateComprehendMedicalAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateComprehendMedicalAction() => this.CreateAndUpdateComprehendMedicalAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateConfluenceAction. 
        /// <para>
        /// The ability to create and update Atlassian Confluence Cloud actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateConfluenceAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateConfluenceAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateConfluenceAction() => this.CreateAndUpdateConfluenceAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateConfluenceKnowledgeBase.
        /// </summary>
        public CapabilityState CreateAndUpdateConfluenceKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateConfluenceKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateConfluenceKnowledgeBase() => this.CreateAndUpdateConfluenceKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateDashboardEmailReports. 
        /// <para>
        /// The ability to create and update email reports.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateDashboardEmailReports { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateDashboardEmailReports property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateDashboardEmailReports() => this.CreateAndUpdateDashboardEmailReports != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateDataSources. 
        /// <para>
        /// The ability to create and update data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateDataSources { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateDataSources property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateDataSources() => this.CreateAndUpdateDataSources != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateDatasets. 
        /// <para>
        /// The ability to create and update datasets.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateDatasets { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateDatasets property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateDatasets() => this.CreateAndUpdateDatasets != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateDropboxAction. 
        /// <para>
        /// The ability to create and update Dropbox actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateDropboxAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateDropboxAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateDropboxAction() => this.CreateAndUpdateDropboxAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateDunAndBradstreetAction. 
        /// <para>
        /// The ability to create and update Dun and Bradstreet actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateDunAndBradstreetAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateDunAndBradstreetAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateDunAndBradstreetAction() => this.CreateAndUpdateDunAndBradstreetAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateFactSetAction. 
        /// <para>
        /// The ability to create and update FactSet actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateFactSetAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateFactSetAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateFactSetAction() => this.CreateAndUpdateFactSetAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateFigmaAction. 
        /// <para>
        /// The ability to create and update Figma actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateFigmaAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateFigmaAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateFigmaAction() => this.CreateAndUpdateFigmaAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateGenericHTTPAction. 
        /// <para>
        /// The ability to create and update REST API connection actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateGenericHTTPAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateGenericHTTPAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateGenericHTTPAction() => this.CreateAndUpdateGenericHTTPAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateGithubAction. 
        /// <para>
        /// The ability to create and update GitHub actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateGithubAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateGithubAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateGithubAction() => this.CreateAndUpdateGithubAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateGmailAction. 
        /// <para>
        /// The ability to create and update Gmail actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateGmailAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateGmailAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateGmailAction() => this.CreateAndUpdateGmailAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateGongAction. 
        /// <para>
        /// The ability to create and update Gong actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateGongAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateGongAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateGongAction() => this.CreateAndUpdateGongAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateGoogleAnalyticsAction. 
        /// <para>
        /// The ability to create and update Google Analytics actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateGoogleAnalyticsAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateGoogleAnalyticsAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateGoogleAnalyticsAction() => this.CreateAndUpdateGoogleAnalyticsAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateGoogleCalendarAction. 
        /// <para>
        /// The ability to create and update Google Calendar actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateGoogleCalendarAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateGoogleCalendarAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateGoogleCalendarAction() => this.CreateAndUpdateGoogleCalendarAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateGoogleChatAction. 
        /// <para>
        /// The ability to create and update Google Chat actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateGoogleChatAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateGoogleChatAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateGoogleChatAction() => this.CreateAndUpdateGoogleChatAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateGoogleDocsAction. 
        /// <para>
        /// The ability to create and update Google Docs actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateGoogleDocsAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateGoogleDocsAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateGoogleDocsAction() => this.CreateAndUpdateGoogleDocsAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateGoogleDriveAction. 
        /// <para>
        /// The ability to create and update Google Drive actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateGoogleDriveAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateGoogleDriveAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateGoogleDriveAction() => this.CreateAndUpdateGoogleDriveAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateGoogleDriveKnowledgeBase.
        /// </summary>
        public CapabilityState CreateAndUpdateGoogleDriveKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateGoogleDriveKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateGoogleDriveKnowledgeBase() => this.CreateAndUpdateGoogleDriveKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateGoogleMeetAction. 
        /// <para>
        /// The ability to create and update Google Meet actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateGoogleMeetAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateGoogleMeetAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateGoogleMeetAction() => this.CreateAndUpdateGoogleMeetAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateGoogleSheetsAction. 
        /// <para>
        /// The ability to create and update Google Sheets actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateGoogleSheetsAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateGoogleSheetsAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateGoogleSheetsAction() => this.CreateAndUpdateGoogleSheetsAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateGoogleSlidesAction. 
        /// <para>
        /// The ability to create and update Google Slides actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateGoogleSlidesAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateGoogleSlidesAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateGoogleSlidesAction() => this.CreateAndUpdateGoogleSlidesAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateHGInsightsAction. 
        /// <para>
        /// The ability to create and update HG Insights Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateHGInsightsAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateHGInsightsAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateHGInsightsAction() => this.CreateAndUpdateHGInsightsAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateHubspotAction. 
        /// <para>
        /// The ability to create and update Hubspot actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateHubspotAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateHubspotAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateHubspotAction() => this.CreateAndUpdateHubspotAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateHuggingFaceAction. 
        /// <para>
        /// The ability to create and update HuggingFace actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateHuggingFaceAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateHuggingFaceAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateHuggingFaceAction() => this.CreateAndUpdateHuggingFaceAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateIDCKnowledgeBase.
        /// </summary>
        public CapabilityState CreateAndUpdateIDCKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateIDCKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateIDCKnowledgeBase() => this.CreateAndUpdateIDCKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateIntercomAction. 
        /// <para>
        /// The ability to create and update Intercom actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateIntercomAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateIntercomAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateIntercomAction() => this.CreateAndUpdateIntercomAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateJiraAction. 
        /// <para>
        /// The ability to create and update Jira actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateJiraAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateJiraAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateJiraAction() => this.CreateAndUpdateJiraAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateKnowledgeBases.
        /// </summary>
        public CapabilityState CreateAndUpdateKnowledgeBases { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateKnowledgeBases property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateKnowledgeBases() => this.CreateAndUpdateKnowledgeBases != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateLinearAction. 
        /// <para>
        /// The ability to create and update Linear actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateLinearAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateLinearAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateLinearAction() => this.CreateAndUpdateLinearAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateMCPAction. 
        /// <para>
        /// The ability to create and update Model Context Protocol actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateMCPAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateMCPAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateMCPAction() => this.CreateAndUpdateMCPAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateMSExchangeAction. 
        /// <para>
        /// The ability to create and update Microsoft Outlook actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateMSExchangeAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateMSExchangeAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateMSExchangeAction() => this.CreateAndUpdateMSExchangeAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateMSTeamsAction. 
        /// <para>
        /// The ability to create and update Microsoft Teams actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateMSTeamsAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateMSTeamsAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateMSTeamsAction() => this.CreateAndUpdateMSTeamsAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateMondayAction. 
        /// <para>
        /// The ability to create and update Monday actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateMondayAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateMondayAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateMondayAction() => this.CreateAndUpdateMondayAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateMoodysAction. 
        /// <para>
        /// The ability to create and update Moody's GenAI Ready Data actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateMoodysAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateMoodysAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateMoodysAction() => this.CreateAndUpdateMoodysAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateNewRelicAction. 
        /// <para>
        /// The ability to create and update New Relic actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateNewRelicAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateNewRelicAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateNewRelicAction() => this.CreateAndUpdateNewRelicAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateNotionAction. 
        /// <para>
        /// The ability to create and update Notion actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateNotionAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateNotionAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateNotionAction() => this.CreateAndUpdateNotionAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateOneDriveAction. 
        /// <para>
        /// The ability to create and update Microsoft OneDrive actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateOneDriveAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateOneDriveAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateOneDriveAction() => this.CreateAndUpdateOneDriveAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateOneDriveKnowledgeBase.
        /// </summary>
        public CapabilityState CreateAndUpdateOneDriveKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateOneDriveKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateOneDriveKnowledgeBase() => this.CreateAndUpdateOneDriveKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateOneNoteAction. 
        /// <para>
        /// The ability to create and update Microsoft OneNote actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateOneNoteAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateOneNoteAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateOneNoteAction() => this.CreateAndUpdateOneNoteAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateOpenAPIAction. 
        /// <para>
        /// The ability to create and update OpenAPI Specification actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateOpenAPIAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateOpenAPIAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateOpenAPIAction() => this.CreateAndUpdateOpenAPIAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdatePagerDutyAction. 
        /// <para>
        /// The ability to create and update PagerDuty Advance actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdatePagerDutyAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdatePagerDutyAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdatePagerDutyAction() => this.CreateAndUpdatePagerDutyAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdatePagerDutyAgentAction. 
        /// <para>
        /// The ability to create and update PagerDuty Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdatePagerDutyAgentAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdatePagerDutyAgentAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdatePagerDutyAgentAction() => this.CreateAndUpdatePagerDutyAgentAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateQBusinessKnowledgeBase.
        /// </summary>
        public CapabilityState CreateAndUpdateQBusinessKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateQBusinessKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateQBusinessKnowledgeBase() => this.CreateAndUpdateQBusinessKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateQuickBooksAction. 
        /// <para>
        /// The ability to create and update QuickBooks actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateQuickBooksAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateQuickBooksAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateQuickBooksAction() => this.CreateAndUpdateQuickBooksAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateS3KnowledgeBase.
        /// </summary>
        public CapabilityState CreateAndUpdateS3KnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateS3KnowledgeBase property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateS3KnowledgeBase() => this.CreateAndUpdateS3KnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateSAPBillOfMaterialAction. 
        /// <para>
        /// The ability to create and update SAP Bill of Materials actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateSAPBillOfMaterialAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateSAPBillOfMaterialAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateSAPBillOfMaterialAction() => this.CreateAndUpdateSAPBillOfMaterialAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateSAPBusinessPartnerAction. 
        /// <para>
        /// The ability to create and update SAP Business Partner actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateSAPBusinessPartnerAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateSAPBusinessPartnerAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateSAPBusinessPartnerAction() => this.CreateAndUpdateSAPBusinessPartnerAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateSAPMaterialStockAction. 
        /// <para>
        /// The ability to create and update SAP Material Stock actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateSAPMaterialStockAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateSAPMaterialStockAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateSAPMaterialStockAction() => this.CreateAndUpdateSAPMaterialStockAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateSAPPhysicalInventoryAction. 
        /// <para>
        /// The ability to create and update SAP Physical Inventory actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateSAPPhysicalInventoryAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateSAPPhysicalInventoryAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateSAPPhysicalInventoryAction() => this.CreateAndUpdateSAPPhysicalInventoryAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateSAPProductMasterDataAction. 
        /// <para>
        /// The ability to create and update SAP Product Master actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateSAPProductMasterDataAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateSAPProductMasterDataAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateSAPProductMasterDataAction() => this.CreateAndUpdateSAPProductMasterDataAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateSalesforceAction. 
        /// <para>
        /// The ability to create and update Salesforce actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateSalesforceAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateSalesforceAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateSalesforceAction() => this.CreateAndUpdateSalesforceAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateSandPGMIAction. 
        /// <para>
        /// The ability to create and update S&amp;P Global Market Intelligence actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateSandPGMIAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateSandPGMIAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateSandPGMIAction() => this.CreateAndUpdateSandPGMIAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateSandPGlobalEnergyAction. 
        /// <para>
        /// The ability to create and update S&amp;P Global Energy actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateSandPGlobalEnergyAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateSandPGlobalEnergyAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateSandPGlobalEnergyAction() => this.CreateAndUpdateSandPGlobalEnergyAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateServiceNowAction. 
        /// <para>
        /// The ability to create and update ServiceNow actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateServiceNowAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateServiceNowAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateServiceNowAction() => this.CreateAndUpdateServiceNowAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateSharePointAction. 
        /// <para>
        /// The ability to create and update Microsoft SharePoint Online actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateSharePointAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateSharePointAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateSharePointAction() => this.CreateAndUpdateSharePointAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateSharePointKnowledgeBase.
        /// </summary>
        public CapabilityState CreateAndUpdateSharePointKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateSharePointKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateSharePointKnowledgeBase() => this.CreateAndUpdateSharePointKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateShopifyAction. 
        /// <para>
        /// The ability to create and update Shopify actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateShopifyAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateShopifyAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateShopifyAction() => this.CreateAndUpdateShopifyAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateSlackAction. 
        /// <para>
        /// The ability to create and update Slack actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateSlackAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateSlackAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateSlackAction() => this.CreateAndUpdateSlackAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateSmartsheetAction. 
        /// <para>
        /// The ability to create and update Smartsheet actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateSmartsheetAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateSmartsheetAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateSmartsheetAction() => this.CreateAndUpdateSmartsheetAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateSnowFlakeAction. 
        /// <para>
        /// The ability to create and update Snowflake Cortex Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateSnowFlakeAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateSnowFlakeAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateSnowFlakeAction() => this.CreateAndUpdateSnowFlakeAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateTextractAction. 
        /// <para>
        /// The ability to create and update Textract actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateTextractAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateTextractAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateTextractAction() => this.CreateAndUpdateTextractAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateThemes. 
        /// <para>
        /// The ability to export to Create and Update themes.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateThemes { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateThemes property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateThemes() => this.CreateAndUpdateThemes != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateThresholdAlerts. 
        /// <para>
        /// The ability to create and update threshold alerts.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateThresholdAlerts { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateThresholdAlerts property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateThresholdAlerts() => this.CreateAndUpdateThresholdAlerts != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateVisierAgentAction. 
        /// <para>
        /// The ability to create and update Visier Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateVisierAgentAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateVisierAgentAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateVisierAgentAction() => this.CreateAndUpdateVisierAgentAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateWebCrawlerKnowledgeBase.
        /// </summary>
        public CapabilityState CreateAndUpdateWebCrawlerKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateWebCrawlerKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateWebCrawlerKnowledgeBase() => this.CreateAndUpdateWebCrawlerKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateWhatsAppAction. 
        /// <para>
        /// The ability to create and update WhatsApp actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateWhatsAppAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateWhatsAppAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateWhatsAppAction() => this.CreateAndUpdateWhatsAppAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateZapierAction. 
        /// <para>
        /// The ability to create and update Zapier Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateZapierAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateZapierAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateZapierAction() => this.CreateAndUpdateZapierAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateZendeskAction. 
        /// <para>
        /// The ability to create and update Zendesk actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateZendeskAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateZendeskAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateZendeskAction() => this.CreateAndUpdateZendeskAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateZoomAction. 
        /// <para>
        /// The ability to create and update Zoom actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateZoomAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateZoomAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateZoomAction() => this.CreateAndUpdateZoomAction != null;

        /// <summary>
        /// Gets and sets the property CreateAndUpdateZoomInfoAction. 
        /// <para>
        /// The ability to create and update ZoomInfo Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateZoomInfoAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateAndUpdateZoomInfoAction property is set.
        /// </summary>
        internal bool IsSetCreateAndUpdateZoomInfoAction() => this.CreateAndUpdateZoomInfoAction != null;

        /// <summary>
        /// Gets and sets the property CreateAthenaDataSource. 
        /// <para>
        /// The ability to create Amazon Athena data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateAthenaDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateAthenaDataSource property is set.
        /// </summary>
        internal bool IsSetCreateAthenaDataSource() => this.CreateAthenaDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateAuroraDataSource. 
        /// <para>
        /// The ability to create Amazon Aurora data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateAuroraDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateAuroraDataSource property is set.
        /// </summary>
        internal bool IsSetCreateAuroraDataSource() => this.CreateAuroraDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateChatAgents. 
        /// <para>
        /// The ability to create chat agents.
        /// </para>
        /// </summary>
        public CapabilityState CreateChatAgents { get; set; }

        /// <summary>
        /// Checks to see if the CreateChatAgents property is set.
        /// </summary>
        internal bool IsSetCreateChatAgents() => this.CreateChatAgents != null;

        /// <summary>
        /// Gets and sets the property CreateDashboardExecutiveSummaryWithQ. 
        /// <para>
        /// The ability to Create Executive Summary
        /// </para>
        /// </summary>
        public CapabilityState CreateDashboardExecutiveSummaryWithQ { get; set; }

        /// <summary>
        /// Checks to see if the CreateDashboardExecutiveSummaryWithQ property is set.
        /// </summary>
        internal bool IsSetCreateDashboardExecutiveSummaryWithQ() => this.CreateDashboardExecutiveSummaryWithQ != null;

        /// <summary>
        /// Gets and sets the property CreateDatabricksDataSource. 
        /// <para>
        /// The ability to create Databricks data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateDatabricksDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateDatabricksDataSource property is set.
        /// </summary>
        internal bool IsSetCreateDatabricksDataSource() => this.CreateDatabricksDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateDb2DataSource. 
        /// <para>
        /// The ability to create Db2 data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateDb2DataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateDb2DataSource property is set.
        /// </summary>
        internal bool IsSetCreateDb2DataSource() => this.CreateDb2DataSource != null;

        /// <summary>
        /// Gets and sets the property CreateDenodoDataSource. 
        /// <para>
        /// The ability to create Denodo data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateDenodoDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateDenodoDataSource property is set.
        /// </summary>
        internal bool IsSetCreateDenodoDataSource() => this.CreateDenodoDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateDocumentDbDataSource. 
        /// <para>
        /// The ability to create Amazon DocumentDB data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateDocumentDbDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateDocumentDbDataSource property is set.
        /// </summary>
        internal bool IsSetCreateDocumentDbDataSource() => this.CreateDocumentDbDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateDremioDataSource. 
        /// <para>
        /// The ability to create Dremio data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateDremioDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateDremioDataSource property is set.
        /// </summary>
        internal bool IsSetCreateDremioDataSource() => this.CreateDremioDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateDynamoDbDataSource. 
        /// <para>
        /// The ability to create Amazon DynamoDB data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateDynamoDbDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateDynamoDbDataSource property is set.
        /// </summary>
        internal bool IsSetCreateDynamoDbDataSource() => this.CreateDynamoDbDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateExasolDataSource. 
        /// <para>
        /// The ability to create Exasol data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateExasolDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateExasolDataSource property is set.
        /// </summary>
        internal bool IsSetCreateExasolDataSource() => this.CreateExasolDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateFileDataSource. 
        /// <para>
        /// The ability to create file data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateFileDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateFileDataSource property is set.
        /// </summary>
        internal bool IsSetCreateFileDataSource() => this.CreateFileDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateGitHubDataSource. 
        /// <para>
        /// The ability to create GitHub data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateGitHubDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateGitHubDataSource property is set.
        /// </summary>
        internal bool IsSetCreateGitHubDataSource() => this.CreateGitHubDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateGoogleAnalyticsDataSource. 
        /// <para>
        /// The ability to create Google Analytics data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateGoogleAnalyticsDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateGoogleAnalyticsDataSource property is set.
        /// </summary>
        internal bool IsSetCreateGoogleAnalyticsDataSource() => this.CreateGoogleAnalyticsDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateGoogleBigQueryDataSource. 
        /// <para>
        /// The ability to create Google BigQuery data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateGoogleBigQueryDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateGoogleBigQueryDataSource property is set.
        /// </summary>
        internal bool IsSetCreateGoogleBigQueryDataSource() => this.CreateGoogleBigQueryDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateGoogleSheetsDataSource. 
        /// <para>
        /// The ability to create Google Sheets data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateGoogleSheetsDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateGoogleSheetsDataSource property is set.
        /// </summary>
        internal bool IsSetCreateGoogleSheetsDataSource() => this.CreateGoogleSheetsDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateImpalaDataSource. 
        /// <para>
        /// The ability to create Impala data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateImpalaDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateImpalaDataSource property is set.
        /// </summary>
        internal bool IsSetCreateImpalaDataSource() => this.CreateImpalaDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateJiraDataSource. 
        /// <para>
        /// The ability to create Jira data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateJiraDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateJiraDataSource property is set.
        /// </summary>
        internal bool IsSetCreateJiraDataSource() => this.CreateJiraDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateMariaDbDataSource. 
        /// <para>
        /// The ability to create MariaDB data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateMariaDbDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateMariaDbDataSource property is set.
        /// </summary>
        internal bool IsSetCreateMariaDbDataSource() => this.CreateMariaDbDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateMongoAtlasDataSource. 
        /// <para>
        /// The ability to create MongoDB Atlas data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateMongoAtlasDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateMongoAtlasDataSource property is set.
        /// </summary>
        internal bool IsSetCreateMongoAtlasDataSource() => this.CreateMongoAtlasDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateMongoDbDataSource. 
        /// <para>
        /// The ability to create MongoDB data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateMongoDbDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateMongoDbDataSource property is set.
        /// </summary>
        internal bool IsSetCreateMongoDbDataSource() => this.CreateMongoDbDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateMySqlDataSource. 
        /// <para>
        /// The ability to create MySQL data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateMySqlDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateMySqlDataSource property is set.
        /// </summary>
        internal bool IsSetCreateMySqlDataSource() => this.CreateMySqlDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateOpenSearchDataSource. 
        /// <para>
        /// The ability to create Amazon OpenSearch Service data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateOpenSearchDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateOpenSearchDataSource property is set.
        /// </summary>
        internal bool IsSetCreateOpenSearchDataSource() => this.CreateOpenSearchDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateOracleDataSource. 
        /// <para>
        /// The ability to create Oracle data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateOracleDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateOracleDataSource property is set.
        /// </summary>
        internal bool IsSetCreateOracleDataSource() => this.CreateOracleDataSource != null;

        /// <summary>
        /// Gets and sets the property CreatePayPalDataSource. 
        /// <para>
        /// The ability to create PayPal data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreatePayPalDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreatePayPalDataSource property is set.
        /// </summary>
        internal bool IsSetCreatePayPalDataSource() => this.CreatePayPalDataSource != null;

        /// <summary>
        /// Gets and sets the property CreatePostgreSqlDataSource. 
        /// <para>
        /// The ability to create PostgreSQL data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreatePostgreSqlDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreatePostgreSqlDataSource property is set.
        /// </summary>
        internal bool IsSetCreatePostgreSqlDataSource() => this.CreatePostgreSqlDataSource != null;

        /// <summary>
        /// Gets and sets the property CreatePrestoDataSource. 
        /// <para>
        /// The ability to create Presto data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreatePrestoDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreatePrestoDataSource property is set.
        /// </summary>
        internal bool IsSetCreatePrestoDataSource() => this.CreatePrestoDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateRadiantDataSource. 
        /// <para>
        /// The ability to create Amazon QuickSight data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateRadiantDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateRadiantDataSource property is set.
        /// </summary>
        internal bool IsSetCreateRadiantDataSource() => this.CreateRadiantDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateRdsDataSource. 
        /// <para>
        /// The ability to create auto-discovered Amazon RDS data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateRdsDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateRdsDataSource property is set.
        /// </summary>
        internal bool IsSetCreateRdsDataSource() => this.CreateRdsDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateRedshiftAutoDiscoveredDataSource. 
        /// <para>
        /// The ability to create auto-discovered Amazon Redshift data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateRedshiftAutoDiscoveredDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateRedshiftAutoDiscoveredDataSource property is set.
        /// </summary>
        internal bool IsSetCreateRedshiftAutoDiscoveredDataSource() => this.CreateRedshiftAutoDiscoveredDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateRedshiftManualDataSource. 
        /// <para>
        /// The ability to create manually configured Amazon Redshift data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateRedshiftManualDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateRedshiftManualDataSource property is set.
        /// </summary>
        internal bool IsSetCreateRedshiftManualDataSource() => this.CreateRedshiftManualDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateS3AnalyticsDataSource. 
        /// <para>
        /// The ability to create Amazon S3 Analytics data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateS3AnalyticsDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateS3AnalyticsDataSource property is set.
        /// </summary>
        internal bool IsSetCreateS3AnalyticsDataSource() => this.CreateS3AnalyticsDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateS3DataSource. 
        /// <para>
        /// The ability to create Amazon S3 data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateS3DataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateS3DataSource property is set.
        /// </summary>
        internal bool IsSetCreateS3DataSource() => this.CreateS3DataSource != null;

        /// <summary>
        /// Gets and sets the property CreateS3TablesDataSource. 
        /// <para>
        /// The ability to create Amazon S3 Tables data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateS3TablesDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateS3TablesDataSource property is set.
        /// </summary>
        internal bool IsSetCreateS3TablesDataSource() => this.CreateS3TablesDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateSPICEDataset. 
        /// <para>
        /// The ability to create a SPICE dataset.
        /// </para>
        /// </summary>
        public CapabilityState CreateSPICEDataset { get; set; }

        /// <summary>
        /// Checks to see if the CreateSPICEDataset property is set.
        /// </summary>
        internal bool IsSetCreateSPICEDataset() => this.CreateSPICEDataset != null;

        /// <summary>
        /// Gets and sets the property CreateSalesforceDataSource. 
        /// <para>
        /// The ability to create Salesforce data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateSalesforceDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateSalesforceDataSource property is set.
        /// </summary>
        internal bool IsSetCreateSalesforceDataSource() => this.CreateSalesforceDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateSapHanaDataSource. 
        /// <para>
        /// The ability to create SAP HANA data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateSapHanaDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateSapHanaDataSource property is set.
        /// </summary>
        internal bool IsSetCreateSapHanaDataSource() => this.CreateSapHanaDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateServiceNowDataSource. 
        /// <para>
        /// The ability to create ServiceNow data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateServiceNowDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateServiceNowDataSource property is set.
        /// </summary>
        internal bool IsSetCreateServiceNowDataSource() => this.CreateServiceNowDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateSharedFolders. 
        /// <para>
        /// The ability to create shared folders.
        /// </para>
        /// </summary>
        public CapabilityState CreateSharedFolders { get; set; }

        /// <summary>
        /// Checks to see if the CreateSharedFolders property is set.
        /// </summary>
        internal bool IsSetCreateSharedFolders() => this.CreateSharedFolders != null;

        /// <summary>
        /// Gets and sets the property CreateSnowflakeDataSource. 
        /// <para>
        /// The ability to create Snowflake data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateSnowflakeDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateSnowflakeDataSource property is set.
        /// </summary>
        internal bool IsSetCreateSnowflakeDataSource() => this.CreateSnowflakeDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateSpaces. 
        /// <para>
        /// The ability to create spaces.
        /// </para>
        /// </summary>
        public CapabilityState CreateSpaces { get; set; }

        /// <summary>
        /// Checks to see if the CreateSpaces property is set.
        /// </summary>
        internal bool IsSetCreateSpaces() => this.CreateSpaces != null;

        /// <summary>
        /// Gets and sets the property CreateSparkDataSource. 
        /// <para>
        /// The ability to create Spark data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateSparkDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateSparkDataSource property is set.
        /// </summary>
        internal bool IsSetCreateSparkDataSource() => this.CreateSparkDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateSqlServerDataSource. 
        /// <para>
        /// The ability to create SQL Server data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateSqlServerDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateSqlServerDataSource property is set.
        /// </summary>
        internal bool IsSetCreateSqlServerDataSource() => this.CreateSqlServerDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateSquareDataSource. 
        /// <para>
        /// The ability to create Square data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateSquareDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateSquareDataSource property is set.
        /// </summary>
        internal bool IsSetCreateSquareDataSource() => this.CreateSquareDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateStarburstDataSource. 
        /// <para>
        /// The ability to create Starburst data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateStarburstDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateStarburstDataSource property is set.
        /// </summary>
        internal bool IsSetCreateStarburstDataSource() => this.CreateStarburstDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateTeradataDataSource. 
        /// <para>
        /// The ability to create Teradata data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateTeradataDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateTeradataDataSource property is set.
        /// </summary>
        internal bool IsSetCreateTeradataDataSource() => this.CreateTeradataDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateTimestreamDataSource. 
        /// <para>
        /// The ability to create Amazon Timestream data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateTimestreamDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateTimestreamDataSource property is set.
        /// </summary>
        internal bool IsSetCreateTimestreamDataSource() => this.CreateTimestreamDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateTrinoDataSource. 
        /// <para>
        /// The ability to create Trino data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateTrinoDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateTrinoDataSource property is set.
        /// </summary>
        internal bool IsSetCreateTrinoDataSource() => this.CreateTrinoDataSource != null;

        /// <summary>
        /// Gets and sets the property CreateTwitterDataSource. 
        /// <para>
        /// The ability to create Twitter data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateTwitterDataSource { get; set; }

        /// <summary>
        /// Checks to see if the CreateTwitterDataSource property is set.
        /// </summary>
        internal bool IsSetCreateTwitterDataSource() => this.CreateTwitterDataSource != null;

        /// <summary>
        /// Gets and sets the property Dashboard. 
        /// <para>
        /// The ability to perform dashboard-related actions.
        /// </para>
        /// </summary>
        public CapabilityState Dashboard { get; set; }

        /// <summary>
        /// Checks to see if the Dashboard property is set.
        /// </summary>
        internal bool IsSetDashboard() => this.Dashboard != null;

        /// <summary>
        /// Gets and sets the property DatabricksDataSource. 
        /// <para>
        /// The ability to create, update, and share Databricks data sources.
        /// </para>
        /// </summary>
        public CapabilityState DatabricksDataSource { get; set; }

        /// <summary>
        /// Checks to see if the DatabricksDataSource property is set.
        /// </summary>
        internal bool IsSetDatabricksDataSource() => this.DatabricksDataSource != null;

        /// <summary>
        /// Gets and sets the property Db2DataSource. 
        /// <para>
        /// The ability to create, update, and share Db2 data sources.
        /// </para>
        /// </summary>
        public CapabilityState Db2DataSource { get; set; }

        /// <summary>
        /// Checks to see if the Db2DataSource property is set.
        /// </summary>
        internal bool IsSetDb2DataSource() => this.Db2DataSource != null;

        /// <summary>
        /// Gets and sets the property DenodoDataSource. 
        /// <para>
        /// The ability to create, update, and share Denodo data sources.
        /// </para>
        /// </summary>
        public CapabilityState DenodoDataSource { get; set; }

        /// <summary>
        /// Checks to see if the DenodoDataSource property is set.
        /// </summary>
        internal bool IsSetDenodoDataSource() => this.DenodoDataSource != null;

        /// <summary>
        /// Gets and sets the property DocumentDbDataSource. 
        /// <para>
        /// The ability to create, update, and share Amazon DocumentDB data sources.
        /// </para>
        /// </summary>
        public CapabilityState DocumentDbDataSource { get; set; }

        /// <summary>
        /// Checks to see if the DocumentDbDataSource property is set.
        /// </summary>
        internal bool IsSetDocumentDbDataSource() => this.DocumentDbDataSource != null;

        /// <summary>
        /// Gets and sets the property DremioDataSource. 
        /// <para>
        /// The ability to create, update, and share Dremio data sources.
        /// </para>
        /// </summary>
        public CapabilityState DremioDataSource { get; set; }

        /// <summary>
        /// Checks to see if the DremioDataSource property is set.
        /// </summary>
        internal bool IsSetDremioDataSource() => this.DremioDataSource != null;

        /// <summary>
        /// Gets and sets the property DropboxAction. 
        /// <para>
        /// The ability to perform actions using Dropbox connectors.
        /// </para>
        /// </summary>
        public CapabilityState DropboxAction { get; set; }

        /// <summary>
        /// Checks to see if the DropboxAction property is set.
        /// </summary>
        internal bool IsSetDropboxAction() => this.DropboxAction != null;

        /// <summary>
        /// Gets and sets the property DunAndBradstreetAction. 
        /// <para>
        /// The ability to perform actions using Dun and Bradstreet connectors.
        /// </para>
        /// </summary>
        public CapabilityState DunAndBradstreetAction { get; set; }

        /// <summary>
        /// Checks to see if the DunAndBradstreetAction property is set.
        /// </summary>
        internal bool IsSetDunAndBradstreetAction() => this.DunAndBradstreetAction != null;

        /// <summary>
        /// Gets and sets the property DynamoDbDataSource. 
        /// <para>
        /// The ability to create, update, and share Amazon DynamoDB data sources.
        /// </para>
        /// </summary>
        public CapabilityState DynamoDbDataSource { get; set; }

        /// <summary>
        /// Checks to see if the DynamoDbDataSource property is set.
        /// </summary>
        internal bool IsSetDynamoDbDataSource() => this.DynamoDbDataSource != null;

        /// <summary>
        /// Gets and sets the property EditVisualWithQ. 
        /// <para>
        /// The ability to Edit Visual with AI
        /// </para>
        /// </summary>
        public CapabilityState EditVisualWithQ { get; set; }

        /// <summary>
        /// Checks to see if the EditVisualWithQ property is set.
        /// </summary>
        internal bool IsSetEditVisualWithQ() => this.EditVisualWithQ != null;

        /// <summary>
        /// Gets and sets the property ExasolDataSource. 
        /// <para>
        /// The ability to create, update, and share Exasol data sources.
        /// </para>
        /// </summary>
        public CapabilityState ExasolDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ExasolDataSource property is set.
        /// </summary>
        internal bool IsSetExasolDataSource() => this.ExasolDataSource != null;

        /// <summary>
        /// Gets and sets the property ExportToCsv. 
        /// <para>
        /// The ability to export to CSV files from the UI.
        /// </para>
        /// </summary>
        public CapabilityState ExportToCsv { get; set; }

        /// <summary>
        /// Checks to see if the ExportToCsv property is set.
        /// </summary>
        internal bool IsSetExportToCsv() => this.ExportToCsv != null;

        /// <summary>
        /// Gets and sets the property ExportToCsvInScheduledReports. 
        /// <para>
        /// The ability to export to CSV files in scheduled email reports.
        /// </para>
        /// </summary>
        public CapabilityState ExportToCsvInScheduledReports { get; set; }

        /// <summary>
        /// Checks to see if the ExportToCsvInScheduledReports property is set.
        /// </summary>
        internal bool IsSetExportToCsvInScheduledReports() => this.ExportToCsvInScheduledReports != null;

        /// <summary>
        /// Gets and sets the property ExportToExcel. 
        /// <para>
        /// The ability to export to Excel files from the UI.
        /// </para>
        /// </summary>
        public CapabilityState ExportToExcel { get; set; }

        /// <summary>
        /// Checks to see if the ExportToExcel property is set.
        /// </summary>
        internal bool IsSetExportToExcel() => this.ExportToExcel != null;

        /// <summary>
        /// Gets and sets the property ExportToExcelInScheduledReports. 
        /// <para>
        /// The ability to export to Excel files in scheduled email reports.
        /// </para>
        /// </summary>
        public CapabilityState ExportToExcelInScheduledReports { get; set; }

        /// <summary>
        /// Checks to see if the ExportToExcelInScheduledReports property is set.
        /// </summary>
        internal bool IsSetExportToExcelInScheduledReports() => this.ExportToExcelInScheduledReports != null;

        /// <summary>
        /// Gets and sets the property ExportToPdf. 
        /// <para>
        /// The ability to export to PDF files from the UI.
        /// </para>
        /// </summary>
        public CapabilityState ExportToPdf { get; set; }

        /// <summary>
        /// Checks to see if the ExportToPdf property is set.
        /// </summary>
        internal bool IsSetExportToPdf() => this.ExportToPdf != null;

        /// <summary>
        /// Gets and sets the property ExportToPdfInScheduledReports. 
        /// <para>
        /// The ability to export to PDF files in scheduled email reports.
        /// </para>
        /// </summary>
        public CapabilityState ExportToPdfInScheduledReports { get; set; }

        /// <summary>
        /// Checks to see if the ExportToPdfInScheduledReports property is set.
        /// </summary>
        internal bool IsSetExportToPdfInScheduledReports() => this.ExportToPdfInScheduledReports != null;

        /// <summary>
        /// Gets and sets the property Extension. 
        /// <para>
        /// The ability to perform Extension-related actions.
        /// </para>
        /// </summary>
        public CapabilityState Extension { get; set; }

        /// <summary>
        /// Checks to see if the Extension property is set.
        /// </summary>
        internal bool IsSetExtension() => this.Extension != null;

        /// <summary>
        /// Gets and sets the property FactSetAction. 
        /// <para>
        /// The ability to perform actions using FactSet connectors.
        /// </para>
        /// </summary>
        public CapabilityState FactSetAction { get; set; }

        /// <summary>
        /// Checks to see if the FactSetAction property is set.
        /// </summary>
        internal bool IsSetFactSetAction() => this.FactSetAction != null;

        /// <summary>
        /// Gets and sets the property FigmaAction. 
        /// <para>
        /// The ability to perform actions using Figma connectors.
        /// </para>
        /// </summary>
        public CapabilityState FigmaAction { get; set; }

        /// <summary>
        /// Checks to see if the FigmaAction property is set.
        /// </summary>
        internal bool IsSetFigmaAction() => this.FigmaAction != null;

        /// <summary>
        /// Gets and sets the property FileDataSource. 
        /// <para>
        /// The ability to create, update, and share file data sources.
        /// </para>
        /// </summary>
        public CapabilityState FileDataSource { get; set; }

        /// <summary>
        /// Checks to see if the FileDataSource property is set.
        /// </summary>
        internal bool IsSetFileDataSource() => this.FileDataSource != null;

        /// <summary>
        /// Gets and sets the property Flow. 
        /// <para>
        /// The ability to perform flow-related actions.
        /// </para>
        /// </summary>
        public CapabilityState Flow { get; set; }

        /// <summary>
        /// Checks to see if the Flow property is set.
        /// </summary>
        internal bool IsSetFlow() => this.Flow != null;

        /// <summary>
        /// Gets and sets the property GenerateAnalyses. 
        /// <para>
        /// The ability to generate analysis using AI
        /// </para>
        /// </summary>
        public CapabilityState GenerateAnalyses { get; set; }

        /// <summary>
        /// Checks to see if the GenerateAnalyses property is set.
        /// </summary>
        internal bool IsSetGenerateAnalyses() => this.GenerateAnalyses != null;

        /// <summary>
        /// Gets and sets the property GenericHTTPAction. 
        /// <para>
        /// The ability to perform actions using REST API connection connectors.
        /// </para>
        /// </summary>
        public CapabilityState GenericHTTPAction { get; set; }

        /// <summary>
        /// Checks to see if the GenericHTTPAction property is set.
        /// </summary>
        internal bool IsSetGenericHTTPAction() => this.GenericHTTPAction != null;

        /// <summary>
        /// Gets and sets the property GitHubDataSource. 
        /// <para>
        /// The ability to create, update, and share GitHub data sources.
        /// </para>
        /// </summary>
        public CapabilityState GitHubDataSource { get; set; }

        /// <summary>
        /// Checks to see if the GitHubDataSource property is set.
        /// </summary>
        internal bool IsSetGitHubDataSource() => this.GitHubDataSource != null;

        /// <summary>
        /// Gets and sets the property GithubAction. 
        /// <para>
        /// The ability to perform actions using GitHub connectors.
        /// </para>
        /// </summary>
        public CapabilityState GithubAction { get; set; }

        /// <summary>
        /// Checks to see if the GithubAction property is set.
        /// </summary>
        internal bool IsSetGithubAction() => this.GithubAction != null;

        /// <summary>
        /// Gets and sets the property GmailAction. 
        /// <para>
        /// The ability to perform actions using Gmail connectors.
        /// </para>
        /// </summary>
        public CapabilityState GmailAction { get; set; }

        /// <summary>
        /// Checks to see if the GmailAction property is set.
        /// </summary>
        internal bool IsSetGmailAction() => this.GmailAction != null;

        /// <summary>
        /// Gets and sets the property GongAction. 
        /// <para>
        /// The ability to perform actions using Gong connectors.
        /// </para>
        /// </summary>
        public CapabilityState GongAction { get; set; }

        /// <summary>
        /// Checks to see if the GongAction property is set.
        /// </summary>
        internal bool IsSetGongAction() => this.GongAction != null;

        /// <summary>
        /// Gets and sets the property GoogleAnalyticsAction. 
        /// <para>
        /// The ability to perform actions using Google Analytics connectors.
        /// </para>
        /// </summary>
        public CapabilityState GoogleAnalyticsAction { get; set; }

        /// <summary>
        /// Checks to see if the GoogleAnalyticsAction property is set.
        /// </summary>
        internal bool IsSetGoogleAnalyticsAction() => this.GoogleAnalyticsAction != null;

        /// <summary>
        /// Gets and sets the property GoogleAnalyticsDataSource. 
        /// <para>
        /// The ability to create, update, and share Google Analytics data sources.
        /// </para>
        /// </summary>
        public CapabilityState GoogleAnalyticsDataSource { get; set; }

        /// <summary>
        /// Checks to see if the GoogleAnalyticsDataSource property is set.
        /// </summary>
        internal bool IsSetGoogleAnalyticsDataSource() => this.GoogleAnalyticsDataSource != null;

        /// <summary>
        /// Gets and sets the property GoogleBigQueryDataSource. 
        /// <para>
        /// The ability to create, update, and share Google BigQuery data sources.
        /// </para>
        /// </summary>
        public CapabilityState GoogleBigQueryDataSource { get; set; }

        /// <summary>
        /// Checks to see if the GoogleBigQueryDataSource property is set.
        /// </summary>
        internal bool IsSetGoogleBigQueryDataSource() => this.GoogleBigQueryDataSource != null;

        /// <summary>
        /// Gets and sets the property GoogleCalendarAction. 
        /// <para>
        /// The ability to perform actions using Google Calendar connectors.
        /// </para>
        /// </summary>
        public CapabilityState GoogleCalendarAction { get; set; }

        /// <summary>
        /// Checks to see if the GoogleCalendarAction property is set.
        /// </summary>
        internal bool IsSetGoogleCalendarAction() => this.GoogleCalendarAction != null;

        /// <summary>
        /// Gets and sets the property GoogleChatAction. 
        /// <para>
        /// The ability to perform actions using Google Chat connectors.
        /// </para>
        /// </summary>
        public CapabilityState GoogleChatAction { get; set; }

        /// <summary>
        /// Checks to see if the GoogleChatAction property is set.
        /// </summary>
        internal bool IsSetGoogleChatAction() => this.GoogleChatAction != null;

        /// <summary>
        /// Gets and sets the property GoogleDocsAction. 
        /// <para>
        /// The ability to perform actions using Google Docs connectors.
        /// </para>
        /// </summary>
        public CapabilityState GoogleDocsAction { get; set; }

        /// <summary>
        /// Checks to see if the GoogleDocsAction property is set.
        /// </summary>
        internal bool IsSetGoogleDocsAction() => this.GoogleDocsAction != null;

        /// <summary>
        /// Gets and sets the property GoogleDriveAction. 
        /// <para>
        /// The ability to perform actions using Google Drive connectors.
        /// </para>
        /// </summary>
        public CapabilityState GoogleDriveAction { get; set; }

        /// <summary>
        /// Checks to see if the GoogleDriveAction property is set.
        /// </summary>
        internal bool IsSetGoogleDriveAction() => this.GoogleDriveAction != null;

        /// <summary>
        /// Gets and sets the property GoogleDriveKnowledgeBase.
        /// </summary>
        public CapabilityState GoogleDriveKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the GoogleDriveKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetGoogleDriveKnowledgeBase() => this.GoogleDriveKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property GoogleMeetAction. 
        /// <para>
        /// The ability to perform actions using Google Meet connectors.
        /// </para>
        /// </summary>
        public CapabilityState GoogleMeetAction { get; set; }

        /// <summary>
        /// Checks to see if the GoogleMeetAction property is set.
        /// </summary>
        internal bool IsSetGoogleMeetAction() => this.GoogleMeetAction != null;

        /// <summary>
        /// Gets and sets the property GoogleSheetsAction. 
        /// <para>
        /// The ability to perform actions using Google Sheets connectors.
        /// </para>
        /// </summary>
        public CapabilityState GoogleSheetsAction { get; set; }

        /// <summary>
        /// Checks to see if the GoogleSheetsAction property is set.
        /// </summary>
        internal bool IsSetGoogleSheetsAction() => this.GoogleSheetsAction != null;

        /// <summary>
        /// Gets and sets the property GoogleSheetsDataSource. 
        /// <para>
        /// The ability to create, update, and share Google Sheets data sources.
        /// </para>
        /// </summary>
        public CapabilityState GoogleSheetsDataSource { get; set; }

        /// <summary>
        /// Checks to see if the GoogleSheetsDataSource property is set.
        /// </summary>
        internal bool IsSetGoogleSheetsDataSource() => this.GoogleSheetsDataSource != null;

        /// <summary>
        /// Gets and sets the property GoogleSlidesAction. 
        /// <para>
        /// The ability to perform actions using Google Slides connectors.
        /// </para>
        /// </summary>
        public CapabilityState GoogleSlidesAction { get; set; }

        /// <summary>
        /// Checks to see if the GoogleSlidesAction property is set.
        /// </summary>
        internal bool IsSetGoogleSlidesAction() => this.GoogleSlidesAction != null;

        /// <summary>
        /// Gets and sets the property HGInsightsAction. 
        /// <para>
        /// The ability to perform actions using HG Insights Agent connectors.
        /// </para>
        /// </summary>
        public CapabilityState HGInsightsAction { get; set; }

        /// <summary>
        /// Checks to see if the HGInsightsAction property is set.
        /// </summary>
        internal bool IsSetHGInsightsAction() => this.HGInsightsAction != null;

        /// <summary>
        /// Gets and sets the property HubspotAction. 
        /// <para>
        /// The ability to perform actions using Hubspot connectors.
        /// </para>
        /// </summary>
        public CapabilityState HubspotAction { get; set; }

        /// <summary>
        /// Checks to see if the HubspotAction property is set.
        /// </summary>
        internal bool IsSetHubspotAction() => this.HubspotAction != null;

        /// <summary>
        /// Gets and sets the property HuggingFaceAction. 
        /// <para>
        /// The ability to perform actions using HuggingFace connectors.
        /// </para>
        /// </summary>
        public CapabilityState HuggingFaceAction { get; set; }

        /// <summary>
        /// Checks to see if the HuggingFaceAction property is set.
        /// </summary>
        internal bool IsSetHuggingFaceAction() => this.HuggingFaceAction != null;

        /// <summary>
        /// Gets and sets the property IDCKnowledgeBase.
        /// </summary>
        public CapabilityState IDCKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the IDCKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetIDCKnowledgeBase() => this.IDCKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property ImpalaDataSource. 
        /// <para>
        /// The ability to create, update, and share Impala data sources.
        /// </para>
        /// </summary>
        public CapabilityState ImpalaDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ImpalaDataSource property is set.
        /// </summary>
        internal bool IsSetImpalaDataSource() => this.ImpalaDataSource != null;

        /// <summary>
        /// Gets and sets the property InboundEmailTrigger. 
        /// <para>
        /// The ability to create, view, edit, delete, and run inbound email triggers for flows
        /// and automations.
        /// </para>
        /// </summary>
        public CapabilityState InboundEmailTrigger { get; set; }

        /// <summary>
        /// Checks to see if the InboundEmailTrigger property is set.
        /// </summary>
        internal bool IsSetInboundEmailTrigger() => this.InboundEmailTrigger != null;

        /// <summary>
        /// Gets and sets the property IncludeContentInScheduledReportsEmail. 
        /// <para>
        /// The ability to include content in scheduled email reports.
        /// </para>
        /// </summary>
        public CapabilityState IncludeContentInScheduledReportsEmail { get; set; }

        /// <summary>
        /// Checks to see if the IncludeContentInScheduledReportsEmail property is set.
        /// </summary>
        internal bool IsSetIncludeContentInScheduledReportsEmail() => this.IncludeContentInScheduledReportsEmail != null;

        /// <summary>
        /// Gets and sets the property IntercomAction. 
        /// <para>
        /// The ability to perform actions using Intercom connectors.
        /// </para>
        /// </summary>
        public CapabilityState IntercomAction { get; set; }

        /// <summary>
        /// Checks to see if the IntercomAction property is set.
        /// </summary>
        internal bool IsSetIntercomAction() => this.IntercomAction != null;

        /// <summary>
        /// Gets and sets the property InvokeAppsAIInference. 
        /// <para>
        /// The ability to add and invoke AI inference in new and existing apps.
        /// </para>
        /// </summary>
        public CapabilityState InvokeAppsAIInference { get; set; }

        /// <summary>
        /// Checks to see if the InvokeAppsAIInference property is set.
        /// </summary>
        internal bool IsSetInvokeAppsAIInference() => this.InvokeAppsAIInference != null;

        /// <summary>
        /// Gets and sets the property JiraAction. 
        /// <para>
        /// The ability to perform actions using Jira connectors.
        /// </para>
        /// </summary>
        public CapabilityState JiraAction { get; set; }

        /// <summary>
        /// Checks to see if the JiraAction property is set.
        /// </summary>
        internal bool IsSetJiraAction() => this.JiraAction != null;

        /// <summary>
        /// Gets and sets the property JiraDataSource. 
        /// <para>
        /// The ability to create, update, and share Jira data sources.
        /// </para>
        /// </summary>
        public CapabilityState JiraDataSource { get; set; }

        /// <summary>
        /// Checks to see if the JiraDataSource property is set.
        /// </summary>
        internal bool IsSetJiraDataSource() => this.JiraDataSource != null;

        /// <summary>
        /// Gets and sets the property KnowledgeBase. 
        /// <para>
        /// The ability to use knowledge bases to specify content from external applications.
        /// </para>
        /// </summary>
        public CapabilityState KnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBase property is set.
        /// </summary>
        internal bool IsSetKnowledgeBase() => this.KnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property LinearAction. 
        /// <para>
        /// The ability to perform actions using Linear connectors.
        /// </para>
        /// </summary>
        public CapabilityState LinearAction { get; set; }

        /// <summary>
        /// Checks to see if the LinearAction property is set.
        /// </summary>
        internal bool IsSetLinearAction() => this.LinearAction != null;

        /// <summary>
        /// Gets and sets the property MCPAction. 
        /// <para>
        /// The ability to perform actions using Model Context Protocol connectors.
        /// </para>
        /// </summary>
        public CapabilityState MCPAction { get; set; }

        /// <summary>
        /// Checks to see if the MCPAction property is set.
        /// </summary>
        internal bool IsSetMCPAction() => this.MCPAction != null;

        /// <summary>
        /// Gets and sets the property MSExchangeAction. 
        /// <para>
        /// The ability to perform actions using Microsoft Outlook connectors.
        /// </para>
        /// </summary>
        public CapabilityState MSExchangeAction { get; set; }

        /// <summary>
        /// Checks to see if the MSExchangeAction property is set.
        /// </summary>
        internal bool IsSetMSExchangeAction() => this.MSExchangeAction != null;

        /// <summary>
        /// Gets and sets the property MSTeamsAction. 
        /// <para>
        /// The ability to perform actions using Microsoft Teams connectors.
        /// </para>
        /// </summary>
        public CapabilityState MSTeamsAction { get; set; }

        /// <summary>
        /// Checks to see if the MSTeamsAction property is set.
        /// </summary>
        internal bool IsSetMSTeamsAction() => this.MSTeamsAction != null;

        /// <summary>
        /// Gets and sets the property ManageSharedFolders. 
        /// <para>
        /// The ability to create, update, delete and view shared folders (both restricted and
        /// unrestricted), ability to add any asset to shared folders, and ability to share the
        /// folders.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> This does <i>not</i> prevent inheriting access to assets that others
        /// share with them through folder membership.
        /// </para>
        /// </summary>
        public CapabilityState ManageSharedFolders { get; set; }

        /// <summary>
        /// Checks to see if the ManageSharedFolders property is set.
        /// </summary>
        internal bool IsSetManageSharedFolders() => this.ManageSharedFolders != null;

        /// <summary>
        /// Gets and sets the property MariaDbDataSource. 
        /// <para>
        /// The ability to create, update, and share MariaDB data sources.
        /// </para>
        /// </summary>
        public CapabilityState MariaDbDataSource { get; set; }

        /// <summary>
        /// Checks to see if the MariaDbDataSource property is set.
        /// </summary>
        internal bool IsSetMariaDbDataSource() => this.MariaDbDataSource != null;

        /// <summary>
        /// Gets and sets the property MondayAction. 
        /// <para>
        /// The ability to perform actions using Monday connectors.
        /// </para>
        /// </summary>
        public CapabilityState MondayAction { get; set; }

        /// <summary>
        /// Checks to see if the MondayAction property is set.
        /// </summary>
        internal bool IsSetMondayAction() => this.MondayAction != null;

        /// <summary>
        /// Gets and sets the property MongoAtlasDataSource. 
        /// <para>
        /// The ability to create, update, and share MongoDB Atlas data sources.
        /// </para>
        /// </summary>
        public CapabilityState MongoAtlasDataSource { get; set; }

        /// <summary>
        /// Checks to see if the MongoAtlasDataSource property is set.
        /// </summary>
        internal bool IsSetMongoAtlasDataSource() => this.MongoAtlasDataSource != null;

        /// <summary>
        /// Gets and sets the property MongoDbDataSource. 
        /// <para>
        /// The ability to create, update, and share MongoDB data sources.
        /// </para>
        /// </summary>
        public CapabilityState MongoDbDataSource { get; set; }

        /// <summary>
        /// Checks to see if the MongoDbDataSource property is set.
        /// </summary>
        internal bool IsSetMongoDbDataSource() => this.MongoDbDataSource != null;

        /// <summary>
        /// Gets and sets the property MoodysAction. 
        /// <para>
        /// The ability to perform actions using Moody's GenAI Ready Data connectors.
        /// </para>
        /// </summary>
        public CapabilityState MoodysAction { get; set; }

        /// <summary>
        /// Checks to see if the MoodysAction property is set.
        /// </summary>
        internal bool IsSetMoodysAction() => this.MoodysAction != null;

        /// <summary>
        /// Gets and sets the property MySqlDataSource. 
        /// <para>
        /// The ability to create, update, and share MySQL data sources.
        /// </para>
        /// </summary>
        public CapabilityState MySqlDataSource { get; set; }

        /// <summary>
        /// Checks to see if the MySqlDataSource property is set.
        /// </summary>
        internal bool IsSetMySqlDataSource() => this.MySqlDataSource != null;

        /// <summary>
        /// Gets and sets the property NewRelicAction. 
        /// <para>
        /// The ability to perform actions using New Relic connectors.
        /// </para>
        /// </summary>
        public CapabilityState NewRelicAction { get; set; }

        /// <summary>
        /// Checks to see if the NewRelicAction property is set.
        /// </summary>
        internal bool IsSetNewRelicAction() => this.NewRelicAction != null;

        /// <summary>
        /// Gets and sets the property NotionAction. 
        /// <para>
        /// The ability to perform actions using Notion connectors.
        /// </para>
        /// </summary>
        public CapabilityState NotionAction { get; set; }

        /// <summary>
        /// Checks to see if the NotionAction property is set.
        /// </summary>
        internal bool IsSetNotionAction() => this.NotionAction != null;

        /// <summary>
        /// Gets and sets the property OneDriveAction. 
        /// <para>
        /// The ability to perform actions using Microsoft OneDrive connectors.
        /// </para>
        /// </summary>
        public CapabilityState OneDriveAction { get; set; }

        /// <summary>
        /// Checks to see if the OneDriveAction property is set.
        /// </summary>
        internal bool IsSetOneDriveAction() => this.OneDriveAction != null;

        /// <summary>
        /// Gets and sets the property OneDriveKnowledgeBase.
        /// </summary>
        public CapabilityState OneDriveKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the OneDriveKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetOneDriveKnowledgeBase() => this.OneDriveKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property OneNoteAction. 
        /// <para>
        /// The ability to perform actions using Microsoft OneNote connectors.
        /// </para>
        /// </summary>
        public CapabilityState OneNoteAction { get; set; }

        /// <summary>
        /// Checks to see if the OneNoteAction property is set.
        /// </summary>
        internal bool IsSetOneNoteAction() => this.OneNoteAction != null;

        /// <summary>
        /// Gets and sets the property OpenAPIAction. 
        /// <para>
        /// The ability to perform actions using OpenAPI Specification connectors.
        /// </para>
        /// </summary>
        public CapabilityState OpenAPIAction { get; set; }

        /// <summary>
        /// Checks to see if the OpenAPIAction property is set.
        /// </summary>
        internal bool IsSetOpenAPIAction() => this.OpenAPIAction != null;

        /// <summary>
        /// Gets and sets the property OpenSearchDataSource. 
        /// <para>
        /// The ability to create, update, and share Amazon OpenSearch Service data sources.
        /// </para>
        /// </summary>
        public CapabilityState OpenSearchDataSource { get; set; }

        /// <summary>
        /// Checks to see if the OpenSearchDataSource property is set.
        /// </summary>
        internal bool IsSetOpenSearchDataSource() => this.OpenSearchDataSource != null;

        /// <summary>
        /// Gets and sets the property OracleDataSource. 
        /// <para>
        /// The ability to create, update, and share Oracle data sources.
        /// </para>
        /// </summary>
        public CapabilityState OracleDataSource { get; set; }

        /// <summary>
        /// Checks to see if the OracleDataSource property is set.
        /// </summary>
        internal bool IsSetOracleDataSource() => this.OracleDataSource != null;

        /// <summary>
        /// Gets and sets the property PagerDutyAction. 
        /// <para>
        /// The ability to perform actions using PagerDuty Advance connectors.
        /// </para>
        /// </summary>
        public CapabilityState PagerDutyAction { get; set; }

        /// <summary>
        /// Checks to see if the PagerDutyAction property is set.
        /// </summary>
        internal bool IsSetPagerDutyAction() => this.PagerDutyAction != null;

        /// <summary>
        /// Gets and sets the property PagerDutyAgentAction. 
        /// <para>
        /// The ability to perform actions using PagerDuty Agent connectors.
        /// </para>
        /// </summary>
        public CapabilityState PagerDutyAgentAction { get; set; }

        /// <summary>
        /// Checks to see if the PagerDutyAgentAction property is set.
        /// </summary>
        internal bool IsSetPagerDutyAgentAction() => this.PagerDutyAgentAction != null;

        /// <summary>
        /// Gets and sets the property PayPalDataSource. 
        /// <para>
        /// The ability to create, update, and share PayPal data sources.
        /// </para>
        /// </summary>
        public CapabilityState PayPalDataSource { get; set; }

        /// <summary>
        /// Checks to see if the PayPalDataSource property is set.
        /// </summary>
        internal bool IsSetPayPalDataSource() => this.PayPalDataSource != null;

        /// <summary>
        /// Gets and sets the property PerformFlowUiTask. 
        /// <para>
        /// The ability to use UI Agent step to perform tasks on public websites.
        /// </para>
        /// </summary>
        public CapabilityState PerformFlowUiTask { get; set; }

        /// <summary>
        /// Checks to see if the PerformFlowUiTask property is set.
        /// </summary>
        internal bool IsSetPerformFlowUiTask() => this.PerformFlowUiTask != null;

        /// <summary>
        /// Gets and sets the property PostgreSqlDataSource. 
        /// <para>
        /// The ability to create, update, and share PostgreSQL data sources.
        /// </para>
        /// </summary>
        public CapabilityState PostgreSqlDataSource { get; set; }

        /// <summary>
        /// Checks to see if the PostgreSqlDataSource property is set.
        /// </summary>
        internal bool IsSetPostgreSqlDataSource() => this.PostgreSqlDataSource != null;

        /// <summary>
        /// Gets and sets the property PrestoDataSource. 
        /// <para>
        /// The ability to create, update, and share Presto data sources.
        /// </para>
        /// </summary>
        public CapabilityState PrestoDataSource { get; set; }

        /// <summary>
        /// Checks to see if the PrestoDataSource property is set.
        /// </summary>
        internal bool IsSetPrestoDataSource() => this.PrestoDataSource != null;

        /// <summary>
        /// Gets and sets the property PrintReports. 
        /// <para>
        /// The ability to print reports.
        /// </para>
        /// </summary>
        public CapabilityState PrintReports { get; set; }

        /// <summary>
        /// Checks to see if the PrintReports property is set.
        /// </summary>
        internal bool IsSetPrintReports() => this.PrintReports != null;

        /// <summary>
        /// Gets and sets the property PublishWithoutApproval. 
        /// <para>
        /// The ability to enable approvals for flow share.
        /// </para>
        /// </summary>
        public CapabilityState PublishWithoutApproval { get; set; }

        /// <summary>
        /// Checks to see if the PublishWithoutApproval property is set.
        /// </summary>
        internal bool IsSetPublishWithoutApproval() => this.PublishWithoutApproval != null;

        /// <summary>
        /// Gets and sets the property QBusinessKnowledgeBase.
        /// </summary>
        public CapabilityState QBusinessKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the QBusinessKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetQBusinessKnowledgeBase() => this.QBusinessKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property QuickBooksAction. 
        /// <para>
        /// The ability to perform actions using QuickBooks connectors.
        /// </para>
        /// </summary>
        public CapabilityState QuickBooksAction { get; set; }

        /// <summary>
        /// Checks to see if the QuickBooksAction property is set.
        /// </summary>
        internal bool IsSetQuickBooksAction() => this.QuickBooksAction != null;

        /// <summary>
        /// Gets and sets the property QuickEventTrigger. 
        /// <para>
        /// The ability to create, view, edit, delete, and run Quick event triggers for flows
        /// and automations.
        /// </para>
        /// </summary>
        public CapabilityState QuickEventTrigger { get; set; }

        /// <summary>
        /// Checks to see if the QuickEventTrigger property is set.
        /// </summary>
        internal bool IsSetQuickEventTrigger() => this.QuickEventTrigger != null;

        /// <summary>
        /// Gets and sets the property RadiantDataSource. 
        /// <para>
        /// The ability to create, update, and share Amazon QuickSight data sources.
        /// </para>
        /// </summary>
        public CapabilityState RadiantDataSource { get; set; }

        /// <summary>
        /// Checks to see if the RadiantDataSource property is set.
        /// </summary>
        internal bool IsSetRadiantDataSource() => this.RadiantDataSource != null;

        /// <summary>
        /// Gets and sets the property RdsDataSource. 
        /// <para>
        /// The ability to create, update, and share auto-discovered Amazon RDS data sources.
        /// </para>
        /// </summary>
        public CapabilityState RdsDataSource { get; set; }

        /// <summary>
        /// Checks to see if the RdsDataSource property is set.
        /// </summary>
        internal bool IsSetRdsDataSource() => this.RdsDataSource != null;

        /// <summary>
        /// Gets and sets the property RedshiftAutoDiscoveredDataSource. 
        /// <para>
        /// The ability to create, update, and share auto-discovered Amazon Redshift data sources.
        /// </para>
        /// </summary>
        public CapabilityState RedshiftAutoDiscoveredDataSource { get; set; }

        /// <summary>
        /// Checks to see if the RedshiftAutoDiscoveredDataSource property is set.
        /// </summary>
        internal bool IsSetRedshiftAutoDiscoveredDataSource() => this.RedshiftAutoDiscoveredDataSource != null;

        /// <summary>
        /// Gets and sets the property RedshiftManualDataSource. 
        /// <para>
        /// The ability to create, update, and share manually configured Amazon Redshift data
        /// sources.
        /// </para>
        /// </summary>
        public CapabilityState RedshiftManualDataSource { get; set; }

        /// <summary>
        /// Checks to see if the RedshiftManualDataSource property is set.
        /// </summary>
        internal bool IsSetRedshiftManualDataSource() => this.RedshiftManualDataSource != null;

        /// <summary>
        /// Gets and sets the property RenameSharedFolders. 
        /// <para>
        /// The ability to rename shared folders.
        /// </para>
        /// </summary>
        public CapabilityState RenameSharedFolders { get; set; }

        /// <summary>
        /// Checks to see if the RenameSharedFolders property is set.
        /// </summary>
        internal bool IsSetRenameSharedFolders() => this.RenameSharedFolders != null;

        /// <summary>
        /// Gets and sets the property Research. 
        /// <para>
        /// The ability to perform research-related actions.
        /// </para>
        /// </summary>
        public CapabilityState Research { get; set; }

        /// <summary>
        /// Checks to see if the Research property is set.
        /// </summary>
        internal bool IsSetResearch() => this.Research != null;

        /// <summary>
        /// Gets and sets the property S3AnalyticsDataSource. 
        /// <para>
        /// The ability to create, update, and share Amazon S3 Analytics data sources.
        /// </para>
        /// </summary>
        public CapabilityState S3AnalyticsDataSource { get; set; }

        /// <summary>
        /// Checks to see if the S3AnalyticsDataSource property is set.
        /// </summary>
        internal bool IsSetS3AnalyticsDataSource() => this.S3AnalyticsDataSource != null;

        /// <summary>
        /// Gets and sets the property S3DataSource. 
        /// <para>
        /// The ability to create, update, and share Amazon S3 data sources.
        /// </para>
        /// </summary>
        public CapabilityState S3DataSource { get; set; }

        /// <summary>
        /// Checks to see if the S3DataSource property is set.
        /// </summary>
        internal bool IsSetS3DataSource() => this.S3DataSource != null;

        /// <summary>
        /// Gets and sets the property S3KnowledgeBase.
        /// </summary>
        public CapabilityState S3KnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the S3KnowledgeBase property is set.
        /// </summary>
        internal bool IsSetS3KnowledgeBase() => this.S3KnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property S3TablesDataSource. 
        /// <para>
        /// The ability to create, update, and share Amazon S3 Tables data sources.
        /// </para>
        /// </summary>
        public CapabilityState S3TablesDataSource { get; set; }

        /// <summary>
        /// Checks to see if the S3TablesDataSource property is set.
        /// </summary>
        internal bool IsSetS3TablesDataSource() => this.S3TablesDataSource != null;

        /// <summary>
        /// Gets and sets the property SAPBillOfMaterialAction. 
        /// <para>
        /// The ability to perform actions using SAP Bill of Materials connectors.
        /// </para>
        /// </summary>
        public CapabilityState SAPBillOfMaterialAction { get; set; }

        /// <summary>
        /// Checks to see if the SAPBillOfMaterialAction property is set.
        /// </summary>
        internal bool IsSetSAPBillOfMaterialAction() => this.SAPBillOfMaterialAction != null;

        /// <summary>
        /// Gets and sets the property SAPBusinessPartnerAction. 
        /// <para>
        /// The ability to perform actions using SAP Business Partner connectors.
        /// </para>
        /// </summary>
        public CapabilityState SAPBusinessPartnerAction { get; set; }

        /// <summary>
        /// Checks to see if the SAPBusinessPartnerAction property is set.
        /// </summary>
        internal bool IsSetSAPBusinessPartnerAction() => this.SAPBusinessPartnerAction != null;

        /// <summary>
        /// Gets and sets the property SAPMaterialStockAction. 
        /// <para>
        /// The ability to perform actions using SAP Material Stock connectors.
        /// </para>
        /// </summary>
        public CapabilityState SAPMaterialStockAction { get; set; }

        /// <summary>
        /// Checks to see if the SAPMaterialStockAction property is set.
        /// </summary>
        internal bool IsSetSAPMaterialStockAction() => this.SAPMaterialStockAction != null;

        /// <summary>
        /// Gets and sets the property SAPPhysicalInventoryAction. 
        /// <para>
        /// The ability to perform actions using SAP Physical Inventory connectors.
        /// </para>
        /// </summary>
        public CapabilityState SAPPhysicalInventoryAction { get; set; }

        /// <summary>
        /// Checks to see if the SAPPhysicalInventoryAction property is set.
        /// </summary>
        internal bool IsSetSAPPhysicalInventoryAction() => this.SAPPhysicalInventoryAction != null;

        /// <summary>
        /// Gets and sets the property SAPProductMasterDataAction. 
        /// <para>
        /// The ability to perform actions using SAP Product Master connectors.
        /// </para>
        /// </summary>
        public CapabilityState SAPProductMasterDataAction { get; set; }

        /// <summary>
        /// Checks to see if the SAPProductMasterDataAction property is set.
        /// </summary>
        internal bool IsSetSAPProductMasterDataAction() => this.SAPProductMasterDataAction != null;

        /// <summary>
        /// Gets and sets the property SalesforceAction. 
        /// <para>
        /// The ability to perform actions using Salesforce connectors.
        /// </para>
        /// </summary>
        public CapabilityState SalesforceAction { get; set; }

        /// <summary>
        /// Checks to see if the SalesforceAction property is set.
        /// </summary>
        internal bool IsSetSalesforceAction() => this.SalesforceAction != null;

        /// <summary>
        /// Gets and sets the property SalesforceDataSource. 
        /// <para>
        /// The ability to create, update, and share Salesforce data sources.
        /// </para>
        /// </summary>
        public CapabilityState SalesforceDataSource { get; set; }

        /// <summary>
        /// Checks to see if the SalesforceDataSource property is set.
        /// </summary>
        internal bool IsSetSalesforceDataSource() => this.SalesforceDataSource != null;

        /// <summary>
        /// Gets and sets the property SandPGMIAction. 
        /// <para>
        /// The ability to perform actions using S&amp;P Global Market Intelligence connectors.
        /// </para>
        /// </summary>
        public CapabilityState SandPGMIAction { get; set; }

        /// <summary>
        /// Checks to see if the SandPGMIAction property is set.
        /// </summary>
        internal bool IsSetSandPGMIAction() => this.SandPGMIAction != null;

        /// <summary>
        /// Gets and sets the property SandPGlobalEnergyAction. 
        /// <para>
        /// The ability to perform actions using S&amp;P Global Energy connectors.
        /// </para>
        /// </summary>
        public CapabilityState SandPGlobalEnergyAction { get; set; }

        /// <summary>
        /// Checks to see if the SandPGlobalEnergyAction property is set.
        /// </summary>
        internal bool IsSetSandPGlobalEnergyAction() => this.SandPGlobalEnergyAction != null;

        /// <summary>
        /// Gets and sets the property SapHanaDataSource. 
        /// <para>
        /// The ability to create, update, and share SAP HANA data sources.
        /// </para>
        /// </summary>
        public CapabilityState SapHanaDataSource { get; set; }

        /// <summary>
        /// Checks to see if the SapHanaDataSource property is set.
        /// </summary>
        internal bool IsSetSapHanaDataSource() => this.SapHanaDataSource != null;

        /// <summary>
        /// Gets and sets the property Scenario. 
        /// <para>
        /// The ability to perform Scenario-related actions.
        /// </para>
        /// </summary>
        public CapabilityState Scenario { get; set; }

        /// <summary>
        /// Checks to see if the Scenario property is set.
        /// </summary>
        internal bool IsSetScenario() => this.Scenario != null;

        /// <summary>
        /// Gets and sets the property ScheduleTrigger. 
        /// <para>
        /// The ability to create, view, edit, delete, and run schedule triggers for flows and
        /// automations.
        /// </para>
        /// </summary>
        public CapabilityState ScheduleTrigger { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleTrigger property is set.
        /// </summary>
        internal bool IsSetScheduleTrigger() => this.ScheduleTrigger != null;

        /// <summary>
        /// Gets and sets the property SelfUpgradeUserRole. 
        /// <para>
        /// The ability to enable users to upgrade their user role.
        /// </para>
        /// </summary>
        public CapabilityState SelfUpgradeUserRole { get; set; }

        /// <summary>
        /// Checks to see if the SelfUpgradeUserRole property is set.
        /// </summary>
        internal bool IsSetSelfUpgradeUserRole() => this.SelfUpgradeUserRole != null;

        /// <summary>
        /// Gets and sets the property ServiceNowAction. 
        /// <para>
        /// The ability to perform actions using ServiceNow connectors.
        /// </para>
        /// </summary>
        public CapabilityState ServiceNowAction { get; set; }

        /// <summary>
        /// Checks to see if the ServiceNowAction property is set.
        /// </summary>
        internal bool IsSetServiceNowAction() => this.ServiceNowAction != null;

        /// <summary>
        /// Gets and sets the property ServiceNowDataSource. 
        /// <para>
        /// The ability to create, update, and share ServiceNow data sources.
        /// </para>
        /// </summary>
        public CapabilityState ServiceNowDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ServiceNowDataSource property is set.
        /// </summary>
        internal bool IsSetServiceNowDataSource() => this.ServiceNowDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareAdobeAction. 
        /// <para>
        /// The ability to share Adobe Marketing Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareAdobeAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareAdobeAction property is set.
        /// </summary>
        internal bool IsSetShareAdobeAction() => this.ShareAdobeAction != null;

        /// <summary>
        /// Gets and sets the property ShareAdobeAnalyticsDataSource. 
        /// <para>
        /// The ability to share Adobe Analytics data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareAdobeAnalyticsDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareAdobeAnalyticsDataSource property is set.
        /// </summary>
        internal bool IsSetShareAdobeAnalyticsDataSource() => this.ShareAdobeAnalyticsDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareAirtableAction. 
        /// <para>
        /// The ability to share Airtable actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareAirtableAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareAirtableAction property is set.
        /// </summary>
        internal bool IsSetShareAirtableAction() => this.ShareAirtableAction != null;

        /// <summary>
        /// Gets and sets the property ShareAmazonBedrockARSAction. 
        /// <para>
        /// The ability to share Bedrock Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareAmazonBedrockARSAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareAmazonBedrockARSAction property is set.
        /// </summary>
        internal bool IsSetShareAmazonBedrockARSAction() => this.ShareAmazonBedrockARSAction != null;

        /// <summary>
        /// Gets and sets the property ShareAmazonBedrockFSAction. 
        /// <para>
        /// The ability to share Bedrock Runtime actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareAmazonBedrockFSAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareAmazonBedrockFSAction property is set.
        /// </summary>
        internal bool IsSetShareAmazonBedrockFSAction() => this.ShareAmazonBedrockFSAction != null;

        /// <summary>
        /// Gets and sets the property ShareAmazonBedrockKRSAction. 
        /// <para>
        /// The ability to share Bedrock Data Automation Runtime actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareAmazonBedrockKRSAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareAmazonBedrockKRSAction property is set.
        /// </summary>
        internal bool IsSetShareAmazonBedrockKRSAction() => this.ShareAmazonBedrockKRSAction != null;

        /// <summary>
        /// Gets and sets the property ShareAmazonSThreeAction. 
        /// <para>
        /// The ability to share Amazon S3 actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareAmazonSThreeAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareAmazonSThreeAction property is set.
        /// </summary>
        internal bool IsSetShareAmazonSThreeAction() => this.ShareAmazonSThreeAction != null;

        /// <summary>
        /// Gets and sets the property ShareAnalyses. 
        /// <para>
        /// The ability to share analyses.
        /// </para>
        /// </summary>
        public CapabilityState ShareAnalyses { get; set; }

        /// <summary>
        /// Checks to see if the ShareAnalyses property is set.
        /// </summary>
        internal bool IsSetShareAnalyses() => this.ShareAnalyses != null;

        /// <summary>
        /// Gets and sets the property ShareApps. 
        /// <para>
        /// The ability to share apps with other users.
        /// </para>
        /// </summary>
        public CapabilityState ShareApps { get; set; }

        /// <summary>
        /// Checks to see if the ShareApps property is set.
        /// </summary>
        internal bool IsSetShareApps() => this.ShareApps != null;

        /// <summary>
        /// Gets and sets the property ShareAsanaAction. 
        /// <para>
        /// The ability to share Asana actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareAsanaAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareAsanaAction property is set.
        /// </summary>
        internal bool IsSetShareAsanaAction() => this.ShareAsanaAction != null;

        /// <summary>
        /// Gets and sets the property ShareAthenaDataSource. 
        /// <para>
        /// The ability to share Amazon Athena data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareAthenaDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareAthenaDataSource property is set.
        /// </summary>
        internal bool IsSetShareAthenaDataSource() => this.ShareAthenaDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareAuroraDataSource. 
        /// <para>
        /// The ability to share Amazon Aurora data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareAuroraDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareAuroraDataSource property is set.
        /// </summary>
        internal bool IsSetShareAuroraDataSource() => this.ShareAuroraDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareBambooHRAction. 
        /// <para>
        /// The ability to share BambooHR actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareBambooHRAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareBambooHRAction property is set.
        /// </summary>
        internal bool IsSetShareBambooHRAction() => this.ShareBambooHRAction != null;

        /// <summary>
        /// Gets and sets the property ShareBedrockManagedKnowledgeBase.
        /// </summary>
        public CapabilityState ShareBedrockManagedKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the ShareBedrockManagedKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetShareBedrockManagedKnowledgeBase() => this.ShareBedrockManagedKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property ShareBeeAction. 
        /// <para>
        /// The ability to share Bee actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareBeeAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareBeeAction property is set.
        /// </summary>
        internal bool IsSetShareBeeAction() => this.ShareBeeAction != null;

        /// <summary>
        /// Gets and sets the property ShareBoxAgentAction. 
        /// <para>
        /// The ability to share Box Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareBoxAgentAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareBoxAgentAction property is set.
        /// </summary>
        internal bool IsSetShareBoxAgentAction() => this.ShareBoxAgentAction != null;

        /// <summary>
        /// Gets and sets the property ShareBoxKnowledgeBase.
        /// </summary>
        public CapabilityState ShareBoxKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the ShareBoxKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetShareBoxKnowledgeBase() => this.ShareBoxKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property ShareCanvaAgentAction. 
        /// <para>
        /// The ability to share Canva Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareCanvaAgentAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareCanvaAgentAction property is set.
        /// </summary>
        internal bool IsSetShareCanvaAgentAction() => this.ShareCanvaAgentAction != null;

        /// <summary>
        /// Gets and sets the property ShareChatAgents. 
        /// <para>
        /// The ability to share chat agents with other users and groups.
        /// </para>
        /// </summary>
        public CapabilityState ShareChatAgents { get; set; }

        /// <summary>
        /// Checks to see if the ShareChatAgents property is set.
        /// </summary>
        internal bool IsSetShareChatAgents() => this.ShareChatAgents != null;

        /// <summary>
        /// Gets and sets the property ShareCiscoWebexMeetingsAction. 
        /// <para>
        /// The ability to share Cisco Webex Meetings actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareCiscoWebexMeetingsAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareCiscoWebexMeetingsAction property is set.
        /// </summary>
        internal bool IsSetShareCiscoWebexMeetingsAction() => this.ShareCiscoWebexMeetingsAction != null;

        /// <summary>
        /// Gets and sets the property ShareCiscoWebexVidcastAction. 
        /// <para>
        /// The ability to share Cisco Webex Video Messaging Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareCiscoWebexVidcastAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareCiscoWebexVidcastAction property is set.
        /// </summary>
        internal bool IsSetShareCiscoWebexVidcastAction() => this.ShareCiscoWebexVidcastAction != null;

        /// <summary>
        /// Gets and sets the property ShareComprehendAction. 
        /// <para>
        /// The ability to share Comprehend actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareComprehendAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareComprehendAction property is set.
        /// </summary>
        internal bool IsSetShareComprehendAction() => this.ShareComprehendAction != null;

        /// <summary>
        /// Gets and sets the property ShareComprehendMedicalAction. 
        /// <para>
        /// The ability to share Comprehend Medical actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareComprehendMedicalAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareComprehendMedicalAction property is set.
        /// </summary>
        internal bool IsSetShareComprehendMedicalAction() => this.ShareComprehendMedicalAction != null;

        /// <summary>
        /// Gets and sets the property ShareConfluenceAction. 
        /// <para>
        /// The ability to share Atlassian Confluence Cloud actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareConfluenceAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareConfluenceAction property is set.
        /// </summary>
        internal bool IsSetShareConfluenceAction() => this.ShareConfluenceAction != null;

        /// <summary>
        /// Gets and sets the property ShareConfluenceKnowledgeBase.
        /// </summary>
        public CapabilityState ShareConfluenceKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the ShareConfluenceKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetShareConfluenceKnowledgeBase() => this.ShareConfluenceKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property ShareDashboards. 
        /// <para>
        /// The ability to share dashboards.
        /// </para>
        /// </summary>
        public CapabilityState ShareDashboards { get; set; }

        /// <summary>
        /// Checks to see if the ShareDashboards property is set.
        /// </summary>
        internal bool IsSetShareDashboards() => this.ShareDashboards != null;

        /// <summary>
        /// Gets and sets the property ShareDataSources. 
        /// <para>
        /// The ability to share data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareDataSources { get; set; }

        /// <summary>
        /// Checks to see if the ShareDataSources property is set.
        /// </summary>
        internal bool IsSetShareDataSources() => this.ShareDataSources != null;

        /// <summary>
        /// Gets and sets the property ShareDatabricksDataSource. 
        /// <para>
        /// The ability to share Databricks data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareDatabricksDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareDatabricksDataSource property is set.
        /// </summary>
        internal bool IsSetShareDatabricksDataSource() => this.ShareDatabricksDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareDatasets. 
        /// <para>
        /// The ability to share datasets.
        /// </para>
        /// </summary>
        public CapabilityState ShareDatasets { get; set; }

        /// <summary>
        /// Checks to see if the ShareDatasets property is set.
        /// </summary>
        internal bool IsSetShareDatasets() => this.ShareDatasets != null;

        /// <summary>
        /// Gets and sets the property ShareDb2DataSource. 
        /// <para>
        /// The ability to share Db2 data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareDb2DataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareDb2DataSource property is set.
        /// </summary>
        internal bool IsSetShareDb2DataSource() => this.ShareDb2DataSource != null;

        /// <summary>
        /// Gets and sets the property ShareDenodoDataSource. 
        /// <para>
        /// The ability to share Denodo data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareDenodoDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareDenodoDataSource property is set.
        /// </summary>
        internal bool IsSetShareDenodoDataSource() => this.ShareDenodoDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareDocumentDbDataSource. 
        /// <para>
        /// The ability to share Amazon DocumentDB data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareDocumentDbDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareDocumentDbDataSource property is set.
        /// </summary>
        internal bool IsSetShareDocumentDbDataSource() => this.ShareDocumentDbDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareDremioDataSource. 
        /// <para>
        /// The ability to share Dremio data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareDremioDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareDremioDataSource property is set.
        /// </summary>
        internal bool IsSetShareDremioDataSource() => this.ShareDremioDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareDropboxAction. 
        /// <para>
        /// The ability to share Dropbox actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareDropboxAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareDropboxAction property is set.
        /// </summary>
        internal bool IsSetShareDropboxAction() => this.ShareDropboxAction != null;

        /// <summary>
        /// Gets and sets the property ShareDunAndBradstreetAction. 
        /// <para>
        /// The ability to share Dun and Bradstreet actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareDunAndBradstreetAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareDunAndBradstreetAction property is set.
        /// </summary>
        internal bool IsSetShareDunAndBradstreetAction() => this.ShareDunAndBradstreetAction != null;

        /// <summary>
        /// Gets and sets the property ShareDynamoDbDataSource. 
        /// <para>
        /// The ability to share Amazon DynamoDB data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareDynamoDbDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareDynamoDbDataSource property is set.
        /// </summary>
        internal bool IsSetShareDynamoDbDataSource() => this.ShareDynamoDbDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareExasolDataSource. 
        /// <para>
        /// The ability to share Exasol data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareExasolDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareExasolDataSource property is set.
        /// </summary>
        internal bool IsSetShareExasolDataSource() => this.ShareExasolDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareFactSetAction. 
        /// <para>
        /// The ability to share FactSet actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareFactSetAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareFactSetAction property is set.
        /// </summary>
        internal bool IsSetShareFactSetAction() => this.ShareFactSetAction != null;

        /// <summary>
        /// Gets and sets the property ShareFigmaAction. 
        /// <para>
        /// The ability to share Figma actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareFigmaAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareFigmaAction property is set.
        /// </summary>
        internal bool IsSetShareFigmaAction() => this.ShareFigmaAction != null;

        /// <summary>
        /// Gets and sets the property ShareFileDataSource. 
        /// <para>
        /// The ability to share file data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareFileDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareFileDataSource property is set.
        /// </summary>
        internal bool IsSetShareFileDataSource() => this.ShareFileDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareGenericHTTPAction. 
        /// <para>
        /// The ability to share REST API connection actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareGenericHTTPAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareGenericHTTPAction property is set.
        /// </summary>
        internal bool IsSetShareGenericHTTPAction() => this.ShareGenericHTTPAction != null;

        /// <summary>
        /// Gets and sets the property ShareGitHubDataSource. 
        /// <para>
        /// The ability to share GitHub data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareGitHubDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareGitHubDataSource property is set.
        /// </summary>
        internal bool IsSetShareGitHubDataSource() => this.ShareGitHubDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareGithubAction. 
        /// <para>
        /// The ability to share GitHub actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareGithubAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareGithubAction property is set.
        /// </summary>
        internal bool IsSetShareGithubAction() => this.ShareGithubAction != null;

        /// <summary>
        /// Gets and sets the property ShareGmailAction. 
        /// <para>
        /// The ability to share Gmail actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareGmailAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareGmailAction property is set.
        /// </summary>
        internal bool IsSetShareGmailAction() => this.ShareGmailAction != null;

        /// <summary>
        /// Gets and sets the property ShareGongAction. 
        /// <para>
        /// The ability to share Gong actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareGongAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareGongAction property is set.
        /// </summary>
        internal bool IsSetShareGongAction() => this.ShareGongAction != null;

        /// <summary>
        /// Gets and sets the property ShareGoogleAnalyticsAction. 
        /// <para>
        /// The ability to share Google Analytics actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareGoogleAnalyticsAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareGoogleAnalyticsAction property is set.
        /// </summary>
        internal bool IsSetShareGoogleAnalyticsAction() => this.ShareGoogleAnalyticsAction != null;

        /// <summary>
        /// Gets and sets the property ShareGoogleAnalyticsDataSource. 
        /// <para>
        /// The ability to share Google Analytics data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareGoogleAnalyticsDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareGoogleAnalyticsDataSource property is set.
        /// </summary>
        internal bool IsSetShareGoogleAnalyticsDataSource() => this.ShareGoogleAnalyticsDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareGoogleBigQueryDataSource. 
        /// <para>
        /// The ability to share Google BigQuery data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareGoogleBigQueryDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareGoogleBigQueryDataSource property is set.
        /// </summary>
        internal bool IsSetShareGoogleBigQueryDataSource() => this.ShareGoogleBigQueryDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareGoogleCalendarAction. 
        /// <para>
        /// The ability to share Google Calendar actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareGoogleCalendarAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareGoogleCalendarAction property is set.
        /// </summary>
        internal bool IsSetShareGoogleCalendarAction() => this.ShareGoogleCalendarAction != null;

        /// <summary>
        /// Gets and sets the property ShareGoogleChatAction. 
        /// <para>
        /// The ability to share Google Chat actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareGoogleChatAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareGoogleChatAction property is set.
        /// </summary>
        internal bool IsSetShareGoogleChatAction() => this.ShareGoogleChatAction != null;

        /// <summary>
        /// Gets and sets the property ShareGoogleDocsAction. 
        /// <para>
        /// The ability to share Google Docs actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareGoogleDocsAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareGoogleDocsAction property is set.
        /// </summary>
        internal bool IsSetShareGoogleDocsAction() => this.ShareGoogleDocsAction != null;

        /// <summary>
        /// Gets and sets the property ShareGoogleDriveAction. 
        /// <para>
        /// The ability to share Google Drive actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareGoogleDriveAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareGoogleDriveAction property is set.
        /// </summary>
        internal bool IsSetShareGoogleDriveAction() => this.ShareGoogleDriveAction != null;

        /// <summary>
        /// Gets and sets the property ShareGoogleDriveKnowledgeBase.
        /// </summary>
        public CapabilityState ShareGoogleDriveKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the ShareGoogleDriveKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetShareGoogleDriveKnowledgeBase() => this.ShareGoogleDriveKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property ShareGoogleMeetAction. 
        /// <para>
        /// The ability to share Google Meet actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareGoogleMeetAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareGoogleMeetAction property is set.
        /// </summary>
        internal bool IsSetShareGoogleMeetAction() => this.ShareGoogleMeetAction != null;

        /// <summary>
        /// Gets and sets the property ShareGoogleSheetsAction. 
        /// <para>
        /// The ability to share Google Sheets actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareGoogleSheetsAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareGoogleSheetsAction property is set.
        /// </summary>
        internal bool IsSetShareGoogleSheetsAction() => this.ShareGoogleSheetsAction != null;

        /// <summary>
        /// Gets and sets the property ShareGoogleSheetsDataSource. 
        /// <para>
        /// The ability to share Google Sheets data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareGoogleSheetsDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareGoogleSheetsDataSource property is set.
        /// </summary>
        internal bool IsSetShareGoogleSheetsDataSource() => this.ShareGoogleSheetsDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareGoogleSlidesAction. 
        /// <para>
        /// The ability to share Google Slides actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareGoogleSlidesAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareGoogleSlidesAction property is set.
        /// </summary>
        internal bool IsSetShareGoogleSlidesAction() => this.ShareGoogleSlidesAction != null;

        /// <summary>
        /// Gets and sets the property ShareHGInsightsAction. 
        /// <para>
        /// The ability to share HG Insights Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareHGInsightsAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareHGInsightsAction property is set.
        /// </summary>
        internal bool IsSetShareHGInsightsAction() => this.ShareHGInsightsAction != null;

        /// <summary>
        /// Gets and sets the property ShareHubspotAction. 
        /// <para>
        /// The ability to share Hubspot actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareHubspotAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareHubspotAction property is set.
        /// </summary>
        internal bool IsSetShareHubspotAction() => this.ShareHubspotAction != null;

        /// <summary>
        /// Gets and sets the property ShareHuggingFaceAction. 
        /// <para>
        /// The ability to share HuggingFace actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareHuggingFaceAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareHuggingFaceAction property is set.
        /// </summary>
        internal bool IsSetShareHuggingFaceAction() => this.ShareHuggingFaceAction != null;

        /// <summary>
        /// Gets and sets the property ShareIDCKnowledgeBase.
        /// </summary>
        public CapabilityState ShareIDCKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the ShareIDCKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetShareIDCKnowledgeBase() => this.ShareIDCKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property ShareImpalaDataSource. 
        /// <para>
        /// The ability to share Impala data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareImpalaDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareImpalaDataSource property is set.
        /// </summary>
        internal bool IsSetShareImpalaDataSource() => this.ShareImpalaDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareIntercomAction. 
        /// <para>
        /// The ability to share Intercom actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareIntercomAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareIntercomAction property is set.
        /// </summary>
        internal bool IsSetShareIntercomAction() => this.ShareIntercomAction != null;

        /// <summary>
        /// Gets and sets the property ShareJiraAction. 
        /// <para>
        /// The ability to share Jira actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareJiraAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareJiraAction property is set.
        /// </summary>
        internal bool IsSetShareJiraAction() => this.ShareJiraAction != null;

        /// <summary>
        /// Gets and sets the property ShareJiraDataSource. 
        /// <para>
        /// The ability to share Jira data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareJiraDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareJiraDataSource property is set.
        /// </summary>
        internal bool IsSetShareJiraDataSource() => this.ShareJiraDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareKnowledgeBases.
        /// </summary>
        public CapabilityState ShareKnowledgeBases { get; set; }

        /// <summary>
        /// Checks to see if the ShareKnowledgeBases property is set.
        /// </summary>
        internal bool IsSetShareKnowledgeBases() => this.ShareKnowledgeBases != null;

        /// <summary>
        /// Gets and sets the property ShareLinearAction. 
        /// <para>
        /// The ability to share Linear actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareLinearAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareLinearAction property is set.
        /// </summary>
        internal bool IsSetShareLinearAction() => this.ShareLinearAction != null;

        /// <summary>
        /// Gets and sets the property ShareMCPAction. 
        /// <para>
        /// The ability to share Model Context Protocol actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareMCPAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareMCPAction property is set.
        /// </summary>
        internal bool IsSetShareMCPAction() => this.ShareMCPAction != null;

        /// <summary>
        /// Gets and sets the property ShareMSExchangeAction. 
        /// <para>
        /// The ability to share Microsoft Outlook actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareMSExchangeAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareMSExchangeAction property is set.
        /// </summary>
        internal bool IsSetShareMSExchangeAction() => this.ShareMSExchangeAction != null;

        /// <summary>
        /// Gets and sets the property ShareMSTeamsAction. 
        /// <para>
        /// The ability to share Microsoft Teams actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareMSTeamsAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareMSTeamsAction property is set.
        /// </summary>
        internal bool IsSetShareMSTeamsAction() => this.ShareMSTeamsAction != null;

        /// <summary>
        /// Gets and sets the property ShareMariaDbDataSource. 
        /// <para>
        /// The ability to share MariaDB data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareMariaDbDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareMariaDbDataSource property is set.
        /// </summary>
        internal bool IsSetShareMariaDbDataSource() => this.ShareMariaDbDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareMondayAction. 
        /// <para>
        /// The ability to share Monday actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareMondayAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareMondayAction property is set.
        /// </summary>
        internal bool IsSetShareMondayAction() => this.ShareMondayAction != null;

        /// <summary>
        /// Gets and sets the property ShareMongoAtlasDataSource. 
        /// <para>
        /// The ability to share MongoDB Atlas data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareMongoAtlasDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareMongoAtlasDataSource property is set.
        /// </summary>
        internal bool IsSetShareMongoAtlasDataSource() => this.ShareMongoAtlasDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareMongoDbDataSource. 
        /// <para>
        /// The ability to share MongoDB data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareMongoDbDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareMongoDbDataSource property is set.
        /// </summary>
        internal bool IsSetShareMongoDbDataSource() => this.ShareMongoDbDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareMoodysAction. 
        /// <para>
        /// The ability to share Moody's GenAI Ready Data actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareMoodysAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareMoodysAction property is set.
        /// </summary>
        internal bool IsSetShareMoodysAction() => this.ShareMoodysAction != null;

        /// <summary>
        /// Gets and sets the property ShareMySqlDataSource. 
        /// <para>
        /// The ability to share MySQL data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareMySqlDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareMySqlDataSource property is set.
        /// </summary>
        internal bool IsSetShareMySqlDataSource() => this.ShareMySqlDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareNewRelicAction. 
        /// <para>
        /// The ability to share New Relic actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareNewRelicAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareNewRelicAction property is set.
        /// </summary>
        internal bool IsSetShareNewRelicAction() => this.ShareNewRelicAction != null;

        /// <summary>
        /// Gets and sets the property ShareNotionAction. 
        /// <para>
        /// The ability to share Notion actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareNotionAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareNotionAction property is set.
        /// </summary>
        internal bool IsSetShareNotionAction() => this.ShareNotionAction != null;

        /// <summary>
        /// Gets and sets the property ShareOneDriveAction. 
        /// <para>
        /// The ability to share Microsoft OneDrive actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareOneDriveAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareOneDriveAction property is set.
        /// </summary>
        internal bool IsSetShareOneDriveAction() => this.ShareOneDriveAction != null;

        /// <summary>
        /// Gets and sets the property ShareOneDriveKnowledgeBase.
        /// </summary>
        public CapabilityState ShareOneDriveKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the ShareOneDriveKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetShareOneDriveKnowledgeBase() => this.ShareOneDriveKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property ShareOneNoteAction. 
        /// <para>
        /// The ability to share Microsoft OneNote actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareOneNoteAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareOneNoteAction property is set.
        /// </summary>
        internal bool IsSetShareOneNoteAction() => this.ShareOneNoteAction != null;

        /// <summary>
        /// Gets and sets the property ShareOpenAPIAction. 
        /// <para>
        /// The ability to share OpenAPI Specification actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareOpenAPIAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareOpenAPIAction property is set.
        /// </summary>
        internal bool IsSetShareOpenAPIAction() => this.ShareOpenAPIAction != null;

        /// <summary>
        /// Gets and sets the property ShareOpenSearchDataSource. 
        /// <para>
        /// The ability to share Amazon OpenSearch Service data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareOpenSearchDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareOpenSearchDataSource property is set.
        /// </summary>
        internal bool IsSetShareOpenSearchDataSource() => this.ShareOpenSearchDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareOracleDataSource. 
        /// <para>
        /// The ability to share Oracle data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareOracleDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareOracleDataSource property is set.
        /// </summary>
        internal bool IsSetShareOracleDataSource() => this.ShareOracleDataSource != null;

        /// <summary>
        /// Gets and sets the property SharePagerDutyAction. 
        /// <para>
        /// The ability to share PagerDuty Advance actions.
        /// </para>
        /// </summary>
        public CapabilityState SharePagerDutyAction { get; set; }

        /// <summary>
        /// Checks to see if the SharePagerDutyAction property is set.
        /// </summary>
        internal bool IsSetSharePagerDutyAction() => this.SharePagerDutyAction != null;

        /// <summary>
        /// Gets and sets the property SharePagerDutyAgentAction. 
        /// <para>
        /// The ability to share PagerDuty Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState SharePagerDutyAgentAction { get; set; }

        /// <summary>
        /// Checks to see if the SharePagerDutyAgentAction property is set.
        /// </summary>
        internal bool IsSetSharePagerDutyAgentAction() => this.SharePagerDutyAgentAction != null;

        /// <summary>
        /// Gets and sets the property SharePayPalDataSource. 
        /// <para>
        /// The ability to share PayPal data sources.
        /// </para>
        /// </summary>
        public CapabilityState SharePayPalDataSource { get; set; }

        /// <summary>
        /// Checks to see if the SharePayPalDataSource property is set.
        /// </summary>
        internal bool IsSetSharePayPalDataSource() => this.SharePayPalDataSource != null;

        /// <summary>
        /// Gets and sets the property SharePointAction. 
        /// <para>
        /// The ability to perform actions using Microsoft SharePoint Online connectors.
        /// </para>
        /// </summary>
        public CapabilityState SharePointAction { get; set; }

        /// <summary>
        /// Checks to see if the SharePointAction property is set.
        /// </summary>
        internal bool IsSetSharePointAction() => this.SharePointAction != null;

        /// <summary>
        /// Gets and sets the property SharePointKnowledgeBase.
        /// </summary>
        public CapabilityState SharePointKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the SharePointKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetSharePointKnowledgeBase() => this.SharePointKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property SharePostgreSqlDataSource. 
        /// <para>
        /// The ability to share PostgreSQL data sources.
        /// </para>
        /// </summary>
        public CapabilityState SharePostgreSqlDataSource { get; set; }

        /// <summary>
        /// Checks to see if the SharePostgreSqlDataSource property is set.
        /// </summary>
        internal bool IsSetSharePostgreSqlDataSource() => this.SharePostgreSqlDataSource != null;

        /// <summary>
        /// Gets and sets the property SharePrestoDataSource. 
        /// <para>
        /// The ability to share Presto data sources.
        /// </para>
        /// </summary>
        public CapabilityState SharePrestoDataSource { get; set; }

        /// <summary>
        /// Checks to see if the SharePrestoDataSource property is set.
        /// </summary>
        internal bool IsSetSharePrestoDataSource() => this.SharePrestoDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareQBusinessKnowledgeBase.
        /// </summary>
        public CapabilityState ShareQBusinessKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the ShareQBusinessKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetShareQBusinessKnowledgeBase() => this.ShareQBusinessKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property ShareQuickBooksAction. 
        /// <para>
        /// The ability to share QuickBooks actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareQuickBooksAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareQuickBooksAction property is set.
        /// </summary>
        internal bool IsSetShareQuickBooksAction() => this.ShareQuickBooksAction != null;

        /// <summary>
        /// Gets and sets the property ShareRadiantDataSource. 
        /// <para>
        /// The ability to share Amazon QuickSight data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareRadiantDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareRadiantDataSource property is set.
        /// </summary>
        internal bool IsSetShareRadiantDataSource() => this.ShareRadiantDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareRdsDataSource. 
        /// <para>
        /// The ability to share auto-discovered Amazon RDS data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareRdsDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareRdsDataSource property is set.
        /// </summary>
        internal bool IsSetShareRdsDataSource() => this.ShareRdsDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareRedshiftAutoDiscoveredDataSource. 
        /// <para>
        /// The ability to share auto-discovered Amazon Redshift data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareRedshiftAutoDiscoveredDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareRedshiftAutoDiscoveredDataSource property is set.
        /// </summary>
        internal bool IsSetShareRedshiftAutoDiscoveredDataSource() => this.ShareRedshiftAutoDiscoveredDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareRedshiftManualDataSource. 
        /// <para>
        /// The ability to share manually configured Amazon Redshift data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareRedshiftManualDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareRedshiftManualDataSource property is set.
        /// </summary>
        internal bool IsSetShareRedshiftManualDataSource() => this.ShareRedshiftManualDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareS3AnalyticsDataSource. 
        /// <para>
        /// The ability to share Amazon S3 Analytics data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareS3AnalyticsDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareS3AnalyticsDataSource property is set.
        /// </summary>
        internal bool IsSetShareS3AnalyticsDataSource() => this.ShareS3AnalyticsDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareS3DataSource. 
        /// <para>
        /// The ability to share Amazon S3 data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareS3DataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareS3DataSource property is set.
        /// </summary>
        internal bool IsSetShareS3DataSource() => this.ShareS3DataSource != null;

        /// <summary>
        /// Gets and sets the property ShareS3KnowledgeBase.
        /// </summary>
        public CapabilityState ShareS3KnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the ShareS3KnowledgeBase property is set.
        /// </summary>
        internal bool IsSetShareS3KnowledgeBase() => this.ShareS3KnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property ShareS3TablesDataSource. 
        /// <para>
        /// The ability to share Amazon S3 Tables data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareS3TablesDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareS3TablesDataSource property is set.
        /// </summary>
        internal bool IsSetShareS3TablesDataSource() => this.ShareS3TablesDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareSAPBillOfMaterialAction. 
        /// <para>
        /// The ability to share SAP Bill of Materials actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareSAPBillOfMaterialAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareSAPBillOfMaterialAction property is set.
        /// </summary>
        internal bool IsSetShareSAPBillOfMaterialAction() => this.ShareSAPBillOfMaterialAction != null;

        /// <summary>
        /// Gets and sets the property ShareSAPBusinessPartnerAction. 
        /// <para>
        /// The ability to share SAP Business Partner actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareSAPBusinessPartnerAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareSAPBusinessPartnerAction property is set.
        /// </summary>
        internal bool IsSetShareSAPBusinessPartnerAction() => this.ShareSAPBusinessPartnerAction != null;

        /// <summary>
        /// Gets and sets the property ShareSAPMaterialStockAction. 
        /// <para>
        /// The ability to share SAP Material Stock actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareSAPMaterialStockAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareSAPMaterialStockAction property is set.
        /// </summary>
        internal bool IsSetShareSAPMaterialStockAction() => this.ShareSAPMaterialStockAction != null;

        /// <summary>
        /// Gets and sets the property ShareSAPPhysicalInventoryAction. 
        /// <para>
        /// The ability to share SAP Physical Inventory actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareSAPPhysicalInventoryAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareSAPPhysicalInventoryAction property is set.
        /// </summary>
        internal bool IsSetShareSAPPhysicalInventoryAction() => this.ShareSAPPhysicalInventoryAction != null;

        /// <summary>
        /// Gets and sets the property ShareSAPProductMasterDataAction. 
        /// <para>
        /// The ability to share SAP Product Master actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareSAPProductMasterDataAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareSAPProductMasterDataAction property is set.
        /// </summary>
        internal bool IsSetShareSAPProductMasterDataAction() => this.ShareSAPProductMasterDataAction != null;

        /// <summary>
        /// Gets and sets the property ShareSalesforceAction. 
        /// <para>
        /// The ability to share Salesforce actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareSalesforceAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareSalesforceAction property is set.
        /// </summary>
        internal bool IsSetShareSalesforceAction() => this.ShareSalesforceAction != null;

        /// <summary>
        /// Gets and sets the property ShareSalesforceDataSource. 
        /// <para>
        /// The ability to share Salesforce data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareSalesforceDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareSalesforceDataSource property is set.
        /// </summary>
        internal bool IsSetShareSalesforceDataSource() => this.ShareSalesforceDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareSandPGMIAction. 
        /// <para>
        /// The ability to share S&amp;P Global Market Intelligence actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareSandPGMIAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareSandPGMIAction property is set.
        /// </summary>
        internal bool IsSetShareSandPGMIAction() => this.ShareSandPGMIAction != null;

        /// <summary>
        /// Gets and sets the property ShareSandPGlobalEnergyAction. 
        /// <para>
        /// The ability to share S&amp;P Global Energy actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareSandPGlobalEnergyAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareSandPGlobalEnergyAction property is set.
        /// </summary>
        internal bool IsSetShareSandPGlobalEnergyAction() => this.ShareSandPGlobalEnergyAction != null;

        /// <summary>
        /// Gets and sets the property ShareSapHanaDataSource. 
        /// <para>
        /// The ability to share SAP HANA data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareSapHanaDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareSapHanaDataSource property is set.
        /// </summary>
        internal bool IsSetShareSapHanaDataSource() => this.ShareSapHanaDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareServiceNowAction. 
        /// <para>
        /// The ability to share ServiceNow actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareServiceNowAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareServiceNowAction property is set.
        /// </summary>
        internal bool IsSetShareServiceNowAction() => this.ShareServiceNowAction != null;

        /// <summary>
        /// Gets and sets the property ShareServiceNowDataSource. 
        /// <para>
        /// The ability to share ServiceNow data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareServiceNowDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareServiceNowDataSource property is set.
        /// </summary>
        internal bool IsSetShareServiceNowDataSource() => this.ShareServiceNowDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareSharePointAction. 
        /// <para>
        /// The ability to share Microsoft SharePoint Online actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareSharePointAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareSharePointAction property is set.
        /// </summary>
        internal bool IsSetShareSharePointAction() => this.ShareSharePointAction != null;

        /// <summary>
        /// Gets and sets the property ShareSharePointKnowledgeBase.
        /// </summary>
        public CapabilityState ShareSharePointKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the ShareSharePointKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetShareSharePointKnowledgeBase() => this.ShareSharePointKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property ShareShopifyAction. 
        /// <para>
        /// The ability to share Shopify actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareShopifyAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareShopifyAction property is set.
        /// </summary>
        internal bool IsSetShareShopifyAction() => this.ShareShopifyAction != null;

        /// <summary>
        /// Gets and sets the property ShareSlackAction. 
        /// <para>
        /// The ability to share Slack actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareSlackAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareSlackAction property is set.
        /// </summary>
        internal bool IsSetShareSlackAction() => this.ShareSlackAction != null;

        /// <summary>
        /// Gets and sets the property ShareSmartsheetAction. 
        /// <para>
        /// The ability to share Smartsheet actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareSmartsheetAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareSmartsheetAction property is set.
        /// </summary>
        internal bool IsSetShareSmartsheetAction() => this.ShareSmartsheetAction != null;

        /// <summary>
        /// Gets and sets the property ShareSnowFlakeAction. 
        /// <para>
        /// The ability to share Snowflake Cortex Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareSnowFlakeAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareSnowFlakeAction property is set.
        /// </summary>
        internal bool IsSetShareSnowFlakeAction() => this.ShareSnowFlakeAction != null;

        /// <summary>
        /// Gets and sets the property ShareSnowflakeDataSource. 
        /// <para>
        /// The ability to share Snowflake data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareSnowflakeDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareSnowflakeDataSource property is set.
        /// </summary>
        internal bool IsSetShareSnowflakeDataSource() => this.ShareSnowflakeDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareSpaces. 
        /// <para>
        /// The ability to share spaces with other users and groups.
        /// </para>
        /// </summary>
        public CapabilityState ShareSpaces { get; set; }

        /// <summary>
        /// Checks to see if the ShareSpaces property is set.
        /// </summary>
        internal bool IsSetShareSpaces() => this.ShareSpaces != null;

        /// <summary>
        /// Gets and sets the property ShareSparkDataSource. 
        /// <para>
        /// The ability to share Spark data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareSparkDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareSparkDataSource property is set.
        /// </summary>
        internal bool IsSetShareSparkDataSource() => this.ShareSparkDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareSqlServerDataSource. 
        /// <para>
        /// The ability to share SQL Server data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareSqlServerDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareSqlServerDataSource property is set.
        /// </summary>
        internal bool IsSetShareSqlServerDataSource() => this.ShareSqlServerDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareSquareDataSource. 
        /// <para>
        /// The ability to share Square data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareSquareDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareSquareDataSource property is set.
        /// </summary>
        internal bool IsSetShareSquareDataSource() => this.ShareSquareDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareStarburstDataSource. 
        /// <para>
        /// The ability to share Starburst data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareStarburstDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareStarburstDataSource property is set.
        /// </summary>
        internal bool IsSetShareStarburstDataSource() => this.ShareStarburstDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareTeradataDataSource. 
        /// <para>
        /// The ability to share Teradata data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareTeradataDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareTeradataDataSource property is set.
        /// </summary>
        internal bool IsSetShareTeradataDataSource() => this.ShareTeradataDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareTextractAction. 
        /// <para>
        /// The ability to share Textract actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareTextractAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareTextractAction property is set.
        /// </summary>
        internal bool IsSetShareTextractAction() => this.ShareTextractAction != null;

        /// <summary>
        /// Gets and sets the property ShareTimestreamDataSource. 
        /// <para>
        /// The ability to share Amazon Timestream data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareTimestreamDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareTimestreamDataSource property is set.
        /// </summary>
        internal bool IsSetShareTimestreamDataSource() => this.ShareTimestreamDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareTrinoDataSource. 
        /// <para>
        /// The ability to share Trino data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareTrinoDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareTrinoDataSource property is set.
        /// </summary>
        internal bool IsSetShareTrinoDataSource() => this.ShareTrinoDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareTwitterDataSource. 
        /// <para>
        /// The ability to share Twitter data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareTwitterDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ShareTwitterDataSource property is set.
        /// </summary>
        internal bool IsSetShareTwitterDataSource() => this.ShareTwitterDataSource != null;

        /// <summary>
        /// Gets and sets the property ShareVisierAgentAction. 
        /// <para>
        /// The ability to share Visier Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareVisierAgentAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareVisierAgentAction property is set.
        /// </summary>
        internal bool IsSetShareVisierAgentAction() => this.ShareVisierAgentAction != null;

        /// <summary>
        /// Gets and sets the property ShareWebCrawlerKnowledgeBase.
        /// </summary>
        public CapabilityState ShareWebCrawlerKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the ShareWebCrawlerKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetShareWebCrawlerKnowledgeBase() => this.ShareWebCrawlerKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property ShareWhatsAppAction. 
        /// <para>
        /// The ability to share WhatsApp actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareWhatsAppAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareWhatsAppAction property is set.
        /// </summary>
        internal bool IsSetShareWhatsAppAction() => this.ShareWhatsAppAction != null;

        /// <summary>
        /// Gets and sets the property ShareZapierAction. 
        /// <para>
        /// The ability to share Zapier Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareZapierAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareZapierAction property is set.
        /// </summary>
        internal bool IsSetShareZapierAction() => this.ShareZapierAction != null;

        /// <summary>
        /// Gets and sets the property ShareZendeskAction. 
        /// <para>
        /// The ability to share Zendesk actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareZendeskAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareZendeskAction property is set.
        /// </summary>
        internal bool IsSetShareZendeskAction() => this.ShareZendeskAction != null;

        /// <summary>
        /// Gets and sets the property ShareZoomAction. 
        /// <para>
        /// The ability to share Zoom actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareZoomAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareZoomAction property is set.
        /// </summary>
        internal bool IsSetShareZoomAction() => this.ShareZoomAction != null;

        /// <summary>
        /// Gets and sets the property ShareZoomInfoAction. 
        /// <para>
        /// The ability to share ZoomInfo Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState ShareZoomInfoAction { get; set; }

        /// <summary>
        /// Checks to see if the ShareZoomInfoAction property is set.
        /// </summary>
        internal bool IsSetShareZoomInfoAction() => this.ShareZoomInfoAction != null;

        /// <summary>
        /// Gets and sets the property ShopifyAction. 
        /// <para>
        /// The ability to perform actions using Shopify connectors.
        /// </para>
        /// </summary>
        public CapabilityState ShopifyAction { get; set; }

        /// <summary>
        /// Checks to see if the ShopifyAction property is set.
        /// </summary>
        internal bool IsSetShopifyAction() => this.ShopifyAction != null;

        /// <summary>
        /// Gets and sets the property SlackAction. 
        /// <para>
        /// The ability to perform actions using Slack connectors.
        /// </para>
        /// </summary>
        public CapabilityState SlackAction { get; set; }

        /// <summary>
        /// Checks to see if the SlackAction property is set.
        /// </summary>
        internal bool IsSetSlackAction() => this.SlackAction != null;

        /// <summary>
        /// Gets and sets the property SmartsheetAction. 
        /// <para>
        /// The ability to perform actions using Smartsheet connectors.
        /// </para>
        /// </summary>
        public CapabilityState SmartsheetAction { get; set; }

        /// <summary>
        /// Checks to see if the SmartsheetAction property is set.
        /// </summary>
        internal bool IsSetSmartsheetAction() => this.SmartsheetAction != null;

        /// <summary>
        /// Gets and sets the property SnowFlakeAction. 
        /// <para>
        /// The ability to perform actions using Snowflake Cortex Agent connectors.
        /// </para>
        /// </summary>
        public CapabilityState SnowFlakeAction { get; set; }

        /// <summary>
        /// Checks to see if the SnowFlakeAction property is set.
        /// </summary>
        internal bool IsSetSnowFlakeAction() => this.SnowFlakeAction != null;

        /// <summary>
        /// Gets and sets the property SnowflakeDataSource. 
        /// <para>
        /// The ability to create, update, and share Snowflake data sources.
        /// </para>
        /// </summary>
        public CapabilityState SnowflakeDataSource { get; set; }

        /// <summary>
        /// Checks to see if the SnowflakeDataSource property is set.
        /// </summary>
        internal bool IsSetSnowflakeDataSource() => this.SnowflakeDataSource != null;

        /// <summary>
        /// Gets and sets the property Space. 
        /// <para>
        /// The ability to perform space-related actions.
        /// </para>
        /// </summary>
        public CapabilityState Space { get; set; }

        /// <summary>
        /// Checks to see if the Space property is set.
        /// </summary>
        internal bool IsSetSpace() => this.Space != null;

        /// <summary>
        /// Gets and sets the property SparkDataSource. 
        /// <para>
        /// The ability to create, update, and share Spark data sources.
        /// </para>
        /// </summary>
        public CapabilityState SparkDataSource { get; set; }

        /// <summary>
        /// Checks to see if the SparkDataSource property is set.
        /// </summary>
        internal bool IsSetSparkDataSource() => this.SparkDataSource != null;

        /// <summary>
        /// Gets and sets the property SqlServerDataSource. 
        /// <para>
        /// The ability to create, update, and share SQL Server data sources.
        /// </para>
        /// </summary>
        public CapabilityState SqlServerDataSource { get; set; }

        /// <summary>
        /// Checks to see if the SqlServerDataSource property is set.
        /// </summary>
        internal bool IsSetSqlServerDataSource() => this.SqlServerDataSource != null;

        /// <summary>
        /// Gets and sets the property SquareDataSource. 
        /// <para>
        /// The ability to create, update, and share Square data sources.
        /// </para>
        /// </summary>
        public CapabilityState SquareDataSource { get; set; }

        /// <summary>
        /// Checks to see if the SquareDataSource property is set.
        /// </summary>
        internal bool IsSetSquareDataSource() => this.SquareDataSource != null;

        /// <summary>
        /// Gets and sets the property StarburstDataSource. 
        /// <para>
        /// The ability to create, update, and share Starburst data sources.
        /// </para>
        /// </summary>
        public CapabilityState StarburstDataSource { get; set; }

        /// <summary>
        /// Checks to see if the StarburstDataSource property is set.
        /// </summary>
        internal bool IsSetStarburstDataSource() => this.StarburstDataSource != null;

        /// <summary>
        /// Gets and sets the property Story. 
        /// <para>
        /// The ability to perform Story-related actions.
        /// </para>
        /// </summary>
        public CapabilityState Story { get; set; }

        /// <summary>
        /// Checks to see if the Story property is set.
        /// </summary>
        internal bool IsSetStory() => this.Story != null;

        /// <summary>
        /// Gets and sets the property SubscribeDashboardEmailReports. 
        /// <para>
        /// The ability to subscribe to email reports.
        /// </para>
        /// </summary>
        public CapabilityState SubscribeDashboardEmailReports { get; set; }

        /// <summary>
        /// Checks to see if the SubscribeDashboardEmailReports property is set.
        /// </summary>
        internal bool IsSetSubscribeDashboardEmailReports() => this.SubscribeDashboardEmailReports != null;

        /// <summary>
        /// Gets and sets the property TeradataDataSource. 
        /// <para>
        /// The ability to create, update, and share Teradata data sources.
        /// </para>
        /// </summary>
        public CapabilityState TeradataDataSource { get; set; }

        /// <summary>
        /// Checks to see if the TeradataDataSource property is set.
        /// </summary>
        internal bool IsSetTeradataDataSource() => this.TeradataDataSource != null;

        /// <summary>
        /// Gets and sets the property TextractAction. 
        /// <para>
        /// The ability to perform actions using Textract connectors.
        /// </para>
        /// </summary>
        public CapabilityState TextractAction { get; set; }

        /// <summary>
        /// Checks to see if the TextractAction property is set.
        /// </summary>
        internal bool IsSetTextractAction() => this.TextractAction != null;

        /// <summary>
        /// Gets and sets the property TimestreamDataSource. 
        /// <para>
        /// The ability to create, update, and share Amazon Timestream data sources.
        /// </para>
        /// </summary>
        public CapabilityState TimestreamDataSource { get; set; }

        /// <summary>
        /// Checks to see if the TimestreamDataSource property is set.
        /// </summary>
        internal bool IsSetTimestreamDataSource() => this.TimestreamDataSource != null;

        /// <summary>
        /// Gets and sets the property Topic. 
        /// <para>
        /// The ability to perform Topic-related actions.
        /// </para>
        /// </summary>
        public CapabilityState Topic { get; set; }

        /// <summary>
        /// Checks to see if the Topic property is set.
        /// </summary>
        internal bool IsSetTopic() => this.Topic != null;

        /// <summary>
        /// Gets and sets the property Trigger. 
        /// <para>
        /// The ability to manage trigger-related settings for flows and automations.
        /// </para>
        /// </summary>
        public CapabilityState Trigger { get; set; }

        /// <summary>
        /// Checks to see if the Trigger property is set.
        /// </summary>
        internal bool IsSetTrigger() => this.Trigger != null;

        /// <summary>
        /// Gets and sets the property TrinoDataSource. 
        /// <para>
        /// The ability to create, update, and share Trino data sources.
        /// </para>
        /// </summary>
        public CapabilityState TrinoDataSource { get; set; }

        /// <summary>
        /// Checks to see if the TrinoDataSource property is set.
        /// </summary>
        internal bool IsSetTrinoDataSource() => this.TrinoDataSource != null;

        /// <summary>
        /// Gets and sets the property TwitterDataSource. 
        /// <para>
        /// The ability to create, update, and share Twitter data sources.
        /// </para>
        /// </summary>
        public CapabilityState TwitterDataSource { get; set; }

        /// <summary>
        /// Checks to see if the TwitterDataSource property is set.
        /// </summary>
        internal bool IsSetTwitterDataSource() => this.TwitterDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateAdobeAnalyticsDataSource. 
        /// <para>
        /// The ability to update Adobe Analytics data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateAdobeAnalyticsDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateAdobeAnalyticsDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateAdobeAnalyticsDataSource() => this.UpdateAdobeAnalyticsDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateAthenaDataSource. 
        /// <para>
        /// The ability to update Amazon Athena data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateAthenaDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateAthenaDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateAthenaDataSource() => this.UpdateAthenaDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateAuroraDataSource. 
        /// <para>
        /// The ability to update Amazon Aurora data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateAuroraDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateAuroraDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateAuroraDataSource() => this.UpdateAuroraDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateDatabricksDataSource. 
        /// <para>
        /// The ability to update Databricks data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateDatabricksDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateDatabricksDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateDatabricksDataSource() => this.UpdateDatabricksDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateDb2DataSource. 
        /// <para>
        /// The ability to update Db2 data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateDb2DataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateDb2DataSource property is set.
        /// </summary>
        internal bool IsSetUpdateDb2DataSource() => this.UpdateDb2DataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateDenodoDataSource. 
        /// <para>
        /// The ability to update Denodo data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateDenodoDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateDenodoDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateDenodoDataSource() => this.UpdateDenodoDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateDocumentDbDataSource. 
        /// <para>
        /// The ability to update Amazon DocumentDB data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateDocumentDbDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateDocumentDbDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateDocumentDbDataSource() => this.UpdateDocumentDbDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateDremioDataSource. 
        /// <para>
        /// The ability to update Dremio data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateDremioDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateDremioDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateDremioDataSource() => this.UpdateDremioDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateDynamoDbDataSource. 
        /// <para>
        /// The ability to update Amazon DynamoDB data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateDynamoDbDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateDynamoDbDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateDynamoDbDataSource() => this.UpdateDynamoDbDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateExasolDataSource. 
        /// <para>
        /// The ability to update Exasol data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateExasolDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateExasolDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateExasolDataSource() => this.UpdateExasolDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateFileDataSource. 
        /// <para>
        /// The ability to update file data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateFileDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateFileDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateFileDataSource() => this.UpdateFileDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateGitHubDataSource. 
        /// <para>
        /// The ability to update GitHub data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateGitHubDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateGitHubDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateGitHubDataSource() => this.UpdateGitHubDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateGoogleAnalyticsDataSource. 
        /// <para>
        /// The ability to update Google Analytics data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateGoogleAnalyticsDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateGoogleAnalyticsDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateGoogleAnalyticsDataSource() => this.UpdateGoogleAnalyticsDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateGoogleBigQueryDataSource. 
        /// <para>
        /// The ability to update Google BigQuery data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateGoogleBigQueryDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateGoogleBigQueryDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateGoogleBigQueryDataSource() => this.UpdateGoogleBigQueryDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateGoogleSheetsDataSource. 
        /// <para>
        /// The ability to update Google Sheets data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateGoogleSheetsDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateGoogleSheetsDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateGoogleSheetsDataSource() => this.UpdateGoogleSheetsDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateImpalaDataSource. 
        /// <para>
        /// The ability to update Impala data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateImpalaDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateImpalaDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateImpalaDataSource() => this.UpdateImpalaDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateJiraDataSource. 
        /// <para>
        /// The ability to update Jira data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateJiraDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateJiraDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateJiraDataSource() => this.UpdateJiraDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateMariaDbDataSource. 
        /// <para>
        /// The ability to update MariaDB data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateMariaDbDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateMariaDbDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateMariaDbDataSource() => this.UpdateMariaDbDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateMongoAtlasDataSource. 
        /// <para>
        /// The ability to update MongoDB Atlas data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateMongoAtlasDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateMongoAtlasDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateMongoAtlasDataSource() => this.UpdateMongoAtlasDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateMongoDbDataSource. 
        /// <para>
        /// The ability to update MongoDB data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateMongoDbDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateMongoDbDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateMongoDbDataSource() => this.UpdateMongoDbDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateMySqlDataSource. 
        /// <para>
        /// The ability to update MySQL data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateMySqlDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateMySqlDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateMySqlDataSource() => this.UpdateMySqlDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateOpenSearchDataSource. 
        /// <para>
        /// The ability to update Amazon OpenSearch Service data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateOpenSearchDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateOpenSearchDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateOpenSearchDataSource() => this.UpdateOpenSearchDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateOracleDataSource. 
        /// <para>
        /// The ability to update Oracle data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateOracleDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateOracleDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateOracleDataSource() => this.UpdateOracleDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdatePayPalDataSource. 
        /// <para>
        /// The ability to update PayPal data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdatePayPalDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdatePayPalDataSource property is set.
        /// </summary>
        internal bool IsSetUpdatePayPalDataSource() => this.UpdatePayPalDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdatePostgreSqlDataSource. 
        /// <para>
        /// The ability to update PostgreSQL data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdatePostgreSqlDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdatePostgreSqlDataSource property is set.
        /// </summary>
        internal bool IsSetUpdatePostgreSqlDataSource() => this.UpdatePostgreSqlDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdatePrestoDataSource. 
        /// <para>
        /// The ability to update Presto data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdatePrestoDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdatePrestoDataSource property is set.
        /// </summary>
        internal bool IsSetUpdatePrestoDataSource() => this.UpdatePrestoDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateRadiantDataSource. 
        /// <para>
        /// The ability to update Amazon QuickSight data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateRadiantDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateRadiantDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateRadiantDataSource() => this.UpdateRadiantDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateRdsDataSource. 
        /// <para>
        /// The ability to update auto-discovered Amazon RDS data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateRdsDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateRdsDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateRdsDataSource() => this.UpdateRdsDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateRedshiftAutoDiscoveredDataSource. 
        /// <para>
        /// The ability to update auto-discovered Amazon Redshift data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateRedshiftAutoDiscoveredDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateRedshiftAutoDiscoveredDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateRedshiftAutoDiscoveredDataSource() => this.UpdateRedshiftAutoDiscoveredDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateRedshiftManualDataSource. 
        /// <para>
        /// The ability to update manually configured Amazon Redshift data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateRedshiftManualDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateRedshiftManualDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateRedshiftManualDataSource() => this.UpdateRedshiftManualDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateS3AnalyticsDataSource. 
        /// <para>
        /// The ability to update Amazon S3 Analytics data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateS3AnalyticsDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateS3AnalyticsDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateS3AnalyticsDataSource() => this.UpdateS3AnalyticsDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateS3DataSource. 
        /// <para>
        /// The ability to update Amazon S3 data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateS3DataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateS3DataSource property is set.
        /// </summary>
        internal bool IsSetUpdateS3DataSource() => this.UpdateS3DataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateS3TablesDataSource. 
        /// <para>
        /// The ability to update Amazon S3 Tables data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateS3TablesDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateS3TablesDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateS3TablesDataSource() => this.UpdateS3TablesDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateSalesforceDataSource. 
        /// <para>
        /// The ability to update Salesforce data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateSalesforceDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateSalesforceDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateSalesforceDataSource() => this.UpdateSalesforceDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateSapHanaDataSource. 
        /// <para>
        /// The ability to update SAP HANA data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateSapHanaDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateSapHanaDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateSapHanaDataSource() => this.UpdateSapHanaDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateServiceNowDataSource. 
        /// <para>
        /// The ability to update ServiceNow data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateServiceNowDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateServiceNowDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateServiceNowDataSource() => this.UpdateServiceNowDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateSnowflakeDataSource. 
        /// <para>
        /// The ability to update Snowflake data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateSnowflakeDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateSnowflakeDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateSnowflakeDataSource() => this.UpdateSnowflakeDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateSparkDataSource. 
        /// <para>
        /// The ability to update Spark data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateSparkDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateSparkDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateSparkDataSource() => this.UpdateSparkDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateSqlServerDataSource. 
        /// <para>
        /// The ability to update SQL Server data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateSqlServerDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateSqlServerDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateSqlServerDataSource() => this.UpdateSqlServerDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateSquareDataSource. 
        /// <para>
        /// The ability to update Square data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateSquareDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateSquareDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateSquareDataSource() => this.UpdateSquareDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateStarburstDataSource. 
        /// <para>
        /// The ability to update Starburst data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateStarburstDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateStarburstDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateStarburstDataSource() => this.UpdateStarburstDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateTeradataDataSource. 
        /// <para>
        /// The ability to update Teradata data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateTeradataDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTeradataDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateTeradataDataSource() => this.UpdateTeradataDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateTimestreamDataSource. 
        /// <para>
        /// The ability to update Amazon Timestream data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateTimestreamDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTimestreamDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateTimestreamDataSource() => this.UpdateTimestreamDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateTrinoDataSource. 
        /// <para>
        /// The ability to update Trino data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateTrinoDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTrinoDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateTrinoDataSource() => this.UpdateTrinoDataSource != null;

        /// <summary>
        /// Gets and sets the property UpdateTwitterDataSource. 
        /// <para>
        /// The ability to update Twitter data sources.
        /// </para>
        /// </summary>
        public CapabilityState UpdateTwitterDataSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTwitterDataSource property is set.
        /// </summary>
        internal bool IsSetUpdateTwitterDataSource() => this.UpdateTwitterDataSource != null;

        /// <summary>
        /// Gets and sets the property UseAdobeAction. 
        /// <para>
        /// The ability to use Adobe Marketing Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState UseAdobeAction { get; set; }

        /// <summary>
        /// Checks to see if the UseAdobeAction property is set.
        /// </summary>
        internal bool IsSetUseAdobeAction() => this.UseAdobeAction != null;

        /// <summary>
        /// Gets and sets the property UseAgentWebSearch. 
        /// <para>
        /// The ability to use internet to enhance results in Chat Agents, Flows, and Quick Research.
        /// Web search queries will be processed securely in an Amazon Web Services region <c>us-east-1</c>.
        /// </para>
        /// </summary>
        public CapabilityState UseAgentWebSearch { get; set; }

        /// <summary>
        /// Checks to see if the UseAgentWebSearch property is set.
        /// </summary>
        internal bool IsSetUseAgentWebSearch() => this.UseAgentWebSearch != null;

        /// <summary>
        /// Gets and sets the property UseAirtableAction. 
        /// <para>
        /// The ability to use Airtable actions.
        /// </para>
        /// </summary>
        public CapabilityState UseAirtableAction { get; set; }

        /// <summary>
        /// Checks to see if the UseAirtableAction property is set.
        /// </summary>
        internal bool IsSetUseAirtableAction() => this.UseAirtableAction != null;

        /// <summary>
        /// Gets and sets the property UseAmazonBedrockARSAction. 
        /// <para>
        /// The ability to use Bedrock Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState UseAmazonBedrockARSAction { get; set; }

        /// <summary>
        /// Checks to see if the UseAmazonBedrockARSAction property is set.
        /// </summary>
        internal bool IsSetUseAmazonBedrockARSAction() => this.UseAmazonBedrockARSAction != null;

        /// <summary>
        /// Gets and sets the property UseAmazonBedrockFSAction. 
        /// <para>
        /// The ability to use Bedrock Runtime actions.
        /// </para>
        /// </summary>
        public CapabilityState UseAmazonBedrockFSAction { get; set; }

        /// <summary>
        /// Checks to see if the UseAmazonBedrockFSAction property is set.
        /// </summary>
        internal bool IsSetUseAmazonBedrockFSAction() => this.UseAmazonBedrockFSAction != null;

        /// <summary>
        /// Gets and sets the property UseAmazonBedrockKRSAction. 
        /// <para>
        /// The ability to use Bedrock Data Automation Runtime actions.
        /// </para>
        /// </summary>
        public CapabilityState UseAmazonBedrockKRSAction { get; set; }

        /// <summary>
        /// Checks to see if the UseAmazonBedrockKRSAction property is set.
        /// </summary>
        internal bool IsSetUseAmazonBedrockKRSAction() => this.UseAmazonBedrockKRSAction != null;

        /// <summary>
        /// Gets and sets the property UseAmazonSThreeAction. 
        /// <para>
        /// The ability to use Amazon S3 actions.
        /// </para>
        /// </summary>
        public CapabilityState UseAmazonSThreeAction { get; set; }

        /// <summary>
        /// Checks to see if the UseAmazonSThreeAction property is set.
        /// </summary>
        internal bool IsSetUseAmazonSThreeAction() => this.UseAmazonSThreeAction != null;

        /// <summary>
        /// Gets and sets the property UseAsanaAction. 
        /// <para>
        /// The ability to use Asana actions.
        /// </para>
        /// </summary>
        public CapabilityState UseAsanaAction { get; set; }

        /// <summary>
        /// Checks to see if the UseAsanaAction property is set.
        /// </summary>
        internal bool IsSetUseAsanaAction() => this.UseAsanaAction != null;

        /// <summary>
        /// Gets and sets the property UseBambooHRAction. 
        /// <para>
        /// The ability to use BambooHR actions.
        /// </para>
        /// </summary>
        public CapabilityState UseBambooHRAction { get; set; }

        /// <summary>
        /// Checks to see if the UseBambooHRAction property is set.
        /// </summary>
        internal bool IsSetUseBambooHRAction() => this.UseBambooHRAction != null;

        /// <summary>
        /// Gets and sets the property UseBedrockManagedKnowledgeBase.
        /// </summary>
        public CapabilityState UseBedrockManagedKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the UseBedrockManagedKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetUseBedrockManagedKnowledgeBase() => this.UseBedrockManagedKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property UseBedrockModels. 
        /// <para>
        /// The ability to use Bedrock models for general knowledge step in flows.
        /// </para>
        /// </summary>
        public CapabilityState UseBedrockModels { get; set; }

        /// <summary>
        /// Checks to see if the UseBedrockModels property is set.
        /// </summary>
        internal bool IsSetUseBedrockModels() => this.UseBedrockModels != null;

        /// <summary>
        /// Gets and sets the property UseBeeAction. 
        /// <para>
        /// The ability to use Bee actions.
        /// </para>
        /// </summary>
        public CapabilityState UseBeeAction { get; set; }

        /// <summary>
        /// Checks to see if the UseBeeAction property is set.
        /// </summary>
        internal bool IsSetUseBeeAction() => this.UseBeeAction != null;

        /// <summary>
        /// Gets and sets the property UseBoxAgentAction. 
        /// <para>
        /// The ability to use Box Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState UseBoxAgentAction { get; set; }

        /// <summary>
        /// Checks to see if the UseBoxAgentAction property is set.
        /// </summary>
        internal bool IsSetUseBoxAgentAction() => this.UseBoxAgentAction != null;

        /// <summary>
        /// Gets and sets the property UseBoxKnowledgeBase.
        /// </summary>
        public CapabilityState UseBoxKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the UseBoxKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetUseBoxKnowledgeBase() => this.UseBoxKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property UseBrowserExtension. 
        /// <para>
        /// The ability to use Amazon Quick through the browser extension for Chrome, Firefox,
        /// and Edge.
        /// </para>
        /// </summary>
        public CapabilityState UseBrowserExtension { get; set; }

        /// <summary>
        /// Checks to see if the UseBrowserExtension property is set.
        /// </summary>
        internal bool IsSetUseBrowserExtension() => this.UseBrowserExtension != null;

        /// <summary>
        /// Gets and sets the property UseCanvaAgentAction. 
        /// <para>
        /// The ability to use Canva Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState UseCanvaAgentAction { get; set; }

        /// <summary>
        /// Checks to see if the UseCanvaAgentAction property is set.
        /// </summary>
        internal bool IsSetUseCanvaAgentAction() => this.UseCanvaAgentAction != null;

        /// <summary>
        /// Gets and sets the property UseCiscoWebexMeetingsAction. 
        /// <para>
        /// The ability to use Cisco Webex Meetings actions.
        /// </para>
        /// </summary>
        public CapabilityState UseCiscoWebexMeetingsAction { get; set; }

        /// <summary>
        /// Checks to see if the UseCiscoWebexMeetingsAction property is set.
        /// </summary>
        internal bool IsSetUseCiscoWebexMeetingsAction() => this.UseCiscoWebexMeetingsAction != null;

        /// <summary>
        /// Gets and sets the property UseCiscoWebexVidcastAction. 
        /// <para>
        /// The ability to use Cisco Webex Video Messaging Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState UseCiscoWebexVidcastAction { get; set; }

        /// <summary>
        /// Checks to see if the UseCiscoWebexVidcastAction property is set.
        /// </summary>
        internal bool IsSetUseCiscoWebexVidcastAction() => this.UseCiscoWebexVidcastAction != null;

        /// <summary>
        /// Gets and sets the property UseComprehendAction. 
        /// <para>
        /// The ability to use Comprehend actions.
        /// </para>
        /// </summary>
        public CapabilityState UseComprehendAction { get; set; }

        /// <summary>
        /// Checks to see if the UseComprehendAction property is set.
        /// </summary>
        internal bool IsSetUseComprehendAction() => this.UseComprehendAction != null;

        /// <summary>
        /// Gets and sets the property UseComprehendMedicalAction. 
        /// <para>
        /// The ability to use Comprehend Medical actions.
        /// </para>
        /// </summary>
        public CapabilityState UseComprehendMedicalAction { get; set; }

        /// <summary>
        /// Checks to see if the UseComprehendMedicalAction property is set.
        /// </summary>
        internal bool IsSetUseComprehendMedicalAction() => this.UseComprehendMedicalAction != null;

        /// <summary>
        /// Gets and sets the property UseConfluenceAction. 
        /// <para>
        /// The ability to use Atlassian Confluence Cloud actions.
        /// </para>
        /// </summary>
        public CapabilityState UseConfluenceAction { get; set; }

        /// <summary>
        /// Checks to see if the UseConfluenceAction property is set.
        /// </summary>
        internal bool IsSetUseConfluenceAction() => this.UseConfluenceAction != null;

        /// <summary>
        /// Gets and sets the property UseConfluenceKnowledgeBase.
        /// </summary>
        public CapabilityState UseConfluenceKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the UseConfluenceKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetUseConfluenceKnowledgeBase() => this.UseConfluenceKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property UseDropboxAction. 
        /// <para>
        /// The ability to use Dropbox actions.
        /// </para>
        /// </summary>
        public CapabilityState UseDropboxAction { get; set; }

        /// <summary>
        /// Checks to see if the UseDropboxAction property is set.
        /// </summary>
        internal bool IsSetUseDropboxAction() => this.UseDropboxAction != null;

        /// <summary>
        /// Gets and sets the property UseDunAndBradstreetAction. 
        /// <para>
        /// The ability to use Dun and Bradstreet actions.
        /// </para>
        /// </summary>
        public CapabilityState UseDunAndBradstreetAction { get; set; }

        /// <summary>
        /// Checks to see if the UseDunAndBradstreetAction property is set.
        /// </summary>
        internal bool IsSetUseDunAndBradstreetAction() => this.UseDunAndBradstreetAction != null;

        /// <summary>
        /// Gets and sets the property UseExcelAddInExtension. 
        /// <para>
        /// The ability to use Amazon Quick through the Microsoft Excel add-in.
        /// </para>
        /// </summary>
        public CapabilityState UseExcelAddInExtension { get; set; }

        /// <summary>
        /// Checks to see if the UseExcelAddInExtension property is set.
        /// </summary>
        internal bool IsSetUseExcelAddInExtension() => this.UseExcelAddInExtension != null;

        /// <summary>
        /// Gets and sets the property UseFactSetAction. 
        /// <para>
        /// The ability to use FactSet actions.
        /// </para>
        /// </summary>
        public CapabilityState UseFactSetAction { get; set; }

        /// <summary>
        /// Checks to see if the UseFactSetAction property is set.
        /// </summary>
        internal bool IsSetUseFactSetAction() => this.UseFactSetAction != null;

        /// <summary>
        /// Gets and sets the property UseFigmaAction. 
        /// <para>
        /// The ability to use Figma actions.
        /// </para>
        /// </summary>
        public CapabilityState UseFigmaAction { get; set; }

        /// <summary>
        /// Checks to see if the UseFigmaAction property is set.
        /// </summary>
        internal bool IsSetUseFigmaAction() => this.UseFigmaAction != null;

        /// <summary>
        /// Gets and sets the property UseGenericHTTPAction. 
        /// <para>
        /// The ability to use REST API connection actions.
        /// </para>
        /// </summary>
        public CapabilityState UseGenericHTTPAction { get; set; }

        /// <summary>
        /// Checks to see if the UseGenericHTTPAction property is set.
        /// </summary>
        internal bool IsSetUseGenericHTTPAction() => this.UseGenericHTTPAction != null;

        /// <summary>
        /// Gets and sets the property UseGithubAction. 
        /// <para>
        /// The ability to use GitHub actions.
        /// </para>
        /// </summary>
        public CapabilityState UseGithubAction { get; set; }

        /// <summary>
        /// Checks to see if the UseGithubAction property is set.
        /// </summary>
        internal bool IsSetUseGithubAction() => this.UseGithubAction != null;

        /// <summary>
        /// Gets and sets the property UseGmailAction. 
        /// <para>
        /// The ability to use Gmail actions.
        /// </para>
        /// </summary>
        public CapabilityState UseGmailAction { get; set; }

        /// <summary>
        /// Checks to see if the UseGmailAction property is set.
        /// </summary>
        internal bool IsSetUseGmailAction() => this.UseGmailAction != null;

        /// <summary>
        /// Gets and sets the property UseGongAction. 
        /// <para>
        /// The ability to use Gong actions.
        /// </para>
        /// </summary>
        public CapabilityState UseGongAction { get; set; }

        /// <summary>
        /// Checks to see if the UseGongAction property is set.
        /// </summary>
        internal bool IsSetUseGongAction() => this.UseGongAction != null;

        /// <summary>
        /// Gets and sets the property UseGoogleAnalyticsAction. 
        /// <para>
        /// The ability to use Google Analytics actions.
        /// </para>
        /// </summary>
        public CapabilityState UseGoogleAnalyticsAction { get; set; }

        /// <summary>
        /// Checks to see if the UseGoogleAnalyticsAction property is set.
        /// </summary>
        internal bool IsSetUseGoogleAnalyticsAction() => this.UseGoogleAnalyticsAction != null;

        /// <summary>
        /// Gets and sets the property UseGoogleCalendarAction. 
        /// <para>
        /// The ability to use Google Calendar actions.
        /// </para>
        /// </summary>
        public CapabilityState UseGoogleCalendarAction { get; set; }

        /// <summary>
        /// Checks to see if the UseGoogleCalendarAction property is set.
        /// </summary>
        internal bool IsSetUseGoogleCalendarAction() => this.UseGoogleCalendarAction != null;

        /// <summary>
        /// Gets and sets the property UseGoogleChatAction. 
        /// <para>
        /// The ability to use Google Chat actions.
        /// </para>
        /// </summary>
        public CapabilityState UseGoogleChatAction { get; set; }

        /// <summary>
        /// Checks to see if the UseGoogleChatAction property is set.
        /// </summary>
        internal bool IsSetUseGoogleChatAction() => this.UseGoogleChatAction != null;

        /// <summary>
        /// Gets and sets the property UseGoogleDocsAction. 
        /// <para>
        /// The ability to use Google Docs actions.
        /// </para>
        /// </summary>
        public CapabilityState UseGoogleDocsAction { get; set; }

        /// <summary>
        /// Checks to see if the UseGoogleDocsAction property is set.
        /// </summary>
        internal bool IsSetUseGoogleDocsAction() => this.UseGoogleDocsAction != null;

        /// <summary>
        /// Gets and sets the property UseGoogleDriveAction. 
        /// <para>
        /// The ability to use Google Drive actions.
        /// </para>
        /// </summary>
        public CapabilityState UseGoogleDriveAction { get; set; }

        /// <summary>
        /// Checks to see if the UseGoogleDriveAction property is set.
        /// </summary>
        internal bool IsSetUseGoogleDriveAction() => this.UseGoogleDriveAction != null;

        /// <summary>
        /// Gets and sets the property UseGoogleDriveKnowledgeBase.
        /// </summary>
        public CapabilityState UseGoogleDriveKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the UseGoogleDriveKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetUseGoogleDriveKnowledgeBase() => this.UseGoogleDriveKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property UseGoogleMeetAction. 
        /// <para>
        /// The ability to use Google Meet actions.
        /// </para>
        /// </summary>
        public CapabilityState UseGoogleMeetAction { get; set; }

        /// <summary>
        /// Checks to see if the UseGoogleMeetAction property is set.
        /// </summary>
        internal bool IsSetUseGoogleMeetAction() => this.UseGoogleMeetAction != null;

        /// <summary>
        /// Gets and sets the property UseGoogleSheetsAction. 
        /// <para>
        /// The ability to use Google Sheets actions.
        /// </para>
        /// </summary>
        public CapabilityState UseGoogleSheetsAction { get; set; }

        /// <summary>
        /// Checks to see if the UseGoogleSheetsAction property is set.
        /// </summary>
        internal bool IsSetUseGoogleSheetsAction() => this.UseGoogleSheetsAction != null;

        /// <summary>
        /// Gets and sets the property UseGoogleSlidesAction. 
        /// <para>
        /// The ability to use Google Slides actions.
        /// </para>
        /// </summary>
        public CapabilityState UseGoogleSlidesAction { get; set; }

        /// <summary>
        /// Checks to see if the UseGoogleSlidesAction property is set.
        /// </summary>
        internal bool IsSetUseGoogleSlidesAction() => this.UseGoogleSlidesAction != null;

        /// <summary>
        /// Gets and sets the property UseHGInsightsAction. 
        /// <para>
        /// The ability to use HG Insights Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState UseHGInsightsAction { get; set; }

        /// <summary>
        /// Checks to see if the UseHGInsightsAction property is set.
        /// </summary>
        internal bool IsSetUseHGInsightsAction() => this.UseHGInsightsAction != null;

        /// <summary>
        /// Gets and sets the property UseHubspotAction. 
        /// <para>
        /// The ability to use Hubspot actions.
        /// </para>
        /// </summary>
        public CapabilityState UseHubspotAction { get; set; }

        /// <summary>
        /// Checks to see if the UseHubspotAction property is set.
        /// </summary>
        internal bool IsSetUseHubspotAction() => this.UseHubspotAction != null;

        /// <summary>
        /// Gets and sets the property UseHuggingFaceAction. 
        /// <para>
        /// The ability to use HuggingFace actions.
        /// </para>
        /// </summary>
        public CapabilityState UseHuggingFaceAction { get; set; }

        /// <summary>
        /// Checks to see if the UseHuggingFaceAction property is set.
        /// </summary>
        internal bool IsSetUseHuggingFaceAction() => this.UseHuggingFaceAction != null;

        /// <summary>
        /// Gets and sets the property UseIDCKnowledgeBase.
        /// </summary>
        public CapabilityState UseIDCKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the UseIDCKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetUseIDCKnowledgeBase() => this.UseIDCKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property UseIntercomAction. 
        /// <para>
        /// The ability to use Intercom actions.
        /// </para>
        /// </summary>
        public CapabilityState UseIntercomAction { get; set; }

        /// <summary>
        /// Checks to see if the UseIntercomAction property is set.
        /// </summary>
        internal bool IsSetUseIntercomAction() => this.UseIntercomAction != null;

        /// <summary>
        /// Gets and sets the property UseJiraAction. 
        /// <para>
        /// The ability to use Jira actions.
        /// </para>
        /// </summary>
        public CapabilityState UseJiraAction { get; set; }

        /// <summary>
        /// Checks to see if the UseJiraAction property is set.
        /// </summary>
        internal bool IsSetUseJiraAction() => this.UseJiraAction != null;

        /// <summary>
        /// Gets and sets the property UseLinearAction. 
        /// <para>
        /// The ability to use Linear actions.
        /// </para>
        /// </summary>
        public CapabilityState UseLinearAction { get; set; }

        /// <summary>
        /// Checks to see if the UseLinearAction property is set.
        /// </summary>
        internal bool IsSetUseLinearAction() => this.UseLinearAction != null;

        /// <summary>
        /// Gets and sets the property UseMCPAction. 
        /// <para>
        /// The ability to use Model Context Protocol actions.
        /// </para>
        /// </summary>
        public CapabilityState UseMCPAction { get; set; }

        /// <summary>
        /// Checks to see if the UseMCPAction property is set.
        /// </summary>
        internal bool IsSetUseMCPAction() => this.UseMCPAction != null;

        /// <summary>
        /// Gets and sets the property UseMSExchangeAction. 
        /// <para>
        /// The ability to use Microsoft Outlook actions.
        /// </para>
        /// </summary>
        public CapabilityState UseMSExchangeAction { get; set; }

        /// <summary>
        /// Checks to see if the UseMSExchangeAction property is set.
        /// </summary>
        internal bool IsSetUseMSExchangeAction() => this.UseMSExchangeAction != null;

        /// <summary>
        /// Gets and sets the property UseMSTeamsAction. 
        /// <para>
        /// The ability to use Microsoft Teams actions.
        /// </para>
        /// </summary>
        public CapabilityState UseMSTeamsAction { get; set; }

        /// <summary>
        /// Checks to see if the UseMSTeamsAction property is set.
        /// </summary>
        internal bool IsSetUseMSTeamsAction() => this.UseMSTeamsAction != null;

        /// <summary>
        /// Gets and sets the property UseMondayAction. 
        /// <para>
        /// The ability to use Monday actions.
        /// </para>
        /// </summary>
        public CapabilityState UseMondayAction { get; set; }

        /// <summary>
        /// Checks to see if the UseMondayAction property is set.
        /// </summary>
        internal bool IsSetUseMondayAction() => this.UseMondayAction != null;

        /// <summary>
        /// Gets and sets the property UseMoodysAction. 
        /// <para>
        /// The ability to use Moody's GenAI Ready Data actions.
        /// </para>
        /// </summary>
        public CapabilityState UseMoodysAction { get; set; }

        /// <summary>
        /// Checks to see if the UseMoodysAction property is set.
        /// </summary>
        internal bool IsSetUseMoodysAction() => this.UseMoodysAction != null;

        /// <summary>
        /// Gets and sets the property UseNewRelicAction. 
        /// <para>
        /// The ability to use New Relic actions.
        /// </para>
        /// </summary>
        public CapabilityState UseNewRelicAction { get; set; }

        /// <summary>
        /// Checks to see if the UseNewRelicAction property is set.
        /// </summary>
        internal bool IsSetUseNewRelicAction() => this.UseNewRelicAction != null;

        /// <summary>
        /// Gets and sets the property UseNotionAction. 
        /// <para>
        /// The ability to use Notion actions.
        /// </para>
        /// </summary>
        public CapabilityState UseNotionAction { get; set; }

        /// <summary>
        /// Checks to see if the UseNotionAction property is set.
        /// </summary>
        internal bool IsSetUseNotionAction() => this.UseNotionAction != null;

        /// <summary>
        /// Gets and sets the property UseOneDriveAction. 
        /// <para>
        /// The ability to use Microsoft OneDrive actions.
        /// </para>
        /// </summary>
        public CapabilityState UseOneDriveAction { get; set; }

        /// <summary>
        /// Checks to see if the UseOneDriveAction property is set.
        /// </summary>
        internal bool IsSetUseOneDriveAction() => this.UseOneDriveAction != null;

        /// <summary>
        /// Gets and sets the property UseOneDriveKnowledgeBase.
        /// </summary>
        public CapabilityState UseOneDriveKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the UseOneDriveKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetUseOneDriveKnowledgeBase() => this.UseOneDriveKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property UseOneNoteAction. 
        /// <para>
        /// The ability to use Microsoft OneNote actions.
        /// </para>
        /// </summary>
        public CapabilityState UseOneNoteAction { get; set; }

        /// <summary>
        /// Checks to see if the UseOneNoteAction property is set.
        /// </summary>
        internal bool IsSetUseOneNoteAction() => this.UseOneNoteAction != null;

        /// <summary>
        /// Gets and sets the property UseOpenAPIAction. 
        /// <para>
        /// The ability to use OpenAPI Specification actions.
        /// </para>
        /// </summary>
        public CapabilityState UseOpenAPIAction { get; set; }

        /// <summary>
        /// Checks to see if the UseOpenAPIAction property is set.
        /// </summary>
        internal bool IsSetUseOpenAPIAction() => this.UseOpenAPIAction != null;

        /// <summary>
        /// Gets and sets the property UseOutlookAddInExtension. 
        /// <para>
        /// The ability to use Amazon Quick through the Microsoft Outlook add-in.
        /// </para>
        /// </summary>
        public CapabilityState UseOutlookAddInExtension { get; set; }

        /// <summary>
        /// Checks to see if the UseOutlookAddInExtension property is set.
        /// </summary>
        internal bool IsSetUseOutlookAddInExtension() => this.UseOutlookAddInExtension != null;

        /// <summary>
        /// Gets and sets the property UsePagerDutyAction. 
        /// <para>
        /// The ability to use PagerDuty Advance actions.
        /// </para>
        /// </summary>
        public CapabilityState UsePagerDutyAction { get; set; }

        /// <summary>
        /// Checks to see if the UsePagerDutyAction property is set.
        /// </summary>
        internal bool IsSetUsePagerDutyAction() => this.UsePagerDutyAction != null;

        /// <summary>
        /// Gets and sets the property UsePagerDutyAgentAction. 
        /// <para>
        /// The ability to use PagerDuty Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState UsePagerDutyAgentAction { get; set; }

        /// <summary>
        /// Checks to see if the UsePagerDutyAgentAction property is set.
        /// </summary>
        internal bool IsSetUsePagerDutyAgentAction() => this.UsePagerDutyAgentAction != null;

        /// <summary>
        /// Gets and sets the property UsePowerpointAddInExtension. 
        /// <para>
        /// The ability to use Amazon Quick through the Microsoft PowerPoint add-in.
        /// </para>
        /// </summary>
        public CapabilityState UsePowerpointAddInExtension { get; set; }

        /// <summary>
        /// Checks to see if the UsePowerpointAddInExtension property is set.
        /// </summary>
        internal bool IsSetUsePowerpointAddInExtension() => this.UsePowerpointAddInExtension != null;

        /// <summary>
        /// Gets and sets the property UseQBusinessKnowledgeBase.
        /// </summary>
        public CapabilityState UseQBusinessKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the UseQBusinessKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetUseQBusinessKnowledgeBase() => this.UseQBusinessKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property UseQuickBooksAction. 
        /// <para>
        /// The ability to use QuickBooks actions.
        /// </para>
        /// </summary>
        public CapabilityState UseQuickBooksAction { get; set; }

        /// <summary>
        /// Checks to see if the UseQuickBooksAction property is set.
        /// </summary>
        internal bool IsSetUseQuickBooksAction() => this.UseQuickBooksAction != null;

        /// <summary>
        /// Gets and sets the property UseS3KnowledgeBase.
        /// </summary>
        public CapabilityState UseS3KnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the UseS3KnowledgeBase property is set.
        /// </summary>
        internal bool IsSetUseS3KnowledgeBase() => this.UseS3KnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property UseSAPBillOfMaterialAction. 
        /// <para>
        /// The ability to use SAP Bill of Materials actions.
        /// </para>
        /// </summary>
        public CapabilityState UseSAPBillOfMaterialAction { get; set; }

        /// <summary>
        /// Checks to see if the UseSAPBillOfMaterialAction property is set.
        /// </summary>
        internal bool IsSetUseSAPBillOfMaterialAction() => this.UseSAPBillOfMaterialAction != null;

        /// <summary>
        /// Gets and sets the property UseSAPBusinessPartnerAction. 
        /// <para>
        /// The ability to use SAP Business Partner actions.
        /// </para>
        /// </summary>
        public CapabilityState UseSAPBusinessPartnerAction { get; set; }

        /// <summary>
        /// Checks to see if the UseSAPBusinessPartnerAction property is set.
        /// </summary>
        internal bool IsSetUseSAPBusinessPartnerAction() => this.UseSAPBusinessPartnerAction != null;

        /// <summary>
        /// Gets and sets the property UseSAPMaterialStockAction. 
        /// <para>
        /// The ability to use SAP Material Stock actions.
        /// </para>
        /// </summary>
        public CapabilityState UseSAPMaterialStockAction { get; set; }

        /// <summary>
        /// Checks to see if the UseSAPMaterialStockAction property is set.
        /// </summary>
        internal bool IsSetUseSAPMaterialStockAction() => this.UseSAPMaterialStockAction != null;

        /// <summary>
        /// Gets and sets the property UseSAPPhysicalInventoryAction. 
        /// <para>
        /// The ability to use SAP Physical Inventory actions.
        /// </para>
        /// </summary>
        public CapabilityState UseSAPPhysicalInventoryAction { get; set; }

        /// <summary>
        /// Checks to see if the UseSAPPhysicalInventoryAction property is set.
        /// </summary>
        internal bool IsSetUseSAPPhysicalInventoryAction() => this.UseSAPPhysicalInventoryAction != null;

        /// <summary>
        /// Gets and sets the property UseSAPProductMasterDataAction. 
        /// <para>
        /// The ability to use SAP Product Master actions.
        /// </para>
        /// </summary>
        public CapabilityState UseSAPProductMasterDataAction { get; set; }

        /// <summary>
        /// Checks to see if the UseSAPProductMasterDataAction property is set.
        /// </summary>
        internal bool IsSetUseSAPProductMasterDataAction() => this.UseSAPProductMasterDataAction != null;

        /// <summary>
        /// Gets and sets the property UseSalesforceAction. 
        /// <para>
        /// The ability to use Salesforce actions.
        /// </para>
        /// </summary>
        public CapabilityState UseSalesforceAction { get; set; }

        /// <summary>
        /// Checks to see if the UseSalesforceAction property is set.
        /// </summary>
        internal bool IsSetUseSalesforceAction() => this.UseSalesforceAction != null;

        /// <summary>
        /// Gets and sets the property UseSandPGMIAction. 
        /// <para>
        /// The ability to use S&amp;P Global Market Intelligence actions.
        /// </para>
        /// </summary>
        public CapabilityState UseSandPGMIAction { get; set; }

        /// <summary>
        /// Checks to see if the UseSandPGMIAction property is set.
        /// </summary>
        internal bool IsSetUseSandPGMIAction() => this.UseSandPGMIAction != null;

        /// <summary>
        /// Gets and sets the property UseSandPGlobalEnergyAction. 
        /// <para>
        /// The ability to use S&amp;P Global Energy actions.
        /// </para>
        /// </summary>
        public CapabilityState UseSandPGlobalEnergyAction { get; set; }

        /// <summary>
        /// Checks to see if the UseSandPGlobalEnergyAction property is set.
        /// </summary>
        internal bool IsSetUseSandPGlobalEnergyAction() => this.UseSandPGlobalEnergyAction != null;

        /// <summary>
        /// Gets and sets the property UseServiceNowAction. 
        /// <para>
        /// The ability to use ServiceNow actions.
        /// </para>
        /// </summary>
        public CapabilityState UseServiceNowAction { get; set; }

        /// <summary>
        /// Checks to see if the UseServiceNowAction property is set.
        /// </summary>
        internal bool IsSetUseServiceNowAction() => this.UseServiceNowAction != null;

        /// <summary>
        /// Gets and sets the property UseSharePointAction. 
        /// <para>
        /// The ability to use Microsoft SharePoint Online actions.
        /// </para>
        /// </summary>
        public CapabilityState UseSharePointAction { get; set; }

        /// <summary>
        /// Checks to see if the UseSharePointAction property is set.
        /// </summary>
        internal bool IsSetUseSharePointAction() => this.UseSharePointAction != null;

        /// <summary>
        /// Gets and sets the property UseSharePointKnowledgeBase.
        /// </summary>
        public CapabilityState UseSharePointKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the UseSharePointKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetUseSharePointKnowledgeBase() => this.UseSharePointKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property UseShopifyAction. 
        /// <para>
        /// The ability to use Shopify actions.
        /// </para>
        /// </summary>
        public CapabilityState UseShopifyAction { get; set; }

        /// <summary>
        /// Checks to see if the UseShopifyAction property is set.
        /// </summary>
        internal bool IsSetUseShopifyAction() => this.UseShopifyAction != null;

        /// <summary>
        /// Gets and sets the property UseSlackAction. 
        /// <para>
        /// The ability to use Slack actions.
        /// </para>
        /// </summary>
        public CapabilityState UseSlackAction { get; set; }

        /// <summary>
        /// Checks to see if the UseSlackAction property is set.
        /// </summary>
        internal bool IsSetUseSlackAction() => this.UseSlackAction != null;

        /// <summary>
        /// Gets and sets the property UseSmartsheetAction. 
        /// <para>
        /// The ability to use Smartsheet actions.
        /// </para>
        /// </summary>
        public CapabilityState UseSmartsheetAction { get; set; }

        /// <summary>
        /// Checks to see if the UseSmartsheetAction property is set.
        /// </summary>
        internal bool IsSetUseSmartsheetAction() => this.UseSmartsheetAction != null;

        /// <summary>
        /// Gets and sets the property UseSnowFlakeAction. 
        /// <para>
        /// The ability to use Snowflake Cortex Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState UseSnowFlakeAction { get; set; }

        /// <summary>
        /// Checks to see if the UseSnowFlakeAction property is set.
        /// </summary>
        internal bool IsSetUseSnowFlakeAction() => this.UseSnowFlakeAction != null;

        /// <summary>
        /// Gets and sets the property UseTextractAction. 
        /// <para>
        /// The ability to use Textract actions.
        /// </para>
        /// </summary>
        public CapabilityState UseTextractAction { get; set; }

        /// <summary>
        /// Checks to see if the UseTextractAction property is set.
        /// </summary>
        internal bool IsSetUseTextractAction() => this.UseTextractAction != null;

        /// <summary>
        /// Gets and sets the property UseVisierAgentAction. 
        /// <para>
        /// The ability to use Visier Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState UseVisierAgentAction { get; set; }

        /// <summary>
        /// Checks to see if the UseVisierAgentAction property is set.
        /// </summary>
        internal bool IsSetUseVisierAgentAction() => this.UseVisierAgentAction != null;

        /// <summary>
        /// Gets and sets the property UseWebCrawlerKnowledgeBase.
        /// </summary>
        public CapabilityState UseWebCrawlerKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the UseWebCrawlerKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetUseWebCrawlerKnowledgeBase() => this.UseWebCrawlerKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property UseWhatsAppAction. 
        /// <para>
        /// The ability to use WhatsApp actions.
        /// </para>
        /// </summary>
        public CapabilityState UseWhatsAppAction { get; set; }

        /// <summary>
        /// Checks to see if the UseWhatsAppAction property is set.
        /// </summary>
        internal bool IsSetUseWhatsAppAction() => this.UseWhatsAppAction != null;

        /// <summary>
        /// Gets and sets the property UseWordAddInExtension. 
        /// <para>
        /// The ability to use Amazon Quick through the Microsoft Word add-in.
        /// </para>
        /// </summary>
        public CapabilityState UseWordAddInExtension { get; set; }

        /// <summary>
        /// Checks to see if the UseWordAddInExtension property is set.
        /// </summary>
        internal bool IsSetUseWordAddInExtension() => this.UseWordAddInExtension != null;

        /// <summary>
        /// Gets and sets the property UseZapierAction. 
        /// <para>
        /// The ability to use Zapier Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState UseZapierAction { get; set; }

        /// <summary>
        /// Checks to see if the UseZapierAction property is set.
        /// </summary>
        internal bool IsSetUseZapierAction() => this.UseZapierAction != null;

        /// <summary>
        /// Gets and sets the property UseZendeskAction. 
        /// <para>
        /// The ability to use Zendesk actions.
        /// </para>
        /// </summary>
        public CapabilityState UseZendeskAction { get; set; }

        /// <summary>
        /// Checks to see if the UseZendeskAction property is set.
        /// </summary>
        internal bool IsSetUseZendeskAction() => this.UseZendeskAction != null;

        /// <summary>
        /// Gets and sets the property UseZoomAction. 
        /// <para>
        /// The ability to use Zoom actions.
        /// </para>
        /// </summary>
        public CapabilityState UseZoomAction { get; set; }

        /// <summary>
        /// Checks to see if the UseZoomAction property is set.
        /// </summary>
        internal bool IsSetUseZoomAction() => this.UseZoomAction != null;

        /// <summary>
        /// Gets and sets the property UseZoomInfoAction. 
        /// <para>
        /// The ability to use ZoomInfo Agent actions.
        /// </para>
        /// </summary>
        public CapabilityState UseZoomInfoAction { get; set; }

        /// <summary>
        /// Checks to see if the UseZoomInfoAction property is set.
        /// </summary>
        internal bool IsSetUseZoomInfoAction() => this.UseZoomInfoAction != null;

        /// <summary>
        /// Gets and sets the property ViewAccountSPICECapacity. 
        /// <para>
        /// The ability to view account SPICE capacity.
        /// </para>
        /// </summary>
        public CapabilityState ViewAccountSPICECapacity { get; set; }

        /// <summary>
        /// Checks to see if the ViewAccountSPICECapacity property is set.
        /// </summary>
        internal bool IsSetViewAccountSPICECapacity() => this.ViewAccountSPICECapacity != null;

        /// <summary>
        /// Gets and sets the property VisierAgentAction. 
        /// <para>
        /// The ability to perform actions using Visier Agent connectors.
        /// </para>
        /// </summary>
        public CapabilityState VisierAgentAction { get; set; }

        /// <summary>
        /// Checks to see if the VisierAgentAction property is set.
        /// </summary>
        internal bool IsSetVisierAgentAction() => this.VisierAgentAction != null;

        /// <summary>
        /// Gets and sets the property WebCrawlerKnowledgeBase.
        /// </summary>
        public CapabilityState WebCrawlerKnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the WebCrawlerKnowledgeBase property is set.
        /// </summary>
        internal bool IsSetWebCrawlerKnowledgeBase() => this.WebCrawlerKnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property WhatsAppAction. 
        /// <para>
        /// The ability to perform actions using WhatsApp connectors.
        /// </para>
        /// </summary>
        public CapabilityState WhatsAppAction { get; set; }

        /// <summary>
        /// Checks to see if the WhatsAppAction property is set.
        /// </summary>
        internal bool IsSetWhatsAppAction() => this.WhatsAppAction != null;

        /// <summary>
        /// Gets and sets the property ZapierAction. 
        /// <para>
        /// The ability to perform actions using Zapier Agent connectors.
        /// </para>
        /// </summary>
        public CapabilityState ZapierAction { get; set; }

        /// <summary>
        /// Checks to see if the ZapierAction property is set.
        /// </summary>
        internal bool IsSetZapierAction() => this.ZapierAction != null;

        /// <summary>
        /// Gets and sets the property ZendeskAction. 
        /// <para>
        /// The ability to perform actions using Zendesk connectors.
        /// </para>
        /// </summary>
        public CapabilityState ZendeskAction { get; set; }

        /// <summary>
        /// Checks to see if the ZendeskAction property is set.
        /// </summary>
        internal bool IsSetZendeskAction() => this.ZendeskAction != null;

        /// <summary>
        /// Gets and sets the property ZoomAction. 
        /// <para>
        /// The ability to perform actions using Zoom connectors.
        /// </para>
        /// </summary>
        public CapabilityState ZoomAction { get; set; }

        /// <summary>
        /// Checks to see if the ZoomAction property is set.
        /// </summary>
        internal bool IsSetZoomAction() => this.ZoomAction != null;

        /// <summary>
        /// Gets and sets the property ZoomInfoAction. 
        /// <para>
        /// The ability to perform actions using ZoomInfo Agent connectors.
        /// </para>
        /// </summary>
        public CapabilityState ZoomInfoAction { get; set; }

        /// <summary>
        /// Checks to see if the ZoomInfoAction property is set.
        /// </summary>
        internal bool IsSetZoomInfoAction() => this.ZoomInfoAction != null;
    }
}
