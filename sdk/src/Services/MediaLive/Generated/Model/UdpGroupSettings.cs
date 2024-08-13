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
    /// Udp Group Settings
    /// </summary>
    public partial class UdpGroupSettings
    {
        private InputLossActionForUdpOut _inputLossAction;
        private UdpTimedMetadataId3Frame _timedMetadataId3Frame;
        private int? _timedMetadataId3Period;

        /// <summary>
        /// Gets and sets the property InputLossAction. Specifies behavior of last resort when
        /// input video is lost, and no more backup inputs are available. When dropTs is selected
        /// the entire transport stream will stop being emitted.  When dropProgram is selected
        /// the program can be dropped from the transport stream (and replaced with null packets
        /// to meet the TS bitrate requirement).  Or, when emitProgram is chosen the transport
        /// stream will continue to be produced normally with repeat frames, black frames, or
        /// slate frames substituted for the absent input video.
        /// </summary>
        public InputLossActionForUdpOut InputLossAction
        {
            get { return this._inputLossAction; }
            set { this._inputLossAction = value; }
        }

        // Check to see if InputLossAction property is set
        internal bool IsSetInputLossAction()
        {
            return this._inputLossAction != null;
        }

        /// <summary>
        /// Gets and sets the property TimedMetadataId3Frame. Indicates ID3 frame that has the
        /// timecode.
        /// </summary>
        public UdpTimedMetadataId3Frame TimedMetadataId3Frame
        {
            get { return this._timedMetadataId3Frame; }
            set { this._timedMetadataId3Frame = value; }
        }

        // Check to see if TimedMetadataId3Frame property is set
        internal bool IsSetTimedMetadataId3Frame()
        {
            return this._timedMetadataId3Frame != null;
        }

        /// <summary>
        /// Gets and sets the property TimedMetadataId3Period. Timed Metadata interval in seconds.
        /// </summary>
        [AWSProperty(Min=0)]
        public int? TimedMetadataId3Period
        {
            get { return this._timedMetadataId3Period; }
            set { this._timedMetadataId3Period = value; }
        }

        // Check to see if TimedMetadataId3Period property is set
        internal bool IsSetTimedMetadataId3Period()
        {
            return this._timedMetadataId3Period.HasValue; 
        }

    }
}