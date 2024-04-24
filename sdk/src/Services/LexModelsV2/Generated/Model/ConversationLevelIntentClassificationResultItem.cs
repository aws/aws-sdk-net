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
    /// The item listing the evaluation of intent level success or failure.
    /// </summary>
    public partial class ConversationLevelIntentClassificationResultItem
    {
        private string _intentName;
        private TestResultMatchStatus _matchResult;

        /// <summary>
        /// Gets and sets the property IntentName. 
        /// <para>
        /// The intent name used in the evaluation of intent level success or failure.
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
        /// Gets and sets the property MatchResult. 
        /// <para>
        /// The number of times the specific intent is used in the evaluation of intent level
        /// success or failure.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TestResultMatchStatus MatchResult
        {
            get { return this._matchResult; }
            set { this._matchResult = value; }
        }

        // Check to see if MatchResult property is set
        internal bool IsSetMatchResult()
        {
            return this._matchResult != null;
        }

    }
}