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

namespace Amazon.Lex.Model
{
    /// <summary>
    /// An intent that Amazon Lex suggests satisfies the user's intent. Includes the name
    /// of the intent, the confidence that Amazon Lex has that the user's intent is satisfied,
    /// and the slots defined for the intent.
    /// </summary>
    public partial class PredictedIntent
    {
        /// <summary>
        /// Gets and sets the property IntentName. 
        /// <para>
        /// The name of the intent that Amazon Lex suggests satisfies the user's intent.
        /// </para>
        /// </summary>
        public string IntentName { get; set; }

        /// <summary>
        /// Checks to see if the IntentName property is set.
        /// </summary>
        internal bool IsSetIntentName() => this.IntentName != null;

        /// <summary>
        /// Gets and sets the property NluIntentConfidence. 
        /// <para>
        /// Indicates how confident Amazon Lex is that an intent satisfies the user's intent.
        /// </para>
        /// </summary>
        public IntentConfidence NluIntentConfidence { get; set; }

        /// <summary>
        /// Checks to see if the NluIntentConfidence property is set.
        /// </summary>
        internal bool IsSetNluIntentConfidence() => this.NluIntentConfidence != null;

        /// <summary>
        /// Gets and sets the property Slots. 
        /// <para>
        /// The slot and slot values associated with the predicted intent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, string> Slots { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Slots property is set.
        /// </summary>
        internal bool IsSetSlots() => this.Slots != null && (this.Slots.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
