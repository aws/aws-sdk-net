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
 * Do not modify this file. This file is generated from the ivs-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IVS.Model
{
    /// <summary>
    /// Summary information about a stream.
    /// </summary>
    public partial class StreamSummary
    {
        private string _channelArn;
        private StreamHealth _health;
        private DateTime? _startTime;
        private StreamState _state;
        private long? _viewerCount;

        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// Channel ARN for the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ChannelArn
        {
            get { return this._channelArn; }
            set { this._channelArn = value; }
        }

        // Check to see if ChannelArn property is set
        internal bool IsSetChannelArn()
        {
            return this._channelArn != null;
        }

        /// <summary>
        /// Gets and sets the property Health. 
        /// <para>
        /// The stream’s health.
        /// </para>
        /// </summary>
        public StreamHealth Health
        {
            get { return this._health; }
            set { this._health = value; }
        }

        // Check to see if Health property is set
        internal bool IsSetHealth()
        {
            return this._health != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// ISO-8601 formatted timestamp of the stream’s start.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The stream’s state.
        /// </para>
        /// </summary>
        public StreamState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property ViewerCount. 
        /// <para>
        /// Number of current viewers of the stream.
        /// </para>
        /// </summary>
        public long ViewerCount
        {
            get { return this._viewerCount.GetValueOrDefault(); }
            set { this._viewerCount = value; }
        }

        // Check to see if ViewerCount property is set
        internal bool IsSetViewerCount()
        {
            return this._viewerCount.HasValue; 
        }

    }
}