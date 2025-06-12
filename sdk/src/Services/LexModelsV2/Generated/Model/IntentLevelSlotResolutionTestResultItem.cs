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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
    /// Information about intent-level slot resolution in a test result.
    /// </summary>
    public partial class IntentLevelSlotResolutionTestResultItem
    {
        private string _intentName;
        private bool? _multiTurnConversation;
        private List<SlotResolutionTestResultItem> _slotResolutionResults = AWSConfigs.InitializeCollections ? new List<SlotResolutionTestResultItem>() : null;

        /// <summary>
        /// Gets and sets the property IntentName. 
        /// <para>
        /// The name of the intent that was recognized.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string IntentName
        {
            get { return this._intentName; }
            set { this._intentName = value; }
        }

        // Check to see if IntentName property is set
        internal bool IsSetIntentName()
        {
            return this._intentName != null;
        }

        /// <summary>
        /// Gets and sets the property MultiTurnConversation. 
        /// <para>
        /// Indicates whether the conversation involves multiple turns or not.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? MultiTurnConversation
        {
            get { return this._multiTurnConversation; }
            set { this._multiTurnConversation = value; }
        }

        // Check to see if MultiTurnConversation property is set
        internal bool IsSetMultiTurnConversation()
        {
            return this._multiTurnConversation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SlotResolutionResults. 
        /// <para>
        /// The results for the slot resolution in the test execution result.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<SlotResolutionTestResultItem> SlotResolutionResults
        {
            get { return this._slotResolutionResults; }
            set { this._slotResolutionResults = value; }
        }

        // Check to see if SlotResolutionResults property is set
        internal bool IsSetSlotResolutionResults()
        {
            return this._slotResolutionResults != null && (this._slotResolutionResults.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}