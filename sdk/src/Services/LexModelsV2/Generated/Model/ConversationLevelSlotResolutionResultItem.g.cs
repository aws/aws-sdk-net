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
    /// The slots used for the slot resolution in the conversation.
    /// </summary>
    public partial class ConversationLevelSlotResolutionResultItem
    {
        /// <summary>
        /// Gets and sets the property IntentName. 
        /// <para>
        /// The intents used in the slots list for the slot resolution details.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string IntentName { get; set; }

        /// <summary>
        /// Checks to see if the IntentName property is set.
        /// </summary>
        internal bool IsSetIntentName() => this.IntentName != null;

        /// <summary>
        /// Gets and sets the property MatchResult. 
        /// <para>
        /// The number of matching slots used in the slots listings for the slot resolution evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TestResultMatchStatus MatchResult { get; set; }

        /// <summary>
        /// Checks to see if the MatchResult property is set.
        /// </summary>
        internal bool IsSetMatchResult() => this.MatchResult != null;

        /// <summary>
        /// Gets and sets the property SlotName. 
        /// <para>
        /// The slot name in the slots list for the slot resolution details.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string SlotName { get; set; }

        /// <summary>
        /// Checks to see if the SlotName property is set.
        /// </summary>
        internal bool IsSetSlotName() => this.SlotName != null;
    }
}
