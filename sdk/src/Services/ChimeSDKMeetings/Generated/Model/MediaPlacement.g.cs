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

namespace Amazon.ChimeSDKMeetings.Model
{
    /// <summary>
    /// A set of endpoints used by clients to connect to the media service group for an Amazon
    /// Chime SDK meeting.
    /// </summary>
    public partial class MediaPlacement
    {
        /// <summary>
        /// Gets and sets the property AudioFallbackUrl. 
        /// <para>
        /// The audio fallback URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
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
        [AWSProperty(Min = 0, Max = 4096)]
        public string AudioHostUrl { get; set; }

        /// <summary>
        /// Checks to see if the AudioHostUrl property is set.
        /// </summary>
        internal bool IsSetAudioHostUrl() => this.AudioHostUrl != null;

        /// <summary>
        /// Gets and sets the property EventIngestionUrl. 
        /// <para>
        /// The event ingestion URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string EventIngestionUrl { get; set; }

        /// <summary>
        /// Checks to see if the EventIngestionUrl property is set.
        /// </summary>
        internal bool IsSetEventIngestionUrl() => this.EventIngestionUrl != null;

        /// <summary>
        /// Gets and sets the property ScreenDataUrl. 
        /// <para>
        /// The screen data URL.
        /// </para>
        ///  <important> 
        /// <para>
        ///  <b>This parameter is deprecated and no longer used by the Amazon Chime SDK.</b> 
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string ScreenDataUrl { get; set; }

        /// <summary>
        /// Checks to see if the ScreenDataUrl property is set.
        /// </summary>
        internal bool IsSetScreenDataUrl() => this.ScreenDataUrl != null;

        /// <summary>
        /// Gets and sets the property ScreenSharingUrl. 
        /// <para>
        /// The screen sharing URL.
        /// </para>
        ///  <important> 
        /// <para>
        ///  <b>This parameter is deprecated and no longer used by the Amazon Chime SDK.</b> 
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string ScreenSharingUrl { get; set; }

        /// <summary>
        /// Checks to see if the ScreenSharingUrl property is set.
        /// </summary>
        internal bool IsSetScreenSharingUrl() => this.ScreenSharingUrl != null;

        /// <summary>
        /// Gets and sets the property ScreenViewingUrl. 
        /// <para>
        /// The screen viewing URL.
        /// </para>
        ///  <important> 
        /// <para>
        ///  <b>This parameter is deprecated and no longer used by the Amazon Chime SDK.</b> 
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string ScreenViewingUrl { get; set; }

        /// <summary>
        /// Checks to see if the ScreenViewingUrl property is set.
        /// </summary>
        internal bool IsSetScreenViewingUrl() => this.ScreenViewingUrl != null;

        /// <summary>
        /// Gets and sets the property SignalingUrl. 
        /// <para>
        /// The signaling URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string SignalingUrl { get; set; }

        /// <summary>
        /// Checks to see if the SignalingUrl property is set.
        /// </summary>
        internal bool IsSetSignalingUrl() => this.SignalingUrl != null;

        /// <summary>
        /// Gets and sets the property TurnControlUrl. 
        /// <para>
        /// The turn control URL.
        /// </para>
        ///  <important> 
        /// <para>
        ///  <b>This parameter is deprecated and no longer used by the Amazon Chime SDK.</b> 
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string TurnControlUrl { get; set; }

        /// <summary>
        /// Checks to see if the TurnControlUrl property is set.
        /// </summary>
        internal bool IsSetTurnControlUrl() => this.TurnControlUrl != null;
    }
}
