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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// A typed union that specifies the configuration based on the type of AI Agent.
    /// </summary>
    public partial class AIAgentConfiguration
    {
        private AnswerRecommendationAIAgentConfiguration _answerRecommendationAIAgentConfiguration;
        private ManualSearchAIAgentConfiguration _manualSearchAIAgentConfiguration;
        private SelfServiceAIAgentConfiguration _selfServiceAIAgentConfiguration;

        /// <summary>
        /// Gets and sets the property AnswerRecommendationAIAgentConfiguration. 
        /// <para>
        /// The configuration for AI Agents of type <c>ANSWER_RECOMMENDATION</c>.
        /// </para>
        /// </summary>
        public AnswerRecommendationAIAgentConfiguration AnswerRecommendationAIAgentConfiguration
        {
            get { return this._answerRecommendationAIAgentConfiguration; }
            set { this._answerRecommendationAIAgentConfiguration = value; }
        }

        // Check to see if AnswerRecommendationAIAgentConfiguration property is set
        internal bool IsSetAnswerRecommendationAIAgentConfiguration()
        {
            return this._answerRecommendationAIAgentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ManualSearchAIAgentConfiguration. 
        /// <para>
        /// The configuration for AI Agents of type <c>MANUAL_SEARCH</c>.
        /// </para>
        /// </summary>
        public ManualSearchAIAgentConfiguration ManualSearchAIAgentConfiguration
        {
            get { return this._manualSearchAIAgentConfiguration; }
            set { this._manualSearchAIAgentConfiguration = value; }
        }

        // Check to see if ManualSearchAIAgentConfiguration property is set
        internal bool IsSetManualSearchAIAgentConfiguration()
        {
            return this._manualSearchAIAgentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SelfServiceAIAgentConfiguration. 
        /// <para>
        /// The configuration for AI Agents of type SELF_SERVICE.
        /// </para>
        /// </summary>
        public SelfServiceAIAgentConfiguration SelfServiceAIAgentConfiguration
        {
            get { return this._selfServiceAIAgentConfiguration; }
            set { this._selfServiceAIAgentConfiguration = value; }
        }

        // Check to see if SelfServiceAIAgentConfiguration property is set
        internal bool IsSetSelfServiceAIAgentConfiguration()
        {
            return this._selfServiceAIAgentConfiguration != null;
        }

    }
}