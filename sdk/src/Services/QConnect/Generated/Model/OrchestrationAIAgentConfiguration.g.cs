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
    /// The configuration for AI Agents of type <c>ORCHESTRATION</c>.
    /// </summary>
    public partial class OrchestrationAIAgentConfiguration
    {
        /// <summary>
        /// Gets and sets the property ConnectInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Connect instance used by the Orchestration
        /// AI Agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ConnectInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the ConnectInstanceArn property is set.
        /// </summary>
        internal bool IsSetConnectInstanceArn() => this.ConnectInstanceArn != null;

        /// <summary>
        /// Gets and sets the property InputSchemas. 
        /// <para>
        /// The JSON schemas that define the structure of the structured data input accepted by
        /// the Orchestration AI Agent. The data in a <c>DATA</c> message sent to the agent is
        /// validated against these schemas. You can specify at most one schema.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<Amazon.Runtime.Documents.Document> InputSchemas { get; set; } = AWSConfigs.InitializeCollections ? new List<Amazon.Runtime.Documents.Document>() : null;

        /// <summary>
        /// Checks to see if the InputSchemas property is set.
        /// </summary>
        internal bool IsSetInputSchemas() => this.InputSchemas != null && (this.InputSchemas.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale setting for the Orchestration AI Agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string Locale { get; set; }

        /// <summary>
        /// Checks to see if the Locale property is set.
        /// </summary>
        internal bool IsSetLocale() => this.Locale != null;

        /// <summary>
        /// Gets and sets the property MultiAgentConfigurations. 
        /// <para>
        /// The collaborator agents that the Orchestration AI Agent can work with. Each entry
        /// defines another agent that the orchestrator either delegates to or hands the conversation
        /// off to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MultiAgentConfiguration> MultiAgentConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<MultiAgentConfiguration>() : null;

        /// <summary>
        /// Checks to see if the MultiAgentConfigurations property is set.
        /// </summary>
        internal bool IsSetMultiAgentConfigurations() => this.MultiAgentConfigurations != null && (this.MultiAgentConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OrchestrationAIGuardrailId. 
        /// <para>
        /// The AI Guardrail identifier used by the Orchestration AI Agent.
        /// </para>
        /// </summary>
        public string OrchestrationAIGuardrailId { get; set; }

        /// <summary>
        /// Checks to see if the OrchestrationAIGuardrailId property is set.
        /// </summary>
        internal bool IsSetOrchestrationAIGuardrailId() => this.OrchestrationAIGuardrailId != null;

        /// <summary>
        /// Gets and sets the property OrchestrationAIPromptId. 
        /// <para>
        /// The AI Prompt identifier used by the Orchestration AI Agent.
        /// </para>
        /// </summary>
        public string OrchestrationAIPromptId { get; set; }

        /// <summary>
        /// Checks to see if the OrchestrationAIPromptId property is set.
        /// </summary>
        internal bool IsSetOrchestrationAIPromptId() => this.OrchestrationAIPromptId != null;

        /// <summary>
        /// Gets and sets the property OutputSchemas. 
        /// <para>
        /// The JSON schemas that define the structure of the structured output generated by the
        /// Orchestration AI Agent. You can specify at most one schema.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<Amazon.Runtime.Documents.Document> OutputSchemas { get; set; } = AWSConfigs.InitializeCollections ? new List<Amazon.Runtime.Documents.Document>() : null;

        /// <summary>
        /// Checks to see if the OutputSchemas property is set.
        /// </summary>
        internal bool IsSetOutputSchemas() => this.OutputSchemas != null && (this.OutputSchemas.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ToolConfigurations. 
        /// <para>
        /// The tool configurations used by the Orchestration AI Agent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ToolConfiguration> ToolConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<ToolConfiguration>() : null;

        /// <summary>
        /// Checks to see if the ToolConfigurations property is set.
        /// </summary>
        internal bool IsSetToolConfigurations() => this.ToolConfigurations != null && (this.ToolConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
