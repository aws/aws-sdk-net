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
        /// <summary>
        /// Gets and sets the property SentimentLabel. 
        /// <para>
        /// The inferred sentiment that Amazon Comprehend has the highest confidence in.
        /// </para>
        /// </summary>
        public string SentimentLabel { get; set; }

        /// <summary>
        /// Checks to see if the SentimentLabel property is set.
        /// </summary>
        internal bool IsSetSentimentLabel() => this.SentimentLabel != null;

        /// <summary>
        /// Gets and sets the property SentimentScore. 
        /// <para>
        /// The likelihood that the sentiment was correctly inferred.
        /// </para>
        /// </summary>
        public string SentimentScore { get; set; }

        /// <summary>
        /// Checks to see if the SentimentScore property is set.
        /// </summary>
        internal bool IsSetSentimentScore() => this.SentimentScore != null;
    }
}
