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
    /// The configuration for AI Agents of type <c>ORCHESTRATION</c>.
    /// </summary>
    public partial class OrchestrationAIAgentConfiguration
    {
        private string _connectInstanceArn;
        private List<Amazon.Runtime.Documents.Document> _inputSchemas = AWSConfigs.InitializeCollections ? new List<Amazon.Runtime.Documents.Document>() : null;
        private string _locale;
        private List<MultiAgentConfiguration> _multiAgentConfigurations = AWSConfigs.InitializeCollections ? new List<MultiAgentConfiguration>() : null;
        private string _orchestrationaiGuardrailId;
        private string _orchestrationaiPromptId;
        private List<Amazon.Runtime.Documents.Document> _outputSchemas = AWSConfigs.InitializeCollections ? new List<Amazon.Runtime.Documents.Document>() : null;
        private List<ToolConfiguration> _toolConfigurations = AWSConfigs.InitializeCollections ? new List<ToolConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property ConnectInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Connect instance used by the Orchestration
        /// AI Agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ConnectInstanceArn
        {
            get { return this._connectInstanceArn; }
            set { this._connectInstanceArn = value; }
        }

        // Check to see if ConnectInstanceArn property is set
        internal bool IsSetConnectInstanceArn()
        {
            return this._connectInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property InputSchemas. 
        /// <para>
        /// The JSON schemas that define the structure of the structured data input accepted by
        /// the Orchestration AI Agent. The data in a <c>DATA</c> message sent to the agent is
        /// validated against these schemas. You can specify at most one schema.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<Amazon.Runtime.Documents.Document> InputSchemas
        {
            get { return this._inputSchemas; }
            set { this._inputSchemas = value; }
        }

        // Check to see if InputSchemas property is set
        internal bool IsSetInputSchemas()
        {
            return this._inputSchemas != null && (this._inputSchemas.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale setting for the Orchestration AI Agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string Locale
        {
            get { return this._locale; }
            set { this._locale = value; }
        }

        // Check to see if Locale property is set
        internal bool IsSetLocale()
        {
            return this._locale != null;
        }

        /// <summary>
        /// Gets and sets the property MultiAgentConfigurations. 
        /// <para>
        /// The collaborator agents that the Orchestration AI Agent can work with. Each entry
        /// defines another agent that the orchestrator either delegates to or hands the conversation
        /// off to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MultiAgentConfiguration> MultiAgentConfigurations
        {
            get { return this._multiAgentConfigurations; }
            set { this._multiAgentConfigurations = value; }
        }

        // Check to see if MultiAgentConfigurations property is set
        internal bool IsSetMultiAgentConfigurations()
        {
            return this._multiAgentConfigurations != null && (this._multiAgentConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OrchestrationAIGuardrailId. 
        /// <para>
        /// The AI Guardrail identifier used by the Orchestration AI Agent.
        /// </para>
        /// </summary>
        public string OrchestrationAIGuardrailId
        {
            get { return this._orchestrationaiGuardrailId; }
            set { this._orchestrationaiGuardrailId = value; }
        }

        // Check to see if OrchestrationAIGuardrailId property is set
        internal bool IsSetOrchestrationAIGuardrailId()
        {
            return this._orchestrationaiGuardrailId != null;
        }

        /// <summary>
        /// Gets and sets the property OrchestrationAIPromptId. 
        /// <para>
        /// The AI Prompt identifier used by the Orchestration AI Agent.
        /// </para>
        /// </summary>
        public string OrchestrationAIPromptId
        {
            get { return this._orchestrationaiPromptId; }
            set { this._orchestrationaiPromptId = value; }
        }

        // Check to see if OrchestrationAIPromptId property is set
        internal bool IsSetOrchestrationAIPromptId()
        {
            return this._orchestrationaiPromptId != null;
        }

        /// <summary>
        /// Gets and sets the property OutputSchemas. 
        /// <para>
        /// The JSON schemas that define the structure of the structured output generated by the
        /// Orchestration AI Agent. You can specify at most one schema.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<Amazon.Runtime.Documents.Document> OutputSchemas
        {
            get { return this._outputSchemas; }
            set { this._outputSchemas = value; }
        }

        // Check to see if OutputSchemas property is set
        internal bool IsSetOutputSchemas()
        {
            return this._outputSchemas != null && (this._outputSchemas.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ToolConfigurations. 
        /// <para>
        /// The tool configurations used by the Orchestration AI Agent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ToolConfiguration> ToolConfigurations
        {
            get { return this._toolConfigurations; }
            set { this._toolConfigurations = value; }
        }

        // Check to see if ToolConfigurations property is set
        internal bool IsSetToolConfigurations()
        {
            return this._toolConfigurations != null && (this._toolConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}