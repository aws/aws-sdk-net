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

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Flag the presence or absence of periods of silence in your Call Analytics transcription
    /// output.
    /// 
    ///  
    /// <para>
    /// Rules using <c>NonTalkTimeFilter</c> are designed to match:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The presence of silence at specified periods throughout the call
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The presence of speech at specified periods throughout the call
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// See <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tca-categories-batch.html#tca-rules-batch">Rule
    /// criteria for post-call categories</a> for usage examples.
    /// </para>
    /// </summary>
    public partial class NonTalkTimeFilter
    {
        /// <summary>
        /// Gets and sets the property AbsoluteTimeRange. 
        /// <para>
        /// Makes it possible to specify a time range (in milliseconds) in your audio, during
        /// which you want to search for a period of silence. See for more detail.
        /// </para>
        /// </summary>
        public AbsoluteTimeRange AbsoluteTimeRange { get; set; }

        /// <summary>
        /// Checks to see if the AbsoluteTimeRange property is set.
        /// </summary>
        internal bool IsSetAbsoluteTimeRange() => this.AbsoluteTimeRange != null;

        /// <summary>
        /// Gets and sets the property Negate. 
        /// <para>
        /// Set to <c>TRUE</c> to flag periods of speech. Set to <c>FALSE</c> to flag periods
        /// of silence
        /// </para>
        /// </summary>
        public bool? Negate { get; set; }

        /// <summary>
        /// Checks to see if the Negate property is set.
        /// </summary>
        internal bool IsSetNegate() => this.Negate.HasValue;

        /// <summary>
        /// Gets and sets the property RelativeTimeRange. 
        /// <para>
        /// Makes it possible to specify a time range (in percentage) in your media file, during
        /// which you want to search for a period of silence. See for more detail.
        /// </para>
        /// </summary>
        public RelativeTimeRange RelativeTimeRange { get; set; }

        /// <summary>
        /// Checks to see if the RelativeTimeRange property is set.
        /// </summary>
        internal bool IsSetRelativeTimeRange() => this.RelativeTimeRange != null;

        /// <summary>
        /// Gets and sets the property Threshold. 
        /// <para>
        /// Specify the duration, in milliseconds, of the period of silence that you want to flag.
        /// For example, you can flag a silent period that lasts 30,000 milliseconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 14400000)]
        public long? Threshold { get; set; }

        /// <summary>
        /// Checks to see if the Threshold property is set.
        /// </summary>
        internal bool IsSetThreshold() => this.Threshold.HasValue;
    }
}
