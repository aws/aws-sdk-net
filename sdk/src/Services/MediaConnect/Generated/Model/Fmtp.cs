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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// A set of parameters that define the media stream.
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
        /// Gets and sets the property ChannelOrder. 
        /// <para>
        ///  The format of the audio channel. 
        /// </para>
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
        /// Gets and sets the property Colorimetry. 
        /// <para>
        /// The format used for the representation of color. 
        /// </para>
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
        /// Gets and sets the property ExactFramerate. 
        /// <para>
        /// The frame rate for the video stream, in frames/second. For example: 60000/1001. 
        /// </para>
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
        /// Gets and sets the property Par. 
        /// <para>
        /// The pixel aspect ratio (PAR) of the video. 
        /// </para>
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
        /// Gets and sets the property Range. 
        /// <para>
        /// The encoding range of the video. 
        /// </para>
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
        /// Gets and sets the property ScanMode. 
        /// <para>
        /// The type of compression that was used to smooth the video’s appearance. 
        /// </para>
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
        /// Gets and sets the property Tcs. 
        /// <para>
        /// The transfer characteristic system (TCS) that is used in the video. 
        /// </para>
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