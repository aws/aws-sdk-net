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
    /// The <c>Result</c> associated with a <code/>.
    /// 
    ///  
    /// <para>
    /// Contains a set of transcription results from one or more audio segments, along with
    /// additional information per your request parameters. This can include information relating
    /// to alternative transcriptions, channel identification, partial result stabilization,
    /// language identification, and other transcription-related data.
    /// </para>
    /// </summary>
    public partial class MedicalResult
    {
        private List<MedicalAlternative> _alternatives = AWSConfigs.InitializeCollections ? new List<MedicalAlternative>() : null;
        private string _channelId;
        private double? _endTime;
        private bool? _isPartial;
        private string _resultId;
        private double? _startTime;

        /// <summary>
        /// Gets and sets the property Alternatives. 
        /// <para>
        /// A list of possible alternative transcriptions for the input audio. Each alternative
        /// may contain one or more of <c>Items</c>, <c>Entities</c>, or <c>Transcript</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MedicalAlternative> Alternatives
        {
            get { return this._alternatives; }
            set { this._alternatives = value; }
        }

        // Check to see if Alternatives property is set
        internal bool IsSetAlternatives()
        {
            return this._alternatives != null && (this._alternatives.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ChannelId. 
        /// <para>
        /// Indicates the channel identified for the <c>Result</c>.
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
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time, in seconds, of the <c>Result</c>.
        /// </para>
        /// </summary>
        public double? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
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
        /// Gets and sets the property ResultId. 
        /// <para>
        /// Provides a unique identifier for the <c>Result</c>.
        /// </para>
        /// </summary>
        public string ResultId
        {
            get { return this._resultId; }
            set { this._resultId = value; }
        }

        // Check to see if ResultId property is set
        internal bool IsSetResultId()
        {
            return this._resultId != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time, in seconds, of the <c>Result</c>.
        /// </para>
        /// </summary>
        public double? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}