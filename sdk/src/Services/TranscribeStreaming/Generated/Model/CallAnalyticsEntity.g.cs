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

namespace Amazon.TranscribeStreaming.Model
{
    /// <summary>
    /// Contains entities identified as personally identifiable information (PII) in your
    /// transcription output, along with various associated attributes. Examples include category,
    /// confidence score, content, type, and start and end times.
    /// </summary>
    public partial class CallAnalyticsEntity
    {
        /// <summary>
        /// Gets and sets the property BeginOffsetMillis. 
        /// <para>
        /// The time, in milliseconds, from the beginning of the audio stream to the start of
        /// the identified entity.
        /// </para>
        /// </summary>
        public long? BeginOffsetMillis { get; set; }

        /// <summary>
        /// Checks to see if the BeginOffsetMillis property is set.
        /// </summary>
        internal bool IsSetBeginOffsetMillis() => this.BeginOffsetMillis.HasValue;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of information identified. For example, <c>PII</c>.
        /// </para>
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// The confidence score associated with the identification of an entity in your transcript.
        /// </para>
        ///  
        /// <para>
        /// Confidence scores are values between 0 and 1. A larger value indicates a higher probability
        /// that the identified entity correctly matches the entity spoken in your media.
        /// </para>
        /// </summary>
        public double? Confidence { get; set; }

        /// <summary>
        /// Checks to see if the Confidence property is set.
        /// </summary>
        internal bool IsSetConfidence() => this.Confidence.HasValue;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The word or words that represent the identified entity.
        /// </para>
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property EndOffsetMillis. 
        /// <para>
        /// The time, in milliseconds, from the beginning of the audio stream to the end of the
        /// identified entity.
        /// </para>
        /// </summary>
        public long? EndOffsetMillis { get; set; }

        /// <summary>
        /// Checks to see if the EndOffsetMillis property is set.
        /// </summary>
        internal bool IsSetEndOffsetMillis() => this.EndOffsetMillis.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of PII identified. For example, <c>NAME</c> or <c>CREDIT_DEBIT_NUMBER</c>.
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
