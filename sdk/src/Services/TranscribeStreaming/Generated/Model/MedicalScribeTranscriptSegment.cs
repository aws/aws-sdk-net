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
 * Do not modify this file. This file is generated from the transcribe-streaming-2017-10-26.normal.json service model.
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
        private double? _beginAudioTime;
        private string _channelId;
        private string _content;
        private double? _endAudioTime;
        private bool? _isPartial;
        private List<MedicalScribeTranscriptItem> _items = AWSConfigs.InitializeCollections ? new List<MedicalScribeTranscriptItem>() : null;
        private string _segmentId;

        /// <summary>
        /// Gets and sets the property BeginAudioTime. 
        /// <para>
        /// The start time, in milliseconds, of the segment.
        /// </para>
        /// </summary>
        public double? BeginAudioTime
        {
            get { return this._beginAudioTime; }
            set { this._beginAudioTime = value; }
        }

        // Check to see if BeginAudioTime property is set
        internal bool IsSetBeginAudioTime()
        {
            return this._beginAudioTime.HasValue; 
        }

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
        public string ChannelId
        {
            get { return this._channelId; }
            set { this._channelId = value; }
        }

        // Check to see if ChannelId property is set
        internal bool IsSetChannelId()
        {
            return this._channelId != null;
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// Contains transcribed text of the segment.
        /// </para>
        /// </summary>
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property EndAudioTime. 
        /// <para>
        /// The end time, in milliseconds, of the segment.
        /// </para>
        /// </summary>
        public double? EndAudioTime
        {
            get { return this._endAudioTime; }
            set { this._endAudioTime = value; }
        }

        // Check to see if EndAudioTime property is set
        internal bool IsSetEndAudioTime()
        {
            return this._endAudioTime.HasValue; 
        }

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
        public bool? IsPartial
        {
            get { return this._isPartial; }
            set { this._isPartial = value; }
        }

        // Check to see if IsPartial property is set
        internal bool IsSetIsPartial()
        {
            return this._isPartial.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// Contains words, phrases, or punctuation marks in your segment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MedicalScribeTranscriptItem> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this._items != null && (this._items.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SegmentId. 
        /// <para>
        /// The identifier of the segment.
        /// </para>
        /// </summary>
        public string SegmentId
        {
            get { return this._segmentId; }
            set { this._segmentId = value; }
        }

        // Check to see if SegmentId property is set
        internal bool IsSetSegmentId()
        {
            return this._segmentId != null;
        }

    }
}