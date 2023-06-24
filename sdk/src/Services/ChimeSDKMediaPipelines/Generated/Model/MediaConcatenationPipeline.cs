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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// Concatenates audio and video data from one or more data streams.
    /// </summary>
    public partial class MediaConcatenationPipeline
    {
        private DateTime? _createdTimestamp;
        private string _mediaPipelineArn;
        private string _mediaPipelineId;
        private List<ConcatenationSink> _sinks = new List<ConcatenationSink>();
        private List<ConcatenationSource> _sources = new List<ConcatenationSource>();
        private MediaPipelineStatus _status;
        private DateTime? _updatedTimestamp;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time at which the concatenation pipeline was created.
        /// </para>
        /// </summary>
        public DateTime CreatedTimestamp
        {
            get { return this._createdTimestamp.GetValueOrDefault(); }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MediaPipelineArn. 
        /// <para>
        /// The ARN of the media pipeline that you specify in the <code>SourceConfiguration</code>
        /// object.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string MediaPipelineArn
        {
            get { return this._mediaPipelineArn; }
            set { this._mediaPipelineArn = value; }
        }

        // Check to see if MediaPipelineArn property is set
        internal bool IsSetMediaPipelineArn()
        {
            return this._mediaPipelineArn != null;
        }

        /// <summary>
        /// Gets and sets the property MediaPipelineId. 
        /// <para>
        /// The ID of the media pipeline being concatenated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string MediaPipelineId
        {
            get { return this._mediaPipelineId; }
            set { this._mediaPipelineId = value; }
        }

        // Check to see if MediaPipelineId property is set
        internal bool IsSetMediaPipelineId()
        {
            return this._mediaPipelineId != null;
        }

        /// <summary>
        /// Gets and sets the property Sinks. 
        /// <para>
        /// The data sinks of the concatenation pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<ConcatenationSink> Sinks
        {
            get { return this._sinks; }
            set { this._sinks = value; }
        }

        // Check to see if Sinks property is set
        internal bool IsSetSinks()
        {
            return this._sinks != null && this._sinks.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// The data sources being concatenated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<ConcatenationSource> Sources
        {
            get { return this._sources; }
            set { this._sources = value; }
        }

        // Check to see if Sources property is set
        internal bool IsSetSources()
        {
            return this._sources != null && this._sources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the concatenation pipeline.
        /// </para>
        /// </summary>
        public MediaPipelineStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp. 
        /// <para>
        /// The time at which the concatenation pipeline was last updated.
        /// </para>
        /// </summary>
        public DateTime UpdatedTimestamp
        {
            get { return this._updatedTimestamp.GetValueOrDefault(); }
            set { this._updatedTimestamp = value; }
        }

        // Check to see if UpdatedTimestamp property is set
        internal bool IsSetUpdatedTimestamp()
        {
            return this._updatedTimestamp.HasValue; 
        }

    }
}