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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LexRuntimeV2.Model
{
    /// <summary>
    /// Provides information about the sentiment expressed in a user's response in a conversation.
    /// Sentiments are determined using Amazon Comprehend. Sentiments are only returned if
    /// they are enabled for the bot.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-sentiment.html">
    /// Determine Sentiment </a> in the <i>Amazon Comprehend developer guide</i>.
    /// </para>
    /// </summary>
    public partial class SentimentResponse
    {
        private SentimentType _sentiment;
        private SentimentScore _sentimentScore;

        /// <summary>
        /// Gets and sets the property Sentiment. 
        /// <para>
        /// The overall sentiment expressed in the user's response. This is the sentiment most
        /// likely expressed by the user based on the analysis by Amazon Comprehend.
        /// </para>
        /// </summary>
        public SentimentType Sentiment
        {
            get { return this._sentiment; }
            set { this._sentiment = value; }
        }

        // Check to see if Sentiment property is set
        internal bool IsSetSentiment()
        {
            return this._sentiment != null;
        }

        /// <summary>
        /// Gets and sets the property SentimentScore.
        /// </summary>
        public SentimentScore SentimentScore
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