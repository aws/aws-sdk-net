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
    /// Information for an intent that is classified by the test workbench.
    /// </summary>
    public partial class IntentClassificationTestResultItem
    {
        private string _intentName;
        private bool? _multiTurnConversation;
        private IntentClassificationTestResultItemCounts _resultCounts;

        /// <summary>
        /// Gets and sets the property IntentName. 
        /// <para>
        /// The name of the intent.
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
        /// Gets and sets the property ResultCounts. 
        /// <para>
        /// The result of the intent classification test.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IntentClassificationTestResultItemCounts ResultCounts
        {
            get { return this._resultCounts; }
            set { this._resultCounts = value; }
        }

        // Check to see if ResultCounts property is set
        internal bool IsSetResultCounts()
        {
            return this._resultCounts != null;
        }

    }
}