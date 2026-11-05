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
    /// Blackout Slate
    /// </summary>
    public partial class BlackoutSlate
    {
        /// <summary>
        /// Gets and sets the property BlackoutSlateImage. Blackout slate image to be used. Leave
        /// empty for solid black. Only bmp and png images are supported.
        /// </summary>
        public InputLocation BlackoutSlateImage { get; set; }

        /// <summary>
        /// Checks to see if the BlackoutSlateImage property is set.
        /// </summary>
        internal bool IsSetBlackoutSlateImage() => this.BlackoutSlateImage != null;

        /// <summary>
        /// Gets and sets the property NetworkEndBlackout. Setting to enabled causes the encoder
        /// to blackout the video, audio, and captions, and raise the "Network Blackout Image"
        /// slate when an SCTE104/35 Network End Segmentation Descriptor is encountered. The blackout
        /// will be lifted when the Network Start Segmentation Descriptor is encountered. The
        /// Network End and Network Start descriptors must contain a network ID that matches the
        /// value entered in "Network ID".
        /// </summary>
        public BlackoutSlateNetworkEndBlackout NetworkEndBlackout { get; set; }

        /// <summary>
        /// Checks to see if the NetworkEndBlackout property is set.
        /// </summary>
        internal bool IsSetNetworkEndBlackout() => this.NetworkEndBlackout != null;

        /// <summary>
        /// Gets and sets the property NetworkEndBlackoutImage. Path to local file to use as Network
        /// End Blackout image. Image will be scaled to fill the entire output raster.
        /// </summary>
        public InputLocation NetworkEndBlackoutImage { get; set; }

        /// <summary>
        /// Checks to see if the NetworkEndBlackoutImage property is set.
        /// </summary>
        internal bool IsSetNetworkEndBlackoutImage() => this.NetworkEndBlackoutImage != null;

        /// <summary>
        /// Gets and sets the property NetworkId. Provides Network ID that matches EIDR ID format
        /// (e.g., "10.XXXX/XXXX-XXXX-XXXX-XXXX-XXXX-C").
        /// </summary>
        public string NetworkId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkId property is set.
        /// </summary>
        internal bool IsSetNetworkId() => this.NetworkId != null;

        /// <summary>
        /// Gets and sets the property State. When set to enabled, causes video, audio and captions
        /// to be blanked when indicated by program metadata.
        /// </summary>
        public BlackoutSlateState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
