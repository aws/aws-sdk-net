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
 * Do not modify this file. This file is generated from the chime-sdk-meetings-2021-07-15.normal.json service model.
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
        private string _audioFallbackUrl;
        private string _audioHostUrl;
        private string _eventIngestionUrl;
        private string _screenDataUrl;
        private string _screenSharingUrl;
        private string _screenViewingUrl;
        private string _signalingUrl;
        private string _turnControlUrl;

        /// <summary>
        /// Gets and sets the property AudioFallbackUrl. 
        /// <para>
        /// The audio fallback URL.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string AudioFallbackUrl
        {
            get { return this._audioFallbackUrl; }
            set { this._audioFallbackUrl = value; }
        }

        // Check to see if AudioFallbackUrl property is set
        internal bool IsSetAudioFallbackUrl()
        {
            return this._audioFallbackUrl != null;
        }

        /// <summary>
        /// Gets and sets the property AudioHostUrl. 
        /// <para>
        /// The audio host URL.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string AudioHostUrl
        {
            get { return this._audioHostUrl; }
            set { this._audioHostUrl = value; }
        }

        // Check to see if AudioHostUrl property is set
        internal bool IsSetAudioHostUrl()
        {
            return this._audioHostUrl != null;
        }

        /// <summary>
        /// Gets and sets the property EventIngestionUrl. 
        /// <para>
        /// The event ingestion URL.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string EventIngestionUrl
        {
            get { return this._eventIngestionUrl; }
            set { this._eventIngestionUrl = value; }
        }

        // Check to see if EventIngestionUrl property is set
        internal bool IsSetEventIngestionUrl()
        {
            return this._eventIngestionUrl != null;
        }

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
        [AWSProperty(Max=4096)]
        public string ScreenDataUrl
        {
            get { return this._screenDataUrl; }
            set { this._screenDataUrl = value; }
        }

        // Check to see if ScreenDataUrl property is set
        internal bool IsSetScreenDataUrl()
        {
            return this._screenDataUrl != null;
        }

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
        [AWSProperty(Max=4096)]
        public string ScreenSharingUrl
        {
            get { return this._screenSharingUrl; }
            set { this._screenSharingUrl = value; }
        }

        // Check to see if ScreenSharingUrl property is set
        internal bool IsSetScreenSharingUrl()
        {
            return this._screenSharingUrl != null;
        }

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
        [AWSProperty(Max=4096)]
        public string ScreenViewingUrl
        {
            get { return this._screenViewingUrl; }
            set { this._screenViewingUrl = value; }
        }

        // Check to see if ScreenViewingUrl property is set
        internal bool IsSetScreenViewingUrl()
        {
            return this._screenViewingUrl != null;
        }

        /// <summary>
        /// Gets and sets the property SignalingUrl. 
        /// <para>
        /// The signaling URL.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string SignalingUrl
        {
            get { return this._signalingUrl; }
            set { this._signalingUrl = value; }
        }

        // Check to see if SignalingUrl property is set
        internal bool IsSetSignalingUrl()
        {
            return this._signalingUrl != null;
        }

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
        [AWSProperty(Max=4096)]
        public string TurnControlUrl
        {
            get { return this._turnControlUrl; }
            set { this._turnControlUrl = value; }
        }

        // Check to see if TurnControlUrl property is set
        internal bool IsSetTurnControlUrl()
        {
            return this._turnControlUrl != null;
        }

    }
}