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
    /// The <c>Result</c> associated with a <c></c>.
    /// 
    ///  
    /// <para>
    /// Contains a set of transcription results from one or more audio segments, along with
    /// additional information per your request parameters. This can include information relating
    /// to alternative transcriptions, channel identification, partial result stabilization,
    /// language identification, and other transcription-related data.
    /// </para>
    /// </summary>
    public partial class Result
    {
        /// <summary>
        /// Gets and sets the property Alternatives. 
        /// <para>
        /// A list of possible alternative transcriptions for the input audio. Each alternative
        /// may contain one or more of <c>Items</c>, <c>Entities</c>, or <c>Transcript</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Alternative> Alternatives { get; set; } = AWSConfigs.InitializeCollections ? new List<Alternative>() : null;

        /// <summary>
        /// Checks to see if the Alternatives property is set.
        /// </summary>
        internal bool IsSetAlternatives() => this.Alternatives != null && (this.Alternatives.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ChannelId. 
        /// <para>
        /// Indicates which audio channel is associated with the <c>Result</c>.
        /// </para>
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// Checks to see if the ChannelId property is set.
        /// </summary>
        internal bool IsSetChannelId() => this.ChannelId != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the <c>Result</c> in seconds, with millisecond precision (e.g., 1.056).
        /// </para>
        /// </summary>
        public double? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property IsPartial. 
        /// <para>
        /// Indicates if the segment is complete.
        /// </para>
        ///  
        /// <para>
        /// If <c>IsPartial</c> is <c>true</c>, the segment is not complete. If <c>IsPartial</c>
        /// is <c>false</c>, the segment is complete.
        /// </para>
        /// </summary>
        public bool? IsPartial { get; set; }

        /// <summary>
        /// Checks to see if the IsPartial property is set.
        /// </summary>
        internal bool IsSetIsPartial() => this.IsPartial.HasValue;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code that represents the language spoken in your audio stream.
        /// </para>
        /// </summary>
        public LanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property LanguageIdentification. 
        /// <para>
        /// The language code of the dominant language identified in your stream.
        /// </para>
        ///  
        /// <para>
        /// If you enabled channel identification and each channel of your audio contains a different
        /// language, you may have more than one result.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LanguageWithScore> LanguageIdentification { get; set; } = AWSConfigs.InitializeCollections ? new List<LanguageWithScore>() : null;

        /// <summary>
        /// Checks to see if the LanguageIdentification property is set.
        /// </summary>
        internal bool IsSetLanguageIdentification() => this.LanguageIdentification != null && (this.LanguageIdentification.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResultId. 
        /// <para>
        /// Provides a unique identifier for the <c>Result</c>.
        /// </para>
        /// </summary>
        public string ResultId { get; set; }

        /// <summary>
        /// Checks to see if the ResultId property is set.
        /// </summary>
        internal bool IsSetResultId() => this.ResultId != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the <c>Result</c> in seconds, with millisecond precision (e.g.,
        /// 1.056).
        /// </para>
        /// </summary>
        public double? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
