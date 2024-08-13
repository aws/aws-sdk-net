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
    /// An object that contains a summary of a recommended intent.
    /// </summary>
    public partial class RecommendedIntentSummary
    {
        private string _intentId;
        private string _intentName;
        private int? _sampleUtterancesCount;

        /// <summary>
        /// Gets and sets the property IntentId. 
        /// <para>
        /// The unique identifier of a recommended intent associated with the bot recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string IntentId
        {
            get { return this._intentId; }
            set { this._intentId = value; }
        }

        // Check to see if IntentId property is set
        internal bool IsSetIntentId()
        {
            return this._intentId != null;
        }

        /// <summary>
        /// Gets and sets the property IntentName. 
        /// <para>
        /// The name of a recommended intent associated with the bot recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property SampleUtterancesCount. 
        /// <para>
        /// The count of sample utterances of a recommended intent that is associated with a bot
        /// recommendation.
        /// </para>
        /// </summary>
        public int? SampleUtterancesCount
        {
            get { return this._sampleUtterancesCount; }
            set { this._sampleUtterancesCount = value; }
        }

        // Check to see if SampleUtterancesCount property is set
        internal bool IsSetSampleUtterancesCount()
        {
            return this._sampleUtterancesCount.HasValue; 
        }

    }
}