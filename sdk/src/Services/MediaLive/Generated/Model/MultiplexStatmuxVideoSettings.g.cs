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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Statmux rate control settings
    /// </summary>
    public partial class MultiplexStatmuxVideoSettings
    {
        /// <summary>
        /// Gets and sets the property MaximumBitrate. Maximum statmux bitrate.
        /// </summary>
        public int? MaximumBitrate { get; set; }

        /// <summary>
        /// Checks to see if the MaximumBitrate property is set.
        /// </summary>
        internal bool IsSetMaximumBitrate() => this.MaximumBitrate.HasValue;

        /// <summary>
        /// Gets and sets the property MinimumBitrate. Minimum statmux bitrate.
        /// </summary>
        public int? MinimumBitrate { get; set; }

        /// <summary>
        /// Checks to see if the MinimumBitrate property is set.
        /// </summary>
        internal bool IsSetMinimumBitrate() => this.MinimumBitrate.HasValue;

        /// <summary>
        /// Gets and sets the property Priority. The purpose of the priority is to use a combination
        /// of the\nmultiplex rate control algorithm and the QVBR capability of the\nencoder to
        /// prioritize the video quality of some channels in a\nmultiplex over others. Channels
        /// that have a higher priority will\nget higher video quality at the expense of the video
        /// quality of\nother channels in the multiplex with lower priority.
        /// </summary>
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;
    }
}
