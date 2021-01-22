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
 * Do not modify this file. This file is generated from the runtime.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexRuntimeV2.Model
{
    /// <summary>
    /// An intent that Amazon Lex determined might satisfy the user's utterance. The intents
    /// are ordered by the confidence score.
    /// </summary>
    public partial class Interpretation
    {
        private Intent _intent;
        private ConfidenceScore _nluConfidence;
        private SentimentResponse _sentimentResponse;

        /// <summary>
        /// Gets and sets the property Intent. 
        /// <para>
        /// A list of intents that might satisfy the user's utterance. The intents are ordered
        /// by the confidence score.
        /// </para>
        /// </summary>
        public Intent Intent
        {
            get { return this._intent; }
            set { this._intent = value; }
        }

        // Check to see if Intent property is set
        internal bool IsSetIntent()
        {
            return this._intent != null;
        }

        /// <summary>
        /// Gets and sets the property NluConfidence. 
        /// <para>
        /// Determines the threshold where Amazon Lex will insert the <code>AMAZON.FallbackIntent</code>,
        /// <code>AMAZON.KendraSearchIntent</code>, or both when returning alternative intents
        /// in a response. <code>AMAZON.FallbackIntent</code> and <code>AMAZON.KendraSearchIntent</code>
        /// are only inserted if they are configured for the bot.
        /// </para>
        /// </summary>
        public ConfidenceScore NluConfidence
        {
            get { return this._nluConfidence; }
            set { this._nluConfidence = value; }
        }

        // Check to see if NluConfidence property is set
        internal bool IsSetNluConfidence()
        {
            return this._nluConfidence != null;
        }

        /// <summary>
        /// Gets and sets the property SentimentResponse. 
        /// <para>
        /// The sentiment expressed in an utterance. 
        /// </para>
        ///  
        /// <para>
        /// When the bot is configured to send utterances to Amazon Comprehend for sentiment analysis,
        /// this field contains the result of the analysis.
        /// </para>
        /// </summary>
        public SentimentResponse SentimentResponse
        {
            get { return this._sentimentResponse; }
            set { this._sentimentResponse = value; }
        }

        // Check to see if SentimentResponse property is set
        internal bool IsSetSentimentResponse()
        {
            return this._sentimentResponse != null;
        }

    }
}