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
    /// Contains details about the errors in the test set discrepancy report
    /// </summary>
    public partial class TestSetDiscrepancyErrors
    {
        /// <summary>
        /// Gets and sets the property IntentDiscrepancies. 
        /// <para>
        /// Contains information about discrepancies found for intents between the test set and
        /// the bot.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<TestSetIntentDiscrepancyItem> IntentDiscrepancies { get; set; } = AWSConfigs.InitializeCollections ? new List<TestSetIntentDiscrepancyItem>() : null;

        /// <summary>
        /// Checks to see if the IntentDiscrepancies property is set.
        /// </summary>
        internal bool IsSetIntentDiscrepancies() => this.IntentDiscrepancies != null && (this.IntentDiscrepancies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SlotDiscrepancies. 
        /// <para>
        /// Contains information about discrepancies found for slots between the test set and
        /// the bot.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<TestSetSlotDiscrepancyItem> SlotDiscrepancies { get; set; } = AWSConfigs.InitializeCollections ? new List<TestSetSlotDiscrepancyItem>() : null;

        /// <summary>
        /// Checks to see if the SlotDiscrepancies property is set.
        /// </summary>
        internal bool IsSetSlotDiscrepancies() => this.SlotDiscrepancies != null && (this.SlotDiscrepancies.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
