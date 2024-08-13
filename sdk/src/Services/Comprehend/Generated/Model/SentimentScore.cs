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
    /// Describes the level of confidence that Amazon Comprehend has in the accuracy of its
    /// detection of sentiments.
    /// </summary>
    public partial class SentimentScore
    {
        private float? _mixed;
        private float? _negative;
        private float? _neutral;
        private float? _positive;

        /// <summary>
        /// Gets and sets the property Mixed. 
        /// <para>
        /// The level of confidence that Amazon Comprehend has in the accuracy of its detection
        /// of the <c>MIXED</c> sentiment.
        /// </para>
        /// </summary>
        public float? Mixed
        {
            get { return this._mixed; }
            set { this._mixed = value; }
        }

        // Check to see if Mixed property is set
        internal bool IsSetMixed()
        {
            return this._mixed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Negative. 
        /// <para>
        /// The level of confidence that Amazon Comprehend has in the accuracy of its detection
        /// of the <c>NEGATIVE</c> sentiment.
        /// </para>
        /// </summary>
        public float? Negative
        {
            get { return this._negative; }
            set { this._negative = value; }
        }

        // Check to see if Negative property is set
        internal bool IsSetNegative()
        {
            return this._negative.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Neutral. 
        /// <para>
        /// The level of confidence that Amazon Comprehend has in the accuracy of its detection
        /// of the <c>NEUTRAL</c> sentiment.
        /// </para>
        /// </summary>
        public float? Neutral
        {
            get { return this._neutral; }
            set { this._neutral = value; }
        }

        // Check to see if Neutral property is set
        internal bool IsSetNeutral()
        {
            return this._neutral.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Positive. 
        /// <para>
        /// The level of confidence that Amazon Comprehend has in the accuracy of its detection
        /// of the <c>POSITIVE</c> sentiment.
        /// </para>
        /// </summary>
        public float? Positive
        {
            get { return this._positive; }
            set { this._positive = value; }
        }

        // Check to see if Positive property is set
        internal bool IsSetPositive()
        {
            return this._positive.HasValue; 
        }

    }
}