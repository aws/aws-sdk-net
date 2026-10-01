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
    /// Contains a set of transcription results, along with additional information of the
    /// segment.
    /// </summary>
    public partial class MedicalScribeTranscriptSegment
    {
        /// <summary>
        /// Gets and sets the property BeginAudioTime. 
        /// <para>
        /// The start time, in milliseconds, of the segment.
        /// </para>
        /// </summary>
        public double? BeginAudioTime { get; set; }

        /// <summary>
        /// Checks to see if the BeginAudioTime property is set.
        /// </summary>
        internal bool IsSetBeginAudioTime() => this.BeginAudioTime.HasValue;

        /// <summary>
        /// Gets and sets the property ChannelId. 
        /// <para>
        /// Indicates which audio channel is associated with the <c>MedicalScribeTranscriptSegment</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If <c>MedicalScribeChannelDefinition</c> is not provided in the <c>MedicalScribeConfigurationEvent</c>,
        /// then this field will not be included. 
        /// </para>
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// Checks to see if the ChannelId property is set.
        /// </summary>
        internal bool IsSetChannelId() => this.ChannelId != null;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// Contains transcribed text of the segment.
        /// </para>
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property EndAudioTime. 
        /// <para>
        /// The end time, in milliseconds, of the segment.
        /// </para>
        /// </summary>
        public double? EndAudioTime { get; set; }

        /// <summary>
        /// Checks to see if the EndAudioTime property is set.
        /// </summary>
        internal bool IsSetEndAudioTime() => this.EndAudioTime.HasValue;

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
        /// Gets and sets the property Items. 
        /// <para>
        /// Contains words, phrases, or punctuation marks in your segment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MedicalScribeTranscriptItem> Items { get; set; } = AWSConfigs.InitializeCollections ? new List<MedicalScribeTranscriptItem>() : null;

        /// <summary>
        /// Checks to see if the Items property is set.
        /// </summary>
        internal bool IsSetItems() => this.Items != null && (this.Items.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SegmentId. 
        /// <para>
        /// The identifier of the segment.
        /// </para>
        /// </summary>
        public string SegmentId { get; set; }

        /// <summary>
        /// Checks to see if the SegmentId property is set.
        /// </summary>
        internal bool IsSetSegmentId() => this.SegmentId != null;
    }
}
