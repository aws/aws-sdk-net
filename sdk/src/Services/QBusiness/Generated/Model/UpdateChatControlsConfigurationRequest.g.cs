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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateChatControlsConfiguration operation. Updates
    /// a set of chat controls configured for an existing Amazon Q Business application.
    /// </summary>
    public partial class UpdateChatControlsConfigurationRequest : AmazonQBusinessRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the application for which the chat controls are configured.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property BlockedPhrasesConfigurationUpdate. 
        /// <para>
        /// The phrases blocked from chat by your chat control configuration.
        /// </para>
        /// </summary>
        public BlockedPhrasesConfigurationUpdate BlockedPhrasesConfigurationUpdate { get; set; }

        /// <summary>
        /// Checks to see if the BlockedPhrasesConfigurationUpdate property is set.
        /// </summary>
        internal bool IsSetBlockedPhrasesConfigurationUpdate() => this.BlockedPhrasesConfigurationUpdate != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token that you provide to identify the request to update a Amazon Q Business application
        /// chat configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property CreatorModeConfiguration. 
        /// <para>
        /// The configuration details for <c>CREATOR_MODE</c>.
        /// </para>
        /// </summary>
        public CreatorModeConfiguration CreatorModeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CreatorModeConfiguration property is set.
        /// </summary>
        internal bool IsSetCreatorModeConfiguration() => this.CreatorModeConfiguration != null;

        /// <summary>
        /// Gets and sets the property HallucinationReductionConfiguration. 
        /// <para>
        ///  The hallucination reduction settings for your application.
        /// </para>
        /// </summary>
        public HallucinationReductionConfiguration HallucinationReductionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the HallucinationReductionConfiguration property is set.
        /// </summary>
        internal bool IsSetHallucinationReductionConfiguration() => this.HallucinationReductionConfiguration != null;

        /// <summary>
        /// Gets and sets the property OrchestrationConfiguration. 
        /// <para>
        ///  The chat response orchestration settings for your application.
        /// </para>
        /// </summary>
        public OrchestrationConfiguration OrchestrationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OrchestrationConfiguration property is set.
        /// </summary>
        internal bool IsSetOrchestrationConfiguration() => this.OrchestrationConfiguration != null;

        /// <summary>
        /// Gets and sets the property ResponseScope. 
        /// <para>
        /// The response scope configured for your application. This determines whether your application
        /// uses its retrieval augmented generation (RAG) system to generate answers only from
        /// your enterprise data, or also uses the large language models (LLM) knowledge to respons
        /// to end user questions in chat.
        /// </para>
        /// </summary>
        public ResponseScope ResponseScope { get; set; }

        /// <summary>
        /// Checks to see if the ResponseScope property is set.
        /// </summary>
        internal bool IsSetResponseScope() => this.ResponseScope != null;

        /// <summary>
        /// Gets and sets the property TopicConfigurationsToCreateOrUpdate. 
        /// <para>
        /// The configured topic specific chat controls you want to update.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<TopicConfiguration> TopicConfigurationsToCreateOrUpdate { get; set; } = AWSConfigs.InitializeCollections ? new List<TopicConfiguration>() : null;

        /// <summary>
        /// Checks to see if the TopicConfigurationsToCreateOrUpdate property is set.
        /// </summary>
        internal bool IsSetTopicConfigurationsToCreateOrUpdate() => this.TopicConfigurationsToCreateOrUpdate != null && (this.TopicConfigurationsToCreateOrUpdate.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TopicConfigurationsToDelete. 
        /// <para>
        /// The configured topic specific chat controls you want to delete.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<TopicConfiguration> TopicConfigurationsToDelete { get; set; } = AWSConfigs.InitializeCollections ? new List<TopicConfiguration>() : null;

        /// <summary>
        /// Checks to see if the TopicConfigurationsToDelete property is set.
        /// </summary>
        internal bool IsSetTopicConfigurationsToDelete() => this.TopicConfigurationsToDelete != null && (this.TopicConfigurationsToDelete.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
