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
    /// This is the response object from the GetChatControlsConfiguration operation.
    /// </summary>
    public partial class GetChatControlsConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BlockedPhrases. 
        /// <para>
        /// The phrases blocked from chat by your chat control configuration.
        /// </para>
        /// </summary>
        public BlockedPhrasesConfiguration BlockedPhrases { get; set; }

        /// <summary>
        /// Checks to see if the BlockedPhrases property is set.
        /// </summary>
        internal bool IsSetBlockedPhrases() => this.BlockedPhrases != null;

        /// <summary>
        /// Gets and sets the property CreatorModeConfiguration. 
        /// <para>
        /// The configuration details for <c>CREATOR_MODE</c>.
        /// </para>
        /// </summary>
        public AppliedCreatorModeConfiguration CreatorModeConfiguration { get; set; }

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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the <c>maxResults</c> response was incomplete because there is more data to retrieve,
        /// Amazon Q Business returns a pagination token in the response. You can use this pagination
        /// token to retrieve the next set of Amazon Q Business chat controls configured.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 800)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property OrchestrationConfiguration. 
        /// <para>
        ///  The chat response orchestration settings for your application.
        /// </para>
        ///  <note> 
        /// <para>
        /// Chat orchestration is optimized to work for English language content. For more details
        /// on language support in Amazon Q Business, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/supported-languages.html">Supported
        /// languages</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public AppliedOrchestrationConfiguration OrchestrationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OrchestrationConfiguration property is set.
        /// </summary>
        internal bool IsSetOrchestrationConfiguration() => this.OrchestrationConfiguration != null;

        /// <summary>
        /// Gets and sets the property ResponseScope. 
        /// <para>
        /// The response scope configured for a Amazon Q Business application. This determines
        /// whether your application uses its retrieval augmented generation (RAG) system to generate
        /// answers only from your enterprise data, or also uses the large language models (LLM)
        /// knowledge to respons to end user questions in chat.
        /// </para>
        /// </summary>
        public ResponseScope ResponseScope { get; set; }

        /// <summary>
        /// Checks to see if the ResponseScope property is set.
        /// </summary>
        internal bool IsSetResponseScope() => this.ResponseScope != null;

        /// <summary>
        /// Gets and sets the property TopicConfigurations. 
        /// <para>
        /// The topic specific controls configured for a Amazon Q Business application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<TopicConfiguration> TopicConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<TopicConfiguration>() : null;

        /// <summary>
        /// Checks to see if the TopicConfigurations property is set.
        /// </summary>
        internal bool IsSetTopicConfigurations() => this.TopicConfigurations != null && (this.TopicConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
