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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Statmux rate control settings
    /// </summary>
    public partial class MultiplexStatmuxVideoSettings
    {
        private int? _maximumBitrate;
        private int? _minimumBitrate;
        private int? _priority;

        /// <summary>
        /// Gets and sets the property MaximumBitrate. Maximum statmux bitrate.
        /// </summary>
        [AWSProperty(Min=100000, Max=100000000)]
        public int? MaximumBitrate
        {
            get { return this._maximumBitrate; }
            set { this._maximumBitrate = value; }
        }

        // Check to see if MaximumBitrate property is set
        internal bool IsSetMaximumBitrate()
        {
            return this._maximumBitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinimumBitrate. Minimum statmux bitrate.
        /// </summary>
        [AWSProperty(Min=100000, Max=100000000)]
        public int? MinimumBitrate
        {
            get { return this._minimumBitrate; }
            set { this._minimumBitrate = value; }
        }

        // Check to see if MinimumBitrate property is set
        internal bool IsSetMinimumBitrate()
        {
            return this._minimumBitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Priority. The purpose of the priority is to use a combination
        /// of the\nmultiplex rate control algorithm and the QVBR capability of the\nencoder to
        /// prioritize the video quality of some channels in a\nmultiplex over others. Channels
        /// that have a higher priority will\nget higher video quality at the expense of the video
        /// quality of\nother channels in the multiplex with lower priority.
        /// </summary>
        [AWSProperty(Min=-5, Max=5)]
        public int? Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

    }
}