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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
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
namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Contains the sentiment and sentiment score for one mention of an entity.
    /// 
    ///  
    /// <para>
    /// For more information about targeted sentiment, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-targeted-sentiment.html">Targeted
    /// sentiment</a> in the <i>Amazon Comprehend Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class MentionSentiment
    {
        private SentimentType _sentiment;
        private SentimentScore _sentimentScore;

        /// <summary>
        /// Gets and sets the property Sentiment. 
        /// <para>
        /// The sentiment of the mention. 
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