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

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// The result of calling the operation. The operation returns one object for each document
    /// that is successfully processed by the operation.
    /// </summary>
    public partial class BatchDetectSentimentItemResult
    {
        /// <summary>
        /// Gets and sets the property Index. 
        /// <para>
        /// The zero-based index of the document in the input list.
        /// </para>
        /// </summary>
        public int? Index { get; set; }

        /// <summary>
        /// Checks to see if the Index property is set.
        /// </summary>
        internal bool IsSetIndex() => this.Index.HasValue;

        /// <summary>
        /// Gets and sets the property Sentiment. 
        /// <para>
        /// The sentiment detected in the document.
        /// </para>
        /// </summary>
        public SentimentType Sentiment { get; set; }

        /// <summary>
        /// Checks to see if the Sentiment property is set.
        /// </summary>
        internal bool IsSetSentiment() => this.Sentiment != null;

        /// <summary>
        /// Gets and sets the property SentimentScore. 
        /// <para>
        /// The level of confidence that Amazon Comprehend has in the accuracy of its sentiment
        /// detection.
        /// </para>
        /// </summary>
        public SentimentScore SentimentScore { get; set; }

        /// <summary>
        /// Checks to see if the SentimentScore property is set.
        /// </summary>
        internal bool IsSetSentimentScore() => this.SentimentScore != null;
    }
}
