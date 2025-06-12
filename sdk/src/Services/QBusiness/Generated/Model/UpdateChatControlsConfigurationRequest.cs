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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateChatControlsConfiguration operation.
    /// Updates a set of chat controls configured for an existing Amazon Q Business application.
    /// </summary>
    public partial class UpdateChatControlsConfigurationRequest : AmazonQBusinessRequest
    {
        private string _applicationId;
        private BlockedPhrasesConfigurationUpdate _blockedPhrasesConfigurationUpdate;
        private string _clientToken;
        private CreatorModeConfiguration _creatorModeConfiguration;
        private HallucinationReductionConfiguration _hallucinationReductionConfiguration;
        private OrchestrationConfiguration _orchestrationConfiguration;
        private ResponseScope _responseScope;
        private List<TopicConfiguration> _topicConfigurationsToCreateOrUpdate = AWSConfigs.InitializeCollections ? new List<TopicConfiguration>() : null;
        private List<TopicConfiguration> _topicConfigurationsToDelete = AWSConfigs.InitializeCollections ? new List<TopicConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the application for which the chat controls are configured.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property BlockedPhrasesConfigurationUpdate. 
        /// <para>
        /// The phrases blocked from chat by your chat control configuration.
        /// </para>
        /// </summary>
        public BlockedPhrasesConfigurationUpdate BlockedPhrasesConfigurationUpdate
        {
            get { return this._blockedPhrasesConfigurationUpdate; }
            set { this._blockedPhrasesConfigurationUpdate = value; }
        }

        // Check to see if BlockedPhrasesConfigurationUpdate property is set
        internal bool IsSetBlockedPhrasesConfigurationUpdate()
        {
            return this._blockedPhrasesConfigurationUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token that you provide to identify the request to update a Amazon Q Business application
        /// chat configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property CreatorModeConfiguration. 
        /// <para>
        /// The configuration details for <c>CREATOR_MODE</c>.
        /// </para>
        /// </summary>
        public CreatorModeConfiguration CreatorModeConfiguration
        {
            get { return this._creatorModeConfiguration; }
            set { this._creatorModeConfiguration = value; }
        }

        // Check to see if CreatorModeConfiguration property is set
        internal bool IsSetCreatorModeConfiguration()
        {
            return this._creatorModeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property HallucinationReductionConfiguration. 
        /// <para>
        ///  The hallucination reduction settings for your application.
        /// </para>
        /// </summary>
        public HallucinationReductionConfiguration HallucinationReductionConfiguration
        {
            get { return this._hallucinationReductionConfiguration; }
            set { this._hallucinationReductionConfiguration = value; }
        }

        // Check to see if HallucinationReductionConfiguration property is set
        internal bool IsSetHallucinationReductionConfiguration()
        {
            return this._hallucinationReductionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property OrchestrationConfiguration. 
        /// <para>
        ///  The chat response orchestration settings for your application.
        /// </para>
        /// </summary>
        public OrchestrationConfiguration OrchestrationConfiguration
        {
            get { return this._orchestrationConfiguration; }
            set { this._orchestrationConfiguration = value; }
        }

        // Check to see if OrchestrationConfiguration property is set
        internal bool IsSetOrchestrationConfiguration()
        {
            return this._orchestrationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseScope. 
        /// <para>
        /// The response scope configured for your application. This determines whether your application
        /// uses its retrieval augmented generation (RAG) system to generate answers only from
        /// your enterprise data, or also uses the large language models (LLM) knowledge to respons
        /// to end user questions in chat.
        /// </para>
        /// </summary>
        public ResponseScope ResponseScope
        {
            get { return this._responseScope; }
            set { this._responseScope = value; }
        }

        // Check to see if ResponseScope property is set
        internal bool IsSetResponseScope()
        {
            return this._responseScope != null;
        }

        /// <summary>
        /// Gets and sets the property TopicConfigurationsToCreateOrUpdate. 
        /// <para>
        /// The configured topic specific chat controls you want to update.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<TopicConfiguration> TopicConfigurationsToCreateOrUpdate
        {
            get { return this._topicConfigurationsToCreateOrUpdate; }
            set { this._topicConfigurationsToCreateOrUpdate = value; }
        }

        // Check to see if TopicConfigurationsToCreateOrUpdate property is set
        internal bool IsSetTopicConfigurationsToCreateOrUpdate()
        {
            return this._topicConfigurationsToCreateOrUpdate != null && (this._topicConfigurationsToCreateOrUpdate.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TopicConfigurationsToDelete. 
        /// <para>
        /// The configured topic specific chat controls you want to delete.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<TopicConfiguration> TopicConfigurationsToDelete
        {
            get { return this._topicConfigurationsToDelete; }
            set { this._topicConfigurationsToDelete = value; }
        }

        // Check to see if TopicConfigurationsToDelete property is set
        internal bool IsSetTopicConfigurationsToDelete()
        {
            return this._topicConfigurationsToDelete != null && (this._topicConfigurationsToDelete.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}