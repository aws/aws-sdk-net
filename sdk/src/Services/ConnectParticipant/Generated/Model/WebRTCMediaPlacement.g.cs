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

namespace Amazon.ConnectParticipant.Model
{
    /// <summary>
    /// A set of endpoints used by clients to connect to the media service group for an Amazon
    /// Chime SDK meeting.
    /// </summary>
    public partial class WebRTCMediaPlacement
    {
        /// <summary>
        /// Gets and sets the property AudioFallbackUrl. 
        /// <para>
        /// The audio fallback URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string AudioFallbackUrl { get; set; }

        /// <summary>
        /// Checks to see if the AudioFallbackUrl property is set.
        /// </summary>
        internal bool IsSetAudioFallbackUrl() => this.AudioFallbackUrl != null;

        /// <summary>
        /// Gets and sets the property AudioHostUrl. 
        /// <para>
        /// The audio host URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string AudioHostUrl { get; set; }

        /// <summary>
        /// Checks to see if the AudioHostUrl property is set.
        /// </summary>
        internal bool IsSetAudioHostUrl() => this.AudioHostUrl != null;

        /// <summary>
        /// Gets and sets the property EventIngestionUrl. 
        /// <para>
        /// The event ingestion URL to which you send client meeting events.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string EventIngestionUrl { get; set; }

        /// <summary>
        /// Checks to see if the EventIngestionUrl property is set.
        /// </summary>
        internal bool IsSetEventIngestionUrl() => this.EventIngestionUrl != null;

        /// <summary>
        /// Gets and sets the property SignalingUrl. 
        /// <para>
        /// The signaling URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string SignalingUrl { get; set; }

        /// <summary>
        /// Checks to see if the SignalingUrl property is set.
        /// </summary>
        internal bool IsSetSignalingUrl() => this.SignalingUrl != null;
    }
}
