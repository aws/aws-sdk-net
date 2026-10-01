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
    /// Configuration settings for the EMAIL_RESPONSE AI agent including prompts, locale,
    /// and knowledge base associations.
    /// </summary>
    public partial class EmailResponseAIAgentConfiguration
    {
        /// <summary>
        /// Gets and sets the property AssociationConfigurations. 
        /// <para>
        /// Configuration settings for knowledge base associations used by the email response
        /// agent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssociationConfiguration> AssociationConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<AssociationConfiguration>() : null;

        /// <summary>
        /// Checks to see if the AssociationConfigurations property is set.
        /// </summary>
        internal bool IsSetAssociationConfigurations() => this.AssociationConfigurations != null && (this.AssociationConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EmailQueryReformulationAIPromptId. 
        /// <para>
        /// The ID of the System AI prompt used for reformulating email queries to optimize knowledge
        /// base search for response generation.
        /// </para>
        /// </summary>
        public string EmailQueryReformulationAIPromptId { get; set; }

        /// <summary>
        /// Checks to see if the EmailQueryReformulationAIPromptId property is set.
        /// </summary>
        internal bool IsSetEmailQueryReformulationAIPromptId() => this.EmailQueryReformulationAIPromptId != null;

        /// <summary>
        /// Gets and sets the property EmailResponseAIPromptId. 
        /// <para>
        /// The ID of the System AI prompt used for generating professional email responses based
        /// on knowledge base content.
        /// </para>
        /// </summary>
        public string EmailResponseAIPromptId { get; set; }

        /// <summary>
        /// Checks to see if the EmailResponseAIPromptId property is set.
        /// </summary>
        internal bool IsSetEmailResponseAIPromptId() => this.EmailResponseAIPromptId != null;

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale setting for language-specific email response generation (for example, en_US,
        /// es_ES).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string Locale { get; set; }

        /// <summary>
        /// Checks to see if the Locale property is set.
        /// </summary>
        internal bool IsSetLocale() => this.Locale != null;
    }
}
