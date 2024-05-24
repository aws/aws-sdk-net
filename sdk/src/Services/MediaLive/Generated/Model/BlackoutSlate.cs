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
    /// Blackout Slate
    /// </summary>
    public partial class BlackoutSlate
    {
        private InputLocation _blackoutSlateImage;
        private BlackoutSlateNetworkEndBlackout _networkEndBlackout;
        private InputLocation _networkEndBlackoutImage;
        private string _networkId;
        private BlackoutSlateState _state;

        /// <summary>
        /// Gets and sets the property BlackoutSlateImage. Blackout slate image to be used. Leave
        /// empty for solid black. Only bmp and png images are supported.
        /// </summary>
        public InputLocation BlackoutSlateImage
        {
            get { return this._blackoutSlateImage; }
            set { this._blackoutSlateImage = value; }
        }

        // Check to see if BlackoutSlateImage property is set
        internal bool IsSetBlackoutSlateImage()
        {
            return this._blackoutSlateImage != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkEndBlackout. Setting to enabled causes the encoder
        /// to blackout the video, audio, and captions, and raise the "Network Blackout Image"
        /// slate when an SCTE104/35 Network End Segmentation Descriptor is encountered. The blackout
        /// will be lifted when the Network Start Segmentation Descriptor is encountered. The
        /// Network End and Network Start descriptors must contain a network ID that matches the
        /// value entered in "Network ID".
        /// </summary>
        public BlackoutSlateNetworkEndBlackout NetworkEndBlackout
        {
            get { return this._networkEndBlackout; }
            set { this._networkEndBlackout = value; }
        }

        // Check to see if NetworkEndBlackout property is set
        internal bool IsSetNetworkEndBlackout()
        {
            return this._networkEndBlackout != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkEndBlackoutImage. Path to local file to use as Network
        /// End Blackout image. Image will be scaled to fill the entire output raster.
        /// </summary>
        public InputLocation NetworkEndBlackoutImage
        {
            get { return this._networkEndBlackoutImage; }
            set { this._networkEndBlackoutImage = value; }
        }

        // Check to see if NetworkEndBlackoutImage property is set
        internal bool IsSetNetworkEndBlackoutImage()
        {
            return this._networkEndBlackoutImage != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkId. Provides Network ID that matches EIDR ID format
        /// (e.g., "10.XXXX/XXXX-XXXX-XXXX-XXXX-XXXX-C").
        /// </summary>
        [AWSProperty(Min=34, Max=34)]
        public string NetworkId
        {
            get { return this._networkId; }
            set { this._networkId = value; }
        }

        // Check to see if NetworkId property is set
        internal bool IsSetNetworkId()
        {
            return this._networkId != null;
        }

        /// <summary>
        /// Gets and sets the property State. When set to enabled, causes video, audio and captions
        /// to be blanked when indicated by program metadata.
        /// </summary>
        public BlackoutSlateState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}