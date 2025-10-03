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
    /// Configuration settings for the EMAIL_RESPONSE AI agent including prompts, locale,
    /// and knowledge base associations.
    /// </summary>
    public partial class EmailResponseAIAgentConfiguration
    {
        private List<AssociationConfiguration> _associationConfigurations = AWSConfigs.InitializeCollections ? new List<AssociationConfiguration>() : null;
        private string _emailQueryReformulationAIPromptId;
        private string _emailResponseAIPromptId;
        private string _locale;

        /// <summary>
        /// Gets and sets the property AssociationConfigurations. 
        /// <para>
        /// Configuration settings for knowledge base associations used by the email response
        /// agent.
        /// </para>
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
        /// Gets and sets the property EmailQueryReformulationAIPromptId. 
        /// <para>
        /// The ID of the System AI prompt used for reformulating email queries to optimize knowledge
        /// base search for response generation.
        /// </para>
        /// </summary>
        public string EmailQueryReformulationAIPromptId
        {
            get { return this._emailQueryReformulationAIPromptId; }
            set { this._emailQueryReformulationAIPromptId = value; }
        }

        // Check to see if EmailQueryReformulationAIPromptId property is set
        internal bool IsSetEmailQueryReformulationAIPromptId()
        {
            return this._emailQueryReformulationAIPromptId != null;
        }

        /// <summary>
        /// Gets and sets the property EmailResponseAIPromptId. 
        /// <para>
        /// The ID of the System AI prompt used for generating professional email responses based
        /// on knowledge base content.
        /// </para>
        /// </summary>
        public string EmailResponseAIPromptId
        {
            get { return this._emailResponseAIPromptId; }
            set { this._emailResponseAIPromptId = value; }
        }

        // Check to see if EmailResponseAIPromptId property is set
        internal bool IsSetEmailResponseAIPromptId()
        {
            return this._emailResponseAIPromptId != null;
        }

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale setting for language-specific email response generation (for example, en_US,
        /// es_ES).
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

    }
}