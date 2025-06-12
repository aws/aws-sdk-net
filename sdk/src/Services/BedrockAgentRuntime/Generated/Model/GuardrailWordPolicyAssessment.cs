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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// The assessment details for words defined in the Guardrail filter.
    /// </summary>
    public partial class GuardrailWordPolicyAssessment
    {
        private List<GuardrailCustomWord> _customWords = AWSConfigs.InitializeCollections ? new List<GuardrailCustomWord>() : null;
        private List<GuardrailManagedWord> _managedWordLists = AWSConfigs.InitializeCollections ? new List<GuardrailManagedWord>() : null;

        /// <summary>
        /// Gets and sets the property CustomWords. 
        /// <para>
        /// The custom word details for words defined in the Guardrail filter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public List<GuardrailCustomWord> CustomWords
        {
            get { return this._customWords; }
            set { this._customWords = value; }
        }

        // Check to see if CustomWords property is set
        internal bool IsSetCustomWords()
        {
            return this._customWords != null && (this._customWords.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ManagedWordLists. 
        /// <para>
        /// The managed word lists for words defined in the Guardrail filter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public List<GuardrailManagedWord> ManagedWordLists
        {
            get { return this._managedWordLists; }
            set { this._managedWordLists = value; }
        }

        // Check to see if ManagedWordLists property is set
        internal bool IsSetManagedWordLists()
        {
            return this._managedWordLists != null && (this._managedWordLists.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}