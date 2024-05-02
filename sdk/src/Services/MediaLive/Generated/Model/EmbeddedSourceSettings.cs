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
    /// Embedded Source Settings
    /// </summary>
    public partial class EmbeddedSourceSettings
    {
        private EmbeddedConvert608To708 _convert608To708;
        private EmbeddedScte20Detection _scte20Detection;
        private int? _source608ChannelNumber;
        private int? _source608TrackNumber;

        /// <summary>
        /// Gets and sets the property Convert608To708. If upconvert, 608 data is both passed
        /// through via the "608 compatibility bytes" fields of the 708 wrapper as well as translated
        /// into 708. 708 data present in the source content will be discarded.
        /// </summary>
        public EmbeddedConvert608To708 Convert608To708
        {
            get { return this._convert608To708; }
            set { this._convert608To708 = value; }
        }

        // Check to see if Convert608To708 property is set
        internal bool IsSetConvert608To708()
        {
            return this._convert608To708 != null;
        }

        /// <summary>
        /// Gets and sets the property Scte20Detection. Set to "auto" to handle streams with intermittent
        /// and/or non-aligned SCTE-20 and Embedded captions.
        /// </summary>
        public EmbeddedScte20Detection Scte20Detection
        {
            get { return this._scte20Detection; }
            set { this._scte20Detection = value; }
        }

        // Check to see if Scte20Detection property is set
        internal bool IsSetScte20Detection()
        {
            return this._scte20Detection != null;
        }

        /// <summary>
        /// Gets and sets the property Source608ChannelNumber. Specifies the 608/708 channel number
        /// within the video track from which to extract captions. Unused for passthrough.
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public int? Source608ChannelNumber
        {
            get { return this._source608ChannelNumber; }
            set { this._source608ChannelNumber = value; }
        }

        // Check to see if Source608ChannelNumber property is set
        internal bool IsSetSource608ChannelNumber()
        {
            return this._source608ChannelNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Source608TrackNumber. This field is unused and deprecated.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public int? Source608TrackNumber
        {
            get { return this._source608TrackNumber; }
            set { this._source608TrackNumber = value; }
        }

        // Check to see if Source608TrackNumber property is set
        internal bool IsSetSource608TrackNumber()
        {
            return this._source608TrackNumber.HasValue; 
        }

    }
}