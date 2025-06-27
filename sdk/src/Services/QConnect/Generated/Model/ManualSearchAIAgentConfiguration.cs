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
    /// The configuration for the <c>MANUAL_SEARCH</c> AI Agent type.
    /// </summary>
    public partial class ManualSearchAIAgentConfiguration
    {
        private string _answerGenerationAIGuardrailId;
        private string _answerGenerationAIPromptId;
        private List<AssociationConfiguration> _associationConfigurations = AWSConfigs.InitializeCollections ? new List<AssociationConfiguration>() : null;
        private string _locale;

        /// <summary>
        /// Gets and sets the property AnswerGenerationAIGuardrailId. 
        /// <para>
        /// The AI Guardrail identifier for the Answer Generation guardrail used by the MANUAL_SEARCH
        /// AI Agent.
        /// </para>
        /// </summary>
        public string AnswerGenerationAIGuardrailId
        {
            get { return this._answerGenerationAIGuardrailId; }
            set { this._answerGenerationAIGuardrailId = value; }
        }

        // Check to see if AnswerGenerationAIGuardrailId property is set
        internal bool IsSetAnswerGenerationAIGuardrailId()
        {
            return this._answerGenerationAIGuardrailId != null;
        }

        /// <summary>
        /// Gets and sets the property AnswerGenerationAIPromptId. 
        /// <para>
        /// The AI Prompt identifier for the Answer Generation prompt used by the MANUAL_SEARCH
        /// AI Agent.
        /// </para>
        /// </summary>
        public string AnswerGenerationAIPromptId
        {
            get { return this._answerGenerationAIPromptId; }
            set { this._answerGenerationAIPromptId = value; }
        }

        // Check to see if AnswerGenerationAIPromptId property is set
        internal bool IsSetAnswerGenerationAIPromptId()
        {
            return this._answerGenerationAIPromptId != null;
        }

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
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale to which specifies the language and region settings that determine the
        /// response language for <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_amazon-q-connect_QueryAssistant.html">QueryAssistant</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// For more information on supported locales, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/supported-languages.html#qic-notes-languages">Language
        /// support for Amazon Q in Connect</a>.
        /// </para>
        ///  </note>
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

    }
}