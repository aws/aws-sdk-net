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
 * Do not modify this file. This file is generated from the runtime.lex-2016-11-28.normal.json service model.
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
    /// The sentiment expressed in an utterance.
    /// 
    ///  
    /// <para>
    /// When the bot is configured to send utterances to Amazon Comprehend for sentiment analysis,
    /// this field structure contains the result of the analysis.
    /// </para>
    /// </summary>
    public partial class SentimentResponse
    {
        private string _sentimentLabel;
        private string _sentimentScore;

        /// <summary>
        /// Gets and sets the property SentimentLabel. 
        /// <para>
        /// The inferred sentiment that Amazon Comprehend has the highest confidence in.
        /// </para>
        /// </summary>
        public string SentimentLabel
        {
            get { return this._sentimentLabel; }
            set { this._sentimentLabel = value; }
        }

        // Check to see if SentimentLabel property is set
        internal bool IsSetSentimentLabel()
        {
            return this._sentimentLabel != null;
        }

        /// <summary>
        /// Gets and sets the property SentimentScore. 
        /// <para>
        /// The likelihood that the sentiment was correctly inferred.
        /// </para>
        /// </summary>
        public string SentimentScore
        {
            get { return this._sentimentScore; }
            set { this._sentimentScore = value; }
        }

        // Check to see if SentimentScore property is set
        internal bool IsSetSentimentScore()
        {
            return this._sentimentScore != null;
        }

    }
}