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
    /// This is the response object from the GetChatControlsConfiguration operation.
    /// </summary>
    public partial class GetChatControlsConfigurationResponse : AmazonWebServiceResponse
    {
        private BlockedPhrasesConfiguration _blockedPhrases;
        private AppliedCreatorModeConfiguration _creatorModeConfiguration;
        private string _nextToken;
        private ResponseScope _responseScope;
        private List<TopicConfiguration> _topicConfigurations = AWSConfigs.InitializeCollections ? new List<TopicConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property BlockedPhrases. 
        /// <para>
        /// The phrases blocked from chat by your chat control configuration.
        /// </para>
        /// </summary>
        public BlockedPhrasesConfiguration BlockedPhrases
        {
            get { return this._blockedPhrases; }
            set { this._blockedPhrases = value; }
        }

        // Check to see if BlockedPhrases property is set
        internal bool IsSetBlockedPhrases()
        {
            return this._blockedPhrases != null;
        }

        /// <summary>
        /// Gets and sets the property CreatorModeConfiguration. 
        /// <para>
        /// The configuration details for <c>CREATOR_MODE</c>.
        /// </para>
        /// </summary>
        public AppliedCreatorModeConfiguration CreatorModeConfiguration
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the <c>maxResults</c> response was incomplete because there is more data to retrieve,
        /// Amazon Q Business returns a pagination token in the response. You can use this pagination
        /// token to retrieve the next set of Amazon Q Business chat controls configured.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=800)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseScope. 
        /// <para>
        /// The response scope configured for a Amazon Q Business application. This determines
        /// whether your application uses its retrieval augmented generation (RAG) system to generate
        /// answers only from your enterprise data, or also uses the large language models (LLM)
        /// knowledge to respons to end user questions in chat.
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
        /// Gets and sets the property TopicConfigurations. 
        /// <para>
        /// The topic specific controls configured for a Amazon Q Business application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<TopicConfiguration> TopicConfigurations
        {
            get { return this._topicConfigurations; }
            set { this._topicConfigurations = value; }
        }

        // Check to see if TopicConfigurations property is set
        internal bool IsSetTopicConfigurations()
        {
            return this._topicConfigurations != null && (this._topicConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}