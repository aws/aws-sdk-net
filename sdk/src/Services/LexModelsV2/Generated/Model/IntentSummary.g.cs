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
    /// Summary information about an intent returned by the <c>ListIntents</c> operation.
    /// </summary>
    public partial class IntentSummary
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the intent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property InputContexts. 
        /// <para>
        /// The input contexts that must be active for this intent to be considered for recognition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<InputContext> InputContexts { get; set; } = AWSConfigs.InitializeCollections ? new List<InputContext>() : null;

        /// <summary>
        /// Checks to see if the InputContexts property is set.
        /// </summary>
        internal bool IsSetInputContexts() => this.InputContexts != null && (this.InputContexts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IntentDisplayName. 
        /// <para>
        /// The display name of the intent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string IntentDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the IntentDisplayName property is set.
        /// </summary>
        internal bool IsSetIntentDisplayName() => this.IntentDisplayName != null;

        /// <summary>
        /// Gets and sets the property IntentId. 
        /// <para>
        /// The unique identifier assigned to the intent. Use this ID to get detailed information
        /// about the intent with the <c>DescribeIntent</c> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string IntentId { get; set; }

        /// <summary>
        /// Checks to see if the IntentId property is set.
        /// </summary>
        internal bool IsSetIntentId() => this.IntentId != null;

        /// <summary>
        /// Gets and sets the property IntentName. 
        /// <para>
        /// The name of the intent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string IntentName { get; set; }

        /// <summary>
        /// Checks to see if the IntentName property is set.
        /// </summary>
        internal bool IsSetIntentName() => this.IntentName != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The timestamp of the date and time that the intent was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property OutputContexts. 
        /// <para>
        /// The output contexts that are activated when this intent is fulfilled.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<OutputContext> OutputContexts { get; set; } = AWSConfigs.InitializeCollections ? new List<OutputContext>() : null;

        /// <summary>
        /// Checks to see if the OutputContexts property is set.
        /// </summary>
        internal bool IsSetOutputContexts() => this.OutputContexts != null && (this.OutputContexts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ParentIntentSignature. 
        /// <para>
        /// If this intent is derived from a built-in intent, the name of the parent intent.
        /// </para>
        /// </summary>
        public string ParentIntentSignature { get; set; }

        /// <summary>
        /// Checks to see if the ParentIntentSignature property is set.
        /// </summary>
        internal bool IsSetParentIntentSignature() => this.ParentIntentSignature != null;
    }
}
