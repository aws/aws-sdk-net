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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Configures the Assisted Natural Language Understanding (NLU) feature for your bot.
    /// This specification determines whether enhanced intent recognition and utterance understanding
    /// capabilities are active.
    /// </summary>
    public partial class NluImprovementSpecification
    {
        /// <summary>
        /// Gets and sets the property AssistedNluMode. 
        /// <para>
        /// Specifies the mode for Assisted NLU operation. Use <c>Primary</c> to make Assisted
        /// NLU the primary intent recognition method, or <c>Fallback</c> to use it only when
        /// standard NLU confidence is low.
        /// </para>
        /// </summary>
        public AssistedNluMode AssistedNluMode { get; set; }

        /// <summary>
        /// Checks to see if the AssistedNluMode property is set.
        /// </summary>
        internal bool IsSetAssistedNluMode() => this.AssistedNluMode != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Determines whether the Assisted NLU feature is enabled for the bot. When set to <c>true</c>,
        /// Amazon Lex uses advanced models to improve intent recognition and slot resolution,
        /// with the default being <c>false</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property IntentDisambiguationSettings. 
        /// <para>
        /// An object containing specifications for the Intent Disambiguation feature within the
        /// Assisted NLU settings. These settings determine how the bot handles ambiguous user
        /// inputs that could match multiple intents.
        /// </para>
        /// </summary>
        public IntentDisambiguationSettings IntentDisambiguationSettings { get; set; }

        /// <summary>
        /// Checks to see if the IntentDisambiguationSettings property is set.
        /// </summary>
        internal bool IsSetIntentDisambiguationSettings() => this.IntentDisambiguationSettings != null;
    }
}
