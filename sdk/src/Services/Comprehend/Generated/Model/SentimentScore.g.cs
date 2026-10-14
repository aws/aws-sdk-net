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
    /// Describes the level of confidence that Amazon Comprehend has in the accuracy of its
    /// detection of sentiments.
    /// </summary>
    public partial class SentimentScore
    {
        /// <summary>
        /// Gets and sets the property Mixed. 
        /// <para>
        /// The level of confidence that Amazon Comprehend has in the accuracy of its detection
        /// of the <c>MIXED</c> sentiment.
        /// </para>
        /// </summary>
        public float? Mixed { get; set; }

        /// <summary>
        /// Checks to see if the Mixed property is set.
        /// </summary>
        internal bool IsSetMixed() => this.Mixed.HasValue;

        /// <summary>
        /// Gets and sets the property Negative. 
        /// <para>
        /// The level of confidence that Amazon Comprehend has in the accuracy of its detection
        /// of the <c>NEGATIVE</c> sentiment.
        /// </para>
        /// </summary>
        public float? Negative { get; set; }

        /// <summary>
        /// Checks to see if the Negative property is set.
        /// </summary>
        internal bool IsSetNegative() => this.Negative.HasValue;

        /// <summary>
        /// Gets and sets the property Neutral. 
        /// <para>
        /// The level of confidence that Amazon Comprehend has in the accuracy of its detection
        /// of the <c>NEUTRAL</c> sentiment.
        /// </para>
        /// </summary>
        public float? Neutral { get; set; }

        /// <summary>
        /// Checks to see if the Neutral property is set.
        /// </summary>
        internal bool IsSetNeutral() => this.Neutral.HasValue;

        /// <summary>
        /// Gets and sets the property Positive. 
        /// <para>
        /// The level of confidence that Amazon Comprehend has in the accuracy of its detection
        /// of the <c>POSITIVE</c> sentiment.
        /// </para>
        /// </summary>
        public float? Positive { get; set; }

        /// <summary>
        /// Checks to see if the Positive property is set.
        /// </summary>
        internal bool IsSetPositive() => this.Positive.HasValue;
    }
}
