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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// A typed union that specifies the configuration based on the type of AI Agent.
    /// </summary>
    public partial class AIAgentConfiguration
    {
        /// <summary>
        /// Gets and sets the property AnswerRecommendationAIAgentConfiguration. 
        /// <para>
        /// The configuration for AI Agents of type <c>ANSWER_RECOMMENDATION</c>.
        /// </para>
        /// </summary>
        public AnswerRecommendationAIAgentConfiguration AnswerRecommendationAIAgentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AnswerRecommendationAIAgentConfiguration property is set.
        /// </summary>
        internal bool IsSetAnswerRecommendationAIAgentConfiguration() => this.AnswerRecommendationAIAgentConfiguration != null;

        /// <summary>
        /// Gets and sets the property CaseSummarizationAIAgentConfiguration. 
        /// <para>
        /// The configuration for AI Agents of type <c>CASE_SUMMARIZATION</c>.
        /// </para>
        /// </summary>
        public CaseSummarizationAIAgentConfiguration CaseSummarizationAIAgentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CaseSummarizationAIAgentConfiguration property is set.
        /// </summary>
        internal bool IsSetCaseSummarizationAIAgentConfiguration() => this.CaseSummarizationAIAgentConfiguration != null;

        /// <summary>
        /// Gets and sets the property EmailGenerativeAnswerAIAgentConfiguration. 
        /// <para>
        /// Configuration for the EMAIL_GENERATIVE_ANSWER AI agent that provides comprehensive
        /// knowledge-based answers for customer queries.
        /// </para>
        /// </summary>
        public EmailGenerativeAnswerAIAgentConfiguration EmailGenerativeAnswerAIAgentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EmailGenerativeAnswerAIAgentConfiguration property is set.
        /// </summary>
        internal bool IsSetEmailGenerativeAnswerAIAgentConfiguration() => this.EmailGenerativeAnswerAIAgentConfiguration != null;

        /// <summary>
        /// Gets and sets the property EmailOverviewAIAgentConfiguration. 
        /// <para>
        /// Configuration for the EMAIL_OVERVIEW AI agent that generates structured overview of
        /// email conversations.
        /// </para>
        /// </summary>
        public EmailOverviewAIAgentConfiguration EmailOverviewAIAgentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EmailOverviewAIAgentConfiguration property is set.
        /// </summary>
        internal bool IsSetEmailOverviewAIAgentConfiguration() => this.EmailOverviewAIAgentConfiguration != null;

        /// <summary>
        /// Gets and sets the property EmailResponseAIAgentConfiguration. 
        /// <para>
        /// Configuration for the EMAIL_RESPONSE AI agent that generates professional email responses
        /// using knowledge base content.
        /// </para>
        /// </summary>
        public EmailResponseAIAgentConfiguration EmailResponseAIAgentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EmailResponseAIAgentConfiguration property is set.
        /// </summary>
        internal bool IsSetEmailResponseAIAgentConfiguration() => this.EmailResponseAIAgentConfiguration != null;

        /// <summary>
        /// Gets and sets the property ManualSearchAIAgentConfiguration. 
        /// <para>
        /// The configuration for AI Agents of type <c>MANUAL_SEARCH</c>.
        /// </para>
        /// </summary>
        public ManualSearchAIAgentConfiguration ManualSearchAIAgentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ManualSearchAIAgentConfiguration property is set.
        /// </summary>
        internal bool IsSetManualSearchAIAgentConfiguration() => this.ManualSearchAIAgentConfiguration != null;

        /// <summary>
        /// Gets and sets the property NoteTakingAIAgentConfiguration. 
        /// <para>
        /// The configuration for AI Agents of type <c>NOTE_TAKING</c>.
        /// </para>
        /// </summary>
        public NoteTakingAIAgentConfiguration NoteTakingAIAgentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NoteTakingAIAgentConfiguration property is set.
        /// </summary>
        internal bool IsSetNoteTakingAIAgentConfiguration() => this.NoteTakingAIAgentConfiguration != null;

        /// <summary>
        /// Gets and sets the property OrchestrationAIAgentConfiguration. 
        /// <para>
        /// The configuration for AI Agents of type <c>ORCHESTRATION</c>.
        /// </para>
        /// </summary>
        public OrchestrationAIAgentConfiguration OrchestrationAIAgentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OrchestrationAIAgentConfiguration property is set.
        /// </summary>
        internal bool IsSetOrchestrationAIAgentConfiguration() => this.OrchestrationAIAgentConfiguration != null;

        /// <summary>
        /// Gets and sets the property SelfServiceAIAgentConfiguration. 
        /// <para>
        /// The configuration for AI Agents of type SELF_SERVICE.
        /// </para>
        /// </summary>
        public SelfServiceAIAgentConfiguration SelfServiceAIAgentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SelfServiceAIAgentConfiguration property is set.
        /// </summary>
        internal bool IsSetSelfServiceAIAgentConfiguration() => this.SelfServiceAIAgentConfiguration != null;
    }
}
