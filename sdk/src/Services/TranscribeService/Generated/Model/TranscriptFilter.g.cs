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
    /// Flag the presence or absence of specific words or phrases detected in your Call Analytics
    /// transcription output.
    /// 
    ///  
    /// <para>
    /// Rules using <c>TranscriptFilter</c> are designed to match:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Custom words or phrases spoken by the agent, the customer, or both
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Custom words or phrases <b>not</b> spoken by the agent, the customer, or either
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Custom words or phrases that occur at a specific time frame
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// See <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tca-categories-batch.html#tca-rules-batch">Rule
    /// criteria for post-call categories</a> and <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tca-categories-stream.html#tca-rules-stream">Rule
    /// criteria for streaming categories</a> for usage examples.
    /// </para>
    /// </summary>
    public partial class TranscriptFilter
    {
        /// <summary>
        /// Gets and sets the property AbsoluteTimeRange. 
        /// <para>
        /// Makes it possible to specify a time range (in milliseconds) in your audio, during
        /// which you want to search for the specified key words or phrases. See for more detail.
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
        /// Set to <c>TRUE</c> to flag the absence of the phrase that you specified in your request.
        /// Set to <c>FALSE</c> to flag the presence of the phrase that you specified in your
        /// request.
        /// </para>
        /// </summary>
        public bool? Negate { get; set; }

        /// <summary>
        /// Checks to see if the Negate property is set.
        /// </summary>
        internal bool IsSetNegate() => this.Negate.HasValue;

        /// <summary>
        /// Gets and sets the property ParticipantRole. 
        /// <para>
        /// Specify the participant that you want to flag. Omitting this parameter is equivalent
        /// to specifying both participants.
        /// </para>
        /// </summary>
        public ParticipantRole ParticipantRole { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantRole property is set.
        /// </summary>
        internal bool IsSetParticipantRole() => this.ParticipantRole != null;

        /// <summary>
        /// Gets and sets the property RelativeTimeRange. 
        /// <para>
        /// Makes it possible to specify a time range (in percentage) in your media file, during
        /// which you want to search for the specified key words or phrases. See for more detail.
        /// </para>
        /// </summary>
        public RelativeTimeRange RelativeTimeRange { get; set; }

        /// <summary>
        /// Checks to see if the RelativeTimeRange property is set.
        /// </summary>
        internal bool IsSetRelativeTimeRange() => this.RelativeTimeRange != null;

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// Specify the phrases that you want to flag.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<string> Targets { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Targets property is set.
        /// </summary>
        internal bool IsSetTargets() => this.Targets != null && (this.Targets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TranscriptFilterType. 
        /// <para>
        /// Flag the presence or absence of an exact match to the phrases that you specify. For
        /// example, if you specify the phrase "speak to a manager" as your <c>Targets</c> value,
        /// only that exact phrase is flagged.
        /// </para>
        ///  
        /// <para>
        /// Note that semantic matching is not supported. For example, if your customer says "speak
        /// to <i>the</i> manager", instead of "speak to <i>a</i> manager", your content is not
        /// flagged.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TranscriptFilterType TranscriptFilterType { get; set; }

        /// <summary>
        /// Checks to see if the TranscriptFilterType property is set.
        /// </summary>
        internal bool IsSetTranscriptFilterType() => this.TranscriptFilterType != null;
    }
}
