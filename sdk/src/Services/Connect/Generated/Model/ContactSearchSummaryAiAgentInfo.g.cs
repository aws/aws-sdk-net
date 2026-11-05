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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information of the AI agent involved in the contact.
    /// </summary>
    public partial class ContactSearchSummaryAiAgentInfo
    {
        /// <summary>
        /// Gets and sets the property AiAgentEscalated. 
        /// <para>
        /// A boolean flag indicating whether the contact initially handled by this AI agent was
        /// escalated to a human agent.
        /// </para>
        /// </summary>
        public bool? AiAgentEscalated { get; set; }

        /// <summary>
        /// Checks to see if the AiAgentEscalated property is set.
        /// </summary>
        internal bool IsSetAiAgentEscalated() => this.AiAgentEscalated.HasValue;

        /// <summary>
        /// Gets and sets the property AiAgentVersionId. 
        /// <para>
        /// The unique identifier that specifies both the AI agent ID and its version number that
        /// was involved in the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string AiAgentVersionId { get; set; }

        /// <summary>
        /// Checks to see if the AiAgentVersionId property is set.
        /// </summary>
        internal bool IsSetAiAgentVersionId() => this.AiAgentVersionId != null;

        /// <summary>
        /// Gets and sets the property AiUseCase. 
        /// <para>
        /// The use case or scenario for which the AI agent is involved in the contact. Valid
        /// values are <c>AgentAssistance</c> and <c>SelfService</c>.
        /// </para>
        /// </summary>
        public AiUseCase AiUseCase { get; set; }

        /// <summary>
        /// Checks to see if the AiUseCase property is set.
        /// </summary>
        internal bool IsSetAiUseCase() => this.AiUseCase != null;
    }
}
