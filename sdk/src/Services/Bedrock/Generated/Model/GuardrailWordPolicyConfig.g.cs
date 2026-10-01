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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Contains details about the word policy to configured for the guardrail.
    /// </summary>
    public partial class GuardrailWordPolicyConfig
    {
        /// <summary>
        /// Gets and sets the property ManagedWordListsConfig. 
        /// <para>
        /// A list of managed words to configure for the guardrail.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GuardrailManagedWordsConfig> ManagedWordListsConfig { get; set; } = AWSConfigs.InitializeCollections ? new List<GuardrailManagedWordsConfig>() : null;

        /// <summary>
        /// Checks to see if the ManagedWordListsConfig property is set.
        /// </summary>
        internal bool IsSetManagedWordListsConfig() => this.ManagedWordListsConfig != null && (this.ManagedWordListsConfig.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WordsConfig. 
        /// <para>
        /// A list of words to configure for the guardrail.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10000)]
        public List<GuardrailWordConfig> WordsConfig { get; set; } = AWSConfigs.InitializeCollections ? new List<GuardrailWordConfig>() : null;

        /// <summary>
        /// Checks to see if the WordsConfig property is set.
        /// </summary>
        internal bool IsSetWordsConfig() => this.WordsConfig != null && (this.WordsConfig.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
