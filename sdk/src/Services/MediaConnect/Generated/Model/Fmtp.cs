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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// FMTP
    /// </summary>
    public partial class Fmtp
    {
        private string _channelOrder;
        private Colorimetry _colorimetry;
        private string _exactFramerate;
        private string _par;
        private Range _range;
        private ScanMode _scanMode;
        private Tcs _tcs;

        /// <summary>
        /// Gets and sets the property ChannelOrder. The format of the audio channel.
        /// </summary>
        public string ChannelOrder
        {
            get { return this._channelOrder; }
            set { this._channelOrder = value; }
        }

        // Check to see if ChannelOrder property is set
        internal bool IsSetChannelOrder()
        {
            return this._channelOrder != null;
        }

        /// <summary>
        /// Gets and sets the property Colorimetry. The format that is used for the representation
        /// of color.
        /// </summary>
        public Colorimetry Colorimetry
        {
            get { return this._colorimetry; }
            set { this._colorimetry = value; }
        }

        // Check to see if Colorimetry property is set
        internal bool IsSetColorimetry()
        {
            return this._colorimetry != null;
        }

        /// <summary>
        /// Gets and sets the property ExactFramerate. The frame rate for the video stream, in
        /// frames/second. For example: 60000/1001. If you specify a whole number, MediaConnect
        /// uses a ratio of N/1. For example, if you specify 60, MediaConnect uses 60/1 as the
        /// exactFramerate.
        /// </summary>
        public string ExactFramerate
        {
            get { return this._exactFramerate; }
            set { this._exactFramerate = value; }
        }

        // Check to see if ExactFramerate property is set
        internal bool IsSetExactFramerate()
        {
            return this._exactFramerate != null;
        }

        /// <summary>
        /// Gets and sets the property Par. The pixel aspect ratio (PAR) of the video.
        /// </summary>
        public string Par
        {
            get { return this._par; }
            set { this._par = value; }
        }

        // Check to see if Par property is set
        internal bool IsSetPar()
        {
            return this._par != null;
        }

        /// <summary>
        /// Gets and sets the property Range. The encoding range of the video.
        /// </summary>
        public Range Range
        {
            get { return this._range; }
            set { this._range = value; }
        }

        // Check to see if Range property is set
        internal bool IsSetRange()
        {
            return this._range != null;
        }

        /// <summary>
        /// Gets and sets the property ScanMode. The type of compression that was used to smooth
        /// the video’s appearance
        /// </summary>
        public ScanMode ScanMode
        {
            get { return this._scanMode; }
            set { this._scanMode = value; }
        }

        // Check to see if ScanMode property is set
        internal bool IsSetScanMode()
        {
            return this._scanMode != null;
        }

        /// <summary>
        /// Gets and sets the property Tcs. The transfer characteristic system (TCS) that is used
        /// in the video.
        /// </summary>
        public Tcs Tcs
        {
            get { return this._tcs; }
            set { this._tcs = value; }
        }

        // Check to see if Tcs property is set
        internal bool IsSetTcs()
        {
            return this._tcs != null;
        }

    }
}