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
    /// The configuration for AI Agents of type SELF_SERVICE.
    /// </summary>
    public partial class SelfServiceAIAgentConfiguration
    {
        private List<AssociationConfiguration> _associationConfigurations = AWSConfigs.InitializeCollections ? new List<AssociationConfiguration>() : null;
        private string _selfServiceAIGuardrailId;
        private string _selfServiceAnswerGenerationAIPromptId;
        private string _selfServicePreProcessingAIPromptId;

        /// <summary>
        /// Gets and sets the property AssociationConfigurations. 
        /// <para>
        /// The association configurations for overriding behavior on this AI Agent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssociationConfiguration> AssociationConfigurations
        {
            get { return this._associationConfigurations; }
            set { this._associationConfigurations = value; }
        }

        // Check to see if AssociationConfigurations property is set
        internal bool IsSetAssociationConfigurations()
        {
            return this._associationConfigurations != null && (this._associationConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SelfServiceAIGuardrailId. 
        /// <para>
        /// The AI Guardrail identifier used by the SELF_SERVICE AI Agent.
        /// </para>
        /// </summary>
        public string SelfServiceAIGuardrailId
        {
            get { return this._selfServiceAIGuardrailId; }
            set { this._selfServiceAIGuardrailId = value; }
        }

        // Check to see if SelfServiceAIGuardrailId property is set
        internal bool IsSetSelfServiceAIGuardrailId()
        {
            return this._selfServiceAIGuardrailId != null;
        }

        /// <summary>
        /// Gets and sets the property SelfServiceAnswerGenerationAIPromptId. 
        /// <para>
        /// The AI Prompt identifier for the Self Service Answer Generation prompt used by the
        /// SELF_SERVICE AI Agent
        /// </para>
        /// </summary>
        public string SelfServiceAnswerGenerationAIPromptId
        {
            get { return this._selfServiceAnswerGenerationAIPromptId; }
            set { this._selfServiceAnswerGenerationAIPromptId = value; }
        }

        // Check to see if SelfServiceAnswerGenerationAIPromptId property is set
        internal bool IsSetSelfServiceAnswerGenerationAIPromptId()
        {
            return this._selfServiceAnswerGenerationAIPromptId != null;
        }

        /// <summary>
        /// Gets and sets the property SelfServicePreProcessingAIPromptId. 
        /// <para>
        /// The AI Prompt identifier for the Self Service Pre-Processing prompt used by the SELF_SERVICE
        /// AI Agent
        /// </para>
        /// </summary>
        public string SelfServicePreProcessingAIPromptId
        {
            get { return this._selfServicePreProcessingAIPromptId; }
            set { this._selfServicePreProcessingAIPromptId = value; }
        }

        // Check to see if SelfServicePreProcessingAIPromptId property is set
        internal bool IsSetSelfServicePreProcessingAIPromptId()
        {
            return this._selfServicePreProcessingAIPromptId != null;
        }

    }
}